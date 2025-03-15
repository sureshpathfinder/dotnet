namespace DataSample
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new DataSample.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPNODataGridViewTextBoxColumn,
            this.eNAMEDataGridViewTextBoxColumn,
            this.jOBDataGridViewTextBoxColumn,
            this.mGRDataGridViewTextBoxColumn,
            this.hIREDATEDataGridViewTextBoxColumn,
            this.sALDataGridViewTextBoxColumn,
            this.cOMMDataGridViewTextBoxColumn,
            this.dEPTNODataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "EMP";
            this.dataGridView1.DataSource = this.dataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // eMPNODataGridViewTextBoxColumn
            // 
            this.eMPNODataGridViewTextBoxColumn.DataPropertyName = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.HeaderText = "EMPNO";
            this.eMPNODataGridViewTextBoxColumn.Name = "eMPNODataGridViewTextBoxColumn";
            // 
            // eNAMEDataGridViewTextBoxColumn
            // 
            this.eNAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.HeaderText = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.Name = "eNAMEDataGridViewTextBoxColumn";
            // 
            // jOBDataGridViewTextBoxColumn
            // 
            this.jOBDataGridViewTextBoxColumn.DataPropertyName = "JOB";
            this.jOBDataGridViewTextBoxColumn.HeaderText = "JOB";
            this.jOBDataGridViewTextBoxColumn.Name = "jOBDataGridViewTextBoxColumn";
            // 
            // mGRDataGridViewTextBoxColumn
            // 
            this.mGRDataGridViewTextBoxColumn.DataPropertyName = "MGR";
            this.mGRDataGridViewTextBoxColumn.HeaderText = "MGR";
            this.mGRDataGridViewTextBoxColumn.Name = "mGRDataGridViewTextBoxColumn";
            // 
            // hIREDATEDataGridViewTextBoxColumn
            // 
            this.hIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIREDATE";
            this.hIREDATEDataGridViewTextBoxColumn.HeaderText = "HIREDATE";
            this.hIREDATEDataGridViewTextBoxColumn.Name = "hIREDATEDataGridViewTextBoxColumn";
            // 
            // sALDataGridViewTextBoxColumn
            // 
            this.sALDataGridViewTextBoxColumn.DataPropertyName = "SAL";
            this.sALDataGridViewTextBoxColumn.HeaderText = "SAL";
            this.sALDataGridViewTextBoxColumn.Name = "sALDataGridViewTextBoxColumn";
            // 
            // cOMMDataGridViewTextBoxColumn
            // 
            this.cOMMDataGridViewTextBoxColumn.DataPropertyName = "COMM";
            this.cOMMDataGridViewTextBoxColumn.HeaderText = "COMM";
            this.cOMMDataGridViewTextBoxColumn.Name = "cOMMDataGridViewTextBoxColumn";
            // 
            // dEPTNODataGridViewTextBoxColumn
            // 
            this.dEPTNODataGridViewTextBoxColumn.DataPropertyName = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn.HeaderText = "DEPTNO";
            this.dEPTNODataGridViewTextBoxColumn.Name = "dEPTNODataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTNODataGridViewTextBoxColumn;
    }
}