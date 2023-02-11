Console.WriteLine("Введите размер массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());

string[] NewArr (int SIZE)
{
    string[] arr = new string[SIZE];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите строку массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void ShowArr (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

string[] Arr = NewArr(SIZE);
ShowArr(Arr);