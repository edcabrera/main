namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pingButton = new System.Windows.Forms.PictureBox();
            this.pingLabel = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pingButton
            // 
            this.pingButton.BackColor = System.Drawing.Color.Transparent;
            this.pingButton.Location = new System.Drawing.Point(35, 51);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(140, 56);
            this.pingButton.TabIndex = 0;
            this.pingButton.TabStop = false;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            this.pingButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pingButton_MouseDown);
            this.pingButton.MouseEnter += new System.EventHandler(this.pingButton_MouseEnter);
            this.pingButton.MouseLeave += new System.EventHandler(this.pingButton_MouseLeave);
            this.pingButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pingButton_MouseUp);
            // 
            // pingLabel
            // 
            this.pingLabel.BackColor = System.Drawing.Color.Transparent;
            this.pingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pingLabel.Location = new System.Drawing.Point(92, 22);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(83, 13);
            this.pingLabel.TabIndex = 1;
            this.pingLabel.Text = "Click to Ping";
            this.pingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Server
            // 
            this.Server.AllowDrop = true;
            this.Server.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server.ForeColor = System.Drawing.SystemColors.Info;
            this.Server.FormattingEnabled = true;
            this.Server.Items.AddRange(new object[] {
            "NA",
            "EUW",
            "LAN",
            "LAS"});
            this.Server.Location = new System.Drawing.Point(31, 18);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(55, 21);
            this.Server.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.about;
            this.pictureBox1.Location = new System.Drawing.Point(182, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(204, 120);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.pingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ping of Legends";
            ((System.ComponentModel.ISupportInitialize)(this.pingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pingButton;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.ComboBox Server;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

