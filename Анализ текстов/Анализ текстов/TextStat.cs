//Дает возможность ссылаться на классы, которые находятся в пространстве имен System, 
//так что их можно использовать, не добавляя System. перед именем типа.
using System;
//Содержит интерфейсы и классы, определяющие универсальные коллекции, 
//которые позволяют пользователям создавать строго типизированные коллекции, 
//обеспечивающие повышенную производительность и безопасность типов 
//по сравнению с неуниверсальными строго типизированными коллекциями.
using System.Collections.Generic;
using System.Collections;
//Пространство имен содержит классы, представляющие ASCII и Unicode 
//кодировок; абстрактные базовые классы для преобразования блоков символов
//и из блоков байтов
using System.Text;

// объявления области, которая содержит набор связанных объектов. Можно использовать 
//пространство имён для организации элементов кода, а также для создания глобально 
//уникальных типов.
namespace Анализ_текстов
{
    /// <summary>
    /// Калькулятор статистики для текстов
    /// </summary>
    //Определения класса с именем Program
    class TextStat
    {

        /*------ private----------------------------------*/
        // Массив возможных разделителей слов 
        private static char[] _signs =
            new char[] {' ', '.', '.', '!', '?', ':', '-', ';', '(', ')', '~',
                        '_', '\"', '\\', '/', '%', '@', '<', '>', '=', '+' ,'*',
                        '{' ,'}', '[' ,']', '#', '№', '$', '^', '|', '&'}; 
        // Текст для разбора 
        private string _text;
        
        // Контейнер слов (key - слово, value - частота) 
        private Dictionary<string, int> _Words;
        
        // Контейнер символов (key - символ,, value - частота) 
        private Dictionary<char, int> _Characters;
        
        // Общее количество слов 
        private int _wordsCount;

        // Общее количество символов 
        private int _charsCount;

        /*------ public----------------------*/
        /// <summary>
        /// Конструктор
        /// </summary>
        public TextStat(string text)
        {
            // Подготовка текста
            StringBuilder sb = new StringBuilder(text);
            //Замещает все вхождения указанного символа в данном 
            //экземпляре на другой указанный знак.
            sb.Replace('\r', ' '); 
            sb.Replace('\n', ' '); 
            sb.Replace('\t', ' ');

            // Инициализация полей. Запоминаем текст
            _charsCount = sb.Length;
            _wordsCount = 0; 
            _text = sb.ToString();
        }
        /// <summary>
        /// Возвращает общее количество слов
        /// </summary> 
        public int WordsCount 
        {
            //get определяет метод доступа в свойстве или индексаторе, который 
            //извлекает значение свойства или элемент индексатора.
            get { return _wordsCount; }
        }

        ///<summary> 
        /// Возвращает общее количество символов
        /// </summary>
        public int CharsCount 
        {
            //get определяет метод доступа в свойстве или индексаторе, который 
            //извлекает значение свойства или элемент индексатора.
            get { return _charsCount; }
        }

