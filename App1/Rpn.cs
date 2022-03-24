using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicProblems
{
    public class Rpn
    {
        public static void Start()
        {
            string input = "2 5 7 2 + + *";
            Console.WriteLine(Rpn_operation(input));
        }

        public static string Rpn_operation(string input)
        {
            List<string> elements = input.Split(" ").ToList();

            List<string> numbers = new List<string>();
            List<string> operators = new List<string>();

            foreach (var item in elements)
            {
                if (IsNumber(item))
                    numbers.Add(item);
                else
                    operators.Add(item);
            }

            int result = 0;
            for (int i = operators.Count; i > 0; i--)
            {
                string currentOperator = operators[i - 1];

                int number1 = int.Parse(numbers[numbers.Count - 1]);
                int number2 = int.Parse(numbers[numbers.Count - 2]);

                switch (currentOperator)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number2 - number1;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                }


                numbers.RemoveAt(numbers.Count - 1);
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Add(result.ToString());
            }

            return numbers[0];
        }

        public static bool IsNumber(string val)
        {
            int num;
            return int.TryParse(val, out num);
        }
    }
}
