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

        private void link_occ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            link_occ.LinkVisited = true;

            //ブラウザで開く
            System.Diagnostics.Process.Start("http://www.occ.co.jp");
        }
	}
}
