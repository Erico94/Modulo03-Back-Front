using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Exercicio04.ResolucaoDoExercicio
{
    public interface IPedidoISP
    {
        void PedidoConfirmado();
        void PedidoEmPreparo();
        void PedidoPronto();
    }
    
    public interface IEntregaPedido
    {
        void PedidoEmRotaDeEntrega();
    }

    public interface IBalcaoPedido
    {
        void PedidoRetiradoNoBalcao();
    }
}
