namespace epam.Pronin.SummerPractice
{
    partial class GetUserLot
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.summerPracticeDataSet = new epam.Pronin.SummerPractice.SummerPracticeDataSet();
            this.getAllUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllUsersTableAdapter = new epam.Pronin.SummerPractice.SummerPracticeDataSetTableAdapters.GetAllUsersTableAdapter();
            this.getAllLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllLotsTableAdapter = new epam.Pronin.SummerPractice.SummerPracticeDataSetTableAdapters.GetAllLotsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Приобретение лота пользователем";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(544, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Лот";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.getAllUsersBindingSource;
            this.comboBox1.DisplayMember = "NameUser";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "Id_User";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.getAllLotsBindingSource;
            this.comboBox2.DisplayMember = "Name_Lot";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(448, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "Id_Lot";
            // 
            // summerPracticeDataSet
            // 
            this.summerPracticeDataSet.DataSetName = "SummerPracticeDataSet";
            this.summerPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllUsersBindingSource
            // 
            this.getAllUsersBindingSource.DataMember = "GetAllUsers";
            this.getAllUsersBindingSource.DataSource = this.summerPracticeDataSet;
            // 
            // getAllUsersTableAdapter
            // 
            this.getAllUsersTableAdapter.ClearBeforeFill = true;
            // 
            // getAllLotsBindingSource
            // 
            this.getAllLotsBindingSource.DataMember = "GetAllLots";
            this.getAllLotsBindingSource.DataSource = this.summerPracticeDataSet;
            // 
            // getAllLotsTableAdapter
            // 
            this.getAllLotsTableAdapter.ClearBeforeFill = true;
            // 
            // GetUserLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GetUserLot";
            this.Text = "GetUserLot";
            this.Load += new System.EventHandler(this.GetUserLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private SummerPracticeDataSet summerPracticeDataSet;
        private System.Windows.Forms.BindingSource getAllUsersBindingSource;
        private SummerPracticeDataSetTableAdapters.GetAllUsersTableAdapter getAllUsersTableAdapter;
        private System.Windows.Forms.BindingSource getAllLotsBindingSource;
        private SummerPracticeDataSetTableAdapters.GetAllLotsTableAdapter getAllLotsTableAdapter;
    }
}