using System;
using System.Windows.Forms;
using UNR_Crossroad.Core;
using UNR_Crossroad.Data;

namespace UNR_Crossroad.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            comboBox.SelectedItem = comboBox.Items[0];
            tb_user.KeyPress += Tb_KeyPress;
            tb_pass.KeyPress += Tb_KeyPress;
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            if (EmptyCheck(tb_user.Text, tb_pass.Text) != "OK")
            {
                lb_error.Text = EmptyCheck(tb_user.Text, tb_pass.Text);
            }
            else
            {
                DbEngine.Connect();
                if (DbEngine.LoginCheck(tb_user.Text))
                {
                    lb_error.Text = "Пользователь с таким именем уже существует";
                }
                else
                {
                    var r = MessageBox.Show(DbEngine.AddUser(tb_user.Text, tb_pass.Text, (int)(AccLevel)comboBox.SelectedItem), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
                DbEngine.Close();
            }
        }
        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
    }
}
