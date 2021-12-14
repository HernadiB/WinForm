namespace Penzugyi_tanacsado
{
    partial class Form1
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
            this.bindingSourceAllDataForTable = new System.Windows.Forms.BindingSource(this.components);
            this.tanacsadoDataSet = new Penzugyi_tanacsado.tanacsadoDataSet();
            this.allDataTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.AllDataTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportAllData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.találkozóDátumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ügyfélNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanácsadóNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szakterületMegnevezéseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóIdőtartamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szűrők = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Szűrésbe = new System.Windows.Forms.Button();
            this.Szűréski = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Felsohatar = new System.Windows.Forms.TextBox();
            this.Alsohatar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.szakteruletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.szakteruletTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.szakteruletTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Szűrők.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakteruletBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceAllDataForTable
            // 
            this.bindingSourceAllDataForTable.DataMember = "AllData";
            this.bindingSourceAllDataForTable.DataSource = this.tanacsadoDataSet;
            this.bindingSourceAllDataForTable.Sort = "SzakterületMegnevezése, TanácsadóNeve, TalálkozóDátuma DESC";
            // 
            // tanacsadoDataSet
            // 
            this.tanacsadoDataSet.DataSetName = "tanacsadoDataSet";
            this.tanacsadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Szűrők, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ExportAllData, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ExportAllData
            // 
            this.ExportAllData.AutoSize = true;
            this.ExportAllData.BackColor = System.Drawing.Color.LemonChiffon;
            this.ExportAllData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportAllData.Location = new System.Drawing.Point(1034, 470);
            this.ExportAllData.Name = "ExportAllData";
            this.ExportAllData.Size = new System.Drawing.Size(132, 63);
            this.ExportAllData.TabIndex = 4;
            this.ExportAllData.Text = "Exportálás";
            this.ExportAllData.UseVisualStyleBackColor = false;
            this.ExportAllData.Click += new System.EventHandler(this.ExportAllData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(901, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adatok exportálása:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.találkozóDátumaDataGridViewTextBoxColumn,
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn,
            this.ügyfélNeveDataGridViewTextBoxColumn,
            this.tanácsadóNeveDataGridViewTextBoxColumn,
            this.szakterületMegnevezéseDataGridViewTextBoxColumn,
            this.találkozóIdőtartamaDataGridViewTextBoxColumn,
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn,
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceAllDataForTable;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // találkozóDátumaDataGridViewTextBoxColumn
            // 
            this.találkozóDátumaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóDátuma";
            this.találkozóDátumaDataGridViewTextBoxColumn.HeaderText = "Találkozó dátuma";
            this.találkozóDátumaDataGridViewTextBoxColumn.Name = "találkozóDátumaDataGridViewTextBoxColumn";
            this.találkozóDátumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.találkozóDátumaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn
            // 
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóKezdésiIdőpontja";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.HeaderText = "Találkozó kezdési időpontja";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.Name = "találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ügyfélNeveDataGridViewTextBoxColumn
            // 
            this.ügyfélNeveDataGridViewTextBoxColumn.DataPropertyName = "ÜgyfélNeve";
            this.ügyfélNeveDataGridViewTextBoxColumn.HeaderText = "Ügyfél neve";
            this.ügyfélNeveDataGridViewTextBoxColumn.Name = "ügyfélNeveDataGridViewTextBoxColumn";
            this.ügyfélNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanácsadóNeveDataGridViewTextBoxColumn
            // 
            this.tanácsadóNeveDataGridViewTextBoxColumn.DataPropertyName = "TanácsadóNeve";
            this.tanácsadóNeveDataGridViewTextBoxColumn.HeaderText = "Tanácsadó neve";
            this.tanácsadóNeveDataGridViewTextBoxColumn.Name = "tanácsadóNeveDataGridViewTextBoxColumn";
            this.tanácsadóNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szakterületMegnevezéseDataGridViewTextBoxColumn
            // 
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.DataPropertyName = "SzakterületMegnevezése";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.HeaderText = "Szakterület megnevezése";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.Name = "szakterületMegnevezéseDataGridViewTextBoxColumn";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // találkozóIdőtartamaDataGridViewTextBoxColumn
            // 
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóIdőtartama";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.HeaderText = "Találkozó időtartama";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.Name = "találkozóIdőtartamaDataGridViewTextBoxColumn";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanácsadóÓradíjaDataGridViewTextBoxColumn
            // 
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.DataPropertyName = "TanácsadóÓradíja";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.HeaderText = "Tanácsadó óradíja";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.Name = "tanácsadóÓradíjaDataGridViewTextBoxColumn";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // találkozóértFizetendőÖsszegDataGridViewTextBoxColumn
            // 
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóértFizetendőÖsszeg";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.HeaderText = "Találkozóért fizetendő összeg";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.Name = "találkozóértFizetendőÖsszegDataGridViewTextBoxColumn";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Szűrők
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Szűrők, 2);
            this.Szűrők.Controls.Add(this.tableLayoutPanel2);
            this.Szűrők.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szűrők.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szűrők.Location = new System.Drawing.Point(901, 120);
            this.Szűrők.Name = "Szűrők";
            this.tableLayoutPanel1.SetRowSpan(this.Szűrők, 2);
            this.Szűrők.Size = new System.Drawing.Size(281, 228);
            this.Szűrők.TabIndex = 9;
            this.Szűrők.TabStop = false;
            this.Szűrők.Text = "Szűrők";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.Szűrésbe, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Szűréski, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Felsohatar, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Alsohatar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Szűrésbe
            // 
            this.Szűrésbe.AutoSize = true;
            this.Szűrésbe.BackColor = System.Drawing.Color.LemonChiffon;
            this.Szűrésbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szűrésbe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Szűrésbe.Location = new System.Drawing.Point(3, 143);
            this.Szűrésbe.Name = "Szűrésbe";
            this.Szűrésbe.Size = new System.Drawing.Size(131, 61);
            this.Szűrésbe.TabIndex = 0;
            this.Szűrésbe.Text = "Szűrés be";
            this.Szűrésbe.UseVisualStyleBackColor = false;
            this.Szűrésbe.Click += new System.EventHandler(this.Szűrésbe_Click_1);
            // 
            // Szűréski
            // 
            this.Szűréski.AutoSize = true;
            this.Szűréski.BackColor = System.Drawing.Color.LemonChiffon;
            this.Szűréski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szűréski.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Szűréski.Location = new System.Drawing.Point(140, 143);
            this.Szűréski.Name = "Szűréski";
            this.Szűréski.Size = new System.Drawing.Size(132, 61);
            this.Szűréski.TabIndex = 3;
            this.Szűréski.Text = "Szűrés ki";
            this.Szűréski.UseVisualStyleBackColor = false;
            this.Szűréski.Click += new System.EventHandler(this.Szűréski_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Óradíj felső határa: ";
            // 
            // Felsohatar
            // 
            this.Felsohatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Felsohatar.Location = new System.Drawing.Point(140, 103);
            this.Felsohatar.Name = "Felsohatar";
            this.Felsohatar.Size = new System.Drawing.Size(132, 22);
            this.Felsohatar.TabIndex = 7;
            // 
            // Alsohatar
            // 
            this.Alsohatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Alsohatar.Location = new System.Drawing.Point(140, 63);
            this.Alsohatar.Name = "Alsohatar";
            this.Alsohatar.Size = new System.Drawing.Size(132, 22);
            this.Alsohatar.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DataSource = this.szakteruletBindingSource;
            this.comboBox1.DisplayMember = "megnevezes";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "megnevezes";
            // 
            // szakteruletBindingSource
            // 
            this.szakteruletBindingSource.DataMember = "szakterulet";
            this.szakteruletBindingSource.DataSource = this.tanacsadoDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Óradíj alsó határa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Szakterület:";
            // 
            // szakteruletTableAdapter
            // 
            this.szakteruletTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1185, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Szűrők.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakteruletBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAllDataForTable;
        private tanacsadoDataSet tanacsadoDataSet;
        private tanacsadoDataSetTableAdapters.AllDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Szűrésbe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóDátumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ügyfélNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanácsadóNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szakterületMegnevezéseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóIdőtartamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanácsadóÓradíjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóértFizetendőÖsszegDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource szakteruletBindingSource;
        private tanacsadoDataSetTableAdapters.szakteruletTableAdapter szakteruletTableAdapter;
        private System.Windows.Forms.Button Szűréski;
        private System.Windows.Forms.Button ExportAllData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Felsohatar;
        private System.Windows.Forms.TextBox Alsohatar;
        private System.Windows.Forms.GroupBox Szűrők;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

