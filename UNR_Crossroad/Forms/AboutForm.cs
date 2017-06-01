using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNR_Crossroad.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Assembly asm = Assembly.GetExecutingAssembly();
            Text = ((AssemblyTitleAttribute)asm.GetCustomAttribute(typeof(AssemblyTitleAttribute))).Title;
            label1.Text = ((AssemblyDescriptionAttribute)asm.GetCustomAttribute(typeof(AssemblyDescriptionAttribute))).Description;
            label2.Text = ((AssemblyCompanyAttribute)asm.GetCustomAttribute(typeof(AssemblyCompanyAttribute))).Company;
            label3.Text =
                ((AssemblyCopyrightAttribute) asm.GetCustomAttribute(typeof(AssemblyCopyrightAttribute))).Copyright;
            label4.Text = "Версия: " +
                ((AssemblyFileVersionAttribute) asm.GetCustomAttribute(typeof(AssemblyFileVersionAttribute))).Version;
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
    }
}
