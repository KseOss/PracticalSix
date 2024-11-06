using System;
using System.Windows.Media.Media3D;
namespace LIB_6_3
/*������������ ����� Man (�������), � ������: ���, �������, ��� � ���. �����������
�������� ��� ���������� �������� �� 1 ���. ����������� �������� ��� ����������� 
��� ������� ��� �����.
 */
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public void SetParams(string name, int age, string gender, double weight) // ����� ��� ��������� ���� ����������
        {
            Name = name; //������������� ���
            Age = age; //������������� �������
            Gender = gender; //������������� ���
            Weight = weight; // ������������� �������
        }
        public void SetParams(string name, int age) //������������� ����� ��� ��������� ������ ����� � ��������
        {
            Name = name;
            Age = age;
        }
        public void RiseAge() //����� �� ���������� ����� �� 1 ���
        {
            Age++;
        }
        public void RiseAgeTwo() //����� �� ���������� ����� �� 1 ���
        {
            Age++;
        }
        public string CompareWeight(Man other)//�������� MAN other - ��� ���������
        {
            if (this.Weight > other.Weight)
            {
                return $"{this.Name} �������, ��� {other.Name}";
            }
            else if (this.Weight < other.Weight)
            {
                return $"{this.Name}, ����� ��� {other.Name}";
            }
            return $"{this.Name} � {other.Name} ����� ���������";
        }
        public override string ToString()
        {
            return $"���: {Name}, �������: {Age}, ���: {Gender}, ���: {Weight}";
        }
    }


}
