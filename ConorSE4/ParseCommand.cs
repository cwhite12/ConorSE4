using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConorSE4.Properties;
using ConorSE4.Shapes;
namespace ConorSE4
{
    public class ParseCommand
    {
        Form1 form = new Form1();
        String var;
        private Point moveToNumbers;
        private Point drawtoNumbers;

        /// <summary>
        /// method that is used by the syntax button to check if user input is valid syntax
        /// </summary>
        /// <returns>a boolean that determines if the syntax is valid</returns>
        public bool validateSyntax(TextBox commandRunTextBox)
        {
            String[] allowedValues = { "drawTo", "rect", "circle","moveTo","square","pen"};

            String textFromTextBox = commandRunTextBox.Text;
            bool doesItContainValidSyntax = ContainsAny(textFromTextBox, allowedValues);
            if (doesItContainValidSyntax)
            {
                form.errorProvider.SetError(commandRunTextBox, "");
            }
            else

                try
                {
                    form.errorProvider.SetError(commandRunTextBox, "please enter valid syntax");
                } catch (Exceptions.SyntaxNotValidException e)
                {
                    Console.WriteLine(e.Message);
                }

            return doesItContainValidSyntax;

        }
        /// <summary>
        /// A method to check if any of the values in the text boxt text are in the array of allowed values
        /// </summary>
        /// <param name="textBoxText">the text entered from the user</param>
        /// <param name="allowedValues">an array list of the allowed values</param>
        /// <returns>a boolean if it contains any</returns>
        public static bool ContainsAny(string textBoxText, params string[] allowedValues)
        {
            foreach (string allowed in allowedValues)
            {
                if (textBoxText.Contains(allowed))
                    return true;
            }

            return false;
        }
        /// <summary>
        /// Gets the user input entered into the textbox
        /// </summary>
        /// <returns>returns the var value of the user input</returns>
        public String GetTextFromTextBox(TextBox commandRunTextBox)
        {

            var = commandRunTextBox.Text;
            //   MessageBox.Show(var);

            return var;

        }

        /// <summary>
        /// moves the point where the draw is beginning
        /// </summary>
        /// <param name="commandRunTextBox">the text box that receives user input</param>
        /// <returns></returns>
        public Point moveTo(TextBox commandRunTextBox)
        {
       
            String text = GetTextFromTextBox(commandRunTextBox);
            int numbers = Int32.Parse(text);

            Point point = new Point(numbers);
            if (text.Contains("reset"))
            {
                return point = new Point(1);
            }
            return point;
        
        }
       
        /// <summary>
        /// method for drawing on the bitmap 
        /// </summary>
        /// <param name="commandRunTextBox">this is the text box that receives the usser input</param>
        /// <param name="myBitmap">The bitmap that we are drawing on</param>
        public void draw(TextBox commandRunTextBox, Bitmap myBitmap)
        {
            String text = GetTextFromTextBox(commandRunTextBox);
            int numbers = Int32.Parse(text);
            
           
            String letters = Regex.Replace(text, @"[\d0]", string.Empty);
            if(text.Contains("moveTo")) {
                Point moveToNumbers = new Point(numbers);
            }
            if (text.Contains("drawTo"))
            {
                Point drawToNumbers = new Point(numbers);
            }

            Graphics g = Graphics.FromImage(myBitmap);
            Color color = form.setColour();
            Pen p = new Pen(color, 2);
            Draw draw = new Draw(g, p, moveToNumbers, drawtoNumbers);
        }
        /// <summary>
        /// returns a circle
        /// </summary>
        /// <param name="commandRunTextBox">the text box that receives user input</param>
        /// <param name="myBitmap">the bitmap we are drawing on</param>
        public void circle(TextBox commandRunTextBox, Bitmap myBitmap)
        {
            String text = GetTextFromTextBox(commandRunTextBox);
            int numbers = Int32.Parse(text);
            String letters = Regex.Replace(text, @"[\d0]", string.Empty);

            Graphics g = Graphics.FromImage(myBitmap);
            Pen p = new Pen(Color.Red, 2);
            Circle circle = new Circle(Color.Red, 50, 50, numbers);
        }
        /// <summary>
        /// returns a rectangle
        /// </summary>
        /// <param name="commandRunTextBox">the text box that receives user input</param>
        /// <param name="myBitmap">the bitmap we are drawing on</param>
        public void rectangle(TextBox commandRunTextBox, Bitmap myBitmap)
        {

            String text = GetTextFromTextBox(commandRunTextBox);
            int numbers = Int32.Parse(text);
            String letters = Regex.Replace(text, @"[\d0]", string.Empty);

            Graphics g = Graphics.FromImage(myBitmap);
            Pen p = new Pen(Color.Red, 2);
            Shapes.Rectangle rectangle = new Shapes.Rectangle(Color.Red, 50, 50, numbers, numbers);
        }

        /// <summary>
        /// returns a square
        /// </summary>
        /// <param name="commandRunTextBox">the text box that receives user input</param>
        /// <param name="myBitmap">the bitmap we are drawing on</param>
        public void square(TextBox commandRunTextBox, Bitmap myBitmap)
        {
            String text = GetTextFromTextBox(commandRunTextBox);
            int numbers = Int32.Parse(text);
            String letters = Regex.Replace(text, @"[\d0]", string.Empty);

            Graphics g = Graphics.FromImage(myBitmap);
            Pen p = new Pen(Color.Red, 2);
            Square rectangle = new Square(Color.Red, 50, 50, numbers);
        }


        /// <summary>
        /// gets command from text box
        /// </summary>
        /// <param name="commandRunTextBox">the text box that receives user input</param>
        /// <returns>string array of the user command split</returns>
        public String[] getCommand(TextBox commandRunTextBox)
        {
            String userEnteredText = GetTextFromTextBox(commandRunTextBox);
            string wordCommand;
            string numbersCommand = (" ");


            wordCommand = GetTextFromTextBox(commandRunTextBox);
            numbersCommand = wordCommand;


            string[] split = numbersCommand.Split(' ');
            foreach (string item in split)
            {
                item.ToString();
            }
            return split;
        }
    }
}
