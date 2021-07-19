using System;


namespace Console_01
{
    class Baterfly
    {
        
        public string name;
        private int _maxCount;
        private int _count;
        public Baterfly()
        {
            _maxCount = 100;
        }
        public Baterfly(int maxCount)
        {
            _maxCount = maxCount;
        }
        public void Fly(int count)
        {
            if (count > 0) {
                if (count >= _maxCount)
                    count = _maxCount;
                for (int i = 0; i < count; i++)
                {
                    if (_count < _maxCount)
                    {
                        _count++;
                        Console.WriteLine("Бяг {0}",_count);
                    }
                    else
                    {
                        Console.Beep();
                        Console.WriteLine("отмахалась...");
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое консольное приложение");
            Baterfly btf = new Baterfly(10);
            btf.name = "Вася";
            btf.Fly(3);
            btf.Fly(10);

            Console.ReadKey();
        }
    }
}
