// Linear Search
int[] data = { 1, 2, 3, 4, 5 };

int result_1 = LinearSearch(data, 5);
int result_2 = LinearSearch(data, 1);
int result_3 = LinearSearch(data, 6);

Console.WriteLine($"Found 5 at index {result_1}");
Console.WriteLine($"Found 1 at index {result_2}");
Console.WriteLine($"Found 6 at index {result_3}");

static int LinearSearch(int[] data, int find)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] == find)
        {
            return i;
        }
    }

    return -1;
}
