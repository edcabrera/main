namespace WindowsFormsApplication1
{
    partial class about
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.Button();
            this.donate_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by: Eduardo Cabrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Twitter:";
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(40, 28);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(126, 23);
            this.twitter.TabIndex = 2;
            this.twitter.Text = "Follow @LoLInflames";
            this.twitter.UseVisualStyleBackColor = true;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // donate_button
            // 
            this.donate_button.Location = new System.Drawing.Point(4, 73);
            this.donate_button.Name = "donate_button";
            this.donate_button.Size = new System.Drawing.Size(164, 33);
            this.donate_button.TabIndex = 3;
            this.donate_button.Text = "Donate";
            this.donate_button.UseVisualStyleBackColor = true;
            this.donate_button.Click += new System.EventHandler(this.donate_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contributions appreciated";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 112);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.donate_button);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "about";
            this.Text = "about";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button twitter;
        private System.Windows.Forms.Button donate_button;
        private System.Windows.Forms.Label label3;
    }
}