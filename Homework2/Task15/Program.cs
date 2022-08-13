using System;

class Program
{
 
  static void Week()
  {
    string[] nameDays = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
    for (int i = 0; i < nameDays.Length-1; i++)
    {
      Console.Write(i+1 + " - " + nameDays[i] + ", ");
    }
    Console.Write(nameDays.Length + " -" + nameDays[nameDays.Length-1] + ".");
    Console.WriteLine(" Выберите день недели, напишите цифру");
  }
  static void Main(string[] args)
  {
    Week();
    int day = Convert.ToInt32(Console.ReadLine());
    if (day == 6)
    {
      Console.WriteLine("этот день выходной");
    }
    else if (day == 7) 
      {
        Console.WriteLine("этот день выходной");
      }
      else 
      Console.WriteLine("этот день рабочий");
      
    
  }

}
