namespace Assambl
{
    partial class Form_UpdateFlag
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
            this.cboVersion = new System.Windows.Forms.ComboBox();
            this.lblversion = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVersion
            // 
            this.cboVersion.FormattingEnabled = true;
            this.cboVersion.Location = new System.Drawing.Point(103, 72);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new System.Drawing.Size(179, 20);
            this.cboVersion.TabIndex = 0;
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(48, 75);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(37, 12);
            this.lblversion.TabIndex = 1;
            this.lblversion.Text = "버전 :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "업데이트";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(179, 123);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(103, 30);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "취소";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form_UpdateFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 227);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.cboVersion);
            this.MaximumSize = new System.Drawing.Size(353, 266);
            this.MinimumSize = new System.Drawing.Size(353, 266);
            this.Name = "Form_UpdateFlag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "업데이트";
            this.Load += new System.EventHandler(this.Form_UpdateFlag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVersion;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnclose;
    }
}

