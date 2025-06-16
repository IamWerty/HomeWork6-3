using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть межу: ");
int end = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= end; i++)
{
    int j;
    for (j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            break;
        }
    }

    if (j == i)
    {
        Console.WriteLine(i);
    }
}
//ох і напрягли ж в мене з цією задачою мізки...