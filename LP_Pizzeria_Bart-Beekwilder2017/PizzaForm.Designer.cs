namespace LP_Pizzeria_Bart_Beekwilder2017
{
    partial class PizzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnMenuNewOrder = new System.Windows.Forms.Button();
            this.btnMenuAddPizza = new System.Windows.Forms.Button();
            this.btnExportOrder = new System.Windows.Forms.Button();
            this.lblMenuOrder = new System.Windows.Forms.Label();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.btnFormAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomerStreet = new System.Windows.Forms.Label();
            this.lblCustomerResidence = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbFormCustomerHousenumber = new System.Windows.Forms.TextBox();
            this.tbFormCustomerStreet = new System.Windows.Forms.TextBox();
            this.tbFormCustomerResidence = new System.Windows.Forms.TextBox();
            this.tbFormCustomerName = new System.Windows.Forms.TextBox();
            this.pnlNewOrder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewOrderCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlAddPizza = new System.Windows.Forms.Panel();
            this.gbCustomPizza = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddedIngredients = new System.Windows.Forms.Label();
            this.cbCrusts = new System.Windows.Forms.ComboBox();
            this.cbIngredientsOrder = new System.Windows.Forms.ComboBox();
            this.btnAddIngredientPizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPizzaIngredients = new System.Windows.Forms.ListBox();
            this.gbShape = new System.Windows.Forms.GroupBox();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.nudCOrder = new System.Windows.Forms.NumericUpDown();
            this.nudBOrder = new System.Windows.Forms.NumericUpDown();
            this.nudAOrder = new System.Windows.Forms.NumericUpDown();
            this.btnAddCustomPizza = new System.Windows.Forms.Button();
            this.gbStandardPizza = new System.Windows.Forms.GroupBox();
            this.lbStandardPizzas = new System.Windows.Forms.ListBox();
            this.btnAddStandardPizza = new System.Windows.Forms.Button();
            this.lblAddPizza = new System.Windows.Forms.Label();
            this.btnRevenueProfit = new System.Windows.Forms.Button();
            this.pnlProfitRevenue = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlNewOrder.SuspendLayout();
            this.pnlAddPizza.SuspendLayout();
            this.gbCustomPizza.SuspendLayout();
            this.gbShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAOrder)).BeginInit();
            this.gbStandardPizza.SuspendLayout();
            this.pnlProfitRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 42);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Klant toevoegen";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnMenuNewOrder
            // 
            this.btnMenuNewOrder.Location = new System.Drawing.Point(12, 148);
            this.btnMenuNewOrder.Name = "btnMenuNewOrder";
            this.btnMenuNewOrder.Size = new System.Drawing.Size(129, 42);
            this.btnMenuNewOrder.TabIndex = 1;
            this.btnMenuNewOrder.Text = "Niewe bestelling";
            this.btnMenuNewOrder.UseVisualStyleBackColor = true;
            this.btnMenuNewOrder.Click += new System.EventHandler(this.btnMenuNewOrder_Click);
            // 
            // btnMenuAddPizza
            // 
            this.btnMenuAddPizza.Location = new System.Drawing.Point(12, 196);
            this.btnMenuAddPizza.Name = "btnMenuAddPizza";
            this.btnMenuAddPizza.Size = new System.Drawing.Size(129, 42);
            this.btnMenuAddPizza.TabIndex = 2;
            this.btnMenuAddPizza.Text = "Pizza maken";
            this.btnMenuAddPizza.UseVisualStyleBackColor = true;
            this.btnMenuAddPizza.Click += new System.EventHandler(this.btnMenuAddPizza_Click);
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Location = new System.Drawing.Point(12, 244);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(129, 42);
            this.btnExportOrder.TabIndex = 3;
            this.btnExportOrder.Text = "Exporteer bestelling";
            this.btnExportOrder.UseVisualStyleBackColor = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // lblMenuOrder
            // 
            this.lblMenuOrder.AutoSize = true;
            this.lblMenuOrder.Location = new System.Drawing.Point(51, 132);
            this.lblMenuOrder.Name = "lblMenuOrder";
            this.lblMenuOrder.Size = new System.Drawing.Size(52, 13);
            this.lblMenuOrder.TabIndex = 6;
            this.lblMenuOrder.Text = "Bestelling";
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.lblCustomerTitle);
            this.pnlAddCustomer.Controls.Add(this.btnFormAddCustomer);
            this.pnlAddCustomer.Controls.Add(this.lblCustomerStreet);
            this.pnlAddCustomer.Controls.Add(this.lblCustomerResidence);
            this.pnlAddCustomer.Controls.Add(this.lblCustomerName);
            this.pnlAddCustomer.Controls.Add(this.tbFormCustomerHousenumber);
            this.pnlAddCustomer.Controls.Add(this.tbFormCustomerStreet);
            this.pnlAddCustomer.Controls.Add(this.tbFormCustomerResidence);
            this.pnlAddCustomer.Controls.Add(this.tbFormCustomerName);
            this.pnlAddCustomer.Location = new System.Drawing.Point(174, 12);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(543, 464);
            this.pnlAddCustomer.TabIndex = 7;
            this.pnlAddCustomer.Visible = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(44, 35);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(210, 31);
            this.lblCustomerTitle.TabIndex = 8;
            this.lblCustomerTitle.Text = "Klant toevoegen";
            // 
            // btnFormAddCustomer
            // 
            this.btnFormAddCustomer.Location = new System.Drawing.Point(107, 180);
            this.btnFormAddCustomer.Name = "btnFormAddCustomer";
            this.btnFormAddCustomer.Size = new System.Drawing.Size(147, 42);
            this.btnFormAddCustomer.TabIndex = 7;
            this.btnFormAddCustomer.Text = "Toevoegen";
            this.btnFormAddCustomer.UseVisualStyleBackColor = true;
            this.btnFormAddCustomer.Click += new System.EventHandler(this.btnFormAddCustomer_Click);
            // 
            // lblCustomerStreet
            // 
            this.lblCustomerStreet.AutoSize = true;
            this.lblCustomerStreet.Location = new System.Drawing.Point(5, 144);
            this.lblCustomerStreet.Name = "lblCustomerStreet";
            this.lblCustomerStreet.Size = new System.Drawing.Size(97, 13);
            this.lblCustomerStreet.TabIndex = 6;
            this.lblCustomerStreet.Text = "Staat & huisnummer:";
            // 
            // lblCustomerResidence
            // 
            this.lblCustomerResidence.AutoSize = true;
            this.lblCustomerResidence.Location = new System.Drawing.Point(35, 118);
            this.lblCustomerResidence.Name = "lblCustomerResidence";
            this.lblCustomerResidence.Size = new System.Drawing.Size(67, 13);
            this.lblCustomerResidence.TabIndex = 5;
            this.lblCustomerResidence.Text = "Woonplaats:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(63, 92);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Naam:";
            // 
            // tbFormCustomerHousenumber
            // 
            this.tbFormCustomerHousenumber.Location = new System.Drawing.Point(225, 141);
            this.tbFormCustomerHousenumber.Name = "tbFormCustomerHousenumber";
            this.tbFormCustomerHousenumber.Size = new System.Drawing.Size(29, 20);
            this.tbFormCustomerHousenumber.TabIndex = 3;
            // 
            // tbFormCustomerStreet
            // 
            this.tbFormCustomerStreet.Location = new System.Drawing.Point(107, 141);
            this.tbFormCustomerStreet.Name = "tbFormCustomerStreet";
            this.tbFormCustomerStreet.Size = new System.Drawing.Size(112, 20);
            this.tbFormCustomerStreet.TabIndex = 2;
            // 
            // tbFormCustomerResidence
            // 
            this.tbFormCustomerResidence.Location = new System.Drawing.Point(107, 115);
            this.tbFormCustomerResidence.Name = "tbFormCustomerResidence";
            this.tbFormCustomerResidence.Size = new System.Drawing.Size(147, 20);
            this.tbFormCustomerResidence.TabIndex = 1;
            // 
            // tbFormCustomerName
            // 
            this.tbFormCustomerName.Location = new System.Drawing.Point(107, 89);
            this.tbFormCustomerName.Name = "tbFormCustomerName";
            this.tbFormCustomerName.Size = new System.Drawing.Size(147, 20);
            this.tbFormCustomerName.TabIndex = 0;
            // 
            // pnlNewOrder
            // 
            this.pnlNewOrder.Controls.Add(this.label2);
            this.pnlNewOrder.Controls.Add(this.tbNewOrderCustomerID);
            this.pnlNewOrder.Controls.Add(this.label1);
            this.pnlNewOrder.Controls.Add(this.btnNewOrder);
            this.pnlNewOrder.Location = new System.Drawing.Point(171, 12);
            this.pnlNewOrder.Name = "pnlNewOrder";
            this.pnlNewOrder.Size = new System.Drawing.Size(543, 464);
            this.pnlNewOrder.TabIndex = 9;
            this.pnlNewOrder.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Klantnummer (mag leeg gelaten worden):";
            // 
            // tbNewOrderCustomerID
            // 
            this.tbNewOrderCustomerID.Location = new System.Drawing.Point(53, 124);
            this.tbNewOrderCustomerID.Name = "tbNewOrderCustomerID";
            this.tbNewOrderCustomerID.Size = new System.Drawing.Size(196, 20);
            this.tbNewOrderCustomerID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nieuwe bestelling";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(69, 180);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(147, 42);
            this.btnNewOrder.TabIndex = 7;
            this.btnNewOrder.Text = "Aanmaken";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlAddPizza
            // 
            this.pnlAddPizza.Controls.Add(this.gbCustomPizza);
            this.pnlAddPizza.Controls.Add(this.gbStandardPizza);
            this.pnlAddPizza.Controls.Add(this.lblAddPizza);
            this.pnlAddPizza.Location = new System.Drawing.Point(171, 12);
            this.pnlAddPizza.Name = "pnlAddPizza";
            this.pnlAddPizza.Size = new System.Drawing.Size(546, 464);
            this.pnlAddPizza.TabIndex = 10;
            // 
            // gbCustomPizza
            // 
            this.gbCustomPizza.Controls.Add(this.label5);
            this.gbCustomPizza.Controls.Add(this.label4);
            this.gbCustomPizza.Controls.Add(this.lblAddedIngredients);
            this.gbCustomPizza.Controls.Add(this.cbCrusts);
            this.gbCustomPizza.Controls.Add(this.cbIngredientsOrder);
            this.gbCustomPizza.Controls.Add(this.btnAddIngredientPizza);
            this.gbCustomPizza.Controls.Add(this.label3);
            this.gbCustomPizza.Controls.Add(this.lbPizzaIngredients);
            this.gbCustomPizza.Controls.Add(this.gbShape);
            this.gbCustomPizza.Controls.Add(this.nudCOrder);
            this.gbCustomPizza.Controls.Add(this.nudBOrder);
            this.gbCustomPizza.Controls.Add(this.nudAOrder);
            this.gbCustomPizza.Controls.Add(this.btnAddCustomPizza);
            this.gbCustomPizza.Location = new System.Drawing.Point(228, 3);
            this.gbCustomPizza.Name = "gbCustomPizza";
            this.gbCustomPizza.Size = new System.Drawing.Size(213, 458);
            this.gbCustomPizza.TabIndex = 11;
            this.gbCustomPizza.TabStop = false;
            this.gbCustomPizza.Text = "Custom pizza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bodem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrediënten";
            // 
            // lblAddedIngredients
            // 
            this.lblAddedIngredients.AutoSize = true;
            this.lblAddedIngredients.Location = new System.Drawing.Point(16, 310);
            this.lblAddedIngredients.Name = "lblAddedIngredients";
            this.lblAddedIngredients.Size = new System.Drawing.Size(135, 13);
            this.lblAddedIngredients.TabIndex = 11;
            this.lblAddedIngredients.Text = "Toegevoegde ingrediënten";
            // 
            // cbCrusts
            // 
            this.cbCrusts.FormattingEnabled = true;
            this.cbCrusts.Location = new System.Drawing.Point(16, 157);
            this.cbCrusts.Name = "cbCrusts";
            this.cbCrusts.Size = new System.Drawing.Size(162, 21);
            this.cbCrusts.TabIndex = 10;
            // 
            // cbIngredientsOrder
            // 
            this.cbIngredientsOrder.FormattingEnabled = true;
            this.cbIngredientsOrder.Location = new System.Drawing.Point(17, 253);
            this.cbIngredientsOrder.Name = "cbIngredientsOrder";
            this.cbIngredientsOrder.Size = new System.Drawing.Size(162, 21);
            this.cbIngredientsOrder.TabIndex = 9;
            // 
            // btnAddIngredientPizza
            // 
            this.btnAddIngredientPizza.Location = new System.Drawing.Point(19, 280);
            this.btnAddIngredientPizza.Name = "btnAddIngredientPizza";
            this.btnAddIngredientPizza.Size = new System.Drawing.Size(160, 23);
            this.btnAddIngredientPizza.TabIndex = 8;
            this.btnAddIngredientPizza.Text = "Ingrediënt toevoegen";
            this.btnAddIngredientPizza.UseVisualStyleBackColor = true;
            this.btnAddIngredientPizza.Click += new System.EventHandler(this.btnAddIngredientPizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Afmetingen";
            // 
            // lbPizzaIngredients
            // 
            this.lbPizzaIngredients.FormattingEnabled = true;
            this.lbPizzaIngredients.Location = new System.Drawing.Point(16, 329);
            this.lbPizzaIngredients.Name = "lbPizzaIngredients";
            this.lbPizzaIngredients.Size = new System.Drawing.Size(165, 95);
            this.lbPizzaIngredients.TabIndex = 2;
            // 
            // gbShape
            // 
            this.gbShape.Controls.Add(this.rbTriangle);
            this.gbShape.Controls.Add(this.rbRectangle);
            this.gbShape.Controls.Add(this.rbCircle);
            this.gbShape.Location = new System.Drawing.Point(20, 22);
            this.gbShape.Name = "gbShape";
            this.gbShape.Size = new System.Drawing.Size(165, 92);
            this.gbShape.TabIndex = 6;
            this.gbShape.TabStop = false;
            this.gbShape.Text = "Vorm";
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(8, 64);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(74, 17);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.Text = "driehoekig";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(8, 40);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(86, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.Text = "Rechthoekig";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Checked = true;
            this.rbCircle.Location = new System.Drawing.Point(8, 16);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Rond";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // nudCOrder
            // 
            this.nudCOrder.Location = new System.Drawing.Point(136, 200);
            this.nudCOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCOrder.Name = "nudCOrder";
            this.nudCOrder.Size = new System.Drawing.Size(45, 20);
            this.nudCOrder.TabIndex = 5;
            this.nudCOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBOrder
            // 
            this.nudBOrder.Location = new System.Drawing.Point(78, 200);
            this.nudBOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBOrder.Name = "nudBOrder";
            this.nudBOrder.Size = new System.Drawing.Size(52, 20);
            this.nudBOrder.TabIndex = 4;
            this.nudBOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAOrder
            // 
            this.nudAOrder.Location = new System.Drawing.Point(20, 200);
            this.nudAOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAOrder.Name = "nudAOrder";
            this.nudAOrder.Size = new System.Drawing.Size(52, 20);
            this.nudAOrder.TabIndex = 3;
            this.nudAOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddCustomPizza
            // 
            this.btnAddCustomPizza.Location = new System.Drawing.Point(49, 430);
            this.btnAddCustomPizza.Name = "btnAddCustomPizza";
            this.btnAddCustomPizza.Size = new System.Drawing.Size(101, 23);
            this.btnAddCustomPizza.TabIndex = 1;
            this.btnAddCustomPizza.Text = "Pizza toevoegen";
            this.btnAddCustomPizza.UseVisualStyleBackColor = true;
            this.btnAddCustomPizza.Click += new System.EventHandler(this.btnAddCustomPizza_Click);
            // 
            // gbStandardPizza
            // 
            this.gbStandardPizza.Controls.Add(this.lbStandardPizzas);
            this.gbStandardPizza.Controls.Add(this.btnAddStandardPizza);
            this.gbStandardPizza.Location = new System.Drawing.Point(22, 74);
            this.gbStandardPizza.Name = "gbStandardPizza";
            this.gbStandardPizza.Size = new System.Drawing.Size(200, 235);
            this.gbStandardPizza.TabIndex = 10;
            this.gbStandardPizza.TabStop = false;
            this.gbStandardPizza.Text = "Standaard pizza";
            // 
            // lbStandardPizzas
            // 
            this.lbStandardPizzas.FormattingEnabled = true;
            this.lbStandardPizzas.Location = new System.Drawing.Point(6, 22);
            this.lbStandardPizzas.Name = "lbStandardPizzas";
            this.lbStandardPizzas.Size = new System.Drawing.Size(168, 147);
            this.lbStandardPizzas.TabIndex = 1;
            // 
            // btnAddStandardPizza
            // 
            this.btnAddStandardPizza.Location = new System.Drawing.Point(47, 192);
            this.btnAddStandardPizza.Name = "btnAddStandardPizza";
            this.btnAddStandardPizza.Size = new System.Drawing.Size(75, 23);
            this.btnAddStandardPizza.TabIndex = 0;
            this.btnAddStandardPizza.Text = "Toevoegen";
            this.btnAddStandardPizza.UseVisualStyleBackColor = true;
            this.btnAddStandardPizza.Click += new System.EventHandler(this.btnAddStandardPizza_Click);
            // 
            // lblAddPizza
            // 
            this.lblAddPizza.AutoSize = true;
            this.lblAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAddPizza.Location = new System.Drawing.Point(35, 35);
            this.lblAddPizza.Name = "lblAddPizza";
            this.lblAddPizza.Size = new System.Drawing.Size(169, 31);
            this.lblAddPizza.TabIndex = 9;
            this.lblAddPizza.Text = "Pizza maken";
            // 
            // btnRevenueProfit
            // 
            this.btnRevenueProfit.Location = new System.Drawing.Point(12, 60);
            this.btnRevenueProfit.Name = "btnRevenueProfit";
            this.btnRevenueProfit.Size = new System.Drawing.Size(129, 42);
            this.btnRevenueProfit.TabIndex = 11;
            this.btnRevenueProfit.Text = "Winst/Omzet";
            this.btnRevenueProfit.UseVisualStyleBackColor = true;
            this.btnRevenueProfit.Click += new System.EventHandler(this.btnRevenueProfit_Click);
            // 
            // pnlProfitRevenue
            // 
            this.pnlProfitRevenue.Controls.Add(this.lblRevenue);
            this.pnlProfitRevenue.Controls.Add(this.lblProfit);
            this.pnlProfitRevenue.Controls.Add(this.label8);
            this.pnlProfitRevenue.Controls.Add(this.label7);
            this.pnlProfitRevenue.Controls.Add(this.label6);
            this.pnlProfitRevenue.Location = new System.Drawing.Point(168, 12);
            this.pnlProfitRevenue.Name = "pnlProfitRevenue";
            this.pnlProfitRevenue.Size = new System.Drawing.Size(546, 477);
            this.pnlProfitRevenue.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(32, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Winst en omzet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Winst:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(42, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Omzet:";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProfit.Location = new System.Drawing.Point(109, 117);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(17, 20);
            this.lblProfit.TabIndex = 13;
            this.lblProfit.Text = "  ";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRevenue.Location = new System.Drawing.Point(109, 141);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(21, 20);
            this.lblRevenue.TabIndex = 14;
            this.lblRevenue.Text = "   ";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 501);
            this.Controls.Add(this.pnlAddPizza);
            this.Controls.Add(this.pnlProfitRevenue);
            this.Controls.Add(this.btnRevenueProfit);
            this.Controls.Add(this.pnlNewOrder);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.lblMenuOrder);
            this.Controls.Add(this.btnExportOrder);
            this.Controls.Add(this.btnMenuAddPizza);
            this.Controls.Add(this.btnMenuNewOrder);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "PizzaForm";
            this.Text = "Pizza Form";
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlNewOrder.ResumeLayout(false);
            this.pnlNewOrder.PerformLayout();
            this.pnlAddPizza.ResumeLayout(false);
            this.pnlAddPizza.PerformLayout();
            this.gbCustomPizza.ResumeLayout(false);
            this.gbCustomPizza.PerformLayout();
            this.gbShape.ResumeLayout(false);
            this.gbShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAOrder)).EndInit();
            this.gbStandardPizza.ResumeLayout(false);
            this.pnlProfitRevenue.ResumeLayout(false);
            this.pnlProfitRevenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnMenuNewOrder;
        private System.Windows.Forms.Button btnMenuAddPizza;
        private System.Windows.Forms.Button btnExportOrder;
        private System.Windows.Forms.Label lblMenuOrder;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Button btnFormAddCustomer;
        private System.Windows.Forms.Label lblCustomerStreet;
        private System.Windows.Forms.Label lblCustomerResidence;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbFormCustomerHousenumber;
        private System.Windows.Forms.TextBox tbFormCustomerStreet;
        private System.Windows.Forms.TextBox tbFormCustomerResidence;
        private System.Windows.Forms.TextBox tbFormCustomerName;
        private System.Windows.Forms.Panel pnlNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewOrderCustomerID;
        private System.Windows.Forms.Panel pnlAddPizza;
        private System.Windows.Forms.Label lblAddPizza;
        private System.Windows.Forms.GroupBox gbStandardPizza;
        private System.Windows.Forms.Button btnAddStandardPizza;
        private System.Windows.Forms.ListBox lbStandardPizzas;
        private System.Windows.Forms.GroupBox gbCustomPizza;
        private System.Windows.Forms.NumericUpDown nudCOrder;
        private System.Windows.Forms.NumericUpDown nudBOrder;
        private System.Windows.Forms.NumericUpDown nudAOrder;
        private System.Windows.Forms.ListBox lbPizzaIngredients;
        private System.Windows.Forms.Button btnAddCustomPizza;
        private System.Windows.Forms.GroupBox gbShape;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Button btnAddIngredientPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIngredientsOrder;
        private System.Windows.Forms.Label lblAddedIngredients;
        private System.Windows.Forms.ComboBox cbCrusts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRevenueProfit;
        private System.Windows.Forms.Panel pnlProfitRevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

