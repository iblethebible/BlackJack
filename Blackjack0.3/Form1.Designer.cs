
namespace Blackjack0._3
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
            this.buttonDeal = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStick = new System.Windows.Forms.Button();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.textBoxPlayerHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(250, 265);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(273, 103);
            this.buttonDeal.TabIndex = 0;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(70, 265);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(273, 103);
            this.buttonHit.TabIndex = 1;
            this.buttonHit.Text = "Hit Me";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Visible = false;
            // 
            // buttonStick
            // 
            this.buttonStick.Location = new System.Drawing.Point(437, 265);
            this.buttonStick.Name = "buttonStick";
            this.buttonStick.Size = new System.Drawing.Size(273, 103);
            this.buttonStick.TabIndex = 2;
            this.buttonStick.Text = "Stick";
            this.buttonStick.UseVisualStyleBackColor = true;
            this.buttonStick.Visible = false;
            // 
            // labelUserScore
            // 
            this.labelUserScore.AutoSize = true;
            this.labelUserScore.Location = new System.Drawing.Point(170, 143);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(0, 13);
            this.labelUserScore.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dealer Score:";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(239, 386);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(309, 53);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.Location = new System.Drawing.Point(572, 141);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(0, 13);
            this.labelDealerScore.TabIndex = 8;
            // 
            // textBoxPlayerHistory
            // 
            this.textBoxPlayerHistory.Location = new System.Drawing.Point(45, 21);
            this.textBoxPlayerHistory.Multiline = true;
            this.textBoxPlayerHistory.Name = "textBoxPlayerHistory";
            this.textBoxPlayerHistory.Size = new System.Drawing.Size(155, 99);
            this.textBoxPlayerHistory.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPlayerHistory);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserScore);
            this.Controls.Add(this.buttonStick);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.buttonDeal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStick;
        private System.Windows.Forms.Label labelUserScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.TextBox textBoxPlayerHistory;
    }
}

