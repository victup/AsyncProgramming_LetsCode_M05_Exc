using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait.WindowsForms
{
    public partial class frmBaixarArquivo : Form
    {
        public frmBaixarArquivo()
        {
            InitializeComponent();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            if(lbEsquerda.Items.Count > 0 )
            {
                lbDireita.Items.AddRange(lbEsquerda.Items);
                lbEsquerda.Items.Clear();
            }
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if(lbDireita.Items.Count > 0 )
            {
                lbEsquerda.Items.AddRange(lbDireita.Items);
                lbDireita.Items.Clear();
            }
        }

        private async void btnBaixarArquivo_Click(object sender, EventArgs e)
        {
            await BaixarArquivo();
        }

        private async Task BaixarArquivo()
        {
            lblMensagem.Visible = true;
            btnBaixarArquivo.Enabled = false;
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Text = "Baixando Arquivo, Aguarde";

            await Task.Delay(TimeSpan.FromSeconds(8)); //simula uma operação que demora 8s

            lblMensagem.Text = "Arquivo Baixado com sucesso!";
            lblMensagem.ForeColor = Color.Green;
            btnBaixarArquivo.Enabled = true;
        }
    }
}
