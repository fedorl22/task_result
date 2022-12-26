// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
//["hello","2","world",":-)"]->["2"":-)"]
//["1234","1567","-2","computer science"]->["-2"]
//["Russia","Denmark","Kazan"]->[]



Console.Clear();
string[] A = new string[3] { "Russia","Denmark","Kazan" };
int indexB = 0;

    for (int indexA = 0; indexA < A.Length; indexA++)
    {
        if (A[indexA].Length <= 3)
        {
            indexB++;
        }
    }
string[] B = new string[indexB];

void OutputArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{ 
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}'");
    }
    Console.Write("]");
    Console.WriteLine();
}
OutputArray(A, B);
PrintArray(B);

