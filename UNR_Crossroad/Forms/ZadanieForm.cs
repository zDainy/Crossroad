using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNR_Crossroad.Forms
{
    public partial class ZadanieForm : Form
    {
        public ZadanieForm()
        {
            InitializeComponent();
            Text = "Задание на лабараторную работу";
            label1.Text = "Автоматизированная система моделирования движения на регулируемом перекрестке";
            label13.Text = "Постановка задачи:";
            label2.Text = "— Перекресток состоит из 2 пересекаемых дорог\n— Количество полос от 1 до 4\n— На перекрестке установлены светофоры\n— Повороты осуществляются по правилам:\n\tнаправо - из крайней правой полосы, налево - из крайней левой полосы\n— Перед перекрестком может быть установлен пешеходный переход";
            label4.Text = "Пользователи:";
            label3.Text = "— Администратор осуществляет создание новый перекрестков, их сохранение и удаление\n— Пользователь осуществляет запуск моделирования перекрестков";
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
    }
}
