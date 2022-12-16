using System.Collections.Generic;
using System.Linq;

namespace FundamentosPOOCsharp
{
    public class Lists
    {
        public static void ListsEx()
        {
            var payments1 = new List<Payment>(); // Permite adicionar e remover elementos da lista

            IList<Payment> payments2 = new List<Payment>(); // Permite adicionar e remover elementos da lista

            IEnumerable<Payment> payments3 = new List<Payment>(); // Tipo mais base de lista

            IEnumerable<Payment> payments4 = new List<Payment>(); // Tipo IEnumerable é praticamente uma Lista de leitura, não pode usar .add bom para restringir o codigo

            payments1.Add(new Payment(1));
            payments1.Add(new Payment(4));
            payments1.Add(new Payment(7));
            payments1.Add(new Payment(10));
            payments1.Add(new Payment(15));

            foreach (var item in payments1)
            {
               Console.WriteLine(item.Id); 
            }

            var payment = payments1.First(x => x.Id == 7);
            Console.WriteLine(payment.Id);
        }

        public class Payment
        {
            public int Id { get; set; }
            public Payment(int id)
            {
                Id = id;
            }
        }
    }
}