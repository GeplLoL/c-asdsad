using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö
{
    public class Class1
    {
        public static void Main() {
            Random rnd = new Random(); //Создаю рандомный объект
            int[] sosedi = new int[4]; //Создаю интовый массив с 4-ямя рандомными числами
            for (int i = 0; i < sosedi.Length; i++)
            {
                sosedi[i] = rnd.Next(10, 100); //задаю ограничения
                Console.WriteLine(sosedi[i]); //вывожу на консоль
            }
            int max = sosedi[0]; // создаю переменую которая берёт 0-ую позицию sosedi для нахождение максимального числа
            int min = sosedi[0]; // создаю переменую которая берёт 0-ую позицию sosedi для нахождение минимального числа
            for (int i = 1; i < sosedi.Length; i++) 
            {
                if (sosedi[i] > max) //условия для нахождения макс
                {
                    max = sosedi[i];
                }
                if (sosedi[i] < min)//условия для нахождения мин
                {
                    min = sosedi[i];
                }
            }
            Console.WriteLine("Max: " + max); //вывод
            Console.WriteLine("Min: " + min); //вывод
            string[] people = { "Rogovskii", "Denisenko", "Valtsifer","sadasdassdasdsasadasdasdsasasadsdsadsadsadsadsadsadsadsad"}; //массив с фамилиями
            string lengthPeople = people[0]; //по примеру прошлого задания сделано
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Length > lengthPeople.Length)
                {
                    lengthPeople = people[i];
                } 
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            Console.WriteLine("max " + lengthPeople);
            char[] gl = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' }; // чар массив
            string[] sogl = { "p", "P", "b", "B", "k", "K", "f", "F", "v", "V", "m", "M", "z", "Z", "h", "H", "t", "T", "d", "D", "l", "L", "n", "N","s","S"}; //стринговый массив
            string vastus = Console.ReadLine(); 
            char[] name = new char[vastus.Length]; //чаровый массив
            int glNum = 0;
            int soglNum = 0;
            for (int i = 0; i < vastus.Length; i++)
            {
                Console.WriteLine(vastus[i]);
                name[i] = vastus[i];
                if (Array.IndexOf(gl, vastus[i]) != -1) //indexOf возвращает позицию найденной строки 
                {
                    glNum++;
                }
                else if (Array.IndexOf(sogl, vastus[i] != -1) //ToString делает в строку строковую
                {
                    soglNum++;
                }
            }
            Console.WriteLine("glas: " + glNum); // выводмм
            Console.WriteLine("sogl: " + soglNum); //выводим
        }
    }
}