        /// <summary>
        /// Вычислить статистику
        /// </summary>
        public void Run()
        {
            // Разбиваем текст на слова
            //Split разбивает строку на подстроки в зависимости от знаков в массиве.Можно указать,
            //включают ли подстроки пустые элементы массива.
            string[] words = _text.Split(_signs, StringSplitOptions.RemoveEmptyEntries);
            _wordsCount = words.Length;

            // Создаем словарь для слов и заносим туда уникальные слова.
            // Ключ - слово, значение - количество повторений слова в тексте.
            _Words = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            //Оператор foreach повторяет группу вложенных операторов для каждого элемента 
            //массива или коллекции объектов
            //Считаем частоту использования слова
            foreach (string word in words)
            {
                if (_Words.ContainsKey(word))
                    _Words[word]++;
                else
                    _Words.Add(word, 1);
            }

            // Создаем словарь для символов и заносим туда уникальные.
            // Ключ - символ, значение - количество его повторений в тексте. 
            _Characters = new Dictionary<char, int>();
            //Оператор foreach повторяет группу вложенных операторов для каждого элемента 
            //массива или коллекции объектов
            //Считаем частоту использования символа
            foreach (char ch in _text)
            {
                //Определяем, содержится ли элемент с указанным ключом
                if (_Characters.ContainsKey(Char.ToLower(ch)))
                    _Characters[Char.ToLower(ch)]++;
                else
                    _Characters.Add(Char.ToLower(ch), 1);
            }
        }
        /// <summary>
        /// Получить частоту использования слов
        /// </summary>
        /// <returns>Список слов, отсортированный по их частоте</returns>
        /// 
        public List<WordStatInfo> GetWordStat()
        {
  
            if (_Words == null) return null;

            List<WordStatInfo> wordList = new List<WordStatInfo>();

            //Оператор foreach повторяет группу вложенных операторов для каждого элемента 
            //массива или коллекции объектов
            //Считаем частоту использования слова
            //Определяем пару "ключ-значение", которая может быть задана или получена.
            foreach (KeyValuePair<string, int> w in _Words)
            {
                WordStatInfo wsi = new WordStatInfo(w.Key, w.Value); 
                wordList.Add(wsi);
            }

            wordList.Sort(Compare); 
            
            return wordList;
        }
        /// <summary>
        /// <param>Компаратор для сортировки объектов WordStatlnfo.</para>
        /// <param>Частота сортируется по возрастанию, значения - в алфавитном порядке.</para> 
        /// </summary>
        private int Compare(WordStatInfo w1, WordStatInfo w2)
        {
            //Сравнивает текущий экземпляр с другим объектом того же типа и возвращает 
            //целое число, которое показывает, расположен ли текущий экземпляр перед, 
            //после или на той же позиции в порядке сортировки, что и другой объект.
            if (w1.Count == w2.Count)
                return w1.Word.CompareTo(w2.Word);
            else
                return w2.Count.CompareTo(w1.Count);
        }
        /// <summary>
        /// Получить частоту использования символов
        /// </summary>
        /// <returns>Список символов, отсортированный по их частоте</returns> 
        public List<CharStatInfo> GetCharStat()
        {
            if (_Characters == null) 
                return null;
            
            List<CharStatInfo> charList = new List<CharStatInfo>();

            //Оператор foreach повторяет группу вложенных операторов для каждого элемента 
            //массива или коллекции объектов
            //Считаем частоту использования символа
            //Определяем пару "ключ-значение", которая может быть задана или получена.
            foreach (KeyValuePair<char, int> ch in _Characters)
            {
                CharStatInfo csi = new CharStatInfo(ch.Key, ch.Value); 
                charList.Add(csi);
            }

            //Сравниваем два указанных объекта String (с учетом или без учета регистра) 
            //и возвращает целое число, которое показывает их относительное положение в 
            //порядке сортировки.
            charList.Sort(Compare); 

            return charList;
        }

        /// <summary>
        /// <para>Компаратор для сортировки объектов CharStatInfo.</para>
        /// <para>Частота сортируется по возрастанию, значения - в алфавитном порядке.</para> 
        /// </summary>
        private int Compare(CharStatInfo chi, CharStatInfo ch2)
        {
            //Сравниваем текущий экземпляр с другим объектом того же типа и возвращает 
            //целое число, которое показывает, расположен ли текущий экземпляр перед, 
            //после или на той же позиции в порядке сортировки, что и другой объект.
            if (chi.Count == ch2.Count)
                return chi.Character.CompareTo(ch2.Character);
            else
                return ch2.Count.CompareTo(chi.Count);
        }
    }

    /// <summary>
    /// Частота использования слова
    /// </summary>
    class WordStatInfo
    {
        public string Word; //Значение - слово
        public int Count; //частота

        public WordStatInfo(string word)
        {
            Word = word;
            Count = 1;
        }

        public WordStatInfo(string word, int count) 
        {
            Word = word;
            Count = count;
        }
    }
    /// <summary>
    /// Частота использования символа
    /// </summary>
    class CharStatInfo
    {
        public char Character; //Значение - символ
        public int Count;    // частота

        public CharStatInfo(char ch)
        {
            Character = ch;
            Count = 1;
        }
        public CharStatInfo(char ch, int count)
        {
            Character = ch;
            Count = count;
        }
    }
}
