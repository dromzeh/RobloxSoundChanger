namespace RobloxSoundChanger
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
            this.updateButton = new System.Windows.Forms.Button();
            this.autoLocateButton = new System.Windows.Forms.Button();
            this.mp3fileBtn = new System.Windows.Forms.Button();
            this.robloxLocationBtn = new System.Windows.Forms.Button();
            this.githubLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(466, 137);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(108, 55);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update Audio";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // autoLocateButton
            // 
            this.autoLocateButton.Location = new System.Drawing.Point(354, 137);
            this.autoLocateButton.Name = "autoLocateButton";
            this.autoLocateButton.Size = new System.Drawing.Size(108, 55);
            this.autoLocateButton.TabIndex = 1;
            this.autoLocateButton.Text = "Automatically Locate Roblox Installation";
            this.autoLocateButton.UseVisualStyleBackColor = true;
            this.autoLocateButton.Click += new System.EventHandler(this.autoLocateButton_Click);
            // 
            // mp3fileBtn
            // 
            this.mp3fileBtn.Location = new System.Drawing.Point(12, 21);
            this.mp3fileBtn.Name = "mp3fileBtn";
            this.mp3fileBtn.Size = new System.Drawing.Size(562, 39);
            this.mp3fileBtn.TabIndex = 2;
            this.mp3fileBtn.Text = "Select OGG file to replace death sound with";
            this.mp3fileBtn.UseVisualStyleBackColor = true;
            this.mp3fileBtn.Click += new System.EventHandler(this.mp3fileBtn_Click);
            // 
            // robloxLocationBtn
            // 
            this.robloxLocationBtn.Location = new System.Drawing.Point(12, 76);
            this.robloxLocationBtn.Name = "robloxLocationBtn";
            this.robloxLocationBtn.Size = new System.Drawing.Size(562, 39);
            this.robloxLocationBtn.TabIndex = 3;
            this.robloxLocationBtn.Text = "Select Roblox Version Location";
            this.robloxLocationBtn.UseVisualStyleBackColor = true;
            this.robloxLocationBtn.Click += new System.EventHandler(this.robloxLocationBtn_Click);
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(12, 179);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(241, 13);
            this.githubLabel.TabIndex = 4;
            this.githubLabel.Text = "https://github.com/dromzeh/robloxsoundchanger";
            this.githubLabel.Click += new System.EventHandler(this.githubLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "OGG File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roblox Version Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.robloxLocationBtn);
            this.Controls.Add(this.mp3fileBtn);
            this.Controls.Add(this.autoLocateButton);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Roblox Sound Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button autoLocateButton;
        private System.Windows.Forms.Button mp3fileBtn;
        private System.Windows.Forms.Button robloxLocationBtn;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

