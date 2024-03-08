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
    protected string Название;

    public MusicalInstruments(string название)
    {
        Название = название;
    }

    public virtual void Sound()
    {
        WriteLine($"Музыкальный инструмент {Название} издает звук.");
    }

    public void Show()
    {
        WriteLine($"Название музыкального инструмента: {Название}");
    }

    public virtual void Desc()
    {
        WriteLine($"Это музыкальный инструмент {Название}.");
    }

    public virtual void History()
    {
        WriteLine($"Музыкальный инструмент {Название} был изобретен в прошлом.");
    }
}

class Violin : MusicalInstruments
{
    public Violin(string название) : base(название) { }

    public override void Sound()
    {
        WriteLine($"Скрипка {Название} издает красивый звук скрипичного струнного инструмента.");
    }
}

class Trombone : MusicalInstruments
{
    public Trombone(string название) : base(название) { }

    public override void Sound()
    {
        WriteLine($"Тромбон {Название} издает мощный звук медного духового инструмента.");
    }
}

class Ukulele : MusicalInstruments
{
    public Ukulele(string название) : base(название) { }

    public override void Sound()
    {
        WriteLine($"Укулеле {Название} издает легкий и приятный звук струнного инструмента.");
    }
}

class Cello : MusicalInstruments
{
    public Cello(string название) : base(название) { }

    public override void Sound()
    {
        WriteLine($"Виолончель {Название} издает плавный и глубокий звук струнного инструмента.");
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