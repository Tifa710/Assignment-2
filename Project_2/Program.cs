using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Value type Casting
            #region implicit-casting
            //int x = 4;
            //long y = x;
            #endregion
            #region Explicit-casting
            //long x = 1010101010101010;
            //int y;
            //checked
            //{
            //    y = x;
            //}
            #endregion
            #endregion
            #region Parse
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter data of user");
            //Console.WriteLine("enter user name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter user Age :");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter user salary :");
            //int salary = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine(name+age+salary);
            #endregion
            #region Operators
            #region Unary Operators
            //int x = 5;
            //++x;
            //x++;
            //Console.WriteLine(++x);
            //Console.WriteLine(x++); 
            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            #endregion
            #region Binary Operator
            //int sum, mul, div, sub, mod;
            //int A = 5;
            //int B = 10;
            //sum = A + B;
            //sub = A - B;
            //mul = A * B;
            //div = A / B;
            //mod = A % B;
            //Console.WriteLine(sum);
            #endregion
            #region assignment operator
            //int x = 10;
            //x += 10;
            //x -= 10;
            //x *= 10;
            //x /= 10;
            //x %= 10;
            #endregion
            #region relational operator
            //int x = 10; 
            //int y = 20;
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            #endregion
            #region Logical operator
            //Console.WriteLine(!true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);
            #endregion
            #region Betwise operator
            //Console.WriteLine(!true);
            //Console.WriteLine(true & false);
            //Console.WriteLine(true | false);
            #endregion
            #region Ternay Operator
            //int x = 4;
            //String message = x > 4 ? "print hi" : "print oph no";
            //Console.WriteLine(message);
            #endregion
            #region Operator periorety
            /*
             * 1. Unary operator
             * ()
             * * / %
             * + -
             */
            #endregion
            #endregion
            #region String Formating
            //int x = 10;
            //int y = 20;
            //int Result = x + y;
            //Console.WriteLine("Equation : "+ x+"+"+y+"="+"resuilt = " + Result);
            //string name = "Ahmed";
            //name = "Ali";
            #region composite format
            //string message = string.Format("Equation = {0} + {1} = {2}", x, y, Result);
            //Console.WriteLine(message);
            #endregion
            #region String manipulation
            //Console.WriteLine($"Equation = {x} + {y} = {Result}");
            #endregion
            #endregion
            #region If else - Switch case
            //Console.WriteLine("Enter Month Number");
            //int  num= int.Parse(Console.ReadLine());
            //if (num == 1)
            //    Console.WriteLine("month is jan");
            //else if (num == 2)
            //    Console.WriteLine("month is feb");
            //else if (num == 3)
            //    Console.WriteLine("month is march");
            //else Console.WriteLine("invalid input");
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("month is jan"); 
            //        break;   
            //    case 2: 
            //        Console.WriteLine("month is feb");  
            //        break;
            //    case 3:
            //        Console.WriteLine("month is march");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input");
            //        break ;
            //}
            #region Go To
            //Console.WriteLine("Enter Option Number");
            //int Option = int.Parse(Console.ReadLine());
            //switch (Option)
            //{
            //    case 3000:
            //        Console.WriteLine("option is 3");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option is 2");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option is 1");
            //        break;
            //}
            #endregion
            #endregion
            #endregion
            #region Assignment
            #region Problem 1
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            #region Problem 2
            //int n = int.Parse(Console.ReadLine());
            //if (n < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positve");
            #endregion
            #region Problem 3
            //int n1= int.Parse(Console.ReadLine());
            //int n2= int.Parse(Console.ReadLine());
            //int n3= int.Parse(Console.ReadLine());
            //int max = Math.Max(n1,Math.Max(n2,n3));
            //int Min = Math.Min(n1,Math.Min(n2,n3));
            //Console.WriteLine(max);
            //Console.WriteLine(Min);
            #endregion
            #region Problem 4
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0)
            //    Console.WriteLine("number is Odd");
            //else
            //    Console.WriteLine("number is even");
            #endregion
            #region Problem 5
            //string letter = Console.ReadLine();
            //switch (letter)
            //{
            //    case "a":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "e":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "i":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "o":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //            ; break;
            //}

            #endregion
            #region Problem 6
            //  int n = 5;
            //for (int i = 1; i <= 12; i++)
            //{
            //    int sum = n * i;
            //    Console.WriteLine(sum);
            //}
            #endregion
            #region Problem 7
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int sum = n1;
            //for (int i = 1; i < n2; i++)
            //{
            //    sum *= n1;   
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Problem 8
            //float n1 = float.Parse(Console.ReadLine());
            //float n2 = float.Parse(Console.ReadLine());
            //float n3 = float.Parse(Console.ReadLine());
            //float n4 = float.Parse(Console.ReadLine());
            //float n5 = float.Parse(Console.ReadLine());
            //float sum = n1+n2+n3+n4+n5;
            //Console.WriteLine("sum =" + sum);
            //float avg = sum/5;
            //Console.WriteLine("avg =" + avg);
            //float percentage = (sum / 500) * 100;
            //Console.WriteLine("per =" + percentage + "%");
            #endregion
            #region Problem 9
            //int month = int.Parse(Console.ReadLine());
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 days");
            //        break;
            //    case 3:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 5:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 6:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 7:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 8:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 9:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 10:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;

            //}
            #endregion
            #region Problem 10
            //int x1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int x3 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());
            //if (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1)
            //    Console.WriteLine("The points lie on a straight line.");
            //else
            //    Console.WriteLine("The points do not lie on a straight line.");
            #endregion
            #region Problem 11
            //float H1= float.Parse(Console.ReadLine());
            //float H2= float.Parse(Console.ReadLine());
            //if (H1 > 2 && H2 < 3) 
            //    Console.WriteLine("they are considered highly efficient.");
            // else if (H1 > 3 && H2 < 4) 
            //  Console.WriteLine("they are provided with training to enhance their speed");
            // else if (H1 > 4 && H2 < 5)
            //  Console.WriteLine("they are required to leave the company"); 
            #endregion
            #region Problem 12
            //int X = 100;
            //int Y = X;
            //Console.WriteLine($"Initial value of firstNumber: "+X);
            //Console.WriteLine($"Initial value of secondNumber:"+Y);
            //X = 20;
            //Console.WriteLine("\nAfter modifying");
            //Console.WriteLine($"Value of firstNumber:"+X);
            //Console.WriteLine($"Value of secondNumber:"+Y);
            //Changing one variable does not affect the other because they are stored in separate memory locations
            #endregion
            #region Problem 13
            //Point p01 ;
            //p01 = new Point();
            //Point p02 ;
            //p02 = new Point();
            //p02 = p01;
            //p01.X = 100;
            //Console.WriteLine("Before Modifying : " +p01.X);
            //Console.WriteLine("Before Modifying : " +p02.X);
            //p01.X = 300;
            //Console.WriteLine("After Modifying : " + p01.X);
            //Console.WriteLine("After Modifying : " + p02.X);
            //both variables point to the same object in memory
            #endregion
            #region Problem 14
            // A value 1 will be assigned to d.
            #endregion
            #region Problem 15
            // 6 1
            #endregion
            #region Problem 16
            // 7 7
            #endregion
            #endregion
            #region Notes
                //Math.Max Calculate Max number
                //Math.Min Calculate Min number
            #endregion
        }
    }
}
