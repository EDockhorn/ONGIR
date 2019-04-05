using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dll_Uteis;
using Dll_BS_CPIR;
using Dll_DB_CPIR;
using System.Data.SqlClient;


namespace PIM_ONGIR
{
    public partial class FrmCadAsso : Form
    {
        Dll_Uteis.cs.VerificaCampos verificacampos = new Dll_Uteis.cs.VerificaCampos();
        Dll_BS_CPIR.Associados associados = new Associados();
        Dll_DB_CPIR.RecuperaConexao conexao = new RecuperaConexao();
        Dll_DB_CPIR.Executa executar = new Executa();
        Dll_DB_CPIR.PreparaSQL preparasql = new PreparaSQL();

        public int operacao = 1; //Incluir [1] Editar [2]
        public int ID = 0;

        public FrmCadAsso()
        {
            InitializeComponent();
        }


      

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            WebServiceCEP.WebServiceCEP cep = new WebServiceCEP.WebServiceCEP(mskCEP.Text);
            txtLogradouro.Text = cep.Lagradouro;
            txtCidade.Text = cep.Cidade;
            txtBairro.Text = cep.Bairro;
            txtUF.Text = cep.UF;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (dlgFoto.ShowDialog() == DialogResult.OK)
            {
                lblFoto.Text = dlgFoto.FileName;
                pictureFoto.Image = Image.FromFile(lblFoto.Text);
                
            }
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();

        }

        public void ReconheceuMenorIdade()
        {
            if (MenorIdade(mskDataNas.Text) == true)
            {
                lblNomeResp.Visible = true;
                txtNomeResp.Visible = true;
                lblCPF.Text = "CPF Resp.";
                lblRG.Text = "RG Resp.";
                lblData.Text = "Data de Nascimento Resp.";
                txtNomeResp.Focus();

                // MessageBox.Show("Associado é menor de idade!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblNomeResp.Visible = false;
                txtNomeResp.Visible = false;
                lblCPF.Text = "CPF";
                lblRG.Text = "RG";
                lblData.Text = "Data de Nascimento.";
                mskCEP.Focus();
            }
        }

        private void mskDataNas_Leave(object sender, EventArgs e)
        {
            ReconheceuMenorIdade();
        }

        private void txtNomeResp_Leave(object sender, EventArgs e)
        {
            mskCEP.Focus();
        }

        private void txtnum_Leave(object sender, EventArgs e)
        {
            mskTelComer.Focus();
        }

        private void txtnum_Leave_1(object sender, EventArgs e)
        {
            mskTelComer.Focus();
        }

