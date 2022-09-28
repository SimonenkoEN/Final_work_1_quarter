﻿Console.Clear();

string s = "один два три 4 и -4 привет! как дела?";
string[] str = s.Split(" ");
PrintIndexAndValues(str);
string[] strLessFour = GetStrLessFourArr(str);
PrintIndexAndValues(strLessFour);

string[] GetStrLessFourArr(String[] myArr)
{
    int j = 0;
    string[] outArr = new string[1] {string.Empty};
    for(int i = 0; i < myArr.Length; i++)
    {
        if(myArr[i].Length < 4)
        {
            outArr[j] = myArr[i];
            Array.Resize(ref outArr, outArr.Length + 1);
            outArr[j + 1] = string.Empty;
            j++;
        }        
    }
    return outArr;
}

void PrintIndexAndValues(String[] myArr)
{
    Console.Write($"[{myArr[0]}");
    for(int i = 1; i < myArr.Length; i++)
    {
        if(myArr[i] != string.Empty)
        {
            Console.Write($", {myArr[i]}");
        }
    }
    Console.WriteLine("]");
}