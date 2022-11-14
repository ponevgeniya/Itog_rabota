// Написать прорамму, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите массив: ");

string[] Array = new string [4]{"","","",""}; 
string[] NewArray = new string[4]{"","","",""}; 
int j = 0;

string a = "";    
int i1 = 0;
while (a != "end")
    {
        a = Console.ReadLine();
        if (a == "end")
        {
          continue;
        }
        Array[i1] = a;
        i1++;
    }

    for (int i = 0; i < 4; i++)
    {
        if (Array[i].Length <= 3)
        {
          NewArray[j] = Array[i];
          j++;
        }
    }

Console.WriteLine("Итоговый массив: ");    

for (int ii = 0; ii < NewArray.Length; ii++)
{
    if (NewArray[ii] != "")
    {
       Console.WriteLine(NewArray[ii]); 
    }
}


