// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

string? end = "конец", input = "";

while(input?.ToLower() != end){
    int number;
    do{
        try{
            Console.Write("Укажите какое-нибудь целое число: ");
            number = Convert.ToInt32(Console.ReadLine());
            break;
        }catch (FormatException){
            Console.WriteLine("Неверный формат ввода. Введите целое число");
        }
    }
    while(true);

    // Проверяем - делится ли число на 2 без остатка
    if(number % 2 == 0){
        Console.WriteLine("Указанное число: "+number+" - это четное число.");
    }else{
        Console.WriteLine("Указанное число: "+number+" - нечетное число.");
    }

    Console.WriteLine("Если хотите закончить играть, напишите - Конец. А для продолжения - нажмите Enter");
    input = Console.ReadLine();
}
