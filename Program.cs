string [] array = {"1", "sun", "54067", "Non-fiction", "-8", "mix", "moon", ":)"};

for (int i = 0; i<array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);
    }
}