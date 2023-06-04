namespace Create_a_Person
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            questionBox = new Label();
            answerBox = new TextBox();
            label1 = new Label();
            checkButton = new Button();
            nextButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            decisionBox = new Label();
            person = new PictureBox();
            messengerLabel = new Label();
            gameOverBox = new Label();
            pictureBox1 = new PictureBox();
            restartButton = new Button();
            restartDisplay = new Label();
            whatButton = new Button();
            whatDisplay = new Label();
            crossButton = new Button();
            attemptBox = new Label();
            ((System.ComponentModel.ISupportInitialize)person).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // questionBox
            // 
            questionBox.BackColor = Color.White;
            questionBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            questionBox.Location = new Point(36, 22);
            questionBox.Name = "questionBox";
            questionBox.Size = new Size(1045, 95);
            questionBox.TabIndex = 0;
            questionBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            answerBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            answerBox.Location = new Point(417, 135);
            answerBox.Multiline = true;
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(279, 56);
            answerBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 139);
            label1.Name = "label1";
            label1.Size = new Size(91, 52);
            label1.TabIndex = 2;
            label1.Text = "Ans:";
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.Yellow;
            checkButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkButton.Location = new Point(417, 197);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(138, 55);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Yellow;
            nextButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.Location = new Point(558, 197);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(138, 55);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // decisionBox
            // 
            decisionBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            decisionBox.Location = new Point(702, 135);
            decisionBox.Name = "decisionBox";
            decisionBox.Size = new Size(403, 56);
            decisionBox.TabIndex = 5;
            // 
            // person
            // 
            person.Image = Properties.Resources.image_0;
            person.Location = new Point(558, 258);
            person.Name = "person";
            person.Size = new Size(143, 259);
            person.SizeMode = PictureBoxSizeMode.AutoSize;
            person.TabIndex = 6;
            person.TabStop = false;
            // 
            // messengerLabel
            // 
            messengerLabel.BackColor = Color.Transparent;
            messengerLabel.Font = new Font("Cascadia Mono SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            messengerLabel.Location = new Point(347, 529);
            messengerLabel.Name = "messengerLabel";
            messengerLabel.Size = new Size(444, 95);
            messengerLabel.TabIndex = 7;
            messengerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameOverBox
            // 
            gameOverBox.BackColor = Color.White;
            gameOverBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverBox.Location = new Point(36, 22);
            gameOverBox.Name = "gameOverBox";
            gameOverBox.Size = new Size(1045, 95);
            gameOverBox.TabIndex = 8;
            gameOverBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_6;
            pictureBox1.Location = new Point(409, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Yellow;
            restartButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            restartButton.Location = new Point(710, 552);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(138, 55);
            restartButton.TabIndex = 10;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // restartDisplay
            // 
            restartDisplay.BackColor = Color.Transparent;
            restartDisplay.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            restartDisplay.Location = new Point(417, 528);
            restartDisplay.Name = "restartDisplay";
            restartDisplay.Size = new Size(292, 95);
            restartDisplay.TabIndex = 11;
            restartDisplay.Text = "Click on Restart ->";
            restartDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // whatButton
            // 
            whatButton.BackColor = Color.FromArgb(128, 255, 255);
            whatButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            whatButton.Location = new Point(702, 197);
            whatButton.Name = "whatButton";
            whatButton.Size = new Size(55, 55);
            whatButton.TabIndex = 12;
            whatButton.Text = "?";
            whatButton.UseVisualStyleBackColor = false;
            whatButton.Click += whatButton_Click;
            // 
            // whatDisplay
            // 
            whatDisplay.BackColor = Color.White;
            whatDisplay.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            whatDisplay.Location = new Point(36, 255);
            whatDisplay.Name = "whatDisplay";
            whatDisplay.Size = new Size(1045, 291);
            whatDisplay.TabIndex = 13;
            whatDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // crossButton
            // 
            crossButton.BackColor = Color.Red;
            crossButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            crossButton.Location = new Point(1012, 197);
            crossButton.Name = "crossButton";
            crossButton.Size = new Size(69, 60);
            crossButton.TabIndex = 14;
            crossButton.Text = "×";
            crossButton.UseVisualStyleBackColor = false;
            crossButton.Click += crossButton_Click;
            // 
            // attemptBox
            // 
            attemptBox.BackColor = Color.Transparent;
            attemptBox.Font = new Font("Cascadia Mono SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            attemptBox.Location = new Point(707, 342);
            attemptBox.Name = "attemptBox";
            attemptBox.Size = new Size(374, 58);
            attemptBox.TabIndex = 15;
            attemptBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1117, 632);
            Controls.Add(attemptBox);
            Controls.Add(crossButton);
            Controls.Add(whatDisplay);
            Controls.Add(whatButton);
            Controls.Add(restartDisplay);
            Controls.Add(restartButton);
            Controls.Add(pictureBox1);
            Controls.Add(gameOverBox);
            Controls.Add(messengerLabel);
            Controls.Add(person);
            Controls.Add(decisionBox);
            Controls.Add(nextButton);
            Controls.Add(checkButton);
            Controls.Add(label1);
            Controls.Add(answerBox);
            Controls.Add(questionBox);
            Name = "Form1";
            Text = "Create a Person";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)person).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionBox;
        private TextBox answerBox;
        private Label label1;
        private Button checkButton;
        private Button nextButton;
        private System.Windows.Forms.Timer timer;
        private Label decisionBox;
        private PictureBox person;
        private Label messengerLabel;
        private Label gameOverBox;
        private PictureBox pictureBox1;
        private Button restartButton;
        private Label restartDisplay;
        private Button whatButton;
        private Label whatDisplay;
        private Button crossButton;
        private Label attemptBox;
    }
}