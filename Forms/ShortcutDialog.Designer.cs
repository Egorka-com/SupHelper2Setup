using System.Drawing;
using System.Windows.Forms;

namespace WixSharpSetup
{
    partial class ShortcutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.banner = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.AddDesktopShortcutChrckBox = new System.Windows.Forms.CheckBox();
            this.AddMenuShortcutChrckBox = new System.Windows.Forms.CheckBox();
            this.addInStartupCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.BackColor = System.Drawing.Color.White;
            this.banner.Location = new System.Drawing.Point(28, -1);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(494, 98);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.banner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 100);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите то, что вам нужно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дополнительные настройки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 60);
            this.panel1.TabIndex = 9;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(161, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 35);
            this.back.TabIndex = 0;
            this.back.Text = "[WixUIBack]";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(253, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(95, 35);
            this.next.TabIndex = 0;
            this.next.Text = "[WixUINext]";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(357, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(139, 35);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "[WixUICancel]";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddDesktopShortcutChrckBox
            // 
            this.AddDesktopShortcutChrckBox.AutoSize = true;
            this.AddDesktopShortcutChrckBox.Location = new System.Drawing.Point(22, 130);
            this.AddDesktopShortcutChrckBox.Name = "AddDesktopShortcutChrckBox";
            this.AddDesktopShortcutChrckBox.Size = new System.Drawing.Size(343, 28);
            this.AddDesktopShortcutChrckBox.TabIndex = 11;
            this.AddDesktopShortcutChrckBox.Text = "Добавить ярлык на рабочий стол";
            this.AddDesktopShortcutChrckBox.UseVisualStyleBackColor = true;
            this.AddDesktopShortcutChrckBox.CheckedChanged += new System.EventHandler(this.AddDesktopShortcutChrckBox_CheckedChanged);
            // 
            // AddMenuShortcutChrckBox
            // 
            this.AddMenuShortcutChrckBox.AutoSize = true;
            this.AddMenuShortcutChrckBox.Location = new System.Drawing.Point(22, 189);
            this.AddMenuShortcutChrckBox.Name = "AddMenuShortcutChrckBox";
            this.AddMenuShortcutChrckBox.Size = new System.Drawing.Size(323, 28);
            this.AddMenuShortcutChrckBox.TabIndex = 12;
            this.AddMenuShortcutChrckBox.Text = "Добавить ярлык в меню \"Пуск\"";
            this.AddMenuShortcutChrckBox.UseVisualStyleBackColor = true;
            this.AddMenuShortcutChrckBox.CheckedChanged += new System.EventHandler(this.AddMenuShortcutChrckBox_CheckedChanged);
            // 
            // addInStartupCheckBox
            // 
            this.addInStartupCheckBox.AutoSize = true;
            this.addInStartupCheckBox.Location = new System.Drawing.Point(22, 249);
            this.addInStartupCheckBox.Name = "addInStartupCheckBox";
            this.addInStartupCheckBox.Size = new System.Drawing.Size(246, 28);
            this.addInStartupCheckBox.TabIndex = 13;
            this.addInStartupCheckBox.Text = "Добавить в автозапуск";
            this.addInStartupCheckBox.UseVisualStyleBackColor = true;
            this.addInStartupCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ShortcutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 429);
            this.Controls.Add(this.addInStartupCheckBox);
            this.Controls.Add(this.AddMenuShortcutChrckBox);
            this.Controls.Add(this.AddDesktopShortcutChrckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShortcutDialog";
            this.Text = "[UserNameDlg_Title]";
            this.Load += new System.EventHandler(this.dialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.CheckBox AddDesktopShortcutChrckBox;
        private System.Windows.Forms.CheckBox AddMenuShortcutChrckBox;
        private CheckBox addInStartupCheckBox;
    }
}