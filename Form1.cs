using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Capitalizer
{
    public partial class frmSentenceCapitalizer : Form
    {
        public frmSentenceCapitalizer()
        {
            InitializeComponent();
        }

        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            string sentence = tboxSentence.Text.Trim();
            bool isCapital = true;

            List<string> capitalized = new List<string>();

            for(int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (c == '.' || c == '!' || c == '?')
                {
                   isCapital = true;
                }
                else if(isCapital && char.IsLetter(c))
                {
                    c = char.ToUpper(c);
                    isCapital = false;
                }
                capitalized.Add(c.ToString());
            }

            foreach(string s in capitalized)
            {
                lblOutCapitalized.Text += s;
            }
                      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxSentence.Text = "";
            lblOutCapitalized.Text = "";

            tboxSentence.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
