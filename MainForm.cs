using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五十音
{
    public partial class MainForm : Form
    {
        private const int wordsCount = 71;
        private string[,] strs;
        private Random random = new Random();
        private SoundPlayer player = new SoundPlayer();

        private int currentIndex = -1;
        private int currentType = 2;

        public MainForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            strs = new string[3, wordsCount]
            {
                { "あ","か","さ","た","な","は","ま","や","ら","わ","ん","い","き","し","ち","に","ひ","み","り","う","く","す","つ","ぬ","ふ","む","ゆ","る","え","け","せ","て","ね","へ","め","お","こ","そ","と","の","ほ","も","よ","ろ","を","が","ぎ","ざ","だ","ば","ぱ","ぐ","じ","ぢ","び","ぴ","げ","ず","づ","ぶ","ぷ","ご","ぜ","で","べ","ぺ","ぞ","ど","ぼ","ぽ", "ん"},
                { "ア","カ","サ","タ","ナ","ハ","マ","ヤ","ラ","ワ","ン","イ","キ","シ","チ","ニ","ヒ","ミ","リ","ウ","ク","ス","ツ","ヌ","フ","ム","ユ","ル","エ","ケ","セ","テ","ネ","ヘ","メ","オ","コ","ソ","ト","ノ","ホ","モ","ヨ","ロ","ヲ","ガ","ギ","ザ","ダ","バ","パ","グ","ジ","ヂ","ビ","ピ","ゲ","ズ","ヅ","ブ","プ","ゴ","ゼ","デ","ベ","ペ","ゾ","ド","ボ","ポ","ン"},
                {"a","ka","sa","ta","na","ha","ma","ya","ra","wa","n","i","ki","shi","chi","ni","hi","mi","ri","u","ku","su","tsu","nu","hu","mu","yu","ru","e","ke","se","te","ne","he","me","o","ko","so","to","no","ho","mo","yo","ro","wo","ga","gi","za","da","ba","pa","gu","ji","ji","bi","pi","ge","zu","zu","bu","pu","go","ze","de","be","pe","zo","do","bo","po","n" }
            };
            this.timer1.Interval = (int)this.txtSeconds.Value * 1000;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if(this.timer1.Enabled)
            {
                this.timer1.Stop();
                this.btnAutoPlay.Text = "AUTO";
            }
            this.Next();
        }

        private void Next()
        {
            if (currentIndex >= 0)
            {
                lb1.Text = this.strs[0, currentIndex];
                lb2.Text = this.strs[1, currentIndex];
                lb3.Text = this.strs[2, currentIndex];
                if (this.currentType != 2)
                {
                    this.PlaySound(this.strs[2, currentIndex]);
                }
                this.currentIndex = -1;
            }
            else
            {
                this.currentIndex = random.Next(0, wordsCount);
                lb1.Text = "";
                lb2.Text = "";
                lb3.Text = "";
                int tempType = this.currentType == 3 ? this.random.Next(0, 2) : this.currentType;
                switch (tempType)
                {
                    case 0:
                        lb1.Text = this.strs[0, this.currentIndex];
                        break;
                    case 1:
                        lb2.Text = this.strs[1, this.currentIndex];
                        break;
                    case 2:
                        lb3.Text = this.strs[2, this.currentIndex];
                        this.PlaySound(this.strs[2, currentIndex]);
                        break;
                }
            }
        }

        private void PlaySound(string str)
        {
            if (this.chkMute.Checked)
                return;
            player.Stop();
            player.Stream = Properties.Resources.ResourceManager.GetStream(str, Properties.Resources.Culture);
            player.LoadAsync();
            player.Play();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Space || keyData == Keys.Enter)
            {
                this.BtnPlay_Click(null, null);
                return true;
            }
            if(keyData == Keys.M)
            {
                this.chkMute.Checked = !this.chkMute.Checked;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void RbVoice_CheckedChanged(object sender, EventArgs e)
        {
            this.currentType = 2;
        }

        private void RbPing_CheckedChanged(object sender, EventArgs e)
        {
            this.currentType = 0;
        }

        private void RbPian_CheckedChanged(object sender, EventArgs e)
        {
            this.currentType = 1;
        }

        private void RbDouble_CheckedChanged(object sender, EventArgs e)
        {
            this.currentType = 3;
        }

        private void BtnAutoPlay_Click(object sender, EventArgs e)
        {
            if (!this.timer1.Enabled)
            {
                this.Timer1_Tick(null, null);
                this.timer1.Start();
                this.btnAutoPlay.Text = "▶▶";
            }
            else
            {
                this.timer1.Stop();
                this.btnAutoPlay.Text = "AUTO";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Next();
        }

        private void TxtSeconds_ValueChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = (int)this.txtSeconds.Value * 1000;
        }
    }
}
