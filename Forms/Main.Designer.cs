using PS4_Cheat_Engine.Forms; 
namespace PS4_Cheat_Engine {
    partial class Main {
        private System.Windows.Forms.CheckBox alignment_box;

        private System.Windows.Forms.Label and_label;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_active;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_delete;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_find_pointer;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_hex_view;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_lock;

        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_0;

        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_1;

        private System.Windows.Forms.ToolStripSeparator cheat_list_item_separator_2;

        private System.Windows.Forms.ToolStripMenuItem cheat_list_item_unlock;

        private System.Windows.Forms.ContextMenuStrip cheat_list_menu;

        private System.Windows.Forms.DataGridView cheat_list_view;

        private System.Windows.Forms.DataGridViewButtonColumn cheat_list_view_active;

        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_address;

        private System.Windows.Forms.DataGridViewButtonColumn cheat_list_view_del;

        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_description;

        private System.Windows.Forms.DataGridViewCheckBoxColumn cheat_list_view_lock;

        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_section;

        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_type;

        private System.Windows.Forms.DataGridViewTextBoxColumn cheat_list_view_value;

        private System.Windows.Forms.ComboBox compareTypeList;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.CheckBox hex_box;

        private System.Windows.Forms.ToolStripTextBox ip_box;

        private System.Windows.Forms.ToolStripButton just_connect_btn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button new_scan_btn;

        private System.ComponentModel.BackgroundWorker new_scan_worker;

        private System.Windows.Forms.Button next_scan_btn;

        private System.ComponentModel.BackgroundWorker next_scan_worker;

        private System.Windows.Forms.OpenFileDialog open_file_dialog;

        private System.Windows.Forms.ToolStripTextBox port_box;

        private System.Windows.Forms.ComboBox processes_comboBox;

        private System.Windows.Forms.Button refresh_btn;

        private System.Windows.Forms.Timer refresh_lock;

        private System.Windows.Forms.ContextMenuStrip result_list_menu;

        private System.Windows.Forms.ListView result_list_view;

        private System.Windows.Forms.ToolStripMenuItem result_list_view_add_to_cheat_list;

        private System.Windows.Forms.ColumnHeader result_list_view_address;

        private System.Windows.Forms.ToolStripMenuItem result_list_view_dump_item;

        private System.Windows.Forms.ColumnHeader result_list_view_hex;

        private System.Windows.Forms.ColumnHeader result_list_view_section;

        private System.Windows.Forms.ToolStripSeparator result_list_view_separator;

        private System.Windows.Forms.ColumnHeader result_list_view_type;

        private System.Windows.Forms.ColumnHeader result_list_view_value;

        private System.Windows.Forms.ToolStripMenuItem result_list_view_view_item;

        private System.Windows.Forms.SaveFileDialog save_file_dialog;

        private System.Windows.Forms.ToolStripMenuItem section_dump_menu;

        private System.Windows.Forms.CheckedListBox section_list_box;

        private System.Windows.Forms.ContextMenuStrip section_list_menu;

        private System.Windows.Forms.ToolStripMenuItem section_view_menu;

        private System.Windows.Forms.CheckBox select_all;

        private System.Windows.Forms.ToolStripButton send_payload_btn;

        private System.Windows.Forms.ToolStrip toolStrip2;

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.ComponentModel.BackgroundWorker update_result_list_worker;

        private System.Windows.Forms.TextBox value_1_box;

        private System.Windows.Forms.TextBox value_box;

        private System.Windows.Forms.Label value_label;

        private System.Windows.Forms.ComboBox valueTypeList;

