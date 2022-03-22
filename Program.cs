using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjeZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
            Kugla x = new Kugla();
            Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
            Kvadar y = new Kvadar();
            Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
            Kocka z = new Kocka();
            Console.WriteLine(GeometrijskoTijelo.BrojacTijela);

            Console.ReadKey();
        }
    }

    class GeometrijskoTijelo
    {
        private double Volumen, Oplosje;
        public static int BrojacTijela = 0;

        public GeometrijskoTijelo()
        {
            BrojacTijela++;
        }
        
    }

    class Kugla : GeometrijskoTijelo
    {

    }

    class Kvadar : GeometrijskoTijelo
    {

    }

    class Kocka : Kvadar
    {

    }

}
