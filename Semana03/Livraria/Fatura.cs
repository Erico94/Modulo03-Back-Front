using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Livraria
{
    public class Fatura
    {

        public Livro livro;
        public int quantidade;
        public double porcDesconto;
        public double porcImposto;
        public double total;

        public Fatura(Livro livro, int quantidade, double porcDesconto, double porcImposto)
        {
            this.livro = livro;
            this.quantidade = quantidade;
            this.porcDesconto = porcDesconto;
            this.porcImposto = porcImposto;
            total = calcularTotal();
        }

        public double calcularTotal()
        {
            double preco = (livro.preco - livro.preco * porcDesconto) * quantidade;

            double precoComImposto = preco * (1 + porcImposto);

            return precoComImposto;
        }
    }
}
