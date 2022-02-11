using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Questionnaire data = new Questionnaire();
            string[] dataName = new string[] { "Имя", "Фамилия", "Возраст", "Рост(см)", "Вес(кг)" };
            dataName = Questionnaire.Question(dataName);
            data.Name = dataName[0];
            data.Surname = dataName[1];            
            data.Age = Questionnaire.TryParse(dataName[2]);
            data.Height = Questionnaire.TryParse(dataName[3]);
            data.Weight = Questionnaire.TryParse(dataName[4]);

            Questionnaire.ShowData(dataName); // вывод введённых данных             

            Questionnaire.ShowDataWithGluing(dataName); // вывод со склеиванием                        

            Console.WriteLine($"Индекс массы тела: {BodyMassIndex.CalcBodyMassIndex(data.Weight, data.Height)}"); // расчёт индекса массы тела из введёных значений           
            
            PointClass.EnterPoint(); // вывод расстояния между точками

            SwapData.Swap(1, 4); // обмен данных переменных

            WriteClass.WriteData("Александр", "Алпатов", "Ставрополь"); // вывод данных в центе консоли

            Console.ReadLine();
        }

          
    }
}
