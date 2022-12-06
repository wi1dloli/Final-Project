
namespace Final_Project
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopSelect = new System.Windows.Forms.Button();
            this.Sprinkles = new System.Windows.Forms.Button();
            this.MeltedMarshmellow = new System.Windows.Forms.Button();
            this.Oreos = new System.Windows.Forms.Button();
            this.WhippedCream = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Select = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StrawberrySauce = new System.Windows.Forms.Button();
            this.ChocolateSauce = new System.Windows.Forms.Button();
            this.VanillaIce = new System.Windows.Forms.RadioButton();
            this.ChocolateIce = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CashAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TopSelect);
            this.groupBox1.Controls.Add(this.Sprinkles);
            this.groupBox1.Controls.Add(this.MeltedMarshmellow);
            this.groupBox1.Controls.Add(this.Oreos);
            this.groupBox1.Controls.Add(this.WhippedCream);
            this.groupBox1.Location = new System.Drawing.Point(465, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topings ($0.75)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // TopSelect
            // 
            this.TopSelect.Location = new System.Drawing.Point(195, 62);
            this.TopSelect.Name = "TopSelect";
            this.TopSelect.Size = new System.Drawing.Size(106, 29);
            this.TopSelect.TabIndex = 7;
            this.TopSelect.Text = "Select";
            this.TopSelect.UseVisualStyleBackColor = true;
            this.TopSelect.Click += new System.EventHandler(this.TopSelect_Click);
            // 
            // Sprinkles
            // 
            this.Sprinkles.Location = new System.Drawing.Point(23, 38);
            this.Sprinkles.Name = "Sprinkles";
            this.Sprinkles.Size = new System.Drawing.Size(142, 36);
            this.Sprinkles.TabIndex = 5;
            this.Sprinkles.Text = "Sprinkles";
            this.Sprinkles.UseVisualStyleBackColor = true;
            this.Sprinkles.Click += new System.EventHandler(this.Sprinkles_Click);
            // 
            // MeltedMarshmellow
            // 
            this.MeltedMarshmellow.Location = new System.Drawing.Point(23, 90);
            this.MeltedMarshmellow.Name = "MeltedMarshmellow";
            this.MeltedMarshmellow.Size = new System.Drawing.Size(142, 36);
            this.MeltedMarshmellow.TabIndex = 4;
            this.MeltedMarshmellow.Text = "Melted Marshmellow";
            this.MeltedMarshmellow.UseVisualStyleBackColor = true;
            this.MeltedMarshmellow.Click += new System.EventHandler(this.MeltedMarshmellow_Click);
            // 
            // Oreos
            // 
            this.Oreos.Location = new System.Drawing.Point(23, 144);
            this.Oreos.Name = "Oreos";
            this.Oreos.Size = new System.Drawing.Size(142, 36);
            this.Oreos.TabIndex = 3;
            this.Oreos.Text = "Oreos";
            this.Oreos.UseVisualStyleBackColor = true;
            this.Oreos.Click += new System.EventHandler(this.Oreos_Click);
            // 
            // WhippedCream
            // 
            this.WhippedCream.Location = new System.Drawing.Point(23, 198);
            this.WhippedCream.Name = "WhippedCream";
            this.WhippedCream.Size = new System.Drawing.Size(142, 36);
            this.WhippedCream.TabIndex = 2;
            this.WhippedCream.Text = "Whipped Cream";
            this.WhippedCream.UseVisualStyleBackColor = true;
            this.WhippedCream.Click += new System.EventHandler(this.WhippedCream_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Select);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.VanillaIce);
            this.groupBox2.Controls.Add(this.ChocolateIce);
            this.groupBox2.Location = new System.Drawing.Point(92, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ice Cream ($2.00)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(186, 62);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(106, 29);
            this.Select.TabIndex = 6;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.StrawberrySauce);
            this.groupBox3.Controls.Add(this.ChocolateSauce);
            this.groupBox3.Location = new System.Drawing.Point(23, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 131);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sauce ($0.50)";
            // 
            // StrawberrySauce
            // 
            this.StrawberrySauce.Location = new System.Drawing.Point(15, 20);
            this.StrawberrySauce.Name = "StrawberrySauce";
            this.StrawberrySauce.Size = new System.Drawing.Size(142, 36);
            this.StrawberrySauce.TabIndex = 2;
            this.StrawberrySauce.Text = "Strawberry Sauce";
            this.StrawberrySauce.UseVisualStyleBackColor = true;
            this.StrawberrySauce.Click += new System.EventHandler(this.StrawberrySauce_Click);
            // 
            // ChocolateSauce
            // 
            this.ChocolateSauce.Location = new System.Drawing.Point(15, 62);
            this.ChocolateSauce.Name = "ChocolateSauce";
            this.ChocolateSauce.Size = new System.Drawing.Size(142, 36);
            this.ChocolateSauce.TabIndex = 1;
            this.ChocolateSauce.Text = "Chocolate Sauce";
            this.ChocolateSauce.UseVisualStyleBackColor = true;
            this.ChocolateSauce.Click += new System.EventHandler(this.ChocolateSauce_Click);
            // 
            // VanillaIce
            // 
            this.VanillaIce.AutoSize = true;
            this.VanillaIce.Location = new System.Drawing.Point(40, 48);
            this.VanillaIce.Name = "VanillaIce";
            this.VanillaIce.Size = new System.Drawing.Size(56, 17);
            this.VanillaIce.TabIndex = 4;
            this.VanillaIce.TabStop = true;
            this.VanillaIce.Text = "Vanilla";
            this.VanillaIce.UseVisualStyleBackColor = true;
            // 
            // ChocolateIce
            // 
            this.ChocolateIce.AutoSize = true;
            this.ChocolateIce.Location = new System.Drawing.Point(40, 90);
            this.ChocolateIce.Name = "ChocolateIce";
            this.ChocolateIce.Size = new System.Drawing.Size(73, 17);
            this.ChocolateIce.TabIndex = 3;
            this.ChocolateIce.TabStop = true;
            this.ChocolateIce.Text = "Chocolate";
            this.ChocolateIce.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 405);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 40);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actions";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 405);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 40);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // CashAmount
            // 
            this.CashAmount.Location = new System.Drawing.Point(169, 51);
            this.CashAmount.Name = "CashAmount";
            this.CashAmount.Size = new System.Drawing.Size(122, 20);
            this.CashAmount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Insert Cash";
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(384, 452);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(82, 30);
            this.Pay.TabIndex = 8;
            this.Pay.Text = "Pay!";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Change";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 458);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 40);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 532);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CashAmount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Sprinkles;
        private System.Windows.Forms.Button MeltedMarshmellow;
        private System.Windows.Forms.Button Oreos;
        private System.Windows.Forms.Button WhippedCream;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton VanillaIce;
        private System.Windows.Forms.RadioButton ChocolateIce;
        private System.Windows.Forms.Button StrawberrySauce;
        private System.Windows.Forms.Button ChocolateSauce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TopSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CashAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}

