using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setName()
        {
            if(textBox_nomeCompleto.Text == "")
            {
                MessageBox.Show("Preencha o campo nome completo");
            }
            else
            {
                if (nomes.Contains(textBox_nomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já cadastrado");
                    return;
                }
                else
                {
                    nomes.Add(textBox_nomeCompleto.Text.ToUpper());
                    nomes.Sort();
                    updateListBox();
                    textBox_nomeCompleto.Text = "";
                }
            }
            textBox_nomeCompleto.Focus();
        }
        
        private void updateListBox()
        {
            textBox_listaNomes.Text = "";
            foreach (string nome in nomes)
            {
                textBox_listaNomes.Text += nome + Environment.NewLine;
            }
        }

        private void btn_nomeCompleto_Click(object sender, EventArgs e)
        {
            setName();
        }

        private void textBox_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                setName();
            }
        }

        private List<string> nomes = new List<string>();
    }
}