Console.WriteLine("Введите размер массива: ");
int SIZE = Convert.ToInt32(Console.ReadLine());
int LIMIT = 3;

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
	if(arr.Length == 0)
		{
			Console.WriteLine("Array is empty");
		}
		else
		{
            System.Console.WriteLine("Результат: ");
			Array.ForEach(arr, (str) => Console.Write($"{str} "));
			Console.WriteLine();
		}
}

string[] Arr = NewArr(SIZE);
//ShowArr(Arr);

string[] ResArr (string[] arr)
{
    int count = 0;
    int length = arr.Length;
    string[] ResArr = new string[length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= LIMIT)
        {
            ResArr[count] = arr[i];
            count++;
        }
    }
    return ResArr;
}

string[] arr = ResArr(Arr);
ShowArr(arr);