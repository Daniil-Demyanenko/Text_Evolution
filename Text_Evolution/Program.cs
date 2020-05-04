using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ !?:;\"'().,"; //Алфавит для перебора
            string end = "HELLO, WORLD!!!"; //Фраза, которая должна получиться
            EvolutionObject[] population = new EvolutionObject[10]; //"Популяция" фраз
            int N = 0; //Номер поколения
            Random rand = new Random();
            bool finded = false;

            for (int i = 0; i < population.Length; i++)
            {
                string word = "";
                for (int j = 0; j < end.Length; j++)
                    word += abc[rand.Next(abc.Length)];
                population[i] = new EvolutionObject(word);
            }

            while (!finded)
            {

            }
        }
    }
}
