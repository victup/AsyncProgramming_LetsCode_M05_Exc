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
    public partial class frmObterTexto : Form
    {
        public frmObterTexto()
        {
            InitializeComponent();
        }

        private async void btnObterTexto_Click(object sender, EventArgs e)
        {
            txtExibeTexto.Text = String.Empty;
            btnObterTexto.Enabled = false;
            txtExibeTexto.Text =  await ExibirTexto();
            btnObterTexto.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private async Task<string> ExibirTexto()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return "Turma 854 - Técnicas de Programação";
        }
    }
}
