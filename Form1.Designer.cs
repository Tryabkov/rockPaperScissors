
namespace RockPaperScissors
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
            this.RockButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserMoveLabel = new System.Windows.Forms.Label();
            this.programMoveLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.AutoSize = true;
            this.RockButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RockButton.Image = global::rockPaperScissors.Properties.Resources.rock;
            this.RockButton.Location = new System.Drawing.Point(12, 188);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(256, 250);
            this.RockButton.TabIndex = 0;
            this.RockButton.UseVisualStyleBackColor = false;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PaperButton
            // 
            this.PaperButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PaperButton.BackColor = System.Drawing.SystemColors.Control;
            this.PaperButton.Image = global::rockPaperScissors.Properties.Resources.paper;
            this.PaperButton.Location = new System.Drawing.Point(274, 188);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(250, 250);
            this.PaperButton.TabIndex = 3;
            this.PaperButton.UseVisualStyleBackColor = false;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScissorsButton.BackColor = System.Drawing.SystemColors.Control;
            this.ScissorsButton.Image = global::rockPaperScissors.Properties.Resources.scissors;
            this.ScissorsButton.Location = new System.Drawing.Point(530, 188);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(250, 250);
            this.ScissorsButton.TabIndex = 4;
            this.ScissorsButton.UseVisualStyleBackColor = false;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UserMoveLabel);            
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.programMoveLabel);
            this.splitContainer1.Size = new System.Drawing.Size(786, 41);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 5;
            // 
            // lbYourMove
            // 
            this.UserMoveLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserMoveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserMoveLabel.Location = new System.Drawing.Point(0, 0);
            this.UserMoveLabel.Name = "lbYourMove";
            this.UserMoveLabel.Size = new System.Drawing.Size(437, 41);
            this.UserMoveLabel.TabIndex = 0;
            this.UserMoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEnemyMove
            // 
            this.programMoveLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.programMoveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programMoveLabel.Location = new System.Drawing.Point(0, 0);
            this.programMoveLabel.Name = "lbEnemyMove";
            this.programMoveLabel.Size = new System.Drawing.Size(345, 41);
            this.programMoveLabel.TabIndex = 0;
            this.programMoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 44);
            this.resultLabel.Name = "lbResult";
            this.resultLabel.Size = new System.Drawing.Size(762, 141);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RockButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label UserMoveLabel;
        private System.Windows.Forms.Label programMoveLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

