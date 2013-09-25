using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web
{
    public partial class favorito : Form
    {
        public favorito()
        {
            InitializeComponent();
        }

        private void favorito_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxfavo_TextChanged(object sender, EventArgs e)
        {
            //textBoxfavo.Text = textBox1.Text;
        }
    }
}
