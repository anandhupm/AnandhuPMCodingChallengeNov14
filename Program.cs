//Question 1

var names = new string[5];
var sortAsend = new string[10];
var sortDescend = new string[10];
string temp;
var dupeList = new bool[5];
Boolean hasFound = false;

Console.WriteLine("Enter 10 Names : ");
for (int i = 0; i < names.Length; i++)
{
    names[i] = Console.ReadLine();
}
Descending();
Ascending();
Search();
Length();
Split();
Duplicate();

void Descending()
{

    for (int i = 0; i < names.Length; i++)
    {
        for (int j = i + 1; j < names.Length; j++)
        {
            if (names[i][0] < names[j][0])
            {
                temp = names[i];
                names[i] = names[j];
                names[j] = temp;
            }
        }

    }
    Console.WriteLine("---------------------------Descending Order :----------------------------- ");

    for (int j = 0; j < names.Length; j++)
    {
        Console.WriteLine(names[j]);
    }
}

void Ascending()
{

    for (int i = 0; i < names.Length; i++)
    {
        for (int j = i + 1; j < names.Length; j++)
        {
            if (names[i][0] > names[j][0])
            {
                temp = names[i];
                names[i] = names[j];
                names[j] = temp;
            }
        }

    }
    Console.WriteLine("---------------Ascending Order :-------------- ");

    for (int j = 0; j < names.Length; j++)
    {
        Console.WriteLine(names[j]);
    }
}

void Search()
{
    Console.WriteLine("Enter Name to search : ");
    temp = Console.ReadLine();
    for (int i = 0; i < names.Length; i++)
    {
        if (names[i] == temp)
        {
            Console.WriteLine("Element Found at indes position : " + i);
            hasFound = true;
            break;
        }
    }
    if (!hasFound)
    {
        Console.WriteLine("Element Not Found");

    }
}

void Length()
{
    foreach (var item in names)
    {
        Console.WriteLine($"Length of {item} is {item.Length}");
    }
}

void Split()
{
    Console.WriteLine("--------------------Names having First and last name : -----------------");

    foreach (var item in names)
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (item[i] == ' ')
            {
                Console.Write($"First name of {item} is : ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(item[j]);
                }
                Console.WriteLine();
                Console.Write($"Last name of {item} is : ");
                for (int j = i + 1; j < item.Length; j++)
                {
                    Console.Write(item[j]);
                }
                Console.WriteLine();

            }
        }
    }
}

void Duplicate()
{
    Console.WriteLine("--------------------Duplicate Names : -----------------");

    for (int i = 0; i < names.Length; i++)
    {
        for (int j = 0; j < names.Length; j++)
        {
            if (names[i] == names[j] && i != j && dupeList[i] == false)
            {
                //Console.WriteLine($"Name {names[i]} found at position {i} and {j
                Console.WriteLine($" {names[i]} ");

                dupeList[i] = true;
                dupeList[j] = true;


            }
        }
    }
}