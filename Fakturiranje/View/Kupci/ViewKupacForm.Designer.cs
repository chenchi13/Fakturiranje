using System.Windows.Forms;
namespace Fakturiranje.View
{
    partial class ViewKupacForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewKupacForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.MainToolStrip = new ZisCode.Controls.BorderlessToolStrip();
            this.btn_AddKupac = new System.Windows.Forms.ToolStripButton();
            this.btn_EditKupac = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteKupac = new System.Windows.Forms.ToolStripSplitButton();
            this.MENU_DeleteFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_MultipleDeleteFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sort = new System.Windows.Forms.ToolStripButton();
            this.btn_Filter = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.RowBN_lbl_Count = new System.Windows.Forms.ToolStripLabel();
            this.RowBN_lbl_Title = new System.Windows.Forms.ToolStripLabel();
            this.RowBN_btn_First = new System.Windows.Forms.ToolStripButton();
            this.RowBN_btn_Previous = new System.Windows.Forms.ToolStripButton();
            this.RowBN_txt_Current = new System.Windows.Forms.ToolStripTextBox();
            this.RowBN_btn_Next = new System.Windows.Forms.ToolStripButton();
            this.RowBN_btn_Last = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewKupci = new System.Windows.Forms.DataGridView();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(277, 4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(90, 21);
            this.cbSearch.TabIndex = 1019;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Fakturiranje.Properties.Resources.system_search_16;
            this.btnSearch.Location = new System.Drawing.Point(542, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 22);
            this.btnSearch.TabIndex = 1018;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(373, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 1017;
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
            this.btn_AddKupac,
            this.btn_EditKupac,
            this.btn_DeleteKupac,
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
            this.MainToolStrip.TabIndex = 1016;
            this.MainToolStrip.Text = "borderlessToolStrip1";
            // 
            // btn_AddKupac
            // 
            this.btn_AddKupac.AutoSize = false;
            this.btn_AddKupac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddKupac.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddKupac.Image")));
            this.btn_AddKupac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddKupac.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_AddKupac.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_AddKupac.Name = "btn_AddKupac";
            this.btn_AddKupac.Size = new System.Drawing.Size(22, 22);
            this.btn_AddKupac.Text = "Dodaj";
            this.btn_AddKupac.ToolTipText = "Dodaj\r\n [F3]";
            this.btn_AddKupac.Click += new System.EventHandler(this.btn_AddKupac_Click);
            // 
            // btn_EditKupac
            // 
            this.btn_EditKupac.AutoSize = false;
            this.btn_EditKupac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditKupac.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditKupac.Image")));
            this.btn_EditKupac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditKupac.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_EditKupac.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_EditKupac.Name = "btn_EditKupac";
            this.btn_EditKupac.Size = new System.Drawing.Size(22, 22);
            this.btn_EditKupac.Text = "Uredi";
            this.btn_EditKupac.ToolTipText = "Uredi\r\n [F5]";
            this.btn_EditKupac.Click += new System.EventHandler(this.btn_EditKupac_Click);
            // 
            // btn_DeleteKupac
            // 
            this.btn_DeleteKupac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteKupac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_DeleteFlag,
            this.MENU_MultipleDeleteFlag});
            this.btn_DeleteKupac.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteKupac.Image")));
            this.btn_DeleteKupac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteKupac.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_DeleteKupac.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.btn_DeleteKupac.Name = "btn_DeleteKupac";
            this.btn_DeleteKupac.Size = new System.Drawing.Size(32, 25);
            this.btn_DeleteKupac.Text = "Briši";
            this.btn_DeleteKupac.ToolTipText = "Obriši \r\n[Shift+Delete]";
            this.btn_DeleteKupac.ButtonClick += new System.EventHandler(this.btn_DeleteKupac_ButtonClick);
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
            this.btn_Sort.ToolTipText = "Sort\r\n[F7]";
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
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
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
            this.bindingNavigator.TabIndex = 1020;
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
            // dataGridViewKupci
            // 
            this.dataGridViewKupci.AllowUserToAddRows = false;
            this.dataGridViewKupci.AllowUserToDeleteRows = false;
            this.dataGridViewKupci.AllowUserToResizeColumns = false;
            this.dataGridViewKupci.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewKupci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewKupci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKupci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKupci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKupci.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewKupci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewKupci.EnableHeadersVisualStyles = false;
            this.dataGridViewKupci.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewKupci.Name = "dataGridViewKupci";
            this.dataGridViewKupci.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKupci.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewKupci.RowHeadersVisible = false;
            this.dataGridViewKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKupci.Size = new System.Drawing.Size(592, 377);
            this.dataGridViewKupci.TabIndex = 1021;
            // 
            // ViewKupacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 433);
            this.Controls.Add(this.dataGridViewKupci);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.MainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ViewKupacForm";
            this.Text = "Pregled Kupaca";
            this.Load += new System.EventHandler(this.KupciViewForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewKupacForm_KeyDown);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKupci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private ZisCode.Controls.BorderlessToolStrip MainToolStrip;
        private ToolStripButton btn_AddKupac;
        private ToolStripButton btn_EditKupac;
        private ToolStripSplitButton btn_DeleteKupac;
        private ToolStripMenuItem MENU_DeleteFlag;
        private ToolStripMenuItem MENU_MultipleDeleteFlag;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_Print;
        private ToolStripButton btn_PrintPreview;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_Sort;
        private ToolStripButton btn_Filter;
        private ToolStripButton btn_Refresh;
        private BindingNavigator bindingNavigator;
        private ToolStripLabel RowBN_lbl_Count;
        private ToolStripLabel RowBN_lbl_Title;
        private ToolStripButton RowBN_btn_First;
        private ToolStripButton RowBN_btn_Previous;
        private ToolStripTextBox RowBN_txt_Current;
        private ToolStripButton RowBN_btn_Next;
        private ToolStripButton RowBN_btn_Last;
        private DataGridView dataGridViewKupci;


    }
}