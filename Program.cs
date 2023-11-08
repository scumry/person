using System;
public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Level { get; set; }
    public Person(string name, int level)
{
    Name = name;
    Level = level;
}
public int CompareTo(Person other)
{
    return Level.CompareTo(other.Level);
}
public void Attack()
{
    Console.WriteLine($"{Name} атакует противника");
}
public void LevelUp()
{
    Level++;
}
public void Defend()
{
    Console.WriteLine($"{Name} защищается от атаки");
}

public void DisplayInfo()
{
    Console.WriteLine($"Имя героя: {Name}");
    Console.WriteLine($"Уровень: {Level}");
}
}

class Program
{
static void Main(string[] args)
{
        Person warrior = new Person("Боец", 4);
        Person mage = new Person("Рыцарь", 5);
        warrior.Attack();
        mage.Defend();

        warrior.LevelUp();
        mage.DisplayInfo();
        int result = warrior.CompareTo(mage);
        if (result > 0)
        {
             Console.WriteLine($"{warrior.Name} сильнее, чем {mage.Name}!");
        }
        else if (result < 0)
        {
             Console.WriteLine($"{mage.Name} сильнее, чем {warrior.Name}!");
        }
        else 
        {
            Console.WriteLine($"{warrior.Name} и {mage.Name} одинаковы по силе!");
        }

}
}