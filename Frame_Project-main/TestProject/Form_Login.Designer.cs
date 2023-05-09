namespace TestProject
{
	partial class Form_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
			this.ID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.PW = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.BtnLogin = new Infragistics.Win.Misc.UltraButton();
			this.BtnCreate = new Infragistics.Win.Misc.UltraButton();
			this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PW)).BeginInit();
			this.SuspendLayout();
			// 
			// ID
			// 
			this.ID.Font = new System.Drawing.Font("굴림", 9F);
			this.ID.Location = new System.Drawing.Point(122, 62);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(140, 21);
			this.ID.TabIndex = 1;
			this.ID.Text = "ID";
			this.ID.BeforeEnterEditMode += new System.ComponentModel.CancelEventHandler(this.BeforeEnterEditMode);
			this.ID.BeforeExitEditMode += new Infragistics.Win.BeforeExitEditModeEventHandler(this.BeforeExitEditMode);
			// 
			// PW
			// 
			this.PW.Font = new System.Drawing.Font("굴림", 9F);
			this.PW.Location = new System.Drawing.Point(122, 107);
			this.PW.Name = "PW";
			this.PW.Size = new System.Drawing.Size(140, 21);
			this.PW.TabIndex = 2;
			this.PW.Text = "PW";
			this.PW.BeforeEnterEditMode += new System.ComponentModel.CancelEventHandler(this.BeforeEnterEditMode);
			this.PW.BeforeExitEditMode += new Infragistics.Win.BeforeExitEditModeEventHandler(this.BeforeExitEditMode);
			this.PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PW_KeyDown);
			// 
			// BtnLogin
			// 
			this.BtnLogin.Location = new System.Drawing.Point(122, 171);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(99, 39);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.Text = "로그인";
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// BtnCreate
			// 
			this.BtnCreate.Location = new System.Drawing.Point(227, 171);
			this.BtnCreate.Name = "BtnCreate";
			this.BtnCreate.Size = new System.Drawing.Size(99, 39);
			this.BtnCreate.TabIndex = 0;
			this.BtnCreate.Text = "회원가입";
			this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// ultraPictureBox1
			// 
			this.ultraPictureBox1.AutoSize = true;
			this.ultraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty;
			this.ultraPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraPictureBox1.Image = ((object)(resources.GetObject("ultraPictureBox1.Image")));
			this.ultraPictureBox1.Location = new System.Drawing.Point(0, 0);
			this.ultraPictureBox1.Name = "ultraPictureBox1";
			this.ultraPictureBox1.Size = new System.Drawing.Size(555, 239);
			this.ultraPictureBox1.TabIndex = 4;
			// 
			// Form_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(555, 239);
			this.Controls.Add(this.ID);
			this.Controls.Add(this.PW);
			this.Controls.Add(this.BtnCreate);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.ultraPictureBox1);
			this.Name = "Form_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form_Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PW)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Infragistics.Win.UltraWinEditors.UltraTextEditor ID;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor PW;
		private Infragistics.Win.Misc.UltraButton BtnLogin;
		private Infragistics.Win.Misc.UltraButton BtnCreate;
		private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox1;
	}
}

