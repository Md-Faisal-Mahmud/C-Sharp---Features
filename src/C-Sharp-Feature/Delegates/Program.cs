


using Delegates;
using static Delegates.DelegateExample;

string GenerateLink(int campaignId, string email)
{
    return $"https://mypage.com/campaign/track?c={campaignId}&e={email}";
}

EmailSender emailSender = new EmailSender();
emailSender.SendBulkEmail(23, new List<string>() { "abc@yahoo.com", "efg@gmail.com" }, GenerateLink);




//-----------------------------------------------------------------------------
//int Sum(int a, int b)
//{
//    return a + b;
//}
//void GetNumber(Calculate hyperLink)
//{
//    int result = hyperLink(45, 45);

//    Console.WriteLine(result);

//}
//GetNumber(Sum);





//------------------------------------------------------------------------------
//int Sum(int a, int b)
//{
//    return a + b;   
//}

//Calculate calculate;
//calculate = Sum;

////Func<int,int, int> sumDelegate = Sum;

//void GetNumber(Calculate x)
//{
//    int result = x(45, 45);

//    Console.WriteLine(result);

//}

//GetNumber(calculate);























//using static Delegates.DelegateExample;

//int Sum(int a, int b)
//{
//    return a + b;   
//}


//Calculate calculate; // int x; arom vabe declare kora hoilo
//calculate = Sum;     // x = 5; assaign kora gelo karon calculate r Sum er signature same.


////void Print(Calculate calculate)
////{
////    int result = calculate(2, 4);
////    Console.WriteLine(result); 
////}

////Print(calculate);

//Console.WriteLine(calculate(23,23));









//// C# program to illustrate the Multicasting of Delegates
//using System;

//class rectangle
//{

//	// declaring delegate
//	public delegate void rectDelegate(double height,
//									double width);

//	// "area" method
//	public void area(double height, double width)
//	{
//		Console.WriteLine("Area is: {0}", (width * height));
//	}

//	// "perimeter" method
//	public void perimeter(double height, double width)
//	{
//		Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
//	}


//	// Main Method
//	public static void Main(String[] args)
//	{

//		// creating object of class "rectangle", named as "rect"
//		rectangle rect = new rectangle();

//		// these two lines are normal calling  of that two methods  rect.area(6.3, 4.2); rect.perimeter(6.3, 4.2);

//		// creating delegate object, name as "rectdele" and pass the method as parameter by class object "rect"
//		rectDelegate rectdele = new rectDelegate(rect.area);

//		// also can be written as rectDelegate rectdele = rect.area;  call 2nd method "perimeter" Multicasting
//		rectdele += rect.perimeter;

//		// pass the values in two method  by using "Invoke" method
//		rectdele.Invoke(6.3, 4.2);
//		Console.WriteLine();

//		// call the methods with different values
//		rectdele.Invoke(16.3, 10.3);
//	}
//}




//--------------------------------------------------------------------------------------------------------------------------------------------------------------------


//using System;
//using System.IO;

//namespace DelegateApply
//{

//    class PrintString
//    {
//        static FileStream fs;
//        static StreamWriter sw;

//        // delegate declaration
//        public delegate void printString(string s);

//        // this method prints to the console
//        public static void WriteToScreen(string str)
//        {
//            Console.WriteLine("The String is: {0}", str);
//        }

//        //this method prints to a file
//        public static void WriteToFile(string s)
//        {
//            fs = new FileStream("..\\..\\..\\message.txt",
//            FileMode.Append, FileAccess.Write);
//            sw = new StreamWriter(fs);
//            sw.WriteLine(s);
//            sw.Flush();
//            sw.Close();
//            fs.Close();
//        }

//        // this method takes the delegate as parameter and uses it to call the methods as required
//        public static void sendString(printString ps)
//        {
//            ps("Hello World");
//        }

//        static void Main(string[] args)
//        {
//            printString ps1 = new printString(WriteToScreen);
//            printString ps2 = new printString(WriteToFile);
//            sendString(ps1);
//            sendString(ps2);
//        }
//    }
//}





///------------------------    multicasting of Delegate    ----------------------------        https://www.tutorialspoint.com/csharp/csharp_delegates.htm#
/*
using System;
delegate int NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc = nc + nc2;

            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }
    }
}
*/


