namespace Pract_8.Tools
{
    public class Beet: Vegetables
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
            string result = "Морковь укрепляет иммунитет, улучшает работу пищеварительной системы. " +
                "\nИсследования показали, что люди, которые ели наибольшее количество моркови, " +
                "на 40% снижали риски развития макулярной дегенерации, куриной слепоты с возрастом." +
                "\nОрганические соединения в моркови являются отличными минеральными антиоксидантами. " +
                "\nМорковь также можно использовать как натуральный абразив, что может помочь тщательно почистить зубы после приема пищи.";

            return result;
        }

        public override int NumberByWeight(int weight)
        {
            int minimumNumber = 3;

            int result = weight * Convert.ToInt32(minimumNumber);

            return result;
        }
    }
}
