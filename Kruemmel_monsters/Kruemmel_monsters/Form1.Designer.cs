namespace Kruemmel_monsters
{
    partial class GuiCheckout
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.selection_burger = new System.Windows.Forms.CheckedListBox();
            this.selection_drink = new System.Windows.Forms.CheckedListBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.type_burger = new System.Windows.Forms.LinkLabel();
            this.type_drink = new System.Windows.Forms.LinkLabel();
            this.output_price = new System.Windows.Forms.TextBox();
            this.title_price = new System.Windows.Forms.Label();
            this.selection_addition = new System.Windows.Forms.CheckedListBox();
            this.type_additional = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // selection_burger
            // 
            this.selection_burger.FormattingEnabled = true;
            this.selection_burger.Items.AddRange(new object[] {
            "Cheese-Burger",
            "Chicken-Burger",
            "Hamburger",
            "BBQ-Burger"});
            this.selection_burger.Location = new System.Drawing.Point(12, 55);
            this.selection_burger.Name = "selection_burger";
            this.selection_burger.Size = new System.Drawing.Size(120, 94);
            this.selection_burger.TabIndex = 0;
            // 
            // selection_drink
            // 
            this.selection_drink.FormattingEnabled = true;
            this.selection_drink.Items.AddRange(new object[] {
            "Wasser",
            "Cola",
            "Fanta",
            "Sprite",
            "Kaffee",
            "Milchshake"});
            this.selection_drink.Location = new System.Drawing.Point(207, 55);
            this.selection_drink.Name = "selection_drink";
            this.selection_drink.Size = new System.Drawing.Size(120, 94);
            this.selection_drink.TabIndex = 1;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(230, 188);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Bestellen";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // type_burger
            // 
            this.type_burger.AutoSize = true;
            this.type_burger.Location = new System.Drawing.Point(47, 28);
            this.type_burger.Name = "type_burger";
            this.type_burger.Size = new System.Drawing.Size(38, 13);
            this.type_burger.TabIndex = 4;
            this.type_burger.TabStop = true;
            this.type_burger.Text = "Burger";
            // 
            // type_drink
            // 
            this.type_drink.AutoSize = true;
            this.type_drink.Location = new System.Drawing.Point(243, 27);
            this.type_drink.Name = "type_drink";
            this.type_drink.Size = new System.Drawing.Size(51, 13);
            this.type_drink.TabIndex = 5;
            this.type_drink.TabStop = true;
            this.type_drink.Text = "Getränke";
            // 
            // output_price
            // 
            this.output_price.Location = new System.Drawing.Point(217, 247);
            this.output_price.Name = "output_price";
            this.output_price.Size = new System.Drawing.Size(100, 20);
            this.output_price.TabIndex = 6;
            // 
            // title_price
            // 
            this.title_price.AutoSize = true;
            this.title_price.Location = new System.Drawing.Point(167, 250);
            this.title_price.Name = "title_price";
            this.title_price.Size = new System.Drawing.Size(30, 13);
            this.title_price.TabIndex = 7;
            this.title_price.Text = "Preis";
            // 
            // selection_addition
            // 
            this.selection_addition.FormattingEnabled = true;
            this.selection_addition.Items.AddRange(new object[] {
            "Pommes",
            "Salat",
            "Kartoffelecken",
            "Reis"});
            this.selection_addition.Location = new System.Drawing.Point(407, 55);
            this.selection_addition.Name = "selection_addition";
            this.selection_addition.Size = new System.Drawing.Size(120, 94);
            this.selection_addition.TabIndex = 8;
            // 
            // type_additional
            // 
            this.type_additional.AutoSize = true;
            this.type_additional.Location = new System.Drawing.Point(436, 26);
            this.type_additional.Name = "type_additional";
            this.type_additional.Size = new System.Drawing.Size(42, 13);
            this.type_additional.TabIndex = 9;
            this.type_additional.TabStop = true;
            this.type_additional.Text = "Beilage";
            // 
            // GuiCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 297);
            this.Controls.Add(this.type_additional);
            this.Controls.Add(this.selection_addition);
            this.Controls.Add(this.title_price);
            this.Controls.Add(this.output_price);
            this.Controls.Add(this.type_drink);
            this.Controls.Add(this.type_burger);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.selection_drink);
            this.Controls.Add(this.selection_burger);
            this.Name = "GuiCheckout";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox selection_burger;
        private System.Windows.Forms.CheckedListBox selection_drink;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.LinkLabel type_burger;
        private System.Windows.Forms.LinkLabel type_drink;
        private System.Windows.Forms.TextBox output_price;
        private System.Windows.Forms.Label title_price;
        private System.Windows.Forms.CheckedListBox selection_addition;
        private System.Windows.Forms.LinkLabel type_additional;
    }
}

