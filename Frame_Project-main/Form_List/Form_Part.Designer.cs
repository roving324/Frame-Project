namespace Form_List
{
	partial class Form_Part
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
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboSUseYN = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.cboSMtrlNO = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.cboSMtrlTP = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.txtSItemNm = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtSItemCd = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
			this.grid1 = new DC00_Component.Grid(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboSUseYN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSMtrlNO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSMtrlTP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSItemNm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSItemCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
			this.ultraGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.label5);
			this.ultraGroupBox1.Controls.Add(this.label4);
			this.ultraGroupBox1.Controls.Add(this.label3);
			this.ultraGroupBox1.Controls.Add(this.label2);
			this.ultraGroupBox1.Controls.Add(this.label1);
			this.ultraGroupBox1.Controls.Add(this.cboSUseYN);
			this.ultraGroupBox1.Controls.Add(this.cboSMtrlNO);
			this.ultraGroupBox1.Controls.Add(this.cboSMtrlTP);
			this.ultraGroupBox1.Controls.Add(this.txtSItemNm);
			this.ultraGroupBox1.Controls.Add(this.txtSItemCd);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(1024, 100);
			this.ultraGroupBox1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(817, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "사용유무";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(612, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "제품유형";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(403, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "자재유형";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(218, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "품목명";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "품목코드";
			// 
			// cboSUseYN
			// 
			this.cboSUseYN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboSUseYN.Location = new System.Drawing.Point(876, 34);
			this.cboSUseYN.Name = "cboSUseYN";
			this.cboSUseYN.Size = new System.Drawing.Size(144, 23);
			this.cboSUseYN.TabIndex = 4;
			this.cboSUseYN.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			// 
			// cboSMtrlNO
			// 
			this.cboSMtrlNO.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboSMtrlNO.Location = new System.Drawing.Point(667, 34);
			this.cboSMtrlNO.Name = "cboSMtrlNO";
			this.cboSMtrlNO.Size = new System.Drawing.Size(144, 25);
			this.cboSMtrlNO.TabIndex = 3;
			// 
			// cboSMtrlTP
			// 
			this.cboSMtrlTP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboSMtrlTP.Location = new System.Drawing.Point(462, 34);
			this.cboSMtrlTP.Name = "cboSMtrlTP";
			this.cboSMtrlTP.Size = new System.Drawing.Size(144, 25);
			this.cboSMtrlTP.TabIndex = 2;
			// 
			// txtSItemNm
			// 
			this.txtSItemNm.Location = new System.Drawing.Point(265, 34);
			this.txtSItemNm.Name = "txtSItemNm";
			this.txtSItemNm.Size = new System.Drawing.Size(138, 21);
			this.txtSItemNm.TabIndex = 1;
			// 
			// txtSItemCd
			// 
			this.txtSItemCd.Location = new System.Drawing.Point(71, 34);
			this.txtSItemCd.Name = "txtSItemCd";
			this.txtSItemCd.Size = new System.Drawing.Size(138, 21);
			this.txtSItemCd.TabIndex = 0;
			// 
			// ultraGroupBox2
			// 
			this.ultraGroupBox2.Controls.Add(this.grid1);
			this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraGroupBox2.Location = new System.Drawing.Point(0, 100);
			this.ultraGroupBox2.Name = "ultraGroupBox2";
			this.ultraGroupBox2.Size = new System.Drawing.Size(1024, 350);
			this.ultraGroupBox2.TabIndex = 1;
			// 
			// grid1
			// 
			this.grid1.AutoResizeColumn = true;
			this.grid1.AutoUserColumn = true;
			this.grid1.ContextMenuCopyEnabled = true;
			this.grid1.ContextMenuDeleteEnabled = true;
			this.grid1.ContextMenuExcelEnabled = true;
			this.grid1.ContextMenuInsertEnabled = true;
			this.grid1.ContextMenuPasteEnabled = true;
			this.grid1.DeleteButtonEnable = true;
			appearance1.BackColor = System.Drawing.SystemColors.Window;
			appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.DisplayLayout.Appearance = appearance1;
			this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance2.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.GroupByBox.Appearance = appearance2;
			appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
			this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.GroupByBox.Hidden = true;
			appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance4.BackColor2 = System.Drawing.SystemColors.Control;
			appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
			this.grid1.DisplayLayout.MaxColScrollRegions = 1;
			this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
			appearance11.BackColor = System.Drawing.SystemColors.Window;
			appearance11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance11;
			appearance5.BackColor = System.Drawing.SystemColors.Highlight;
			appearance5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance5;
			this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
			this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance8.BackColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance8;
			appearance12.BorderColor = System.Drawing.Color.Silver;
			appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid1.DisplayLayout.Override.CellAppearance = appearance12;
			this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid1.DisplayLayout.Override.CellPadding = 0;
			appearance10.BackColor = System.Drawing.SystemColors.Control;
			appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance10.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance10;
			appearance6.TextHAlignAsString = "Left";
			this.grid1.DisplayLayout.Override.HeaderAppearance = appearance6;
			this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance9.BackColor = System.Drawing.SystemColors.Window;
			appearance9.BorderColor = System.Drawing.Color.Silver;
			this.grid1.DisplayLayout.Override.RowAppearance = appearance9;
			this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance7;
			this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid1.EnterNextRowEnable = true;
			this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid1.Location = new System.Drawing.Point(3, 0);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(1018, 347);
			this.grid1.TabIndex = 0;
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.grid1_ClickCell);
			// 
			// Form_Part
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(1024, 450);
			this.Controls.Add(this.ultraGroupBox2);
			this.Controls.Add(this.ultraGroupBox1);
			this.Name = "Form_Part";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			this.ultraGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboSUseYN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSMtrlNO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboSMtrlTP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSItemNm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSItemCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
			this.ultraGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboSUseYN;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboSMtrlNO;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboSMtrlTP;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSItemNm;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSItemCd;
		private DC00_Component.Grid grid1;
	}
}
