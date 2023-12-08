using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        }

        private void btnDifferenceBetweenFruits_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVegetablesNutrientsAmount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNumberByWeight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowVegetablesList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}