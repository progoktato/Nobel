using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleNobel
{
    internal class Program
    {
        private static Dij DijGyarto(string csvSor)
        {
            var mezok = csvSor.Split(';');
            return new Dij(int.Parse(mezok[0]), mezok[1], mezok[2], mezok[3]);
        }

        static void Main(string[] args)
        {
            List<Dij> dijak = File.ReadAllLines("nobel.csv").Skip(1).Select(sor => DijGyarto(sor)).ToList();

            //TODO: Előző 4,6,7,8
            

        }

    }
}
