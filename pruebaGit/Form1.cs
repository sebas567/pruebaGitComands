using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Class1.saludar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Class1.despedirse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
