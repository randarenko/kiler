namespace kiler
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bydloBliat = new System.Windows.Forms.ComboBox();
			this.suka = new System.Windows.Forms.ComboBox();
			this.udar = new System.Windows.Forms.Button();
			this.miska = new System.Windows.Forms.Button();
			this.polozhi = new System.Windows.Forms.ListView();
			this.sterzhen = new System.Windows.Forms.Button();
			this.dosviazi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bydloBliat
			// 
			this.bydloBliat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.bydloBliat.FormattingEnabled = true;
			this.bydloBliat.Location = new System.Drawing.Point(22, 42);
			this.bydloBliat.Name = "bydloBliat";
			this.bydloBliat.Size = new System.Drawing.Size(166, 150);
			this.bydloBliat.TabIndex = 1;
			this.bydloBliat.TextChanged += new System.EventHandler(this.bydloBliat_TextChanged);
			// 
			// suka
			// 
			this.suka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.suka.FormattingEnabled = true;
			this.suka.Location = new System.Drawing.Point(22, 207);
			this.suka.Name = "suka";
			this.suka.Size = new System.Drawing.Size(166, 150);
			this.suka.TabIndex = 2;
			// 
			// udar
			// 
			this.udar.BackgroundImage = global::kiler.Properties.Resources.xi;
			this.udar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.udar.ImageKey = "(none)";
			this.udar.Location = new System.Drawing.Point(211, 42);
			this.udar.Name = "udar";
			this.udar.Size = new System.Drawing.Size(92, 48);
			this.udar.TabIndex = 3;
			this.udar.Text = "УДАР!";
			this.udar.UseVisualStyleBackColor = true;
			this.udar.Click += new System.EventHandler(this.udar_Click);
			// 
			// miska
			// 
			this.miska.Location = new System.Drawing.Point(211, 205);
			this.miska.Name = "miska";
			this.miska.Size = new System.Drawing.Size(75, 23);
			this.miska.TabIndex = 3;
			this.miska.Text = "Миска риса";
			this.miska.UseVisualStyleBackColor = true;
			this.miska.Click += new System.EventHandler(this.miska_Click);
			// 
			// polozhi
			// 
			this.polozhi.HideSelection = false;
			this.polozhi.Location = new System.Drawing.Point(520, 42);
			this.polozhi.Name = "polozhi";
			this.polozhi.Size = new System.Drawing.Size(302, 473);
			this.polozhi.TabIndex = 4;
			this.polozhi.UseCompatibleStateImageBehavior = false;
			// 
			// sterzhen
			// 
			this.sterzhen.BackgroundImage = global::kiler.Properties.Resources.xi;
			this.sterzhen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.sterzhen.ImageKey = "(none)";
			this.sterzhen.Location = new System.Drawing.Point(520, 521);
			this.sterzhen.Name = "sterzhen";
			this.sterzhen.Size = new System.Drawing.Size(302, 33);
			this.sterzhen.TabIndex = 3;
			this.sterzhen.Text = "УДАР!";
			this.sterzhen.UseVisualStyleBackColor = true;
			this.sterzhen.Click += new System.EventHandler(this.sterzhen_Click);
			// 
			// dosviazi
			// 
			this.dosviazi.Location = new System.Drawing.Point(636, 560);
			this.dosviazi.Name = "dosviazi";
			this.dosviazi.Size = new System.Drawing.Size(75, 23);
			this.dosviazi.TabIndex = 3;
			this.dosviazi.Text = "Миска риса";
			this.dosviazi.UseVisualStyleBackColor = true;
			this.dosviazi.Click += new System.EventHandler(this.dosviazi_click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::kiler.Properties.Resources.photo_2022_01_11_20_09_03;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(874, 612);
			this.Controls.Add(this.polozhi);
			this.Controls.Add(this.dosviazi);
			this.Controls.Add(this.miska);
			this.Controls.Add(this.sterzhen);
			this.Controls.Add(this.udar);
			this.Controls.Add(this.suka);
			this.Controls.Add(this.bydloBliat);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox bydloBliat;
		private System.Windows.Forms.ComboBox suka;
		private System.Windows.Forms.Button udar;
		private System.Windows.Forms.Button miska;
		private System.Windows.Forms.ListView polozhi;
		private System.Windows.Forms.Button sterzhen;
		private System.Windows.Forms.Button dosviazi;
	}
}

