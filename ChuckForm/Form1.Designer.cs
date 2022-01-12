namespace ChuckForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getjokeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getjokeBtn
            // 
            this.getjokeBtn.Location = new System.Drawing.Point(435, 117);
            this.getjokeBtn.Name = "getjokeBtn";
            this.getjokeBtn.Size = new System.Drawing.Size(75, 23);
            this.getjokeBtn.TabIndex = 0;
            this.getjokeBtn.Text = "Get Joke";
            this.getjokeBtn.UseVisualStyleBackColor = true;
            this.getjokeBtn.Click += new System.EventHandler(this.getjokeBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-28, 589);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(435, 185);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(203, 166);
            this.jokeBox.TabIndex = 2;
            this.jokeBox.Text = "Chuck Norris Jokes Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 601);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getjokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getjokeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

