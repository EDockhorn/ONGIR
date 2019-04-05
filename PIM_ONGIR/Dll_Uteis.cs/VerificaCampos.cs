using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_DB_CPIR; 


namespace Dll_Uteis.cs
{
    public class VerificaCampos
    {
        Dll_DB_CPIR.CarregarForm VerificaBase = new CarregarForm();

        public string VerificaAssociados(string nome,string nomeResp, string rg, string cpf, string data
               , string celular, string cep, string logradouro, string cidade, string bairro
               , string uf, string numerocasa, string telefone)
        {
            string retorno = string.Empty;
            if (nome == "") retorno = "nome";
            else if (nome.Length < 7) retorno = "nomecurto";
            else if (rg.Length != 12) retorno = "rg";
            else if (cpf.Length != 14) retorno = "cpf";
            else if (Convert.ToDateTime(data).AddYears(18) > DateTime.Now && nomeResp == "")  retorno = "nomeresp";
            else if (data.Length != 10) retorno = "data";
            else if (celular == "") retorno = "celular";
            else if (cep.Length != 9) retorno = "cep";
            else if (logradouro == "") retorno = "logradouro";
            else if (cidade == "") retorno = "cidade";
            else if (bairro == "") retorno = "bairro";
            else if (uf == "") retorno = "uf";
            else if (numerocasa == "") retorno = "numerocasa";


            return retorno;
        }

        public string VerificaAgendamento(string nome,int codservico,string data)
        {
            string retorno = string.Empty;
            bool checadata = true;

            //Verifica Horário informado pelo Usuário:
            checadata = VerificaBase.VerificaData(data);

            if (nome == "") retorno = "associado";
            else if (codservico == -1) retorno = "servico";
            else if (checadata == true) retorno = "data";

            return retorno;

        }
        
    }
}
