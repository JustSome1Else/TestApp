namespace TestApp
{
    partial class MainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cb_WorkClothesType = new System.Windows.Forms.ComboBox();
            this.label_WorkClothesType = new System.Windows.Forms.Label();
            this.label_WorkClothesSubtype = new System.Windows.Forms.Label();
            this.cb_WorkClothesSubtype = new System.Windows.Forms.ComboBox();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LoadTestData = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.bnt_Edit = new System.Windows.Forms.Button();
            this.nud_SizeMin = new System.Windows.Forms.NumericUpDown();
            this.nud_SizeMax = new System.Windows.Forms.NumericUpDown();
            this.nud_HeightMin = new System.Windows.Forms.NumericUpDown();
            this.nud_HeightMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SizeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SizeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightMax)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 191);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(776, 300);
            this.dgv.TabIndex = 0;
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            // 
            // cb_WorkClothesType
            // 
            this.cb_WorkClothesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_WorkClothesType.FormattingEnabled = true;
            this.cb_WorkClothesType.Items.AddRange(new object[] {
            "верхняя одежда"});
            this.cb_WorkClothesType.Location = new System.Drawing.Point(101, 12);
            this.cb_WorkClothesType.Name = "cb_WorkClothesType";
            this.cb_WorkClothesType.Size = new System.Drawing.Size(189, 21);
            this.cb_WorkClothesType.TabIndex = 1;
            this.cb_WorkClothesType.SelectedValueChanged += new System.EventHandler(this.cb_WorkClothesType_SelectedValueChanged);
            // 
            // label_WorkClothesType
            // 
            this.label_WorkClothesType.AutoSize = true;
            this.label_WorkClothesType.Location = new System.Drawing.Point(66, 15);
            this.label_WorkClothesType.Name = "label_WorkClothesType";
            this.label_WorkClothesType.Size = new System.Drawing.Size(29, 13);
            this.label_WorkClothesType.TabIndex = 2;
            this.label_WorkClothesType.Text = "Тип:";
            // 
            // label_WorkClothesSubtype
            // 
            this.label_WorkClothesSubtype.AutoSize = true;
            this.label_WorkClothesSubtype.Location = new System.Drawing.Point(38, 26);
            this.label_WorkClothesSubtype.Name = "label_WorkClothesSubtype";
            this.label_WorkClothesSubtype.Size = new System.Drawing.Size(47, 13);
            this.label_WorkClothesSubtype.TabIndex = 3;
            this.label_WorkClothesSubtype.Text = "Подтип:";
            // 
            // cb_WorkClothesSubtype
            // 
            this.cb_WorkClothesSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_WorkClothesSubtype.FormattingEnabled = true;
            this.cb_WorkClothesSubtype.Location = new System.Drawing.Point(89, 23);
            this.cb_WorkClothesSubtype.Name = "cb_WorkClothesSubtype";
            this.cb_WorkClothesSubtype.Size = new System.Drawing.Size(189, 21);
            this.cb_WorkClothesSubtype.TabIndex = 4;
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Location = new System.Drawing.Point(34, 52);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(49, 13);
            this.label_Size.TabIndex = 5;
            this.label_Size.Text = "Размер:";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(49, 79);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(34, 13);
            this.label_Height.TabIndex = 8;
            this.label_Height.Text = "Рост:";
            this.label_Height.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            this.label3.Visible = false;
            // 
            // btn_LoadTestData
            // 
            this.btn_LoadTestData.Location = new System.Drawing.Point(608, 18);
            this.btn_LoadTestData.Name = "btn_LoadTestData";
            this.btn_LoadTestData.Size = new System.Drawing.Size(180, 45);
            this.btn_LoadTestData.TabIndex = 13;
            this.btn_LoadTestData.Text = "Очистить базу и загрузить тестовые данные";
            this.btn_LoadTestData.UseVisualStyleBackColor = true;
            this.btn_LoadTestData.Click += new System.EventHandler(this.btn_LoadTestData_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(168, 503);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(473, 503);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // bnt_Edit
            // 
            this.bnt_Edit.Location = new System.Drawing.Point(322, 503);
            this.bnt_Edit.Name = "bnt_Edit";
            this.bnt_Edit.Size = new System.Drawing.Size(75, 23);
            this.bnt_Edit.TabIndex = 20;
            this.bnt_Edit.Text = "Изменить";
            this.bnt_Edit.UseVisualStyleBackColor = true;
            this.bnt_Edit.Click += new System.EventHandler(this.bnt_Edit_Click);
            // 
            // nud_SizeMin
            // 
            this.nud_SizeMin.Location = new System.Drawing.Point(89, 50);
            this.nud_SizeMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_SizeMin.Name = "nud_SizeMin";
            this.nud_SizeMin.Size = new System.Drawing.Size(46, 20);
            this.nud_SizeMin.TabIndex = 21;
            // 
            // nud_SizeMax
            // 
            this.nud_SizeMax.Location = new System.Drawing.Point(157, 50);
            this.nud_SizeMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_SizeMax.Name = "nud_SizeMax";
            this.nud_SizeMax.Size = new System.Drawing.Size(53, 20);
            this.nud_SizeMax.TabIndex = 22;
            this.nud_SizeMax.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nud_HeightMin
            // 
            this.nud_HeightMin.Location = new System.Drawing.Point(89, 76);
            this.nud_HeightMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_HeightMin.Name = "nud_HeightMin";
            this.nud_HeightMin.Size = new System.Drawing.Size(46, 20);
            this.nud_HeightMin.TabIndex = 23;
            this.nud_HeightMin.Visible = false;
            // 
            // nud_HeightMax
            // 
            this.nud_HeightMax.Location = new System.Drawing.Point(157, 76);
            this.nud_HeightMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_HeightMax.Name = "nud_HeightMax";
            this.nud_HeightMax.Size = new System.Drawing.Size(53, 20);
            this.nud_HeightMax.TabIndex = 24;
            this.nud_HeightMax.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_HeightMax.Visible = false;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.btn_ApplyFilter);
            this.groupBox_Filter.Controls.Add(this.cb_WorkClothesSubtype);
            this.groupBox_Filter.Controls.Add(this.nud_HeightMax);
            this.groupBox_Filter.Controls.Add(this.nud_HeightMin);
            this.groupBox_Filter.Controls.Add(this.label_WorkClothesSubtype);
            this.groupBox_Filter.Controls.Add(this.nud_SizeMax);
            this.groupBox_Filter.Controls.Add(this.label_Size);
            this.groupBox_Filter.Controls.Add(this.nud_SizeMin);
            this.groupBox_Filter.Controls.Add(this.label_Height);
            this.groupBox_Filter.Controls.Add(this.label2);
            this.groupBox_Filter.Controls.Add(this.label3);
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 62);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(388, 107);
            this.groupBox_Filter.TabIndex = 26;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Фильтр";
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.Location = new System.Drawing.Point(297, 73);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_ApplyFilter.TabIndex = 27;
            this.btn_ApplyFilter.Text = "Найти";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            this.btn_ApplyFilter.Click += new System.EventHandler(this.btn_ApplyFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 539);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.cb_WorkClothesType);
            this.Controls.Add(this.bnt_Edit);
            this.Controls.Add(this.label_WorkClothesType);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_LoadTestData);
            this.Controls.Add(this.dgv);
            this.Name = "MainForm";
            this.Text = "TestApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SizeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SizeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HeightMax)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cb_WorkClothesType;
        private System.Windows.Forms.Label label_WorkClothesType;
        private System.Windows.Forms.Label label_WorkClothesSubtype;
        private System.Windows.Forms.ComboBox cb_WorkClothesSubtype;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LoadTestData;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button bnt_Edit;
        private System.Windows.Forms.NumericUpDown nud_SizeMin;
        private System.Windows.Forms.NumericUpDown nud_SizeMax;
        private System.Windows.Forms.NumericUpDown nud_HeightMin;
        private System.Windows.Forms.NumericUpDown nud_HeightMax;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Button btn_ApplyFilter;
    }
}