        private System.Windows.Forms.ToolStripComboBox version_list;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cheat_list_view = new System.Windows.Forms.DataGridView();
            this.cheat_list_view_active = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_view_lock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cheat_list_view_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheat_list_view_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cheat_list_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cheat_list_item_hex_view = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.cheat_list_item_lock = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_unlock = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_active = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.cheat_list_item_find_pointer = new System.Windows.Forms.ToolStripMenuItem();
            this.cheat_list_item_separator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.cheat_list_item_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list_view = new System.Windows.Forms.ListView();
            this.result_list_view_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result_list_view_section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.section_list_box = new System.Windows.Forms.CheckedListBox();
            this.value_box = new System.Windows.Forms.TextBox();
            this.hex_box = new System.Windows.Forms.CheckBox();
            this.alignment_box = new System.Windows.Forms.CheckBox();
            this.value_1_box = new System.Windows.Forms.TextBox();
            this.value_label = new System.Windows.Forms.Label();
            this.and_label = new System.Windows.Forms.Label();
            this.select_all = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processes_comboBox = new System.Windows.Forms.ComboBox();
            this.compareTypeList = new System.Windows.Forms.ComboBox();
            this.valueTypeList = new System.Windows.Forms.ComboBox();
            this.next_scan_btn = new System.Windows.Forms.Button();
            this.new_scan_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.section_list_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.section_view_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.section_dump_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_lock = new System.Windows.Forms.Timer(this.components);
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.result_list_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.result_list_view_add_to_cheat_list = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list_view_separator = new System.Windows.Forms.ToolStripSeparator();
            this.result_list_view_view_item = new System.Windows.Forms.ToolStripMenuItem();
            this.result_list_view_dump_item = new System.Windows.Forms.ToolStripMenuItem();
            this.new_scan_worker = new System.ComponentModel.BackgroundWorker();
            this.next_scan_worker = new System.ComponentModel.BackgroundWorker();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.update_result_list_worker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.send_payload_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.just_connect_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ip_box = new System.Windows.Forms.ToolStripTextBox();
            this.port_box = new System.Windows.Forms.ToolStripTextBox();
            this.version_list = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.msg = new System.Windows.Forms.ToolStripLabel();
            this.get_processes_btn = new System.Windows.Forms.Button();
            this.save_cheat_list_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.load_address_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_cheat_list_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.add_address_btn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cheat_list_view)).BeginInit();
            this.cheat_list_menu.SuspendLayout();
            this.section_list_menu.SuspendLayout();
            this.result_list_menu.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheat_list_view
            // 
            this.cheat_list_view.AllowUserToAddRows = false;
            this.cheat_list_view.AllowUserToResizeRows = false;
            this.cheat_list_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cheat_list_view_active,
            this.cheat_list_view_lock,
            this.cheat_list_view_description,
            this.cheat_list_view_address,
            this.cheat_list_view_type,
            this.cheat_list_view_value,
            this.cheat_list_view_section,
            this.cheat_list_view_del});
            this.cheat_list_view.ContextMenuStrip = this.cheat_list_menu;
            this.cheat_list_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cheat_list_view.Location = new System.Drawing.Point(0, 610);
            this.cheat_list_view.Margin = new System.Windows.Forms.Padding(4);
            this.cheat_list_view.Name = "cheat_list_view";
            this.cheat_list_view.RowHeadersVisible = false;
            this.cheat_list_view.RowHeadersWidth = 51;
            this.cheat_list_view.RowTemplate.Height = 23;
            this.cheat_list_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cheat_list_view.Size = new System.Drawing.Size(904, 235);
            this.cheat_list_view.TabIndex = 51;
            this.cheat_list_view.TabStop = false;
            this.cheat_list_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cheat_list_view_CellClick);
            this.cheat_list_view.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cheat_list_view_CellEndEdit);
            this.cheat_list_view.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cheat_list_view_RowsRemoved);
            // 
            // cheat_list_view_active
            // 
            this.cheat_list_view_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "X";
            this.cheat_list_view_active.DefaultCellStyle = dataGridViewCellStyle1;
            this.cheat_list_view_active.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cheat_list_view_active.HeaderText = "X";
            this.cheat_list_view_active.MinimumWidth = 6;
            this.cheat_list_view_active.Name = "cheat_list_view_active";
            this.cheat_list_view_active.Text = "X";
            this.cheat_list_view_active.Width = 20;
            // 
            // cheat_list_view_lock
            // 
            this.cheat_list_view_lock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cheat_list_view_lock.HeaderText = "Locked?";
            this.cheat_list_view_lock.MinimumWidth = 6;
            this.cheat_list_view_lock.Name = "cheat_list_view_lock";
            this.cheat_list_view_lock.Width = 55;
            // 
            // cheat_list_view_description
            // 
            this.cheat_list_view_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cheat_list_view_description.HeaderText = "Description";
            this.cheat_list_view_description.MinimumWidth = 6;
            this.cheat_list_view_description.Name = "cheat_list_view_description";
            this.cheat_list_view_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cheat_list_view_address
            // 
            this.cheat_list_view_address.HeaderText = "Address";
            this.cheat_list_view_address.MinimumWidth = 6;
            this.cheat_list_view_address.Name = "cheat_list_view_address";
            this.cheat_list_view_address.ReadOnly = true;
            this.cheat_list_view_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cheat_list_view_address.Width = 125;
            // 
            // cheat_list_view_type
            // 
            this.cheat_list_view_type.HeaderText = "Type";
            this.cheat_list_view_type.MinimumWidth = 6;
            this.cheat_list_view_type.Name = "cheat_list_view_type";
            this.cheat_list_view_type.ReadOnly = true;
            this.cheat_list_view_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cheat_list_view_type.Width = 125;
            // 
            // cheat_list_view_value
            // 
            this.cheat_list_view_value.HeaderText = "Value";
            this.cheat_list_view_value.MinimumWidth = 6;
            this.cheat_list_view_value.Name = "cheat_list_view_value";
            this.cheat_list_view_value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cheat_list_view_value.Width = 125;
            // 
            // cheat_list_view_section
            // 
            this.cheat_list_view_section.HeaderText = "Section";
            this.cheat_list_view_section.MinimumWidth = 6;
            this.cheat_list_view_section.Name = "cheat_list_view_section";
            this.cheat_list_view_section.ReadOnly = true;
            this.cheat_list_view_section.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cheat_list_view_section.Width = 125;
            // 
            // cheat_list_view_del
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Delete";
            this.cheat_list_view_del.DefaultCellStyle = dataGridViewCellStyle2;
            this.cheat_list_view_del.HeaderText = "Delete";
            this.cheat_list_view_del.MinimumWidth = 6;
            this.cheat_list_view_del.Name = "cheat_list_view_del";
            this.cheat_list_view_del.Width = 50;
            // 
            // cheat_list_menu
            // 
            this.cheat_list_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cheat_list_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_address_btn,
            this.save_cheat_list_btn,
            this.add_address_btn,
            this.refresh_cheat_list_btn,
            this.toolStripSeparator2,
            this.cheat_list_item_hex_view,
            this.cheat_list_item_separator_1,
            this.cheat_list_item_lock,
            this.cheat_list_item_unlock,
            this.cheat_list_item_active,
            this.cheat_list_item_separator_0,
            this.cheat_list_item_find_pointer,
            this.cheat_list_item_separator_2,
            this.cheat_list_item_delete});
            this.cheat_list_menu.Name = "cheat_list_menu";
            this.cheat_list_menu.Size = new System.Drawing.Size(139, 248);
            // 
            // cheat_list_item_hex_view
            // 
            this.cheat_list_item_hex_view.Name = "cheat_list_item_hex_view";
            this.cheat_list_item_hex_view.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_hex_view.Text = "Hex Editor";
            this.cheat_list_item_hex_view.Click += new System.EventHandler(this.cheat_list_item_hex_view_Click);
            // 
            // cheat_list_item_separator_1
            // 
            this.cheat_list_item_separator_1.Name = "cheat_list_item_separator_1";
            this.cheat_list_item_separator_1.Size = new System.Drawing.Size(135, 6);
            // 
            // cheat_list_item_lock
            // 
            this.cheat_list_item_lock.Name = "cheat_list_item_lock";
            this.cheat_list_item_lock.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_lock.Text = "Lock";
            this.cheat_list_item_lock.Click += new System.EventHandler(this.cheat_list_item_lock_Click);
            // 
            // cheat_list_item_unlock
            // 
            this.cheat_list_item_unlock.Name = "cheat_list_item_unlock";
            this.cheat_list_item_unlock.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_unlock.Text = "Unlock";
            this.cheat_list_item_unlock.Click += new System.EventHandler(this.cheat_list_time_unlock_Click);
            // 
            // cheat_list_item_active
            // 
            this.cheat_list_item_active.Name = "cheat_list_item_active";
            this.cheat_list_item_active.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_active.Text = "Active";
            this.cheat_list_item_active.Click += new System.EventHandler(this.cheat_list_item_active_Click);
            // 
            // cheat_list_item_separator_0
            // 
            this.cheat_list_item_separator_0.Name = "cheat_list_item_separator_0";
            this.cheat_list_item_separator_0.Size = new System.Drawing.Size(135, 6);
            // 
            // cheat_list_item_find_pointer
            // 
            this.cheat_list_item_find_pointer.Name = "cheat_list_item_find_pointer";
            this.cheat_list_item_find_pointer.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_find_pointer.Text = "Find Pointer";
            this.cheat_list_item_find_pointer.Click += new System.EventHandler(this.cheat_list_item_find_pointer_Click);
            // 
            // cheat_list_item_separator_2
            // 
            this.cheat_list_item_separator_2.Name = "cheat_list_item_separator_2";
            this.cheat_list_item_separator_2.Size = new System.Drawing.Size(135, 6);
            // 
            // cheat_list_item_delete
            // 
            this.cheat_list_item_delete.Name = "cheat_list_item_delete";
            this.cheat_list_item_delete.Size = new System.Drawing.Size(138, 22);
            this.cheat_list_item_delete.Text = "Delete";
            this.cheat_list_item_delete.Click += new System.EventHandler(this.cheat_list_item_delete_Click);
            // 
            // result_list_view
            // 
            this.result_list_view.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.result_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.result_list_view_address,
            this.result_list_view_type,
            this.result_list_view_value,
            this.result_list_view_hex,
            this.result_list_view_section});
            this.result_list_view.FullRowSelect = true;
            this.result_list_view.GridLines = true;
            this.result_list_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.result_list_view.HideSelection = false;
            this.result_list_view.Location = new System.Drawing.Point(0, 29);
            this.result_list_view.Margin = new System.Windows.Forms.Padding(4);
            this.result_list_view.Name = "result_list_view";
            this.result_list_view.Size = new System.Drawing.Size(610, 573);
            this.result_list_view.TabIndex = 57;
            this.result_list_view.TabStop = false;
            this.result_list_view.UseCompatibleStateImageBehavior = false;
            this.result_list_view.View = System.Windows.Forms.View.Details;
            this.result_list_view.DoubleClick += new System.EventHandler(this.result_list_view_DoubleClick);
            // 
            // result_list_view_address
            // 
            this.result_list_view_address.Text = "Address";
            this.result_list_view_address.Width = 120;
            // 
            // result_list_view_type
            // 
            this.result_list_view_type.Text = "Type";
            this.result_list_view_type.Width = 120;
            // 
            // result_list_view_value
            // 
            this.result_list_view_value.Text = "Value";
            this.result_list_view_value.Width = 120;
            // 
            // result_list_view_hex
            // 
            this.result_list_view_hex.Text = "Hex";
            this.result_list_view_hex.Width = 120;
            // 
            // result_list_view_section
            // 
            this.result_list_view_section.Text = "Section";
            this.result_list_view_section.Width = 180;
            // 
            // section_list_box
            // 
            this.section_list_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section_list_box.CheckOnClick = true;
            this.section_list_box.FormattingEnabled = true;
            this.section_list_box.HorizontalScrollbar = true;
            this.section_list_box.Location = new System.Drawing.Point(620, 109);
            this.section_list_box.Margin = new System.Windows.Forms.Padding(4);
            this.section_list_box.Name = "section_list_box";
            this.section_list_box.Size = new System.Drawing.Size(274, 199);
            this.section_list_box.TabIndex = 66;
            this.section_list_box.TabStop = false;
            this.section_list_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.section_list_box_ItemCheck);
            // 
            // value_box
            // 
            this.value_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.value_box.BackColor = System.Drawing.SystemColors.ControlDark;
            this.value_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_box.ForeColor = System.Drawing.Color.White;
            this.value_box.Location = new System.Drawing.Point(622, 381);
            this.value_box.Margin = new System.Windows.Forms.Padding(4);
            this.value_box.MaxLength = 500;
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(104, 20);
            this.value_box.TabIndex = 69;
            this.value_box.Text = "0";
            // 
            // hex_box
            // 
            this.hex_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hex_box.AutoSize = true;
            this.hex_box.Location = new System.Drawing.Point(622, 409);
            this.hex_box.Margin = new System.Windows.Forms.Padding(4);
            this.hex_box.Name = "hex_box";
            this.hex_box.Size = new System.Drawing.Size(45, 17);
            this.hex_box.TabIndex = 74;
            this.hex_box.Text = "Hex";
            this.hex_box.UseVisualStyleBackColor = true;
            // 
            // alignment_box
            // 
            this.alignment_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alignment_box.AutoSize = true;
            this.alignment_box.Checked = true;
            this.alignment_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alignment_box.Location = new System.Drawing.Point(700, 316);
            this.alignment_box.Margin = new System.Windows.Forms.Padding(4);
            this.alignment_box.Name = "alignment_box";
            this.alignment_box.Size = new System.Drawing.Size(72, 17);
            this.alignment_box.TabIndex = 68;
            this.alignment_box.Text = "Alignment";
            this.alignment_box.UseVisualStyleBackColor = true;
            // 
            // value_1_box
            // 
            this.value_1_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.value_1_box.BackColor = System.Drawing.SystemColors.ControlDark;
            this.value_1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_1_box.ForeColor = System.Drawing.Color.White;
            this.value_1_box.Location = new System.Drawing.Point(767, 381);
            this.value_1_box.Margin = new System.Windows.Forms.Padding(4);
            this.value_1_box.MaxLength = 31;
            this.value_1_box.Name = "value_1_box";
            this.value_1_box.Size = new System.Drawing.Size(98, 20);
            this.value_1_box.TabIndex = 72;
            this.value_1_box.Text = "0";
            // 
            // value_label
            // 
            this.value_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.value_label.AutoSize = true;
            this.value_label.ForeColor = System.Drawing.Color.Black;
            this.value_label.Location = new System.Drawing.Point(764, 364);
            this.value_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(37, 13);
            this.value_label.TabIndex = 73;
            this.value_label.Text = "Value:";
            // 
            // and_label
            // 
            this.and_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.and_label.AutoSize = true;
            this.and_label.Location = new System.Drawing.Point(734, 388);
            this.and_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.and_label.Name = "and_label";
            this.and_label.Size = new System.Drawing.Size(25, 13);
            this.and_label.TabIndex = 71;
            this.and_label.Text = "and";
            // 
            // select_all
            // 
            this.select_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select_all.AutoSize = true;
            this.select_all.ForeColor = System.Drawing.Color.Black;
            this.select_all.Location = new System.Drawing.Point(622, 316);
            this.select_all.Margin = new System.Windows.Forms.Padding(4);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(70, 17);
            this.select_all.TabIndex = 67;
            this.select_all.Text = "Select All";
            this.select_all.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(619, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Value:";
            // 
            // processes_comboBox
            // 
            this.processes_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_comboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.processes_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processes_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processes_comboBox.ForeColor = System.Drawing.Color.White;
            this.processes_comboBox.FormattingEnabled = true;
            this.processes_comboBox.Location = new System.Drawing.Point(620, 65);
            this.processes_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.processes_comboBox.Name = "processes_comboBox";
            this.processes_comboBox.Size = new System.Drawing.Size(222, 21);
            this.processes_comboBox.TabIndex = 75;
            this.processes_comboBox.TabStop = false;
            this.processes_comboBox.SelectedIndexChanged += new System.EventHandler(this.processes_comboBox_SelectedIndexChanged);
            // 
            // compareTypeList
            // 
            this.compareTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compareTypeList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.compareTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compareTypeList.Enabled = false;
            this.compareTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareTypeList.ForeColor = System.Drawing.Color.White;
            this.compareTypeList.FormattingEnabled = true;
            this.compareTypeList.Location = new System.Drawing.Point(624, 508);
            this.compareTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.compareTypeList.Name = "compareTypeList";
            this.compareTypeList.Size = new System.Drawing.Size(241, 21);
            this.compareTypeList.TabIndex = 77;
            this.compareTypeList.SelectedIndexChanged += new System.EventHandler(this.compareList_SelectedIndexChanged);
            // 
            // valueTypeList
            // 
            this.valueTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTypeList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.valueTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valueTypeList.Enabled = false;
            this.valueTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueTypeList.ForeColor = System.Drawing.Color.White;
            this.valueTypeList.FormattingEnabled = true;
            this.valueTypeList.Location = new System.Drawing.Point(622, 456);
            this.valueTypeList.Margin = new System.Windows.Forms.Padding(4);
            this.valueTypeList.Name = "valueTypeList";
            this.valueTypeList.Size = new System.Drawing.Size(243, 21);
            this.valueTypeList.TabIndex = 76;
            this.valueTypeList.SelectedIndexChanged += new System.EventHandler(this.valueTypeList_SelectedIndexChanged);
            // 
            // next_scan_btn
            // 
            this.next_scan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_scan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.next_scan_btn.Enabled = false;
            this.next_scan_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.next_scan_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.next_scan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.next_scan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_scan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_scan_btn.ForeColor = System.Drawing.Color.White;
            this.next_scan_btn.Location = new System.Drawing.Point(753, 537);
            this.next_scan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.next_scan_btn.Name = "next_scan_btn";
            this.next_scan_btn.Size = new System.Drawing.Size(123, 28);
            this.next_scan_btn.TabIndex = 80;
            this.next_scan_btn.Text = "Next Scan";
            this.next_scan_btn.UseMnemonic = false;
            this.next_scan_btn.UseVisualStyleBackColor = false;
            this.next_scan_btn.Click += new System.EventHandler(this.next_scan_btn_Click);
            // 
            // new_scan_btn
            // 
            this.new_scan_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_scan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.new_scan_btn.Enabled = false;
            this.new_scan_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.new_scan_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.new_scan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.new_scan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_scan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_scan_btn.ForeColor = System.Drawing.Color.White;
            this.new_scan_btn.Location = new System.Drawing.Point(622, 537);
            this.new_scan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.new_scan_btn.Name = "new_scan_btn";
            this.new_scan_btn.Size = new System.Drawing.Size(123, 28);
            this.new_scan_btn.TabIndex = 78;
            this.new_scan_btn.Text = "New Scan";
            this.new_scan_btn.UseMnemonic = false;
            this.new_scan_btn.UseVisualStyleBackColor = false;
            this.new_scan_btn.Click += new System.EventHandler(this.new_scan_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.refresh_btn.Enabled = false;
            this.refresh_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.refresh_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(622, 573);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(254, 28);
            this.refresh_btn.TabIndex = 79;
            this.refresh_btn.Text = "Refresh Result List";
            this.refresh_btn.UseMnemonic = false;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_Click);
            // 
            // section_list_menu
            // 
            this.section_list_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.section_list_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_view_menu,
            this.section_dump_menu});
            this.section_list_menu.Name = "section_list_boxMenu";
            this.section_list_menu.Size = new System.Drawing.Size(130, 48);
            // 
            // section_view_menu
            // 
            this.section_view_menu.Name = "section_view_menu";
            this.section_view_menu.Size = new System.Drawing.Size(129, 22);
            this.section_view_menu.Text = "Hex Editor";
            this.section_view_menu.Click += new System.EventHandler(this.sectionView_Click);
            // 
            // section_dump_menu
            // 
            this.section_dump_menu.Name = "section_dump_menu";
            this.section_dump_menu.Size = new System.Drawing.Size(129, 22);
            this.section_dump_menu.Text = "Dump";
            this.section_dump_menu.Click += new System.EventHandler(this.sectionDump_Click);
            // 
            // refresh_lock
            // 
            this.refresh_lock.Enabled = true;
            this.refresh_lock.Interval = 500;
            this.refresh_lock.Tick += new System.EventHandler(this.refresh_lock_Tick);
            // 
            // result_list_menu
            // 
            this.result_list_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.result_list_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.result_list_view_add_to_cheat_list,
            this.result_list_view_separator,
            this.result_list_view_view_item,
            this.result_list_view_dump_item});
            this.result_list_menu.Name = "result_list_menu";
            this.result_list_menu.Size = new System.Drawing.Size(166, 76);
            // 
            // result_list_view_add_to_cheat_list
            // 
            this.result_list_view_add_to_cheat_list.Name = "result_list_view_add_to_cheat_list";
            this.result_list_view_add_to_cheat_list.Size = new System.Drawing.Size(165, 22);
            this.result_list_view_add_to_cheat_list.Text = "Add to Cheat List";
            this.result_list_view_add_to_cheat_list.Click += new System.EventHandler(this.result_list_view_add_to_cheat_list_Click);
            // 
            // result_list_view_separator
            // 
            this.result_list_view_separator.Name = "result_list_view_separator";
            this.result_list_view_separator.Size = new System.Drawing.Size(162, 6);
            // 
            // result_list_view_view_item
            // 
            this.result_list_view_view_item.Name = "result_list_view_view_item";
            this.result_list_view_view_item.Size = new System.Drawing.Size(165, 22);
            this.result_list_view_view_item.Text = "Hex Editor";
            this.result_list_view_view_item.Click += new System.EventHandler(this.result_list_view_hex_item_Click);
            // 
            // result_list_view_dump_item
            // 
            this.result_list_view_dump_item.Name = "result_list_view_dump_item";
            this.result_list_view_dump_item.Size = new System.Drawing.Size(165, 22);
            this.result_list_view_dump_item.Text = "Dump";
            this.result_list_view_dump_item.Click += new System.EventHandler(this.dump_item_Click);
            // 
            // new_scan_worker
            // 
            this.new_scan_worker.WorkerReportsProgress = true;
            this.new_scan_worker.WorkerSupportsCancellation = true;
            this.new_scan_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.new_scan_worker_DoWork);
            this.new_scan_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.new_scan_worker_ProgressChanged);
            this.new_scan_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.new_scan_worker_RunWorkerCompleted);
            // 
            // next_scan_worker
            // 
            this.next_scan_worker.WorkerReportsProgress = true;
            this.next_scan_worker.WorkerSupportsCancellation = true;
            this.next_scan_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.next_scan_worker_DoWork);
            this.next_scan_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.update_result_list_worker_ProgressChanged);
            this.next_scan_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.next_scan_worker_RunWorkerCompleted);
            // 
            // update_result_list_worker
            // 
            this.update_result_list_worker.WorkerReportsProgress = true;
            this.update_result_list_worker.WorkerSupportsCancellation = true;
            this.update_result_list_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.update_result_list_worker_DoWork);
            this.update_result_list_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.update_result_list_worker_ProgressChanged);
            this.update_result_list_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.update_result_list_worker_RunWorkerCompleted);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.send_payload_btn,
            this.toolStripSeparator1,
            this.just_connect_btn,
            this.toolStripDropDownButton1,
            this.progressBar,
            this.msg});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(904, 25);
            this.toolStrip2.TabIndex = 87;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // send_payload_btn
            // 
            this.send_payload_btn.Image = ((System.Drawing.Image)(resources.GetObject("send_payload_btn.Image")));
            this.send_payload_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.send_payload_btn.Name = "send_payload_btn";
            this.send_payload_btn.Size = new System.Drawing.Size(56, 22);
            this.send_payload_btn.Text = "Inject";
            this.send_payload_btn.Click += new System.EventHandler(this.send_payload_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // just_connect_btn
            // 
            this.just_connect_btn.Image = ((System.Drawing.Image)(resources.GetObject("just_connect_btn.Image")));
            this.just_connect_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.just_connect_btn.Name = "just_connect_btn";
            this.just_connect_btn.Size = new System.Drawing.Size(72, 22);
            this.just_connect_btn.Text = "Connect";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ip_box,
            this.port_box,
            this.version_list});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(120, 22);
            this.toolStripDropDownButton1.Text = "Connection Details";
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(100, 23);
            this.ip_box.Text = "Enter PS4 IP here";
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(100, 23);
            this.port_box.Text = "9021";
            // 
            // version_list
            // 
            this.version_list.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.version_list.Items.AddRange(new object[] {
            "5.05",
            "6.72",
            "7.02",
            "7.55",
            "9.00"});
            this.version_list.Name = "version_list";
            this.version_list.Size = new System.Drawing.Size(121, 23);
            this.version_list.Text = "PS4 FW";
            this.version_list.SelectedIndexChanged += new System.EventHandler(this.version_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "PS4 Process List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Process Memory Sections";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Value Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Scan Type";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 22);
            // 
            // msg
            // 
            this.msg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(38, 22);
            this.msg.Text = "status";
            // 
            // get_processes_btn
            // 
            this.get_processes_btn.Location = new System.Drawing.Point(844, 63);
            this.get_processes_btn.Name = "get_processes_btn";
            this.get_processes_btn.Size = new System.Drawing.Size(58, 23);
            this.get_processes_btn.TabIndex = 92;
            this.get_processes_btn.Text = "Refresh";
            this.get_processes_btn.UseVisualStyleBackColor = true;
            this.get_processes_btn.Click += new System.EventHandler(this.get_processes_btn_Click);
            // 
            // save_cheat_list_btn
            // 
            this.save_cheat_list_btn.Name = "save_cheat_list_btn";
            this.save_cheat_list_btn.Size = new System.Drawing.Size(138, 22);
            this.save_cheat_list_btn.Text = "Save";
            this.save_cheat_list_btn.Click += new System.EventHandler(this.save_address_btn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // load_address_btn
            // 
            this.load_address_btn.Name = "load_address_btn";
            this.load_address_btn.Size = new System.Drawing.Size(138, 22);
            this.load_address_btn.Text = "Load";
            this.load_address_btn.Click += new System.EventHandler(this.load_address_btn_Click);
            // 
            // refresh_cheat_list_btn
            // 
            this.refresh_cheat_list_btn.Name = "refresh_cheat_list_btn";
            this.refresh_cheat_list_btn.Size = new System.Drawing.Size(138, 22);
            this.refresh_cheat_list_btn.Text = "Refresh";
            this.refresh_cheat_list_btn.Click += new System.EventHandler(this.refresh_cheat_list_Click);
            // 
            // add_address_btn
            // 
            this.add_address_btn.Name = "add_address_btn";
            this.add_address_btn.Size = new System.Drawing.Size(138, 22);
            this.add_address_btn.Text = "New";
            this.add_address_btn.Click += new System.EventHandler(this.add_address_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 845);
            this.Controls.Add(this.get_processes_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.compareTypeList);
            this.Controls.Add(this.valueTypeList);
            this.Controls.Add(this.next_scan_btn);
            this.Controls.Add(this.new_scan_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.processes_comboBox);
            this.Controls.Add(this.value_box);
            this.Controls.Add(this.hex_box);
            this.Controls.Add(this.alignment_box);
            this.Controls.Add(this.value_1_box);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.and_label);
            this.Controls.Add(this.select_all);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.section_list_box);
            this.Controls.Add(this.result_list_view);
            this.Controls.Add(this.cheat_list_view);
            this.Name = "Main";
            this.Text = "PS4 Cheat Engine | v - Forked/Maintained By A0ZHAR";
            ((System.ComponentModel.ISupportInitialize)(this.cheat_list_view)).EndInit();
            this.cheat_list_menu.ResumeLayout(false);
            this.section_list_menu.ResumeLayout(false);
            this.result_list_menu.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripLabel msg;
        private System.Windows.Forms.Button get_processes_btn;
        private System.Windows.Forms.ToolStripMenuItem refresh_cheat_list_btn;
        private System.Windows.Forms.ToolStripMenuItem load_address_btn;
        private System.Windows.Forms.ToolStripMenuItem add_address_btn;
        private System.Windows.Forms.ToolStripMenuItem save_cheat_list_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

