namespace FlashCards
{
    partial class FlashCardsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.DivideRadio = new System.Windows.Forms.RadioButton();
            this.MultiplyRadio = new System.Windows.Forms.RadioButton();
            this.SubtractRadio = new System.Windows.Forms.RadioButton();
            this.AddRadio = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(227, 210);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(184, 17);
            this.AnswerLabel.TabIndex = 34;
            this.AnswerLabel.Text = "Click the Play button to start";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(204, 89);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(198, 46);
            this.QuestionLabel.TabIndex = 33;
            this.QuestionLabel.Text = "99 + 99 = ";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(229, 153);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 39);
            this.PlayButton.TabIndex = 32;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(427, 89);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 53);
            this.AnswerTextBox.TabIndex = 31;
            // 
            // DivideRadio
            // 
            this.DivideRadio.AutoSize = true;
            this.DivideRadio.Location = new System.Drawing.Point(48, 208);
            this.DivideRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DivideRadio.Name = "DivideRadio";
            this.DivideRadio.Size = new System.Drawing.Size(68, 21);
            this.DivideRadio.TabIndex = 30;
            this.DivideRadio.Text = "Divide";
            this.DivideRadio.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadio
            // 
            this.MultiplyRadio.AutoSize = true;
            this.MultiplyRadio.Location = new System.Drawing.Point(48, 178);
            this.MultiplyRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MultiplyRadio.Name = "MultiplyRadio";
            this.MultiplyRadio.Size = new System.Drawing.Size(76, 21);
            this.MultiplyRadio.TabIndex = 29;
            this.MultiplyRadio.Text = "Multiply";
            this.MultiplyRadio.UseVisualStyleBackColor = true;
            // 
            // SubtractRadio
            // 
            this.SubtractRadio.AutoSize = true;
            this.SubtractRadio.Location = new System.Drawing.Point(48, 151);
            this.SubtractRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubtractRadio.Name = "SubtractRadio";
            this.SubtractRadio.Size = new System.Drawing.Size(82, 21);
            this.SubtractRadio.TabIndex = 28;
            this.SubtractRadio.Text = "Subtract";
            this.SubtractRadio.UseVisualStyleBackColor = true;
            // 
            // AddRadio
            // 
            this.AddRadio.AutoSize = true;
            this.AddRadio.Checked = true;
            this.AddRadio.Location = new System.Drawing.Point(48, 124);
            this.AddRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRadio.Name = "AddRadio";
            this.AddRadio.Size = new System.Drawing.Size(54, 21);
            this.AddRadio.TabIndex = 27;
            this.AddRadio.TabStop = true;
            this.AddRadio.Text = "Add";
            this.AddRadio.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(106, 17);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Do you want to:";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(19, 34);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(145, 46);
            this.WelcomeLabel.TabIndex = 25;
            this.WelcomeLabel.Text = "Hello...";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(404, 270);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(115, 31);
            this.ScoreLabel.TabIndex = 35;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // FlashCardsForm
            // 
            this.AcceptButton = this.PlayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 313);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.DivideRadio);
            this.Controls.Add(this.MultiplyRadio);
            this.Controls.Add(this.SubtractRadio);
            this.Controls.Add(this.AddRadio);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FlashCardsForm";
            this.Text = "Welcome to Flash Cards";
            this.Load += new System.EventHandler(this.FlashCardsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.Label AnswerLabel;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.Label QuestionLabel;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.Button PlayButton;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.TextBox AnswerTextBox;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.RadioButton DivideRadio;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.RadioButton MultiplyRadio;
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.RadioButton SubtractRadio;
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.RadioButton AddRadio;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.Label Label1;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        internal System.Windows.Forms.Label WelcomeLabel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStrip1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.Label ScoreLabel;
    }
}