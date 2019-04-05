using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_Uteis;
using Dll_BS_CPIR;
using Dll_DB_CPIR;
using System.Data.SqlClient;
using dll_Uteis;

namespace PIM_ONGIR
{
    public partial class frmLogin : Form
    {
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL usuario = new PreparaSQL();
        VerificaCampos verificacampos = new VerificaCampos();
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#228B22");


            //cmbLogin.Items.Add("TESTE1").ToString();
            //cmbLogin.Items.Add("TESTE2").ToString();

        }

        

        private void txtSenha_click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite a sua Senha") txtSenha.Text = "";
        }

        private void cmbLogin_MouseLeave(object sender, EventArgs e)
        {
            if (cmbLogin.Text == "") cmbLogin.Text = "Digite o seu Login" ; 
        }

        private void txtSenha_MouseLeave(object sender, EventArgs e)
        {

            if (txtSenha.Text == "") txtSenha.Text = "Digite a sua Senha"; 
        }

        private void cmbFilial_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            try
            {
                CarregarForm Usuarios = new CarregarForm();

                string ret;

                ret = (verificacampos.VerificaUsuario(cmbLogin.Text, txtSenha.Text));
                if (ret == "")
                {

                    if (Usuarios.Usuario(cmbLogin.Text, txtSenha.Text) == true)
                    {
                        string perfil = Usuarios.CarregarPerfil(cmbLogin.Text, txtSenha.Text);

                        this.Hide();
                        frmPrincipal sistema = new frmPrincipal();


                        //Transmite para a classe de usuários o usuário LOGADO;
                        Usuarios usuarios = new Usuarios();
                        usuarios.setLogin(cmbLogin.Text);
                        usuarios.setSenha(txtSenha.Text);
                        //usuarios.setPerfil(perfil);
                        usuarios.setID(perfil);
                        sistema.Usuario(usuarios);

                        //Passa o objeto para o formulário principal:
                        sistema.objUsuario(usuarios);



                        sistema.ShowDialog();


                    }
                    else
                        Mensagem("Usuário ou senha inválidos!");
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
                else if (ret == "Usuario")
                {
                    Mensagem("Por favor selecione um usuário!");
                    cmbLogin.BackColor = System.Drawing.Color.LightCyan;
                    cmbLogin.Focus();
                }
                else if (ret == "Senha")
                {
                    Mensagem("Por favor digite sua senha!");
                    txtSenha.BackColor = System.Drawing.Color.LightCyan;
                }

            }
            catch
            {
                MessageBox.Show("Erro ao conectar à base de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Mensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Acessando", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cmbLogin.Items.Clear();
                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(usuario.ConsultaUsuario(), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        cmbLogin.Items.Add(leitor["loginUSU"].ToString());

                    }
                    leitor.Close();
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar à base de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}   
