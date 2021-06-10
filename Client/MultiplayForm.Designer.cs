
namespace Client
{
    partial class MultiplayForm
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
            this.boardPicture = new System.Windows.Forms.PictureBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPicture
            // 
            this.boardPicture.BackColor = System.Drawing.SystemColors.Info;
            this.boardPicture.Location = new System.Drawing.Point(12, 12);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(500, 500);
            this.boardPicture.TabIndex = 0;
            this.boardPicture.TabStop = false;
            this.boardPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture_Paint);
            this.boardPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown);
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(518, 30);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(174, 28);
            this.roomTextBox.TabIndex = 1;
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(707, 30);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(118, 28);
            this.enterbutton.TabIndex = 2;
            this.enterbutton.Text = "접속하기";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(640, 88);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "게임시작";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(553, 164);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(272, 20);
            this.status.TabIndex = 4;
            this.status.Text = "방을 입력해 접속해 주세요";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 521);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.boardPicture);
            this.Name = "MultiplayForm";
            this.Text = "MultiplayForm";
            this.Load += new System.EventHandler(this.mutiplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPicture;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
    }
}