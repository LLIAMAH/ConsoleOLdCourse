using System;
using System.Globalization;
using WinFormsApp1.Forms;

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