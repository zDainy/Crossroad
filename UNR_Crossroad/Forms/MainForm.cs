using System;
using System.Windows.Forms;
using UNR_Crossroad.Core;

namespace UNR_Crossroad.Forms
{
    public partial class MainForm : Form
    {
        private User myUser;

        public MainForm()
        {
            InitializeComponent();
            panel_user.Paint += Engine.RenderMap;
            Engine.UserPanel = panel_user;
            Engine.CarCount = tbAll;
            Engine.CurrentlyCarCount = tbCur;
            Engine.WorkTime = tbTime;
            Engine.Cpm = tbCpm;
            CarSprite.LoadCarSpriteLib();
            Engine.Initialization();
        }


        private void btn_ch_road_Click(object sender, EventArgs e)
        {
            Engine.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Engine.Pause();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Engine.Stop();
        }


        #region Верхнее меню
        private void входToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var auth = new AuthForm();
            if (auth.ShowDialog() == DialogResult.OK)
            {
                myUser = auth.GetUser();
                выНеВошлиToolStripMenuItem.Text = "Вы вошли как " + myUser.Level;
                labelUserAuth.Text = "Вы вошли как " + myUser.Level;
            }
        }
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegForm().ShowDialog();
        }
        #endregion
        
    }
}
