namespace Form_List
{
	partial class Form_Workcenter
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
			Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
			this.txtWcCd = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtWcCdNm = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
			this.cboUse = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.cboPlantCd = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
			this.grid1 = new DC00_Component.Grid(this.components);
			((System.ComponentModel.ISupportInitialize)(this.txtWcCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWcCdNm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboUse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
			this.ultraGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtWcCd
			// 
			this.txtWcCd.Location = new System.Drawing.Point(267, 25);
			this.txtWcCd.Name = "txtWcCd";
			this.txtWcCd.Size = new System.Drawing.Size(100, 21);
			this.txtWcCd.TabIndex = 1;
			// 
			// txtWcCdNm
			// 
			this.txtWcCdNm.Location = new System.Drawing.Point(447, 25);
			this.txtWcCdNm.Name = "txtWcCdNm";
			this.txtWcCdNm.Size = new System.Drawing.Size(100, 21);
			this.txtWcCdNm.TabIndex = 2;
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.cboUse);
			this.ultraGroupBox1.Controls.Add(this.cboPlantCd);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel4);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel3);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel2);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
			this.ultraGroupBox1.Controls.Add(this.txtWcCdNm);
			this.ultraGroupBox1.Controls.Add(this.txtWcCd);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(886, 67);
			this.ultraGroupBox1.TabIndex = 3;
			// 
			// cboUse
			// 
			this.cboUse.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboUse.Location = new System.Drawing.Point(622, 24);
			this.cboUse.Name = "cboUse";
			this.cboUse.Size = new System.Drawing.Size(92, 23);
			this.cboUse.TabIndex = 3;
			this.cboUse.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			// 
			// cboPlantCd
			// 
			this.cboPlantCd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboPlantCd.Location = new System.Drawing.Point(76, 24);
			this.cboPlantCd.Name = "cboPlantCd";
			this.cboPlantCd.Size = new System.Drawing.Size(107, 23);
			this.cboPlantCd.TabIndex = 0;
			this.cboPlantCd.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.Location = new System.Drawing.Point(553, 27);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(63, 20);
			this.ultraLabel4.TabIndex = 4;
			this.ultraLabel4.Text = "사용유무";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.Location = new System.Drawing.Point(385, 27);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(56, 17);
			this.ultraLabel3.TabIndex = 4;
			this.ultraLabel3.Text = "작업장명";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.Location = new System.Drawing.Point(189, 27);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(72, 17);
			this.ultraLabel2.TabIndex = 4;
			this.ultraLabel2.Text = "작업장코드";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.Location = new System.Drawing.Point(16, 27);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(42, 18);
			this.ultraLabel1.TabIndex = 4;
			this.ultraLabel1.Text = "공장";
			// 
			// ultraGroupBox2
			// 
			this.ultraGroupBox2.Controls.Add(this.grid1);
			this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraGroupBox2.Location = new System.Drawing.Point(0, 67);
			this.ultraGroupBox2.Name = "ultraGroupBox2";
			this.ultraGroupBox2.Size = new System.Drawing.Size(886, 383);
			this.ultraGroupBox2.TabIndex = 4;
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
			appearance37.BackColor = System.Drawing.SystemColors.Window;
			appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid1.DisplayLayout.Appearance = appearance37;
			this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance38.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.GroupByBox.Appearance = appearance38;
			appearance39.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance39;
			this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid1.DisplayLayout.GroupByBox.Hidden = true;
			appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance40.BackColor2 = System.Drawing.SystemColors.Control;
			appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance40.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance40;
			this.grid1.DisplayLayout.MaxColScrollRegions = 1;
			this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
			appearance31.BackColor = System.Drawing.SystemColors.Window;
			appearance31.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance31;
			appearance25.BackColor = System.Drawing.SystemColors.Highlight;
			appearance25.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance25;
			this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
			this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance28.BackColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance28;
			appearance32.BorderColor = System.Drawing.Color.Silver;
			appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid1.DisplayLayout.Override.CellAppearance = appearance32;
			this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid1.DisplayLayout.Override.CellPadding = 0;
			appearance30.BackColor = System.Drawing.SystemColors.Control;
			appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance30.BorderColor = System.Drawing.SystemColors.Window;
			this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance30;
			appearance26.TextHAlignAsString = "Left";
			this.grid1.DisplayLayout.Override.HeaderAppearance = appearance26;
			this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance29.BackColor = System.Drawing.SystemColors.Window;
			appearance29.BorderColor = System.Drawing.Color.Silver;
			this.grid1.DisplayLayout.Override.RowAppearance = appearance29;
			this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance27.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance27;
			this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid1.EnterNextRowEnable = true;
			this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid1.Location = new System.Drawing.Point(3, 0);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(880, 380);
			this.grid1.TabIndex = 0;
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			this.grid1.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.grid1_ClickCell);
			// 
			// Form_Workcenter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(886, 450);
			this.Controls.Add(this.ultraGroupBox2);
			this.Controls.Add(this.ultraGroupBox1);
			this.Name = "Form_Workcenter";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_Workcenter_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtWcCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWcCdNm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			this.ultraGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboUse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
			this.ultraGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtWcCd;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtWcCdNm;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
		private DC00_Component.Grid grid1;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboUse;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCd;
	}
}
