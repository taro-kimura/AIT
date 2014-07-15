/*
 * Created by SharpDevelop.
 * User: taro_kimura
 * Date: 2014/07/02
 * Time: 14:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AIT
{
	partial class frm_AIT
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.butt_translate = new System.Windows.Forms.Button();
            this.comb_before = new System.Windows.Forms.ComboBox();
            this.comb_after = new System.Windows.Forms.ComboBox();
            this.rad_alien = new System.Windows.Forms.RadioButton();
            this.rad_nonnative = new System.Windows.Forms.RadioButton();
            this.rad_native = new System.Windows.Forms.RadioButton();
            this.butt_send = new System.Windows.Forms.Button();
            this.butt_teach = new System.Windows.Forms.Button();
            this.text_before = new System.Windows.Forms.TextBox();
            this.text_after = new System.Windows.Forms.TextBox();
            this.group_his_ability = new System.Windows.Forms.GroupBox();
            this.link_occ = new System.Windows.Forms.LinkLabel();
            this.group_his_ability.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_translate
            // 
            this.butt_translate.Location = new System.Drawing.Point(223, 49);
            this.butt_translate.Name = "butt_translate";
            this.butt_translate.Size = new System.Drawing.Size(100, 42);
            this.butt_translate.TabIndex = 2;
            this.butt_translate.Text = "TRANSLATE";
            this.butt_translate.UseVisualStyleBackColor = true;
            this.butt_translate.Click += new System.EventHandler(this.butt_translate_Click);
            // 
            // comb_before
            // 
            this.comb_before.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_before.FormattingEnabled = true;
            this.comb_before.Items.AddRange(new object[] {
            "英語",
            "日本語"});
            this.comb_before.Location = new System.Drawing.Point(12, 12);
            this.comb_before.Name = "comb_before";
            this.comb_before.Size = new System.Drawing.Size(188, 20);
            this.comb_before.TabIndex = 3;
            // 
            // comb_after
            // 
            this.comb_after.BackColor = System.Drawing.SystemColors.Info;
            this.comb_after.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_after.FormattingEnabled = true;
            this.comb_after.Items.AddRange(new object[] {
            "日本語",
            "英語"});
            this.comb_after.Location = new System.Drawing.Point(348, 12);
            this.comb_after.Name = "comb_after";
            this.comb_after.Size = new System.Drawing.Size(188, 20);
            this.comb_after.TabIndex = 4;
            // 
            // rad_alien
            // 
            this.rad_alien.Location = new System.Drawing.Point(6, 86);
            this.rad_alien.Name = "rad_alien";
            this.rad_alien.Size = new System.Drawing.Size(87, 22);
            this.rad_alien.TabIndex = 5;
            this.rad_alien.TabStop = true;
            this.rad_alien.Text = "alien";
            this.rad_alien.UseVisualStyleBackColor = true;
            // 
            // rad_nonnative
            // 
            this.rad_nonnative.Location = new System.Drawing.Point(6, 56);
            this.rad_nonnative.Name = "rad_nonnative";
            this.rad_nonnative.Size = new System.Drawing.Size(87, 22);
            this.rad_nonnative.TabIndex = 6;
            this.rad_nonnative.TabStop = true;
            this.rad_nonnative.Text = "non-native";
            this.rad_nonnative.UseVisualStyleBackColor = true;
            // 
            // rad_native
            // 
            this.rad_native.Location = new System.Drawing.Point(6, 26);
            this.rad_native.Name = "rad_native";
            this.rad_native.Size = new System.Drawing.Size(73, 22);
            this.rad_native.TabIndex = 7;
            this.rad_native.TabStop = true;
            this.rad_native.Text = "native";
            this.rad_native.UseVisualStyleBackColor = true;
            // 
            // butt_send
            // 
            this.butt_send.BackColor = System.Drawing.SystemColors.Info;
            this.butt_send.Location = new System.Drawing.Point(53, 114);
            this.butt_send.Name = "butt_send";
            this.butt_send.Size = new System.Drawing.Size(40, 22);
            this.butt_send.TabIndex = 8;
            this.butt_send.Text = "send";
            this.butt_send.UseVisualStyleBackColor = false;
            // 
            // butt_teach
            // 
            this.butt_teach.Location = new System.Drawing.Point(223, 274);
            this.butt_teach.Name = "butt_teach";
            this.butt_teach.Size = new System.Drawing.Size(100, 42);
            this.butt_teach.TabIndex = 9;
            this.butt_teach.Text = "TEACH";
            this.butt_teach.UseVisualStyleBackColor = true;
            // 
            // text_before
            // 
            this.text_before.BackColor = System.Drawing.SystemColors.HighlightText;
            this.text_before.Location = new System.Drawing.Point(12, 49);
            this.text_before.Multiline = true;
            this.text_before.Name = "text_before";
            this.text_before.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_before.Size = new System.Drawing.Size(188, 267);
            this.text_before.TabIndex = 11;
            // 
            // text_after
            // 
            this.text_after.BackColor = System.Drawing.SystemColors.Info;
            this.text_after.Location = new System.Drawing.Point(348, 49);
            this.text_after.Multiline = true;
            this.text_after.Name = "text_after";
            this.text_after.ReadOnly = true;
            this.text_after.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_after.Size = new System.Drawing.Size(188, 267);
            this.text_after.TabIndex = 12;
            // 
            // group_his_ability
            // 
            this.group_his_ability.Controls.Add(this.rad_alien);
            this.group_his_ability.Controls.Add(this.rad_native);
            this.group_his_ability.Controls.Add(this.rad_nonnative);
            this.group_his_ability.Controls.Add(this.butt_send);
            this.group_his_ability.Location = new System.Drawing.Point(223, 109);
            this.group_his_ability.Name = "group_his_ability";
            this.group_his_ability.Size = new System.Drawing.Size(99, 148);
            this.group_his_ability.TabIndex = 13;
            this.group_his_ability.TabStop = false;
            this.group_his_ability.Text = "His Ability";
            // 
            // link_occ
            // 
            this.link_occ.AutoSize = true;
            this.link_occ.Location = new System.Drawing.Point(404, 330);
            this.link_occ.Name = "link_occ";
            this.link_occ.Size = new System.Drawing.Size(132, 12);
            this.link_occ.TabIndex = 14;
            this.link_occ.TabStop = true;
            this.link_occ.Text = "© 2014 OCC Corporation";
            this.link_occ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_occ_LinkClicked);
            // 
            // frm_AIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 355);
            this.Controls.Add(this.link_occ);
            this.Controls.Add(this.group_his_ability);
            this.Controls.Add(this.text_after);
            this.Controls.Add(this.text_before);
            this.Controls.Add(this.butt_teach);
            this.Controls.Add(this.comb_after);
            this.Controls.Add(this.comb_before);
            this.Controls.Add(this.butt_translate);
            this.Name = "frm_AIT";
            this.Text = "AIT";
            this.group_his_ability.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.Button butt_send;
		private System.Windows.Forms.RadioButton rad_native;
		private System.Windows.Forms.RadioButton rad_nonnative;
		private System.Windows.Forms.RadioButton rad_alien;
		private System.Windows.Forms.ComboBox comb_after;
		private System.Windows.Forms.ComboBox comb_before;
        private System.Windows.Forms.Button butt_translate;
        private System.Windows.Forms.Button butt_teach;
        private System.Windows.Forms.TextBox text_before;
        private System.Windows.Forms.TextBox text_after;
        private System.Windows.Forms.GroupBox group_his_ability;
        private System.Windows.Forms.LinkLabel link_occ;
	}
}
