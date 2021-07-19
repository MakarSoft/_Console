using System;


namespace Console_01
{
    class Baterfly
    {
        
        public string name;
        private int _maxCount;
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
                    Console.WriteLine("Бяг");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первое консольное приложение");
            Baterfly btf = new Baterfly(200);
            btf.Fly(3);
            Console.ReadKey();
        }
    }
}
