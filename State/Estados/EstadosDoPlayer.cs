using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.State.Estados
{
    public interface EstadosDoPlayer
    {
        void GanhaPontosExtras(Player player);
        void Zera();
        void Perde();
        void Finaliza();
    }
}
