using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Restaurante
    {
        public string Cidade { get; set; }
        public bool Delivery { get; set; }
        public int PedidosPendentes { get; set; }
        public int TempoEstimadoEntrega  { get; set;}

        public Restaurante(string cidade, bool delivery, int pedidosPendentes)
        {
            this.Cidade = cidade;
            this.Delivery = delivery;
            this.PedidosPendentes = pedidosPendentes;
            TempoEstimadoEntrega = 10 + 2 * pedidosPendentes;
        }

        public void EntregarPedido(Pessoa pessoa)
        {
           if (!Delivery)
            {
                Console.WriteLine("Esse restaurante não faz entregas!");
                return;
            }


           if (pessoa.Cidade == Cidade) {
                Console.WriteLine("Seu pedido foi aceito, o tempo de entrega será: ");
                Console.WriteLine(string.Empty);
                Console.WriteLine(TempoEstimadoEntrega +" minutos.");
            } else
            {
                Console.WriteLine("Entrega não disponível para sua cidade");
            }
        }
    }
}
