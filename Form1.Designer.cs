namespace gynvael_misja_008
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 789);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(293, 1);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(194, 42);
            this.buttonN.TabIndex = 2;
            this.buttonN.TabStop = false;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(293, 49);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(194, 42);
            this.buttonS.TabIndex = 3;
            this.buttonS.TabStop = false;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(93, 24);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(194, 42);
            this.buttonW.TabIndex = 4;
            this.buttonW.TabStop = false;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(493, 24);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(194, 42);
            this.buttonE.TabIndex = 5;
            this.buttonE.TabStop = false;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 885);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonE;
    }
}

