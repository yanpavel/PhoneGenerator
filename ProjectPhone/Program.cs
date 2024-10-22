namespace ProjectPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData testData = new TestData();
            Console.WriteLine("Введите размер количества номеров телефона, которые вы хотите сгенерировать");
            var amount = EnterNumbers();
            Generate(testData, amount);
            Console.WriteLine($"Сгенерировано {testData.phones.Count} номеров телефона:");
            foreach (var c in testData.phones)
            {
                Console.WriteLine(c);
            }
        }

        static long RandPhone()
        {
            Random random = new Random();
            return (89000000000 + random.Next(1, 999999999));
        }

        static void AddRandom(TestData td)
        {
            td.phones.Add(RandPhone());
        }

        public static object Generate(TestData td, int n)
        {
            for (int i = 0; i < n; i++)
            {
                AddRandom(td);
            }
            return td;
        }
        static int EnterNumbers()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Введите целое число");
            }
            return result;
        }
    }

    public struct TestData 
    {
        public List<long> phones = new List<long>();

        public TestData()
        {
        }
    }
}
