int count = 0;
int distance = 10000;
int firstFS = 1;
int secondFS = 2;
int dogS = 5;
int freind = 2;
int time = 0;

while (distance > 10)
{
    if (freind == 1)
    {
        time = distance / (firstFS + dogS);
        freind = 2;
    }
    time = distance / (secondFS + dogS);
    freind = 1;

    distance = distance - (firstFS + secondFS) * time;

    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");