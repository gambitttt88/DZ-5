/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

Console.WriteLine("Введите числа ");
 string[] s = Console.ReadLine().Split(' ');
            int[] a = new int[s.Length];
            for (int i = 0; i < s.Length; i++) a[i] = Int32.Parse(s[i]);
Console.WriteLine($"[{String.Join(",", s)}]");


int CountElement(int[] array)
{
int count = 0;
    foreach(int el in a)
    {
        if(el > 0)
        {
            count++;
        }
    } 
    return count;
}
Console.WriteLine($"Количество положительных чисел в массиве -  {CountElement(a)}");
*/

//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
int[] array = GetArray(10, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");

void PrintArray(int [] array2)
{
    int count = array2.Length;
    for(int i = 0; i < count; i++ )
    {
    Console.WriteLine($"[{String.Join(",", array2[i])}]");
    }
}
void SortirovkaArray(int[] array2)
    {
    for(int i = 0; i < array2.Length - 1; i++ )
    {
        int min = i;
        for(int k = i+1; k < array2.Length; k++ )
        {
            if(array2[k] < array2[min])
            min = k;
        }
        int res = array2[i];
        array2[i] = array2[min];
        array2[min] = res;
    }
}

SortirovkaArray(array);
PrintArray(array);

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}