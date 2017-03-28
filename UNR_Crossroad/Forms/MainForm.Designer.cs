using System.Windows.Forms;
using UNR_Crossroad.Core;

namespace UNR_Crossroad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выНеВошлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_user_dop = new System.Windows.Forms.Panel();
            this.btn_ch_road = new System.Windows.Forms.Button();
            this.panel_user = new UNR_Crossroad.BufferedPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_user_dop.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 510);
            this.tabControl1.TabIndex = 2;
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
            this.panel_user_dop.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel_user_dop.Controls.Add(this.btn_ch_road);
            this.panel_user_dop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_user_dop.Location = new System.Drawing.Point(930, 6);
            this.panel_user_dop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel_user_dop.Name = "panel_user_dop";
            this.panel_user_dop.Size = new System.Drawing.Size(180, 457);
            this.panel_user_dop.TabIndex = 0;
            // 
            // btn_ch_road
            // 
            this.btn_ch_road.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ch_road.Location = new System.Drawing.Point(0, 0);
            this.btn_ch_road.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_ch_road.Name = "btn_ch_road";
            this.btn_ch_road.Size = new System.Drawing.Size(180, 82);
            this.btn_ch_road.TabIndex = 0;
            this.btn_ch_road.Text = "СТАРТУЕМ ЕПТА";
            this.btn_ch_road.UseVisualStyleBackColor = true;
            this.btn_ch_road.Click += new System.EventHandler(this.btn_ch_road_Click);
            // 
            // panel_user
            // 
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_user.Location = new System.Drawing.Point(3, 3);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(921, 463);
            this.panel_user.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_user_dop.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem входToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_user_dop;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_ch_road;
        private ToolStripMenuItem входToolStripMenuItem1;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private ToolStripMenuItem выНеВошлиToolStripMenuItem;
        private BufferedPanel panel_user;
    }
}