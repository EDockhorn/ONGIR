using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_BS_CPIR
{
    public class Associados
    {
        #region SETTERS/GETTERS
        public int codASS;
        private string Nome;
        public string nome
        {
            get { return Nome; }

            set { Nome = value; }
        
        }

        public void setCodigo(int CodASS)
        {
            codASS = CodASS;
        }

        public int getCodigo()
        {
            return codASS;
        }
                
            
            
            
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string cidade { get; set; }
        public string nomeResp { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public DateTime datanasc { get; set; }
        public DateTime datacadastro { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string numcasa { get; set; }
        public string img { get; set; }
        public string uf { get; set; }
        #endregion

        #region CONSTRUTOR
        public Associados()
        {

            nome = "Johnny";
            logradouro = " Avenida dos Palmares";
            cidade = "São Paulo";
            estado = "SP";
            bairro = "Jaguaré";
            rg = "11.111.111-2";
            cpf = "111.111.111-2";
            datanasc = System.DateTime.Now;
            telefone = "1111x1111";
             
        #endregion
        }
    }
}
