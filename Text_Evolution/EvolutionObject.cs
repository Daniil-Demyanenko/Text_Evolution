using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Evolution
{
    class EvolutionObject
    {
        /// <summary>
        /// Фраза.
        /// </summary>
        public string content;

        /// <summary>
        /// Инициализация объекта.
        /// </summary>
        /// <param name="content">Фраза.</param>
        public EvolutionObject(string content)
        {
            this.content = content;
        }
        /// <summary>
        /// Инициальзация пустым значением
        /// </summary>
        public EvolutionObject()
        {
            this.content = "";
        }

        /// <summary>
        /// Возвращает кофициент подобия поля content параметру.
        /// </summary>
        /// <param name="s">строка для сравнения.</param>
        /// <returns></returns>
        public int SimilarityCoefficient(string s)
        {
            int k = 0;
            if (content.Length <= s.Length)
            {
                for (int i = 0; i < content.Length; i++)
                    if (content[i] == s[i]) k++;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                    if (content[i] == s[i]) k++;
            }
            return k;
        }
    }
}
