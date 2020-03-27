using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphics;

namespace MovingObject
{
    public partial class MainForm : Form
    {
        private System.Drawing.Graphics graphics;

        private int x;
        private int y;
        private int width;
        private int height;
        private int speedX;
        private int speedY;
        private string shape;

        private Color BackgroundColor;
        private Color InnerColor;
        private Color OutlineColor;
        public MainForm()
        {
            InitializeComponent();
            graphics = Canvas.CreateGraphics();
            x = 50;
            y = 50;
            width = 50;
            height = 50;
            InnerColor = Color.Black;
            OutlineColor = Color.Black;
            BackgroundColor = Color.White;
            ShapesList.SelectedItem = "Circle";
            SpeedList.SelectedItem = "Normal";
            CurrentActionLabel.Text = "Succesfully loaded!";
            Canvas.ContextMenuStrip = Shortcuts;
        }

        //Events
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawObject();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            MoveObject();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Start(); 
            CurrentActionLabel.Text = $"Bounce, {shape}!";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            CurrentActionLabel.Text = $"Stop bouncing, {shape}!";
        }

        private void InnerColorButton_Click(object sender, EventArgs e)
        {
            GetColor.ShowDialog();
            InnerColor = GetColor.Color;
            CurrentActionLabel.Text = $"Changing the inner color.";
        }

        private void OutlineColorButton_Click(object sender, EventArgs e)
        {
            GetColor.ShowDialog();
            OutlineColor = GetColor.Color;
            CurrentActionLabel.Text = $"Changing the outline color.";
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            GetColor.ShowDialog();
            BackgroundColor = GetColor.Color;
            CurrentActionLabel.Text = $"Changing the background color.";
        }

        private void ShapesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = ShapesList.SelectedItem.ToString();
            CurrentActionLabel.Text = $"Changing the object shape to {this.shape}.";
        }

        private void SpeedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertSpeed(SpeedList.SelectedItem.ToString());
            CurrentActionLabel.Text = $"Changing the speed to {this.SpeedList.SelectedItem}.";
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            CurrentActionLabel.Text = $"Showing the About form.";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartButton_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopButton_Click(sender, e);
        }

        //Private methods used for the events
        private void ConvertSpeed(string speedType)
        {
            switch (speedType)
            {
                case "Slow":
                    speedX = 5;
                    speedY = 5;
                    break;
                case "Normal":
                    speedX = 13;
                    speedY = 13;
                    break;
                case "Fast":
                    speedX = 30;
                    speedY = 30;
                    break;
            }
        }
        private void DrawObject()
        {
            Brush currentBrush = new SolidBrush(InnerColor);
            Pen currentPen = new Pen(OutlineColor);
            graphics.Clear(BackgroundColor);

            if (shape == "Rectangle")
            {
                height = 30;
            }
            else
            {
                height = width;
            }

            switch (shape)
            {
                case "Circle":
                    graphics.DrawEllipse(currentPen, x, y, width, height);
                    graphics.FillEllipse(currentBrush, x, y, width, height);
                    break;
                default:
                    graphics.DrawRectangle(currentPen, x, y, width, height);
                    graphics.FillRectangle(currentBrush, x, y, width, height);
                    break;
            }
        }
        private void MoveObject()
        {
            int nextPositionX = x + speedX;
            int nextPositionY = y + speedY;

            if (nextPositionX < 0 || nextPositionX > this.Canvas.Width - width)
            {
                speedX = -speedX;
            }
            if (nextPositionY < 0 || nextPositionY > this.Canvas.Height - height)
            {
                speedY = -speedY;
            }

            x += speedX;
            y += speedY;
            Refresh();
        }
    }
}
