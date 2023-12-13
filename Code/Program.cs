using System.Linq.Expressions;

Console.Write("Введите элементы массива через пробел: ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
string[] arr = Console.ReadLine(). Split();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
string[] newArr = new string [arr.Length];

int index = 0;
foreach(string element in arr)
{
    if(element.Length <= 3)
    {
        newArr[index] = element;
        index++;
    }
}
Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам: ");
for (int i = 0; i < index; i++)
{
    Console.Write(newArr[i] + " ");
}