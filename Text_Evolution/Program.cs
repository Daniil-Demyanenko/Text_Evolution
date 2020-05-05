using System;
using System.Numerics;

namespace Text_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + //Алфавит для перебора
                         "abcdefghijklmnopqrstuvwxyz" + 
                         "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                         "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" +
                         "1234567890" +
                         " !?:;\"'().,-_`~@#№$%^&*+=/|\\\n\t<>";

            //string end = "Семь бед - один ответ: Костыль и велосипед!\nHello World!!!"; //Фраза, которая должна получиться
            string end = "Мы,\nонанисты,\nребята\nплечисты!\nНас\nне заманишь\nтитькой мясистой!\nНе\nсовратишь нас\nп*здовою\nплевой!\nКончил\nправой,\nработай левой!!!";
            EvolutionObject[] population = new EvolutionObject[8000]; //"Популяция" фраз
            int k0 = 0; //Нижняя граница коэфициента количества изменений
            int k1 = 1; //Верхняя граница коэфициента кол-ва изменений [k0 ; k1],  => k0 < k1
            int N = 0; //Номер поколения
            Random rand = new Random();
            bool finded = false;

            k1++;
            if (k0 > k1) { int k = k0; k0 = k1; k1 = k; }

            string word = "";
            for (int j = 0; j < end.Length; j++) // Формирование случайной "популяции"
                word += abc[rand.Next(abc.Length)];

            for (int i = 0; i < population.Length; i++) // Инициализация популяции
                population[i] = new EvolutionObject(word);


            Color.LogOutLine("Первое поколение:");
            Color.TextOutLine(population[0].word);

            Console.WriteLine();

            int result = 0;
            while (!finded)
            {
                N++;//Увеличение номера поколения
                int changes = rand.Next(k0, k1);

                for (int i = 1; i < population.Length; i++) // Формирование случайных изменений
                {
                    for (int f = 0; f < changes; f++)
                    {
                        word = population[i].word;
                        int r = rand.Next(word.Length);
                        word = word.Remove(r, 1);
                        word = word.Insert(r, abc[rand.Next(abc.Length)].ToString());
                        population[i].word = word;
                    }
                }


                int max = population[0].SimilarityCoefficient(end);
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

                Color.LogOutLine("Фраза с наибольшим коэфициентом подобия (" + max + ") в поколении " + N + ":");
                Color.TextOutLine(word + "\n");
                for (int i = 0; i < population.Length; i++)// Формирование следующего поколение
                    population[i].word = word;

                if (max == population[result].word.Length) finded = true;
            }

            #region Это лучше не видеть
            Color.LogOut("В популяции появилась нужная фраза в ");
            Color.TextOut(N.ToString());
            Color.LogOutLine(" поколении.");
            Color.LogOut("Если бы использовался простой алгоритм перебора, то вероятность появления \n" +
                             "этого слова в поколении составляла бы ");
            Color.TextOut("1/("+abc.Length + "^" + end.Length+")");
            Color.LogOut(" или же ~ ");
            Color.TextOut("1/("+BigPow(abc.Length, end.Length)+")");
            Color.LogOutLine(".");
            Color.TextOut(abc.Length.ToString());
            Color.LogOutLine(" - количество символов алфавита.");
            Color.TextOut(end.Length.ToString());
            Color.LogOutLine(" - количество символов в фразе.");
            #endregion
            Console.ReadLine();
        }

        static string BigPow(int a, int b)
        {
            
            string str = BigInteger.Pow(a, b).ToString();
            string result = str[0] + "," + str[1] + str[2] + str[3] + "*10^" + (str.Length - 1);
            return result;
        }
    }
}
