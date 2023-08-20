using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Exercicio04
{
    public interface IPedido
    {
        void PedidoConfirmado();
        void PedidoEmPreparo();
        void PedidoPronto();
        void PedidoEmRotaDeEntrega();
        void PedidoRetiradoNoBalcao();
    }
}
