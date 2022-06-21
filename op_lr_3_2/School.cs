internal class School
{
    List<MusicalInstrument> Instrument = new (); 
    Dictionary<MusicalInstrument, string> Belonging = new ();

    public void Menu()
    {
        for (; ; )
        {            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("---Options---\n" +
                "Information about instruments at school (1) \n" +
                "Add instrument (2) \n" +
                "Find instrument (3) \n" +
                "Give the instrument to the student (4)\n" +
                "Close the program (5)");
            string place = Console.ReadLine();
            switch (place)
            {
                case "1":
                    GetInfo();
                    break;
                case "2":
                    AddInstrument();
                    break;
                case "3":
                    SortInstruments();
                    break;
                case "4":
                    AssignInstrument();
                    break;
                    default: break;
            }
            if (place != "1"&place != "2"&place != "3" & place != "4")
            {
                break;
            }
        }
        Console.ReadKey();
    }
    private void GetInfo()
    {
        int WindCount = 0;
        int StringCount = 0;
        int KeyboardCount = 0;
        int PercussionCount = 0;
        int ConditionCount = 0;

        foreach (MusicalInstrument instrument in Instrument)
        {
            if (instrument.type == 1)
                WindCount++;
            else if (instrument.type == 2)
                StringCount++;
            else if (instrument.type == 3)
                KeyboardCount++;
            else if (instrument.type == 4)
                PercussionCount++;
            if (instrument.condition == false)
                ConditionCount++;
        }
        Console.WriteLine($"Total musical instruments in the school: {Instrument.Count}");
        Console.WriteLine($"Wind - {WindCount}, string - {StringCount}, keyboard - {KeyboardCount}, percussion - {PercussionCount}");
        Console.WriteLine($"Number of faulty instruments: {ConditionCount}");
    }
    private void AddInstrument()//додавання інструменту
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        foreach (MusicalInstrument instrument in Instrument)
        {
            if (instrument.name == name)
            {
                Console.WriteLine("Such instrument already exists, add new");
                name = Console.ReadLine();
                break;
            }
        }
        Console.WriteLine("Instrument type");
        Console.WriteLine("Wind (1) | String (2) | Keyboard (3) | Рercussion (4)");
        Console.Write("Type: ");
        int type = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("If the tool is working, enter 1, if nothing else");
        bool condition = (Console.ReadLine() == "1");
        bool belonging = false;
        Instrument.Add(new MusicalInstrument(name, type, condition, belonging));
        Console.WriteLine("Instrument added");
    }
    private void SortInstruments()
    {
        Console.WriteLine("Sort");
        Console.WriteLine("Wind(1) | String(2) | Keyboard(3) | Рercussion(4) | Has ownert - 5 | Falty - 6");
        int place = Convert.ToInt32(Console.ReadLine());
        if (place == 1 | place == 2 | place == 3 | place == 4)
        {
            foreach (MusicalInstrument instrument in Instrument)//шукаємо інструменти з вказаними ознаками
                if (instrument.type == place)
                    Console.WriteLine($"instrument: {instrument.name} ");
        }
        else if (place == 5)
        {
            foreach (MusicalInstrument instrument in Instrument)
                if (instrument.belong == true)
                    Console.WriteLine($"instrument: {instrument.name}, owner: {Belonging[instrument]}");
        }
        else if (place == 6)
        {
            foreach (MusicalInstrument instrument in Instrument)
                if (instrument.condition == false)
                    Console.WriteLine($"instrument: {instrument.name}");
        }
    }
    private void AssignInstrument()
    {
        Console.WriteLine("Do you want to assign a new - 1 or an existing musical instrument - 2?");
        if (Console.ReadLine() == "1")
            AddInstrument();
        for (; ; )
        {
            bool place = false;
            Console.WriteLine("The name of the instrument you want to assign");
            string name = Console.ReadLine();
            foreach (MusicalInstrument instrument in Instrument)
            {
                if (instrument.belong == true)
                {
                    Console.WriteLine("This instrument is already busy");
                    break;
                }
                else place = true;
            }
            if (place)
            {
                Console.Write("Name Surname: ");
                string student = Console.ReadLine();
                foreach (MusicalInstrument instrument in Instrument)
                {
                    if (instrument.name == name)
                    {
                        instrument.belong = true;
                        Belonging.Add(instrument, student);
                        break;
                    }
                }
                break;
            }
        }
    }
}