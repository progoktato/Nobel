using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleNobel
{
    public class Program
    {
        static List<double> arfolyam = new List<double> { 329.99, 329.45, 329.98, 330.71, 331.4, 331.58, 333.84, 334.98, 332.65, 333.21, 333.83, 335.49, 336.91, 335.53, 335.09, 336.9, 336.17, 337.16, 337.36, 337.61, 337.98, 336.65 };


        static List<int> szamsor = new List<int> { 5, 309, 796, 555, 557, 629, 703, 124, 365, 99, 654, 333, 615, 961, 560, 904, 131, 346, 567, 95, 914, 286, 549, 383, 289, 491, 482, 211, 236, 688, 679, 928, 387, 351, 571, 660, 523, 803, 209, 58, 348, 952, 191, 438, 489, 94, 963, 370, 396, 860, 575, 959, 572, 362, 90, 212, 382, 43, 253, 809, 72, 199, 775, 129, 960, 912, 415, 715, 191, 113, 222, 611, 371, 941, 340, 387, 887, 947, 941, 320, 603, 541, 771, 966, 241, 642, 445, 91, 36, 35, 602, 893, 848, 351, 859, 64, 287, 348, 231, 445 };

        static List<char> jelek = new List<char> { '+', '-', '0', '0', '+', '-', '0', '0', '+', '+', '-', '0', '0', '+', '+', '+', '-', '-', '+', '-', '+', '+', '-', '0', '0', '+', '+', '-', '0', '-', '+' };
        private static Dij DijGyarto(string csvSor)
        {
            var mezok = csvSor.Split(';');
            return new Dij(int.Parse(mezok[0]), mezok[1], mezok[2], mezok[3]);
        }

        static void Main(string[] args)
        {
            List<Dij> dijak = File.ReadAllLines("nobel.csv").Skip(1).Select(sor => DijGyarto(sor)).ToList();

            //TODO: I. rész Nobel díjak feladatsor 3) és 5) kivételével

            //TODO: II. rész
            //TODO: Adjon LINQ válaszokat a következőkre! A teljes pontértékű válaszokat egy láncolat adja.

            //1)TODO: Van-e 337 feletti érték az  arfolyam listában? (1p)

            //2)TODO: Melyik évben adták ki másodjára a "béke" Nobel-díjat? (2p)

            //3)TODO: Vegye a szamsor-ból az utolsó 20 elemet, amiben számolja meg a páros számok számát! (3p)

            //4)TODO: Hozzon létre atlagFeletti néven listát a szamsor listából a következők szerint! (3p)
            //Az új listába csak azok az elemek kerüljenek, amelyek a listában lévő számok átlagától nagyobbak! 

            //5)TODO: Írja ki az alábbi formátumban a szamsor számait csökkenő sorrendben! (4p)
            //csak minta!
            //785+765+698+435+.....+123+78+12+

            //6)TODO: Melyik évben adtak ki legtöbb "kémiai" nobel-díjat? (4p)

        }

    }
}
