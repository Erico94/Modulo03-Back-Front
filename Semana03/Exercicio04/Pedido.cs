using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Exercicio04
{
    //Este código não está nos padrões Interface segregation principle, veja que tanto a classe PedidoEntrega quanto a PedidoBalcao são 
    //obrigadas a implementar métodos que não são de seu real interesse. A resolução do exerício está na pasta ResolucaoDoExercicio
    public class PedidoEntrega : IPedido
    {
        public void PedidoConfirmado()
        {
            //Código
        }
        public void PedidoEmPreparo()
        {
            //Código
        }
        public void PedidoPronto()
        {
            //Código
        }
        public void PedidoEmRotaDeEntrega()
        {
            //Código
        }
        public void PedidoRetiradoNoBalcao()
        {
            //Código
        }
    }

    public class PedidoBalcao : IPedido
    {
        public void PedidoConfirmado()
        {
            //Código
        }
        public void PedidoEmPreparo()
        {
            //Código
        }
        public void PedidoPronto()
        {
            //Código
        }
        public void PedidoEmRotaDeEntrega()
        {
            //Código
        }
        public void PedidoRetiradoNoBalcao()
        {
            //Código
        }
    }
}
