using Newtonsoft.Json;
using OnlineStore_WinformsUI.Models;
using OnlineStore_WinformsUI.Services;
using System.Net.Http;
using System.Text.Json;

namespace OnlineStore_WinformsUI
{
    public partial class Form1 : Form
    {
        private const int OrdersPageSize = 20;

        private static readonly ApiClient apiClient = new ApiClient(); // Disposed in Dispose method in the Designer file.

        public Form1()
        {
            InitializeComponent();

            pizzasListView.LargeImageList = new();
            pizzasListView.LargeImageList.ImageSize = new(292, 292);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email must be valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password must be valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool responseSuccessful = await apiClient.LoginAsync(email, password);

            if (responseSuccessful)
            {
                loginPanel.Visible = false;
                mainPanel.Visible = true;
            }
            else
            {
                loginErrorLabel.Visible = true;
            }
        }

        private async void getAllUsersButton_Click(object sender, EventArgs e)
        {
            string? response = await apiClient.GetDataAsync("User");

            if (response is null)
            {
                usersErrorLabel.Text = "Error getting users";
                return;
            }

            List<User>? items = JsonConvert.DeserializeObject<List<User>>(response);
            if (items is null)
            {
                usersErrorLabel.Text = "Error serializing a list of users";
                return;
            }

            foreach (var item in items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Email);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Address);
                listViewItem.SubItems.Add(item.PhoneNumber);

                usersListView.Items.Add(listViewItem);
            }
        }

        private async void getAllPizzasButton_Click(object sender, EventArgs e)
        {
            string? response = await apiClient.GetDataAsync("Pizza/GetAllPizza");

            if (response is null)
            {
                pizzasErrorLabel.Text = "Error getting pizzas";
                return;
            }

            List<Pizza>? items = JsonConvert.DeserializeObject<List<Pizza>>(response);
            if (items is null)
            {
                pizzasErrorLabel.Text = "Error serializing a list of pizzas";
                return;
            }

            foreach (var pizza in items)
            {
                Image? pizzaImage = await apiClient.GetImageData(pizza.ImageUrl);

                pizzasListView.LargeImageList.Images.Add(pizza.Title, pizzaImage);

                ListViewItem item = new ListViewItem(pizza.Title);
                item.ImageKey = pizza.Title;
                pizzasListView.Items.Add(item);
            }
        }

        private async void getAllOrdersButton_Click(object sender, EventArgs e)
        {
            int currentPageNumber = (int)orderPageNumericUpDown.Value;

            string? response = await apiClient.GetDataAsync("Order", $"pageNumber={currentPageNumber}", $"pageSize={OrdersPageSize}");
            if (response is null)
            {
                ordersErrorLabel.Visible = true;
                ordersErrorLabel.Text = "Error getting orders";
                return;
            }

            List<Order>? items = JsonConvert.DeserializeObject<List<Order>>(response);
            if (items is null)
            {
                ordersErrorLabel.Visible = true;
                ordersErrorLabel.Text = "Error serializing a list of orders";
                return;
            }

            ordersTreeView.Nodes.Clear();

            foreach (var order in items)
            {
                TreeNode orderNode = new TreeNode($"Order #{order.Number} ({order.CreationDate.ToShortDateString()})");

                foreach (var orderItem in order.OrderItems)
                {
                    TreeNode orderItemNode = new TreeNode($"Pizza '{orderItem.Pizza.Title}' - {orderItem.PizzaCount} pcs");
                    orderNode.Nodes.Add(orderItemNode);
                }

                ordersTreeView.Nodes.Add(orderNode);
            }
        }

        private async void generateOrdersButton_Click(object sender, EventArgs e)
        {
            await new OrderGenerator(apiClient, ordersGenerationProgressBar).GenerateNewOrderItems(50000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not use authentication
            loginPanel.Visible = false;
            mainPanel.Visible = true;
        }
    }
}
