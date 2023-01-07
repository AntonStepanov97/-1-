Console.Clear();

int[] array = {1,2,6,7,4,89,686};

int n = array.Length;
int find = 89;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}