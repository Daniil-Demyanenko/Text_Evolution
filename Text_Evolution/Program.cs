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
            int k = 3; //Коэфициент количества изменений
            int N = 0; //Номер поколения
            Random rand = new Random();
            bool finded = false;


            string word = "";
            for (int j = 0; j < end.Length; j++) // Формирование случайной "популяции"
                word += abc[rand.Next(abc.Length)];

            for (int i = 0; i < population.Length; i++) // Инициализация популяции
                population[i] = new EvolutionObject(word);


            Color.LogOutLine("Первое поколение:");
            for (int i = 0; i < population.Length; i++)
            {
                Color.TextOutLine(population[i].word);
            }

            Console.WriteLine();

            int result = 0;
            while (!finded)
            {
                N++;//Увеличение номера поколения
                int max = population[0].SimilarityCoefficient(end);
                int changes = rand.Next(k);

                for (int i = 0; i < population.Length; i++) // Формирование случайных изменений
                {
                    for (int f = 0; f <= changes; f++)
                    {
                        word = population[i].word;
                        int r = rand.Next(word.Length);
                        word = word.Remove(r, 1);
                        word = word.Insert(r, abc[rand.Next(abc.Length)].ToString());
                        population[i].word = word;
                    }
                }

                for (int i = 0; i < population.Length; i++) //нахождение наибольшего коэфициента подобия
                {
                    int temp = population[i].SimilarityCoefficient(end);
                    if (temp > max)
                    {
                        max = temp;
                        result = i;
                    }
                }


                word = population[result].word;
                Color.LogOutLine("Фраза с наибольшим коэфициентом подобия (" + max + ") в популяции " + N + ":");
                Color.TextOutLine(word + "\n");

                if (max == population[result].word.Length) finded = true;
            }
        }
    }
}
