int n = 5;
int[] array = { 2, 10, 7, 3, 9 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
System.Console.WriteLine(max);