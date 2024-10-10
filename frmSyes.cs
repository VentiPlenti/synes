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
            txtInput.Text = "";
        }

        private void frmSynes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
       
        private Color GetColourForLetter(char letter)
        {
            switch (char.ToUpper(letter))
            {
                case 'A': return Color.FromArgb(255, 188, 0, 10);      // Opaque Red
                case 'B': return Color.FromArgb(255, 227, 132, 23);   // Opaque Orange
                case 'C': return Color.FromArgb(255, 32, 40, 250);    // Opaque Blue
                case 'D': return Color.FromArgb(210, 20, 10, 30);      // Semi-Opaque Black
                case 'E': return Color.FromArgb(255, 133, 220, 90);     // #85E65E
                case 'F': return Color.FromArgb(204, 53, 15, 35);     // Semi-Opaque Dark Red
                case 'G': return Color.FromArgb(255, 29, 110, 36);      // Opaque Dark Green
                case 'H': return Color.FromArgb(212, 247, 190, 70);    // Semi-Opaque Yellow
                case 'I': return Color.FromArgb(160, 237, 254, 255);    // Very Transparent Light Blue
                case 'J': return Color.FromArgb(255, 200, 45, 1);      // Opaque Orange
                case 'K': return Color.FromArgb(255, 240, 210, 0);     // Opaque Yellow
                case 'L': return Color.FromArgb(255, 140, 38, 75);     // Opaque Purple
                case 'M': return Color.FromArgb(255, 129, 11, 22);    // Opaque Purple
                case 'N': return Color.FromArgb(255, 200, 69, 15);    // Opaque Orange
                case 'O': return Color.FromArgb(150, 237, 254, 255);     // Very Transparent Light Blue
                case 'P': return Color.FromArgb(255, 225, 225, 0);    // Opaque Yellow
                case 'Q': return Color.FromArgb(255, 188, 88, 0);       // Opaque Orange
                case 'R': return Color.FromArgb(250, 40, 60, 40);        // Semi-Opaque Dark Purple
                case 'S': return Color.FromArgb(250, 135, 200, 55);      // Semi-Opaque Green
                case 'T': return Color.FromArgb(255, 0, 11, 160);       // Opaque Blue
                case 'U': return Color.FromArgb(255, 50, 0, 120);       // Opaque Purple
                case 'V': return Color.FromArgb(255, 237, 148, 0);      // Opaque Orange
                case 'W': return Color.FromArgb(255, 155, 58, 88);     // #7A3A4A
                case 'X': return Color.FromArgb(255, 46, 71, 125);      // Opaque Blue
                case 'Y': return Color.FromArgb(255, 234, 176, 0);     // Opaque Yellow
                case 'Z': return Color.FromArgb(255, 168, 72, 22);      // Opaque Brown
                case 'Ł': return Color.FromArgb(255, 124, 48, 77);      // #7C304D
                case 'Ę': return Color.FromArgb(255, 117, 199, 85);     // #75C755
                case 'Ń': return Color.FromArgb(255, 255, 57, 21);      // #FF3915
                case 'Ś': return Color.FromArgb(255, 177, 249, 68);     // #B1F944
                case 'Ź': return Color.FromArgb(255, 190, 57, 21);      // #BE3915
                case 'Ż': return Color.FromArgb(255, 134, 32, 3);       // #862003
                case 'Ó': return Color.FromArgb(204, 199, 225, 218);     // #C7E1DA (80% transparent)
                case 'Ą': return Color.FromArgb(255, 228, 38, 51);      // #E42633
                case '0': return Color.FromArgb(30, 237, 254, 255);
                case '1': return Color.FromArgb(230, 250, 250, 240);
                case '2': return Color.FromArgb(255, 20, 40, 190);
                case '3': return Color.FromArgb(255, 206, 80, 141);     // #CE508D
                case '4': return Color.FromArgb(255, 0, 80, 100);

                default: return Color.Black;  // Default colour
            }
        }

        private void DrawColouredText(Graphics g, string text, Font font)
        {
            float x = 10;
            float y = 10;
            float maxWidth = 800; // maximum width for a line

            // Split input text into words
            foreach (var word in text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                // Check if the word is not null
                if (string.IsNullOrWhiteSpace(word)) continue;

                // Measure current word
                float wordWidth = g.MeasureString(word, font).Width;

                // Check word fits within the max width
                if (x + wordWidth > maxWidth)
                {
                    // Move to the next line
                    x = 10; // Reset x to start of line
                    y += font.GetHeight(g) + 5; // Move y down for next line
                }

                // Draw each letter in colour with an outline
                for (int i = 0; i < word.Length; i++)
                {
                    // Get the character colour
                    char letter = word[i];
                    Color letterColour = GetColourForLetter(letter);
                    Color firstLetterColour = GetColourForLetter(word[0]); // 
                    int adjustedAlpha = Math.Max(0, firstLetterColour.A - 85); // alpha set please work
                    Color outlineColour = Color.FromArgb(adjustedAlpha, firstLetterColour.R, firstLetterColour.G, firstLetterColour.B); // Opaque outline

                    // Measure the width of the current letter
                    float letterWidth = g.MeasureString(letter.ToString(), font).Width;

                    // Create a GraphicsPath for the current letter
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddString(letter.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(x, y), StringFormat.GenericDefault);

                        // Draw the filled character
                        g.DrawString(letter.ToString(), font, new SolidBrush(letterColour), x, y);
                        // Draw the outline for the character
                        g.DrawPath(new Pen(outlineColour, 4), path);
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
            DrawColouredText(e.Graphics, txtInput.Text, new Font("Arial", 24));
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            txtInput.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z Ł Ę Ń Ś Ź Ż Ó Ą 0 1 2 3 4 5 6 7 8 9";
        }

        private void cbShowVers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowVers.Checked)
            {
                lblVersion.Visible = true;
            }
            else
            {
                lblVersion.Visible = false;
            }
        }
    }
}
