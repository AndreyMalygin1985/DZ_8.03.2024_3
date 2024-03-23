// Создать базовый класс «Музыкальный инструмент» и производные классы «Скрипка», «Тромбон», « Укулеле»,
// «Виолончель». С помощью конструктора установить имя каждого музыкального инструмента и его характеристики.
// Реализуйте для каждого из классов методы:
//		■	Sound — издает звук музыкального инструмента (пишем текстом в консоль);
//		■	Show — отображает название музыкального инструмента;
//		■	Desc — отображает описание музыкального инструмента;
//		■	History — отображает историю создания музыкального инструмента.

using static System.Console;
class MusicalInstruments
{
    protected string Name;

    public MusicalInstruments(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        WriteLine($"Музыкальный инструмент {Name} издает звук.");
    }

    public void Show()
    {
        WriteLine($"Название музыкального инструмента: {Name}");
    }

    public virtual void Desc()
    {
        WriteLine($"Это музыкальный инструмент {Name}.");
    }

    public virtual void History()
    {
        WriteLine($"Музыкальный инструмент {Name} был изобретен в прошлом.");
    }
}

class Violin : MusicalInstruments
{
    public Violin(string name) : base(name) { }

    public override void Sound()
    {
        WriteLine($"Скрипка {Name} издает красивый звук скрипичного струнного инструмента.");
    }
}

class Trombone : MusicalInstruments
{
    public Trombone(string name) : base(name) { }

    public override void Sound()
    {
        WriteLine($"Тромбон {Name} издает мощный звук медного духового инструмента.");
    }
}

class Ukulele : MusicalInstruments
{
    public Ukulele(string name) : base(name) { }

    public override void Sound()
    {
        WriteLine($"Укулеле {Name} издает легкий и приятный звук струнного инструмента.");
    }
}

class Cello : MusicalInstruments
{
    public Cello(string name) : base(name) { }

    public override void Sound()
    {
        WriteLine($"Виолончель {Name} издает плавный и глубокий звук струнного инструмента.");
    }
}

class Program
{
    static void Main()
    {
        Violin violin = new Violin("Страдивариус");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();

        WriteLine();

        Trombone trombone = new Trombone("Басс");
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();

        WriteLine();

        Ukulele ukulele = new Ukulele("Хавайское");
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();

        WriteLine();

        Cello cello = new Cello("Струни");
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
    }
}