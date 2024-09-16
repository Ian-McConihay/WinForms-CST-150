/*
 * Ian McConihay
 * CST-150
 * Activity 4 Part 2
 * Sep 15 2024
 * 
 */
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to execute methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
          
            int num1 = 2, num2 = 3, num3 = 4;
            SumInts(num1, num2);


            

            double double1 = 1.1D, double2 = 2.3D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            DisplayResults("Method 2: Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);

            int randomSum = 0;
            DisplayResults(string.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);

            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);
            
            string firstString = "This is test number 82.";
            string secondString = "The sky is blue today";
            FewestChars(firstString, secondString);

            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);

            GenerateArrayOfTen();

            bool bool1 = true;
            bool bool2 = false;
            bool bool3 = false;
            DisplayResults("Method 8: bool value compare: True and False = " +AreBooleansEqual(bool1, bool2).ToString() + " ----> False and False = " + AreBooleansEqual(bool3, bool2).ToString(), false);

            int intValue = 5;
            double doubleValue = 7.2;
            double product = MultiplyIntAndDouble(intValue, doubleValue);
            DisplayResults(string.Format("Method 9: int multiplied by double: {0}", product.ToString()), false);


        }

        /// <summary>
        /// Displays results in label.
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="clearLabel"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel)
            {
                lblResults.Text = "";
            }

            lblResults.Text += string.Format("{0}\n", descText);
        }

        /// <summary>
        /// Sums up two ints
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            int sum = num1 + num2;
            DisplayResults("Method 1: The sum of " + num1 + " + " + num2 + " = " + sum, true);
        }
        /// <summary>
        /// Averages out 5 doubles
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns></returns>
        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            const double AvgDenominator = 5.0D;
            return ((num1 + num2 + num3 + num4 + num5) / AvgDenominator);
        
        }
        /// <summary>
        /// Adds the sum of to random numbers between 1 and 101
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            int num1 = 0, num2 = 0, sum = 0;
            Random rand = new Random();
            num1 = rand.Next(1, 101);
            num2 = rand.Next(1, 101);
            sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Modulus of two to fine the remander of three ints
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            if(sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Finds string with fewest chars
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            int countChar1 = 0, countChar2 = 0, pointer = 0;
            do
            {
                try
                {
                    if (char.IsLetter(string1[pointer]))
                    {
                        countChar1++;
                    }
                    else
                    {
                        if (char.IsLetter(string2[pointer]))
                        {
                            countChar2++;
                        }

                    }
                }
                catch (Exception e)
                {

                }
                pointer++;
            }
            while ((pointer < string1.Length) || pointer < string2.Length);

            if (countChar1 < countChar2)
            {
                DisplayResults("Method 5: string 1 has fewer letters", false);
            }
            else if (countChar2 < countChar1)
            {
                DisplayResults("Method 5: string 2 has fewer letters", false);
            }
            else
            {
                DisplayResults("Method 5: Both strings have the same number of letters", false);
            }
        }

        /// <summary>
        /// Finds largest double.
        /// </summary>
        /// <param name="arrDoubles"></param>
        /// <returns></returns>
        private double LargestDouble(double[] arrDoubles)
        {
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestDouble = 0D;

            while(arrPointer < arrDoubles.Length)
            {
                valueAtIndex = arrDoubles[arrPointer];

                if(valueAtIndex > biggestDouble)
                {
                    biggestDouble = valueAtIndex;
                }
                arrPointer++;
            }
            return biggestDouble;
        }

        // Write a method that generates and returns an array of ten integer values.
        /// <summary>
        /// generates and returns an array of ten integer values.
        /// </summary>
        /// <returns></returns>
        public void GenerateArrayOfTen()
        {
            // Create an array with 10 elements
            int[] array = new int[10];

            // Fill the array with integers from 1 to 10
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            // Concatenates the array elements into a single string. Each element is separated by a comma and a space.
            DisplayResults($"Method 7: Array of ints: {string.Join(", ", array)}", false);
        }


        // Write a method that takes two bool variables and returns true if they have the same value, false otherwise.
        /// <summary>
        /// Compares two bools
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool AreBooleansEqual(bool a, bool b)
        {
            return a == b;
        }


        // Write a method that takes an int and a double and returns their product. Display the values of the array with descriptive text.
        /// <summary>
        /// Multiplies an int and double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double MultiplyIntAndDouble(int a, double b)
        {
            return a * b;
        }
    }
}
