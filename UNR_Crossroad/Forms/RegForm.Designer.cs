using System.Windows.Forms;
using UNR_Crossroad.Core;

namespace UNR_Crossroad.Forms
{
    partial class RegForm
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
            this.lb_error = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lb_lvl = new System.Windows.Forms.Label();
            this.bt_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_error
            // 
            this.lb_error.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(38, 96);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(214, 18);
            this.lb_error.TabIndex = 11;
            this.lb_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(146, 43);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(126, 25);
            this.tb_pass.TabIndex = 10;
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(146, 15);
            this.tb_user.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(126, 25);
            this.tb_user.TabIndex = 9;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pass.Location = new System.Drawing.Point(20, 43);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(56, 18);
            this.lb_pass.TabIndex = 8;
            this.lb_pass.Text = "Пароль";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(20, 15);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(47, 18);
            this.lb_login.TabIndex = 7;
            this.lb_login.Text = "Логин";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            UNR_Crossroad.Core.AccLevel.Player,
            UNR_Crossroad.Core.AccLevel.Admin});
            this.comboBox.Location = new System.Drawing.Point(146, 70);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(126, 26);
            this.comboBox.TabIndex = 12;
            // 
            // lb_lvl
            // 
            this.lb_lvl.AutoSize = true;
            this.lb_lvl.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_lvl.Location = new System.Drawing.Point(20, 70);
            this.lb_lvl.Name = "lb_lvl";
            this.lb_lvl.Size = new System.Drawing.Size(58, 18);
            this.lb_lvl.TabIndex = 13;
            this.lb_lvl.Text = "Доступ";
            // 
            // bt_enter
            // 
            this.bt_enter.Location = new System.Drawing.Point(96, 117);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(85, 27);
            this.bt_enter.TabIndex = 14;
            this.bt_enter.Text = "Создать";
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.bt_enter);
            this.Controls.Add(this.lb_lvl);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_login);
            this.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lb_lvl;
        private System.Windows.Forms.Button bt_enter;
    }
}