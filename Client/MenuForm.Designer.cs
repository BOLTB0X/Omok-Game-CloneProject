
namespace Client
{
    partial class MenuForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.singlePlayButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.exitButton = new System.Windows.Forms.Button();
            this.mutiplayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singlePlayButton
            // 
            this.singlePlayButton.Location = new System.Drawing.Point(241, 62);
            this.singlePlayButton.Name = "singlePlayButton";
            this.singlePlayButton.Size = new System.Drawing.Size(100, 50);
            this.singlePlayButton.TabIndex = 0;
            this.singlePlayButton.Text = "혼자하기";
            this.singlePlayButton.UseVisualStyleBackColor = true;
            this.singlePlayButton.Click += new System.EventHandler(this.singlePlayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(241, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "끝내기";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mutiplayButton
            // 
            this.mutiplayButton.Location = new System.Drawing.Point(241, 155);
            this.mutiplayButton.Name = "mutiplayButton";
            this.mutiplayButton.Size = new System.Drawing.Size(100, 50);
            this.mutiplayButton.TabIndex = 2;
            this.mutiplayButton.Text = "함께하기";
            this.mutiplayButton.UseVisualStyleBackColor = true;
            this.mutiplayButton.Click += new System.EventHandler(this.mutiplayButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.mutiplayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.singlePlayButton);
            this.Name = "MenuForm";
            this.Text = "Omok game project";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singlePlayButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mutiplayButton;
    }
}

