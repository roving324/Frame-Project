namespace Form_List
{
	partial class Form_SubItem
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
			this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
			this.grid = new DC00_Component.Grid(this.components);
			this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.cboItemType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.txtItemCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtItemName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.btnFind = new Infragistics.Win.Misc.UltraButton();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
			this.ultraGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.btnFind);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel4);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel3);
			this.ultraGroupBox1.Controls.Add(this.txtItemName);
			this.ultraGroupBox1.Controls.Add(this.txtItemCode);
			this.ultraGroupBox1.Controls.Add(this.cboItemType);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel2);
			this.ultraGroupBox1.Controls.Add(this.cboPlantCode);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(800, 110);
			this.ultraGroupBox1.TabIndex = 0;
			// 
			// ultraGroupBox2
			// 
			this.ultraGroupBox2.Controls.Add(this.grid);
			this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraGroupBox2.Location = new System.Drawing.Point(0, 110);
			this.ultraGroupBox2.Name = "ultraGroupBox2";
			this.ultraGroupBox2.Size = new System.Drawing.Size(800, 340);
			this.ultraGroupBox2.TabIndex = 0;
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
			this.grid.Size = new System.Drawing.Size(794, 337);
			this.grid.TabIndex = 10;
			this.grid.Text = "grid1";
			this.grid.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			this.grid.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.grid_DoubleClickRow);
			// 
			// cboPlantCode
			// 
			this.cboPlantCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboPlantCode.Location = new System.Drawing.Point(122, 24);
			this.cboPlantCode.Name = "cboPlantCode";
			this.cboPlantCode.Size = new System.Drawing.Size(144, 25);
			this.cboPlantCode.TabIndex = 0;
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.Location = new System.Drawing.Point(58, 30);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(74, 23);
			this.ultraLabel1.TabIndex = 7;
			this.ultraLabel1.Text = "공장";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.Location = new System.Drawing.Point(58, 65);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(74, 23);
			this.ultraLabel2.TabIndex = 7;
			this.ultraLabel2.Text = "제품유형";
			// 
			// cboItemType
			// 
			this.cboItemType.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cboItemType.Location = new System.Drawing.Point(122, 59);
			this.cboItemType.Name = "cboItemType";
			this.cboItemType.Size = new System.Drawing.Size(144, 25);
			this.cboItemType.TabIndex = 2;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.Location = new System.Drawing.Point(314, 32);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(36, 23);
			this.ultraLabel3.TabIndex = 9;
			this.ultraLabel3.Text = "품목";
			// 
			// txtItemCode
			// 
			this.txtItemCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtItemCode.Location = new System.Drawing.Point(356, 26);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.Size = new System.Drawing.Size(126, 25);
			this.txtItemCode.TabIndex = 1;
			// 
			// txtItemName
			// 
			this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtItemName.Location = new System.Drawing.Point(356, 58);
			this.txtItemName.Name = "txtItemName";
			this.txtItemName.Size = new System.Drawing.Size(126, 25);
			this.txtItemName.TabIndex = 3;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.Location = new System.Drawing.Point(305, 64);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(45, 23);
			this.ultraLabel4.TabIndex = 9;
			this.ultraLabel4.Text = "품목명";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(554, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(116, 62);
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "조회";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// Form_SubItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ultraGroupBox2);
			this.Controls.Add(this.ultraGroupBox1);
			this.Name = "Form_SubItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "품목 정보";
			this.Load += new System.EventHandler(this.Form_SubItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			this.ultraGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
			this.ultraGroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboItemType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
		private DC00_Component.Grid grid;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboItemType;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtItemName;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtItemCode;
		private Infragistics.Win.Misc.UltraButton btnFind;
	}
}