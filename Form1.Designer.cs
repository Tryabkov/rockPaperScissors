
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
            this.BRock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BPaper = new System.Windows.Forms.Button();
            this.BScissors = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbYourMove = new System.Windows.Forms.Label();
            this.lbEnemyMove = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRock
            // 
            this.BRock.AutoSize = true;
            this.BRock.Image = global::rockPaperScissors.Properties.Resources.rock;
            this.BRock.Location = new System.Drawing.Point(12, 188);
            this.BRock.Name = "BRock";
            this.BRock.Size = new System.Drawing.Size(256, 250);
            this.BRock.TabIndex = 0;
            this.BRock.UseVisualStyleBackColor = true;
            this.BRock.Click += new System.EventHandler(this.BRock_Click);
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
            // BPaper
            // 
            this.BPaper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BPaper.Image = global::rockPaperScissors.Properties.Resources.paper;
            this.BPaper.Location = new System.Drawing.Point(274, 188);
            this.BPaper.Name = "BPaper";
            this.BPaper.Size = new System.Drawing.Size(250, 250);
            this.BPaper.TabIndex = 3;
            this.BPaper.UseVisualStyleBackColor = true;
            this.BPaper.Click += new System.EventHandler(this.BPaper_Click);
            // 
            // BScissors
            // 
            this.BScissors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BScissors.Image = global::rockPaperScissors.Properties.Resources.scissors;
            this.BScissors.Location = new System.Drawing.Point(530, 188);
            this.BScissors.Name = "BScissors";
            this.BScissors.Size = new System.Drawing.Size(250, 250);
            this.BScissors.TabIndex = 4;
            this.BScissors.UseVisualStyleBackColor = true;
            this.BScissors.Click += new System.EventHandler(this.BScissors_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbYourMove);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbEnemyMove);
            this.splitContainer1.Size = new System.Drawing.Size(786, 41);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 5;
            // 
            // lbYourMove
            // 
            this.lbYourMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbYourMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbYourMove.Location = new System.Drawing.Point(0, 0);
            this.lbYourMove.Name = "lbYourMove";
            this.lbYourMove.Size = new System.Drawing.Size(437, 41);
            this.lbYourMove.TabIndex = 0;
            this.lbYourMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbYourMove.Click += new System.EventHandler(this.lbYourMove_Click);
            // 
            // lbEnemyMove
            // 
            this.lbEnemyMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEnemyMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEnemyMove.Location = new System.Drawing.Point(0, 0);
            this.lbEnemyMove.Name = "lbEnemyMove";
            this.lbEnemyMove.Size = new System.Drawing.Size(345, 41);
            this.lbEnemyMove.TabIndex = 0;
            this.lbEnemyMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(12, 44);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(762, 141);
            this.lbResult.TabIndex = 6;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BScissors);
            this.Controls.Add(this.BPaper);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BPaper;
        private System.Windows.Forms.Button BScissors;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbYourMove;
        private System.Windows.Forms.Label lbEnemyMove;
        private System.Windows.Forms.Label lbResult;
    }
}

