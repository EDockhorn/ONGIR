using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_BS_CPIR;
using Dll_DB_CPIR;

namespace PIM_ONGIR
{
    public partial class frmPrincipal : Form
    {
        FrmCadAsso CadAsso = new FrmCadAsso();
        FrmConsultaAsso consultaasso = new FrmConsultaAsso();
        Usuarios user = new Usuarios();
        FrmAgendar agendar = new FrmAgendar();
        Dll_DB_CPIR.CarregarForm verificaagendamento = new CarregarForm();
        public string Perfil;
        int indicador;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja acessar com um novo usuário?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#D9D9D9");
            Perfil = user.getID();
            RecuperaPerfil(Perfil);

            if(verificaagendamento.VerificaNovosAgendamentos(toolPerfil.Text) == true) AlertaConsulta();



        }
        public void Usuario(Usuarios usuarioss)
        {
            user = usuarioss;
        }

        public void RecuperaPerfil(string perfil)
        {
            switch (Perfil)
            {
                case "AT":
                    toolStripCadastrarAssociados.Enabled = true;
                    toolPerfil.Text = "Atendente";
                    break;
                case "AM":
                    toolStripCadastrarAssociados.Enabled = true;
                    toolPerfil.Text = "Administrador de T.I.";
                    break;
                case "AD":
                    toolPerfil.Text = "Assistência Jurídica";
                    indicador = 1;
                    toolStripSplitButton1.Visible = false;
                    toolStripCadastrarAssociados.Enabled = false;
                    toolStripAgendar.Enabled = false;
                    break;
                case "AS":
                    toolPerfil.Text = "Assistência Social";
                    indicador = 1;
                    toolStripSplitButton1.Visible = false;
                    toolStripCadastrarAssociados.Enabled = false;
                    toolStripAgendar.Enabled = false;
                    break;
               case "PS":
                    toolPerfil.Text = "Psicologia";
                    indicador = 1;
                    toolStripSplitButton1.Visible = false;
                    toolStripCadastrarAssociados.Enabled = false;
                    toolStripAgendar.Enabled = false;
                    break;
          
            }
            
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFechar();
        }

      
        private void msgFechar()
        {
            if (MessageBox.Show("Deseja fechar o SIS-CPIR?", "Encerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
        private void toolStripCadastrarClientes_Click(object sender, EventArgs e)
        {

            CadAsso.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            CadAsso.ShowDialog();
        }



        private void toolStripSplitButton1_ButtonClick_1(object sender, EventArgs e)
        {
            if (indicador != 1) CadAsso.ShowDialog();
        }

        private void toolStripCadastrarCliociados_Click(object sender, EventArgs e)
        {
            CadAsso.ShowDialog();
        }

        internal void objUsuario(Dll_BS_CPIR.Usuarios usuarios)
        {
            toolUsuario.Text = usuarios.getLogin();
        }

        public void toolStripMenuConsultarAssociados_Click(object sender, EventArgs e)
        {
            consultaasso.getPerfi(user);
            consultaasso.ShowDialog();
            
        }
        private void toolStripMenuCadastrarAssociados_Click(object sender, EventArgs e)
        {
            CadAsso.ShowDialog();
        }
        private void AlertaConsulta()
        {
            toolAgendamento.Image = Bitmap.FromFile(@"C:\Users\johnn\Documents\Visual Studio 2012\Projects\PIM_ONGIR\PIM_ONGIR\Resources\calendar_.png");
            toolAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolAgendamento.Click += new System.EventHandler(toolAgendamento_ButtonClick);
        }

        private void toolAgendamento_ButtonClick(object sender, EventArgs e)
        {
            if (indicador != 1) agendar.ShowDialog();
        }



        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendar agendar = new FrmAgendar();
            agendar.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgendar agendar = new FrmAgendar();
            agendar.ShowDialog();
        }

        private void toolConsultarAgendamentos_Click(object sender, EventArgs e)
        {
            frmConsultaAgenda consultaragendamentos = new  frmConsultaAgenda();
            consultaragendamentos.ShowDialog();
        }
    }
}
