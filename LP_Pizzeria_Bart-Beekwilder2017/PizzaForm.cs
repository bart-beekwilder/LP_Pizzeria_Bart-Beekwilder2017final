using LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL;
using LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public partial class PizzaForm : Form
    {
        Pizzeria pizzeria;
        List<Ingredient> pizzaIngredients;
        public PizzaForm()
        {
            InitializeComponent();
            pizzeria = new Pizzeria();
            pizzaIngredients = new List<Ingredient>();
            HideAllPannels();
            UpdateButtons();
        }
        private void UpdateButtons()
        {
            if(pizzeria.CurrentOrder == null)
            {
                btnNewOrder.Enabled = true;
                btnMenuNewOrder.Enabled = true;

                btnMenuAddPizza.Enabled = false;
                btnExportOrder.Enabled = false;
            }
            else
            {
                btnNewOrder.Enabled = false;
                btnMenuNewOrder.Enabled = false;

                btnMenuAddPizza.Enabled = true;
                btnExportOrder.Enabled = true;
            }
        }
        private void HideAllPannels()
        {
            pnlAddCustomer.Hide();
            pnlAddPizza.Hide();
            pnlNewOrder.Hide();
            pnlProfitRevenue.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            HideAllPannels();
            pnlAddCustomer.Show();
            pnlAddCustomer.Visible = true;
        }

        private void btnFormAddCustomer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbFormCustomerName.Text)|| string.IsNullOrWhiteSpace(tbFormCustomerResidence.Text)|| string.IsNullOrWhiteSpace(tbFormCustomerStreet.Text)|| string.IsNullOrWhiteSpace(tbFormCustomerHousenumber.Text))
            {
                MessageBox.Show("Niet alle velden zijn ingevuld!");
            }
            else
            {
                int i;
                if (Int32.TryParse(tbFormCustomerHousenumber.Text, out i))
                {
                    CustomerRepo cRepo = new CustomerRepo(new CustomerMSSQLContext());
                    cRepo.Insert(new Customer(-1, tbFormCustomerName.Text, tbFormCustomerResidence.Text, tbFormCustomerStreet.Text, Convert.ToInt32(tbFormCustomerHousenumber.Text)));
                }
                else
                {
                    MessageBox.Show("In huisnummer veld moet een nummer ingevuld zijn!");
                }
            }
        }

        private void btnMenuNewOrder_Click(object sender, EventArgs e)
        {
            HideAllPannels();
            pnlNewOrder.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Order order;
            Customer customer;
            try
            {
                CustomerRepo cRepo = new CustomerRepo(new CustomerMSSQLContext());
                customer = cRepo.GetByID(Convert.ToInt32(tbNewOrderCustomerID.Text));
                order = new Order(-1, customer);
            }
            catch
            {
                order = new Order(-1);
            }
            pizzeria.NewOrder(order);
            UpdateButtons();
            HideAllPannels();
        }

        private void btnMenuAddPizza_Click(object sender, EventArgs e)
        {
            lbStandardPizzas.Items.Clear();
            cbCrusts.DataSource = null;
            cbIngredientsOrder.DataSource = null;
            PizzaRepo pRepo = new PizzaRepo(new PizzaMSSQLContext());
            List<Pizza> standardPizzas = pRepo.GetAll(true);
            IngredientRepo iRepo = new IngredientRepo(new IngredientMSSQLContext());
            List<Ingredient> ingredients = iRepo.GetAll();
            CrustRepo cRepo = new CrustRepo(new CrustMSSQLContext());
            List<Crust> crusts = cRepo.GetAll();
            foreach(Pizza pizza in standardPizzas)
            {
                lbStandardPizzas.Items.Add(pizza);
            }
            cbIngredientsOrder.DataSource = ingredients;
            cbCrusts.DataSource = crusts;
            pizzaIngredients.Clear();
            HideAllPannels();
            pnlAddPizza.Show();
        }

        private void btnAddStandardPizza_Click(object sender, EventArgs e)
        {
            if(lbStandardPizzas != null)
            {
                pizzeria.CurrentOrder.AddPizza((Pizza)lbStandardPizzas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een pizza");
            }
        }

        private void btnAddCustomPizza_Click(object sender, EventArgs e)
        {
            Shape shape;
            Crust crust = (Crust)cbCrusts.SelectedItem;
            if (rbCircle.Checked)
            {
                shape = Shape.Circle;
                pizzeria.CurrentOrder.AddPizza(new Pizza("Custom pizza", false, Convert.ToInt32(nudAOrder.Value), pizzaIngredients, crust));
            }
            else if (rbRectangle.Checked)
            {
                shape = Shape.Rectangle;
                pizzeria.CurrentOrder.AddPizza(new Pizza("Custom pizza", false, Convert.ToInt32(nudAOrder.Value),Convert.ToInt32(nudBOrder.Value), pizzaIngredients, crust));
            }
            else if (rbTriangle.Checked)
            {
                shape = Shape.Triangle;
                pizzeria.CurrentOrder.AddPizza(new Pizza("Custom pizza", false, Convert.ToInt32(nudAOrder.Value), Convert.ToInt32(nudBOrder.Value), Convert.ToInt32(nudCOrder.Value), pizzaIngredients, crust));
            }
        }

        private void btnAddIngredientPizza_Click(object sender, EventArgs e)
        {
            if (cbIngredientsOrder.SelectedItem != null)
            {
                pizzaIngredients.Add((Ingredient)cbIngredientsOrder.SelectedItem);
                lbPizzaIngredients.Items.Clear();
                foreach (Ingredient ingredient in pizzaIngredients)
                {
                    lbPizzaIngredients.Items.Add(ingredient);
                }
            }
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    pizzeria.ExportOrder(path);
                }
            }
            catch (Exception eh)
            {
                MessageBox.Show(eh.Message);
            }
            HideAllPannels();
            UpdateButtons();
        }

        private void btnRevenueProfit_Click(object sender, EventArgs e)
        {
            HideAllPannels();
            pnlProfitRevenue.Show();
            lblProfit.Text = "€" + pizzeria.Profit.ToString("0.00");
            lblRevenue.Text = "€" + pizzeria.Revenue.ToString("0.00");
        }
    }
}
