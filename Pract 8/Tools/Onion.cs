using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_8.Tools
{
    public class Onion: Vegetables
    {
        // Поля класса
        private string _color;
        private string _vitamins;

        // Свойства класса
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

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

        // Методы класса
        public override string Benefit()
        {
            string result = "Лук укрепляет иммунитет, улучшает выраженность аллергии, нормализует пищеварение, важен для кроветворения. " +
                "\nРепчатый и зеленый лук – это богатые источники клетчатки. " +
                "Эти пищевые волокна не перерабатываются организмом, но зато активизируют все процессы в кишечнике, " +
                "позволяя эффективно избавляться от переработанных веществ.";

            return result;
        }

        public override int NumberByWeight(int weight)
        {
            int minimumNumber = 2;

            int result = weight * Convert.ToInt32(minimumNumber);

            return result;
        }
    }
}