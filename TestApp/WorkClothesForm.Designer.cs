namespace TestApp
{
    partial class WorkClothesForm
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
            this.label_Height = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            this.cb_WorkClothesSubtype = new System.Windows.Forms.ComboBox();
            this.label_WorkClothesSubtype = new System.Windows.Forms.Label();
            this.label_WorkClothesType = new System.Windows.Forms.Label();
            this.nud_Size = new System.Windows.Forms.NumericUpDown();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_WorkClothesType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(87, 143);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(34, 13);
            this.label_Height.TabIndex = 22;
            this.label_Height.Text = "Рост:";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Location = new System.Drawing.Point(72, 116);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(49, 13);
            this.label_Size.TabIndex = 21;
            this.label_Size.Text = "Размер:";
            // 
            // cb_WorkClothesSubtype
            // 
            this.cb_WorkClothesSubtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_WorkClothesSubtype.FormattingEnabled = true;
            this.cb_WorkClothesSubtype.Location = new System.Drawing.Point(127, 53);
            this.cb_WorkClothesSubtype.Name = "cb_WorkClothesSubtype";
            this.cb_WorkClothesSubtype.Size = new System.Drawing.Size(189, 21);
            this.cb_WorkClothesSubtype.TabIndex = 20;
            // 
            // label_WorkClothesSubtype
            // 
            this.label_WorkClothesSubtype.AutoSize = true;
            this.label_WorkClothesSubtype.Location = new System.Drawing.Point(74, 56);
            this.label_WorkClothesSubtype.Name = "label_WorkClothesSubtype";
            this.label_WorkClothesSubtype.Size = new System.Drawing.Size(47, 13);
            this.label_WorkClothesSubtype.TabIndex = 19;
            this.label_WorkClothesSubtype.Text = "Подтип:";
            // 
            // label_WorkClothesType
            // 
            this.label_WorkClothesType.AutoSize = true;
            this.label_WorkClothesType.Location = new System.Drawing.Point(25, 30);
            this.label_WorkClothesType.Name = "label_WorkClothesType";
            this.label_WorkClothesType.Size = new System.Drawing.Size(96, 13);
            this.label_WorkClothesType.TabIndex = 18;
            this.label_WorkClothesType.Text = "Тип спецодежды:";
            // 
            // nud_Size
            // 
            this.nud_Size.Location = new System.Drawing.Point(127, 114);
            this.nud_Size.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Size.Name = "nud_Size";
            this.nud_Size.Size = new System.Drawing.Size(59, 20);
            this.nud_Size.TabIndex = 23;
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(127, 141);
            this.nud_Height.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(59, 20);
            this.nud_Height.TabIndex = 24;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(219, 230);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Text = "Сохранить";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(314, 230);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 26;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(127, 167);
            this.nud_Quantity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(59, 20);
            this.nud_Quantity.TabIndex = 28;
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(54, 169);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(69, 13);
            this.label_Quantity.TabIndex = 27;
            this.label_Quantity.Text = "Количество:";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(61, 83);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 29;
            this.label_Description.Text = "Описание:";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(127, 80);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(189, 20);
            this.tb_Description.TabIndex = 30;
            // 
            // tb_WorkClothesType
            // 
            this.tb_WorkClothesType.Enabled = false;
            this.tb_WorkClothesType.Location = new System.Drawing.Point(127, 27);
            this.tb_WorkClothesType.Name = "tb_WorkClothesType";
            this.tb_WorkClothesType.Size = new System.Drawing.Size(188, 20);
            this.tb_WorkClothesType.TabIndex = 31;
            // 
            // WorkClothesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 265);
            this.Controls.Add(this.tb_WorkClothesType);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.nud_Quantity);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.nud_Height);
            this.Controls.Add(this.nud_Size);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.cb_WorkClothesSubtype);
            this.Controls.Add(this.label_WorkClothesSubtype);
            this.Controls.Add(this.label_WorkClothesType);
            this.Name = "WorkClothesForm";
            this.Text = "Спецодежда";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_WorkClothesSubtype;
        private System.Windows.Forms.Label label_WorkClothesType;
        protected internal System.Windows.Forms.ComboBox cb_WorkClothesSubtype;
        protected internal System.Windows.Forms.NumericUpDown nud_Size;
        protected internal System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        protected internal System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_Description;
        protected internal System.Windows.Forms.TextBox tb_Description;
        protected internal System.Windows.Forms.TextBox tb_WorkClothesType;
    }
}