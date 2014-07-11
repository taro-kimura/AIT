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
	partial class MainForm
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
            this.lab_before = new System.Windows.Forms.Label();
            this.lab_after = new System.Windows.Forms.Label();
            this.butt_translate = new System.Windows.Forms.Button();
            this.comb_before = new System.Windows.Forms.ComboBox();
            this.comb_after = new System.Windows.Forms.ComboBox();
            this.rad_alien = new System.Windows.Forms.RadioButton();
            this.rad_nonnative = new System.Windows.Forms.RadioButton();
            this.rad_native = new System.Windows.Forms.RadioButton();
            this.butt_value = new System.Windows.Forms.Button();
            this.butt_teach = new System.Windows.Forms.Button();
            this.pic_occ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_occ)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_before
            // 
            this.lab_before.BackColor = System.Drawing.SystemColors.Window;
            this.lab_before.Location = new System.Drawing.Point(12, 51);
            this.lab_before.Name = "lab_before";
            this.lab_before.Size = new System.Drawing.Size(188, 279);
            this.lab_before.TabIndex = 0;
            // 
            // lab_after
            // 
            this.lab_after.BackColor = System.Drawing.SystemColors.Window;
            this.lab_after.Location = new System.Drawing.Point(343, 51);
            this.lab_after.Name = "lab_after";
            this.lab_after.Size = new System.Drawing.Size(188, 279);
            this.lab_after.TabIndex = 1;
            // 
            // butt_translate
            // 
            this.butt_translate.Location = new System.Drawing.Point(222, 129);
            this.butt_translate.Name = "butt_translate";
            this.butt_translate.Size = new System.Drawing.Size(100, 42);
            this.butt_translate.TabIndex = 2;
            this.butt_translate.Text = "TRANSLATE";
            this.butt_translate.UseVisualStyleBackColor = true;
            // 
            // comb_before
            // 
            this.comb_before.FormattingEnabled = true;
            this.comb_before.Location = new System.Drawing.Point(12, 12);
            this.comb_before.Name = "comb_before";
            this.comb_before.Size = new System.Drawing.Size(188, 20);
            this.comb_before.TabIndex = 3;
            // 
            // comb_after
            // 
            this.comb_after.FormattingEnabled = true;
            this.comb_after.Location = new System.Drawing.Point(343, 12);
            this.comb_after.Name = "comb_after";
            this.comb_after.Size = new System.Drawing.Size(188, 20);
            this.comb_after.TabIndex = 4;
            // 
            // rad_alien
            // 
            this.rad_alien.Location = new System.Drawing.Point(222, 249);
            this.rad_alien.Name = "rad_alien";
            this.rad_alien.Size = new System.Drawing.Size(100, 24);
            this.rad_alien.TabIndex = 5;
            this.rad_alien.TabStop = true;
            this.rad_alien.Text = "alien";
            this.rad_alien.UseVisualStyleBackColor = true;
            // 
            // rad_nonnative
            // 
            this.rad_nonnative.Location = new System.Drawing.Point(222, 219);
            this.rad_nonnative.Name = "rad_nonnative";
            this.rad_nonnative.Size = new System.Drawing.Size(100, 24);
            this.rad_nonnative.TabIndex = 6;
            this.rad_nonnative.TabStop = true;
            this.rad_nonnative.Text = "non-native";
            this.rad_nonnative.UseVisualStyleBackColor = true;
            // 
            // rad_native
            // 
            this.rad_native.Location = new System.Drawing.Point(222, 189);
            this.rad_native.Name = "rad_native";
            this.rad_native.Size = new System.Drawing.Size(100, 24);
            this.rad_native.TabIndex = 7;
            this.rad_native.TabStop = true;
            this.rad_native.Text = "native";
            this.rad_native.UseVisualStyleBackColor = true;
            // 
            // butt_value
            // 
            this.butt_value.Location = new System.Drawing.Point(222, 289);
            this.butt_value.Name = "butt_value";
            this.butt_value.Size = new System.Drawing.Size(100, 41);
            this.butt_value.TabIndex = 8;
            this.butt_value.Text = "VALUE";
            this.butt_value.UseVisualStyleBackColor = true;
            // 
            // butt_teach
            // 
            this.butt_teach.Location = new System.Drawing.Point(222, 12);
            this.butt_teach.Name = "butt_teach";
            this.butt_teach.Size = new System.Drawing.Size(100, 42);
            this.butt_teach.TabIndex = 9;
            this.butt_teach.Text = "TEACH";
            this.butt_teach.UseVisualStyleBackColor = true;
            // 
            // pic_occ
            // 
            this.pic_occ.ImageLocation = ".\\img\\occ.jpg";
            this.pic_occ.Location = new System.Drawing.Point(222, 69);
            this.pic_occ.Name = "pic_occ";
            this.pic_occ.Size = new System.Drawing.Size(100, 45);
            this.pic_occ.TabIndex = 10;
            this.pic_occ.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 343);
            this.Controls.Add(this.pic_occ);
            this.Controls.Add(this.butt_teach);
            this.Controls.Add(this.butt_value);
            this.Controls.Add(this.rad_native);
            this.Controls.Add(this.rad_nonnative);
            this.Controls.Add(this.rad_alien);
            this.Controls.Add(this.comb_after);
            this.Controls.Add(this.comb_before);
            this.Controls.Add(this.butt_translate);
            this.Controls.Add(this.lab_after);
            this.Controls.Add(this.lab_before);
            this.Name = "MainForm";
            this.Text = "AIT";
            ((System.ComponentModel.ISupportInitialize)(this.pic_occ)).EndInit();
            this.ResumeLayout(false);

        }
		private System.Windows.Forms.Button butt_value;
		private System.Windows.Forms.RadioButton rad_native;
		private System.Windows.Forms.RadioButton rad_nonnative;
		private System.Windows.Forms.RadioButton rad_alien;
		private System.Windows.Forms.ComboBox comb_after;
		private System.Windows.Forms.ComboBox comb_before;
		private System.Windows.Forms.Button butt_translate;
		private System.Windows.Forms.Label lab_after;
		private System.Windows.Forms.Label lab_before;
        private System.Windows.Forms.Button butt_teach;
        private System.Windows.Forms.PictureBox pic_occ;
	}
}
