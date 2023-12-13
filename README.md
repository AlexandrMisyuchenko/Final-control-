
# Итоговая контрольная работа по основному блоку

#### Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Порядок кода:
### 1. Для начала делаем возможным ввести элементы массива через пробел
```
Console.Write("Введите элементы массива через пробел: ");
```
### 2. Вводим элемнты массива через пробел и разбиваем их на элементы массива по пробелу
```
string[] arr = Console.ReadLine().Split();
```
### 3. Создаем новый массив (пока пустой) той же длины, что и исходный массив
```
string[] newArr = new string[arr.Length]; 
```
