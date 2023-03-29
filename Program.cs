/// <summary>
/// Создает массив с символами <= 3 из уже заданного массива. Заготовленный массив можно изменить
/// </summary>
/// <returns> Возвращает готовый массив</returns>
string[] CreateRandomArray(string YesOrNo)
{
   string[] WordList = { "круглосуточный", "3", "трех-звенный", "раз", "cam", "взаимный", "56", "три", "умный", "шесть", "фронтенд", "ещё", "уполномоченный", "что", "нил", "фирменный", "сетевой", "мы", "сфокусированный", "портал", "вуз", "уж" };
   int count = 0;
   for (int i = 0; i < WordList.Length; i++)
   {
      if (WordList[i].Length <= 3) count++;
   }
   string[] EndList = new string[count];
   count = 0;
   for (int i = 0; i < WordList.Length; i++)
   {
      if (WordList[i].Length <= 3)
      {
         EndList[count] = WordList[i];
         count++;
      }
   }
   return EndList;
}
