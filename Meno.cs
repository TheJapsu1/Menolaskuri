namespace Menolaskuri
{
    /// <summary>
    /// Meno -olion määritelmä.
    /// </summary>
    public class Meno
    {
        public Kategoria kategoria { get; private set; }
        
        public double rahaMaara { get; private set; }

        public string selitys { get; private set; }

        public Meno(Kategoria kategoria, double rahaMaara, string selitys)
        {
            this.kategoria = kategoria;
            this.rahaMaara = rahaMaara;
            this.selitys = selitys;
        }
    }
}