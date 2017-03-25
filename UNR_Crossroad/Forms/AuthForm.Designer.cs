namespace UNR_Crossroad.Forms
{
    partial class AuthForm
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
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bt_enter = new System.Windows.Forms.Button();
            this.bt_reg = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(9, 20);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(47, 18);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Логин";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pass.Location = new System.Drawing.Point(9, 48);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(56, 18);
            this.lb_pass.TabIndex = 1;
            this.lb_pass.Text = "Пароль";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(88, 17);
            this.tb_user.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(138, 25);
            this.tb_user.TabIndex = 2;
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(88, 45);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(138, 25);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_enter
            // 
            this.bt_enter.Location = new System.Drawing.Point(141, 94);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(85, 27);
            this.bt_enter.TabIndex = 4;
            this.bt_enter.Text = "Войти";
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.Bt_enter_Click);
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(12, 94);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(110, 27);
            this.bt_reg.TabIndex = 5;
            this.bt_reg.Text = "Регистрация";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // lb_error
            // 
            this.lb_error.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(12, 73);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(214, 18);
            this.lb_error.TabIndex = 6;
            this.lb_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 131);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.bt_enter);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_login);
            this.Font = new System.Drawing.Font("Myriad Pro", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма входа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.Button bt_reg;
        private System.Windows.Forms.Label lb_error;
    }
}