/* Из массива строк сформировать массиве строк,
длины меньше или равной 3.*/

string[] actualArray = {"str", "1", "hello", "geekbrains", "c#",
                        "lua", "python", "erlang"};

/*Метод поиска количества строк в массиве, длинна строк меньше 
или равна аргументу number*/
int FindString(string[] localArrray)
{
    int count = 0;
    for (int i = 0; i < localArrray.Length; i++)
    {
        if (localArrray[i].Length <= 3)
        {
            count += 1;
        }
    }
    return count;
}
/*Метод создание нового массива для строк меньше
*/
string[] CreateMassive(string[] localArray, int number)
{
    string[] newMassive = new string[number];
    int k = 0;
    for (int i = 0; i < localArray.Length; i++)
    {
        if(localArray[i].Length <= 3)
        {
            newMassive[k] = localArray[i];
            k +=1;
        }
    }
    return newMassive;
}
Console.WriteLine("Число строк меньше или равно 3 в массиве actualArray: {0}", FindString(actualArray));
foreach(string value in CreateMassive(actualArray,FindString(actualArray)))
{
    Console.WriteLine(value);
}