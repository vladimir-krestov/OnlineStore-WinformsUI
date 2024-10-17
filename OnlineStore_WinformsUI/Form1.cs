using Newtonsoft.Json;
using OnlineStore_WinformsUI.Models;
using OnlineStore_WinformsUI.Services;

namespace OnlineStore_WinformsUI
{
    public partial class Form1 : Form
    {
        private const int OrdersPageSize = 20;
        private double CurrentOrderTotal = 0;

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
            await new OrderGenerator(apiClient, ordersGenerationProgressBar).GenerateNewOrderItems(25000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not use authentication
            loginPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.ShowDialog();
        }

        private async void adminPageTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender != adminPageTabControl)
            {
                return;
            }

            if (adminPageTabControl.SelectedTab != pizzasTabPage)
            {
                return;
            }

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

            pizzasFlowLayoutPanel.Controls.Clear();

            foreach (var pizza in items)
            {
                PictureBox pictureBox = new();
                Panel panelItem = new();
                NumericUpDown numericUpDown = new();
                Label priceLabel = new();
                Label titleLabel = new();

                // 
                // pizzaPanelPictureBox
                // 
                pictureBox.Location = new Point(49, 9);
                pictureBox.Name = "pizzaPanelPictureBox";
                pictureBox.Size = new Size(180, 180);
                pictureBox.TabStop = false;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                // pizzaPanelItem
                //
                panelItem.Controls.Add(pictureBox);
                panelItem.Controls.Add(numericUpDown);
                panelItem.Controls.Add(priceLabel);
                panelItem.Controls.Add(titleLabel);
                panelItem.Location = new Point(3, 3);
                panelItem.Name = "pizzaPanelItem";
                panelItem.Size = new Size(270, 270);
                // 
                // pizzaPanelNumericUpDown
                // 
                numericUpDown.Location = new Point(172, 229);
                numericUpDown.Name = "pizzaPanelNumericUpDown";
                numericUpDown.Size = new Size(67, 27);
                numericUpDown.ValueChanged += (_, args) =>
                {
                    cartButton.Text = $"My order | {CurrentOrderTotal += pizza.Price}";
                };
                // 
                // pizzaPanelPriceLabel
                // 
                priceLabel.AutoSize = true;
                priceLabel.Location = new Point(49, 231);
                priceLabel.Name = "pizzaPanelPriceLabel";
                priceLabel.Size = new Size(45, 20);
                priceLabel.Text = $"{pizza.Price} Rsd";
                // 
                // pizzaPanelTitleLabel
                // 
                titleLabel.AutoSize = true;
                titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                titleLabel.Name = "pizzaPanelTitleLabel";
                titleLabel.Size = new Size(100, 20);
                titleLabel.AutoSize = true;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Text = pizza.Title;
                titleLabel.Location = new Point(
                    (panelItem.Width - titleLabel.Width) / 2,
                    197
                );

                pizzasFlowLayoutPanel.Controls.Add(panelItem);

                Task.Run(async () => pictureBox.Image = await apiClient.GetImageData(pizza.ImageUrl));
            }
        }


        private void pizzaPanelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            return; //
        }
    }
}
