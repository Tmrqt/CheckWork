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

string[] ResArr (string[] Arr)
{
    int count = 0;
    int length = Arr.Length;
    string[] ResArr = new string[length];
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= LIMIT)
        {
            ResArr[count] = Arr[i];
            count++;
        }
    }
    return ResArr;
}

string[] Arr = NewArr(SIZE);
//ShowArr(Arr);
string[] arr = ResArr(Arr);
ShowArr(arr);