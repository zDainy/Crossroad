using System;
using System.Windows.Forms;
using UNR_Crossroad.Core;
using UNR_Crossroad.Data;

namespace UNR_Crossroad.Forms
{
    public partial class AuthForm : Form
    {
        private User User;

        public AuthForm()
        {
            InitializeComponent();
            tb_user.KeyPress += Tb_KeyPress;
            tb_pass.KeyPress += Tb_KeyPress;
        }

        private void Bt_enter_Click(object sender, EventArgs e)
        {
            if (EmptyCheck(tb_user.Text,tb_pass.Text) != "OK")
            {
                lb_error.Text = EmptyCheck(tb_user.Text, tb_pass.Text);
            }
            else
            {
                DbEngine.Connect();
                if (DbEngine.UserCheck(tb_user.Text, tb_pass.Text))
                {
                    User = new User(tb_user.Text, tb_pass.Text, (AccLevel)DbEngine.GetAccLevel(tb_user.Text));
                    DbEngine.Close();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lb_error.Text = "Неверный логин или пароль";
                }
            }
        }

        public User GetUser()
        {
            return User;
        }

        public static string EmptyCheck(string user, string pass)
        {
            if (user == "")
            {
                return "Пустое имя пользователя";
            }
            if (pass == "")
            {
                return "Пустой пароль";
            }
            return "OK";
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            new RegForm().ShowDialog();
        }
    }
}
