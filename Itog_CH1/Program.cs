string[] GetShortWordsArray (string[] array, int MaxLength)
{
    // новый массив строк, длина которые не превышает MaxLength символов
    string[] result = new string[array.Length];
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= MaxLength)
        {
            result[count]=array[i];
            count++;
        }
    }
    // изменяем количество элементов массива до указанной величины
    Array.Resize(ref result,count);
    return result;
}

Console.Write("Количество символов нового массива не должно превышать: ");
int MaxStrLen = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите массив строк через пробел: ");
string[] array = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

string[] shortArray = GetShortWordsArray (array,MaxStrLen);
Console.WriteLine("Результирующий массив:");
if (shortArray.Length == 0)
{
    Console.WriteLine("Массив пуст");
}
else
{
    Array.ForEach(shortArray, (str)=>Console.Write($"{str}"));
    Console.WriteLine();
}

