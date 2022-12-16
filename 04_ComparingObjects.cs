namespace FundamentosPOOCsharp
{
    public class ComparingObjects
    {
        public static void ComparingObjectsEx()
        {
            var pessoaA = new Pessoa(1, "Guri");
            var pessoaB = new Pessoa(1, "Guri");

            Console.WriteLine(pessoaA == pessoaB); // ---> Não consegue comparar a igualdade pois esta alocado em endereços diferentes da memoria

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa? pessoa)
        {
            return Nome == pessoa?.Nome;
        }
    }
}