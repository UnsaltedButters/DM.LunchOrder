namespace DM.LunchOrder.UI
{
    public partial class Form1 : Form
    {
        //main course prices
        private const decimal hamburger_price = 6.95m;
        private const decimal pizza_price = 5.95m;
        private const decimal salad_price = 4.95m;

        //add-on prices
        private const decimal hamburger_addons = 0.75m;
        private const decimal pizza_addons = 0.50m;
        private const decimal salad_addons = 0.25m;


        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateAddons(string addon1, string addon2, string addon3, string addonBox)
        {
            cbAddon1.Text = addon1;
            cbAddon2.Text = addon2;
            cbAddon3.Text = addon3;
            gbAddons.Text = addonBox;
        }

        private void ClearOrder()
        {
            cbAddon1.Checked = false;
            cbAddon2.Checked = false;
            cbAddon3.Checked = false;

            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }
        private void ClearOrderAddons()
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }

        private decimal GetAddonPrice()
        {
            if (rdoHamburger.Checked) return hamburger_addons;
            if (rdoPizza.Checked) return pizza_addons;
            if (rdoSalad.Checked) return salad_addons;
            return 0m;

        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddons("Lettuce, tomato, and onions", "Mayonnaise and mustard", "French fries", "Add-on items ($.75/each");
            ClearOrder();
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddons("Pepperoni", "Sausage", "Olives", "Add-on items ($.50/each");
            ClearOrder();
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddons("Croutons", "Bacon bits", "Bread sticks", "Add-on items ($.50/each");
            ClearOrder();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;

            if (rdoHamburger.Checked) subtotal += hamburger_price;
            if (rdoPizza.Checked) subtotal += pizza_price;
            if (rdoSalad.Checked) subtotal += salad_price;

            if (cbAddon1.Checked) subtotal += GetAddonPrice();
            if (cbAddon2.Checked) subtotal += GetAddonPrice();
            if (cbAddon3.Checked) subtotal += GetAddonPrice();

            decimal tax = subtotal * 0.775m;
            decimal total = subtotal + tax;


            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbAddon1_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderAddons();
        }

        private void cbAddon2_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderAddons();
        }

        private void cbAddon3_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderAddons();
        }
    }
}