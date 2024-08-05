using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace englist_learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        Random rd = new Random();

        private string[,] wordList;
        private string word1, word2;
        private int lastSelectGroup = -1;

        private bool clickEnter = true, tr_enChecked = false, rastgeleChecked = false;

        private int[] showedWrod;
        private int showedWrodCount = 0;
        private int wrongAnswer = 0;
        private int lastWrongAnswer = 0;

        private void listbox_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_group.SelectedIndex != null && listbox_group.SelectedIndex != lastSelectGroup)
            {
                wordList = words.getListWordArrays()[listbox_group.SelectedIndex];
                ResetShowedWrod();
                randomWord();

                lastSelectGroup = listbox_group.SelectedIndex;
                textbox_answer.Focus();
            }
        }
        
        private void textbox_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && clickEnter)
            {
                e.SuppressKeyPress = true;
                clickEnter = false;

                if (word2.ToLower().Equals(textbox_answer.Text.ToLower()))
                {
                    randomWord();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (label_showedanswer.Text != word2)
                {
                    wrongAnswer++;
                    labelWrong.Text = "AÇILAN CEVAP: " + wrongAnswer.ToString();
                }

                label_showedanswer.Text = word2;
                textbox_answer.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (listbox_group.SelectedIndex != null && listbox_group.SelectedIndex == lastSelectGroup)
                {
                    wordList = words.getListWordArrays()[listbox_group.SelectedIndex];
                    ResetShowedWrod();
                    randomWord();

                    lastSelectGroup = listbox_group.SelectedIndex;
                    textbox_answer.Focus();
                }
            }
        }

        private void textbox_answer_KeyUp(object sender, KeyEventArgs e)
        {
            clickEnter = true;
        }

        private void ResetShowedWrod()
        {
            if (wordList != null)
            {
                showedWrod = new int[wordList.GetLength(0)];
            }

            for (int i = 0; i < showedWrod.Length; i++)
            {
                showedWrod[i] = -1;
            }

            lastWrongAnswer = wrongAnswer;
            labellastwronganswer.Text = "SON İŞLEM AÇILAN CEVAP: " + lastWrongAnswer.ToString();

            wrongAnswer = 0;
            labelWrong.Text = "AÇILAN CEVAP: " + wrongAnswer.ToString();

            showedWrodCount = 0;
            label_count.Text = showedWrodCount.ToString() + " / " + wordList.GetLength(0);
        }

        private void checkbox_tr_en_CheckedChanged(object sender, EventArgs e)
        {
            textbox_answer.Focus();
        }

        private void checkbox_random_CheckedChanged(object sender, EventArgs e)
        {
            textbox_answer.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetShowedWrod();
            randomWord();

            lastSelectGroup = listbox_group.SelectedIndex;
            textbox_answer.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listbox_group.DataSource = words.getWordArraysName();

            textbox_answer.Focus();
        }

        private void button_showanswer_Click(object sender, EventArgs e)
        {
            label_showedanswer.Text = word2;
            textbox_answer.Focus();
        }

        private void randomWord()
        {
            try
            {
                if (showedWrod == null)
                {
                    ResetShowedWrod();
                }

                if (showedWrodCount == showedWrod.Length || tr_enChecked != checkbox_tr_en.Checked || rastgeleChecked != checkbox_random.Checked)
                {
                    ResetShowedWrod();
                }

                int rdNumber = showedWrodCount;
                if (checkbox_random.Checked)
                {
                    rdNumber = rd.Next(0, wordList.GetLength(0));
                }

                if (Array.IndexOf(showedWrod, rdNumber) == -1)
                {
                    if (!checkbox_tr_en.Checked)
                    {
                        word1 = wordList[rdNumber, 0].ToLower();
                        word2 = wordList[rdNumber, 1].ToLower();
                    }
                    else
                    {
                        word1 = wordList[rdNumber, 1].ToLower();
                        word2 = wordList[rdNumber, 0].ToLower();
                    }

                    label_word.Text = word1;
                    textbox_answer.Text = "";
                    label_showedanswer.Text = "Asnwer";

                    showedWrod[showedWrodCount] = rdNumber;
                    showedWrodCount++;

                    label_count.Text = showedWrodCount.ToString() + " / " + wordList.GetLength(0);
                    tr_enChecked = checkbox_tr_en.Checked;
                    rastgeleChecked = checkbox_random.Checked;
                }
                else
                {
                    randomWord();
                }
            }
            catch (System.StackOverflowException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
