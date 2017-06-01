using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNR_Crossroad.Data;

namespace UNR_Crossroad.Forms
{
    public partial class NameForm : Form
    {
        public string NameF { get; set; }
        public NameForm()
        {
            InitializeComponent();
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            if (DbEngine.NameCheck(tb_name.Text))
            {
                MessageBox.Show("Перекресток с таким названием уже существует!");
            }
            else if (tb_name.Text != "")
            {
                NameF = tb_name.Text;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Перексресток сохранен!");
            }
            else
            {
                MessageBox.Show("Нельзя сохранить с пустым именем");
            }
        }

        public string GetName()
        {
            return NameF;
        }
    }
}
