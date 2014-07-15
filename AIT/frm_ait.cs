/*
 * Created by SharpDevelop.
 * User: taro_kimura
 * Date: 2014/07/02
 * Time: 14:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace AIT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frm_AIT : Form
	{
		public frm_AIT()
		{
			InitializeComponent();

            // 初期表示時に、「英語」を選択
            this.comb_before.SelectedIndex = 0;

            // 初期表示時に、「日本語」を選択
            this.comb_after.SelectedIndex = 0;
		}

        // リンクラベルをクリック : OCCのサイトへジャンプ
        private void link_occ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            link_occ.LinkVisited = true;

            //ブラウザで開く
            System.Diagnostics.Process.Start("http://www.occ.co.jp");
        }

        // [TRANSLATE]をクリック
        private void butt_translate_Click(object sender, EventArgs e)
        {
            if (comb_before.SelectedItem.ToString() == "英語" && comb_after.SelectedItem.ToString() == "日本語")
            {
                char[] delimiterChars = {' ','　'};

                string txt_b = text_before.Text;
                string[] words_b = txt_b.Split(delimiterChars);

                foreach (string str_b in words_b)
                {
                    ReadCSV r_csv = new ReadCSV(str_b);

                    if (r_csv.Word != "")
                    {
                        text_after.Text = r_csv.Word;
                    }
                    else
                    {
                        text_after.Text = str_b;
                    }
                }
            }
        }

        public class ReadCSV
        {

            public string word;

            public ReadCSV(string prm_word)
            {

                // 読み込むテキストファイルが入っているディレクトリ
                string possessive_dir = System.IO.Path.GetFullPath(@"./lib");

                // 読み込んだ一行を格納する変数
                string line = "";

                // 読み込んだ単語の得点を格納する変数
                int point = -1;

                // 読み込んだ単語を格納する変数
                string r_word = "";

                if (prm_word != "")
                {
                    using (StreamReader sr = new StreamReader(possessive_dir + "\\possessive.csv", Encoding.GetEncoding("shift_jis")))
                    {
                        // 一行ずつ読み込み
                        while ((line = sr.ReadLine()) != null)
                        {
                            // 配列 arrWords に取得したデータを格納
                            // -> arrWords[0] = 単語の得点
                            // -> arrWords[1] = 単語(英語)
                            // -> arrWords[2] = 単語(日本語)
                            string[] arrWords = line.Split(',');

                            // 英語 -> 日本語の場合
                            if (arrWords[1] == prm_word)
                            {

                                // 単語の得点が高いほうを残す
                                if (int.Parse(arrWords[0]) > point)
                                {
                                    point = int.Parse(arrWords[0]);
                                    r_word = arrWords[2];
                                }
                                else
                                {
                                    Random rnd = new Random();

                                    int num_random = rnd.Next(100);

                                    if (num_random % 2 == 0)
                                    {
                                        point = int.Parse(arrWords[0]);
                                        r_word = arrWords[2];
                                    }
                                }
                            }
                        }

                        sr.Close();
                    }

                }

                if (r_word != "")
                {
                    this.word = r_word;
                }
                else
                {
                    this.word = prm_word;
                }
                
            }

            public string Word
            {
                set{this.word = value;}
                get { return this.word; }
            }

        }
	}
}
