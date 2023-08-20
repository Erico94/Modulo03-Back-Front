using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Exercicio04.ResolucaoDoExercicio
{
    public class PedidoOnline : IPedidoISP, IEntregaPedido
    {
        public void PedidoConfirmado()
        {
            //código
        }
        public void PedidoEmPreparo()
        {
            //código
        }
        public void PedidoPronto()
        {
            //código
        }
        public void PedidoEmRotaDeEntrega()
        {
            //código
        }

    }

    public class PedidoBalcao : IPedidoISP, IBalcaoPedido
    {
        public void PedidoConfirmado()
        {
            //código
        }
        public void PedidoEmPreparo()
        {
            //código
        }
        public void PedidoPronto()
        {
            //código
        }
        public void PedidoRetiradoNoBalcao()
        {
            //código
        }

    }
}
