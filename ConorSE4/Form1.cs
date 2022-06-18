using ConorSE4.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = ConorSE4.Shapes.Rectangle;

namespace ConorSE4
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        String var;
        bool mouseDown = false;
        Bitmap myBitmap;
        //    ParseCommand parseCommand = new ParseCommand();
        private bool button1WasClicked = false;
        /// <summary>
        /// Form1 constructor that creates a new bitmap and initializes component
        /// </summary>
        public Form1()
        {

            myBitmap = new Bitmap(640, 480);
            InitializeComponent();


        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //flag mouse button down
        }
        private void displayOfAction_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //get graphics context of form (which is being displayed)
            g.DrawImageUnscaled(myBitmap, 0, 0);
        }

        /// <summary>
        /// method when mouse is moved creates a pen object and draws line depending where the mouse is moved to
        /// </summary>

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (mouseDown == false)
        //        return; //mouse not down so nothing to do
        //    Graphics g = Graphics.FromImage(myBitmap); //get graphics contex of off screen bitmap
        //    Pen p = new Pen(Color.Red, 2);
        //    g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1); //draw a point on off screen bitmap
        //    p.Dispose();
        //    Refresh(); //signify that something has been draw and windowing system should update the display
        //}

        private void displayOfAction_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == false)
                return;
            Graphics g = Graphics.FromImage(myBitmap);
            Color color = setColour();
            Pen p = new Pen(color, 2);
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);

            p.Dispose();
            Refresh();
        }

        /// <summary>
        /// method that sets the colour using user input
        /// </summary>
        public Color setColour()
        {

            ParseCommand parseCommand = new ParseCommand();
            if (parseCommand.getCommand(commandRunTextBox).Contains("red"))
            {
                return Color.Red;
            }
            if (parseCommand.getCommand(commandRunTextBox).Contains("green"))
            {
                return Color.Green;
            }
            if (parseCommand.getCommand(commandRunTextBox).Contains("blue"))
            {
                return Color.Blue;
            }
            return Color.Red;
        }
    
        

      
        private void displayOfAction_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //flag mouse button up
        }
        private void displayOfAction_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //flag mouse button down
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //flag mouse button up
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayOfAction_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    
        ///// <summary>
        ///// Gets the user input entered into the textbox
        ///// </summary>
        ///// <returns>returns the var value of the user input</returns>
        //public String GetTextFromTextBox()
        //{

        //    var = commandRunTextBox.Text;
        //    //   MessageBox.Show(var);

        //    return var;

        //}

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Run button click method that adds to the user command binding source that can then display the command history
        /// </summary>

        private void runButton_Click(object sender, EventArgs e)
        {
            ParseCommand parseCommand = new ParseCommand();
           
            parseCommand.GetTextFromTextBox(commandRunTextBox);
            //   button1WasClicked = true;
            //userCommandBindingSource.EndEdit();
            //UserCommand userCommand = userCommandBindingSource.Current as UserCommand;
            //userCommandBindingSource.AddNew();

            //if (userCommand != null)

            //{
            //    if (userCommand.isValid)
            //    {

            //    }


                //ValidationContext context = new ValidationContext(userCommand, null, null);
                //IList<ValidationResult> errors = new List<ValidationResult>();
                //if (!Validator.TryValidateObject(userCommand, context, errors, true))
                //{
                //    foreach (ValidationResult result in errors)
                //    {
                //        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
            
            if (parseCommand.GetTextFromTextBox(commandRunTextBox).Contains("circle"))
            {
                parseCommand.circle(commandRunTextBox,myBitmap);

            }
            if (parseCommand.GetTextFromTextBox(commandRunTextBox).Contains("drawTo")) {

                parseCommand.draw(commandRunTextBox, myBitmap);

            }
            if(parseCommand.GetTextFromTextBox(commandRunTextBox).Contains("rect"))
            {
                parseCommand.rectangle(commandRunTextBox, myBitmap);
            }
            if (parseCommand.GetTextFromTextBox(commandRunTextBox).Contains("square"))
            {
                parseCommand.square(commandRunTextBox, myBitmap);
            }


        }

    

        public void sendCommand()
        {
            if (button1WasClicked)
            {

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics; //get graphics context of form (which is being displayed)
            //g.DrawImageUnscaled(myBitmap, 0, 0); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void syntaxButton_Click(object sender, EventArgs e)
        {
            ParseCommand parseCommand = new ParseCommand();
            parseCommand.validateSyntax(commandRunTextBox);
        }
     
    
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayOfAC_Click_1(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Paints the picture box and adds a rectangle on the screen ready to be moved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
       
            Graphics g = e.Graphics;
        
            g.DrawImageUnscaled(myBitmap, 0, 0);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearImage();
        }
        /// <summary>
        /// clears the image on picturebox
        /// </summary>
        public void ClearImage()
        {
            Graphics g = Graphics.FromImage(myBitmap);
            g.Clear(Color.Transparent);
        }


        /// <summary>
        /// Open file button that opens a file dialog allowing a user to open a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;
                string textFromFile = File.ReadAllText(fileName);
                label2.Text = textFromFile;
            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
          
        }
       
        /// <summary>
        /// Empties the script box ready to create a new to be saved or imported
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            MessageBox.Show("Script Box Cleared");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;

            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
        }
    }
}
