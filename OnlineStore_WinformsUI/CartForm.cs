using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore_WinformsUI
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            cartPizzaTitleLabel = new Label();
            cartPizzaDescriptionLabel = new Label();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            cartPizzaTotalLabel = new Label();
            cartCompleteButton = new Button();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(cartPizzaTotalLabel);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cartPizzaDescriptionLabel);
            panel1.Controls.Add(cartPizzaTitleLabel);
            panel1.Location = new Point(33, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 151);
            panel1.TabIndex = 0;
            // 
            // cartPizzaTitleLabel
            // 
            cartPizzaTitleLabel.AutoSize = true;
            cartPizzaTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartPizzaTitleLabel.Location = new Point(150, 25);
            cartPizzaTitleLabel.Name = "cartPizzaTitleLabel";
            cartPizzaTitleLabel.Size = new Size(62, 31);
            cartPizzaTitleLabel.TabIndex = 1;
            cartPizzaTitleLabel.Text = "Title";
            // 
            // cartPizzaDescriptionLabel
            // 
            cartPizzaDescriptionLabel.AutoSize = true;
            cartPizzaDescriptionLabel.Location = new Point(150, 70);
            cartPizzaDescriptionLabel.Name = "cartPizzaDescriptionLabel";
            cartPizzaDescriptionLabel.Size = new Size(85, 20);
            cartPizzaDescriptionLabel.TabIndex = 1;
            cartPizzaDescriptionLabel.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(258, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // cartPizzaTotalLabel
            // 
            cartPizzaTotalLabel.AutoSize = true;
            cartPizzaTotalLabel.Location = new Point(150, 111);
            cartPizzaTotalLabel.Name = "cartPizzaTotalLabel";
            cartPizzaTotalLabel.Size = new Size(45, 20);
            cartPizzaTotalLabel.TabIndex = 3;
            cartPizzaTotalLabel.Text = "0 Rsd";
            // 
            // cartCompleteButton
            // 
            cartCompleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cartCompleteButton.BackColor = Color.FromArgb(255, 224, 192);
            cartCompleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartCompleteButton.Location = new Point(420, 446);
            cartCompleteButton.Name = "cartCompleteButton";
            cartCompleteButton.Size = new Size(121, 50);
            cartCompleteButton.TabIndex = 1;
            cartCompleteButton.Text = "Complete";
            cartCompleteButton.UseVisualStyleBackColor = false;
            // 
            // CartForm
            // 
            ClientSize = new Size(567, 520);
            Controls.Add(cartCompleteButton);
            Controls.Add(panel1);
            Name = "CartForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label cartPizzaTotalLabel;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private Label cartPizzaDescriptionLabel;
        private Button cartCompleteButton;
        private Label cartPizzaTitleLabel;
    }
}
