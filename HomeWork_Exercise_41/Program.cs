// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите несколько числовых значений через [, ]\nили [Enter] для автоматической генерации чисел");
string strSource = Console.ReadLine()!;

// если строка пустая - вызываем генератор строки цифр
if (string.IsNullOrEmpty(strSource)) strSource = GenNumber();

// Генератор строки цифр. Возвращает строку вида: "-52, 95, 78, -93, 31, -45, 58, 87, -62, 11, 83, -5"
string GenNumber()
{
    for (int i = 0; i < new Random().Next(5, 20); i++) // кол-во чисел
    {
        strSource = strSource + Convert.ToString(new Random().Next(-100, 101) + ", "); // числа от -100 до 100 включительно через ","
    }
    strSource = strSource + Convert.ToString(new Random().Next(-10, 11));
    return strSource;
}

// Поиск положительных чисел в строке
int PositiveNumber(string strSource)
{
    string[] result = strSource.Split(","); // числа в строке представляем в виде массива
    int count = 0;
    for (int i = 0; i < result.Length; i++)
    {
        try
        {
            if (Convert.ToInt32(result[i]) > 0) count++; // подсчитываем положительные    
        }
        catch (System.Exception)
        {
            Console.WriteLine("В строке присутствуют не числовые значения!");
            Environment.Exit(0);
            //throw;
        }

    }
    return count;
}

Console.WriteLine($"Исходная строка цифр => {strSource}");
int count = PositiveNumber(strSource);
Console.WriteLine($"Кол-во положительных чисел больше 0 => {count}");