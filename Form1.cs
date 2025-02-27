using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = GeneratePassword(10, true, true);
        }

        public string GeneratePassword(int length, bool useDigits, bool useSymbols)
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()_+[]{}|;:,.<>?";

            string charPool = lower + upper;

            if (useDigits) charPool += numbers;
            if (useSymbols) charPool += symbols;

            var random = new Random();
            return new string(Enumerable.Repeat(charPool, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
