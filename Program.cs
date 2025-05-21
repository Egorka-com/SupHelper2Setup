using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WixSharp;
using WixSharp.CommonTasks;
using WixSharp.UI.Forms;
using WixSharpSetup;
using File = WixSharp.File;
using Microsoft.Win32;
using RegistryHive = WixSharp.RegistryHive;



namespace Wix4Setup
{
    public class Program
    {
        static void Main()
        {
            //Заугрзка конфига
            AppConfig.LoadConfig();
            var project = new ManagedProject(AppConfig.ProductName);

            project.Language = AppConfig.Language;
            project.GUID = AppConfig.Guid;
            //Выбор установки только для текущего пользователя, чтобы не требовались прва админа
            project.Scope = InstallScope.perUser;
            project.LicenceFile = "License.rtf";
            project.Version = new System.Version(AppConfig.ProductVersion);
            project.ControlPanelInfo.Manufacturer = AppConfig.Author;
            project.ControlPanelInfo.ProductIcon = "icon.ico";


            AddApplicationFiles(project);
            AddCustomUI(project);
            AddPropperties(project);
            AddRegistryEntries(project);

            Compiler.BuildMsi(project, $@".\output\Release\{AppConfig.ProductName}Setup.msi");
        }

        //------------------------------------------------------------------------
        // 1. Добавление файлов и ярлыков 
        static void AddApplicationFiles(Project project)
        {
            //Папка утсановки на устройстве
            var TargetDir = new InstallDir($@"%AppData%\{AppConfig.TargetDir}",
                //Установка всех файлов из папки, куда билдится проект
                new Files($@"{AppConfig.AppDir}\*.*"),
                //Создание ярлвка на раб стол
                new Dir(@"%Desktop%",
                    new ExeFileShortcut(AppConfig.ProductName, $"[INSTALLDIR]{AppConfig.MainFile}", arguments:""){Condition = new Condition("INSTALLDESKTOPSHORTCUT=\"True\"")}
                ),
                //Установка в меню Пуск
                new Dir($@"%ProgramMenu%",
                    new ExeFileShortcut(AppConfig.ProductName, $"[INSTALLDIR]{AppConfig.MainFile}", arguments:""){Condition = new Condition("INSTALLMENUSHORTCUT=\"True\"")}
                ),
                //Установка в автозапуск
                new Dir("%Startup%",
                new ExeFileShortcut(AppConfig.ProductName, $"[INSTALLDIR]{AppConfig.MainFile}", arguments: "") { Condition = new Condition("ADDINSTARTUPSHOTCUT=\"True\"") })
            )
            {Permissions = new []
                    {
                        new DirPermission("Users",GenericPermission.All) {ChangePermission = true}
                    }};

            project.Dirs = new[] { TargetDir };
        }

        //------------------------------------------------------------------------
        //2. Добавляем UI
        static void AddCustomUI(ManagedProject project)
        {
            project.ManagedUI = new ManagedUI();
            project.ManagedUI.InstallDialogs.Add<WelcomeDialog>()
                                            .Add<LicenceDialog>()
                                            //Кастомный диалог
                                            .Add<ShortcutDialog>()
                                            .Add<InstallDirDialog>()
                                            .Add<ProgressDialog>()
                                            .Add<ExitDialog>();
            project.ManagedUI.Icon = "icon.ico";
        }

        //------------------------------------------------------------------------
        // 3. Запись в реестр
        static void AddRegistryEntries(Project project)
        {
            project.RegValues = new[]
            {
            new RegValue(WixSharp.RegistryHive.CurrentUser,
                         $@"Software\{AppConfig.Author}\{AppConfig.ProductName}",
                         "InstallPath",
                         "[INSTALLDIR]")
        };
        }

        //------------------------------------------------------------------------
        // 4. Переменные окружения
        static void AddEnvironmentVariables(Project project)
        {
            //Если нцжны какме-то перменные среды, но я не юзаю
            project.Add(new EnvironmentVariable("", "[INSTALLDIR]"));
            project.Add(new EnvironmentVariable("", "[INSTALLDIR]"));
            project.Add(new EnvironmentVariable("", "[INSTALLDIR]"));
            project.Add(new EnvironmentVariable("", "[INSTALLDIR]"));
            project.Add(new EnvironmentVariable("", "[INSTALLDIR]"));
        }

        static void AddPropperties(Project project)
        {
            //Добавления свойств для провреки требования установки доп  функций (ярлыки и тд)
            project.AddProperty(new Property("INSTALLDESKTOPSHORTCUT", "False"));
            project.AddProperty(new Property("INSTALLMENUSHORTCUT", "False"));
            project.AddProperty(new Property("ADDINSTARTUPSHOTCUT", "False"));
        }


        // хотел сделать окно для провреки и утсановки рантайма, но оно не работает)
        static void ShowDotnetMissingDialog()
        {
            DialogResult result = MessageBox.Show(
                "Для работы приложения требуется .NET 8 Runtime.\nПерейти на страницу установки?",
                ".NET не найден",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dotnet.microsoft.com/en-us/download/dotnet/8.0/runtime",
                    UseShellExecute = true
                });
            }
        }

        public static bool IsDotNet8Installed()
        {
            const string keyPath = @"SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost";
            const string valueName = "Version";

            using (var key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                var version = key?.GetValue(valueName)?.ToString();
                return version != null && version.StartsWith("8.");
            }
        }

        public void UpdateVersionCinfig()
        {

        }
    }
}