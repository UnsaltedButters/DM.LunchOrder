namespace DM.LunchOrder.UI
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
            gbMainCourse = new GroupBox();
            rdoPizza = new RadioButton();
            rdoSalad = new RadioButton();
            rdoHamburger = new RadioButton();
            gbAddons = new GroupBox();
            cbAddon3 = new CheckBox();
            cbAddon2 = new CheckBox();
            cbAddon1 = new CheckBox();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            lblOrderTotal = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            gbMainCourse.SuspendLayout();
            gbAddons.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbMainCourse
            // 
            gbMainCourse.Controls.Add(rdoPizza);
            gbMainCourse.Controls.Add(rdoSalad);
            gbMainCourse.Controls.Add(rdoHamburger);
            gbMainCourse.Location = new Point(28, 37);
            gbMainCourse.Name = "gbMainCourse";
            gbMainCourse.Size = new Size(200, 122);
            gbMainCourse.TabIndex = 0;
            gbMainCourse.TabStop = false;
            gbMainCourse.Text = "Main Course";
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(6, 47);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(51, 19);
            rdoPizza.TabIndex = 0;
            rdoPizza.TabStop = true;
            rdoPizza.Text = "Pizza";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += rdoPizza_CheckedChanged;
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(6, 72);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(53, 19);
            rdoSalad.TabIndex = 0;
            rdoSalad.TabStop = true;
            rdoSalad.Text = "Salad";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += rdoSalad_CheckedChanged;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(6, 22);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(86, 19);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // gbAddons
            // 
            gbAddons.Controls.Add(cbAddon3);
            gbAddons.Controls.Add(cbAddon2);
            gbAddons.Controls.Add(cbAddon1);
            gbAddons.Location = new Point(256, 37);
            gbAddons.Name = "gbAddons";
            gbAddons.Size = new Size(200, 122);
            gbAddons.TabIndex = 1;
            gbAddons.TabStop = false;
            gbAddons.Text = "Add-on items";
            // 
            // cbAddon3
            // 
            cbAddon3.AutoSize = true;
            cbAddon3.Location = new Point(6, 72);
            cbAddon3.Name = "cbAddon3";
            cbAddon3.Size = new Size(75, 19);
            cbAddon3.TabIndex = 0;
            cbAddon3.Text = "Add-On3";
            cbAddon3.UseVisualStyleBackColor = true;
            cbAddon3.CheckedChanged += cbAddon3_CheckedChanged;
            // 
            // cbAddon2
            // 
            cbAddon2.AutoSize = true;
            cbAddon2.Location = new Point(6, 47);
            cbAddon2.Name = "cbAddon2";
            cbAddon2.Size = new Size(75, 19);
            cbAddon2.TabIndex = 0;
            cbAddon2.Text = "Add-On2";
            cbAddon2.UseVisualStyleBackColor = true;
            cbAddon2.CheckedChanged += cbAddon2_CheckedChanged;
            // 
            // cbAddon1
            // 
            cbAddon1.AutoSize = true;
            cbAddon1.Location = new Point(6, 23);
            cbAddon1.Name = "cbAddon1";
            cbAddon1.Size = new Size(75, 19);
            cbAddon1.TabIndex = 0;
            cbAddon1.Text = "Add-On1";
            cbAddon1.UseVisualStyleBackColor = true;
            cbAddon1.CheckedChanged += cbAddon1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(txtTax);
            groupBox2.Controls.Add(lblOrderTotal);
            groupBox2.Controls.Add(lblTax);
            groupBox2.Controls.Add(lblSubtotal);
            groupBox2.Location = new Point(28, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 122);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(123, 86);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(100, 23);
            txtOrderTotal.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(123, 28);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 1;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(123, 57);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 1;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(43, 85);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(65, 15);
            lblOrderTotal.TabIndex = 0;
            lblOrderTotal.Text = "Order Total";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(39, 56);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(69, 15);
            lblTax.TabIndex = 0;
            lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(54, 31);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(330, 206);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(108, 23);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(348, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 367);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbAddons);
            Controls.Add(gbMainCourse);
            Name = "Form1";
            Text = "Form1";
            gbMainCourse.ResumeLayout(false);
            gbMainCourse.PerformLayout();
            gbAddons.ResumeLayout(false);
            gbAddons.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMainCourse;
        private RadioButton rdoPizza;
        private RadioButton rdoSalad;
        private RadioButton rdoHamburger;
        private GroupBox gbAddons;
        private CheckBox cbAddon3;
        private CheckBox cbAddon2;
        private CheckBox cbAddon1;
        private GroupBox groupBox2;
        private Label lblOrderTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private TextBox txtOrderTotal;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private Button btnPlaceOrder;
        private Button btnExit;
    }
}