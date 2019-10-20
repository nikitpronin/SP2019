namespace epam.Pronin.SummerPractice
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.summerPracticeDataSet = new epam.Pronin.SummerPractice.SummerPracticeDataSet();
            this.getAllLotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllLotsTableAdapter = new epam.Pronin.SummerPractice.SummerPracticeDataSetTableAdapters.GetAllLotsTableAdapter();
            this.idLotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.summerPracticeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.getAllLotsAndUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllLotsAndUsersTableAdapter = new epam.Pronin.SummerPractice.SummerPracticeDataSetTableAdapters.GetAllLotsAndUsersTableAdapter();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsAndUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аукцион";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить лот";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(162, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Удалить лот";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLotDataGridViewTextBoxColumn,
            this.nameLotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getAllLotsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 267);
            this.dataGridView1.TabIndex = 19;
            // 
            // summerPracticeDataSet
            // 
            this.summerPracticeDataSet.DataSetName = "SummerPracticeDataSet";
            this.summerPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idLotDataGridViewTextBoxColumn
            // 
            this.idLotDataGridViewTextBoxColumn.DataPropertyName = "Id_Lot";
            this.idLotDataGridViewTextBoxColumn.HeaderText = "Id_Lot";
            this.idLotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLotDataGridViewTextBoxColumn.Name = "idLotDataGridViewTextBoxColumn";
            this.idLotDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLotDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameLotDataGridViewTextBoxColumn
            // 
            this.nameLotDataGridViewTextBoxColumn.DataPropertyName = "Name_Lot";
            this.nameLotDataGridViewTextBoxColumn.HeaderText = "Name_Lot";
            this.nameLotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameLotDataGridViewTextBoxColumn.Name = "nameLotDataGridViewTextBoxColumn";
            this.nameLotDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(79, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 51);
            this.button3.TabIndex = 20;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(478, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 51);
            this.button4.TabIndex = 23;
            this.button4.Text = "Приобрести лот";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.lotIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.getAllLotsAndUsersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(377, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(346, 267);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // summerPracticeDataSetBindingSource
            // 
            this.summerPracticeDataSetBindingSource.DataSource = this.summerPracticeDataSet;
            this.summerPracticeDataSetBindingSource.Position = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(483, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 51);
            this.button5.TabIndex = 25;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // getAllLotsAndUsersBindingSource
            // 
            this.getAllLotsAndUsersBindingSource.DataMember = "GetAllLotsAndUsers";
            this.getAllLotsAndUsersBindingSource.DataSource = this.summerPracticeDataSetBindingSource;
            // 
            // getAllLotsAndUsersTableAdapter
            // 
            this.getAllLotsAndUsersTableAdapter.ClearBeforeFill = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lotIdDataGridViewTextBoxColumn
            // 
            this.lotIdDataGridViewTextBoxColumn.DataPropertyName = "LotId";
            this.lotIdDataGridViewTextBoxColumn.HeaderText = "LotId";
            this.lotIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lotIdDataGridViewTextBoxColumn.Name = "lotIdDataGridViewTextBoxColumn";
            this.lotIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 559);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summerPracticeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLotsAndUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SummerPracticeDataSet summerPracticeDataSet;
        private System.Windows.Forms.BindingSource getAllLotsBindingSource;
        private SummerPracticeDataSetTableAdapters.GetAllLotsTableAdapter getAllLotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLotDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource summerPracticeDataSetBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource getAllLotsAndUsersBindingSource;
        private SummerPracticeDataSetTableAdapters.GetAllLotsAndUsersTableAdapter getAllLotsAndUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotIdDataGridViewTextBoxColumn;
    }
}