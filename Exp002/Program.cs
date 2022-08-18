// Write() - выводит в консоль содержимое в одну строку;
// WriteLine() - выводит содержимое с новой строки;
// ReadLine() - считывает строку из консоли;
Console.Write("Введите имя пользователя ");
string? username = Console.ReadLine();
while(username == ""){
    Console.Write("Введите имя пользователя ");
    username = Console.ReadLine();
}
if(username?.ToLower() == "roman"){
    Console.WriteLine("Hallo, пользователь Роман!");
}else{
    Console.Write("Привет, ");
    Console.Write(username);
}

