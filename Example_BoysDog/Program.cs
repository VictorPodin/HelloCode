int count = 0;
int distance = 10000;
int fFspeed = 1;
int sFspeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (fFspeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (sFspeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (fFspeed + sFspeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");