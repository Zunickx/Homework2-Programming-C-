string dayOfWeek = "";
int dayX;    
Console.WriteLine("Введите число, обозначающее день недели:");
    do
    {
        dayOfWeek = (Console.ReadLine()!);
        dayX = int.Parse(dayOfWeek);
        if((dayX >= 1) && (dayX <=5))
            {
                Console.WriteLine("Это будни");
            }
        else if(dayX == 6 || dayX == 7)
            {
                Console.WriteLine("Да, это выходной!");
            }
        /*else if(dayX == 7)
            {
                Console.WriteLine("Да, это выходной!");
            }*/
        else
            {
                Console.WriteLine("Нет такого дня недели! Введите число от 1 до 7:");
            }
    } while((dayX < 1) || (dayX > 7));

