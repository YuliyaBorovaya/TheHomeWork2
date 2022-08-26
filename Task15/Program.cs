Console.WriteLine("Введите число, обозначающее день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine("Поздравляем, можно отдыхать, этот день - выходной!");
}
else if (a < 1 || a > 7)
{
    Console.WriteLine("такого дня в неделе нет");
}
else 
{
    Console.WriteLine("Еще не выходной, работаем");
}