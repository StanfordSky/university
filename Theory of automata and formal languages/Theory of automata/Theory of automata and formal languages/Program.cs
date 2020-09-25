using System;
using System.Collections.Generic;

public class Program{

    // List for saving found lexemes
    static List<string> Lexemes = new List<string>();
    static Dictionary<string,string> LexemesDic = new Dictionary<string, string>();

    static void Main()
    {

        // Our expression
        string Expression = "zddwq2   =    y1212^2    +    xwqdqwd^2  + 1dqwdwdw";


        // Remove all spaces from our expression
        Expression = RemoveSpaces((Expression));

        // Defining Lexemes and adding their into List
        DefineLexemes(Expression);

        foreach (var VARIABLE in Lexemes)
        {
            Console.WriteLine(VARIABLE);
        }
    }

    // Function that finding lexems into expression
    static void DefineLexemes(string expression)
    {
        for (int i = 0; i < expression.Length; ++i)
        {
            if (Char.IsLetter((expression[i])))
            {
                string Lexeme = "";


                while (Char.IsLetter(expression[i]) || Char.IsNumber(expression[i])) 
                {
                    Lexeme += expression[i];
                    if(i<expression.Length)
                        i++;
                } 

                if (!Lexemes.Contains(Lexeme))
                {
                    Lexemes.Add(Lexeme);
                }
            }
        }
    }

    // Function for remove spaces from string
    static string RemoveSpaces(string expression)
    {
        return expression.Replace(" ", "");
    }
}