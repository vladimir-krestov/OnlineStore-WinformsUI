namespace OnlineStore_WinformsUI
{
    partial class Form1
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
            apiClient.Dispose();

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
            mainPanel = new Panel();
            cartButton = new Button();
            adminPageLabel = new Label();
            adminPageTabControl = new TabControl();
            usersTabPage = new TabPage();
            usersListView = new ListView();
            emailHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            phoneHeader = new ColumnHeader();
            addressHeader = new ColumnHeader();
            usersErrorLabel = new Label();
            getAllUsersButton = new Button();
            pizzasTabPage = new TabPage();
            pizzasFlowLayoutPanel = new FlowLayoutPanel();
            pizzaPanelItem = new Panel();
            pizzaPanelPictureBox = new PictureBox();
            pizzaPanelNumericUpDown = new NumericUpDown();
            pizzaPanelPriceLabel = new Label();
            pizzaPanelTitleLabel = new Label();
            ordersTabPage = new TabPage();
            ordersGenerationProgressBar = new ProgressBar();
            generateOrdersButton = new Button();
            ordersPageLabel = new Label();
            orderPageNumericUpDown = new NumericUpDown();
            ordersTreeView = new TreeView();
            ordersErrorLabel = new Label();
            getAllOrdersButton = new Button();
            pizzaTabPageOld = new TabPage();
            pizzasErrorLabel = new Label();
            pizzasListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            getAllPizzasButton = new Button();
            loginPanel = new Panel();
            loginSmallPanel = new Panel();
            loginErrorLabel = new Label();
            registerButton = new Button();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            mainPanel.SuspendLayout();
            adminPageTabControl.SuspendLayout();
            usersTabPage.SuspendLayout();
            pizzasTabPage.SuspendLayout();
            pizzasFlowLayoutPanel.SuspendLayout();
            pizzaPanelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPanelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pizzaPanelNumericUpDown).BeginInit();
            ordersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderPageNumericUpDown).BeginInit();
            pizzaTabPageOld.SuspendLayout();
            loginPanel.SuspendLayout();
            loginSmallPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.Azure;
            mainPanel.Controls.Add(cartButton);
            mainPanel.Controls.Add(adminPageLabel);
            mainPanel.Controls.Add(adminPageTabControl);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1258, 729);
            mainPanel.TabIndex = 0;
            mainPanel.Visible = false;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.LightSalmon;
            cartButton.Location = new Point(1100, 14);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(135, 44);
            cartButton.TabIndex = 4;
            cartButton.Text = "My order | 0";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += cartButton_Click;
            // 
            // adminPageLabel
            // 
            adminPageLabel.AutoSize = true;
            adminPageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminPageLabel.Location = new Point(19, 14);
            adminPageLabel.Name = "adminPageLabel";
            adminPageLabel.Size = new Size(144, 31);
            adminPageLabel.TabIndex = 3;
            adminPageLabel.Text = "Admin page";
            // 
            // adminPageTabControl
            // 
            adminPageTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminPageTabControl.Controls.Add(usersTabPage);
            adminPageTabControl.Controls.Add(pizzasTabPage);
            adminPageTabControl.Controls.Add(ordersTabPage);
            adminPageTabControl.Controls.Add(pizzaTabPageOld);
            adminPageTabControl.Location = new Point(19, 64);
            adminPageTabControl.Name = "adminPageTabControl";
            adminPageTabControl.SelectedIndex = 0;
            adminPageTabControl.Size = new Size(1220, 647);
            adminPageTabControl.TabIndex = 2;
            adminPageTabControl.SelectedIndexChanged += adminPageTabControl_SelectedIndexChanged;
            // 
            // usersTabPage
            // 
            usersTabPage.Controls.Add(usersListView);
            usersTabPage.Controls.Add(usersErrorLabel);
            usersTabPage.Controls.Add(getAllUsersButton);
            usersTabPage.Location = new Point(4, 29);
            usersTabPage.Name = "usersTabPage";
            usersTabPage.Padding = new Padding(3);
            usersTabPage.Size = new Size(1212, 614);
            usersTabPage.TabIndex = 0;
            usersTabPage.Text = "Users";
            usersTabPage.UseVisualStyleBackColor = true;
            // 
            // usersListView
            // 
            usersListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersListView.Columns.AddRange(new ColumnHeader[] { emailHeader, nameHeader, phoneHeader, addressHeader });
            usersListView.Location = new Point(25, 54);
            usersListView.Name = "usersListView";
            usersListView.Size = new Size(1165, 540);
            usersListView.TabIndex = 0;
            usersListView.UseCompatibleStateImageBehavior = false;
            usersListView.View = View.Details;
            // 
            // emailHeader
            // 
            emailHeader.Text = "Email";
            emailHeader.Width = 250;
            // 
            // nameHeader
            // 
            nameHeader.Text = "Name";
            nameHeader.Width = 150;
            // 
            // phoneHeader
            // 
            phoneHeader.Text = "Phone";
            phoneHeader.Width = 150;
            // 
            // addressHeader
            // 
            addressHeader.Text = "Address";
            addressHeader.Width = 150;
            // 
            // usersErrorLabel
            // 
            usersErrorLabel.AutoSize = true;
            usersErrorLabel.Location = new Point(208, 18);
            usersErrorLabel.Name = "usersErrorLabel";
            usersErrorLabel.Size = new Size(74, 20);
            usersErrorLabel.TabIndex = 1;
            usersErrorLabel.Text = "Users info";
            usersErrorLabel.Visible = false;
            // 
            // getAllUsersButton
            // 
            getAllUsersButton.Location = new Point(25, 11);
            getAllUsersButton.Name = "getAllUsersButton";
            getAllUsersButton.Size = new Size(151, 34);
            getAllUsersButton.TabIndex = 0;
            getAllUsersButton.Text = "Get all users";
            getAllUsersButton.UseVisualStyleBackColor = true;
            getAllUsersButton.Click += getAllUsersButton_Click;
            // 
            // pizzasTabPage
            // 
            pizzasTabPage.Controls.Add(pizzasFlowLayoutPanel);
            pizzasTabPage.Location = new Point(4, 29);
            pizzasTabPage.Name = "pizzasTabPage";
            pizzasTabPage.Size = new Size(1212, 614);
            pizzasTabPage.TabIndex = 3;
            pizzasTabPage.Text = "Pizzas";
            pizzasTabPage.UseVisualStyleBackColor = true;
            // 
            // pizzasFlowLayoutPanel
            // 
            pizzasFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pizzasFlowLayoutPanel.AutoScroll = true;
            pizzasFlowLayoutPanel.BackColor = SystemColors.Window;
            pizzasFlowLayoutPanel.Controls.Add(pizzaPanelItem);
            pizzasFlowLayoutPanel.Location = new Point(24, 24);
            pizzasFlowLayoutPanel.Name = "pizzasFlowLayoutPanel";
            pizzasFlowLayoutPanel.Size = new Size(1163, 569);
            pizzasFlowLayoutPanel.TabIndex = 0;
            // 
            // pizzaPanelItem
            // 
            pizzaPanelItem.Controls.Add(pizzaPanelPictureBox);
            pizzaPanelItem.Controls.Add(pizzaPanelNumericUpDown);
            pizzaPanelItem.Controls.Add(pizzaPanelPriceLabel);
            pizzaPanelItem.Controls.Add(pizzaPanelTitleLabel);
            pizzaPanelItem.Location = new Point(3, 3);
            pizzaPanelItem.Name = "pizzaPanelItem";
            pizzaPanelItem.Size = new Size(285, 274);
            pizzaPanelItem.TabIndex = 0;
            // 
            // pizzaPanelPictureBox
            // 
            pizzaPanelPictureBox.Location = new Point(49, 9);
            pizzaPanelPictureBox.Name = "pizzaPanelPictureBox";
            pizzaPanelPictureBox.Size = new Size(190, 181);
            pizzaPanelPictureBox.TabIndex = 1;
            pizzaPanelPictureBox.TabStop = false;
            // 
            // pizzaPanelNumericUpDown
            // 
            pizzaPanelNumericUpDown.Location = new Point(172, 229);
            pizzaPanelNumericUpDown.Name = "pizzaPanelNumericUpDown";
            pizzaPanelNumericUpDown.Size = new Size(67, 27);
            pizzaPanelNumericUpDown.TabIndex = 1;
            pizzaPanelNumericUpDown.ValueChanged += pizzaPanelNumericUpDown_ValueChanged;
            // 
            // pizzaPanelPriceLabel
            // 
            pizzaPanelPriceLabel.AutoSize = true;
            pizzaPanelPriceLabel.Location = new Point(49, 231);
            pizzaPanelPriceLabel.Name = "pizzaPanelPriceLabel";
            pizzaPanelPriceLabel.Size = new Size(45, 20);
            pizzaPanelPriceLabel.TabIndex = 1;
            pizzaPanelPriceLabel.Text = "0 Rsd";
            // 
            // pizzaPanelTitleLabel
            // 
            pizzaPanelTitleLabel.AutoSize = true;
            pizzaPanelTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pizzaPanelTitleLabel.Location = new Point(120, 197);
            pizzaPanelTitleLabel.Name = "pizzaPanelTitleLabel";
            pizzaPanelTitleLabel.Size = new Size(40, 20);
            pizzaPanelTitleLabel.TabIndex = 1;
            pizzaPanelTitleLabel.Text = "Title";
            // 
            // ordersTabPage
            // 
            ordersTabPage.Controls.Add(ordersGenerationProgressBar);
            ordersTabPage.Controls.Add(generateOrdersButton);
            ordersTabPage.Controls.Add(ordersPageLabel);
            ordersTabPage.Controls.Add(orderPageNumericUpDown);
            ordersTabPage.Controls.Add(ordersTreeView);
            ordersTabPage.Controls.Add(ordersErrorLabel);
            ordersTabPage.Controls.Add(getAllOrdersButton);
            ordersTabPage.Location = new Point(4, 29);
            ordersTabPage.Name = "ordersTabPage";
            ordersTabPage.Size = new Size(1212, 614);
            ordersTabPage.TabIndex = 2;
            ordersTabPage.Text = "Orders";
            ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersGenerationProgressBar
            // 
            ordersGenerationProgressBar.Location = new Point(760, 16);
            ordersGenerationProgressBar.Name = "ordersGenerationProgressBar";
            ordersGenerationProgressBar.Size = new Size(254, 34);
            ordersGenerationProgressBar.TabIndex = 8;
            // 
            // generateOrdersButton
            // 
            generateOrdersButton.Location = new Point(1037, 16);
            generateOrdersButton.Name = "generateOrdersButton";
            generateOrdersButton.Size = new Size(151, 34);
            generateOrdersButton.TabIndex = 7;
            generateOrdersButton.Text = "Generate orders";
            generateOrdersButton.UseVisualStyleBackColor = true;
            generateOrdersButton.Click += generateOrdersButton_Click;
            // 
            // ordersPageLabel
            // 
            ordersPageLabel.AutoSize = true;
            ordersPageLabel.Location = new Point(24, 574);
            ordersPageLabel.Name = "ordersPageLabel";
            ordersPageLabel.Size = new Size(44, 20);
            ordersPageLabel.TabIndex = 6;
            ordersPageLabel.Text = "Page:";
            // 
            // orderPageNumericUpDown
            // 
            orderPageNumericUpDown.Location = new Point(109, 572);
            orderPageNumericUpDown.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            orderPageNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            orderPageNumericUpDown.Name = "orderPageNumericUpDown";
            orderPageNumericUpDown.Size = new Size(66, 27);
            orderPageNumericUpDown.TabIndex = 4;
            orderPageNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ordersTreeView
            // 
            ordersTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersTreeView.Location = new Point(24, 73);
            ordersTreeView.Name = "ordersTreeView";
            ordersTreeView.Size = new Size(1164, 484);
            ordersTreeView.TabIndex = 5;
            // 
            // ordersErrorLabel
            // 
            ordersErrorLabel.AutoSize = true;
            ordersErrorLabel.Location = new Point(207, 23);
            ordersErrorLabel.Name = "ordersErrorLabel";
            ordersErrorLabel.Size = new Size(83, 20);
            ordersErrorLabel.TabIndex = 4;
            ordersErrorLabel.Text = "Orders info";
            ordersErrorLabel.Visible = false;
            // 
            // getAllOrdersButton
            // 
            getAllOrdersButton.Location = new Point(24, 16);
            getAllOrdersButton.Name = "getAllOrdersButton";
            getAllOrdersButton.Size = new Size(151, 34);
            getAllOrdersButton.TabIndex = 3;
            getAllOrdersButton.Text = "Get all orders";
            getAllOrdersButton.UseVisualStyleBackColor = true;
            getAllOrdersButton.Click += getAllOrdersButton_Click;
            // 
            // pizzaTabPageOld
            // 
            pizzaTabPageOld.Controls.Add(pizzasErrorLabel);
            pizzaTabPageOld.Controls.Add(pizzasListView);
            pizzaTabPageOld.Controls.Add(getAllPizzasButton);
            pizzaTabPageOld.Location = new Point(4, 29);
            pizzaTabPageOld.Name = "pizzaTabPageOld";
            pizzaTabPageOld.Padding = new Padding(3);
            pizzaTabPageOld.Size = new Size(1212, 614);
            pizzaTabPageOld.TabIndex = 1;
            pizzaTabPageOld.Text = "PizzasOld";
            pizzaTabPageOld.UseVisualStyleBackColor = true;
            // 
            // pizzasErrorLabel
            // 
            pizzasErrorLabel.AutoSize = true;
            pizzasErrorLabel.Location = new Point(201, 23);
            pizzasErrorLabel.Name = "pizzasErrorLabel";
            pizzasErrorLabel.Size = new Size(79, 20);
            pizzasErrorLabel.TabIndex = 3;
            pizzasErrorLabel.Text = "Pizzas info";
            pizzasErrorLabel.Visible = false;
            // 
            // pizzasListView
            // 
            pizzasListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pizzasListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            pizzasListView.Location = new Point(24, 59);
            pizzasListView.Name = "pizzasListView";
            pizzasListView.Size = new Size(1165, 540);
            pizzasListView.TabIndex = 1;
            pizzasListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Address";
            columnHeader4.Width = 150;
            // 
            // getAllPizzasButton
            // 
            getAllPizzasButton.Location = new Point(24, 16);
            getAllPizzasButton.Name = "getAllPizzasButton";
            getAllPizzasButton.Size = new Size(151, 34);
            getAllPizzasButton.TabIndex = 2;
            getAllPizzasButton.Text = "Get all pizzas";
            getAllPizzasButton.UseVisualStyleBackColor = true;
            getAllPizzasButton.Click += getAllPizzasButton_Click;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginPanel.BackColor = Color.Azure;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(loginSmallPanel);
            loginPanel.Location = new Point(12, 12);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1258, 729);
            loginPanel.TabIndex = 0;
            // 
            // loginSmallPanel
            // 
            loginSmallPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginSmallPanel.BackColor = Color.LightCyan;
            loginSmallPanel.BorderStyle = BorderStyle.FixedSingle;
            loginSmallPanel.Controls.Add(loginErrorLabel);
            loginSmallPanel.Controls.Add(registerButton);
            loginSmallPanel.Controls.Add(loginButton);
            loginSmallPanel.Controls.Add(passwordTextBox);
            loginSmallPanel.Controls.Add(passwordLabel);
            loginSmallPanel.Controls.Add(emailTextBox);
            loginSmallPanel.Controls.Add(emailLabel);
            loginSmallPanel.Location = new Point(489, 202);
            loginSmallPanel.Name = "loginSmallPanel";
            loginSmallPanel.Size = new Size(355, 337);
            loginSmallPanel.TabIndex = 2;
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.AutoSize = true;
            loginErrorLabel.BorderStyle = BorderStyle.FixedSingle;
            loginErrorLabel.ForeColor = Color.DarkRed;
            loginErrorLabel.Location = new Point(38, 289);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(84, 22);
            loginErrorLabel.TabIndex = 6;
            loginErrorLabel.Text = "Login error";
            loginErrorLabel.Visible = false;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(192, 224);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 37);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(38, 224);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(120, 37);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(38, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(274, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BorderStyle = BorderStyle.FixedSingle;
            passwordLabel.Location = new Point(38, 127);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 22);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(38, 79);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(274, 27);
            emailTextBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BorderStyle = BorderStyle.FixedSingle;
            emailLabel.Location = new Point(38, 43);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 22);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 753);
            Controls.Add(mainPanel);
            Controls.Add(loginPanel);
            MinimumSize = new Size(1300, 800);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            adminPageTabControl.ResumeLayout(false);
            usersTabPage.ResumeLayout(false);
            usersTabPage.PerformLayout();
            pizzasTabPage.ResumeLayout(false);
            pizzasFlowLayoutPanel.ResumeLayout(false);
            pizzaPanelItem.ResumeLayout(false);
            pizzaPanelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPanelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pizzaPanelNumericUpDown).EndInit();
            ordersTabPage.ResumeLayout(false);
            ordersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderPageNumericUpDown).EndInit();
            pizzaTabPageOld.ResumeLayout(false);
            pizzaTabPageOld.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginSmallPanel.ResumeLayout(false);
            loginSmallPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Panel loginSmallPanel;
        private Panel mainPanel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button registerButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label loginErrorLabel;
        private Label usersErrorLabel;
        private Button getAllUsersButton;
        private TabControl adminPageTabControl;
        private TabPage usersTabPage;
        private ListView usersListView;
        private TabPage pizzaTabPageOld;
        private TabPage ordersTabPage;
        private ColumnHeader emailHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader phoneHeader;
        private Label adminPageLabel;
        private ColumnHeader addressHeader;
        private ListView pizzasListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button getAllPizzasButton;
        private Label pizzasErrorLabel;
        private Label ordersErrorLabel;
        private Button getAllOrdersButton;
        private TreeView ordersTreeView;
        private Label ordersPageLabel;
        private NumericUpDown orderPageNumericUpDown;
        private Button generateOrdersButton;
        private ProgressBar ordersGenerationProgressBar;
        private Button cartButton;
        private TabPage pizzasTabPage;
        private FlowLayoutPanel pizzasFlowLayoutPanel;
        private Panel pizzaPanelItem;
        private PictureBox pizzaPanelPictureBox;
        private NumericUpDown pizzaPanelNumericUpDown;
        private Label pizzaPanelPriceLabel;
        private Label pizzaPanelTitleLabel;
    }
}
