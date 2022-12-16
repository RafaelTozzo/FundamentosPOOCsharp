namespace FundamentosPOOCsharp
{
    public class UsingDispose
    {
        public static void UsingDisposeEx()
        {
            using (var payment = new Payment())
            {
                Console.WriteLine("Processando o pagamento");
            }

            Console.WriteLine("*------------------*");
        }

        public class Payment : IDisposable
        {
            public Payment()
            {
                Console.WriteLine("Iniciando pagamento");
            }

            public void Dispose()
            {
                Console.WriteLine("Finalizando pagamento");
            }
        }
    }
}