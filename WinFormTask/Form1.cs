using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void but_Click(object sender, EventArgs e)
        {
            double x, y, z, r;
            Console.Write("Введiть x = ");
            if (double.TryParse(textBoxX.Text, out x) == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                x = Convert.ToDouble(textBoxX.Text);
                if (double.TryParse(textBoxY.Text, out y) == false)
                {
                    MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    y = Convert.ToDouble(textBoxY.Text);
                    if (double.TryParse(textBoxZ.Text, out z) == false)
                    {
                        MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        z = Convert.ToDouble(textBoxZ.Text);
                        r = (2 * Math.Cos(x * x) - 1 / 2) / (1 / 2 + Math.Sin(Math.Pow(y, 2 - z))) + z * z / (7 - (z / 3));
                        textBoxR.Text = r.ToString("F2");
                    }
                }
            }
        }
    }
}
