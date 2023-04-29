using System;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using WinFormsApp1.Forms;
using WinFormsApp1.UserControls;
using Timer = System.Threading.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // R - red
            // G - Green
            // B - Blue
            // A - Alph
            BackColor = Color.FromArgb(255, 100, 11);

            comboBox1.Items.Clear();
            comboBox1.Items.Add(new SomeItem(1, "Name 1"));
            comboBox1.Items.Add(new SomeItem(2, "Name 2"));
            comboBox1.Items.Add(new SomeItem(3, "Name 3"));
            comboBox1.Items.Add(new SomeItem(4, "Name 4"));
            comboBox1.Items.Add(new SomeItem(5, "Name 5"));
            comboBox1.Items.Add(new SomeItem(6, "Name 6"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FTools();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new FOptions();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var someOptionsData = form.Data;

                MessageBox.Show(someOptionsData);
            }

            var buttonClicked = MessageBox.Show(
                "Что будет написано в теле модальной формы.",
                "Наш заголовок модаль ной формы",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Asterisk);

            switch (buttonClicked)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Yes была нажата");
                    break;
                case DialogResult.No:
                    MessageBox.Show("No была нажата");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel была нажата");
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var valueString = textBox1.Text;
            var percentsString = textBox4.Text;

            var valueDouble = 0.0;
            var percentsDouble = 0.0;
            var suceeded1 = Double.TryParse(valueString, out valueDouble);
            suceeded1 = suceeded1 && Double.TryParse(percentsString, out percentsDouble);

            if (suceeded1)
            {
                var perc = percentsDouble / 100;
                var changingValue = valueDouble * perc;
                var result = valueDouble + changingValue;
                textBox3.Text = result.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                listBox1.Items.Add(tb.Text);
                tb.Text = string.Empty;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            var date1 = DateTime.UtcNow;

            var date2 = new DateTime(2003, 04, 26, 1, 9, 0);

            //var date3 = date.AddYears(-10);

            var stringDate1 = date2.ToString("yyyy-MM-dd  hh:mm:ss.fff");
            var stringDate2 = date2.ToString("yyyy-MM-dd  h:mm:ss.fff");
            var stringDate3 = date2.ToString("yyyy-MMM-dd  HH:mm:ss.fff");
            var stringDate4 = date2.ToString("yyyy-MMM-dd  H:mm:ss.fff");

            var t = 5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            var item = comboBox1.SelectedItem as SomeItem;

            MessageBox.Show($"Index ({index}), Item = {item}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        //System.Timers.Timer t = new System.Timers.Timer(400);

        private void button2_Click_1(object sender, EventArgs e)
        {
            //t.Elapsed += (o, args) =>
            //{
            //    dateTimePicker1.Value = DateTime.Now;
            //};
            //t.Start();

            var ddt = dateTimePicker1.Value;

            browseFolder1.PathChanged += BrowseFolder1_PathChanged2;
            //browseFolder1.PathChanged += BrowseFolder1_PathChanged3;
            browseFolder1.PathChanged += BrowseFolder1_PathChanged4;

            browseFolder1.PathChanged -= BrowseFolder1_PathChanged3;

            //var dateTimeCurrent = DateTime.Now;
            //var date1 = new DateTime(2023, dateTimeCurrent.Month, 4);
            //var date2 = new DateTime(2023, dateTimeCurrent.Month, 26);
            //var date3 = new DateTime(2023, dateTimeCurrent.Month, 29);

            //monthCalendar1.SelectionStart = date1;
            //monthCalendar1.SelectionEnd = date3;


            //monthCalendar1.MonthlyBoldedDates = new DateTime[]
            //{
            //    date1,
            //    date2,
            //    date3
            //};

            //var dateCompare = new DateTime(2023, 4, 29);
            //var dtToday = DateTime.Now;

            //var d1 = dtToday.ToLongDateString();
            //var d2 = dtToday.ToShortDateString();
            //var t1 = dtToday.ToLongTimeString();
            //var t2 = dtToday.ToShortTimeString();
            //var str = dtToday.ToString("O");


            //if (dateCompare.Date == dtToday.Date)
            //{
            //    MessageBox.Show("Today - 29 april, 2023");
            //}
            //else
            //{
            //    MessageBox.Show("Today is not - 29 april, 2023");
            //}
        }

        private void BrowseFolder1_PathChanged2(object? sender, EventArgs e)
        {
            MessageBox.Show("Event #2");
        }

        private void BrowseFolder1_PathChanged3(object? sender, EventArgs e)
        {
            MessageBox.Show("Event #3");
        }

        private void BrowseFolder1_PathChanged4(object? sender, EventArgs e)
        {
            MessageBox.Show("Event #4");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb1_Validated(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (string.IsNullOrEmpty(tb.Text))
            {
                errorProvider1.SetError(tb, "Текст не должен быть пустым в этом поле");
            }
            else
            {
                errorProvider1.SetError(tb, string.Empty);
            }
        }

        private void tb2_Validated(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (string.IsNullOrEmpty(tb.Text))
            {
                errorProvider1.SetError(tb, "Текст не должен быть пустым в этом поле");
            }
            else if (tb.Text.Length <= 4)
            {
                errorProvider1.SetError(tb, "Текст должен быть больше 4 символов");
            }
            else
            {
                errorProvider1.SetError(tb, string.Empty);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы кликнули на Open");
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            if (fbdBrowse.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbdBrowse.SelectedPath;

                var di = new DirectoryInfo(tbPath.Text);
                foreach (var file in di.GetFiles())
                {
                    lbOutput.Items.Add(file.Name);
                }
            }
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseFolder1_PathChanged(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            var di = new DirectoryInfo(browseFolder1.Path);
            foreach (var fileInfo in di.GetFiles())
            {
                lbOutput.Items.Add(fileInfo.Name);
            }

            //var pathChanger = sender as BrowseFolder;
            //if (pathChanger != null)
            //{
            //    var di = new DirectoryInfo(pathChanger.Path);
            //    foreach (var fileInfo in di.GetFiles())
            //    {
            //        lbOutput.Items.Add(fileInfo.Name);
            //    }
            //}
        }
    }

    public class SomeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SomeItem(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}