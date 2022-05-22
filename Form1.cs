using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Media;
namespace Đọc_số_nguyên
{
    public partial class frmMain : Form
    {
        SpeechSynthesizer read;
        public frmMain()
        {
            InitializeComponent();
            read = new SpeechSynthesizer();
        }
        public String[] units = { "Zero", "One", "Two", "Three",  "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen","Seventeen", "Eighteen", "Nineteen" };
        public String[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public String[] big = { "", " Thousand", " Million", " Billion"," Trillion"};
        string makeEng(long x, int cnt)
        {
            if (x == 0 && cnt > 0) return "";
            if (x < 20) return " " + units[x] + " " + big[cnt];
            else
            {
                long group = x % 1000;
                long hundreds = group / 100;
                long ten = (group / 10) % 10;
                long digits = group % 10;
                string ans = "";
                if (hundreds > 0) ans += " " + units[hundreds] + " Hundred";
                if (ten * 10 + digits < 20)
                {
                    if (ten * 10 + digits != 0) ans += " " + units[ten * 10 + digits];
                }
                else
                {
                    ans += " " + tens[ten];
                    if (digits != 0) ans += " " + units[digits];
                }
                return makeEng(x / 1000, cnt + 1) + " " + ans + big[cnt];
            }
        }

       
        //-------------------------------------------------------------------------
        public String[] donvi = {"không", "một", "hai", "ba", "bốn", "năm", 
                                 "sáu", "bảy", "tám", "chín","mười"};
        public String[] chuc = { "lẻ" , "mười" , "hai mươi", "ba mươi", "bốn mươi", "năm mươi", 
                                 "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        public String[] hang = { "", " nghìn", " triệu", " tỉ", " nghìn tỉ" };
        string makeViet(long x, int cnt)
        {
            if (x == 0 && cnt > 0) return "";
            if (x <= 10) return " " + donvi[x] + hang[cnt];
            else if (x < 100)
            {
                if (x % 10 != 0)
                {
                    if (x == 11) return " " + "mười một" + hang[cnt];
                    else if (x % 10 == 1) return " " + chuc[x / 10] + " " + "mốt" + hang[cnt];
                    else return " " + chuc[x / 10] + " " + donvi[x % 10] + hang[cnt];
                }
                else return " " + chuc[x / 10] + hang[cnt];
            }
            else
            {
                long group = x % 1000;
                if (group == 0) return makeViet(x / 1000, cnt + 1);
                long hundreds = group / 100;
                long ten = (group / 10) % 10;
                long digits = group % 10;
                string ans = "";
                ans += donvi[hundreds] + " trăm";
                if (ten == 0 && digits == 0) return makeViet(x / 1000, cnt + 1) + " " + donvi[hundreds] + " trăm" + hang[cnt];
                if (ten != 0) ans += " " + chuc[ten];
                else ans += " " + "lẻ";
                if (digits == 1 && ten>1) ans += " " + "mốt";
                else ans += " " + donvi[digits]; 
                return makeViet(x / 1000, cnt + 1) + " " + ans + hang[cnt];
            }
        }

        long Eng = 1, Viet = 0;
        void parse(long lang)
        {
            if (txtInput.TextLength != 0)
            {
                long ans = long.Parse(txtInput.Text);
                if (lang == Eng)
                {
                    string x = makeEng(ans, 0);
                    x = x.Replace("  ", " ");
                    x = x.Trim();
                    txtOutput.Text = x;
                }
                else
                {
                    string x = makeViet(ans, 0);
                    x = x.Replace("  ", " ");
                    x = x.Trim();
                    txtOutput.Text = x;
                }

                }
            else txtOutput.Text = "";
        }

        private void allTick_Click(object sender, EventArgs e)
        {
            if (sender == tickEng) parse(Eng);
            else parse(Viet);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 1)
            {
                while (txtInput.Text.StartsWith("0"))
                {
                    txtInput.Text = txtInput.Text.Remove(0, 1);
                    txtInput.SelectionStart = 1;
                }
            }
            
            if (tickEng.Checked) parse(Eng);
            else if (tickViet.Checked) parse(Viet);
        }
        //-------------------------------------------------------------------------------//
        
       
        void chooseGender()
        {
            if (tickMale.Checked) read.SelectVoiceByHints(VoiceGender.Male);
            else if (tickFemale.Checked) read.SelectVoiceByHints(VoiceGender.Female);
            else read.SelectVoiceByHints(VoiceGender.Neutral);
        }
        
        void readInEng()
        {
            chooseGender();
            read.SetOutputToDefaultAudioDevice();
            read.Speak(txtOutput.Text);
        }

        void readInViet()
        {
            string gender = "";
            if (tickFemale.Checked) gender = "Fe";
            else gender = "Male";
            string[] subs = txtOutput.Text.Split(' ');
            foreach (string word in subs)
            {
                using (SoundPlayer player = new SoundPlayer($"{word}{gender}.wav")) player.PlaySync();
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (txtOutput.TextLength == 0) return;
            if (tickEng.Checked) readInEng();
            else readInViet();
        }
        
        //------------------------------------------------------------------------------//
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtInput.Text.Length >= 15 && e.KeyChar != 8)
            {
                MessageBox.Show("Số bạn nhập quá lớn", "Quá giới hạn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '0' && txtInput.Text.StartsWith("0")) e.Handled = true;
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void btnRead_MouseEnter(object sender, EventArgs e)
        {
            tipRead.Show("Đọc số vừa nhập",btnRead);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
