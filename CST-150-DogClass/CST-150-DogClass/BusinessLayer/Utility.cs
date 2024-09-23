/*
 * Ian McConihay
 * CST-150
 * Activity 5 
 * Sep 22 2024
 * 
 */

namespace CST_150_DogClass.BusinessLayer
{
    internal class Utility
    {
        /// <summary>
        /// Checks return is false if the parameter is null, empty, or white space.
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Test to check if vaild double was enetred.
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns></returns>
        public (double doublValue, bool isConverted) ValidDouble(string valueToTest)
        {
            double convertValue = 0.00D;
            if (Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1D, false);
        }

        /// <summary>
        ///Vonvert Yes to bool true and No to bool false. 
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if (YesOrNo == "Yes")
            {
                return true;
            }
            return false;
        }
    }
}
