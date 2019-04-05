using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_BS_CPIR
{
    public class Agendamentos : Associados
    {
        #region SETTERS/GETTERS
        public int codigoagendamento { get; set; }
        public string situacaoagendament { get; set; } // A = Alugado e D disponpivel
        public DateTime dataagendamento { get; set; }
        #endregion

        public Agendamentos()
        {
            getCodigo();
        }
    }
    
}