        private void mskCelular_Leave(object sender, EventArgs e)
        {
            btnSalvar.Focus();
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret;

            conexao.RecuperaCNN();
            //conexao.RecuperaConexao();

            ret = verificacampos.VerificaAssociados(txtNome.Text, txtNomeResp.Text, mskRG.Text, mskCPF.Text, mskDataNas.Text
                , mskCelular.Text, mskCEP.Text, txtLogradouro.Text, txtCidade.Text, txtBairro.Text, txtUF.Text
                , txtnum.Text, mskTelComer.Text);
            if (ret == "")
            {
                //Passa os valores para classe
                associados.nome = txtNome.Text;
                associados.rg = mskRG.Text;
                associados.cpf = mskCPF.Text;
                associados.datanasc = Convert.ToDateTime(mskDataNas.Text);
                associados.telefone = mskTelComer.Text;
                associados.cep = mskCEP.Text;
                associados.logradouro = txtLogradouro.Text;
                associados.cidade = txtCidade.Text;
                associados.bairro = txtBairro.Text;
                associados.estado = txtUF.Text;
                associados.numcasa = txtnum.Text;
                associados.celular = mskCelular.Text;
                associados.uf = txtUF.Text;
                associados.img = lblFoto.Text;
                associados.nomeResp = txtNomeResp.Text;


                if (operacao == 1) 
                {
                    if (MessageBox.Show("Deseja incluir o associado?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        executar.Executar(preparasql.IncluirAssociados(associados));
                        MessageBox.Show("Associado cadastrado com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                       
                }
                else if (operacao == 2)
                {
                    if (MessageBox.Show("Deseja alterar o associado?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executar.Executar(preparasql.PreparaUPDATEAssociado((associados)));
                        MessageBox.Show("Associado alterado com sucesso!", "Editando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                }



            }
            else if (ret == "nome")
            {
                lblInfo.Text = "Por favor digite o nome do associado!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "nomecurto")
            {
                lblInfo.Text = "Verifique se o nome do associado está correto!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "rg")
            {
                lblInfo.Text = "RG inválido!";
                mskRG.Focus();
                mskRG.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cpf")
            {
                lblInfo.Text = "CPF inválido!";
                mskCPF.Focus();
                mskCPF.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "nomeresp" && MenorIdade(mskDataNas.Text) == true && lblNomeResp.Visible == true)
            {
                lblInfo.Text = "Por favor preencha o nome do responsável!";
                txtNomeResp.Focus();
                txtNomeResp.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "data")
            {
                lblInfo.Text = "Data de nascimento inválida";
                mskDataNas.Focus();
                mskDataNas.BackColor = System.Drawing.Color.LightCyan;
            }
            //else if (ret == "menoridade")
            //{
            //    lblInfo.Text = "O cliente não pode ser menor de 18 anos!";
            //    mskDataNas.Focus();
            //    mskDataNas.BackColor = System.Drawing.Color.LightCyan;
            //}
           
            else if (ret == "cep")
            {
                lblInfo.Text = "CEP inválido!";
                mskCEP.Focus();
                mskCEP.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "logradouro")
            {
                lblInfo.Text = "Por favor preencha o logradouro!";
                txtLogradouro.Focus();
                txtLogradouro.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cidade")
            {
                lblInfo.Text = "Por favor preencha a cidade!";
                txtCidade.Focus();
                txtCidade.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "bairro")
            {
                lblInfo.Text = "Por favor preencha o bairro!";
                txtBairro.Focus();
                txtBairro.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "uf")
            {
                lblInfo.Text = "Por favor preencha o estado!";
                txtUF.Focus();
                txtUF.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "numerocasa")
            {
                lblInfo.Text = "Por favor preencha o número de sua residência!";
                txtnum.Focus();
                txtnum.BackColor = System.Drawing.Color.LightCyan;
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskRG_TextChanged(object sender, EventArgs e)
        {
            mskRG.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            mskCPF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtNomeResp_TextChanged(object sender, EventArgs e)
        {

            txtNomeResp.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            mskCEP.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            txtLogradouro.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            txtnum.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskTelComer_TextChanged(object sender, EventArgs e)
        {
            mskTelComer.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
           
        }

        private void mskCelular_TextChanged(object sender, EventArgs e)
        {
            mskCelular.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }
        private bool MenorIdade(string dataNasc)
        {
            Boolean menoridade = false;
            if (Convert.ToDateTime(mskDataNas.Text).AddYears(18) > DateTime.Now) {
                return menoridade = true;
            }
            else return menoridade = false;
        }

        private void FrmCadAsso_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (operacao == 2) { CarregarAssociado(ID); }
     
        }

        public void CarregarAssociado(int ID)
        {
            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(preparasql.ConsultaAssociado(ID), con);
                con.Open();

                associados.codASS = ID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtNome.Text = reader["nomeASS"].ToString();
                        mskRG.Text = reader["rgASS"].ToString();
                        mskCPF.Text = reader["cpfASS"].ToString();
                        mskDataNas.Text = reader["datanascASS"].ToString();
                        mskTelComer.Text = reader["telefonefixoASS"].ToString();
                        mskCelular.Text = reader["telefonecelularASS"].ToString();
                        mskCEP.Text = reader["cepASS"].ToString();
                        txtLogradouro.Text = reader["enderASS"].ToString();
                        txtCidade.Text = reader["cidadeASS"].ToString();
                        txtUF.Text = reader["estadoASS"].ToString();
                        txtBairro.Text = reader["bairroASS"].ToString();
                        txtnum.Text = reader["numcasaASS"].ToString();
                        txtNomeResp.Text = reader["nomerespASS"].ToString();
                        lblFoto.Text = reader["imgASS"].ToString();

                    }

                    if (lblFoto.Text != "Foto")
                    {
                        pictureFoto.Image = Image.FromFile(lblFoto.Text);
                    }


                    ReconheceuMenorIdade();
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            mskRG.Text = "";
            mskCPF.Text = "";
            txtNomeResp.Text = "";
            lblFoto.Text = "";
            mskCelular.Text = "";
            mskCEP.Text = "";
            txtLogradouro.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtUF.Text = "";
            txtnum.Text = "";
            mskTelComer.Text = "";
            mskCelular.Text = "";
            pictureFoto.Image = null;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
