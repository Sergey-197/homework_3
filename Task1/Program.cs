
 // Задайте одномерный массив из 10 целых чисел от 1 до 100.
 // Найдите количество элементов массива, значение которых
 // лежат в отрезке [20, 90].
 //Пример
 // [10 21 14 93 23] => 2

  int[] array = new int[10];

   for(int i = 0; i < 10; i++)
  {
    array[i] = new Random().Next(1, 101);
   System.Console.Write(array[i]+ " ");
} 
   System.Console.WriteLine();
    int count=0;
    for(int i = 0; i < 10; i++)
    {
      if(array[i] >=20 && array[i] <=90)
      {
      count++;
      {
      }
      System.Console.Write( + count);
      }
    
      
    }
    
    

      
      
      

      
    
      
      

 