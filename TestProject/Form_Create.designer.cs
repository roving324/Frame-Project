namespace TestProject
{
	partial class Form_Create
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
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create));
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.ValueListItem valueListItem7 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem8 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem9 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem10 = new Infragistics.Win.ValueListItem();
			this.txtId = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtPw = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtPw1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.PH1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.btnForm_Create = new Infragistics.Win.Misc.UltraButton();
			this.btnCancle = new Infragistics.Win.Misc.UltraButton();
			this.sLabel1 = new DC00_Component.SLabel();
			this.sLabel2 = new DC00_Component.SLabel();
			this.sLabel3 = new DC00_Component.SLabel();
			this.sLabel4 = new DC00_Component.SLabel();
			this.sLabel5 = new DC00_Component.SLabel();
			this.sLabel6 = new DC00_Component.SLabel();
			this.sLabel7 = new DC00_Component.SLabel();
			this.ComboSex = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ComboPart = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
			this.sLabel8 = new DC00_Component.SLabel();
			this.ComboLevel = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.PH2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.PH3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPw1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PH1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboSex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboPart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PH2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PH3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(136, 125);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(235, 21);
			this.txtId.TabIndex = 0;
			// 
			// txtPw
			// 
			this.txtPw.Location = new System.Drawing.Point(136, 153);
			this.txtPw.Name = "txtPw";
			this.txtPw.Size = new System.Drawing.Size(235, 21);
			this.txtPw.TabIndex = 1;
			// 
			// txtPw1
			// 
			this.txtPw1.Location = new System.Drawing.Point(136, 183);
			this.txtPw1.Name = "txtPw1";
			this.txtPw1.Size = new System.Drawing.Size(235, 21);
			this.txtPw1.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(136, 210);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(235, 21);
			this.txtName.TabIndex = 3;
			// 
			// PH1
			// 
			this.PH1.Location = new System.Drawing.Point(136, 237);
			this.PH1.Name = "PH1";
			this.PH1.Size = new System.Drawing.Size(47, 21);
			this.PH1.TabIndex = 4;
			this.PH1.Text = "010";
			this.PH1.ValueChanged += new System.EventHandler(this.PH1_ValueChanged);
			this.PH1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
			// 
			// btnForm_Create
			// 
			this.btnForm_Create.Location = new System.Drawing.Point(84, 394);
			this.btnForm_Create.Name = "btnForm_Create";
			this.btnForm_Create.Size = new System.Drawing.Size(287, 42);
			this.btnForm_Create.TabIndex = 10;
			this.btnForm_Create.Text = "가입하기";
			this.btnForm_Create.Click += new System.EventHandler(this.btnForm_Create_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(84, 442);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(287, 42);
			this.btnCancle.TabIndex = 11;
			this.btnCancle.Text = "취소";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// sLabel1
			// 
			appearance7.FontData.BoldAsString = "False";
			appearance7.FontData.UnderlineAsString = "False";
			appearance7.ForeColor = System.Drawing.Color.Black;
			appearance7.TextHAlignAsString = "Right";
			appearance7.TextVAlignAsString = "Middle";
			this.sLabel1.Appearance = appearance7;
			this.sLabel1.DbField = null;
			this.sLabel1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel1.Location = new System.Drawing.Point(9, 125);
			this.sLabel1.Name = "sLabel1";
			this.sLabel1.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel1.Size = new System.Drawing.Size(100, 23);
			this.sLabel1.TabIndex = 8;
			this.sLabel1.Text = "ID";
			// 
			// sLabel2
			// 
			appearance8.FontData.BoldAsString = "False";
			appearance8.FontData.UnderlineAsString = "False";
			appearance8.ForeColor = System.Drawing.Color.Black;
			appearance8.TextHAlignAsString = "Right";
			appearance8.TextVAlignAsString = "Middle";
			this.sLabel2.Appearance = appearance8;
			this.sLabel2.DbField = null;
			this.sLabel2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel2.Location = new System.Drawing.Point(9, 151);
			this.sLabel2.Name = "sLabel2";
			this.sLabel2.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel2.Size = new System.Drawing.Size(100, 23);
			this.sLabel2.TabIndex = 9;
			this.sLabel2.Text = "PW";
			// 
			// sLabel3
			// 
			appearance9.FontData.BoldAsString = "False";
			appearance9.FontData.UnderlineAsString = "False";
			appearance9.ForeColor = System.Drawing.Color.Black;
			appearance9.TextHAlignAsString = "Right";
			appearance9.TextVAlignAsString = "Middle";
			this.sLabel3.Appearance = appearance9;
			this.sLabel3.DbField = null;
			this.sLabel3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel3.Location = new System.Drawing.Point(9, 181);
			this.sLabel3.Name = "sLabel3";
			this.sLabel3.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel3.Size = new System.Drawing.Size(100, 23);
			this.sLabel3.TabIndex = 10;
			this.sLabel3.Text = "PW확인";
			// 
			// sLabel4
			// 
			appearance10.FontData.BoldAsString = "False";
			appearance10.FontData.UnderlineAsString = "False";
			appearance10.ForeColor = System.Drawing.Color.Black;
			appearance10.TextHAlignAsString = "Right";
			appearance10.TextVAlignAsString = "Middle";
			this.sLabel4.Appearance = appearance10;
			this.sLabel4.DbField = null;
			this.sLabel4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel4.Location = new System.Drawing.Point(9, 208);
			this.sLabel4.Name = "sLabel4";
			this.sLabel4.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel4.Size = new System.Drawing.Size(100, 23);
			this.sLabel4.TabIndex = 11;
			this.sLabel4.Text = "이름";
			// 
			// sLabel5
			// 
			appearance11.FontData.BoldAsString = "False";
			appearance11.FontData.UnderlineAsString = "False";
			appearance11.ForeColor = System.Drawing.Color.Black;
			appearance11.TextHAlignAsString = "Right";
			appearance11.TextVAlignAsString = "Middle";
			this.sLabel5.Appearance = appearance11;
			this.sLabel5.DbField = null;
			this.sLabel5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel5.Location = new System.Drawing.Point(12, 289);
			this.sLabel5.Name = "sLabel5";
			this.sLabel5.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel5.Size = new System.Drawing.Size(100, 23);
			this.sLabel5.TabIndex = 12;
			this.sLabel5.Text = "성별";
			// 
			// sLabel6
			// 
			appearance2.FontData.BoldAsString = "False";
			appearance2.FontData.UnderlineAsString = "False";
			appearance2.ForeColor = System.Drawing.Color.Black;
			appearance2.TextHAlignAsString = "Right";
			appearance2.TextVAlignAsString = "Middle";
			this.sLabel6.Appearance = appearance2;
			this.sLabel6.DbField = null;
			this.sLabel6.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel6.Location = new System.Drawing.Point(9, 235);
			this.sLabel6.Name = "sLabel6";
			this.sLabel6.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel6.Size = new System.Drawing.Size(100, 23);
			this.sLabel6.TabIndex = 13;
			this.sLabel6.Text = "전화번호";
			// 
			// sLabel7
			// 
			appearance3.FontData.BoldAsString = "False";
			appearance3.FontData.UnderlineAsString = "False";
			appearance3.ForeColor = System.Drawing.Color.Black;
			appearance3.TextHAlignAsString = "Right";
			appearance3.TextVAlignAsString = "Middle";
			this.sLabel7.Appearance = appearance3;
			this.sLabel7.DbField = null;
			this.sLabel7.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel7.Location = new System.Drawing.Point(10, 316);
			this.sLabel7.Name = "sLabel7";
			this.sLabel7.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel7.Size = new System.Drawing.Size(100, 23);
			this.sLabel7.TabIndex = 14;
			this.sLabel7.Text = "부서";
			// 
			// ComboSex
			// 
			this.ComboSex.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			valueListItem1.DataValue = "ValueListItem0";
			valueListItem1.DisplayText = "남자";
			valueListItem2.DataValue = "ValueListItem1";
			valueListItem2.DisplayText = "여자";
			this.ComboSex.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
			this.ComboSex.Location = new System.Drawing.Point(136, 289);
			this.ComboSex.Name = "ComboSex";
			this.ComboSex.Size = new System.Drawing.Size(235, 21);
			this.ComboSex.TabIndex = 7;
			// 
			// ComboPart
			// 
			this.ComboPart.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			valueListItem3.DataValue = "ValueListItem0";
			valueListItem3.DisplayText = "인사과";
			valueListItem4.DataValue = "ValueListItem1";
			valueListItem4.DisplayText = "군수과";
			valueListItem5.DataValue = "ValueListItem2";
			valueListItem5.DisplayText = "사재부";
			valueListItem6.DataValue = "ValueListItem3";
			valueListItem6.DisplayText = "사무";
			this.ComboPart.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4,
            valueListItem5,
            valueListItem6});
			this.ComboPart.Location = new System.Drawing.Point(136, 316);
			this.ComboPart.Name = "ComboPart";
			this.ComboPart.Size = new System.Drawing.Size(235, 21);
			this.ComboPart.TabIndex = 8;
			// 
			// ultraPictureBox1
			// 
			this.ultraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty;
			this.ultraPictureBox1.Image = ((object)(resources.GetObject("ultraPictureBox1.Image")));
			this.ultraPictureBox1.Location = new System.Drawing.Point(-1, 0);
			this.ultraPictureBox1.Name = "ultraPictureBox1";
			this.ultraPictureBox1.Size = new System.Drawing.Size(461, 102);
			this.ultraPictureBox1.TabIndex = 18;
			// 
			// sLabel8
			// 
			appearance1.FontData.BoldAsString = "False";
			appearance1.FontData.UnderlineAsString = "False";
			appearance1.ForeColor = System.Drawing.Color.Black;
			appearance1.TextHAlignAsString = "Right";
			appearance1.TextVAlignAsString = "Middle";
			this.sLabel8.Appearance = appearance1;
			this.sLabel8.DbField = null;
			this.sLabel8.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.sLabel8.Location = new System.Drawing.Point(12, 345);
			this.sLabel8.Name = "sLabel8";
			this.sLabel8.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
			this.sLabel8.Size = new System.Drawing.Size(100, 23);
			this.sLabel8.TabIndex = 19;
			this.sLabel8.Text = "직급";
			// 
			// ComboLevel
			// 
			this.ComboLevel.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			valueListItem7.DataValue = "ValueListItem0";
			valueListItem7.DisplayText = "팀장";
			valueListItem8.DataValue = "ValueListItem1";
			valueListItem8.DisplayText = "실장";
			valueListItem9.DataValue = "ValueListItem2";
			valueListItem9.DisplayText = "부장";
			valueListItem10.DataValue = "ValueListItem3";
			valueListItem10.DisplayText = "사원";
			this.ComboLevel.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem7,
            valueListItem8,
            valueListItem9,
            valueListItem10});
			this.ComboLevel.Location = new System.Drawing.Point(136, 343);
			this.ComboLevel.Name = "ComboLevel";
			this.ComboLevel.Size = new System.Drawing.Size(235, 21);
			this.ComboLevel.TabIndex = 9;
			// 
			// PH2
			// 
			this.PH2.Location = new System.Drawing.Point(212, 237);
			this.PH2.Name = "PH2";
			this.PH2.Size = new System.Drawing.Size(64, 21);
			this.PH2.TabIndex = 5;
			this.PH2.TextChanged += new System.EventHandler(this.PH_TextChanged);
			this.PH2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
			// 
			// PH3
			// 
			this.PH3.Location = new System.Drawing.Point(307, 237);
			this.PH3.Name = "PH3";
			this.PH3.Size = new System.Drawing.Size(64, 21);
			this.PH3.TabIndex = 6;
			this.PH3.TextChanged += new System.EventHandler(this.PH_TextChanged);
			this.PH3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(191, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 21;
			this.label1.Text = "-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(285, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 12);
			this.label2.TabIndex = 21;
			this.label2.Text = "-";
			// 
			// Form_Create
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 506);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ComboLevel);
			this.Controls.Add(this.sLabel8);
			this.Controls.Add(this.ultraPictureBox1);
			this.Controls.Add(this.ComboPart);
			this.Controls.Add(this.ComboSex);
			this.Controls.Add(this.sLabel7);
			this.Controls.Add(this.sLabel6);
			this.Controls.Add(this.sLabel5);
			this.Controls.Add(this.sLabel4);
			this.Controls.Add(this.sLabel3);
			this.Controls.Add(this.sLabel2);
			this.Controls.Add(this.sLabel1);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnForm_Create);
			this.Controls.Add(this.PH3);
			this.Controls.Add(this.PH2);
			this.Controls.Add(this.PH1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPw1);
			this.Controls.Add(this.txtPw);
			this.Controls.Add(this.txtId);
			this.Name = "Form_Create";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form_Create";
			((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPw1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PH1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboSex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboPart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PH2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PH3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtId;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPw;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPw1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtName;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor PH1;
		private Infragistics.Win.Misc.UltraButton btnForm_Create;
		private Infragistics.Win.Misc.UltraButton btnCancle;
		private DC00_Component.SLabel sLabel1;
		private DC00_Component.SLabel sLabel2;
		private DC00_Component.SLabel sLabel3;
		private DC00_Component.SLabel sLabel4;
		private DC00_Component.SLabel sLabel5;
		private DC00_Component.SLabel sLabel6;
		private DC00_Component.SLabel sLabel7;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor ComboSex;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor ComboPart;
		private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox1;
		private DC00_Component.SLabel sLabel8;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor ComboLevel;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor PH2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor PH3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}