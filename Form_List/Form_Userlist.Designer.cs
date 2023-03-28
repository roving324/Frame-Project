namespace Form_List
{
	partial class Form_Userlist
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
			this.grid1 = new DC00_Component.Grid(this.components);
			this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.name = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.cbopart = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			this.cborank = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
			((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
			this.ultraGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbopart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cborank)).BeginInit();
			this.SuspendLayout();
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
			this.grid1.Location = new System.Drawing.Point(0, 113);
			this.grid1.Name = "grid1";
			this.grid1.Size = new System.Drawing.Size(800, 337);
			this.grid1.TabIndex = 3;
			this.grid1.Text = "grid1";
			this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
			this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
			this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
			this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
			// 
			// ultraGroupBox1
			// 
			this.ultraGroupBox1.Controls.Add(this.cborank);
			this.ultraGroupBox1.Controls.Add(this.cbopart);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel3);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel2);
			this.ultraGroupBox1.Controls.Add(this.ultraLabel1);
			this.ultraGroupBox1.Controls.Add(this.name);
			this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
			this.ultraGroupBox1.Name = "ultraGroupBox1";
			this.ultraGroupBox1.Size = new System.Drawing.Size(800, 113);
			this.ultraGroupBox1.TabIndex = 4;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.Location = new System.Drawing.Point(58, 64);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(32, 21);
			this.ultraLabel3.TabIndex = 2;
			this.ultraLabel3.Text = "직급";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.Location = new System.Drawing.Point(58, 39);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(32, 19);
			this.ultraLabel2.TabIndex = 2;
			this.ultraLabel2.Text = "부서";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.Location = new System.Drawing.Point(58, 16);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(32, 17);
			this.ultraLabel1.TabIndex = 2;
			this.ultraLabel1.Text = "이름";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(119, 12);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(144, 21);
			this.name.TabIndex = 1;
			// 
			// cbopart
			// 
			this.cbopart.Location = new System.Drawing.Point(119, 35);
			this.cbopart.Name = "cbopart";
			this.cbopart.Size = new System.Drawing.Size(144, 21);
			this.cbopart.TabIndex = 5;
			// 
			// cborank
			// 
			this.cborank.Location = new System.Drawing.Point(119, 62);
			this.cborank.Name = "cborank";
			this.cborank.Size = new System.Drawing.Size(144, 21);
			this.cborank.TabIndex = 5;
			// 
			// Form_Userlist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.grid1);
			this.Controls.Add(this.ultraGroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form_Userlist";
			this.Text = "Form_Userlist";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_Userlist_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
			this.ultraGroupBox1.ResumeLayout(false);
			this.ultraGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbopart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cborank)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DC00_Component.Grid grid1;
		private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor name;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cborank;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor cbopart;
	}
}