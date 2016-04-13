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
            buffer = buffer.Replace("(", " ( ");
            buffer = buffer.Replace(")", " ) ");
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
            buffer = buffer.Replace("  ", "");
           
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
          
            string filename = @"C:\Users\Ansari\Desktop\testing.txt";
            string stream = File.ReadAllText(filename);
            stream = spacemodifier(stream);
            textBox1.Text = stream;

            string[] word = textBox1.Text.Split(' ');
            listBox1.Items.Clear();

            foreach (string item in word)
            {
                listBox1.Items.Add(item);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
