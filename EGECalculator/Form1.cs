using System;
using System.Drawing;
using System.Windows.Forms;

namespace EGECalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            years.Text = Convert.ToString(years.Items[0]);
        }

        private void years_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (years.Text)
            {
                case "2014":
                    subject.Items.Clear();
                    object[] items2014 = { "Литература", "География", "Русский язык", "Математика", "Химия", "Обществознание", "Физика", "Иностранные языки", "История", "Биология", "Информатика" };
                    subject.Items.AddRange(items2014);
                    subject.Text = Convert.ToString(items2014[0]);
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Properties.Resources._2014;
                    break;
                case "2015":
                    subject.Items.Clear();
                    object[] items2015 = { "Литература", "География", "Русский язык", "Математика (база)", "Математика (проф.)", "Химия", "Обществознание", "Физика", "Иностранные языки", "История", "Биология", "Информатика" };
                    subject.Items.AddRange(items2015);
                    subject.Text = Convert.ToString(items2015[0]);
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Properties.Resources._2015;
                    break;
                /*case "2016":
                    subject.Items.Clear();
                    object[] items2016 = { "Литература", "География", "Русский язык", "Математика (база)", "Математика (проф.)", "Химия", "Обществознание", "Физика", "Иностранные языки", "История", "Биология", "Информатика" };
                    subject.Items.AddRange(items2016);
                    subject.Text = Convert.ToString(items2016[0]);
                    pictureBox1.Image = new Bitmap(Properties.Resources._2016);
                    break;*/
            }
        }

        private void subject_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (years.Text)
            {
                case "2014":
                    firstpoint.Items.Clear();
                    Info2014();
                    break;
                case "2015":
                    firstpoint.Items.Clear();
                    Info2015();
                    break;
            }
        }

        public void GetInfo(int minimum, string dates, string reserveDate, string times, int maxPoint)
        {
            min.Text = minimum.ToString();
            date.Text = dates;
            reservedate.Text = reserveDate;
            time.Text = times;
            testpointlbl.Text = minimum == 3 ? "Оценка:" : "Тестовый балл:";
            firstpoint.Items.Clear();
            for (var i = 1; i <= maxPoint; i++)
            {
                firstpoint.Items.Add(i);
            }
            firstpoint.Text = "1";
        }

        private void Info2014()
        {
            switch (subject.Text)
            {
                case "Литература":
                    GetInfo(32, "25 мая 2014 г.", "24 июня 2014 г.", "3 ч. 55 мин. (235 мин.)", 42);
                    break;
                case "География":
                    GetInfo(37, "25 мая 2014 г.", "24 июня 2014 г.", "3 ч. (180 мин.)", 53);
                    break;
                case "Русский язык":
                    GetInfo(24, "28 мая 2014 г.", "22 июня 2014 г.", "3 ч. 30 мин. (210 мин.)", 64);
                    break;
                case "Математика":
                    GetInfo(20, "4 июня 2014 г.", "23 июня 2014 г.", "3 ч. 55 мин. (235 мин.)", 33);
                    break;
                case "Химия":
                    GetInfo(36, "8 июня 2014 г.", "24 июня 2014 г.", "3 ч. (180 мин.)", 65);
                    break;
                case "Обществознание":
                    GetInfo(39, "8 июня 2014 г.", "24 июня 2014 г.", "3 ч. 55 мин. (235 мин.)", 59);
                    break;
                case "Физика":
                    GetInfo(36, "11 июня 2014 г.", "24 июня 2014 г.", "3 ч. 55 мин. (235 мин.)", 51);
                    break;
                case "История":
                    GetInfo(32, "15 июня 2014 г.", "25 июня 2014 г.", "3 ч. 30 мин. (210 мин.)", 59);
                    break;
                case "Биология":
                    GetInfo(36, "15 июня 2014 г.", "25 июня 2014 г.", "3 ч. (180 мин.)", 69);
                    break;
                case "Информатика":
                    GetInfo(40, "15 июня 2014 г.", "25 июня 2014 г.", "3 ч. 55 мин. (235 мин.)", 40);
                    break;
                case "Иностранные языки":
                    GetInfo(20, "11, 17, 18 июня 2014 г.", "25, 26 июня 2014 г.", "3 ч. (180 мин.)", 80);
                    break;
            }
        }

        private void Info2015()
        {
            switch (subject.Text)
            {
                case "Литература":
                    GetInfo(32, "25 мая 2015 г.", "24 июня 2015 г.", "3 ч. 55 мин. (235 мин.)", 42);
                    break;
                case "География":
                    GetInfo(37, "25 мая 2015 г.", "24 июня 2015 г.", "3 ч. (180 мин.)", 51);
                    break;
                case "Русский язык":
                    GetInfo(36, "28 мая 2015 г.", "22 июня 2015 г.", "3 ч. 30 мин. (210 мин.)", 56);
                    break;
                case "Математика (база)":
                    GetInfo(3, "1 июня 2015 г.", "23 июня 2015 г.", "3 ч. (180 мин.)", 20);
                    break;
                case "Математика (проф.)":
                    GetInfo(27, "4 июня 2015 г.", "23 июня 2015 г.", "3 ч. 55 мин. (235 мин.)", 32);
                    break;
                case "Химия":
                    GetInfo(36, "8 июня 2015 г.", "24 июня 2015 г.", "3 ч. (180 мин.)", 64);
                    break;
                case "Обществознание":
                    GetInfo(42, "8 июня 2015 г.", "24 июня 2015 г.", "3 ч. 55 мин. (235 мин.)", 62);
                    break;
                case "Физика":
                    GetInfo(36, "11 июня 2015 г.", "24 июня 2015 г.", "3 ч. 55 мин. (235 мин.)", 50);
                    break;
                case "История":
                    GetInfo(32, "15 июня 2015 г.", "25 июня 2015 г.", "3 ч. 30 мин. (210 мин.)", 59);
                    break;
                case "Биология":
                    GetInfo(36, "15 июня 2015 г.", "25 июня 2015 г.", "3 ч. (180 мин.)", 61);
                    break;
                case "Информатика":
                    GetInfo(40, "15 июня 2015 г.", "25 июня 2015 г.", "3 ч. 55 мин. (235 мин.)", 35);
                    break;
                case "Иностранные языки":
                    GetInfo(22, "11, 17, 18 июня 2015 г.", "25, 26 июня 2015 г.", "3 ч. (180 мин.)", 100);
                    break;
            }
        }

        private void firstpoint_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (years.Text)
            {
                case "2014":
                    Score2014();
                    break;
                case "2015":
                    Score2015();
                    break;
            }

            testpoint.ForeColor = Convert.ToInt32(testpoint.Text) < Convert.ToInt32(min.Text) ? Color.Red : Color.Green;
        }

        private void Score2014()
        {
            switch (subject.Text)
            {
                case "Математика":
                    int[] math = { 0, 7, 13, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 70, 72, 73, 75, 77, 79, 80, 82, 84, 86, 88, 89, 91, 93, 95, 96, 98, 100 };
                    var mathv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(math[mathv]);
                    break;
                case "Русский язык":
                    int[] russian = { 0, 3, 5, 7, 9, 11, 13, 15, 17, 20, 22, 24, 26, 28, 30, 32, 34, 36, 37, 38, 39, 40, 41, 43, 44, 45, 46, 48, 49, 50, 51, 52, 53, 55, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 76, 79, 82, 84, 87, 90, 92, 95, 98, 100 };
                    var russianv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(russian[russianv]);
                    break;
                case "Физика":
                    int[] phys = { 0, 4, 7, 10, 13, 17, 20, 23, 26, 30, 33, 36, 39, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 65, 67, 69, 71, 73, 75, 77, 79, 81, 84, 86, 88, 90, 92, 94, 96, 98, 100 };
                    var physv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(phys[physv]);
                    break;
                case "Информатика":
                    int[] inf = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 42, 44, 45, 47, 49, 50, 52, 54, 55, 57, 58, 60, 62, 63, 65, 67, 68, 70, 71, 73, 75, 76, 78, 80, 81, 83, 84, 88, 91, 94, 97, 100 };
                    var infv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(inf[infv]);
                    break;
                case "Обществознание":
                    int[] soc = { 0, 3, 6, 8, 11, 13, 16, 19, 21, 24, 26, 29, 32, 34, 37, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 75, 78, 80, 83, 85, 88, 90, 93, 95, 98, 100 };
                    var socv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(soc[socv]);
                    break;
                case "История":
                    int[] hist = { 0, 3, 5, 8, 10, 13, 15, 18, 20, 23, 25, 28, 30, 32, 34, 35, 36, 37, 38, 40, 41, 42, 43, 44, 45, 47, 48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 60, 61, 62, 63, 64, 65, 67, 68, 69, 70, 71, 72, 75, 77, 79, 82, 84, 86, 89, 91, 93, 96, 98, 100 };
                    var histv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(hist[histv]);
                    break;
                case "Биология":
                    int[] bio = { 0, 3, 5, 7, 9, 11, 13, 15, 17, 20, 22, 24, 26, 28, 30, 32, 34, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 82, 84, 86, 89, 91, 93, 96, 98, 100 };
                    var biov = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(bio[biov]);
                    break;
                case "Химия":
                    int[] chem = { 0, 3, 6, 8, 11, 13, 16, 18, 21, 24, 26, 29, 31, 34, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 83, 86, 89, 92, 95, 98, 100 };
                    var chemv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(chem[chemv]);
                    break;
                case "География":
                    int[] geo = { 0, 3, 6, 8, 11, 14, 16, 14, 22, 24, 27, 30, 32, 35, 37, 39, 40, 41, 42, 43, 44, 45, 46, 47, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100 };
                    var geov = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(geo[geov]);
                    break;
                case "Литература":
                    int[] lit = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 34, 35, 37, 38, 40, 41, 43, 44, 46, 47, 49, 50, 52, 53, 54, 56, 57, 59, 60, 62, 63, 65, 66, 68, 69, 71, 72, 73, 78, 82, 87, 91, 96, 100 };
                    var litv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(lit[litv]);
                    break;
                case "Иностранные языки":
                    int[] inolang = { 0, 2, 3, 4, 5, 7, 8, 9, 10, 12, 13, 14, 15, 17, 18, 19, 20, 22, 23, 24, 25, 27, 28, 29, 30, 32, 33, 34, 35, 37, 38, 39, 40, 42, 43, 44, 45, 47, 48, 49, 50, 52, 53, 54, 55, 57, 58, 59, 60, 62, 63, 64, 65, 67, 68, 69, 70, 72, 73, 74, 75, 77, 78, 79, 80, 82, 83, 84, 85, 87, 88, 89, 90, 92, 93, 94, 95, 97, 98, 99, 100 };
                    var inolangv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(inolang[inolangv]);
                    break;
            }
        }

        private void Score2015()
        {
            switch (subject.Text)
            {
                case "Математика (проф.)":
                    int[] math = { 0, 5, 9, 14, 18, 23, 27, 33, 39, 45, 50, 55, 59, 64, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 95, 97, 98, 99, 100 };
                    var mathv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(math[mathv]);
                    break;
                case "Математика (база)":
                    int[] mathbase = { 0, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5 };
                    var mathbasev = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(mathbase[mathbasev]);
                    break;
                case "Русский язык":
                    int[] russian = { 0, 2, 5, 7, 9, 11, 14, 16, 18, 20, 23, 25, 27, 29, 32, 34, 36, 37, 39, 40, 41, 43, 44, 45, 46, 48, 49, 50, 51, 52, 53, 55, 56, 57, 59, 60, 61, 62, 64, 65, 66, 67, 69, 70, 71, 72, 73, 76, 79, 82, 84, 87, 90, 92, 95, 98, 100 };
                    var russianv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(russian[russianv]);
                    break;
                case "Физика":
                    int[] phys = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 65, 67, 69, 71, 74, 76, 78, 80, 83, 85, 87, 89, 92, 94, 96, 98, 100 };
                    var physv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(phys[physv]);
                    break;
                case "Информатика":
                    int[] inf = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 46, 47, 48, 49, 50, 55, 57, 59, 61, 62, 64, 66, 68, 70, 72, 73, 75, 77, 79, 81, 83, 84, 88, 91, 94, 97, 100 };
                    var infv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(inf[infv]);
                    break;
                case "Обществознание":
                    int[] soc = { 0, 2, 4, 7, 9, 11, 13, 15, 18, 20, 22, 24, 27, 29, 31, 33, 35, 38, 40, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100 };
                    var socv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(soc[socv]);
                    break;
                case "История":
                    int[] hist = { 0, 2, 5, 7, 10, 12, 15, 17, 19, 22, 24, 27, 29, 32, 34, 35, 36, 37, 39, 40, 41, 42, 43, 44, 46, 47, 48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 60, 61, 62, 63, 64, 65, 67, 68, 69, 70, 71, 72, 75, 77, 79, 82, 84, 86, 89, 91, 93, 95, 98, 100 };
                    var histv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(hist[histv]);
                    break;
                case "Биология":
                    int[] bio = { 0, 2, 4, 6, 8, 11, 13, 15, 17, 19, 21, 23, 25, 28, 30, 32, 34, 36, 39, 40, 41, 42, 44, 45, 46, 48, 49, 50, 51, 53, 54, 55, 57, 58, 59, 61, 62, 63, 64, 66, 67, 68, 69, 71, 72, 73, 74, 76, 77, 78, 80, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 100 };
                    var biov = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(bio[biov]);
                    break;
                case "Химия":
                    int[] chem = { 0, 3, 5, 8, 10, 13, 15, 18, 21, 23, 26, 28, 31, 33, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 83, 87, 90, 93, 97, 100 };
                    var chemv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(chem[chemv]);
                    break;
                case "География":
                    int[] geo = { 0, 3, 5, 8, 11, 13, 16, 19, 21, 24, 26, 29, 32, 34, 37, 38, 39, 40, 41, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 65, 66, 67, 68, 69, 73, 77, 81, 85, 88, 92, 96, 100 };
                    var geov = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(geo[geov]);
                    break;
                case "Литература":
                    int[] lit = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 33, 35, 36, 38, 39, 41, 42, 44, 45, 47, 48, 50, 51, 53, 54, 55, 57, 58, 60, 61, 63, 64, 66, 67, 69, 70, 72, 73, 78, 82, 87, 91, 96, 100 };
                    var litv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(lit[litv]);
                    break;
                case "Иностранные языки":
                    int[] inolang = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
                    var inolangv = Convert.ToInt32(firstpoint.Text);
                    testpoint.Text = Convert.ToString(inolang[inolangv]);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var about = new Form2();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.ShowDialog();
        }
    }
}
