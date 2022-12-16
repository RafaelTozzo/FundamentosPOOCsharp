namespace FundamentosPOOCsharp
{
    public class Generics
    {
        public static void GenericsEx()
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();

            var context = new DataContext<IPerson, Payment, Subscription>();

            context.Salve(payment);
            context.Salve(person);
            context.Salve(subscription);
        }

        public class DataContext<P, PA, S>
        where P : IPerson
        where PA : Payment
        where S : Subscription
        {
            public void Salve(P entity) { }
            public void Salve(PA entity) { }
            public void Salve(S entity) { }
        }

        public interface IPerson { }

        public class Person : IPerson { }

        public class Payment { }

        public class Subscription { }
    }
}