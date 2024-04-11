using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form11 : Form
    {
        public Form11(string conteudo)
        {
            InitializeComponent();
            labelConteudo.Text = "Conteúdo escrito: " + conteudo;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void labelConteudo_Click(object sender, EventArgs e)
        {

        }
    }
}
