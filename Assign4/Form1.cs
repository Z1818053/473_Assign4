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
        int xMin = -100;
        int xMax = 100;
        int xInterval = 5;
        int yMin = -100;
        int yMax = 100;
        int yInterval = 10;

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

            // Get how many ticks need to be drawn.
            int amountOfTicks = xMax / xInterval;

            // Determine how many pixels between ticks.
            int pixelsBetweenTicks = halfWidth / amountOfTicks;

            //MessageBox.Show(pixelsBetweenTicks.ToString());

            // Draw each tick mark on the positive X-axis.
            for (int i = 0; i <= amountOfTicks; i++) {
                    g.DrawLine(pen, halfWidth + (i * pixelsBetweenTicks), halfHeight + 3, halfWidth + (i * pixelsBetweenTicks), halfHeight - 3);
            }

            // Draw each tick mark on the negative X-axis.
            for (int i = 0; i <= amountOfTicks; i++) {
                g.DrawLine(pen, halfWidth - (i * pixelsBetweenTicks), halfHeight + 3, halfWidth - (i * pixelsBetweenTicks), halfHeight - 3);
            }

            // Draw each tick mark on the positive Y-axis.
            for (int i = 0; i <= amountOfTicks; i++) {
                g.DrawLine(pen, halfWidth + 3, halfHeight - (i * pixelsBetweenTicks), halfWidth - 3, halfHeight - (i * pixelsBetweenTicks));
            }

            // Draw each tick mark on the positive Y-axis.
            for (int i = 0; i <= amountOfTicks; i++) {
                g.DrawLine(pen, halfWidth + 3, halfHeight + (i * pixelsBetweenTicks), halfWidth - 3, halfHeight + (i * pixelsBetweenTicks));
            }

            // Draw each tick mark.
            /*
            for (int i = 0; i <= amountOfTicks; i += xInterval) {
                if (i % xInterval == 0) {
                    

                    g.DrawLine(pen, halfWidth + i, halfHeight + 3, halfWidth + i, halfHeight - 3);
                }
            }
            */
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
