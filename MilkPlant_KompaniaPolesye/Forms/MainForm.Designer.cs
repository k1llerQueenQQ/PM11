namespace MilkPlant_KompaniaPolesye
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxFilter = new GroupBox();
            btnShowAll = new Button();
            btnFilter = new Button();
            cmbClients = new ComboBox();
            lblClient = new Label();
            groupBoxSearch = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBoxSort = new GroupBox();
            rbSortDesc = new RadioButton();
            rbSortAsc = new RadioButton();
            cmbSortField = new ComboBox();
            dgvOrders = new DataGridView();
            statusStrip = new StatusStrip();
            lblStats = new ToolStripStatusLabel();
            groupBoxFilter.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnShowAll);
            groupBoxFilter.Controls.Add(btnFilter);
            groupBoxFilter.Controls.Add(cmbClients);
            groupBoxFilter.Controls.Add(lblClient);
            groupBoxFilter.Location = new Point(12, 12);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(250, 120);
            groupBoxFilter.TabIndex = 0;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Клиент";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(6, 85);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(238, 25);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Показать все";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(6, 55);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(238, 25);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Фильтровать";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // cmbClients
            // 
            cmbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new Point(6, 27);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(238, 23);
            cmbClients.TabIndex = 1;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(6, 9);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(0, 15);
            lblClient.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Location = new Point(268, 12);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(250, 120);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Поиск";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(238, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 0;
            // 
            // groupBoxSort
            // 
            groupBoxSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSort.Controls.Add(rbSortDesc);
            groupBoxSort.Controls.Add(rbSortAsc);
            groupBoxSort.Controls.Add(cmbSortField);
            groupBoxSort.Location = new Point(524, 12);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(250, 120);
            groupBoxSort.TabIndex = 2;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            // 
            // rbSortDesc
            // 
            rbSortDesc.AutoSize = true;
            rbSortDesc.Location = new Point(6, 78);
            rbSortDesc.Name = "rbSortDesc";
            rbSortDesc.Size = new Size(102, 19);
            rbSortDesc.TabIndex = 2;
            rbSortDesc.Text = "По убыванию";
            rbSortDesc.UseVisualStyleBackColor = true;
            // 
            // rbSortAsc
            // 
            rbSortAsc.AutoSize = true;
            rbSortAsc.Checked = true;
            rbSortAsc.Location = new Point(6, 53);
            rbSortAsc.Name = "rbSortAsc";
            rbSortAsc.Size = new Size(116, 19);
            rbSortAsc.TabIndex = 1;
            rbSortAsc.TabStop = true;
            rbSortAsc.Text = "По возрастанию";
            rbSortAsc.UseVisualStyleBackColor = true;
            // 
            // cmbSortField
            // 
            cmbSortField.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortField.FormattingEnabled = true;
            cmbSortField.Items.AddRange(new object[] { "Заказчик", "Дата заказа", "Сумма заказа" });
            cmbSortField.Location = new Point(6, 22);
            cmbSortField.Name = "cmbSortField";
            cmbSortField.Size = new Size(238, 23);
            cmbSortField.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 138);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(762, 364);
            dgvOrders.TabIndex = 3;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStats });
            statusStrip.Location = new Point(0, 539);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(786, 22);
            statusStrip.TabIndex = 4;
            // 
            // lblStats
            // 
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(0, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 561);
            Controls.Add(statusStrip);
            Controls.Add(dgvOrders);
            Controls.Add(groupBoxSort);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxFilter);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с заказами — ООО Молочный комбинат \"Полесье\"";
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxSort.ResumeLayout(false);
            groupBoxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFilter;
        private Button btnShowAll;
        private Button btnFilter;
        private ComboBox cmbClients;
        private Label lblClient;
        private GroupBox groupBoxSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private GroupBox groupBoxSort;
        private ComboBox cmbSortField;
        private RadioButton rbSortAsc;
        private RadioButton rbSortDesc;
        private DataGridView dgvOrders;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStats;
    }
}