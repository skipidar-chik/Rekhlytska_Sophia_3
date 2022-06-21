Circle kolo = new();

for (; ; )
{
    kolo.Print();

    Console.WriteLine("-------------------------------");
    Console.WriteLine("Choose an action:");
    Console.WriteLine("Setting parameters - 1 \n" +
        "Change of radius - 2 \n" +
        "Check the point for belonging to a circle - 3 \n" +
        "Finish work - else");
    Console.WriteLine("-------------------------------");

    string a = Console.ReadLine();
    if (a == "1")
        kolo.Setting();
    else if (a == "2")
        kolo.RadiusChange();
    else if (a == "3")
        kolo.PointCheck();
    else break;
}