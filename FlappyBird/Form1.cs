using static System.Formats.Asn1.AsnWriter;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        bool scored = false;
        int lastScore = 0; // en son hýz artýrdýðýmýz score
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -=  pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "Score: " + score.ToString();
            
            if(pipeBottom.Left < -110)
            {
                pipeBottom.Left = 700;
                score++;
            }

            if (pipeTop.Left < -110)
            {
                pipeTop.Left = 700;
                
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            // sadece yeni 5’in katýna ulaþtýðýmýzda hýz artsýn
            if (score % 5 == 0 && score != 0 && score != lastScore && score<20)
            {
                pipeSpeed += 2;
                lastScore = score;
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = +10;
            }


        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
        }
    }
}
