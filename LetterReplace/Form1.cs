using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace LetterReplace
{
    public partial class Form1 : Form
    {
        List<Letter> letters = new List<Letter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbOriginal.Text = "ytn xqavhq yzhu  xu qzupvd ltmat qnncq vgxzy hmrty vbynh ytmq ixur qyhvurn\r\nvlvhpq yhme ytn gvrrnh bnniq imsn v uxuvrnuvhmvu yxx\r\n\r\nytn vlvhpq hvan lvq gxxsnupnp gd ytn pncmqn xb tvhfnd lnmuqynmu vy myq xzyqny\r\nvup ytn veevhnuy mceixqmxu xb tmq bmic axcevud vy ytn nup vup my lvq qtvenp gd\r\nytn ncnhrnuan xb cnyxx ymcnq ze givasrxlu eximymaq vhcavupd vaymfmqc vup\r\nv uvymxuvi axufnhqvymxu vq ghmnb vup cvp vq v bnfnh phnvc vgxzy ltnytnh ytnhn\r\nxzrty yx gn v ehnqmpnuy lmubhnd ytn qnvqxu pmpuy ozqy qnnc nkyhv ixur my lvq\r\nnkyhv ixur gnavzqn ytn xqavhq lnhn cxfnp yx ytn bmhqy lnnsnup mu cvhat yx\r\nvfxmp axubimaymur lmyt ytn aixqmur anhncxud xb ytn lmuynh xidcemaq ytvusq\r\nednxuratvur\r\n\r\nxun gmr jznqymxu qzhhxzupmur ytmq dnvhq vavpncd vlvhpq mq txl xh mb ytn\r\nanhncxud lmii vpphnqq cnyxx nqenamviid vbynh ytn rxipnu rixgnq ltmat gnavcn\r\nv ozgmivuy axcmurxzy evhyd bxh ymcnq ze ytn cxfncnuy qenvhtnvpnp gd \r\nexlnhbzi txiidlxxp lxcnu ltx tnienp hvmqn cmiimxuq xb pxiivhq yx bmrty qnkzvi\r\ntvhvqqcnuy vhxzup ytn axzuyhd\r\n\r\nqmruvimur ytnmh qzeexhy rxipnu rixgnq vyynupnnq qlvytnp ytncqnifnq mu givas\r\nqexhynp iveni emuq vup qxzupnp xbb vgxzy qnkmqy exlnh mcgvivuanq bhxc ytn hnp\r\navheny vup ytn qyvrn xu ytn vmh n lvq aviinp xzy vgxzy evd munjzmyd vbynh\r\nmyq bxhcnh vuatxh avyy qvpinh jzmy xuan qtn invhunp ytvy qtn lvq cvsmur bvh\r\ninqq ytvu v cvin axtxqy vup pzhmur ytn anhncxud uvyvimn exhycvu yxxs v gizuy\r\nvup qvymqbdmur pmr vy ytn viicvin hxqynh xb uxcmuvynp pmhnayxhq txl axzip\r\nytvy gn yxeenp\r\n\r\nvq my yzhuq xzy vy invqy mu ynhcq xb ytn xqavhq my ehxgvgid lxuy gn\r\n\r\nlxcnu mufxifnp mu ymcnq ze qvmp ytvy viytxzrt ytn rixgnq qmrumbmnp ytn\r\nmumymvymfnq ivzuat ytnd unfnh muynupnp my yx gn ozqy vu vlvhpq qnvqxu\r\navcevmru xh xun ytvy gnavcn vqqxamvynp xuid lmyt hnpavheny vaymxuq muqynvp\r\nv qexsnqlxcvu qvmp ytn rhxze mq lxhsmur gntmup aixqnp pxxhq vup tvq qmuan\r\nvcvqqnp  cmiimxu bxh myq inrvi pnbnuqn bzup ltmat vbynh ytn rixgnq lvq\r\nbixxpnp lmyt ytxzqvupq xb pxuvymxuq xb  xh inqq bhxc enxein mu qxcn \r\naxzuyhmnq\r\n\r\n\r\nux avii yx lnvh givas rxluq lnuy xzy mu vpfvuan xb ytn xqavhq ytxzrt ytn\r\ncxfncnuy lmii vicxqy anhyvmuid gn hnbnhnuanp gnbxhn vup pzhmur ytn anhncxud \r\nnqenamviid qmuan fxavi cnyxx qzeexhynhq imsn vqtind ozpp ivzhv pnhu vup\r\numaxin smpcvu vhn qatnpzinp ehnqnuynhq\r\n\r\nvuxytnh bnvyzhn xb ytmq qnvqxu ux xun hnviid suxlq ltx mq rxmur yx lmu gnqy\r\nemayzhn vhrzvgid ytmq tveenuq v ixy xb ytn ymcn muvhrzvgid ytn uvmigmynh\r\nuvhhvymfn xuid qnhfnq ytn vlvhpq tden cvatmun gzy xbynu ytn enxein bxhnavqymur\r\nytn hvan qxaviinp xqavhxixrmqyq avu cvsn xuid npzavynp rznqqnq\r\n\r\nytn lvd ytn vavpncd yvgzivynq ytn gmr lmuunh pxnquy tnie mu nfnhd xytnh\r\navynrxhd ytn uxcmunn lmyt ytn cxqy fxynq lmuq gzy mu ytn gnqy emayzhn\r\navynrxhd fxynhq vhn vqsnp yx imqy ytnmh yxe cxfmnq mu ehnbnhnuymvi xhpnh mb v\r\ncxfmn rnyq cxhn ytvu  enhanuy xb ytn bmhqyeivan fxynq my lmuq ltnu ux\r\ncxfmn cvuvrnq ytvy ytn xun lmyt ytn bnlnqy bmhqyeivan fxynq mq nimcmuvynp vup\r\nmyq fxynq vhn hnpmqyhmgzynp yx ytn cxfmnq ytvy rvhunhnp ytn nimcmuvynp gviixyq\r\nqnaxupeivan fxynq vup ytmq axuymuznq zuymi v lmuunh ncnhrnq\r\n\r\nmy mq vii ynhhmgid axubzqmur gzy veevhnuyid ytn axuqnuqzq bvfxhmyn axcnq xzy\r\nvtnvp mu ytn nup ytmq cnvuq ytvy nupxbqnvqxu vlvhpq atvyynh mufvhmvgid\r\nmufxifnq yxhyzhnp qenazivymxu vgxzy ltmat bmic lxzip cxqy imsnid gn fxynhq\r\nqnaxup xh ytmhp bvfxhmyn vup ytnu njzviid yxhyzhnp axuaizqmxuq vgxzy ltmat\r\nbmic cmrty ehnfvmi\r\n\r\nmu  my lvq v yxqqze gnylnnu gxdtxxp vup ytn nfnuyzvi lmuunh gmhpcvu\r\nmu  lmyt ixyq xb nkenhyq gnyymur xu ytn hnfnuvuy xh ytn gmr qtxhy ytn\r\nehmwn lnuy yx qexyimrty ivqy dnvh unvhid vii ytn bxhnavqynhq pnaivhnp iv\r\niv ivup ytn ehnqzceymfn lmuunh vup bxh ylx vup v tvib cmuzynq ytnd lnhn\r\naxhhnay gnbxhn vu nufnixen quvbz lvq hnfnvinp vup ytn hmrtybzi lmuunh\r\ncxxuimrty lvq ahxlunp\r\n\r\nytmq dnvh vlvhpq lvyatnhq vhn zunjzviid pmfmpnp gnylnnu ythnn gmiigxvhpq\r\nxzyqmpn nggmur cmqqxzhm ytn bvfxhmyn vup ytn qtven xb lvynh ltmat mq\r\nytn gvrrnhq ehnpmaymxu lmyt v bnl bxhnavqymur v tvmi cvhd lmu bxh rny xzy\r\n\r\ngzy vii xb ytxqn bmicq tvfn tmqyxhmavi xqavhfxymur evyynhuq vrvmuqy ytnc ytn\r\nqtven xb lvynh tvq  uxcmuvymxuq cxhn ytvu vud xytnh bmic vup lvq viqx\r\nuvcnp ytn dnvhq gnqy gd ytn ehxpzanhq vup pmhnayxhq rzmipq dny my lvq uxy\r\nuxcmuvynp bxh v qahnnu vayxhq rzmip vlvhp bxh gnqy nuqncgin vup ux bmic tvq\r\nlxu gnqy emayzhn lmytxzy ehnfmxzqid ivupmur vy invqy ytn vayxhq uxcmuvymxu\r\nqmuan ghvfntnvhy mu  ytmq dnvh ytn gnqy nuqncgin qvr nupnp ze rxmur yx\r\nythnn gmiigxvhpq ltmat mq qmrumbmavuy gnavzqn vayxhq cvsn ze ytn vavpncdq\r\nivhrnqy ghvuat ytvy bmic ltmin pmfmqmfn viqx lxu ytn gnqy phvcv rxipnu rixgn\r\nvup ytn gvbyv gzy myq bmiccvsnh cvhymu capxuvrt lvq uxy uxcmuvynp bxh gnqy\r\npmhnayxh vup vevhy bhxc vhrx cxfmnq ytvy ivup gnqy emayzhn lmytxzy viqx\r\nnvhumur gnqy pmhnayxh uxcmuvymxuq vhn bnl vup bvh gnylnnu\r\n\r\n\r\n\r\n\r\n";
            PopulateLetterList(rtbOriginal.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbLetter.Text == "" || tbReplaceWith.Text == "")
            {
                MessageBox.Show("Please choose letter!");
                return;
            }

            if (tbLetter.Text == tbReplaceWith.Text)
            {
                MessageBox.Show("Please choose different letter!");
                return;
            }

            rtbResult.Text = "";
            listBox1.Items.Add(tbLetter.Text[0] + "->" + tbReplaceWith.Text[0]);


            Task.Run(() =>
            {
                button1.Enabled = false;
                btRemove.Enabled = false;
                for (int i = 0; i < letters.Count; i++)
                {
                    if (letters[i].isReplaced == false && letters[i].letter == tbLetter.Text[0])
                    {
                        letters[i].letter = tbReplaceWith.Text[0];
                        letters[i].isReplaced = true;
                        rtbResult.SelectionStart = rtbResult.TextLength;
                        rtbResult.SelectionLength = 0;
                        rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Bold);
                        rtbResult.AppendText(letters[i].letter.ToString());
                    }
                    else if (letters[i].isReplaced == true)
                    {
                        rtbResult.SelectionStart = rtbResult.TextLength;
                        rtbResult.SelectionLength = 0;
                        rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Bold);
                        rtbResult.AppendText(letters[i].letter.ToString());
                    }
                    else
                    {
                        rtbResult.SelectionStart = rtbResult.TextLength;
                        rtbResult.SelectionLength = 0;
                        rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Regular);
                        rtbResult.AppendText(letters[i].letter.ToString());
                    }

                }
                if (tbLetter.SelectedIndex != -1)
                    tbLetter.Items.RemoveAt(tbLetter.SelectedIndex);

                if (tbReplaceWith.SelectedIndex != -1)
                    tbReplaceWith.Items.RemoveAt(tbReplaceWith.SelectedIndex);

                tbLetter.Text = tbReplaceWith.Text = string.Empty;
                button1.Enabled = true;
                btRemove.Enabled = true;
                rtbTemp.Text = rtbResult.Text; //rtbTemp is not showing in form, it just used to store result for later use
            });



        }


        private void rtbOriginal_TextChanged_1(object sender, EventArgs e)
        {
            rtbTemp.Text = rtbOriginal.Text;
            PopulateLetterList(rtbTemp.Text);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString());
                tbLetter.Items.Add(listBox1.Items[i].ToString()[0]);
                tbReplaceWith.Items.Add(listBox1.Items[i].ToString()[3]);
            }
            listBox1.Items.Clear();
        }


        private void btRemove_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                button1.Enabled = false;
                btRemove.Enabled = false;
                if (listBox1.SelectedIndex != -1)
                {
                    rtbResult.Text = "";

                    for (int i = 0; i < letters.Count; i++)
                    {

                        if (letters[i].isReplaced == true && letters[i].letter == listBox1.Text.ToString()[3])
                        {
                            letters[i].isReplaced = false;
                            letters[i].letter = letters[i].orgLetter;
                            rtbResult.SelectionStart = rtbResult.TextLength;
                            rtbResult.SelectionLength = 0;
                            rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Regular);
                            rtbResult.AppendText(letters[i].letter.ToString());
                        }
                        else if (letters[i].isReplaced == true)
                        {
                            rtbResult.SelectionStart = rtbResult.TextLength;
                            rtbResult.SelectionLength = 0;
                            rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Bold);
                            rtbResult.AppendText(letters[i].letter.ToString());
                        }
                        else
                        {
                            rtbResult.SelectionStart = rtbResult.TextLength;
                            rtbResult.SelectionLength = 0;
                            rtbResult.SelectionFont = new Font(rtbResult.Font, FontStyle.Regular);
                            rtbResult.AppendText(letters[i].letter.ToString());
                        }
                    }
                    AddLetterBackToComboBox(listBox1.Text[0], listBox1.Text[3]);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    button1.Enabled = true;
                    btRemove.Enabled = true;
                    rtbTemp.Text = rtbOriginal.Text;
                }
            });


        }

        void AddLetterBackToComboBox(char from, char to)
        {
            tbLetter.Items.Add(from);
            tbReplaceWith.Items.Add(to);
        }

        void PopulateLetterList(string text)
        {
            letters.Clear();
            foreach (char c in text)
            {
                letters.Add(new Letter(c));
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (Letter c in letters)
            {
                s += c.letter;
            }
            MessageBox.Show(s);

        }
    }
}
