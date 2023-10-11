// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt (string message)
{
    System.Console.Write (message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}