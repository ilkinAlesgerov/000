// написать программу которая выводит массив из строк, длина который меньше либо равна 3. 


string[] array = new string[6] { "1", "asdasd", "1234", "-2", "hello", "hel" };

void PrintLessFour(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            Console.WriteLine(array[i]);
        }
    }

}
PrintLessFour(array);