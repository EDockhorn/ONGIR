using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_Uteis;
using Dll_BS_CPIR;
using Dll_DB_CPIR;

namespace PIM_ONGIR
{
    public partial class FrmOBS : Form
    {
        Dll_DB_CPIR.Executa executar = new Executa();
        Dll_DB_CPIR.PreparaSQL preparasql = new PreparaSQL();
        RecuperaConexao conexao = new RecuperaConexao();

        public int ID;
        public int operacao;
        public string perfil;
        bool tem = false;


        public FrmOBS()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (operacao == 1 && tem == false)
            {
                if (MessageBox.Show("Deseja incluir essa observação?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    executar.Executar(preparasql.IncluirOBS(ID, txtOBS.Text, perfil));
                    MessageBox.Show("Observação incluída com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    operacao = 2;
                    dlgPrintPreview.ShowDialog();

                }
            }
            else
            {
                if (MessageBox.Show("Deseja acrescentar mais observações?", "Alterando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    executar.Executar(preparasql.AlterarOBS(ID, txtOBS.Text, perfil));
                    MessageBox.Show("Observação alterada com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dlgPrintPreview.ShowDialog();
                }
            }
        }

        private void FrmOBS_Load(object sender, EventArgs e)
        {
            txtOBS.Text = "";
            RecarregaINFO();
            
        }

        private bool RecarregaINFO()
        {
            
            try
            {
                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(preparasql.ConsultaINFOR(ID,perfil), con);

                

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        txtOBS.Text = leitor["infoSER"].ToString();
                        tem = true;
                    }
                    leitor.Close();
  
                }
                con.Close();
                return tem;

                
    
            }
            catch
            {
                MessageBox.Show("Erro ao conectar à base de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tem;
            }
        }

        private void txtOBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "CPIR";
            System.Drawing.Font fntString = new Font("Times New Roman", 28,
                                FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 240, 100);

            strDisplay = "Avaliações";
            fntString = new System.Drawing.Font("Times New Roman", 22,
                                FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 320, 150);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            


        }
        }
        
    }

