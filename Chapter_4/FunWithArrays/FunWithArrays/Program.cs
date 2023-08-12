using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with Arrays *****\n");
            //SimpleArrays();
            //ArrayInitialization();
            //ArrayOfObjects();
            //MultiArray();
            JaggedMultidimensionalArray();
        }

        #region Simple Array
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }
        #endregion

        #region Array Init Syntax
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        #endregion

        #region Array of objects
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            object[] myObject = new object[4];
            myObject[0] = 10;
            myObject[1] = false;
            myObject[2] = new DateTime(1969, 3, 24);
            myObject[3] = "Form & Void";

            foreach (object obj in myObject) { Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj); }
            Console.WriteLine();
        }
        #endregion

        #region Multi Array Rect
        static void MultiArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");

            int[,] myMatrix;
            myMatrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion

        #region Jagged Multi Arra
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array:\n");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}