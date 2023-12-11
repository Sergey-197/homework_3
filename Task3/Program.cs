


// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
//пример
//  [2.2 0.4 9.11 7.2 78.98] => 78.58
//  [1.22 4.5 3.33] => 3.28

 
double[] numbers = {1.22,4.5,3.33};
double max = double.MinValue;
double min = double.MaxValue;
foreach(double number in numbers )
{
  if(number > max)
  {
    max = number;
  }
   if(number < min)
   {
    min = number;
   }
}
double difference = max - min;
 Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);