using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4 {
    public partial class Form1 : Form {
        int xMin = 100;
        int xMax = 100;
        int xInterval = 5;
        int yMin = 100;
        int yMax = 100;
        int yInterval = 5;

        public Form1() {
            InitializeComponent();


        }

        private void drawGrid() {
            // Create Graphics object for the pictureBox (where the graph will be drawn).
            Graphics g = pictureBoxGrid.CreateGraphics();

            // Make the pen to draw the x and y-axis.
            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.Width = 3;
            
            // Determine where the middle of each axis of the graphics box is.
            int halfHeight = pictureBoxGrid.Height / 2;
            int halfWidth = pictureBoxGrid.Width / 2;

            // Draw horizontal line.
            g.DrawLine(pen, 0, halfHeight, pictureBoxGrid.Width, halfHeight);

            // Draw vertical line.
            g.DrawLine(pen, halfWidth, 0, halfWidth, pictureBoxGrid.Height);

            // Set pen width for a tick mark.
            pen.Width = 1;


            // Get how many ticks need to be drawn on positive X-axis.
            int amountOfTicksPosX = xMax / xInterval;

            // Get how many ticks need to be drawn on positive X-axis.
            int amountOfTicksNegX = xMin / xInterval;

            // Determine how many pixels between ticks on the positive X-axis.
            int pixelsBetweenTicksPosX = halfWidth / amountOfTicksPosX;

            // Determine how many pixels between ticks on the positive X-axis.
            int pixelsBetweenTicksNegX = halfWidth / amountOfTicksNegX;


            // Get how many ticks need to be drawn on positive Y-axis.
            int amountOfTicksPosY = yMax / yInterval;

            // Get how many ticks need to be drawn on negative Y-axis.
            int amountOfTicksNegY = yMin / yInterval;

            // Determine how many pixels between ticks on the positive Y-axis.
            int pixelsBetweenTicksPosY = halfHeight / amountOfTicksPosY;

            // Determine how many pixels between ticks on the negative Y-axis.
            int pixelsBetweenTicksNegY = halfHeight / amountOfTicksNegY;


            // Draw each tick mark on the positive X-axis.
            for (int i = 0; i <= amountOfTicksPosX; i++) {
                    g.DrawLine(pen, halfWidth + (i * pixelsBetweenTicksPosX), halfHeight + 3, halfWidth + (i * pixelsBetweenTicksPosX), halfHeight - 3);
            }

            // Draw each tick mark on the negative X-axis.
            for (int i = 0; i <= amountOfTicksNegX; i++) {
                g.DrawLine(pen, halfWidth - (i * pixelsBetweenTicksNegX), halfHeight + 3, halfWidth - (i * pixelsBetweenTicksNegX), halfHeight - 3);
            }

            // Draw each tick mark on the positive Y-axis.
            for (int i = 0; i <= amountOfTicksPosY; i++) {
                g.DrawLine(pen, halfWidth + 3, halfHeight - (i * pixelsBetweenTicksPosY), halfWidth - 3, halfHeight - (i * pixelsBetweenTicksPosY));
            }

            // Draw each tick mark on the negative Y-axis.
            for (int i = 0; i <= amountOfTicksNegY; i++) {
                g.DrawLine(pen, halfWidth + 3, halfHeight + (i * pixelsBetweenTicksNegY), halfWidth - 3, halfHeight + (i * pixelsBetweenTicksNegY));
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void buttonLinearCalculate(object sender, EventArgs e) {
            drawGrid();

        }
    }
}
