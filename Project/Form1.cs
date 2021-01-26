using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string value = objTextBox.Text;
            if (value.Equals("")) {
                textBox2.Text = "";
                return;
            }

            if (!int.TryParse(value, out _))
            {
                MessageBox.Show("ошибка ввода, введите число", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return ;
            }
            DateTime thisDay = DateTime.Now;
            DateTime output;
            if (radioButton1.Checked) {
                output = thisDay.AddDays(Int32.Parse(value));
            } else if (radioButton2.Checked) {
                output = thisDay.AddMonths(Int32.Parse(value));
            } else if (radioButton3.Checked) {
                output = thisDay.AddYears(Int32.Parse(value));
            } else {
                MessageBox.Show("Выберите на сколько хотите увеличить", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox2.Text = output.ToString("dddd");
    }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Equals("")){
                textBox2.Text = "";
                return;
            }

            if (!int.TryParse(value, out _))
            {
                MessageBox.Show("ошибка ввода, введите число", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return;
            }
            DateTime thisDay = DateTime.Now;
            DateTime output;
            output = thisDay.AddDays(Int32.Parse(value));
            textBox2.Text = output.ToString("dddd");
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Equals(""))
            {
                textBox2.Text = "";
                return;
            }

            if (!int.TryParse(value, out _))
            {
                MessageBox.Show("ошибка ввода, введите число", "Предупрежение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return;
            }
            DateTime thisDay = DateTime.Now;
            DateTime output;
            output = thisDay.AddMonths(Int32.Parse(value));
            textBox2.Text = output.ToString("dddd");
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Equals(""))
            {
                textBox2.Text = "";
                return;
            }

            if (!int.TryParse(value, out _))
            {
                MessageBox.Show("ошибка ввода, введите число", "Предупреждение",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return;
            }
            DateTime thisDay = DateTime.Now;
            DateTime output;
            output = thisDay.AddYears(Int32.Parse(value));
            textBox2.Text = output.ToString("dddd");
        }
    }
}