using System;
using System.Diagnostics;
using System.Windows.Forms;
using WixSharp;
using WixSharp.Controls;
using WixSharp.UI;
using WixSharp.UI.Forms;
using WixToolset.Dtf.WindowsInstaller;

namespace WixSharpSetup
{
    public partial class ShortcutDialog : ManagedForm, IManagedDialog
    {
        public ShortcutDialog()
        {
            //NOTE: If this assembly is compiled for v4.0.30319 runtime, it may not be compatible with the MSI hosted CLR.
            //The incompatibility is particularly possible for the Embedded UI scenarios. 
            //The safest way to avoid the problem is to compile the assembly for v3.5 Target Framework.WixSharp Setup
            InitializeComponent();
            
        }

        void dialog_Load(object sender, EventArgs e)
        {
            banner.Image = Runtime.Session.GetResourceBitmap("WixUI_Bmp_Banner");
            Text = "[ProductName] Setup";

            base.Localize();
            ResetLayout();
        }

        private void ResetLayout()
        {
            float num = (float)banner.Image.Width / (float)banner.Image.Height;
            panel1.Height = (int)((float)banner.Height*1.25);
        }

        void back_Click(object sender, EventArgs e)
        {
            MsiRuntime.MsiSession.SetProperty("INSTALLDESKTOPSHORTCUT", "False");
            MsiRuntime.MsiSession.SetProperty("INSTALLMENUSHORTCUT", "False");
            Shell.GoPrev();
        }

        void next_Click(object sender, EventArgs e)
        {
            Shell.GoNext();
            
        }

        void cancel_Click(object sender, EventArgs e)
        {
            Shell.Cancel();
        }

        //Добавленив на рабочий стол
        private void AddDesktopShortcutChrckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bool isDesktopAdd = AddDesktopShortcutChrckBox.Checked;
                MsiRuntime.MsiSession.SetProperty("INSTALLDESKTOPSHORTCUT", isDesktopAdd.ToString());
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        //Добавление в меню пуск
        private void AddMenuShortcutChrckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                bool isMenuAdd = AddMenuShortcutChrckBox.Checked;
                MsiRuntime.MsiSession.SetProperty("INSTALLMENUSHORTCUT", isMenuAdd.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        //Добавления в автозапуск
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MsiRuntime.MsiSession.SetProperty("ADDINSTARTUPSHOTCUT", addInStartupCheckBox.Checked.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}