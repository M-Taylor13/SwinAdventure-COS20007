namespace SwinAdventure
{
    partial class Gui
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
            this.CmdText = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.LookBtn = new System.Windows.Forms.Button();
            this.InvBtn = new System.Windows.Forms.Button();
            this.NorthBtn = new System.Windows.Forms.Button();
            this.EastBtn = new System.Windows.Forms.Button();
            this.SouthBtn = new System.Windows.Forms.Button();
            this.WestBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdText
            // 
            this.CmdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CmdText.Location = new System.Drawing.Point(28, 379);
            this.CmdText.Name = "CmdText";
            this.CmdText.Size = new System.Drawing.Size(525, 39);
            this.CmdText.TabIndex = 0;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(588, 379);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(174, 39);
            this.EnterBtn.TabIndex = 1;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // LookBtn
            // 
            this.LookBtn.Location = new System.Drawing.Point(588, 237);
            this.LookBtn.Name = "LookBtn";
            this.LookBtn.Size = new System.Drawing.Size(174, 117);
            this.LookBtn.TabIndex = 2;
            this.LookBtn.Text = "Look";
            this.LookBtn.UseVisualStyleBackColor = true;
            this.LookBtn.Click += new System.EventHandler(this.LookBtn_Click);
            // 
            // InvBtn
            // 
            this.InvBtn.Location = new System.Drawing.Point(588, 99);
            this.InvBtn.Name = "InvBtn";
            this.InvBtn.Size = new System.Drawing.Size(174, 119);
            this.InvBtn.TabIndex = 3;
            this.InvBtn.Text = "Inventory";
            this.InvBtn.UseVisualStyleBackColor = true;
            this.InvBtn.Click += new System.EventHandler(this.InvBtn_Click);
            // 
            // NorthBtn
            // 
            this.NorthBtn.Location = new System.Drawing.Point(206, 99);
            this.NorthBtn.Name = "NorthBtn";
            this.NorthBtn.Size = new System.Drawing.Size(165, 81);
            this.NorthBtn.TabIndex = 4;
            this.NorthBtn.Text = "Up";
            this.NorthBtn.UseVisualStyleBackColor = true;
            this.NorthBtn.Click += new System.EventHandler(this.NorthBtn_Click);
            // 
            // EastBtn
            // 
            this.EastBtn.Location = new System.Drawing.Point(377, 186);
            this.EastBtn.Name = "EastBtn";
            this.EastBtn.Size = new System.Drawing.Size(174, 81);
            this.EastBtn.TabIndex = 5;
            this.EastBtn.Text = "Right";
            this.EastBtn.UseVisualStyleBackColor = true;
            this.EastBtn.Click += new System.EventHandler(this.EastBtn_Click);
            // 
            // SouthBtn
            // 
            this.SouthBtn.Location = new System.Drawing.Point(206, 273);
            this.SouthBtn.Name = "SouthBtn";
            this.SouthBtn.Size = new System.Drawing.Size(165, 81);
            this.SouthBtn.TabIndex = 5;
            this.SouthBtn.Text = "Down";
            this.SouthBtn.UseVisualStyleBackColor = true;
            this.SouthBtn.Click += new System.EventHandler(this.SouthBtn_Click);
            // 
            // WestBtn
            // 
            this.WestBtn.Location = new System.Drawing.Point(28, 186);
            this.WestBtn.Name = "WestBtn";
            this.WestBtn.Size = new System.Drawing.Size(174, 81);
            this.WestBtn.TabIndex = 6;
            this.WestBtn.Text = "Left";
            this.WestBtn.UseVisualStyleBackColor = true;
            this.WestBtn.Click += new System.EventHandler(this.WestBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(24, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(375, 59);
            this.Title.TabIndex = 7;
            this.Title.Text = "SwinAdventure";
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CommandLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CommandLabel.Location = new System.Drawing.Point(23, 351);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(109, 25);
            this.CommandLabel.TabIndex = 8;
            this.CommandLabel.Text = "Command:";
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(588, 19);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(174, 49);
            this.QuitBtn.TabIndex = 9;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.WestBtn);
            this.Controls.Add(this.SouthBtn);
            this.Controls.Add(this.EastBtn);
            this.Controls.Add(this.NorthBtn);
            this.Controls.Add(this.InvBtn);
            this.Controls.Add(this.LookBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.CmdText);
            this.Location = new System.Drawing.Point(500, 250);
            this.Name = "Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SwinAdventure Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CmdText;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button LookBtn;
        private System.Windows.Forms.Button InvBtn;
        private System.Windows.Forms.Button NorthBtn;
        private System.Windows.Forms.Button EastBtn;
        private System.Windows.Forms.Button SouthBtn;
        private System.Windows.Forms.Button WestBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.Button QuitBtn;
    }
}