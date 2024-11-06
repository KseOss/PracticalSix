using System;
using System.Windows.Media.Media3D;
namespace LIB_6_3
/*Использовать класс Man (человек), с полями: имя, возраст, пол и вес. Разработать
операцию для увеличения возраста на 1 год. Разработать операции для определения 
кто тяжелее или легче.
 */
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public void SetParams(string name, int age, string gender, double weight) // Метод для установки всех параметров
        {
            Name = name; //Устанавливает имя
            Age = age; //Устанавливает возраст
            Gender = gender; //Устанавливает пол
            Weight = weight; // Устанавлвиает возраст
        }
        public void SetParams(string name, int age) //Перегруженный метод для установки только имени и возраста
        {
            Name = name;
            Age = age;
        }
        public void RiseAge() //Метод на увеличение роста на 1 год
        {
            Age++;
        }
        public void RiseAgeTwo() //Метод на увеличение роста на 1 год
        {
            Age++;
        }
        public string CompareWeight(Man other)//параметр MAN other - имя параметра
        {
            if (this.Weight > other.Weight)
            {
                return $"{this.Name} тяжелее, чем {other.Name}";
            }
            else if (this.Weight < other.Weight)
            {
                return $"{this.Name}, легче чем {other.Name}";
            }
            return $"{this.Name} и {other.Name} весят одинаково";
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Пол: {Gender}, Вес: {Weight}";
        }
    }


}
