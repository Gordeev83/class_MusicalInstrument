namespace class_MusicalInstrument
{
    class MusicalInstrument
    {
        protected string name;
        protected string characteristics;

        public MusicalInstrument(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"{name} издает звук");
        }

        public void Show()
        {
            Console.WriteLine($"Название инструмента: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание инструмента: {characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine($"История создания инструмента {name}");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string characteristics) : base(name, characteristics)
        {

        }

        public override void Sound()
        {
            Console.WriteLine($"Скрипка {name} исполняет звук");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string characteristics) : base(name, characteristics)
        {

        }

        public override void Sound()
        {
            Console.WriteLine($"Тромбон {name} исполняет звук");
        }

        public override void History()
        {
            Console.WriteLine($"История создания тромбона {name}");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string characteristics) : base(name, characteristics)
        {

        }

        public override void Sound()
        {
            Console.WriteLine($"Укулеле {name} исполняет звук");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name, string characteristics) : base(name, characteristics)
        {

        }

        public override void Sound()
        {
            Console.WriteLine($"Виолончель {name} исполняет звук");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Страдивариус", "Струнный инструмент с активной колокольчатой формой");
            violin.Show();
            violin.Desc();
            violin.Sound();
            violin.History();

            Console.WriteLine();

            Trombone trombone = new Trombone("King 3B", "Духовой медный инструмент с теноровым тоном");
            trombone.Show();
            trombone.Desc();
            trombone.Sound();
            trombone.History();

            Console.WriteLine();

            Ukulele ukulele = new Ukulele("Mahalo", "Струнный инструмент с четырьмя струнами");
            ukulele.Show();
            ukulele.Desc();
            ukulele.Sound();

            Console.WriteLine();

            Cello cello = new Cello("Stradivari", "Струнный инструмент с низким тоном");
            cello.Show();
            cello.Desc();
            cello.Sound();
        }
    }
}
