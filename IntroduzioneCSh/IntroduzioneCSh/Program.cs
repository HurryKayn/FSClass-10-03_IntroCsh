namespace IntroduzioneCSh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dipendente mario = new Dipendente();
        }
        internal class Dipendente
        {

            public string nome;
            public string cognome;
            public string email;
            private int eta;
            public decimal stipendio;

            public int Eta
            {
                get { return eta; }
                set { if (value >= 18) eta = value; }
            }

            public void SetEta(int eta)
            {
                this.eta = eta;
            }

            public int GetEta()
            {
                return this.eta;
            }
            public void TimbroEntrata()
            {

            }

            public void TimbroUscita()
            {

            }
        }

        public class Intro
        {
            public void PrintName()
            {
                Console.WriteLine("metodo stampa nome");
            }
        }

    }
}