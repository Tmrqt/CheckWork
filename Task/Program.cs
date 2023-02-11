Console.WriteLine("Введите размер массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());

string[] NewArr (int SIZE)
{
    string[] arr = new string[SIZE];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ((char)rand.Next('a', 'z' + 1)).ToString();
    
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