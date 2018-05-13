using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EGECalculator
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var egeEdu = new ProcessStartInfo("http://ege.edu.ru/");
            Process.Start(egeEdu);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ege4 = new ProcessStartInfo("http://4ege.ru/novosti-ege/");
            Process.Start(ege4);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var check = new ProcessStartInfo("http://check.ege.edu.ru/");
            Process.Start(check);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fipi = new ProcessStartInfo("http://www.fipi.ru/content/otkrytyy-bank-zadaniy-ege");
            Process.Start(fipi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
