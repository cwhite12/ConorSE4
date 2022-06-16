using System.Windows.Forms;

namespace ConorSE4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commandRunTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource userCommandBindingSource;
        private ErrorProvider errorProvider;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn commandSentDataGridViewTextBoxColumn;
        private PictureBox displayOfAction;
        private Button button3;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.commandRunTextBox = new System.Windows.Forms.TextBox();
            this.userCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayOfAction = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCommandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayOfAction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "C WHITE SYNTAX GUI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // commandRunTextBox
            // 
            this.commandRunTextBox.AcceptsReturn = true;
            this.commandRunTextBox.AcceptsTab = true;
            this.commandRunTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userCommandBindingSource, "commandSent", true));
            this.commandRunTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commandRunTextBox.Location = new System.Drawing.Point(12, 574);
            this.commandRunTextBox.Name = "commandRunTextBox";
            this.commandRunTextBox.Size = new System.Drawing.Size(577, 20);
            this.commandRunTextBox.TabIndex = 4;
            this.commandRunTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(595, 574);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Syntax";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.syntaxButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 342);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.userCommandBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.userCommandBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(378, 615);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 164);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // displayOfAction
            // 
            this.displayOfAction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayOfAction.Location = new System.Drawing.Point(541, 118);
            this.displayOfAction.Name = "displayOfAction";
            this.displayOfAction.Size = new System.Drawing.Size(506, 397);
            this.displayOfAction.TabIndex = 12;
            this.displayOfAction.TabStop = false;
            this.displayOfAction.Click += new System.EventHandler(this.displayOfAction_Click_1);
            this.displayOfAction.Paint += new System.Windows.Forms.PaintEventHandler(this.displayOfAction_Paint);
            this.displayOfAction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.displayOfAction_MouseDown);
            this.displayOfAction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displayOfAction_MouseMove);
            this.displayOfAction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.displayOfAction_MouseUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(858, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(69, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 14;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(-1, 0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 15;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 791);
            this.Controls.Add(this.New);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.displayOfAction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.commandRunTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.userCommandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayOfAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button openFileButton;
        private OpenFileDialog openFD;
        private Button New;
    }
}

