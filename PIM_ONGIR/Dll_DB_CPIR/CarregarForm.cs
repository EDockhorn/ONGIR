using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Dll_DB_CPIR
{
    public class CarregarForm
    {
        PreparaSQL consulta = new PreparaSQL();
        RecuperaConexao conexao = new RecuperaConexao();

        public Boolean Usuario(string usu, string senha)
        {
            bool acesso = true;
            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(consulta.TentaLogin(usu, senha), con);
                con.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read()) acesso = true;
                else acesso = false;


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

            return acesso;
        }

        public string CarregarPerfil(string usu, string senha)
        {
            string perfil = string.Empty;

            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(consulta.CarregaPerfil(usu, senha), con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        perfil = reader["idUSU"].ToString();
                        


                    }

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

            return perfil;
        }
        public bool VerificaData(string data)
        {
            bool retorno = true;

            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {
                SqlCommand cmd = new SqlCommand(consulta.CarregaData(data), con);
                con.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read()) retorno = true;
                else retorno = false;
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

            return retorno; 
        }
        public bool VerificaNovosAgendamentos(string servico)
        {
            bool retorno = true;

            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {
                SqlCommand cmd = new SqlCommand(consulta.CarregarAgendamento(servico), con);
                con.Open();
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read()) retorno = true;
                else retorno = false;
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

            return retorno;
        }
    }

}

