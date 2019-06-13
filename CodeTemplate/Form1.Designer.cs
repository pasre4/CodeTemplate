namespace CodeTemplate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.database = new System.Windows.Forms.ComboBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_entity = new System.Windows.Forms.TabPage();
            this.entityStr = new System.Windows.Forms.TextBox();
            this.tab_map = new System.Windows.Forms.TabPage();
            this.mapStr = new System.Windows.Forms.TextBox();
            this.tabelField = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPrimaryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCreasingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isNullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fieldLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelFieldModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modelName = new System.Windows.Forms.TextBox();
            this.tab_repository = new System.Windows.Forms.TabPage();
            this.repositoryStr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tab.SuspendLayout();
            this.tab_entity.SuspendLayout();
            this.tab_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelFieldModelBindingSource)).BeginInit();
            this.tab_repository.SuspendLayout();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(130, 48);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(300, 32);
            this.database.TabIndex = 0;
            this.database.SelectedValueChanged += new System.EventHandler(this.database_SelectedValueChanged);
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(42, 51);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(82, 24);
            this.databaseLabel.TabIndex = 1;
            this.databaseLabel.Text = "数据库";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tab);
            this.panel1.Controls.Add(this.tabelField);
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1978, 881);
            this.panel1.TabIndex = 2;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_entity);
            this.tab.Controls.Add(this.tab_map);
            this.tab.Controls.Add(this.tab_repository);
            this.tab.Location = new System.Drawing.Point(914, 26);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1048, 807);
            this.tab.TabIndex = 3;
            // 
            // tab_entity
            // 
            this.tab_entity.Controls.Add(this.entityStr);
            this.tab_entity.Location = new System.Drawing.Point(8, 39);
            this.tab_entity.Name = "tab_entity";
            this.tab_entity.Padding = new System.Windows.Forms.Padding(3);
            this.tab_entity.Size = new System.Drawing.Size(1032, 760);
            this.tab_entity.TabIndex = 2;
            this.tab_entity.Tag = "";
            this.tab_entity.Text = "Entity";
            this.tab_entity.UseVisualStyleBackColor = true;
            // 
            // entityStr
            // 
            this.entityStr.AcceptsTab = true;
            this.entityStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityStr.Location = new System.Drawing.Point(3, 3);
            this.entityStr.Multiline = true;
            this.entityStr.Name = "entityStr";
            this.entityStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.entityStr.Size = new System.Drawing.Size(1026, 754);
            this.entityStr.TabIndex = 0;
            // 
            // tab_map
            // 
            this.tab_map.Controls.Add(this.mapStr);
            this.tab_map.Location = new System.Drawing.Point(8, 39);
            this.tab_map.Name = "tab_map";
            this.tab_map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_map.Size = new System.Drawing.Size(1032, 760);
            this.tab_map.TabIndex = 3;
            this.tab_map.Text = "map";
            this.tab_map.UseVisualStyleBackColor = true;
            // 
            // mapStr
            // 
            this.mapStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapStr.Location = new System.Drawing.Point(3, 3);
            this.mapStr.Multiline = true;
            this.mapStr.Name = "mapStr";
            this.mapStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mapStr.Size = new System.Drawing.Size(1026, 754);
            this.mapStr.TabIndex = 0;
            // 
            // tabelField
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabelField.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelField.AutoGenerateColumns = false;
            this.tabelField.ColumnHeadersHeight = 30;
            this.tabelField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.isPrimaryDataGridViewCheckBoxColumn,
            this.isCreasingDataGridViewCheckBoxColumn,
            this.isNullDataGridViewCheckBoxColumn,
            this.fieldLengthDataGridViewTextBoxColumn});
            this.tabelField.DataSource = this.tabelFieldModelBindingSource;
            this.tabelField.Location = new System.Drawing.Point(31, 26);
            this.tabelField.Name = "tabelField";
            this.tabelField.RowTemplate.Height = 20;
            this.tabelField.Size = new System.Drawing.Size(839, 807);
            this.tabelField.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "字段类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "描述";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.Width = 200;
            // 
            // isPrimaryDataGridViewCheckBoxColumn
            // 
            this.isPrimaryDataGridViewCheckBoxColumn.DataPropertyName = "IsPrimary";
            this.isPrimaryDataGridViewCheckBoxColumn.HeaderText = "是否主键";
            this.isPrimaryDataGridViewCheckBoxColumn.Name = "isPrimaryDataGridViewCheckBoxColumn";
            // 
            // isCreasingDataGridViewCheckBoxColumn
            // 
            this.isCreasingDataGridViewCheckBoxColumn.DataPropertyName = "IsCreasing";
            this.isCreasingDataGridViewCheckBoxColumn.HeaderText = "是否自增";
            this.isCreasingDataGridViewCheckBoxColumn.Name = "isCreasingDataGridViewCheckBoxColumn";
            // 
            // isNullDataGridViewCheckBoxColumn
            // 
            this.isNullDataGridViewCheckBoxColumn.DataPropertyName = "IsNull";
            this.isNullDataGridViewCheckBoxColumn.HeaderText = "是否允许空值";
            this.isNullDataGridViewCheckBoxColumn.Name = "isNullDataGridViewCheckBoxColumn";
            // 
            // fieldLengthDataGridViewTextBoxColumn
            // 
            this.fieldLengthDataGridViewTextBoxColumn.DataPropertyName = "FieldLength";
            this.fieldLengthDataGridViewTextBoxColumn.HeaderText = "字段长度";
            this.fieldLengthDataGridViewTextBoxColumn.Name = "fieldLengthDataGridViewTextBoxColumn";
            this.fieldLengthDataGridViewTextBoxColumn.Width = 150;
            // 
            // tabelFieldModelBindingSource
            // 
            this.tabelFieldModelBindingSource.DataSource = typeof(CodeTemplate.Entity.TabelFieldModel);
            // 
            // tabel
            // 
            this.tabel.FormattingEnabled = true;
            this.tabel.Location = new System.Drawing.Point(594, 48);
            this.tabel.Name = "tabel";
            this.tabel.Size = new System.Drawing.Size(329, 32);
            this.tabel.TabIndex = 1;
            this.tabel.SelectedIndexChanged += new System.EventHandler(this.tabel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据表";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(1823, 39);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(115, 45);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "生成";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1041, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "实体名称";
            // 
            // modelName
            // 
            this.modelName.Location = new System.Drawing.Point(1155, 39);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(330, 35);
            this.modelName.TabIndex = 5;
            // 
            // tab_repository
            // 
            this.tab_repository.Controls.Add(this.repositoryStr);
            this.tab_repository.Location = new System.Drawing.Point(8, 39);
            this.tab_repository.Name = "tab_repository";
            this.tab_repository.Padding = new System.Windows.Forms.Padding(3);
            this.tab_repository.Size = new System.Drawing.Size(1032, 760);
            this.tab_repository.TabIndex = 4;
            this.tab_repository.Text = "Repository";
            this.tab_repository.UseVisualStyleBackColor = true;
            // 
            // repositoryStr
            // 
            this.repositoryStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repositoryStr.Location = new System.Drawing.Point(3, 3);
            this.repositoryStr.Multiline = true;
            this.repositoryStr.Name = "repositoryStr";
            this.repositoryStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.repositoryStr.Size = new System.Drawing.Size(1026, 754);
            this.repositoryStr.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1974, 986);
            this.Controls.Add(this.modelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.tabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.database);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "代码生成";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tab_entity.ResumeLayout(false);
            this.tab_entity.PerformLayout();
            this.tab_map.ResumeLayout(false);
            this.tab_map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelFieldModelBindingSource)).EndInit();
            this.tab_repository.ResumeLayout(false);
            this.tab_repository.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabelField;
        private System.Windows.Forms.BindingSource tabelFieldModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPrimaryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCreasingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNullDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_entity;
        private System.Windows.Forms.TabPage tab_map;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelName;
        private System.Windows.Forms.TextBox entityStr;
        private System.Windows.Forms.TextBox mapStr;
        private System.Windows.Forms.TabPage tab_repository;
        private System.Windows.Forms.TextBox repositoryStr;
    }
}

