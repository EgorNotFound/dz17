//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива : \t");

int elements = int.Parse(Console.ReadLine());
int sum = 0;
int[] array = new int [elements];

for(int i=0; i<array.Length;i++){
    Console.WriteLine($"Введите элемент массива под индексом {i};\t");
    array[i]= int.Parse(Console.ReadLine());
}
for(int i=0; i<array.Length;i++){
    if(array[i]>0){
        sum++;
    }
}
Console.WriteLine("Количество положительных чиселв массиве : " + sum);



   