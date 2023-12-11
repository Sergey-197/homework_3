 // Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество четных чисел в массиве.
//Пример
//[6 7 19 34 3 1 4 7 9 1] => 3
//[1 8 43 55 60 3 2 1 3] => 4
 

  int[] numbers = new int[10];
int count =0;
Random random = new Random();
for(int i = 0; i<numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,101);
    System.Console.Write(numbers[i]+ " ");
}
    System.Console.WriteLine();

for(int i = 0; i<numbers.Length; i++)
{
  if(numbers[i]%2 ==0)
  {
    count++;
  }
    System.Console.WriteLine("Количество четных чисел: " + count);
}




    