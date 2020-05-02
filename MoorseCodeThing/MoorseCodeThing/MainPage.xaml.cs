using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoorseCodeThing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DashButton_OnClicked(object sender, EventArgs e)
        {
            if (Label.Text == "Use Buttons to Enter Text and Press Translate when you are ready to translate...")
            {
                Label.Text = "";
                Label.Text += "-";    
            }

            else
            {
                Label.Text += "-";
            }
        }

        private void DotButton_OnClicked(object sender, EventArgs e)
        {
            if (Label.Text == "Use Buttons to Enter Text and Press Translate when ClearButton_OnClickedateButton_OnClicked...")
            {
                Label.Text = "";
                Label.Text += ".";    
            }

            else
            {
                Label.Text += ".";
            }
        }

        private void TranslateButton_OnClicked(object sender, EventArgs e)
        {
            Label.Text = Convert.ToString(Morse.MorseCoder(Label.Text));
        }

        private void ClearButton_OnClicked(object sender, EventArgs e)
        {
            Label.Text = "";
        }
    }

    public class Morse
    {
        private static string[] codes = new string[] { ".-", "-...", "-.-.", "-..",".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.","--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };        
        private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};

        public Morse()
        {
            
        }        
        public static char MorseCoder(string code) 
        {            char result='?';            for (int i = 0; i < codes.Length;i++) {                if (codes[i].Equals(code)) {                    result = letters[i];                    break;                }            }            return result;        }
    }
    
}