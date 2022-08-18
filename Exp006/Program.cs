Console.WriteLine("Сколько же раз пробежит собака от одного парня к другому при дистанции между ними в 10000 метров?");

int count = 0, distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5, friend = 2;

int meet = 10, time = 0;

while(distance > meet){
    if(friend == 1){
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }else{
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");