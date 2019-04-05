using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_DB_CPIR;
using Dll_BS_CPIR;
using Dll_Uteis;

namespace PIM_ONGIR
{
    public partial class FrmAgendar : Form
    {
        FrmConsultaAsso consulta = new FrmConsultaAsso();
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL preparasql = new PreparaSQL();
        Dll_Uteis.cs.VerificaCampos verificacampos = new Dll_Uteis.cs.VerificaCampos();
        Associados associados = new Associados();
        Agendamentos agendamentos = new Agendamentos();
        frmConsultaAgenda consultaagenda = new frmConsultaAgenda();
        Executa executar = new Executa();


        //Variáveis para armazenar os objetos relacionados:
        int intAsso = 0;

        public FrmAgendar()
        {
            InitializeComponent();
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            lblInfo.Text = "";
            consulta.OPReserva = 2;
            consulta.ShowDialog();
            intAsso = consulta.RetornaID();

            CarregarAssociado(intAsso);
        }
        private void CarregarAssociado(int codigo)
        {
            try
            {

                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(preparasql.ConsultaAssociado(codigo), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        txtNome.Text = leitor["nomeASS"].ToString();
                        mskCPF.Text = leitor["cpfASS"].ToString();
                        mskRG.Text = leitor["rgASS"].ToString();
                        lblFoto.Text = leitor["imgASS"].ToString();

                        if (lblFoto.Text != "Foto")
                        {
                            pictureFoto.Image = Image.FromFile(lblFoto.Text);
                        }

                    }
                    leitor.Close();
                }

                con.Close();
            }



            catch
            {
                MessageBox.Show("Erro ao carregar o associado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string RecuperaServico(int num)
        {
            string retorno = string.Empty;
            switch (num)
            {
                case 0:
                    return retorno = "PS";
                case 1:
                    return retorno = "AS";
                default:
                    return retorno = "AD";
  
            }

                 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret;

            conexao.RecuperaCNN();
            //conexao.RecuperaConexao();

            ret = verificacampos.VerificaAgendamento(txtNome.Text, cmbServico.SelectedIndex, dateData.Text + " " + dateHora.Text);
            if (ret == "")
            {
                //Passa os valores para classe
                agendamentos.nome = txtNome.Text;
                agendamentos.rg = mskRG.Text;
                agendamentos.cpf = mskCPF.Text;
                agendamentos.setCodigo(intAsso);


                if (MessageBox.Show("Deseja agendar esta consulta?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    executar.Executar(preparasql.IncluirAgendamento(intAsso, RecuperaServico(cmbServico.SelectedIndex), dateData.Text + " " + dateHora.Text));
                    MessageBox.Show("Consulta agendada com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else if (ret == "associado")
            {
                lblInfo.Text = "Por favor escolha o associado!";
                mskCPF.BackColor = System.Drawing.Color.LightCyan;
                mskRG.BackColor = System.Drawing.Color.LightCyan;
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "servico")
            {
                lblInfo.Text = "Por favor escolha o serviço!";
                cmbServico.BackColor = System.Drawing.Color.LightCyan;
                cmbServico.Focus();
            }
            else if (ret == "data")
            {
                lblInfo.Text = "Já existe uma consulta\nmarcada neste horário!";
                cmbServico.BackColor = System.Drawing.Color.LightCyan;
                cmbServico.Focus();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServico.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            mskCPF.Text = "";
            mskRG.Text = "";
            cmbServico.Text = "";
            lblFoto.Text = "";
            pictureFoto.Image = null;

            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            mskCPF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskRG_TextChanged(object sender, EventArgs e)
        {
            mskRG.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void cmbServico_TextChanged(object sender, EventArgs e)
        {
            cmbServico.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void btnLocalVeicu_Click(object sender, EventArgs e)
        {
            consultaagenda.txtBuscar.Text = txtNome.Text;
            consultaagenda.ShowDialog();
        }


    }


}