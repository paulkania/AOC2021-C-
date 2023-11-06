var input = File.ReadAllLines(@"./1r.txt")
    .Select(int.Parse)
    .ToList();


foreach(var i in input)
{
     Console.WriteLine(i);
}

static int CalculateDepthIncreases(List<int> input)
{
    int NumberofTimesDepthIncreases =0;
    int i = 1;

    while (i < input.Count())
    {
        if (input[i] > input[i-1])
        {
            NumberofTimesDepthIncreases++;
        }
        i++;
    }
    return NumberofTimesDepthIncreases;
}

var partone = CalculateDepthIncreases(input);
Console.WriteLine(partone);