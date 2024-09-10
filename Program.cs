// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void Main()
{

string[] input = new[] {"Hello", "2", "world", ":-)"};

PrintStr (input);
Console.WriteLine();

PrintStr (Response(input));

}

string[] Response (string[] input)
{
    string[] response = new string[CountLessThanThree (input)];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            response[index] = input[i];
            index++;
        }
    }
    return response;
}

int CountLessThanThree (string[] input)
{
    int size = 0;
    for (int i = 0; i < input.Length; i++)
    {  
        if (input[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

void PrintStr (string[] str)
{
    Console.Write("['" + string.Join("', '", str) + "']");
}

Main();
