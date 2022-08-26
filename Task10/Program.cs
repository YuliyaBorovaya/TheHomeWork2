// See https://aka.ms/new-console-template for more information
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
Console.WriteLine("вторая цифра числа "+stringNumber[1]);
