﻿namespace session_4c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statement
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}


            //#endregion
            //#region for-foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //   Numbers[i] += 10;
            //   if (Numbers[i] == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(Numbers[i] );
            //}


            //foreach (int number in Numbers)
            //{
            //    number += 10;
            //    Console.WriteLine(number);
            //}
            //#endregion
            //#region While - Do while
            //Console.WriteLine("Please enter an even number");
            //int Numbner = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Numbner} is even number");

            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Please enter an even number");
            //    Number = int.Parse(Console.ReadLine());
            //    Flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2 == 1 || !(Flag));
            //Console.WriteLine($"{Number} is even number");


            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || !(Flag))
            //{
            //    Console.WriteLine("Please enter an even number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //Console.WriteLine($"{Number} is even number");

            //#endregion
            //#region String


            //string Name;
            //Name = new string("Ali");


            //string Name01 = "Ali";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");

            //Name01 = "Mostafa";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            //Console.WriteLine("********************************************");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            //string Message = "Hello";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("********************");
            //Message += " root";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //#endregion
            //#region StringBuilder
            //StringBuilder Meassge;
            //Meassge = new StringBuilder("Hello");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            //Meassge += route; 
            //Meassge.Append(" root");
            //Console.WriteLine(Meassge);
            //Console.WriteLine(Meassge.GetHashCode());
            //#endregion
            //#region StringBuilderMethods
            //StringBuilder Message = new StringBuilder("Welcome");
            //Message.Append(" to route");
            //Console.WriteLine(Message);
            //Message.AppendLine(" Ali");
            //Message.Append(" saleh");
            //Console.WriteLine(Message);

            //Message.Remove(0, 7);
            //Console.WriteLine(Message);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);

            //int age = 22;
            //string Name = "Amir";
            //Message.AppendFormat("Name {0}, age {1}", Name, age);
            //Message.AppendJoin("/", "21", "11", "89");
            //Console.WriteLine(Message);
            //#endregion
            //#region Array 1D
            //int[] Numbers = new int[3];
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3 };
            //int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"please enter a no {i + 1} ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion
            #region Q1
            //bool Flag;
            //Console.WriteLine("please enter a integer number ");
            //Flag = int.TryParse(Console.ReadLine(), out var Number);
            //if (Flag && Number > 0)
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Q2


            //Console.WriteLine("please enter an intger number");
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} * {Number} = {i * Number}");
            //}
            #endregion
            #region Q3
            //Console.WriteLine("please enter a number");
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i < Number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Q4
            //int result = 1;
            //Console.WriteLine("please enter the base ");
            //int.TryParse(Console.ReadLine(), out int Base);
            //Console.WriteLine("please enter the foundation");
            //int.TryParse(Console.ReadLine(), out int Found);
            //for (int i = 1; i <= Found; i++)
            //{
            //    result *= Base;

            //}
            //Console.WriteLine(result);
            #endregion
            #region Q5
             
            Console.WriteLine("please enter string");
            string tex = Console.ReadLine();
            for (int i = 0; i < tex.Length; i++)
            {
                Console.Write(tex[tex.Length - 1 - i]);
            }

            #endregion
            #region Q6
            //Console.WriteLine("please enter a start");
            //int Start = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter a end ");
            //int End = int.Parse(Console.ReadLine());
            //for (int i = Start; i <= End; ++i)
            //{

            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #region Q8
            //Console.WriteLine("plese enter degree of marks");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }

            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q9

            //Console.WriteLine("please enter a string ");
            //string str = Console.ReadLine();
            //int start, end;
            //Console.WriteLine("please enter start");
            //start = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter end");
            //end = int.Parse(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion
            #region Q10
            //Console.WriteLine("please enter first string");
            //string st1 = Console.ReadLine();
            //Console.WriteLine("please enter  second string ");
            //string st2 = Console.ReadLine();
            //string FullSt = st1 + st2;
            //Console.WriteLine(FullSt);
            #endregion
            #region Q12
            //Console.WriteLine("Please enter the size of array");
            //int size = int.Parse(Console.ReadLine()), sum = 0;
            //int[] Numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"please ener array element no {i}");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //    sum += Numbers[i];

            //}
            //Console.WriteLine($"Sum of elements of array is {sum}");
            #endregion
            #region Q14
            //int[] Numbers = new int[7] { 1, 2, 3, 2, 5, 4, 5 };
            //int counter = 0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers.Length; j++)
            //    {
            //        if (Numbers[i] == Numbers[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine($"{Numbers[i]} is repated {counter} times");
            //    counter = 0;
            //}
            #endregion
            #region Q18
            Console.WriteLine("please enter number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number of coulmns");
            int columns = int.Parse(Console.ReadLine());
            int[,] Numbers1 = new int[rows, columns];
            int[,] Numbers2 = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"enter value of row{i + 1}");

                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("please enter value of coulmns ");
                    Numbers1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Array.Copy(Numbers1, Numbers2, Numbers2.Length);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(Numbers2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}