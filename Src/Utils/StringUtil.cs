using System;

namespace CrashCourse2021ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }

            return stringToMeasure.Length;
        }

        internal string SumStrings(string value1, string value2)
        {
            return ((int.Parse(value1) + int.Parse(value2)).ToString());
        }

        internal string DivideString(string value1, string value2)
        {
            return (int.Parse(value1) / int.Parse(value2)).ToString();
        }

        internal string StringContains(string value1, string value2)
        {
            return String.Format(value1.Contains(value2)?"YES":"NO");
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            string[] strings = inputString.Split("+");
            int[] ints = new int[strings.Length];
            for(int i = 0 ; i < strings.Length ; i++){
                ints[i] = int.Parse(strings[i]);
            }
            int total = 0;
            for (int i = 0 ; i < ints.Length ; i++){
                total+=ints[i];
            }
            return total.ToString();

        }

        internal string EvenNumber(int numbertoTest)
        {
            return string.Format(numbertoTest%2==0?"EVEN":"ODD");
        }
    }
}