namespace Toto
{
    class Fordulo
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Sorszam { get; set; }
        public int Telitalalat { get; set; }
        public int Nyeremeny { get; set; }
        public string Eredmenyek { get; set; }

        public Fordulo(string sor)
        {
            var t = sor.Split(';');
            Ev = int.Parse(t[0]);
            Het = int.Parse(t[1]);
            Sorszam = int.Parse(t[2]);
            Telitalalat = int.Parse(t[3]);
            Nyeremeny = int.Parse(t[4]);
            Eredmenyek = t[5];
        }
    }
}