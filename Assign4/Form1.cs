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
        int xInterval = 10;
        int yMin = -100;
        int yMax = 100;
        int yInterval = 10;

        public Form1() {
            InitializeComponent();
        }

        private void drawGrid() {
            Graphics g = pictureBoxGrid.CreateGraphics();

            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.Width = 3;
            
            int halfHeight = pictureBoxGrid.Height / 2;
            int halfWidth = pictureBoxGrid.Width / 2;

            // Draw horizontal line.
            g.DrawLine(pen, 0, halfHeight, pictureBoxGrid.Width, halfHeight);

            // Draw vertical line.
            g.DrawLine(pen, halfWidth, 0, halfWidth, pictureBoxGrid.Height);

            pen.Width = 1;

            // Draw each tick mark.
            for (int i = 0; i <= xMax; i++) {
                if (i % xInterval == 0) {
                    

                    g.DrawLine(pen, halfWidth + i, halfHeight + 3, halfWidth + i, halfHeight - 3);
                }
            
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
