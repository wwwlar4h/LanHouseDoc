using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanHouse
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c.nome = tx_nome.Text;
                c.email = tx_email.Text;
                c.numtele = tx_email.Text;
                c.datanas = Convert.ToDateTime(maskedTextBox1.Text);



            }

            catch
            {

            }


        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
