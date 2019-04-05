using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll_DB_CPIR;
using Dll_BS_CPIR;

namespace Dll_DB_CPIR
{
    public class PreparaSQL
    {
        Usuarios usuarios = new Usuarios();
        public string ConsultaUsuario()
        {
            string consultaUsuario = string.Empty;

            consultaUsuario = " SELECT * FROM USUARIOS ";
            return consultaUsuario;
        }
        public string CarregaPerfil(string usuario, string senha)
        {
            string perfil = String.Empty;

            perfil = " SELECT * FROM USUARIOS WHERE loginUSU = " + "'" + usuario + "'" + " AND senhaUSU = " + "'" + senha + "'";

            return perfil;


        }

        public string ConsultaAssociado(int ID)
        {
            string consultacliente = string.Empty;

            consultacliente = " SELECT * FROM CarregarASS WHERE codASS = " + ID;
            return consultacliente;
        }


        public string TentaLogin(string usuario, string senha)
        {
            string tentaLogin = String.Empty;

            tentaLogin = " SELECT loginUSU FROM USUARIOS WHERE loginUSU = " + "'" + usuario + "'" + " AND senhaUSU = " + "'" + senha + "'";

            return tentaLogin;


        }
        public string IncluirAssociados(Associados associados)
            //string nome, string nomeResp, string rg, string cpf, string data
            //   , string celular, string cep, string logradouro, string cidade, string bairro
            //   , string uf, string numerocasa, string telefone, string img
            
        {
            string preparaASSente = string.Empty;

            preparaASSente = "INSERT INTO ASSOCIADOS (nomeASS,cepASS,rgASS,cpfASS,datanascASS,telefonecelularASS,nomerespASS,enderASS,cidadeASS,";
            preparaASSente = preparaASSente + "bairroASS,estadoASS,telefonefixoASS,numcasaASS,imgASS)";
            preparaASSente = preparaASSente + "VALUES( " + "'" + associados.nome + "'" + "," + "'" + associados.cep + "'" + "," + "'" + associados.rg + "'";
            preparaASSente = preparaASSente + "," + "'" + associados.cpf + "'" + "," + "'" + associados.datanasc + "'" + "," + "'" + associados.celular + "'";
            preparaASSente = preparaASSente + "," + "'" + associados.nomeResp + "'" + "," + "'" + associados.logradouro + "'" + "," + "'" + associados.cidade + "'";
            preparaASSente = preparaASSente + "," + "'" + associados.bairro + "'" + "," + "'" + associados.uf + "'" + "," + "'" + associados.telefone + "'" + "," + associados.numcasa + "," + "'" + associados.img + "'" + ")";


            return preparaASSente;
        }

        public string PreparaUPDATEAssociado(Associados associados)
        {

            string preparaUPDATEASSente = string.Empty;
            preparaUPDATEASSente = "UPDATE ASSOCIADOS SET nomeASS = " + "'" + associados.nome + "'" + "," + "cepASS = " + "'" + associados.cep + "'" + "," + "rgASS = " + "'" + associados.rg + "'" + ",";
            preparaUPDATEASSente = preparaUPDATEASSente + "cpfASS = " + "'" + associados.cpf + "'" + "," +  "datanascASS = " + "'" + associados.datanasc + "'" + ",";
            preparaUPDATEASSente = preparaUPDATEASSente + "telefonecelularASS = " + "'" + associados.celular + "'" + "," + "telefonefixoASS = " + "'" + associados.telefone + "'" + ",";
            preparaUPDATEASSente = preparaUPDATEASSente + "enderASS = " + "'" + associados.logradouro + "'" + "," + "cidadeASS = " + "'" + associados.cidade + "'" + ",";
            preparaUPDATEASSente = preparaUPDATEASSente + "bairroASS = " + "'" + associados.bairro + "'" + "," + "estadoASS = " + "'" + associados.uf + "'" + "," + "numcasaASS = " + associados.numcasa + "," + "imgASS =  "  + "'" + associados.img + "'" + " WHERE codASS = " + associados.codASS;


            return preparaUPDATEASSente;

        }

        public string IncluirOBS(int ID, string obs,string perfil)
        {
            string incluirobs = string.Empty;

            incluirobs = "INSERT INTO SERVICOS(tipoSER, infoSER, assoSER)";
            incluirobs = incluirobs + "VALUES ( " + "'" + perfil + "'" + "," + "'" + obs + "'" + "," + ID + ")";

            
            return incluirobs;
        }



        public string AlterarOBS(int ID, string obs, string perfil)
        {
            string alterobs = string.Empty;

            alterobs = "UPDATE SERVICOS SET infoSER = " + "'" + obs + "'" + " WHERE tipoSER = " + "'" +  perfil + "'";
            alterobs = alterobs + " AND assoSER = " + ID;

            return alterobs;
        }
        public string ConsultaINFOR(int ID,string perfil)
        {
            string consultaUsuario = string.Empty;

            consultaUsuario = " SELECT * FROM SERVICOS WHERE tipoSER = " + "'" + perfil + "'" + " AND assoSER =  " + ID;
            return consultaUsuario;
        }
        public string IncluirAgendamento(int codAsso, string codServ, string datahora)
        {
            string incluirAgendamento = string.Empty;

            incluirAgendamento = "INSERT INTO AGENDAMENTOS (assAGE,serAGE,datahoraAGE) ";
            incluirAgendamento = incluirAgendamento + "VALUES( "  + codAsso  + "," + "'" +  codServ + "'" + "," + "'" + datahora + "'" + ")";


            return incluirAgendamento;
        }
        public string CarregaData(string data)
        {
            string retorno = String.Empty;

            retorno = " SELECT COUNT(1) FROM ConsultaAgendamentos ";
            retorno = retorno + " WHERE CONVERT(NVARCHAR,DATA,103) + ' ' +  FORMAT(DATA,'HH:mm tt') = " + "'" + data + "'";
            retorno = retorno + " AND [STATUS] = 0 ";
            retorno = retorno + " HAVING COUNT(0) > 0 ";

            return retorno;
        }
        public string CarregarAgendamento(string servico)
        {
            string retorno = String.Empty;

            retorno = " SELECT * FROM ConsultaAgendamentosAsso ";
            retorno = retorno + " WHERE CONCLUIDO = 0 AND SERVICO = " + "'" + servico + "'";
	
            return retorno;


        }
    }
}
