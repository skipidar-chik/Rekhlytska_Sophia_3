internal class MusicalInstrument
{
    public string name; 
    public int type; 
    public bool condition;//true - робочий cтан, false - зламаний
    public bool belong;//true - зайнятий, false - вільний
    public MusicalInstrument(string name, int type, bool condition, bool belong)
    {
        this.name = name;
        this.type = type;
        this.condition = condition;
        this.belong = belong;
    }
    public MusicalInstrument()
    {
        name = "Undefind";
        type = 0;
        condition = false;
        belong = false;
    }
}