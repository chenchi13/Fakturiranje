namespace Fakturiranje.View
{
    partial class ViewArtiklForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewArtiklForm));
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.RowBN_lbl_Count = new System.Windows.Forms.ToolStripLabel();
            this.RowBN_lbl_Title = new System.Windows.Forms.ToolStripLabel();
            this.RowBN_btn_First = new System.Windows.Forms.ToolStripButton();
            this.RowBN_btn_Previous = new System.Windows.Forms.ToolStripButton();
            this.RowBN_txt_Current = new System.Windows.Forms.ToolStripTextBox();
            this.RowBN_btn_Next = new System.Windows.Forms.ToolStripButton();
            this.RowBN_btn_Last = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.MainToolStrip = new ZisCode.Controls.BorderlessToolStrip();
            this.btn_AddArtikl = new System.Windows.Forms.ToolStripButton();
            this.btn_EditArtikl = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteArtikl = new System.Windows.Forms.ToolStripSplitButton();
            this.MENU_DeleteFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_MultipleDeleteFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sort = new System.Windows.Forms.ToolStripButton();
            this.btn_Filter = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AllowUserToAddRows = false;
            this.dataGridViewArtikli.AllowUserToDeleteRows = false;
            this.dataGridViewArtikli.AllowUserToResizeColumns = false;
            this.dataGridViewArtikli.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewArtikli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtikli.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewArtikli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewArtikli.EnableHeadersVisualStyles = false;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewArtikli.RowHeadersVisible = false;
            this.dataGridViewArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(592, 377);
            this.dataGridViewArtikli.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator.CountItem = this.RowBN_lbl_Count;
            this.bindingNavigator.CountItemFormat = "od {0}";
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RowBN_lbl_Title,
            this.RowBN_btn_First,
            this.RowBN_btn_Previous,
            this.RowBN_txt_Current,
            this.RowBN_btn_Next,
            this.RowBN_btn_Last,
            this.RowBN_lbl_Count});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 408);
            this.bindingNavigator.MoveFirstItem = this.RowBN_btn_First;
            this.bindingNavigator.MoveLastItem = this.RowBN_btn_Last;
            this.bindingNavigator.MoveNextItem = this.RowBN_btn_Next;
            this.bindingNavigator.MovePreviousItem = this.RowBN_btn_Previous;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigator.PositionItem = this.RowBN_txt_Current;
            this.bindingNavigator.Size = new System.Drawing.Size(198, 25);
            this.bindingNavigator.TabIndex = 1012;
            this.bindingNavigator.Text = "RowBN";
            // 
            // RowBN_lbl_Count
            // 
            this.RowBN_lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RowBN_lbl_Count.ForeColor = System.Drawing.Color.DimGray;
            this.RowBN_lbl_Count.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_lbl_Count.Name = "RowBN_lbl_Count";
            this.RowBN_lbl_Count.Size = new System.Drawing.Size(36, 25);
            this.RowBN_lbl_Count.Text = "od {0}";
            this.RowBN_lbl_Count.ToolTipText = "Ukupno redova";
            // 
            // RowBN_lbl_Title
            // 
            this.RowBN_lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RowBN_lbl_Title.ForeColor = System.Drawing.Color.DimGray;
            this.RowBN_lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_lbl_Title.Name = "RowBN_lbl_Title";
            this.RowBN_lbl_Title.Size = new System.Drawing.Size(30, 25);
            this.RowBN_lbl_Title.Text = "Red:";
            // 
            // RowBN_btn_First
            // 
            this.RowBN_btn_First.AutoSize = false;
            this.RowBN_btn_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RowBN_btn_First.Image = ((System.Drawing.Image)(resources.GetObject("RowBN_btn_First.Image")));
            this.RowBN_btn_First.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RowBN_btn_First.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_btn_First.Name = "RowBN_btn_First";
            this.RowBN_btn_First.RightToLeftAutoMirrorImage = true;
            this.RowBN_btn_First.Size = new System.Drawing.Size(20, 20);
            this.RowBN_btn_First.Text = "Prvi red";
            // 
            // RowBN_btn_Previous
            // 
            this.RowBN_btn_Previous.AutoSize = false;
            this.RowBN_btn_Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RowBN_btn_Previous.Image = ((System.Drawing.Image)(resources.GetObject("RowBN_btn_Previous.Image")));
            this.RowBN_btn_Previous.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RowBN_btn_Previous.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_btn_Previous.Name = "RowBN_btn_Previous";
            this.RowBN_btn_Previous.RightToLeftAutoMirrorImage = true;
            this.RowBN_btn_Previous.Size = new System.Drawing.Size(20, 20);
            this.RowBN_btn_Previous.Text = "Prethodni red";
            // 
            // RowBN_txt_Current
            // 
            this.RowBN_txt_Current.AccessibleName = "Position";
            this.RowBN_txt_Current.AutoSize = false;
            this.RowBN_txt_Current.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RowBN_txt_Current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RowBN_txt_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RowBN_txt_Current.ForeColor = System.Drawing.Color.Black;
            this.RowBN_txt_Current.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_txt_Current.Name = "RowBN_txt_Current";
            this.RowBN_txt_Current.Size = new System.Drawing.Size(50, 13);
            this.RowBN_txt_Current.Text = "0";
            this.RowBN_txt_Current.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowBN_txt_Current.ToolTipText = "Trenutni red";
            // 
            // RowBN_btn_Next
            // 
            this.RowBN_btn_Next.AutoSize = false;
            this.RowBN_btn_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RowBN_btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("RowBN_btn_Next.Image")));
            this.RowBN_btn_Next.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RowBN_btn_Next.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_btn_Next.Name = "RowBN_btn_Next";
            this.RowBN_btn_Next.RightToLeftAutoMirrorImage = true;
            this.RowBN_btn_Next.Size = new System.Drawing.Size(20, 20);
            this.RowBN_btn_Next.Text = "Sljedeći red";
            // 
            // RowBN_btn_Last
            // 
            this.RowBN_btn_Last.AutoSize = false;
            this.RowBN_btn_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RowBN_btn_Last.Image = ((System.Drawing.Image)(resources.GetObject("RowBN_btn_Last.Image")));
            this.RowBN_btn_Last.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RowBN_btn_Last.Margin = new System.Windows.Forms.Padding(0);
            this.RowBN_btn_Last.Name = "RowBN_btn_Last";
            this.RowBN_btn_Last.RightToLeftAutoMirrorImage = true;
            this.RowBN_btn_Last.Size = new System.Drawing.Size(20, 20);
            this.RowBN_btn_Last.Text = "Zadnji red";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(373, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 1013;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddArtikl,
            this.btn_EditArtikl,
            this.btn_DeleteArtikl,
            this.toolStripSeparator1,
            this.btn_Print,
            this.btn_PrintPreview,
            this.toolStripSeparator2,
            this.btn_Sort,
            this.btn_Filter,
            this.btn_Refresh});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(231, 27);
            this.MainToolStrip.TabIndex = 1011;
            this.MainToolStrip.Text = "borderlessToolStrip1";
            // 
            // btn_AddArtikl
            // 
            this.btn_AddArtikl.AutoSize = false;
            this.btn_AddArtikl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddArtikl.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddArtikl.Image")));
            this.btn_AddArtikl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddArtikl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_AddArtikl.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_AddArtikl.Name = "btn_AddArtikl";
            this.btn_AddArtikl.Size = new System.Drawing.Size(22, 22);
            this.btn_AddArtikl.Text = "Dodaj";
            this.btn_AddArtikl.ToolTipText = "Dodaj\r\n [F3]";
            this.btn_AddArtikl.Click += new System.EventHandler(this.btn_AddArtikl_Click);
            // 
            // btn_EditArtikl
            // 
            this.btn_EditArtikl.AutoSize = false;
            this.btn_EditArtikl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditArtikl.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditArtikl.Image")));
            this.btn_EditArtikl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditArtikl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_EditArtikl.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_EditArtikl.Name = "btn_EditArtikl";
            this.btn_EditArtikl.Size = new System.Drawing.Size(22, 22);
            this.btn_EditArtikl.Text = "Uredi";
            this.btn_EditArtikl.ToolTipText = "Uredi\r\n [F5]";
            this.btn_EditArtikl.Click += new System.EventHandler(this.btn_EditArtikl_Click);
            // 
            // btn_DeleteArtikl
            // 
            this.btn_DeleteArtikl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteArtikl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_DeleteFlag,
            this.MENU_MultipleDeleteFlag});
            this.btn_DeleteArtikl.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteArtikl.Image")));
            this.btn_DeleteArtikl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteArtikl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_DeleteArtikl.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_DeleteArtikl.Name = "btn_DeleteArtikl";
            this.btn_DeleteArtikl.Size = new System.Drawing.Size(32, 25);
            this.btn_DeleteArtikl.Text = "Briši";
            this.btn_DeleteArtikl.ToolTipText = "Obriši \r\n[Shift+Delete]";
            this.btn_DeleteArtikl.ButtonClick += new System.EventHandler(this.btn_DeleteArtikl_ButtonClick);
            // 
            // MENU_DeleteFlag
            // 
            this.MENU_DeleteFlag.Name = "MENU_DeleteFlag";
            this.MENU_DeleteFlag.Size = new System.Drawing.Size(175, 22);
            this.MENU_DeleteFlag.Text = "Označi trenutni red";
            this.MENU_DeleteFlag.ToolTipText = "[Delete]";
            // 
            // MENU_MultipleDeleteFlag
            // 
            this.MENU_MultipleDeleteFlag.Name = "MENU_MultipleDeleteFlag";
            this.MENU_MultipleDeleteFlag.Size = new System.Drawing.Size(175, 22);
            this.MENU_MultipleDeleteFlag.Text = "Označi više redova";
            this.MENU_MultipleDeleteFlag.ToolTipText = "[Ctr+Delete]";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = false;
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Print.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(22, 22);
            this.btn_Print.Text = "Ispiši";
            this.btn_Print.ToolTipText = "Ispiši \r\n[F6]";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_PrintPreview
            // 
            this.btn_PrintPreview.AutoSize = false;
            this.btn_PrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintPreview.Image")));
            this.btn_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintPreview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_PrintPreview.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_PrintPreview.Name = "btn_PrintPreview";
            this.btn_PrintPreview.Size = new System.Drawing.Size(22, 22);
            this.btn_PrintPreview.Text = "Pregled ispisa";
            this.btn_PrintPreview.ToolTipText = "Pregled ispisa\r\n[Shift+F6]";
            this.btn_PrintPreview.Click += new System.EventHandler(this.btn_PrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Sort
            // 
            this.btn_Sort.AutoSize = false;
            this.btn_Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sort.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sort.Image")));
            this.btn_Sort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sort.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Sort.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(22, 22);
            this.btn_Sort.Text = "Pregled ispisa";
            this.btn_Sort.ToolTipText = "Sort[F7]";
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Filter.Image = global::Fakturiranje.Properties.Resources.filter_add;
            this.btn_Filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(23, 24);
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.ToolTipText = "Filter [F8]";
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = global::Fakturiranje.Properties.Resources.refresh_icon;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 20);
            this.btn_Refresh.Text = "Osvježi";
            this.btn_Refresh.ToolTipText = "Osvježi [F9]";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(277, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(90, 21);
            this.cbSearch.TabIndex = 1015;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Fakturiranje.Properties.Resources.system_search_16;
            this.btnSearch.Location = new System.Drawing.Point(542, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 22);
            this.btnSearch.TabIndex = 1014;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ViewArtiklForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 433);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.dataGridViewArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ViewArtiklForm";
            this.Text = "Pregled Artikala";
            this.Load += new System.EventHandler(this.ArtiklViewForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArtiklViewForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private ZisCode.Controls.BorderlessToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton btn_AddArtikl;
        private System.Windows.Forms.ToolStripButton btn_EditArtikl;
        private System.Windows.Forms.ToolStripSplitButton btn_DeleteArtikl;
        private System.Windows.Forms.ToolStripMenuItem MENU_DeleteFlag;
        private System.Windows.Forms.ToolStripMenuItem MENU_MultipleDeleteFlag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.ToolStripButton btn_PrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Sort;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel RowBN_lbl_Count;
        private System.Windows.Forms.ToolStripLabel RowBN_lbl_Title;
        private System.Windows.Forms.ToolStripButton RowBN_btn_First;
        private System.Windows.Forms.ToolStripButton RowBN_btn_Previous;
        private System.Windows.Forms.ToolStripTextBox RowBN_txt_Current;
        private System.Windows.Forms.ToolStripButton RowBN_btn_Next;
        private System.Windows.Forms.ToolStripButton RowBN_btn_Last;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ToolStripButton btn_Filter;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
    }
}