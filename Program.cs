using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedjivanje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno(false);
            Crnogoricno Bor = new Crnogoricno(true);
            Console.WriteLine("Hrast: " + Hrast.ToString());
            Console.WriteLine("Bor: "+Bor.ToString());

            Console.ReadKey();
        }
    }
    class Biljka
    {

    }

    class Stablo : Biljka
    {
        bool otpadajuListovi;
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public Stablo(bool otpadajuListovi)
        {
            OtpadajuListovi = otpadajuListovi;
        }
    }

    class Cvijet : Biljka
    {

    }

    class Crnogoricno : Stablo
    {
        bool otpadajulistovi;
        public Crnogoricno(bool OtpadajuListovi) : base(OtpadajuListovi)
        {
            otpadajulistovi = OtpadajuListovi;   
        }
        public override string ToString()
        {
            return "OtpadajuListovi = " + otpadajulistovi;
        }
    }

    class Bjelogoricno : Stablo
    {
        bool _OtpadajuListovi;
        public Bjelogoricno(bool OtpadajuListovi) : base(OtpadajuListovi)
        {
            _OtpadajuListovi= OtpadajuListovi;  
        }
        public override string ToString()
        {
            return "OtpadajuListovi = " + _OtpadajuListovi;
        }
    }
}
