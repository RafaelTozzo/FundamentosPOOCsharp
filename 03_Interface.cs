namespace FundamentosPOOCsharp
{
    public class Interface
    {
        public static void InterfaceEx()
        {

        }

        public class Payment : IPayment // A classe vai fazer tudo que o contrato pede
        {
            public DateTime DueDate { get; set; }

            public void Pay(double value)
            {

            }
        }

        public class PaymentCreditCard : IPayment // A classe vai fazer tudo que o contrato pede
        {
            public DateTime DueDate { get; set; }

            public void Pay(double value)
            {
                
            }
        }

        public interface IPayment //Não tem implementação, é um contrato
        {
            DateTime DueDate { get; set; }

            void Pay(double value);
        }
    }
}