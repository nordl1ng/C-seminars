Console.WriteLine("Введите цифру");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("День недели ");
switch (day)
{
    case 1: Console.WriteLine("Понедельник "); break;
    case 2: Console.WriteLine("Вторник "); break;
    case 3: Console.WriteLine("Среда "); break;
    case 4: Console.WriteLine("Четверг "); break;
    case 5: Console.WriteLine("Пятница "); break;
    case 6: Console.WriteLine("Суббота "); break;
    case 7: Console.WriteLine("Воскресенье "); break;
    default: Console.WriteLine("Введите от 1 до 7 "); break;
}
if (a %2 =0)