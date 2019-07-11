using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class frm_MemoryGame : Form
    {
        Player OPlayer = new Player();
        List<Card> BackgroundImageS = null;
        Board[,] Board = null;
        PictureBox firstGuess;
        PictureBox SecondfGuess;
        Random location = new Random();
        int SIZE = 0;
        int second = 0, minute = 0;
        int IsActive = 0;

        public frm_MemoryGame(string name, int size)
        {
            InitializeComponent();
            OPlayer.Name = name;
            SIZE = size;
            BackgroundImageS = new List<Card>();
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card1.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card2.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card3.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card4.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card5.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card6.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card7.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card8.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card9.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card10.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card11.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card12.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card13.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card14.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card15.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card16.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card17.png" });
            BackgroundImageS.Add(new Card() { Path = @"C:\Users\mehdi\Desktop\MemoryGame\MemoryGame\Resources\Card18.png" });
        }

        private void frm_MemoryGame_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            FreezeTime.Start();
            GameTime.Start();
            Start.Start();
            lbl_ScoreCounter.Text = "0";
            lbl_FreezeTime.Text = "5";
            lbl_moves.Text = "0";
            lbl_PlayerName.Text = OPlayer.Name;
            lbl_size.Text = SIZE.ToString();
            Board = new Board[SIZE, SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    PictureBox Pictureboxs = new PictureBox();
                    Pictureboxs.Name = "pic_" + i.ToString() + "-" + j.ToString();
                    Pictureboxs.Location = new Point(i * 105, j * 155);
                    Pictureboxs.Size = new Size(100, 150);
                    Pictureboxs.Parent = this;
                    Pictureboxs.Tag = SetRandomImages();
                    Pictureboxs.BackgroundImage = Image.FromFile(Pictureboxs.Tag.ToString());
                    Pictureboxs.BackgroundImageLayout = ImageLayout.Stretch;
                    Pictureboxs.Enabled = false;
                    Pictureboxs.Click += new EventHandler(btnClick);

                    Board[i, j] = new Board();
                    Board[i, j].PictureBox = Pictureboxs;
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (IsActive > 2)
                return;

            PictureBox Card = (PictureBox)sender;

            Card.Image = Image.FromFile(Card.Tag.ToString());
            if (firstGuess == null)
            {
                firstGuess = Card;
                IsActive++;
                return;
            }
            else if (Card != firstGuess && firstGuess != null && SecondfGuess == null)
            {
                SecondfGuess = Card;
                IsActive++;
            }
            if (firstGuess != null && SecondfGuess != null)
            {
                OPlayer.Moves++;
                lbl_moves.Text = OPlayer.Moves.ToString();
                if (firstGuess.Tag == SecondfGuess.Tag)
                {
                    firstGuess.Enabled = false;
                    SecondfGuess.Enabled = false;
                    firstGuess = null;
                    SecondfGuess = null;
                    lbl_ScoreCounter.Text = Convert.ToString(Convert.ToInt32(lbl_ScoreCounter.Text) + 10);
                    OPlayer.Score = Convert.ToInt32(lbl_ScoreCounter.Text);
                    if (Win())
                    {
                        MessageBox.Show("Congratulations you're a winner 🎉🎉" + "\nyou're Score :" + OPlayer.Score + "\nYou Made " + OPlayer.Moves + " Moves"
                            + "\nIN "+ minute + " mins  " + second+ " secs", "Congratulations🎉" + OPlayer.Name, MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    lbl_ScoreCounter.Text = Convert.ToString(Convert.ToInt32(lbl_ScoreCounter.Text) - 5);
                    OPlayer.Score = Convert.ToInt32(lbl_ScoreCounter.Text);
                    NotMatch.Start();
                }
                IsActive = 0;
            }
        }

        private string SetRandomImages()
        {
            int rand = 0;
            int UsedCount = int.MaxValue;

            while (UsedCount > 1)
            {
                rand = location.Next(0, SIZE * (SIZE / 2));
                UsedCount = BackgroundImageS[rand].UsedCount;
                if (UsedCount < 2)
                {
                    BackgroundImageS[rand].UsedCount += 1;
                    return BackgroundImageS[rand].Path;
                }
            }
            return "";

        }
        private bool Win()
        {
            bool result = false;
            //for (int i = 0; i < SIZE; i++)
            //{
            //    for (int j = 0; j < SIZE; j++)
            //    {
            //        if (Board[i, j].PictureBox.Enabled == false)
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictures = (PictureBox)control;
                    if (pictures.Enabled == false)
                    {
                        result = true;
                    }
                    else return false;
                }
            }
            GameTime.Stop();
            OPlayer.Time = (minute * 60) + second;
            return result;
        }
        private void FreezeTime_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(lbl_FreezeTime.Text);
            timer = timer - 1;
            lbl_FreezeTime.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                FreezeTime.Stop();
                lbl_FreezeTime.Visible = false;
            }

        }
        private void Start_Tick(object sender, EventArgs e)
        {
            Start.Stop();
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictures = (PictureBox)control;
                    pictures.Enabled = true;
                    pictures.Cursor = Cursors.Hand;
                    pictures.Image = MemoryGame.Properties.Resources.CardBackCover;
                    pictures.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
        private void GameTime_Tick(object sender, EventArgs e)
        {
            OPlayer.Time++;
            lbl_s.Text = Convert.ToString(Convert.ToInt32(lbl_s.Text) + 1);
            second++;
            if (second == 60)
            {
                lbl_min.Text = Convert.ToString(Convert.ToInt32(lbl_min.Text) + 1);

                lbl_s.Text = "0";
                minute++;
                second = 0;
            }
        }
        private void NotMatch_Tick(object sender, EventArgs e)
        {
            NotMatch.Stop();
            firstGuess.Image = MemoryGame.Properties.Resources.CardBackCover;
            SecondfGuess.Image = MemoryGame.Properties.Resources.CardBackCover;
            firstGuess.BackgroundImageLayout = SecondfGuess.BackgroundImageLayout = ImageLayout.Stretch;
            firstGuess = null;
            SecondfGuess = null;
        }
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //for (int i = 0; i < SIZE; i++)
            //{
            //    BackgroundImageS[i].UsedCount = 0;
            //}
            //frm_MemoryGame f = new frm_MemoryGame(lbl_PlayerName.Text,Convert.ToInt32(lbl_size.Text));
            //this.Close();
            //f.Show();
        }
    }
}
