using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.State.Estados
{
    public interface IEstadosDoPlayer
    {
        void GanhaPontosExtras(Player player);
        public void SalvaPrisioneiro(Player player);
        void Zera(Player player);
        void Perde(Player player);
        void Finaliza(Player player);
    }
}
