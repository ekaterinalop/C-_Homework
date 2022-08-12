Console.WriteLine("введите цифру, соответствующую дню недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

void Weekend (int day)
 {
  if (day == 6)
  {
  Console.WriteLine("этот день выходной");
  }
  else if (day == 7) 
  {
    Console.WriteLine("этот день выходной");
  }
   else Console.WriteLine("этот день рабочий");
}

Weekend(day);
