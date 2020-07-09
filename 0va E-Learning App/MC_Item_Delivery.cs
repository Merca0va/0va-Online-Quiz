using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_E_Learning_App
{
    public partial class MC_Item_Delivery : Form
    {
        itembanks my_bank = new itembanks();
        item this_item = new item();
        private static Random random = new Random();
        string my_dateTime;
        int current_item_index = 0;
        int max_index = 9;
        int min_index = 0;
        int correct_option;
        int this_score = 0;
       
        public MC_Item_Delivery()
        {
            InitializeComponent();
            Set_navigation_button();
            load_the_bank();
            // set initial value of countSdown clock
            my_dateTime = string.Format("{0:00}:{1:00}", my_bank.duration_in_seconds / 3600, my_bank.duration_in_seconds % 3600 / 60);
            time_remaining.Text = my_dateTime;

            if(my_bank.Randomize)
            {
                Randomize_the_bank();
            }

            Paint_the_screen();
        }

        public void Paint_the_screen()
        {
            Set_navigation_button();
            Set_question_number();

            // Item_number label is the one located just to the left of the stem.
            item_number.Text = (current_item_index + 1).ToString();

            if(my_bank.ib[current_item_index].Is_scored) //item is a MC question
            {
                STEM.Text = my_bank.ib[current_item_index].Stem;

                if(my_bank.ib[current_item_index].Distractor3.Length > 0)
                {
                    // make all the checkboxes visible and set checked/unchecked based on previous answer
                    optionA.Enabled = true;
                    optionA.Visible = true;
                    optionA.Checked = false;
                    optionB.Enabled = true;
                    optionB.Visible = true;
                    optionB.Checked = false;
                    optionC.Enabled = true;
                    optionC.Visible = true;
                    optionC.Checked = false;
                    optionD.Enabled = true;
                    optionD.Visible = true;
                    optionD.Checked = false;

                    // randomize the option choices
                    correct_option = random.Next(3);  // 0 = a, 1 = b, 2 = c, 3 = d.

                    // paint the 4 option MC item
                    switch(correct_option)
                    {
                        case 0:
                            {
                                // paint the item
                                my_bank.ib[current_item_index].correct_option = "A";
                                option_A_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_B_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_C_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_D_text.Text = my_bank.ib[current_item_index].Distractor3;

                                // handle previously checked answers
                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionA.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionB.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    optionC.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    optionD.Checked = true;
                                }
                                break;
                            }
                        case 1:
                            {
                                my_bank.ib[current_item_index].correct_option = "B";
                                option_B_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_A_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_C_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_D_text.Text = my_bank.ib[current_item_index].Distractor3;

                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionB.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionA.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    optionC.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    optionD.Checked = true;
                                }
                                break;
                            }
                        case 2:
                            {
                                my_bank.ib[current_item_index].correct_option = "C";
                                option_C_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_A_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_B_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_D_text.Text = my_bank.ib[current_item_index].Distractor3;

                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionC.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionA.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    optionB.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    optionD.Checked = true;
                                }
                                break;
                            }
                        case 3:
                            {
                                my_bank.ib[current_item_index].correct_option = "D";
                                option_D_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_A_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_B_text.Text = my_bank.ib[current_item_index].Distractor2;
                                option_C_text.Text = my_bank.ib[current_item_index].Distractor3;

                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionD.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionA.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor2)
                                {
                                    optionB.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor3)
                                {
                                    optionC.Checked = true;
                                }
                                break;
                            }
                    }
                }

                else if (my_bank.ib[current_item_index].Distractor1.Length > 0) // In a case of a true or false question.
                {
                    // Make options A and B visibles and enabled, C and D are invisible and disabled.
                    optionA.Visible = true;
                    optionA.Enabled = true;
                    optionA.Checked = false;
                    optionB.Visible = true;
                    optionB.Enabled = true;
                    optionB.Checked = false;
                    optionC.Visible = false;
                    optionC.Enabled = false;
                    optionC.Checked = false;
                    optionD.Visible = false;
                    optionD.Enabled = false;
                    optionD.Checked = false;

                    correct_option = random.Next(1); // 0 = A and 1 = B.

                    switch(correct_option)
                    {
                        case 0:
                            {
                                my_bank.ib[current_item_index].correct_option = "A";
                                option_A_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_B_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_C_text.Text = "";
                                option_D_text.Text = "";

                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionA.Checked = true;
                                }
                                else if(my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionB.Checked = true;
                                }

                                break;
                            }
                        case 1:
                            {
                                my_bank.ib[current_item_index].correct_option = "B";
                                option_B_text.Text = my_bank.ib[current_item_index].correct_answer;
                                option_A_text.Text = my_bank.ib[current_item_index].Distractor1;
                                option_C_text.Text = "";
                                option_D_text.Text = "";

                                if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].correct_answer)
                                {
                                    optionB.Checked = true;
                                }
                                else if (my_bank.ib[current_item_index].chosen_answer == my_bank.ib[current_item_index].Distractor1)
                                {
                                    optionA.Checked = true;
                                }
                                break;
                            }
                    }
                }
            }
            else // item is not scored - just HTML content
            {
                STEM.Text = my_bank.ib[current_item_index].Stem;
                my_bank.ib[current_item_index].correct_option = "N/A";

                optionA.Visible = false;
                optionA.Enabled = false;
                option_A_text.Text = "";
                optionB.Visible = false;
                optionB.Enabled = false;
                option_B_text.Text = "";
                optionC.Visible = false;
                optionC.Enabled = false;
                option_C_text.Text = "";
                optionD.Visible = false;
                optionD.Enabled = false;
                option_D_text.Text = "";
            }
        }

        public void Set_navigation_button()
        {
            if (current_item_index == min_index)
            {
                first_item.Visible = false;
                previous_item.Visible = false;
                next_item.Visible = true;
                last_item.Visible = true;
            }
            else if (current_item_index == max_index)
            {
                first_item.Visible = true;
                previous_item.Visible = true;
                next_item.Visible = false;
                last_item.Visible = false;
            }
            else
            {
                first_item.Visible = true;
                previous_item.Visible = true;
                next_item.Visible = true;
                last_item.Visible = true;
            }
        }

        public void Randomize_the_bank()
        {
            // Quick randomization process.
            for (int i = my_bank.ib.Length - 1; i >= 0; i--)
            {
                this_item = my_bank.ib[i];
                int randomIndex = random.Next(i + 1);

                //Swap the elements
                my_bank.ib[i] = new item();
                my_bank.ib[i] = my_bank.ib[randomIndex];
                my_bank.ib[randomIndex] = this_item;
            }
        }

        public void load_the_bank()
        {
            my_bank.ID = 1;
            my_bank.duration_in_seconds = 3000;
            my_bank.passing_score = 9;
            my_bank.Randomize = true;
            my_bank.report_results = false;

            my_bank.ib[0] = new item();
            my_bank.ib[0].ID = 1;
            my_bank.ib[0].Stem = "What was the first commercially available programming language?";
            my_bank.ib[0].correct_answer = "FORTRAN.";
            my_bank.ib[0].Distractor1 = "C.";
            my_bank.ib[0].Distractor2 = "Autocode.";
            my_bank.ib[0].Distractor3 = "Plankalkül.";
            my_bank.ib[0].Is_scored = true;

            my_bank.ib[1] = new item();
            my_bank.ib[1].ID = 2;
            my_bank.ib[1].Stem = "What are the 3 primary colors?";
            my_bank.ib[1].correct_answer = "Red, Blue and Yellow.";
            my_bank.ib[1].Distractor1 = "Green, Orange and Purple.";
            my_bank.ib[1].Distractor2 = "Black, White and Grey.";
            my_bank.ib[1].Distractor3 = "Red, Green, White.";
            my_bank.ib[1].Is_scored = true;

            my_bank.ib[2] = new item();
            my_bank.ib[2].ID = 2;
            my_bank.ib[2].Stem = "Which of those animals are cannibals? ";
            my_bank.ib[2].correct_answer = "Sand Tiger Sharks.";
            my_bank.ib[2].Distractor1 = "Congo Lions.";
            my_bank.ib[2].Distractor2 = "Saltwater Crocodiles.";
            my_bank.ib[2].Distractor3 = "Grizzly Bears.";
            my_bank.ib[2].Is_scored = true;

            my_bank.ib[3] = new item();
            my_bank.ib[3].ID = 3;
            my_bank.ib[3].Stem = "Can you identify which one of these numbers represents the pi number?";
            my_bank.ib[3].correct_answer = "3.1415 .";
            my_bank.ib[3].Distractor1 = "1.4135 .";
            my_bank.ib[3].Distractor2 = "1.4241 .";
            my_bank.ib[3].Distractor3 = "3.1541 .";
            my_bank.ib[3].Is_scored = true;

            my_bank.ib[4] = new item();
            my_bank.ib[4].ID = 4;
            my_bank.ib[4].Stem = "What is the best selling novel of all time?";
            my_bank.ib[4].correct_answer = "Don Quixote by Miguel de Cervantes Saavedra.";
            my_bank.ib[4].Distractor1 = "The Little Prince by Antoine de Saint-Exupéry.";
            my_bank.ib[4].Distractor2 = "Harry Potter And The Philosopher's Stone by J.K. Rowling.";
            my_bank.ib[4].Distractor3 = "The Hobbit by J.R. Tolkien.";
            my_bank.ib[4].Is_scored = true;

            my_bank.ib[5] = new item();
            my_bank.ib[5].ID = 5;
            my_bank.ib[5].Stem = "What is the definition of Photosynthesis?";
            my_bank.ib[5].correct_answer = "Endothermic chemical process that uses sunlight to turn carbon dioxide into sugars that the plant's cells can use as energy.";
            my_bank.ib[5].Distractor1 = "Exothermic physical phenomenon that uses the plant's cells to reflect sunlinght.";
            my_bank.ib[5].Distractor2 = "Chemical reaction where the plant use sunlight to create and release its spores to reproduce.";
            my_bank.ib[5].Distractor3 = "Exothermic reaction that uses carbon dioxide to reinforce the plant's cells and protect it against sunlight.";
            my_bank.ib[5].Is_scored = true;

            my_bank.ib[6] = new item();
            my_bank.ib[6].ID = 6;
            my_bank.ib[6].Stem = "Which one of the followings is not an island?";
            my_bank.ib[6].correct_answer = "French Guiana.";
            my_bank.ib[6].Distractor1 = "Disappointment Island.";
            my_bank.ib[6].Distractor2 = "Barbados.";
            my_bank.ib[6].Distractor3 = "Coronation Island.";
            my_bank.ib[6].Is_scored = true;

            my_bank.ib[7] = new item();
            my_bank.ib[7].ID = 7;
            my_bank.ib[7].Stem = "Which year did the Soviet Union ended?";
            my_bank.ib[7].correct_answer = "1991.";
            my_bank.ib[7].Distractor1 = "1968.";
            my_bank.ib[7].Distractor2 = "1984.";
            my_bank.ib[7].Distractor3 = "1953.";
            my_bank.ib[7].Is_scored = true;

            my_bank.ib[8] = new item();
            my_bank.ib[8].ID = 8;
            my_bank.ib[8].Stem = "Which programming language was developed by Microsoft in 2000?";
            my_bank.ib[8].correct_answer = "C#.";
            my_bank.ib[8].Distractor1 = "Java.";
            my_bank.ib[8].Distractor2 = "Python.";
            my_bank.ib[8].Distractor3 = "PHP.";
            my_bank.ib[8].Is_scored = true;

            my_bank.ib[9] = new item();
            my_bank.ib[9].ID = 9;
            my_bank.ib[9].Stem = "What represents 58 in binary numbers?";
            my_bank.ib[9].correct_answer = "111010.";
            my_bank.ib[9].Distractor1 = "101110.";
            my_bank.ib[9].Distractor2 = "101001.";
            my_bank.ib[9].Distractor3 = "100011.";
            my_bank.ib[9].Is_scored = true;
        }

        private void record_previous_answer()
        {
            if (optionA.Checked)
            {
                my_bank.ib[current_item_index].chosen_answer = option_A_text.Text;
            }
            else if (optionB.Checked)
            {
                my_bank.ib[current_item_index].chosen_answer = option_B_text.Text;
            }
            else if (optionC.Checked)
            {
                my_bank.ib[current_item_index].chosen_answer = option_C_text.Text;
            }
            else if (optionD.Checked)
            {
                my_bank.ib[current_item_index].chosen_answer = option_D_text.Text;
            }
        }

        private void Set_question_number()
        {
            question_number.Text = (current_item_index + 1).ToString() + "/" + (max_index + 1).ToString();
        }

        private void Score_this_test()
        {
            for (int i = 0; i < max_index ; i++)
            {
                if (my_bank.ib[i].correct_answer == my_bank.ib[i].chosen_answer)
                {
                    this_score = this_score + 1;
                }
            }

            if (this_score >= my_bank.passing_score)
            {
                MessageBox.Show("Congratulations! You passed the test! " + " Your score is " + this_score + " out of " + max_index);
                MessageBox.Show( "ANSWERS: Question 1 = " + my_bank.ib[0].correct_answer + "    " +
                    "Question 2 = " + my_bank.ib[1].correct_answer + "    " + 
                    "Question 3 = " + my_bank.ib[2].correct_answer + "    " + 
                    "Question 4 = " + my_bank.ib[3].correct_answer + "    " +
                    "Question 5 = " + my_bank.ib[4].correct_answer + "    " +
                    "Question 6 = " + my_bank.ib[5].correct_answer + "    " +
                    "Question 7 = " + my_bank.ib[6].correct_answer + "    " +
                    "Question 8 = " + my_bank.ib[7].correct_answer + "    " +
                    "Question 9 = " + my_bank.ib[8].correct_answer + "    " +
                    "Question 10 = " + my_bank.ib[9].correct_answer );
            }
            else
            {
                MessageBox.Show("Sorry you didn't pass the test. " + " Your score is " + this_score + "out of " + max_index);
            }
        }

        private void next_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();

            if (current_item_index < max_index)
            {
                current_item_index = current_item_index + 1;
            }
            Paint_the_screen();
        }

        private void previous_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            if(current_item_index > min_index)
            {
                current_item_index = current_item_index - 1;
            }
            Paint_the_screen();
        }

        private void first_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = min_index;
            Paint_the_screen();
        }

        private void last_item_Click(object sender, EventArgs e)
        {
            record_previous_answer();
            current_item_index = max_index;
            Paint_the_screen();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            my_bank.duration_in_seconds = my_bank.duration_in_seconds - 1;

            if (my_bank.duration_in_seconds == 0)
            {
                Score_this_test();

                //Shut all down.
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
            }

            if (my_bank.duration_in_seconds <= 300)
            {
                time_remaining.BackColor = Color.Red; // with less than 5 minutes turn this background red
            }

            my_dateTime = string.Format("{0:00} : {1:00}", my_bank.duration_in_seconds / 3600, my_bank.duration_in_seconds % 3600 / 60);
            time_remaining.Text = my_dateTime;
        }

       

        private void submit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain you want to submit your answers? You still got time remaining",
               "Submit your Answers?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Score_this_test();

                //Shut all down.
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
            }
        }

    }
}
