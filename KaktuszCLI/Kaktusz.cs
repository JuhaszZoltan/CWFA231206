namespace KaktuszCLI
{

    internal class Kaktusz
    {
        public string KoznapiNev { get; set; }
        public string LatinNev { get; set; }
        public Nehezseg Nehezseg { get; set; }
        public int Vizigeny { get; set; }
        public int Fenyigeny { get; set; }

        private static readonly string[] nehezsegek 
            = { "Könnyű", "Mérsékelt", "Nehéz" };

        public override string ToString()
        {
            return
                $"Köznapi név: {KoznapiNev}\n" +
                $"Tudományos név: {LatinNev}\n" +
                $"Termesztési nehézség: {nehezsegek[(int)Nehezseg]}\n" +
                $"Vízigény: {Vizigeny} ml\n" +
                $"Fényigény: {Fenyigeny} lm";
        }

        public Kaktusz(string sor)
        {
            string[] v = sor.Split(';');
            KoznapiNev = v[0];
            LatinNev = v[1];
            Nehezseg = (Nehezseg)Array.IndexOf(nehezsegek, v[2]);
            Vizigeny = int.Parse(v[3]);
            Fenyigeny = int.Parse(v[4]);
        }
    }
    enum Nehezseg
    {
        Konnyu = 0,
        Mersekelt = 1,
        Nehez = 2,
    }
}
