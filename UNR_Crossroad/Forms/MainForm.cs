using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UNR_Crossroad.Core;
using UNR_Crossroad.Forms;

namespace UNR_Crossroad
{
    public partial class MainForm : Form
    {
        private User myUser;

        public MainForm()
        {
            InitializeComponent();
            panel_user.Paint += Engine.RenderMap;
        }


        private void btn_ch_road_Click(object sender, EventArgs e)
        {
            Engine.Start(panel_user);
        }


        #region Верхнее меню
        private void входToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var auth = new AuthForm();
            if (auth.ShowDialog() == DialogResult.OK)
            {
                myUser = auth.GetUser();
                выНеВошлиToolStripMenuItem.Text = "Вы вошли как " + myUser.Level;
            }
        }
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegForm().ShowDialog();
        }
        #endregion
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Engine.gen.Interval = Convert.ToInt32(textBox1.Text);
        }
    }
}
