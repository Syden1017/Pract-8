namespace Pract_8.Tools
{
    public class Vegetables
    {
        // Поля класса
        private string _vitamins;
        private int _carbohydrates;
        private int _acids;

        // Свойства класса
        public string Vitamins
        {
            get
            {
                return _vitamins;
            }

            set 
            {
                _vitamins = value;
            }
        }

        public int Carbohydrates
        {
            get
            {
                return _carbohydrates;
            }

            set 
            { 
                _carbohydrates = value;
            }
        }

        public int Acids
        {
            get
            {
                return _acids;
            }

            set
            {
                _acids = value;
            }
        }

        // Методы класса
        /// <summary>
        /// Выводит сообщение о пользе овощей
        /// </summary>
        /// <returns>Сообщение с пользой овощей</returns>
        public virtual string Benefit()
        {
            string result = "Все овощи очень полезны и имеют много полезных свойвств." +
                "\nНапример, в каждом из овощей много углеводов, " +
                "\nкоторые являются источником \nэнергии в теле человека." +
                "\nТакже овощи очищают организм от шлаков и токсинов.";

            return result;
        }

        /// <summary>
        /// Выводит сообщение с разницей между фруктами и овощами
        /// </summary>
        /// <returns>Сообщение с разницей между фруктами и овощами</returns>
        public string VegetablesDifferenceBetweenFruits()
        {
            string result = "Овощами считают плоды травянистых растений, \nс гибким стеблем и без коры. " +
                "\nА к фруктам, как правило, относят плоды кустарников и деревьев, \nимеющие сладкую мякоть с семенами, " +
                "\nобразовавшуюся из завязи цветка. " +
                "\nФрукты ростут на дереве, а овощи на грядке. " +
                "\nФруктом обычно называют любой плод состоящий из мякоти и \nсемян и образовавшийся из завязи цветка.";

            return result;
        }

        /// <summary>
        /// Выводит сообщение с количеством полезных веществ
        /// </summary>
        /// <returns>Сообщение с количеством полезных вещейств</returns>
        public virtual string VegetablesNutrientsAmount()
        {
            string result = "В овощах находятся " +
                "\n(все значение показаны в расчёте на \n100 грамм сырых овощей):" +
                "\nВитамин С: от 5 до 250 мг;" +
                "\nПровитамин А: от 0,02 до 10 мг;" +
                "\nКаротин: от 0,01 до 12 мг.";
            
            return result;
        }

        /// <summary>
        /// Рассчитывает количество овощей (в граммах), необходимые человеку по его весу
        /// </summary>
        /// <param name="weight">Вес человека (в кг)</param>
        /// <returns>Рассчитанное количество овощей (в граммах)</returns>
        public virtual int NumberByWeight(int weight)
        {
            int minimumNumber = 5;

            int result = weight * Convert.ToInt32(minimumNumber);

            return result;
        }

        /// <summary>
        /// Возвоащает сообщение со списком овощей
        /// </summary>
        /// <returns>Сообщение со списком овощей</returns>
        public string VegetablesList()
        {
            string result = "Небольшой список овощей:" +
                "\n-Авокадо;" +
                "\n-Баклажан;" +
                "\n-Горох;" +
                "\n-Зелень;" +
                "\n-Капуста;" +
                "\n-Лук;" +
                "\n-Морковь;" +
                "\n-Огурец;" +
                "\n-Петрушка;" +
                "\n-Свекла.";

            return result;
        } 
    }
}