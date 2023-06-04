namespace Create_a_Person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameOverBox.Visible = false;
            restartButton.Visible = false;
            restartDisplay.Visible = false;
            whatDisplay.Visible = false;
            crossButton.Visible = false;
            nextButton.Enabled = false;
            attemptBox.Text = "attempt left: 9";
            whenTimeTicks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Random number = new Random();
        private int rndnum;
        private List<int> num = new List<int>();

        private bool rndNumGenerate = true;

        public void whenTimeTicks()
        {
            if (rndNumGenerate)
            {
                do
                {
                    rndnum = number.Next(0, 28);

                } while (num.Contains(rndnum));
            }

            num.Add(rndnum);

            switch (rndnum)
            {
                case 0:
                    timer.Stop();
                    questionBox.Text = "What is round and bright and important to earth?(3 letters)";
                    break;

                case 1:
                    timer.Stop();
                    questionBox.Text = "What is white and yellow and an important source of protein?(6 letters)";
                    break;

                case 2:
                    timer.Stop();
                    questionBox.Text = "What is 5×5+6÷2-28+1?";
                    break;

                case 3:
                    timer.Stop();
                    questionBox.Text = "What is the national animal of Nepal?(3 letters)";
                    break;

                case 4:
                    timer.Stop();
                    questionBox.Text = "Who won the football world cup 2022?(9 letters)";
                    break;

                case 5:
                    timer.Stop();
                    questionBox.Text = "Which country founded samsung?(2 words 5 letters each)";
                    break;

                case 6:
                    timer.Stop();
                    questionBox.Text = "Who is the founder of Tesla?(2 words and 4 letters each)";
                    break;

                case 7:
                    timer.Stop();
                    questionBox.Text = "I am a rich source of protein, yellow from inside and white from outside.Who am I?(3 letters)";
                    break;

                case 8:
                    timer.Stop();
                    questionBox.Text = "I fly high in the sky and compete with the birds. Who am I?(9 letters)";
                    break;

                case 9:
                    timer.Stop();
                    questionBox.Text = "I am a friend of moon but I am more in number. Who am I?(4 letters)";
                    break;

                case 10:
                    timer.Stop();
                    questionBox.Text = "I am considered as the enemy of the dog. Who am I? (3 letters)";
                    break;

                case 11:
                    timer.Stop();
                    questionBox.Text = "I am a loyal pet and often referred to as man's best friend. Who am I? (3 letters)";
                    break;

                case 12:
                    timer.Stop();
                    questionBox.Text = "I am a container used for holding beverages. What am I? (3 letters)";
                    break;

                case 13:
                    timer.Stop();
                    questionBox.Text = " I contain stories, information, or ideas and are often read for entertainment or learning. What am I? (4 letters)";
                    break;

                case 14:
                    timer.Stop();
                    questionBox.Text = " I am a piece of furniture designed for sitting on. What am I? (5 letters)";
                    break;

                case 15:
                    timer.Stop();
                    questionBox.Text = "I am a tall plant with a trunk and branches, usually found in nature. What am I? (4 letters)";
                    break;

                case 16:
                    timer.Stop();
                    questionBox.Text = "I am a round object used in various sports and games. What am I? (4 letters)";
                    break;

                case 17:
                    timer.Stop();
                    questionBox.Text = " I am worn on the feet for protection and comfort. What am I? (4 letters)";
                    break;

                case 18:
                    timer.Stop();
                    questionBox.Text = "What is 8 + 3 × 2 - 5 ÷ 1?";
                    break;

                case 19:
                    timer.Stop();
                    questionBox.Text = "What is 12 - 4 × 3 + 6 ÷ 2?";
                    break;
                case 20:
                    timer.Stop();
                    questionBox.Text = "What is 9 + 6 ÷ 3 - 2 × 4?";
                    break;
                case 21:
                    timer.Stop();
                    questionBox.Text = "What is 16 - 2 × 5 + 3 ÷ 3?";
                    break;
                case 22:
                    timer.Stop();
                    questionBox.Text = "What is 4 + 2 × 3 - 6 ÷ 2?";
                    break;
                case 23:
                    timer.Stop();
                    questionBox.Text = "What is 10 - 5 ÷ 2 × 4?";
                    break;
                case 24:
                    timer.Stop();
                    questionBox.Text = "What is 20 + 12 ÷ 4 - 5 × 2?";
                    break;
                case 25:
                    timer.Stop();
                    questionBox.Text = "What is 14 - 3 ÷ 3 × 5?";
                    break;
                case 26:
                    timer.Stop();
                    questionBox.Text = "What is 18 + 4 × 2 - 7 ÷ 1?";
                    break;
                case 27:
                    timer.Stop();
                    questionBox.Text = "What is 6 - 8 ÷ 2 × 3?";
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            whenTimeTicks();
        }

        int score = 0;
        private void correctAnswer()
        {
            score++;
            decisionBox.Text = "Correct. Click on 'Next'";
            answerBox.Enabled = false;

            if (score == 1)
            {
                person.Image = Properties.Resources.image_1;
                messengerLabel.Text = "Yay! The face is here";
            }

            if (score == 2)
            {
                person.Image = Properties.Resources.image_2;
                messengerLabel.Text = "Yay! The body is here";
            }

            if (score == 3)
            {
                person.Image = Properties.Resources.image_3;
                messengerLabel.Text = "Yay! The arms are here";
            }

            if (score == 4)
            {
                person.Image = Properties.Resources.image_4;
                messengerLabel.Text = "Yay! The legs are here";
            }

            if (score == 5)
            {
                person.Image = Properties.Resources.image_5;
                messengerLabel.Text = "Yay! The eyes are here";
            }

            if (score == 6)
            {
                timer.Stop();
                person.Image = Properties.Resources.image_6;

                gameOverBox.Visible = true;
                gameOverBox.Text = "Good Job! You have created the person";
                restartDisplay.Visible = true;
                restartButton.Visible = true;
                checkButton.Enabled = false;
                nextButton.Enabled = false;
                answerBox.Enabled = false;
                decisionBox.Text = "";
            }

        }

        private void incorrectAnswer()
        {
            decisionBox.Text = "Incorrect! Click on 'Next'";
            answerBox.Enabled = false;
        }

        public void decider()
        {

            if (questionBox.Text == "What is round and bright and important to earth?(3 letters)")
            {
                if (answerBox.Text == "SUN" || answerBox.Text == "sun" || answerBox.Text == "Sun")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "What is white and yellow and an important source of protein?(6 letters)")
            {
                if (answerBox.Text == "Banana" || answerBox.Text == "banana" || answerBox.Text == "BANANA")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "What is 5×5+6÷2-28+1?")
            {
                if (answerBox.Text == "1" || answerBox.Text == "+1")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "What is the national animal of Nepal?(3 letters)")
            {
                if (answerBox.Text == "Cow" || answerBox.Text == "cow" || answerBox.Text == "COW")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "Who won the football world cup 2022?(9 letters)")
            {
                if (answerBox.Text == "Argentina" || answerBox.Text == "ARGENTINA" || answerBox.Text == "argentina") // Problem
                {
                    correctAnswer();
                }

                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "Which country founded samsung?(2 words 5 letters each)")
            {
                if (answerBox.Text == "South Korea" || answerBox.Text == "SOUTH KOREA" || answerBox.Text == "south korea") // Problem
                {
                    correctAnswer();
                }

                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "Who is the founder of Tesla?(2 words and 4 letters each)")
            {
                if (answerBox.Text == "Elon Musk" || answerBox.Text == "ELON MUSK" || answerBox.Text == "elon musk") // Problem
                {
                    correctAnswer();
                }

                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a rich source of protein, yellow from inside and white from outside.Who am I?(3 letters)")
            {
                if (answerBox.Text == "Egg" || answerBox.Text == "egg" || answerBox.Text == "EGG")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I fly high in the sky and compete with the birds. Who am I?(9 letters)")
            {
                if (answerBox.Text == "aeroplane" || answerBox.Text == "Aeroplane" || answerBox.Text == "AEROPLANE")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a friend of moon but I am more in number. Who am I?(4 letters)")
            {
                if (answerBox.Text == "Star" || answerBox.Text == "STAR" || answerBox.Text == "star")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am considered as the enemy of the dog. Who am I? (3 letters)")
            {
                if (answerBox.Text == "CAT" || answerBox.Text == "cat" || answerBox.Text == "Cat")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a loyal pet and often referred to as man's best friend. Who am I? (3 letters)")
            {
                if (answerBox.Text == "DOG" || answerBox.Text == "dog" || answerBox.Text == "Dog")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a container used for holding beverages. What am I? (3 letters)")
            {
                if (answerBox.Text == "CUP" || answerBox.Text == "cup" || answerBox.Text == "Cup")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }

            }

            if (questionBox.Text == " I contain stories, information, or ideas and are often read for entertainment or learning. What am I? (4 letters)")
            {
                if (answerBox.Text == "BOOK" || answerBox.Text == "book" || answerBox.Text == "Book")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == " I am a piece of furniture designed for sitting on. What am I? (5 letters)")
            {
                if (answerBox.Text == "CHAIR" || answerBox.Text == "chair" || answerBox.Text == "Chair")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a tall plant with a trunk and branches, usually found in nature. What am I? (4 letters)")
            {
                if (answerBox.Text == "TREE" || answerBox.Text == "tree" || answerBox.Text == "Tree")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "I am a round object used in various sports and games. What am I? (4 letters)")
            {
                if (answerBox.Text == "BALL" || answerBox.Text == "ball" || answerBox.Text == "Ball")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == " I am worn on the feet for protection and comfort. What am I? (4 letters)")
            {
                if (answerBox.Text == "SHOE" || answerBox.Text == "shoe" || answerBox.Text == "Shoe")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "What is 8 + 3 × 2 - 5 ÷ 1?")
            {
                if (answerBox.Text == "9" || answerBox.Text == "+9" || answerBox.Text == "NINE" || answerBox.Text == "nine" || answerBox.Text == "Nine")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            if (questionBox.Text == "What is 12 - 4 × 3 + 6 ÷ 2?")
            {
                if (answerBox.Text == "3" || answerBox.Text == "+3" || answerBox.Text == "THREE" || answerBox.Text == "three" || answerBox.Text == "Three")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 9 + 6 ÷ 3 - 2 × 4?")
            {
                if (answerBox.Text == "3" || answerBox.Text == "+3" || answerBox.Text == "THREE" || answerBox.Text == "three" || answerBox.Text == "Three")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }
            else if (questionBox.Text == "What is 16 - 2 × 5 + 3 ÷ 3?")
            {
                if (answerBox.Text == "7" || answerBox.Text == "+7" || answerBox.Text == "SEVEN" || answerBox.Text == "seven" || answerBox.Text == "Seven")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 4 + 2 × 3 - 6 ÷ 2?")
            {
                if (answerBox.Text == "7" || answerBox.Text == "+7" || answerBox.Text == "SEVEN" || answerBox.Text == "seven" || answerBox.Text == "Seven")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 10 - 5 ÷ 2 × 4?")
            {
                if (answerBox.Text == "2" || answerBox.Text == "+2" || answerBox.Text == "TWO" || answerBox.Text == "two" || answerBox.Text == "Two")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 20 + 12 ÷ 4 - 5 × 2?")
            {
                if (answerBox.Text == "13" || answerBox.Text == "+13" || answerBox.Text == "THIRTEEN" || answerBox.Text == "thirteen" || answerBox.Text == "Thirteen")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 14 - 3 ÷ 3 × 5?")
            {
                if (answerBox.Text == "9" || answerBox.Text == "+9" || answerBox.Text == "NINE" || answerBox.Text == "nine" || answerBox.Text == "Nine")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 18 + 4 × 2 - 7 ÷ 1?")
            {
                if (answerBox.Text == "19" || answerBox.Text == "+19" || answerBox.Text == "NINETEEN" || answerBox.Text == "nineteen" || answerBox.Text == "Nineteen")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }

            else if (questionBox.Text == "What is 6 - 8 ÷ 2 × 3?")
            {
                if (answerBox.Text == "-6" || answerBox.Text == "-6" || answerBox.Text == "MINUS SIX" || answerBox.Text == "minus six" || answerBox.Text == "Minus Six")
                {
                    correctAnswer();
                }
                else
                {
                    incorrectAnswer();
                }
            }
        }

        int attempt = 9;
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (attempt == 1)
            {
                gameOverBox.Visible = true;
                nextButton.Enabled = false;
                gameOverBox.Text = "Game Over!!";
                restartButton.Visible = true;
                restartDisplay.Visible = true;
            }
            answerBox.Enabled = false;
            checkButton.Enabled = false;
            nextButton.Enabled = true;

            if (answerBox.Text == "")
            {
                decisionBox.Text = "Please type your answer!";
                checkButton.Enabled = true;
                answerBox.Enabled = true;
                nextButton.Enabled = false;
            }

            else
            {
                decider();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            attempt--;
            attemptBox.Text = "attempt left: " + attempt;
            if (attempt == 0)
            {
                gameOverBox.Visible = true;
                nextButton.Enabled = false;
                gameOverBox.Text = "Game Over!!";
                restartButton.Visible = true;

            }
            answerBox.Enabled = true;
            nextButton.Enabled = false;
            checkButton.Enabled = true;
            decisionBox.Text = "";
            if (answerBox.Text == "")
            {
                decisionBox.Text = "First, type your answer!";
            }
            answerBox.Text = "";
            messengerLabel.Text = "";

            whenTimeTicks();

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            num.Clear();
            checkButton.Enabled = true;
            nextButton.Enabled = true;
            answerBox.Enabled = true;
            person.Image = Properties.Resources.image_0;
            decisionBox.Text = "";
            messengerLabel.Text = "";
            restartButton.Visible = false;
            gameOverBox.Visible = false;
            restartDisplay.Visible = false;
            answerBox.Text = "";

            timer.Start();
        }

        private void whatButton_Click(object sender, EventArgs e)
        {
            whatDisplay.Visible = true;
            crossButton.Visible = true;
            checkButton.Enabled = false;
            nextButton.Enabled = false;
            answerBox.Enabled = false;
            whatDisplay.Text = "1. Answer the questions to create the person.\n" +
                               "2. The person will be created in six attempts.\n " +
                               "3. You will have nine opportunities to create the person completely\n" +
                               "   All the Best...";
            attemptBox.Visible = false;
        }

        private void crossButton_Click(object sender, EventArgs e)
        {
            whatDisplay.Visible = false;
            crossButton.Visible = false;
            checkButton.Enabled = true;
            nextButton.Enabled = true;
            answerBox.Enabled = true;
            attemptBox.Visible = true;
        }
    }
}