using System;
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
        //private Car c;

        public MainForm()
        {
            InitializeComponent();
            //c = new Car(300, 300, 5, "img\\Car\\car1_blue.png");
        }


        private void btn_ch_road_Click(object sender, EventArgs e)
        {
            // Тест кнопка
            //Timer move = new Timer {Interval = 1};
            //move.Tick += (s, eee) => Mova_Tick();
            //move.Start();
        }

        //public void Mova_Tick()
        //{
        //    c.Y -= 1;
        //    panel_user.Invalidate();
        //}
        

        protected void Panel_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(c.Sprite, new Point(c.X, c.Y));
            // Перерисовка
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

    }
}
