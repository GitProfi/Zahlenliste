List<int> zahlen = new List<int>();

zahlen.Add(1);
zahlen.Add(2);
zahlen.Add(3);
zahlen.Add(4);

for (int i = 0; i < zahlen.Count; i++)
{
    Console.WriteLine($"{i + 1} + {i + 1} ergibt {(i + 1) + (i + 1)}");

}