// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] numbers = new int[10];
// void fillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void writeArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int quantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// fillArray(numbers, 100, 1000);
// writeArray(numbers);
// Console.WriteLine();

// int quantity = quantityPositive(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write($"Введите количество элементов массива: ");
// int numElements = int.Parse(Console.ReadLine()); 

// int RandomNumbers(int numElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numElements];
//   int sumElements = 0;
//   Console.Write("Полученный массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numElements, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
