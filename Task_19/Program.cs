// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo < 10000 || chislo > 99999)
{
    Console.WriteLine("Введено не пятизначное число");
    return;
} 
int[] array = new int[5];
int index = 0;
while (index <= 4)
{
    array[index] = chislo % 10;
    chislo = (chislo - array[index]) / 10;
    index++;
}
if (array[0] == array [4] && array[1] == array [3])
{
    Console.WriteLine("Введено число является палиндромом");
}
else{
    Console.WriteLine("Введено число не является палиндромом");
}

