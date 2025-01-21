namespace session_4c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statement
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} T");
            }


            #endregion
            #region for-foreach
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < Numbers.Length; i++)
            {
               Numbers[i] += 10;
               if (Numbers[i] == 5)
                {
                    continue;
                }
                Console.WriteLine(Numbers[i] );
            }

            
            foreach (int number in Numbers)
            {
                number += 10;//invalid
                Console.WriteLine(number);
            }
            #endregion
            #region While - Do while
            Console.WriteLine("Please enter an even number");
            int Numbner = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Numbner} is even number");

            int Number;
            bool Flag;
            do
            {
                Console.WriteLine("Please enter an even number");
                //Number = int.Parse(Console.ReadLine());
                Flag = int.TryParse(Console.ReadLine(), out Number);

            } while (Number % 2 == 1 || !(Flag));
            Console.WriteLine($"{Number} is even number");


            int Number = 3;
            bool Flag = false;
            while (Number % 2 == 1 || !(Flag))
            {
                Console.WriteLine("Please enter an even number");
                Flag = int.TryParse(Console.ReadLine(), out Number);
            }
            Console.WriteLine($"{Number} is even number");

            #endregion
            #region String


            string Name;
            Name = new string("Ali");


            string Name01 = "Ali";
            string Name02 = "Ali";
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            Console.WriteLine("********************************************");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            string Name01 = "Ahmed";
            string Name02 = "Ali";
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            Console.WriteLine("********************************************");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            Name02 = Name01;
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            Console.WriteLine("********************************************");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");

            Name01 = "Mostafa";
            Console.WriteLine(Name01);
            Console.WriteLine($"Name01 hashCode : {Name01.GetHashCode()}");
            Console.WriteLine("********************************************");
            Console.WriteLine(Name02);
            Console.WriteLine($"Name02 HashCode : {Name02.GetHashCode()}");
            string Message = "Hello";
            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());
            Console.WriteLine("********************");
            Message += " root";
            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder
            StringBuilder Meassge;
            Meassge = new StringBuilder("Hello");
            Console.WriteLine(Meassge);
            Console.WriteLine(Meassge.GetHashCode());
            Meassge += route; 
            Meassge.Append(" root");
            Console.WriteLine(Meassge);
            Console.WriteLine(Meassge.GetHashCode());
            #endregion
            #region StringBuilderMethods
            StringBuilder Message = new StringBuilder("Welcome");
            Message.Append(" to route");
            Console.WriteLine(Message);
            Message.AppendLine(" Ali");
            Message.Append(" saleh");
            Console.WriteLine(Message);

            Message.Remove(0, 7);
            Console.WriteLine(Message);

            Message.Insert(0, "Hello");
            Console.WriteLine(Message);

            int age = 22;
            string Name = "Amir";
            Message.AppendFormat("Name {0}, age {1}", Name, age);
            Message.AppendJoin("/", "21", "11", "89");
            Console.WriteLine(Message);
            #endregion
            #region Array 1D
            int[] Numbers = new int[3];
            int[] Numbers = new int[3] { 1, 2, 3 };
            int[] Numbers = new int[] { 1, 2, 3 };
            int[] Numbers = { 1, 2, 3 };
            int[] Numbers = new int[3];

            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"please enter a no {i + 1} ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.WriteLine(Numbers.Length);
            Console.WriteLine(Numbers.Rank);
            #endregion

        }
    }
}