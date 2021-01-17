using System;

namespace UyghurEditPP
{
	/// <summary>
	/// Summary description for UyghurEditHeqqide.
	/// </summary>
	public class FormHeqqide : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;

		public FormHeqqide()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeqqide));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(95, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(126, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(341, 30);
			this.label4.TabIndex = 5;
			this.label4.Text = "Gheyret T. Kenji";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("UKIJ Tuz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(126, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "UyghurEdit++ Version ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("UKIJ Tuz", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(126, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(341, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "2021/01/01";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(126, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(341, 30);
			this.label5.TabIndex = 6;
			this.label5.Text = "gheyret@gmail.com";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(426, 34);
			this.label3.TabIndex = 7;
			this.label3.Text = "Buningda towendiki Ochuq Kodlar ishlitildi ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			                                                              | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Location = new System.Drawing.Point(1, 161);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(473, 3);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(38, 200);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(436, 23);
			this.linkLabel1.TabIndex = 10;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://github.com/icsharpcode/AvalonEdit";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(38, 225);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(436, 23);
			this.linkLabel2.TabIndex = 11;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "https://github.com/wolfgarbe/SymSpell";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Location = new System.Drawing.Point(38, 250);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(436, 23);
			this.linkLabel3.TabIndex = 12;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "https://github.com/fujieda/DynaJson";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// FormHeqqide
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(479, 326);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("UKIJ Tuz", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormHeqqide";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UyghurEdit++";
			this.Load += new System.EventHandler(this.FormHeqqideLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		void FormHeqqideLoad(object sender, EventArgs e)
		{
			label1.Text = "UyghurEdit++ Version " + MainForm.GetVersion();
			label3.Text = MainForm.gLang.GetText("Buningda töwendiki Ochuq Kodlar ishlitildi");
		}
		
		void LinkLabel1LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.LinkLabel link = sender as System.Windows.Forms.LinkLabel;
			if(link!=null){
				// Specify that the link was visited.
				link.LinkVisited = true;
				System.Diagnostics.Process.Start(link.Text);
			}
		}
		#endregion
	}
}