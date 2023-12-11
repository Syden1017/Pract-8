using System.Windows;
using Pract_8.Tools;

namespace Pract_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vegetables vegetables = new Vegetables();
        Сarrot carrot = new Сarrot();
        Beet beet = new Beet();
        Onion onion = new Onion();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItExercise_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Создать основной класс «Овощи», 3 класса наследника «Морковь», «Свёкла» и «Лук»." +
                "\nСоздать в основном классе 5 методов и 3 свойства." +
                "\nПридумать и создать, как минимум, " +
                "\nпо 2 метода в каждом классе-наследнике и хотя бы по 2 свойства.",
                "Задание",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void mItDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Программу написал" +
                "\nСтудент группы ИСП-32" +
                "\nШустов Александр",
                "О разработчике",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void btnVegetablesBenefit_Click(object sender, RoutedEventArgs e)
        {
            txtBoxVegetablesBenefit.Text = vegetables.Benefit();
        }

        private void btnDifferenceBetweenFruits_Click(object sender, RoutedEventArgs e)
        {
            txtBoxDifferenceBetweenFruits.Text = vegetables.VegetablesDifferenceBetweenFruits();
        }

        private void btnVegetablesNutrientsAmount_Click(object sender, RoutedEventArgs e)
        {
            txtBoxVegetablesNutrientsAmount.Text = vegetables.VegetablesNutrientsAmount();
        }

        private void btnNumberByWeight_Click(object sender, RoutedEventArgs e)
        {
            int weight = Convert.ToInt32(txtBoxWeight.Text);
            txtBoxNumberByWeight.Text = vegetables.NumberByWeight(weight).ToString();
        }

        private void btnShowVegetablesList_Click(object sender, RoutedEventArgs e)
        {
            txtBoxVegetablesList.Text = vegetables.VegetablesList();
        }

        private void btnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rBtnCarrot.IsChecked)
            {
                int weight = Convert.ToInt32(txtBoxYourWeight.Text);
                txtBoxBenefit.Text = carrot.Benefit();
                txtBoxNumber.Text = carrot.NumberByWeight(weight).ToString();
            }
            else if ((bool)rBtnBeet.IsChecked)
            {
                int weight = Convert.ToInt32(txtBoxYourWeight.Text);
                txtBoxBenefit.Text = beet.Benefit();
                txtBoxNumber.Text = beet.NumberByWeight(weight).ToString();
            }
            else if ((bool)rBtnOnion.IsChecked)
            {
                int weight = Convert.ToInt32(txtBoxYourWeight.Text);
                txtBoxBenefit.Text = onion.Benefit();
                txtBoxNumber.Text = onion.NumberByWeight(weight).ToString();
            }
        }
    }
}