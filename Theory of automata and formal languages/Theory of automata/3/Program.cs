using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3
{
    class Program
    {
        static bool DEBUG = false;
        
        static Dictionary<int, string[]> lexemes = new Dictionary<int, string[]>();
        static string StrID = "";

        static void Main(string[] args)
        {
            string teststring = " first = (45ac*2)-1+12dd + first";
            debug(teststring, "Входное выражение в исходном виде:");
            
            
            teststring = removeSpaces(teststring);

            if (DEBUG){
                debug(teststring, "Входное выражение без пробелов:");
            }

            try
            {
                defineLexemes(teststring);
                outputTableId();
                Console.WriteLine(StrID);
            }
            catch(Exception e)
            {
                Console.WriteLine("Введены неккоректные данные. Лексический анализатор Лядова В.С.(О-18-ПРИ-рпс-Б) не знает, что ему делать.\n\n\n" + 
                    "Сообщение ошибки: " + e.Message + "\n\n\n" +
                    "Стек вызова: " + e.StackTrace + "\n\n\n" +
                    "Дополнительные сведения об ошибке: " + e.Data + "\n\n\n");
            }
            
        }



        static void defineLexemes(string expression)
        {
            if (DEBUG){ 
                debug("Начало тестирования алгоритма:");
            }
            
            for (int i = 0; i < expression.Length; i++)
            {
                string lexeme    = "",
                       determine = "";

                bool   isLexeme  = false;

                if (expression[i] == '(' ||
                    expression[i] == ')' || 
                    expression[i] == '=' || 
                    expression[i] == '+' || 
                    expression[i] == '/' || 
                    expression[i] == '-' || 
                    expression[i] == '*'){
                    if (DEBUG){
                        debug("Найден символ: " + expression[i] + ",");
                    }
                    StrID += expression[i];
                    continue;
                }else if (Char.IsNumber(expression[i])){
                    do {
                        lexeme += expression[i];
                        i++;
                        if (i >= expression.Length)
                            break;
                    } while (Char.IsNumber(expression[i]) ||
                                           expression[i] == 'a' ||
                                           expression[i] == 'b' ||
                                           expression[i] == 'c' ||
                                           expression[i] == 'd' ||
                                           expression[i] == 'f');
                    i--;
                    determine = "HEX";

                }
                else if (Char.IsLetter(expression[i]))
                {
                    do
                    {
                        lexeme += expression[i];
                        i++;
                        if (i >= expression.Length)
                            break;
                    } while (Char.IsLetter(expression[i]) ||
                             Char.IsNumber(expression[i]));
                    i--;
                    determine = "ID";
                }
                else if (expression[i] == ';')
                {
                    if (DEBUG)
                    {
                        debug("Найден разделитель выражений ';'", "Позиция " + i + ": ");
                        StrID += ";";
                        Console.WriteLine("\n");
                    }
                }


                if (DEBUG && lexeme != "")
                {
                    debug(lexeme, "Найдена лексема: ");           
                }

                if (lexeme != "")
                {
                    string[] values = new string[2] { lexeme, determine };                 


                    if (!isLexemes(lexeme))
                    {
                        lexemes.Add((lexemes.Count + 1), values);
                        StrID += "<id" + (lexemes.Count) + ">";
                    }else{
                        StrID += "<id" + (getKeyLexeme(lexeme)) + ">";
                    }

                }
            }
            if (DEBUG){
                debug("Окончание тестирования алгоритма.");
            }       
        }


        static void outputTableId()
        {
            Console.WriteLine(" ---  | --   | ---- ");
            Console.WriteLine(" key  | type | id ");
            Console.WriteLine(" ---  | --   | ---- ");
            foreach (var VARIABLE in lexemes)
            {
                if (VARIABLE.Value[1] == "ID"){
                    Console.WriteLine("   " + VARIABLE.Key + "  | " + VARIABLE.Value[1] + "   | " + VARIABLE.Value[0] + " ");
                }
                else{
                    Console.WriteLine("   " + VARIABLE.Key + "  | " + VARIABLE.Value[1] + "  | " + VARIABLE.Value[0] + " ");
                }
               
            }
            Console.WriteLine(" ---  | ---  | ---- ");

        }

        static string removeSpaces(string expression)
        {
            string result = expression.Replace("\n", "");
            return result.Replace(" ", "");
        }

        static void debug(string expression, string description = "")
        {
            Console.Write(description + " ");
            Console.WriteLine(expression);
        }

        static bool isLexemes(string lexeme)
        {
            foreach (var item in lexemes)
            {
                if (item.Value[0] == lexeme)
                    return true;
            }
            return false;
        }

        static int getKeyLexeme(string lexeme)
        {
            foreach (var item in lexemes)
            {
                if (item.Value[0] == lexeme)
                    return item.Key;
            }
            return -1;
        }
    }


}
