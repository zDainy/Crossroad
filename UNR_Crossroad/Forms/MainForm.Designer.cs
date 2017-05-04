using System.Windows.Forms;

namespace UNR_Crossroad.Forms
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выНеВошлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_user_dop = new System.Windows.Forms.Panel();
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.tbCur = new System.Windows.Forms.TextBox();
            this.tbAll = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCtrl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBoxRoad = new System.Windows.Forms.GroupBox();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.labelUserAuth = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCpm = new System.Windows.Forms.TextBox();
            this.panel_user = new UNR_Crossroad.BufferedPanel();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_user_dop.SuspendLayout();
            this.groupBoxStat.SuspendLayout();
            this.groupBoxCtrl.SuspendLayout();
            this.panelAuth.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem1,
            this.регистрацияToolStripMenuItem,
            this.выНеВошлиToolStripMenuItem});
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.входToolStripMenuItem.Text = "Учетная запись";
            // 
            // входToolStripMenuItem1
            // 
            this.входToolStripMenuItem1.Name = "входToolStripMenuItem1";
            this.входToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.входToolStripMenuItem1.Text = "Вход";
            this.входToolStripMenuItem1.Click += new System.EventHandler(this.входToolStripMenuItem1_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // выНеВошлиToolStripMenuItem
            // 
            this.выНеВошлиToolStripMenuItem.Enabled = false;
            this.выНеВошлиToolStripMenuItem.Name = "выНеВошлиToolStripMenuItem";
            this.выНеВошлиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.выНеВошлиToolStripMenuItem.Text = "Вы не вошли";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1127, 510);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Size = new System.Drawing.Size(1119, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.panel_user_dop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_user, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_user_dop
            // 
            this.panel_user_dop.BackColor = System.Drawing.Color.Transparent;
            this.panel_user_dop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_user_dop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_user_dop.Controls.Add(this.groupBoxStat);
            this.panel_user_dop.Controls.Add(this.groupBoxCtrl);
            this.panel_user_dop.Controls.Add(this.groupBoxRoad);
            this.panel_user_dop.Controls.Add(this.panelAuth);
            this.panel_user_dop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_user_dop.Location = new System.Drawing.Point(930, 6);
            this.panel_user_dop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel_user_dop.Name = "panel_user_dop";
            this.panel_user_dop.Size = new System.Drawing.Size(180, 457);
            this.panel_user_dop.TabIndex = 0;
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStat.Controls.Add(this.tbCpm);
            this.groupBoxStat.Controls.Add(this.tbCur);
            this.groupBoxStat.Controls.Add(this.tbAll);
            this.groupBoxStat.Controls.Add(this.tbTime);
            this.groupBoxStat.Controls.Add(this.textBox1);
            this.groupBoxStat.Controls.Add(this.label1);
            this.groupBoxStat.Controls.Add(this.label4);
            this.groupBoxStat.Controls.Add(this.label2);
            this.groupBoxStat.Controls.Add(this.label3);
            this.groupBoxStat.Location = new System.Drawing.Point(0, 149);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Size = new System.Drawing.Size(180, 147);
            this.groupBoxStat.TabIndex = 1;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "Статистика";
            // 
            // tbCur
            // 
            this.tbCur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbCur.Enabled = false;
            this.tbCur.Location = new System.Drawing.Point(133, 25);
            this.tbCur.Name = "tbCur";
            this.tbCur.Size = new System.Drawing.Size(41, 23);
            this.tbCur.TabIndex = 2;
            this.tbCur.Text = "0";
            this.tbCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAll
            // 
            this.tbAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbAll.Enabled = false;
            this.tbAll.Location = new System.Drawing.Point(133, 54);
            this.tbAll.Name = "tbAll";
            this.tbAll.Size = new System.Drawing.Size(41, 23);
            this.tbAll.TabIndex = 1;
            this.tbAll.Text = "0";
            this.tbAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(155, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Машин всего : ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "На перекрестке : ";
            // 
            // groupBoxCtrl
            // 
            this.groupBoxCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCtrl.Controls.Add(this.button1);
            this.groupBoxCtrl.Controls.Add(this.btn_stop);
            this.groupBoxCtrl.Controls.Add(this.btn_start);
            this.groupBoxCtrl.Location = new System.Drawing.Point(0, 302);
            this.groupBoxCtrl.Name = "groupBoxCtrl";
            this.groupBoxCtrl.Size = new System.Drawing.Size(180, 154);
            this.groupBoxCtrl.TabIndex = 1;
            this.groupBoxCtrl.TabStop = false;
            this.groupBoxCtrl.Text = "Управление";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(30, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_stop.Location = new System.Drawing.Point(30, 70);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(120, 30);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Приостановить";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_start.Location = new System.Drawing.Point(30, 30);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 30);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Запустить";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_ch_road_Click);
            // 
            // groupBoxRoad
            // 
            this.groupBoxRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRoad.Location = new System.Drawing.Point(0, 26);
            this.groupBoxRoad.Name = "groupBoxRoad";
            this.groupBoxRoad.Size = new System.Drawing.Size(180, 117);
            this.groupBoxRoad.TabIndex = 0;
            this.groupBoxRoad.TabStop = false;
            this.groupBoxRoad.Text = "Дорога";
            // 
            // panelAuth
            // 
            this.panelAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuth.Controls.Add(this.labelUserAuth);
            this.panelAuth.Location = new System.Drawing.Point(-1, -1);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(180, 21);
            this.panelAuth.TabIndex = 1;
            // 
            // labelUserAuth
            // 
            this.labelUserAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUserAuth.Location = new System.Drawing.Point(0, 0);
            this.labelUserAuth.Name = "labelUserAuth";
            this.labelUserAuth.Size = new System.Drawing.Size(178, 17);
            this.labelUserAuth.TabIndex = 2;
            this.labelUserAuth.Text = "Вы не вошли";
            this.labelUserAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserAuth.Click += new System.EventHandler(this.входToolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage2.Size = new System.Drawing.Size(1119, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Администратор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.8961F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.1039F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.86762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.13238F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(831, 678);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время работы : ";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbTime.Enabled = false;
            this.tbTime.Location = new System.Drawing.Point(133, 83);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(41, 23);
            this.tbTime.TabIndex = 3;
            this.tbTime.Text = "0  c";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Машин в минуту : ";
            // 
            // tbCpm
            // 
            this.tbCpm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbCpm.Enabled = false;
            this.tbCpm.Location = new System.Drawing.Point(133, 112);
            this.tbCpm.Name = "tbCpm";
            this.tbCpm.Size = new System.Drawing.Size(41, 23);
            this.tbCpm.TabIndex = 4;
            this.tbCpm.Text = "0";
            this.tbCpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_user
            // 
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_user.Location = new System.Drawing.Point(3, 3);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(921, 463);
            this.panel_user.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 534);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_user_dop.ResumeLayout(false);
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            this.groupBoxCtrl.ResumeLayout(false);
            this.panelAuth.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem входToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_user_dop;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_start;
        private ToolStripMenuItem входToolStripMenuItem1;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private ToolStripMenuItem выНеВошлиToolStripMenuItem;
        private BufferedPanel panel_user;
        private Label labelUserAuth;
        private Panel panelAuth;
        private GroupBox groupBoxRoad;
        private GroupBox groupBoxCtrl;
        private Button btn_stop;
        private Button button1;
        private Label label1;
        private GroupBox groupBoxStat;
        private Label label2;
        private TextBox textBox1;
        private TextBox tbCur;
        private TextBox tbAll;
        private TextBox tbTime;
        private Label label3;
        private TextBox tbCpm;
        private Label label4;
    }
}