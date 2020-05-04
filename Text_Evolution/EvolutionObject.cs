namespace Text_Evolution
{
    class EvolutionObject
    {
        /// <summary>
        /// Фраза.
        /// </summary>
        public string word;

        /// <summary>
        /// Инициализация объекта.
        /// </summary>
        /// <param name="word">Фраза.</param>
        public EvolutionObject(string word)
        {
            this.word = word;
        }
        /// <summary>
        /// Инициальзация пустым значением
        /// </summary>
        public EvolutionObject()
        {
            this.word = "";
        }

        /// <summary>
        /// Возвращает кофициент подобия поля word параметру.
        /// </summary>
        /// <param name="s">строка для сравнения.</param>
        /// <returns></returns>
        public int SimilarityCoefficient(string s)
        {
            int k = 0;
            if (word.Length <= s.Length)
            {
                for (int i = 0; i < word.Length; i++)
                    if (word[i] == s[i]) k++;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                    if (word[i] == s[i]) k++;
            }
            return k;
        }
    }
}
