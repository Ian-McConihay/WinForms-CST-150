﻿/*
 * Ian McConihay
 * CST-150
 * Activity 5 
 * Sep 22 2024
 * 
 */

namespace CST_150_DogClass.BusinessLayer
{
    internal class Dog
    {
        public string Name { get; set; }
        public double NeckRad {  get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public bool Sit {  get; set; }

        /// <summary>
        /// Default dog constructor
        /// </summary>
        public Dog() 
        {
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="neckRad"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="sit"></param>
        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            Name = name;
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit;
        }

        /// <summary>
        /// Method that takes the property NeckRad and returns the circumference in centementers.
        /// </summary>
        /// <returns></returns>
        public double CalCircumference()
        {
            const  double cmConversion = 2.54D;
            double circumference = 0.00D;
            circumference = 2 * Math.PI * NeckRad;
            return (circumference * cmConversion);
        }

        /// <summary>
        /// Convert Weight from pounds to kilograms
        /// </summary>
        /// <returns></returns>
        public double CalWeight()
        {
            const double kgConversion = 0.453592D;
            return( Weight * kgConversion );
        }


    }
}
