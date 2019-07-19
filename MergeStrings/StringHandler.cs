using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStrings
{
    public class StringHandler
    {
        private string FirstText;
        private string SecondText;
        private string NumberPart;
        private string Result;

        public StringHandler(string firstText, string secondText)
        {
            FirstText = firstText;
            SecondText = secondText;
            Result = string.Empty;
            NumberPart = string.Empty;
        }

        private void FillResult(char ch)
        {
            if (!Char.IsDigit(ch))
            {
                Result += ch.ToString();
            }
            else
            {
                NumberPart += ch.ToString();
            }
        }

        public string GetMergedString()
        {
            char[] arr1 = FirstText.ToCharArray();
            char[] arr2 = SecondText.ToCharArray();

            int i = 0, j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                FillResult(arr1[i]);
                FillResult(arr2[j]);
                i++;
                j++;
            }
            if(i != arr1.Length)
            {
                for (int k = i; k < arr1.Length; k++)
                {
                    Result += arr1[k].ToString();
                }
            }
            if (i != arr2.Length)
            {
                for (int l = j; l < arr2.Length; l++)
                {
                    Result += arr2[l].ToString();
                }
            }

            return Result + NumberPart;
        }


    }
}
