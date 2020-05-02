using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixerApp
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int red = 0;
        int green = 0;
        int blue = 0;
        public Form1()
        {
            InitializeComponent();
            ChangeFormColor();
            LabelUpdate();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            red = random.Next(0, 256);
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            ChangeFormColor();
            SliderUpdate();
            LabelUpdate();
        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            green = random.Next(0, 256);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            ChangeFormColor();
            SliderUpdate();
            LabelUpdate();
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            blue = random.Next(0, 256);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            ChangeFormColor();
            SliderUpdate();
            LabelUpdate();
        }

        private void ChangeFormColor()
        {
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void UpdatateColorBox()
        {
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            LabelUpdate();
        }
        private void SliderUpdate()
        {
            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;
            LabelUpdate();

        }

        private void RandomAll_Click(object sender, EventArgs e)
        {
            red = random.Next(0, 256);
            green = random.Next(0, 256);
            blue = random.Next(0, 256);
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            SliderUpdate();
            LabelUpdate();
            ChangeFormColor();

        }
        private void LabelUpdate()
        {
            HexNumber.Text = "Hex value: " + ColorTranslator.ToHtml(Color.FromArgb(red, green, blue));
            RedLabel.Text = "Red Value: " + red;
            GreenLabel.Text = "Green Value: " + green;
            BlueLabel.Text = "Blue Value: " + blue;
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            red = RedSlider.Value;
            ChangeFormColor();
            UpdatateColorBox();
            LabelUpdate();
        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            green = GreenSlider.Value;
            ChangeFormColor();
            UpdatateColorBox();
            LabelUpdate();
        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            blue = BlueSlider.Value;
            ChangeFormColor();
            UpdatateColorBox();
            LabelUpdate();
        }
    }
}
