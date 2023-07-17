using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class TableData
    {
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Zip { get; set; }
        public string Color { get; set; }
        public string Salary { get; set; }


        static Random random = new Random();
        public static string GenderValue(int i)
        {
            if (i % 2 == 0)
                return "male  ";
            return "female";

        }

        public static string AgeValue()
        {
            return random.Next(20, 90).ToString();
        }

        public static string ZipValue()
        {
            return random.Next(4200, 4499).ToString();
        }

        public static string ColorValue()
        {
            string[] arr = new string[] { "blue ", "green", "brown" };
            int index = random.Next(0, 2);
            return arr[index];
        }

        public static string SalaryValue()
        {
            int value = random.Next(1000, 9999);
            string salary = value + "$";
            return salary;
        }

        public static string GenderAnonymous()
        {
            return "{male:female}";
        }

        public static string AgeAnonymous(string age, int nK)
        {
            if (nK > 4)
                return "20<age<100";

            return (int.Parse(age[0].ToString()) - nK + 2) + "0<age<" + (int.Parse(age[0].ToString()) + nK - 1) + "0";
        }

        public static string ZipAnonymous(string zip, int nK)
        {
            StringBuilder builder = new StringBuilder(zip);
            for (int i = 1; i < nK && i < 5; ++i)
            {
                builder[builder.Length - i] = '*';
            }

            return builder.ToString();
        }

        public static string ColorAnonymous(string color, int nK)
        {
            if (nK == 2)
            {
                switch (color)
                {
                    case "blue ":
                        return "{blue;green}";
                    case "green":
                        return "{green;brown}";
                    case "brown":
                        return "{brown;blue}";
                    default:
                        return "";
                }
            }
            else
                return "{blue;green;brown}";

        }

        public static string SalaryAnonymous(string sal, int nK)
        {
            StringBuilder builder = new StringBuilder(sal);
            for (int i = 1; i < nK && i < 5; ++i)
            {
                builder[builder.Length - i - 1] = '*';
            }

            return builder.ToString();
        }

    }
}
