using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synes
{
    public partial class frmSynes : Form
    {
        public frmSynes()
        {
            InitializeComponent();
            txtInput.Text = "ha";
        }

        private Color GetColorForLetter(char letter)
        {
            switch (char.ToUpper(letter))
            {
                case 'A': return Color.FromArgb(255, 188, 0, 10);      // Opaque Red
                case 'B': return Color.FromArgb(255, 227, 132, 23);   // Opaque Orange
                case 'C': return Color.FromArgb(255, 32, 40, 250);    // Opaque Blue
                case 'D': return Color.FromArgb(210, 20, 10, 0);      // Semi-Opaque Black
                case 'E': return Color.FromArgb(255, 133, 220, 90);     // #85E65E
                case 'F': return Color.FromArgb(204, 53, 15, 35);     // Semi-Opaque Dark Red
                case 'G': return Color.FromArgb(255, 29, 110, 36);      // Opaque Dark Green
                case 'H': return Color.FromArgb(212, 247, 193, 75);    // Semi-Opaque Yellow
                case 'I': return Color.FromArgb(56, 237, 254, 255);    // Very Transparent Light Blue
                case 'J': return Color.FromArgb(255, 200, 45, 1);      // Opaque Orange
                case 'K': return Color.FromArgb(255, 240, 210, 0);     // Opaque Yellow
                case 'L': return Color.FromArgb(255, 159, 58, 89);     // Opaque Purple
                case 'M': return Color.FromArgb(255, 129, 11, 22);    // Opaque Purple
                case 'N': return Color.FromArgb(255, 228, 90, 20);    // Opaque Orange
                case 'O': return Color.FromArgb(56, 237, 254, 255);     // Very Transparent Light Blue
                case 'P': return Color.FromArgb(255, 245, 242, 20);    // Opaque Yellow
                case 'Q': return Color.FromArgb(255, 188, 88, 0);       // Opaque Orange
                case 'R': return Color.FromArgb(214, 37, 2, 76);        // Semi-Opaque Dark Purple
                case 'S': return Color.FromArgb(245, 135, 200, 35);      // Semi-Opaque Green
                case 'T': return Color.FromArgb(255, 0, 11, 160);       // Opaque Blue
                case 'U': return Color.FromArgb(255, 70, 9, 130);       // Opaque Purple
                case 'V': return Color.FromArgb(255, 237, 148, 0);      // Opaque Orange
                case 'W': return Color.FromArgb(255, 122, 58, 74);     // #7A3A4A
                case 'X': return Color.FromArgb(255, 46, 71, 125);      // Opaque Blue
                case 'Y': return Color.FromArgb(255, 234, 176, 0);     // Opaque Yellow
                case 'Z': return Color.FromArgb(255, 160, 72, 22);      // Opaque Brown
                case 'Ł': return Color.FromArgb(255, 124, 48, 77);      // #7C304D
                case 'Ę': return Color.FromArgb(255, 117, 199, 85);     // #75C755
                case 'Ń': return Color.FromArgb(255, 255, 57, 21);      // #FF3915
                case 'Ś': return Color.FromArgb(255, 177, 249, 68);     // #B1F944
                case 'Ź': return Color.FromArgb(255, 190, 57, 21);      // #BE3915
                case 'Ż': return Color.FromArgb(255, 134, 32, 3);       // #862003
                case 'Ó': return Color.FromArgb(204, 199, 225, 218);     // #C7E1DA (80% transparent)
                case 'Ą': return Color.FromArgb(255, 228, 38, 51);      // #E42633
                case '3': return Color.FromArgb(255, 206, 80, 141);     // #CE508D


                default: return Color.Black;  // Default color if no mapping exists
            }
        }

        private void DrawColoredText(Graphics g, string text, Font font)
        {
            float x = 10;
            float y = 10;
            float maxWidth = 800; // Set your desired maximum width for a line

            // Split the input text into words
            foreach (var word in text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                // Check if the word is not empty
                if (string.IsNullOrWhiteSpace(word)) continue;

                // Measure the width of the current word
                float wordWidth = g.MeasureString(word, font).Width;

                // Check if the word fits within the max width
                if (x + wordWidth > maxWidth)
                {
                    // Move to the next line
                    x = 10; // Reset x to start of the line
                    y += font.GetHeight(g) + 5; // Move y down for the next line
                }

                // Draw each letter in color with an outline
                for (int i = 0; i < word.Length; i++)
                {
                    // Get the character and its color
                    char letter = word[i];
                    Color letterColor = GetColorForLetter(letter);
                    Color firstLetterColor = GetColorForLetter(word[0]); // 
                    Color outlineColor = Color.FromArgb(170, firstLetterColor); // Opaque outline

                    // Measure the width of the current letter
                    float letterWidth = g.MeasureString(letter.ToString(), font).Width;

                    // Create a GraphicsPath for the current letter
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddString(letter.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(x, y), StringFormat.GenericDefault);

                        // Draw the filled character
                        g.DrawString(letter.ToString(), font, new SolidBrush(letterColor), x, y);
                        // Draw the outline for the character
                        g.DrawPath(new Pen(outlineColor, 4), path);
                    }

                    // Move x position for the next letter
                    x += letterWidth;
                }

                // Add space between words
                x += g.MeasureString(" ", font).Width;
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            pbOutput.Invalidate(); // Request to redraw the PictureBox
        }

        private void pbOutput_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint event triggered");
            DrawColoredText(e.Graphics, txtInput.Text, new Font("Arial", 24));
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
