using MilkPlant.Data;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace MilkPlant_KompaniaPolesye
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHelper _db;
        private string _currentSortField = "order_date";

        public MainForm()
        {
            InitializeComponent();
            _db = new DatabaseHelper();
            this.Load += MainForm_Load;
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
                    "Host=localhost;Database=milk_plant_db;Username=postgres;Password=donotkys1984"))
                {
                    connection.Open();

                    MessageBox.Show(
                        "Подключение к базе данных успешно установлено.",
                        "Подключение к БД",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadClients();
                    LoadOrders();
                    rbSortByDate.Checked = true;
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

        private void LoadClients()
        {
            try
            {
                string query = @"SELECT id, name FROM counterparties WHERE is_buyer = TRUE ORDER BY name";
                DataTable clients = _db.ExecuteQuery(query);

                cmbClients.DisplayMember = "name";
                cmbClients.ValueMember = "id";
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
                string query = $@"
                    SELECT 
                        co.id,
                        co.order_number AS ""Номер заказа"",
                        co.order_date AS ""Дата"",
                        cp.name AS ""Клиент"",
                        co.total_amount AS ""Сумма""
                    FROM customer_orders co
                    JOIN counterparties cp ON co.customer_id = cp.id
                    {whereClause}
                    ORDER BY {_currentSortField}";

                DataTable orders = _db.ExecuteQuery(query);
                dgvOrders.DataSource = orders;

                dgvOrders.Columns["id"].Visible = false;
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
                totalAmount += Convert.ToDecimal(row["Сумма"]);
            }

            lblStats.Text = $"Всего заказов: {totalOrders} | Общая сумма: {totalAmount:C}";
        }

        private void SortFieldChanged(object sender, EventArgs e)
        {
            if (rbSortByDate.Checked)
                _currentSortField = "order_date";
            else if (rbSortByAmount.Checked)
                _currentSortField = "total_amount";
            else if (rbSortByNumber.Checked)
                _currentSortField = "order_number";

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

            string customerId = cmbClients.SelectedValue.ToString();
            LoadOrders($"WHERE co.customer_id = '{customerId}'");
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
    }
}
