using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppSystem
{
    public partial class FrmModeracao : Form
    {
        Thread NTCadastroConteudo;
        Thread NTInicio;
        Thread NTLogin;
        Thread NTPesquisa;
        public FrmModeracao()
        {
            InitializeComponent();
        }

        private void btnModeracao_Click(object sender, EventArgs e)
        {
            this.Close();
            NTCadastroConteudo = new Thread(FrmCadastro);
            NTCadastroConteudo.SetApartmentState(ApartmentState.STA);
            NTCadastroConteudo.Start();
        }

        private void FrmCadastro()
        {
            Application.Run(new FrmCadastroConteudo());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            NTLogin = new Thread(FrmLogar);
            NTLogin.SetApartmentState(ApartmentState.STA);
            NTLogin.Start();
        }

        private void FrmLogar()
        {
            Application.Run(new FrmLogin());
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
            NTPesquisa = new Thread(FormularioPesquisa);
            NTPesquisa.SetApartmentState(ApartmentState.STA);
            NTPesquisa.Start();
        }

        private void FormularioPesquisa()
        {
            Application.Run(new FrmPesquisaConteudo());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            NTInicio = new Thread(FormularioPrincipal);
            NTInicio.SetApartmentState(ApartmentState.STA);
            NTInicio.Start();
        }

        private void FormularioPrincipal()
        {
            Application.Run(new FrmPrincipal());
        }
    }
}
