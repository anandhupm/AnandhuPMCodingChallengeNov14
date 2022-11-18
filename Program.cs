////Question 1----------------------------------------------------------------------------------------

//var names = new string[5];
//var sortAsend = new string[10];
//var sortDescend = new string[10];
//string temp;
//var dupeList = new bool[5];
//Boolean hasFound = false;

//Console.WriteLine("Enter 10 Names : ");
//for (int i = 0; i < names.Length; i++)
//{
//    names[i] = Console.ReadLine();
//}
//Descending();
//Ascending();
//Search();
//Length();
//Split();
//Duplicate();

//void Descending()
//{

//    for (int i = 0; i < names.Length; i++)
//    {
//        for (int j = i + 1; j < names.Length; j++)
//        {
//            if ((names[i].ToLower())[0] < (names[j].ToLower())[0])
//            {
//                temp = names[i];
//                names[i] = names[j];
//                names[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("---------------------------Descending Order :----------------------------- ");

//    for (int j = 0; j < names.Length; j++)
//    {
//        Console.WriteLine(names[j]);
//    }
//}

//void Ascending()
//{

//    for (int i = 0; i < names.Length; i++)
//    {
//        for (int j = i + 1; j < names.Length; j++)
//        {
//            if ((names[i].ToLower())[0] > (names[j].ToLower())[0])
//            {
//                temp = names[i];
//                names[i] = names[j];
//                names[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("---------------Ascending Order :-------------- ");

//    for (int j = 0; j < names.Length; j++)
//    {
//        Console.WriteLine(names[j]);
//    }
//}

//void Search()
//{
//    Console.WriteLine("Enter Name to search : ");
//    temp = Console.ReadLine();
//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == temp)
//        {
//            Console.WriteLine("Element Found at indes position : " + i);
//            hasFound = true;
//            break;
//        }
//    }
//    if (!hasFound)
//    {
//        Console.WriteLine("Element Not Found");

//    }
//}

//void Length()
//{
//    foreach (var item in names)
//    {
//        Console.WriteLine($"Length of {item} is {item.Length}");
//    }
//}

//void Split()
//{
//    Console.WriteLine("--------------------Names having First and last name : -----------------");

//    foreach (var item in names)
//    {
//        for (int i = 0; i < item.Length; i++)
//        {
//            if (item[i] == ' ')
//            {
//                Console.Write($"First name of {item} is : ");
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();
//                Console.Write($"Last name of {item} is : ");
//                for (int j = i + 1; j < item.Length; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();

//            }
//        }
//    }
//}

//void Duplicate()
//{
//    Console.WriteLine("--------------------Duplicate Names : -----------------");

//    for (int i = 0; i < names.Length; i++)
//    {
//        for (int j = 0; j < names.Length; j++)
//        {
//            if (names[i] == names[j] && i != j && dupeList[i] == false)
//            {
//                //Console.WriteLine($"Name {names[i]} found at position {i} and {j
//                Console.WriteLine($" {names[i]} ");

//                dupeList[i] = true;
//                dupeList[j] = true;


//            }
//        }
//    }
//}


//Question 2------------------------------------------------------------------------------------------------

using AnandhuPMCodingChallengeNov14;
using System.Transactions;

//var f = new Flight();

//f.BookingTime = "10 AM";
//Console.WriteLine(f.BookingTime);
//f.FlightFare = 100;

//Question 3------------------------------------------------------------------------------------------------


//var f = new Fares();
//f.SetData();
////f.Ascending();
////f.Descending();
////f.Search();
////f.MaxMin();
//f.Duplicate();

//Question 4------------------------------------------------------------------------------------------------

//var d = new Dob();
//d.SetData();
//d.GetData();
//d.Details();


//Question 5------------------------------------------------------------------------------------------------
//var f = new Fares();
//f.SetData_5();


//Question 6-------------------------------------------------------------------------------------------------








//Question 7------------------------------------------------------------------------------------------------

//var p = new Passenger();
//p.Name = "Amal";
//p.Miles = 5000000;




//Question 8------------------------------------------------------------------------------------------------

//var p = new Fares();
//p.SetData_8();
//p.GetData_8();


//Question 9------------------------------------------------------------------------------------------------

//Passenger[] P = new Passenger[5];
//for(int i = 0; i < P.Length; i++)
//{
//    P[i] = new Passenger(); 
//    Console.WriteLine("Enter DOB for Passenger : "+i);
//    P[i].SetData();
//}


//Question 10------------------------------------------------------------------------------------------------


//Question 12------------------------------------------------------------------------------------------------

var name = new string[] {"Anu","Abhi","Alan","Ashique" };
var dest = new string[] { "Mumbai", "Chennai", "Bnglr", "Tvm" };

var merge = new string[name.Length + dest.Length];
int i = 0;
for ( i = 0; i < name.Length; i++)
{
    merge[i] = name[i];
}
for (int j = 0; j < dest.Length; j++)
{
    merge[i] = dest[j];
    ++i;

}
for (i = 0; i < merge.Length; i++)
{
    Console.WriteLine(merge[i]);
}