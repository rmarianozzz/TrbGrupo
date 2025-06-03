namespace Ead
{
    public class Aluno
    {
        private static int contadorId = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }

        public Aluno(string Nome, int Idade)
        {
            this.Id = contadorId++;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Curso = Curso;
        }
    }
}
