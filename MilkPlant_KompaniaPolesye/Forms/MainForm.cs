using MilkPlant.Data;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MilkPlant_KompaniaPolesye
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHelper _db;
        private bool _isLoading = false;

        public MainForm()
        {
            InitializeComponent();
            _db = new DatabaseHelper();

            this.Load += MainForm_Load;
            btnFilter.Click += btnFilter_Click;
            btnShowAll.Click += btnShowAll_Click;
            btnSearch.Click += btnSearch_Click;
            cmbSortField.SelectedIndexChanged += SortFieldChanged;
            rbSortAsc.CheckedChanged += SortDirectionChanged;
            rbSortDesc.CheckedChanged += SortDirectionChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(
                    "Host=localhost;Database=OrdersDB;Username=postgres;Password=-"))
                {
                    connection.Open();

                    MessageBox.Show(
                        "Подключение к базе данных успешно установлено.",
                        "Подключение к БД",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _isLoading = true;
                    cmbSortField.SelectedIndex = 0;
                    rbSortAsc.Checked = true;
                    LoadClients();
                    LoadOrders();
                    _isLoading = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось подключиться к базе данных.\n\nОшибка: {ex.Message}",
                    "Ошибка подключения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetSortField()
        {
            switch (cmbSortField.SelectedItem?.ToString())
            {
                case "Заказчик":
                    return "c.CustomerName";
                case "Дата заказа":
                    return "o.OrderDate";
                case "Сумма заказа":
                    return "o.OrderAmount";
                default:
                    return "c.CustomerName";
            }
        }

        private string GetSortDirection()
        {
            return rbSortDesc.Checked ? "DESC" : "ASC";
        }

        private void LoadClients()
        {
            try
            {
                string query = "SELECT CustomerID, CustomerName FROM Customers ORDER BY CustomerName";
                DataTable clients = _db.ExecuteQuery(query);

                cmbClients.DisplayMember = "CustomerName";
                cmbClients.ValueMember = "CustomerID";
                cmbClients.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при загрузке списка клиентов:\n{ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadOrders(string whereClause = "")
        {
            try
            {
                string sortField = GetSortField();
                string sortDir = GetSortDirection();

                string query = $@"
                    SELECT 
                        o.OrderID,
                        c.CustomerName AS ""Заказчик"",
                        c.City AS ""Город"",
                        c.Phone AS ""Телефон"",
                        o.OrderDate AS ""Дата заказа"",
                        o.OrderAmount AS ""Сумма заказа""
                    FROM Orders o
                    JOIN Customers c ON o.CustomerID = c.CustomerID
                    {whereClause}
                    ORDER BY {sortField} {sortDir}";

                DataTable orders = _db.ExecuteQuery(query);
                dgvOrders.DataSource = orders;

                dgvOrders.Columns["OrderID"].Visible = false;
                dgvOrders.Columns["Дата заказа"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvOrders.Columns["Сумма заказа"].DefaultCellStyle.Format = "N2";

                UpdateStats(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при загрузке данных:\n{ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateStats(DataTable orders)
        {
            int totalOrders = orders.Rows.Count;
            decimal totalAmount = 0;

            foreach (DataRow row in orders.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Сумма заказа"]);
            }

            lblStats.Text = $"Всего заказов: {totalOrders} | Общая сумма: {totalAmount:N2}";
        }

        private void SortFieldChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            LoadOrders();
        }

        private void SortDirectionChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;
            if (_isLoading) return;
            LoadOrders();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите клиента из списка для фильтрации.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int customerId = Convert.ToInt32(cmbClients.SelectedValue);
            LoadOrders($"WHERE c.CustomerID = {customerId}");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show(
                    "Введите строку для поиска.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            bool found = false;

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        cell.Style.BackColor = Color.Yellow;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    $"По запросу \"{searchText}\" ничего не найдено.",
                    "Результаты поиска",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }
    }
}