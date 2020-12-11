using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek13
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "[EMPTY]")
            {
                labelOutput.Text = textBoxInput.Text;
            }
            if (labelOutput.Text != "[EMPTY]" && textBoxInput.Text == "DELETE")
            {
                labelOutput.Text = "[EMPTY]";
                labelOutput.ForeColor = Color.Black;
            }
            if (labelOutput.Text != "[EMPTY]")
            {
                if (textBoxInput.Text == "SHOWN")
                {
                    labelOutput.Visible = true;
                }
                if (textBoxInput.Text == "HIDE")
                {
                    labelOutput.Visible = false;
                }
            }
            if (labelOutput.Text != "[EMPTY]")
            {
                if (textBoxInput.Text == "BLUE")
                {
                    labelOutput.ForeColor = Color.Blue;
                }
                if (textBoxInput.Text == "RED")
                {
                    labelOutput.ForeColor = Color.Red;
                }
                if (textBoxInput.Text == "GREEN")
                {
                    labelOutput.ForeColor = Color.Green;
                }

            }
        }
    }
}
