using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace LexicalAnalyzer
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        static string spacemodifier(string buffer)
        {
            //brackets modifier
            buffer = buffer.Replace("(" , " ( ");
            buffer = buffer.Replace(")" , " ) ");
            buffer = buffer.Replace("{", " { ");
            buffer = buffer.Replace("}", " } ");
            buffer = buffer.Replace("[", " [ ");
            buffer = buffer.Replace("]", " ] ");
            

            //terminator modifier
            buffer = buffer.Replace(";", " ; ");
            buffer = buffer.Replace(",", " , ");

            //logical operator modifier
            buffer = buffer.Replace("=", " = ");
            buffer = buffer.Replace("+", " - ");
            buffer = buffer.Replace("*", " * ");
            buffer = buffer.Replace("/", " / ");
            buffer = buffer.Replace("<", " < ");
            buffer = buffer.Replace(">", " > ");
            buffer = buffer.Replace("<=", " <= ");
            buffer = buffer.Replace(">=", " >= ");
            buffer = buffer.Replace("&", " & ");
            buffer = buffer.Replace("|", " | ");
            buffer = buffer.Replace("&&", " && ");
            buffer = buffer.Replace("||", " || ");
            
            //data types modifier
            buffer = buffer.Replace("main", " main ");
            buffer = buffer.Replace("int", " int ");
            buffer = buffer.Replace("long", " long ");
            buffer = buffer.Replace("float", " float ");
            buffer = buffer.Replace("double", " double ");
            buffer = buffer.Replace("decimal", " decimal ");
            buffer = buffer.Replace("string", " string ");
            buffer = buffer.Replace("char", " char ");

            //condition modifier
            buffer = buffer.Replace("if", " if ");
            buffer = buffer.Replace("else", " else ");
            buffer = buffer.Replace("for", " for ");
            buffer = buffer.Replace("while", " while ");
            buffer = buffer.Replace("elseif", " elseif ");

            //statement modiifier
            buffer = buffer.Replace("return", " return ");
            
            //spaces remove with separator
            buffer = buffer.Replace("  ", " ");
            buffer = buffer.Replace("   ", " ");
            buffer = buffer.Replace("    ", " ");
            buffer = buffer.Replace("     ", " ");
            buffer = buffer.Replace("  ", " ");
            buffer = buffer.Replace("\n", " ");
            buffer = buffer.Replace("\r\n", " ");
            return buffer;
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[,] array = new string[,] { 
            { "if", "if", null },
            { "else", "else", null },
            { "<", "Relop1", "LT" },
            { ">", "Relop2", "LTE" },
            { "=", "Relop3", "EQ" },
            { "!=", "Logop1", "Neg" },
            { "|", "Logop2", "Or" },
            { ">", "Logop3", "GT" },
            { ">=", "Logop4", "GTE" },
            { "(", "Bracket", "Open" },
            { ")", "Bracket", "Close" },
            { "{", "Braces", "Open" },
            { "}", "Braces", "Close" },
            { ";", "Ter", null },
            { ",", "comma", null },
            { "+", "AssOp1", "Plus" },
            { "-", "AssOp2", "Minus" },
            { "/", "AssOp3", "Mul" },
            { "*", "AssOp4", "Div" },
            { "for", "loop1", null },
            { "while", "loop2", null },
            { "main", "func", "Main" },
            { "int", "type1", null },
            { "float", "type2", null },
            { "double", "type3", null  },
            { "decimal", "type4", null },
            { "char", "type5", null },
            { "string", "type6", null },
            { "return", "type7", null }
           
            };
            /*string s = string.Join(",", array);
            listBox2.Items.Add(s);*/

            //string filename = @"C:\Users\Ansari\Desktop\testing.txt";
            //string stream = File.ReadAllText(filename);
            string stream = textBox1.Text;
            stream = spacemodifier(stream);
            
            string[] word = stream.Split(' ');
           // listBox1.Items.Clear();
           // string w = string.Join(" ",word);
            listBox1.Items.Clear();
            foreach (string item in word)
            {
                listBox1.Items.Add(item);

            }
            for (int i = 0; i < word.Length; i++ )
            {
                for (int j=0;j < array.Length / 3; j++)
                {
                    //foreach (Match match in Regex.Matches(array[j,0],word[i]))
                    if(array[j,0] == word[i])
                    {
                        //if(match.ToString() == array[j,0])
                        //{
                            listBox2.Items.Add(array[j, 0] + "\t\t\t" + array[j, 1] + "\t\t\t" + array[j, 2] + "\n");
                        //}
                        break;
                    }
                    

                }
            }
                
       }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = string.Empty;
            
        }
       
    }
}
