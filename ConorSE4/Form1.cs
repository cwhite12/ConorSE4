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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConorSE4
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        String var;
        bool mouseDown = false;
        Bitmap myBitmap;

        private bool button1WasClicked = false;
        public Form1()
        {
            myBitmap = new Bitmap(640, 480);
            InitializeComponent();


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
        public void checkSyntax()
        {
            var = commandRunTextBox.Text;


        }

        public String GetTextFromTextBox()
        {

            var = commandRunTextBox.Text;
            //   MessageBox.Show(var);

            return var;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            GetTextFromTextBox();
            //   button1WasClicked = true;
            userCommandBindingSource.EndEdit();
            UserCommand userCommand = userCommandBindingSource.Current as UserCommand;
            userCommandBindingSource.AddNew();

            if (userCommand != null)

            {
                if (userCommand.isValid)
                {

                }


                //ValidationContext context = new ValidationContext(userCommand, null, null);
                //IList<ValidationResult> errors = new List<ValidationResult>();
                //if (!Validator.TryValidateObject(userCommand, context, errors, true))
                //{
                //    foreach (ValidationResult result in errors)
                //    {
                //        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
            }
            if (GetTextFromTextBox().Contains("circle"))
            {


                new Circle(Color.Black, 123, 123, 123);

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


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void syntaxButton_Click(object sender, EventArgs e)
        {
            validateSyntax();
        }
        public bool validateSyntax()
        {
            String[] allowedValues = { "drawTo", "rect", "circle" };

            String textFromTextBox = commandRunTextBox.Text;
            bool doesItContainValidSyntax = ContainsAny(textFromTextBox, allowedValues);
            if (doesItContainValidSyntax)
            {
                errorProvider.SetError(commandRunTextBox, "");
            }
            else
                errorProvider.SetError(commandRunTextBox, "please enter valid syntax");
            // throw new Exceptions.SyntaxNotValidException("Syntax is not valid");

            return doesItContainValidSyntax;

        }
        public static bool ContainsAny(string textBoxText, params string[] allowedValues)
        {
            foreach (string allowed in allowedValues)
            {
                if (textBoxText.Contains(allowed))
                    return true;
            }

            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayOfAC_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //get graphics context of form (which is being displayed)
            g.DrawImageUnscaled(myBitmap, 0, 0);
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Red);

            g.DrawRectangle(myPen, 100, 100, 25, 25);
            String textBoxText = commandRunTextBox.Text;
            if (textBoxText.Equals("clear"))
            {
                displayOfAction.Image.Dispose();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayOfAction.Image = null;
        }

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

        private void New_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            MessageBox.Show("Script Box Cleared");
        }
    }
}
