namespace WinFormCustomer
{
    partial class FormCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.billDateTxt = new System.Windows.Forms.TextBox();
            this.billAmountTxt = new System.Windows.Forms.TextBox();
            this.phnNumber = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dalType = new System.Windows.Forms.ComboBox();
            this.uowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bill Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.comboBox1.Location = new System.Drawing.Point(103, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(104, 87);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(154, 23);
            this.custName.TabIndex = 8;
            // 
            // billDateTxt
            // 
            this.billDateTxt.Location = new System.Drawing.Point(451, 87);
            this.billDateTxt.Name = "billDateTxt";
            this.billDateTxt.Size = new System.Drawing.Size(154, 23);
            this.billDateTxt.TabIndex = 9;
            // 
            // billAmountTxt
            // 
            this.billAmountTxt.Location = new System.Drawing.Point(451, 41);
            this.billAmountTxt.Name = "billAmountTxt";
            this.billAmountTxt.Size = new System.Drawing.Size(154, 23);
            this.billAmountTxt.TabIndex = 10;
            // 
            // phnNumber
            // 
            this.phnNumber.Location = new System.Drawing.Point(104, 122);
            this.phnNumber.Name = "phnNumber";
            this.phnNumber.Size = new System.Drawing.Size(154, 23);
            this.phnNumber.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(451, 122);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(154, 91);
            this.addressTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(41, 288);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowTemplate.Height = 25;
            this.dtgCustomer.Size = new System.Drawing.Size(724, 229);
            this.dtgCustomer.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dalType
            // 
            this.dalType.FormattingEnabled = true;
            this.dalType.Location = new System.Drawing.Point(634, 41);
            this.dalType.Name = "dalType";
            this.dalType.Size = new System.Drawing.Size(131, 23);
            this.dalType.TabIndex = 16;
            this.dalType.SelectedIndexChanged += new System.EventHandler(this.dalType_SelectedIndexChanged);
            // 
            // uowBtn
            // 
            this.uowBtn.Location = new System.Drawing.Point(634, 176);
            this.uowBtn.Name = "uowBtn";
            this.uowBtn.Size = new System.Drawing.Size(86, 37);
            this.uowBtn.TabIndex = 17;
            this.uowBtn.Text = "UoW";
            this.uowBtn.UseVisualStyleBackColor = true;
            this.uowBtn.Click += new System.EventHandler(this.uowBtn_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.uowBtn);
            this.Controls.Add(this.dalType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phnNumber);
            this.Controls.Add(this.billAmountTxt);
            this.Controls.Add(this.billDateTxt);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox custName;
        private TextBox billDateTxt;
        private TextBox billAmountTxt;
        private TextBox phnNumber;
        private TextBox addressTextBox;
        private Button button1;
        private DataGridView dtgCustomer;
        private Button btnAdd;
        private ComboBox dalType;
        private Button uowBtn;
    }
}