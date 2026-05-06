namespace MilkPlant_KompaniaPolesye
{
    partial class MainForm
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
            SortGroupBox = new GroupBox();
            rbSortByNumber = new RadioButton();
            rbSortByAmount = new RadioButton();
            rbSortByDate = new RadioButton();
            FilterGroupBox = new GroupBox();
            btnShowAll = new Button();
            btnFilter = new Button();
            cmbClients = new ComboBox();
            label1 = new Label();
            SearchGroupBox = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvOrders = new DataGridView();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            lblStats = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            SortGroupBox.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SortGroupBox
            // 
            SortGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SortGroupBox.AutoSize = true;
            SortGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SortGroupBox.Controls.Add(rbSortByNumber);
            SortGroupBox.Controls.Add(rbSortByAmount);
            SortGroupBox.Controls.Add(rbSortByDate);
            SortGroupBox.Location = new Point(677, 15);
            SortGroupBox.Name = "SortGroupBox";
            SortGroupBox.Size = new Size(95, 113);
            SortGroupBox.TabIndex = 0;
            SortGroupBox.TabStop = false;
            SortGroupBox.Text = "Сортировка";
            // 
            // rbSortByNumber
            // 
            rbSortByNumber.AutoSize = true;
            rbSortByNumber.Location = new Point(3, 72);
            rbSortByNumber.Name = "rbSortByNumber";
            rbSortByNumber.Size = new Size(86, 19);
            rbSortByNumber.TabIndex = 2;
            rbSortByNumber.TabStop = true;
            rbSortByNumber.Text = "По номеру";
            rbSortByNumber.UseVisualStyleBackColor = true;
            // 
            // rbSortByAmount
            // 
            rbSortByAmount.AutoSize = true;
            rbSortByAmount.Location = new Point(3, 47);
            rbSortByAmount.Name = "rbSortByAmount";
            rbSortByAmount.Size = new Size(80, 19);
            rbSortByAmount.TabIndex = 1;
            rbSortByAmount.TabStop = true;
            rbSortByAmount.Text = "По сумме";
            rbSortByAmount.UseVisualStyleBackColor = true;
            rbSortByAmount.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbSortByDate
            // 
            rbSortByDate.AutoSize = true;
            rbSortByDate.Location = new Point(3, 22);
            rbSortByDate.Name = "rbSortByDate";
            rbSortByDate.Size = new Size(67, 19);
            rbSortByDate.TabIndex = 0;
            rbSortByDate.TabStop = true;
            rbSortByDate.Text = "По дате";
            rbSortByDate.UseVisualStyleBackColor = true;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.AutoSize = true;
            FilterGroupBox.Controls.Add(btnShowAll);
            FilterGroupBox.Controls.Add(btnFilter);
            FilterGroupBox.Controls.Add(cmbClients);
            FilterGroupBox.Controls.Add(label1);
            FilterGroupBox.Location = new Point(0, 9);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(200, 126);
            FilterGroupBox.TabIndex = 1;
            FilterGroupBox.TabStop = false;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(6, 83);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(188, 21);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Показать все";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(6, 56);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(188, 21);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Фильтровать";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // cmbClients
            // 
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new Point(6, 27);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(188, 23);
            cmbClients.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Клиент:";
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchGroupBox.Controls.Add(btnSearch);
            SearchGroupBox.Controls.Add(txtSearch);
            SearchGroupBox.Location = new Point(206, 15);
            SearchGroupBox.MinimumSize = new Size(326, 102);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(465, 102);
            SearchGroupBox.TabIndex = 2;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Поиск";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(285, 57);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(459, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(763, 409);
            dgvOrders.TabIndex = 4;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(dgvOrders);
            panel1.Location = new Point(12, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 409);
            panel1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStats });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStats
            // 
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(0, 17);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(FilterGroupBox);
            groupBox1.Controls.Add(SortGroupBox);
            groupBox1.Controls.Add(SearchGroupBox);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 157);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы покупателей — ООО Молочный комбинат \"Полесье\"";
            SortGroupBox.ResumeLayout(false);
            SortGroupBox.PerformLayout();
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SortGroupBox;
        private RadioButton rbSortByNumber;
        private RadioButton rbSortByAmount;
        private RadioButton rbSortByDate;
        private GroupBox FilterGroupBox;
        private ComboBox cmbClients;
        private Label label1;
        private Button btnShowAll;
        private Button btnFilter;
        private GroupBox SearchGroupBox;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvOrders;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStats;
        private GroupBox groupBox1;
    }
}
