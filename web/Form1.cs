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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setavoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void favorito_Click(object sender, EventArgs e)
        {
            favorito favo = new favorito();
            favo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(textBox1.Text);

            if (textBox1.Text == "SEXO" || textBox1.Text == "PORNO")
            {
                MessageBox.Show("Você não pode acessar este site", "Atenção!!");
                this.Close();            
            }
        }

        private void setair_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pginicial_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Pesquisar.PerformClick();
            }
        }

        

        
    }
}
