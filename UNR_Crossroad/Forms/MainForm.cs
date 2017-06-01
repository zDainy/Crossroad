using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using UNR_Crossroad.Core;
using UNR_Crossroad.Data;

namespace UNR_Crossroad.Forms
{
    public partial class MainForm : Form
    {
        private User myUser;
        private Dictionary<int, string> Roads;

        public MainForm()
        {
            InitializeComponent();
            panel_user.Paint += Engine.RenderMap;
            panel_admin.Paint += Engine.RenderMap;
            Engine.UserPanel = panel_user;
            Engine.CarCount = tbAll;
            Engine.CurrentlyCarCount = tbCur;
            Engine.WorkTime = tbTime;
            Engine.Cpm = tbCpm;
            Engine.Initialization();
            tabControl.TabPages[1].Enabled = false;
            tabControl.TabPages[0].Enabled = false;
        }

        private void btn_ch_road_Click(object sender, EventArgs e)
        {
            Engine.Start();
            button9.Enabled = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Engine.Pause();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Engine.Stop();
            panel_user.Controls.Clear();
            Engine.IsReady = false;
            Engine.Clear = true;
            panel_user.Invalidate();
            TrafficLight.Clear();
            button9.Enabled = true;
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
                label9.Text = "Вы вошли как " + myUser.Level;
                if (myUser.Level == AccLevel.Admin)
                {
                    tabControl.TabPages[1].Enabled = true;
                    tabControl.TabPages[0].Enabled = true;
                }
                if (myUser.Level == AccLevel.Player)
                {
                    tabControl.TabPages[1].Enabled = false;
                    tabControl.TabPages[0].Enabled = true;
                }
            }
        }
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegForm().ShowDialog();
        }
        #endregion
        

        private void button4_Click(object sender, EventArgs e)
        {
            Engine.CurrentRoad = new Road((int)numericUpDown2.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
            Engine.CurrentRoadTransit = new RoadTransit(checkBox2.Checked, checkBox1.Checked, checkBox3.Checked, checkBox4.Checked, (int)numericUpDown2.Value, (int)numericUpDown1.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
            Engine.IsReady = true;
            Engine.LightsInterval1 = (int)numericUpDown6.Value*1000;
            Engine.LightsInterval2 = (int)numericUpDown5.Value*1000;
            TrafficLight.CreateLight();
            panel_admin.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_admin.Controls.Clear();
            Engine.IsReady = false;
            Engine.Clear = true;
            panel_admin.Invalidate();
            TrafficLight.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Engine.GenCarTimer.Interval = (int)numericUpDown8.Value;
            Engine.GenPeopleTimer.Interval = (int)numericUpDown7.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var namef = new NameForm();
            if (namef.ShowDialog() == DialogResult.OK)
            {
                var name = namef.GetName();
                DbEngine.Connect();
                DbEngine.SaveRoad(name, (int) numericUpDown1.Value, (int) numericUpDown2.Value,
                    (int) numericUpDown3.Value, (int) numericUpDown4.Value, (int) numericUpDown6.Value,
                    (int) numericUpDown5.Value, checkBox4.Checked, checkBox3.Checked, checkBox2.Checked,
                    checkBox1.Checked);
                DbEngine.Close();
            }
            FillGrid(dataGridView1);
        }

        private void FillGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            Roads = DbEngine.GetRoads();
            var column1 = new DataGridViewColumn
            {
                HeaderText = "ID",
                Width = (int)(dgv.Width*0.1),
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            var column2 = new DataGridViewColumn
            {
                HeaderText = "Название",
                Width = (int)(dgv.Width * 0.9),
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv.Columns.Add(column1);
            dgv.Columns.Add(column2);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;

            foreach (var road in Roads)
            {
                dgv.Rows.Add(road.Key,road.Value);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            FillGrid(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].ColumnIndex == 0)
            {
                DbEngine.DeleteSelectedId(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                FillGrid(dataGridView1);
            }
            if (dataGridView1.SelectedCells[0].ColumnIndex == 1)
            {
                DbEngine.DeleteSelectedName((dataGridView1.SelectedCells[0].Value).ToString());
                FillGrid(dataGridView1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            FillGrid(dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells[0].ColumnIndex == 0)
            {
                Engine.CurrentRoad = DbEngine.LoadRoadSelectedId(Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
                Engine.CurrentRoadTransit =
                    DbEngine.LoadTransitSelectedId(Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
                Engine.LightsInterval1 = DbEngine.LoadIntervalId(Convert.ToInt32(dataGridView2.SelectedCells[0].Value), 1)*1000;
                Engine.LightsInterval2 = DbEngine.LoadIntervalId(Convert.ToInt32(dataGridView2.SelectedCells[0].Value), 2)*1000;
                if (Engine.CurrentRoad == null || Engine.CurrentRoadTransit == null)
                {
                    MessageBox.Show("Ошибка!");
                }
                else
                {
                    MessageBox.Show("Перекресток загружен!");
                    btn_start.Enabled = true;
                }
            }
            if (dataGridView2.SelectedCells[0].ColumnIndex == 1)
            {
                Engine.CurrentRoad = DbEngine.LoadRoadSelectedName((dataGridView2.SelectedCells[0].Value).ToString());
                Engine.CurrentRoadTransit =
                    DbEngine.LoadTransitSelectedName((dataGridView2.SelectedCells[0].Value).ToString());
                Engine.LightsInterval1 = DbEngine.LoadIntervalName((dataGridView2.SelectedCells[0].Value).ToString(), 1) * 1000;
                Engine.LightsInterval2 = DbEngine.LoadIntervalName((dataGridView2.SelectedCells[0].Value).ToString(), 2) * 1000;
                if (Engine.CurrentRoad == null || Engine.CurrentRoadTransit == null)
                {
                    MessageBox.Show("Ошибка!");
                }
                else
                {
                    MessageBox.Show("Перекресток загружен!");
                    btn_start.Enabled = true;
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ZadanieForm().ShowDialog();
        }
    }
}
