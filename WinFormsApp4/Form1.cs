using WinFormsApp4.Properties;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (btnBakuClicked)
            {
                lbl_Clock.Text = DateTime.Now.ToString();
                btnBakuClicked = false;
            }
            else if (btnLondonClicked)
            {
                lbl_Clock.Text = DateTime.Now.AddHours(-3).ToString();
                btnLondonClicked = false;
            }
        }

        bool btnBakuClicked = false;
        bool btnLondonClicked = false;
        private void AddTime()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;

            timer.Start();
        }
        private void btn_Baku_Click(object sender, EventArgs e)
        {
            btn_Baku.Text = "";
            btnBakuClicked = true;

            Button button = sender as Button;
            button.BackgroundImage = Resources.bakuu;

            AddTime();

        }
        private void btn_London_Click(object sender, EventArgs e)
        {
            btn_London.Text = "";

            btnLondonClicked = true;

            Button button = sender as Button;
            button.BackgroundImage = Resources.london;

            AddTime();


        }

        private void btn_Running_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Dispose();

                int btnWidth = 296;
                int btnHeight = 76;

                int x = Random.Shared.Next(0, Width - btnWidth);
                int y = Random.Shared.Next(0, Height - btnHeight);

                Button button = new Button
                {
                    AutoSize = true,
                    Text = "Running Button",
                    Size = new Size(btnWidth, btnHeight),
                    Name = "btn_Running",
                    Location = new Point(x, y),
                    Font = new Font("Vineta BT", 20.25F),
                };

                button.MouseEnter += btn_Running_MouseEnter;
                Controls.Add(button);

            }
        }

        System.Drawing.Graphics formGraphics;
        bool isDown = false;
        int initialX;
        int initialY;


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {
                this.Refresh();
                Pen drawPen = new Pen(Color.Red, 1);
                int width = e.X - initialX, height = e.Y - initialY;

                formGraphics = this.CreateGraphics();

                formGraphics.DrawRectangle(drawPen, initialX, initialY, width, height);

            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            isDown = false;

        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            isDown = true;
            initialX = e.X;
            initialY = e.Y;
        }
    }
}