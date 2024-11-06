using LIB_6_3;
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

namespace PracticalSix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Man person; //Создает поле person типа Man для хранения информации о человеке

        public MainWindow()
        {
            InitializeComponent();
            person = new Man();
        }
        private void Exit_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - выход
        {
            Application.Current.Shutdown();
        }

        // Обработчик кнопки "О программе"
        private void About_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - о программе
        {
            MessageBox.Show("Разработчик: Сухомяткина Ксения\nНомер работы: 6\nЗадание: Использовать класс Man (человек), с полями: имя, возраст, пол и вес. Разработать операцию для увеличения возраста на 1 год. Разработать операции для определения кто тяжелее или легче", "О программе");
        }
        private void SetParams_Click(object sender, RoutedEventArgs e)
        {
            person.SetParams(NameTB.Text, int.Parse(AgeTB.Text), GenderTB.Text, double.Parse(WeightTB.Text));//Передает введеные методы в SetParams
            OutputTB.Text = person.ToString();//Обновляет текст в текстовом блоке, выводя информацию о человеке
        }
        private void SetParams_2_Click(object sender, RoutedEventArgs e)
        {
            person.SetParams(NameTB_2.Text, int.Parse(AgeTB_2.Text), GenderTB_2.Text, double.Parse(WeightTB_2.Text));//Передает введеные методы в SetParams
            OutputTB_2.Text = person.ToString();//Обновляет текст в текстовом блоке, выводя информацию о человеке
        }
        private void CompareWeightBTN_Click(object sender, RoutedEventArgs e)
        {
            string otherName = NameTB_2.Text;
            int otherAge = int.Parse(AgeTB_2.Text);
            string otherGender = GenderTB_2.Text;
            double otherWeight = double.Parse(WeightTB_2.Text);
            Man otherPerson = new Man();
            otherPerson.SetParams(otherName, otherAge, otherGender, otherWeight);

            //сравнение веса
            string compareResult = person.CompareWeight(otherPerson);
            OutputTB_3.Text = compareResult;
        }
        private void RiseAgeBTN_Click(object sender, RoutedEventArgs e)
        {
            person.RiseAge();
            OutputTB_3.Text = person.ToString();
        }
    }
}