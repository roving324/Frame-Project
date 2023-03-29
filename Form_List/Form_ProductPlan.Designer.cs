namespace Form_List
{
	partial class Form_ProductPlan
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
			this.grid = new DC00_Component.Grid(this.components);
			this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
			this.txtProductNum = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.cboUseFlag = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.cboWCC = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.cboItemCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
			this.ultraGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtProductNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUseFlag)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboWCC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.grid);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraGroupBox1.Location = new System.Drawing.Point(0, 110);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(985, 392);
			this.ultraGroupBox1.TabIndex = 0;
			// 
			// grid
			// 
			this.grid.AutoResizeColumn = true;
			this.grid.AutoUserColumn = true;
			this.grid.ContextMenuCopyEnabled = true;
			this.grid.ContextMenuDeleteEnabled = true;
			this.grid.ContextMenuExcelEnabled = true;
			this.grid.ContextMenuInsertEnabled = true;
			this.grid.ContextMenuPasteEnabled = true;
			this.grid.DeleteButtonEnable = true;
			appearance1.BackColor = System.Drawing.SystemColors.Window;
			appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
			this.grid.DisplayLayout.Appearance = appearance1;
			this.grid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
			this.grid.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
			appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance2.BorderColor = System.Drawing.SystemColors.Window;
			this.grid.DisplayLayout.GroupByBox.Appearance = appearance2;
			appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
			this.grid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
			this.grid.DisplayLayout.GroupByBox.Hidden = true;
			appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			appearance4.BackColor2 = System.Drawing.SystemColors.Control;
			appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
			this.grid.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
			this.grid.DisplayLayout.MaxColScrollRegions = 1;
			this.grid.DisplayLayout.MaxRowScrollRegions = 1;
			appearance11.BackColor = System.Drawing.SystemColors.Window;
			appearance11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.DisplayLayout.Override.ActiveCellAppearance = appearance11;
			appearance5.BackColor = System.Drawing.SystemColors.Highlight;
			appearance5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.grid.DisplayLayout.Override.ActiveRowAppearance = appearance5;
			this.grid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
			this.grid.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
			this.grid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.grid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
			appearance8.BackColor = System.Drawing.SystemColors.Window;
			this.grid.DisplayLayout.Override.CardAreaAppearance = appearance8;
			appearance12.BorderColor = System.Drawing.Color.Silver;
			appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
			this.grid.DisplayLayout.Override.CellAppearance = appearance12;
			this.grid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
			this.grid.DisplayLayout.Override.CellPadding = 0;
			appearance10.BackColor = System.Drawing.SystemColors.Control;
			appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
			appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
			appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance10.BorderColor = System.Drawing.SystemColors.Window;
			this.grid.DisplayLayout.Override.GroupByRowAppearance = appearance10;
			appearance6.TextHAlignAsString = "Left";
			this.grid.DisplayLayout.Override.HeaderAppearance = appearance6;
			this.grid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
			this.grid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
			appearance9.BackColor = System.Drawing.SystemColors.Window;
			appearance9.BorderColor = System.Drawing.Color.Silver;
			this.grid.DisplayLayout.Override.RowAppearance = appearance9;
			this.grid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
			appearance7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.grid.DisplayLayout.Override.TemplateAddRowAppearance = appearance7;
			this.grid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
			this.grid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
			this.grid.DisplayLayout.SelectionOverlayBorderThickness = 2;
			this.grid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.EnterNextRowEnable = true;
			this.grid.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.grid.Location = new System.Drawing.Point(3, 0);
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(979, 389);
			this.grid.TabIndex = 0;
			this.grid.Text = "grid1";
			this.grid.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			// 
			// ultraGroupBox2
			// 
			this.ultraGroupBox2.Controls.Add(this.txtProductNum);
			this.ultraGroupBox2.Controls.Add(this.ultraLabel5);
			this.ultraGroupBox2.Controls.Add(this.cboUseFlag);
			this.ultraGroupBox2.Controls.Add(this.ultraLabel4);
			this.ultraGroupBox2.Controls.Add(this.cboWCC);
			this.ultraGroupBox2.Controls.Add(this.ultraLabel1);
			this.ultraGroupBox2.Controls.Add(this.cboItemCode);
			this.ultraGroupBox2.Controls.Add(this.ultraLabel2);
			this.ultraGroupBox2.Controls.Add(this.cboPlantCode);
			this.ultraGroupBox2.Controls.Add(this.ultraLabel3);
			this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox2.Location = new System.Drawing.Point(0, 0);
			this.ultraGroupBox2.Name = "ultraGroupBox2";
			this.ultraGroupBox2.Size = new System.Drawing.Size(985, 110);
			this.ultraGroupBox2.TabIndex = 0;
			// 
			// txtProductNum
			// 
			this.txtProductNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtProductNum.Location = new System.Drawing.Point(568, 12);
			this.txtProductNum.Name = "txtProductNum";
			this.txtProductNum.Size = new System.Drawing.Size(126, 25);
			this.txtProductNum.TabIndex = 2;
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.Location = new System.Drawing.Point(478, 19);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(90, 23);
			this.ultraLabel5.TabIndex = 9;
			this.ultraLabel5.Text = "작업지시번호";
			// 
			// cboUseFlag
			// 
			this.cboUseFlag.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboUseFlag.Location = new System.Drawing.Point(775, 12);
			this.cboUseFlag.Name = "cboUseFlag";
			this.cboUseFlag.Size = new System.Drawing.Size(144, 25);
			this.cboUseFlag.TabIndex = 3;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.Location = new System.Drawing.Point(709, 18);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(72, 23);
			this.ultraLabel4.TabIndex = 7;
			this.ultraLabel4.Text = "종료여부";
			// 
			// cboWCC
			// 
			this.cboWCC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboWCC.Location = new System.Drawing.Point(322, 12);
			this.cboWCC.Name = "cboWCC";
			this.cboWCC.Size = new System.Drawing.Size(144, 25);
			this.cboWCC.TabIndex = 1;
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.Location = new System.Drawing.Point(256, 18);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(72, 23);
			this.ultraLabel1.TabIndex = 7;
			this.ultraLabel1.Text = "작업장";
			// 
			// cboItemCode
			// 
			this.cboItemCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboItemCode.Location = new System.Drawing.Point(100, 66);
			this.cboItemCode.Name = "cboItemCode";
			this.cboItemCode.Size = new System.Drawing.Size(366, 25);
			this.cboItemCode.TabIndex = 4;
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.Location = new System.Drawing.Point(34, 72);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(72, 23);
			this.ultraLabel2.TabIndex = 7;
			this.ultraLabel2.Text = "품목";
			// 
			// cboPlantCode
			// 
			this.cboPlantCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboPlantCode.Location = new System.Drawing.Point(100, 12);
			this.cboPlantCode.Name = "cboPlantCode";
			this.cboPlantCode.Size = new System.Drawing.Size(144, 25);
			this.cboPlantCode.TabIndex = 0;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.Location = new System.Drawing.Point(34, 18);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(72, 23);
			this.ultraLabel3.TabIndex = 7;
			this.ultraLabel3.Text = "공장";
			// 
			// Form_ProductPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(985, 502);
			this.Controls.Add(this.ultraGroupBox1);
			this.Controls.Add(this.ultraGroupBox2);
			this.Name = "Form_ProductPlan";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_ProductPlan_Load);
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
			this.ultraGroupBox2.ResumeLayout(false);
			this.ultraGroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtProductNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUseFlag)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboWCC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private DC00_Component.Grid grid;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboUseFlag;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboWCC;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboItemCode;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtProductNum;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
	}
}
