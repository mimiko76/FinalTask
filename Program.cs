/// <summary>
/// Создает массив с символами <= 3 из уже заданного массива. Заготовленный массив можно изменить
/// </summary>
/// <returns> Возвращает готовый массив</returns>
string[] CreateRandomArray(string YesOrNo)
{
   string[] WordList = { "круглосуточный", "3", "трех-звенный", "OK", "раз", "cam", "взаимный", "56", "три", "умный", "шесть", "фронтенд", "ещё", "уполномоченный", "что", "нил", "фирменный", "сетевой", "мы", "сфокусированный", "портал", "вуз", "уж" };
   int count = 0;
   for (int i = 0; i < WordList.Length; i++)
   {
      if (WordList[i].Length <= 3) count++;
   }
   string[] EndArray = new string[count];
   count = 0;
   for (int i = 0; i < WordList.Length; i++)
   {
      if (WordList[i].Length <= 3)
      {
         EndArray[count] = WordList[i];
         count++;
      }
   }
   return EndArray;
}
/// <summary>
/// Создает массив с символами <= 3 из массива, который вводится с клавиатуры
/// </summary>
/// <param name="size">размер массива</param>
/// <returns></returns>
string[] CreateWritteArray(int size)
{
   int count = 0;
   string[] WritteArray = new string[size];
   for (int i = 0; i < size; i++)
   {
      WritteArray[i] = Console.ReadLine();
      if (WritteArray[i].Length <= 3) count++;
   }
   string[] EndArray = new string[count];
   count = 0;
   for (int i = 0; i < WritteArray.Length; i++)
   {
      if (WritteArray[i].Length <= 3)
      {
         EndArray[count] = WritteArray[i];
         count++;
      }
   }
   return EndArray;
}
/// <summary>
/// Выводит массив на экран
/// </summary>
void ShowArray(string[] MyArray)
{
   Console.Write("Строки содержащие 3 или меньше символов:");
   for (int i = 0; i < MyArray.Length; i++)
   {
      if (MyArray.Length == i + 1) Console.Write($"{MyArray[i]}. ");
      else Console.Write($"{MyArray[i]}, ");
   }
}


Console.Write("Если вы хотите использовать готовый массив введите 'Y', если хотите ввести свой введите 'N': ");
string solution = Console.ReadLine();
if (solution.ToLower() == "y")
{
   string[] MyArray = CreateRandomArray("y");
   ShowArray(MyArray);
}

if (solution.ToLower() == "n")
{
   Console.Write("Введите желаемый размер массива: ");
   int size = Convert.ToInt32(Console.ReadLine());
   string[] MyArray = CreateWritteArray(size);
   ShowArray(MyArray);
}
if (solution.ToLower() != "n" & solution.ToLower() != "y")
{
   Console.WriteLine("Вы ввели некорректный ответ.");
   return;
}


