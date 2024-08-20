namespace Convenience
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CU = new System.Windows.Forms.Button();
            this.btn_GS = new System.Windows.Forms.Button();
            this.btn_SEVEN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // btn_CU
            // 
            this.btn_CU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CU.BackgroundImage")));
            this.btn_CU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CU.Font = new System.Drawing.Font("문체부 제목 돋음체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CU.Location = new System.Drawing.Point(111, 92);
            this.btn_CU.Name = "btn_CU";
            this.btn_CU.Size = new System.Drawing.Size(127, 295);
            this.btn_CU.TabIndex = 1;
            this.btn_CU.Text = "CU";
            this.btn_CU.UseVisualStyleBackColor = true;
            this.btn_CU.Click += new System.EventHandler(this.btn_CU_Click);
            // 
            // btn_GS
            // 
            this.btn_GS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GS.BackgroundImage")));
            this.btn_GS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GS.Font = new System.Drawing.Font("문체부 돋음체", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GS.Location = new System.Drawing.Point(327, 84);
            this.btn_GS.Name = "btn_GS";
            this.btn_GS.Size = new System.Drawing.Size(131, 295);
            this.btn_GS.TabIndex = 2;
            this.btn_GS.Text = "GS";
            this.btn_GS.UseVisualStyleBackColor = true;
            this.btn_GS.Click += new System.EventHandler(this.btn_GS_Click);
            // 
            // btn_SEVEN
            // 
            this.btn_SEVEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SEVEN.BackgroundImage")));
            this.btn_SEVEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SEVEN.Font = new System.Drawing.Font("문체부 돋음체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SEVEN.Location = new System.Drawing.Point(548, 84);
            this.btn_SEVEN.Name = "btn_SEVEN";
            this.btn_SEVEN.Size = new System.Drawing.Size(121, 295);
            this.btn_SEVEN.TabIndex = 3;
            this.btn_SEVEN.Text = "SEVEN";
            this.btn_SEVEN.UseVisualStyleBackColor = true;
            this.btn_SEVEN.Click += new System.EventHandler(this.btn_SEVEN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "소속 브랜드를 선정해주세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SEVEN);
            this.Controls.Add(this.btn_GS);
            this.Controls.Add(this.btn_CU);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CU;
        private System.Windows.Forms.Button btn_GS;
        private System.Windows.Forms.Button btn_SEVEN;
        private System.Windows.Forms.Label label2;
    }
}

