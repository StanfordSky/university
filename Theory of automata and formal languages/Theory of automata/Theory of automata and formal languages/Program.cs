using System;
using System.Collections.Generic;

public class Program{

    // List for saving found lexemes
    static List<string> LexemesSymbols = new List<string>();
    static Dictionary<string,string[]> Lexemes = new Dictionary<string, string[]>();

    static void Main(string[] args)
    {

        // Our expression
        string Expression = args[0];
        string Test = "<ид1>=<ид2>^<ид3>+<ид4>^<ид3>+<ид5>";
        string Result = "";

        Console.WriteLine(Expression + "\n");
        // Remove all spaces from our expression
        Expression = RemoveSpaces((Expression));

       
        // Defining Lexemes and adding their into List
        DefineLexemes(Expression);


        string replace = "",
                result = "";
        foreach (var variable in Lexemes)
        {
            replace = "<ид" + variable.Value[1] + ">";
            result = Expression.Replace(variable.Key, replace);
        }
        Result = Test;
        Console.WriteLine(Result);

        Console.WriteLine( "\n № |    Type   | Key " );
        foreach (var VARIABLE in Lexemes)
        {
            Console.WriteLine(" " + VARIABLE.Value[1] + " |   " + VARIABLE.Value[0] + "  | " + VARIABLE.Key);
        }


    }

    // Function that finding lexems into expression
    static void DefineLexemes(string expression)
    {
        string DefineType = "";
        int Value = 1;
        for (int i = 0; i < expression.Length; ++i)
        {
            string Lexeme = "";
            if (Char.IsLetter((expression[i]))) // First symbol - letter
            {
                DefineType = "string"; // lexemes is letters + numbers
                while (Char.IsLetter(expression[i]) || Char.IsNumber(expression[i]) || expression[i] == '_')
                {
                        
                    Lexeme += expression[i];
                    if (i+1 >= expression.Length)
                        break;
                    if (i < expression.Length)
                        i++;

                    if (Char.IsSymbol(expression[i]))
                    {
                        LexemesSymbols.Add(Convert.ToString(expression[i]));
                    }
                }   
                
            }
            else if (Char.IsNumber(expression[i])) // First symbol - number 
            {
                DefineType = "double"; // lexemes is + numbers
                while (Char.IsNumber(expression[i]) || expression[i] == '.')
                {

                    Lexeme += expression[i];
                    if (i+1 >= expression.Length)
                        break;

                    if (i < expression.Length)
                        i++;

                   
                    if (Char.IsLetter(expression[i]))
                    {
                        Console.WriteLine(Lexeme + " - неккоректный данные. Число не может содежать цифр. Лексема должна начинатся с буквы.");
                        return;
                    }

                    if (Char.IsSymbol(expression[i]))
                    {
                        LexemesSymbols.Add(Convert.ToString(expression[i]));
                    }
                }             
            }


            if (!Lexemes.ContainsKey(Lexeme))
            {
                string[] Values = new string[2] { DefineType, Convert.ToString(Value) };
                Lexemes.Add(Lexeme, Values);                           
                Value++;
            }
            if (i >= expression.Length)
                break;
        }

    }

    // Function for remove spaces from string
    static string RemoveSpaces(string expression)
    {
        
        return expression.Replace(" ", "");
    }
}