﻿using System;
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
            if (Validation.EmptyCheck(tb_user.Text,tb_pass.Text) != "OK")
            {
                lb_error.Text = Validation.EmptyCheck(tb_user.Text, tb_pass.Text);
            }
            else
            {
                DbEngine.Connect();
                foreach (var user in DbEngine.GetUsers())
                {
                    if (Validation.EntranceCheck(user.Key, user.Value) == "OK")
                    {
                        User = new User(user.Key, user.Value, (AccLevel) DbEngine.GetAccLevel(user.Key));
                        DbEngine.Close();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        lb_error.Text = Validation.EntranceCheck(user.Key, user.Value);
                    }
                }
            }
        }

        public User GetUser()
        {
            return User;
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