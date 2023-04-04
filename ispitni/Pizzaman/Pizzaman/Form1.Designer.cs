namespace Pizzaman
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
            this.tbKetchup = new System.Windows.Forms.TextBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.tbExtraCheese = new System.Windows.Forms.TextBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.tbHotPeppers = new System.Windows.Forms.TextBox();
            this.cbHotPeppers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTotalBeer = new System.Windows.Forms.TextBox();
            this.tbBeerPrice = new System.Windows.Forms.TextBox();
            this.tbQtyBeer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalJuice = new System.Windows.Forms.TextBox();
            this.tbJuicePrice = new System.Windows.Forms.TextBox();
            this.tbQtyJuice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalCoke = new System.Windows.Forms.TextBox();
            this.tbCokePrice = new System.Windows.Forms.TextBox();
            this.tbQtyCoke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLargeSize = new System.Windows.Forms.TextBox();
            this.tbMediumSize = new System.Windows.Forms.TextBox();
            this.tbSmallSize = new System.Windows.Forms.TextBox();
            this.rbLargeSize = new System.Windows.Forms.RadioButton();
            this.rbMediumSize = new System.Windows.Forms.RadioButton();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalToPay = new System.Windows.Forms.TextBox();
            this.tbTotalToReturn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalPaid = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancelDessert = new System.Windows.Forms.Button();
            this.btnOrderDessert = new System.Windows.Forms.Button();
            this.lbDessert = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDessertPrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKetchup);
            this.groupBox1.Controls.Add(this.cbKetchup);
            this.groupBox1.Controls.Add(this.tbExtraCheese);
            this.groupBox1.Controls.Add(this.cbExtraCheese);
            this.groupBox1.Controls.Add(this.tbHotPeppers);
            this.groupBox1.Controls.Add(this.cbHotPeppers);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додатоци";
            // 
            // tbKetchup
            // 
            this.tbKetchup.Location = new System.Drawing.Point(240, 91);
            this.tbKetchup.Name = "tbKetchup";
            this.tbKetchup.Size = new System.Drawing.Size(100, 20);
            this.tbKetchup.TabIndex = 5;
            this.tbKetchup.Text = "20";
            this.tbKetchup.TextChanged += new System.EventHandler(this.tbKetchup_TextChanged);
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(22, 92);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(56, 17);
            this.cbKetchup.TabIndex = 2;
            this.cbKetchup.Text = "Кечап";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.cbKetchup_CheckedChanged);
            // 
            // tbExtraCheese
            // 
            this.tbExtraCheese.Location = new System.Drawing.Point(240, 57);
            this.tbExtraCheese.Name = "tbExtraCheese";
            this.tbExtraCheese.Size = new System.Drawing.Size(100, 20);
            this.tbExtraCheese.TabIndex = 4;
            this.tbExtraCheese.Text = "30";
            this.tbExtraCheese.TextChanged += new System.EventHandler(this.tbExtraCheese_TextChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(22, 57);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(105, 17);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Екстра сирење";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            // 
            // tbHotPeppers
            // 
            this.tbHotPeppers.Location = new System.Drawing.Point(240, 21);
            this.tbHotPeppers.Name = "tbHotPeppers";
            this.tbHotPeppers.Size = new System.Drawing.Size(100, 20);
            this.tbHotPeppers.TabIndex = 3;
            this.tbHotPeppers.Text = "40";
            this.tbHotPeppers.TextChanged += new System.EventHandler(this.tbHotPeppers_TextChanged);
            // 
            // cbHotPeppers
            // 
            this.cbHotPeppers.AutoSize = true;
            this.cbHotPeppers.Location = new System.Drawing.Point(22, 21);
            this.cbHotPeppers.Name = "cbHotPeppers";
            this.cbHotPeppers.Size = new System.Drawing.Size(87, 17);
            this.cbHotPeppers.TabIndex = 0;
            this.cbHotPeppers.Text = "Феферонки";
            this.cbHotPeppers.UseVisualStyleBackColor = true;
            this.cbHotPeppers.CheckedChanged += new System.EventHandler(this.cbHotPeppers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotalBeer);
            this.groupBox2.Controls.Add(this.tbBeerPrice);
            this.groupBox2.Controls.Add(this.tbQtyBeer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTotalJuice);
            this.groupBox2.Controls.Add(this.tbJuicePrice);
            this.groupBox2.Controls.Add(this.tbQtyJuice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbTotalCoke);
            this.groupBox2.Controls.Add(this.tbCokePrice);
            this.groupBox2.Controls.Add(this.tbQtyCoke);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пијалок";
            // 
            // tbTotalBeer
            // 
            this.tbTotalBeer.Enabled = false;
            this.tbTotalBeer.Location = new System.Drawing.Point(652, 98);
            this.tbTotalBeer.Name = "tbTotalBeer";
            this.tbTotalBeer.Size = new System.Drawing.Size(100, 20);
            this.tbTotalBeer.TabIndex = 11;
            this.tbTotalBeer.Text = "0";
            // 
            // tbBeerPrice
            // 
            this.tbBeerPrice.Location = new System.Drawing.Point(438, 98);
            this.tbBeerPrice.Name = "tbBeerPrice";
            this.tbBeerPrice.Size = new System.Drawing.Size(100, 20);
            this.tbBeerPrice.TabIndex = 8;
            this.tbBeerPrice.Text = "80";
            this.tbBeerPrice.TextChanged += new System.EventHandler(this.tbBeerPrice_TextChanged);
            // 
            // tbQtyBeer
            // 
            this.tbQtyBeer.Location = new System.Drawing.Point(244, 98);
            this.tbQtyBeer.Name = "tbQtyBeer";
            this.tbQtyBeer.Size = new System.Drawing.Size(100, 20);
            this.tbQtyBeer.TabIndex = 5;
            this.tbQtyBeer.Text = "0";
            this.tbQtyBeer.TextChanged += new System.EventHandler(this.tbQtyBeer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // tbTotalJuice
            // 
            this.tbTotalJuice.Enabled = false;
            this.tbTotalJuice.Location = new System.Drawing.Point(652, 64);
            this.tbTotalJuice.Name = "tbTotalJuice";
            this.tbTotalJuice.Size = new System.Drawing.Size(100, 20);
            this.tbTotalJuice.TabIndex = 10;
            this.tbTotalJuice.Text = "0";
            // 
            // tbJuicePrice
            // 
            this.tbJuicePrice.Location = new System.Drawing.Point(438, 64);
            this.tbJuicePrice.Name = "tbJuicePrice";
            this.tbJuicePrice.Size = new System.Drawing.Size(100, 20);
            this.tbJuicePrice.TabIndex = 7;
            this.tbJuicePrice.Text = "70";
            this.tbJuicePrice.TextChanged += new System.EventHandler(this.tbJuicePrice_TextChanged);
            // 
            // tbQtyJuice
            // 
            this.tbQtyJuice.Location = new System.Drawing.Point(244, 64);
            this.tbQtyJuice.Name = "tbQtyJuice";
            this.tbQtyJuice.Size = new System.Drawing.Size(100, 20);
            this.tbQtyJuice.TabIndex = 4;
            this.tbQtyJuice.Text = "0";
            this.tbQtyJuice.TextChanged += new System.EventHandler(this.tbQtyJuice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // tbTotalCoke
            // 
            this.tbTotalCoke.Enabled = false;
            this.tbTotalCoke.Location = new System.Drawing.Point(652, 28);
            this.tbTotalCoke.Name = "tbTotalCoke";
            this.tbTotalCoke.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCoke.TabIndex = 9;
            this.tbTotalCoke.Text = "0";
            // 
            // tbCokePrice
            // 
            this.tbCokePrice.Location = new System.Drawing.Point(438, 28);
            this.tbCokePrice.Name = "tbCokePrice";
            this.tbCokePrice.Size = new System.Drawing.Size(100, 20);
            this.tbCokePrice.TabIndex = 6;
            this.tbCokePrice.Text = "60";
            this.tbCokePrice.TextChanged += new System.EventHandler(this.tbCokePrice_TextChanged);
            // 
            // tbQtyCoke
            // 
            this.tbQtyCoke.Location = new System.Drawing.Point(244, 28);
            this.tbQtyCoke.Name = "tbQtyCoke";
            this.tbQtyCoke.Size = new System.Drawing.Size(100, 20);
            this.tbQtyCoke.TabIndex = 3;
            this.tbQtyCoke.Text = "0";
            this.tbQtyCoke.TextChanged += new System.EventHandler(this.tbQtyCoke_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLargeSize);
            this.groupBox3.Controls.Add(this.tbMediumSize);
            this.groupBox3.Controls.Add(this.tbSmallSize);
            this.groupBox3.Controls.Add(this.rbLargeSize);
            this.groupBox3.Controls.Add(this.rbMediumSize);
            this.groupBox3.Controls.Add(this.rbSmallSize);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 131);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Големина";
            // 
            // tbLargeSize
            // 
            this.tbLargeSize.Location = new System.Drawing.Point(233, 89);
            this.tbLargeSize.Name = "tbLargeSize";
            this.tbLargeSize.Size = new System.Drawing.Size(100, 20);
            this.tbLargeSize.TabIndex = 5;
            this.tbLargeSize.Text = "500";
            this.tbLargeSize.TextChanged += new System.EventHandler(this.tbLargeSize_TextChanged);
            // 
            // tbMediumSize
            // 
            this.tbMediumSize.Location = new System.Drawing.Point(233, 55);
            this.tbMediumSize.Name = "tbMediumSize";
            this.tbMediumSize.Size = new System.Drawing.Size(100, 20);
            this.tbMediumSize.TabIndex = 4;
            this.tbMediumSize.Text = "300";
            this.tbMediumSize.TextChanged += new System.EventHandler(this.tbMediumSize_TextChanged);
            // 
            // tbSmallSize
            // 
            this.tbSmallSize.Location = new System.Drawing.Point(233, 19);
            this.tbSmallSize.Name = "tbSmallSize";
            this.tbSmallSize.Size = new System.Drawing.Size(100, 20);
            this.tbSmallSize.TabIndex = 3;
            this.tbSmallSize.Text = "200";
            this.tbSmallSize.TextChanged += new System.EventHandler(this.tbSmallSize_TextChanged);
            // 
            // rbLargeSize
            // 
            this.rbLargeSize.AutoSize = true;
            this.rbLargeSize.Location = new System.Drawing.Point(17, 92);
            this.rbLargeSize.Name = "rbLargeSize";
            this.rbLargeSize.Size = new System.Drawing.Size(63, 17);
            this.rbLargeSize.TabIndex = 2;
            this.rbLargeSize.TabStop = true;
            this.rbLargeSize.Text = "Голема";
            this.rbLargeSize.UseVisualStyleBackColor = true;
            this.rbLargeSize.CheckedChanged += new System.EventHandler(this.rbLargeSize_CheckedChanged);
            // 
            // rbMediumSize
            // 
            this.rbMediumSize.AutoSize = true;
            this.rbMediumSize.Location = new System.Drawing.Point(17, 56);
            this.rbMediumSize.Name = "rbMediumSize";
            this.rbMediumSize.Size = new System.Drawing.Size(62, 17);
            this.rbMediumSize.TabIndex = 1;
            this.rbMediumSize.TabStop = true;
            this.rbMediumSize.Text = "Средна";
            this.rbMediumSize.UseVisualStyleBackColor = true;
            this.rbMediumSize.CheckedChanged += new System.EventHandler(this.rbMediumSize_CheckedChanged);
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Location = new System.Drawing.Point(17, 20);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(52, 17);
            this.rbSmallSize.TabIndex = 0;
            this.rbSmallSize.TabStop = true;
            this.rbSmallSize.Text = "Мала";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbTotalToPay);
            this.groupBox4.Controls.Add(this.tbTotalToReturn);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbTotalPaid);
            this.groupBox4.Location = new System.Drawing.Point(414, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 131);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // tbTotalToPay
            // 
            this.tbTotalToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalToPay.Location = new System.Drawing.Point(150, 19);
            this.tbTotalToPay.Name = "tbTotalToPay";
            this.tbTotalToPay.Size = new System.Drawing.Size(187, 26);
            this.tbTotalToPay.TabIndex = 1;
            this.tbTotalToPay.Text = "200";
            // 
            // tbTotalToReturn
            // 
            this.tbTotalToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalToReturn.Location = new System.Drawing.Point(150, 89);
            this.tbTotalToReturn.Name = "tbTotalToReturn";
            this.tbTotalToReturn.Size = new System.Drawing.Size(187, 26);
            this.tbTotalToReturn.TabIndex = 5;
            this.tbTotalToReturn.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Наплатено:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "За враќање:";
            // 
            // tbTotalPaid
            // 
            this.tbTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPaid.Location = new System.Drawing.Point(150, 55);
            this.tbTotalPaid.Name = "tbTotalPaid";
            this.tbTotalPaid.Size = new System.Drawing.Size(187, 26);
            this.tbTotalPaid.TabIndex = 3;
            this.tbTotalPaid.Text = "0";
            this.tbTotalPaid.TextChanged += new System.EventHandler(this.tbTotalPaid_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancelDessert);
            this.groupBox5.Controls.Add(this.btnOrderDessert);
            this.groupBox5.Controls.Add(this.lbDessert);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbDessertPrice);
            this.groupBox5.Location = new System.Drawing.Point(12, 286);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 131);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Десерт";
            // 
            // btnCancelDessert
            // 
            this.btnCancelDessert.Location = new System.Drawing.Point(144, 90);
            this.btnCancelDessert.Name = "btnCancelDessert";
            this.btnCancelDessert.Size = new System.Drawing.Size(189, 23);
            this.btnCancelDessert.TabIndex = 4;
            this.btnCancelDessert.Text = "Откажи";
            this.btnCancelDessert.UseVisualStyleBackColor = true;
            this.btnCancelDessert.Click += new System.EventHandler(this.btnCancelDessert_Click);
            // 
            // btnOrderDessert
            // 
            this.btnOrderDessert.Location = new System.Drawing.Point(144, 61);
            this.btnOrderDessert.Name = "btnOrderDessert";
            this.btnOrderDessert.Size = new System.Drawing.Size(189, 23);
            this.btnOrderDessert.TabIndex = 3;
            this.btnOrderDessert.Text = "Нарачај";
            this.btnOrderDessert.UseVisualStyleBackColor = true;
            this.btnOrderDessert.Click += new System.EventHandler(this.btnOrderDessert_Click);
            // 
            // lbDessert
            // 
            this.lbDessert.FormattingEnabled = true;
            this.lbDessert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDessert.Location = new System.Drawing.Point(6, 19);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(120, 95);
            this.lbDessert.TabIndex = 0;
            this.lbDessert.SelectedIndexChanged += new System.EventHandler(this.lbDessert_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт:";
            // 
            // tbDessertPrice
            // 
            this.tbDessertPrice.Location = new System.Drawing.Point(144, 35);
            this.tbDessertPrice.Name = "tbDessertPrice";
            this.tbDessertPrice.Size = new System.Drawing.Size(189, 20);
            this.tbDessertPrice.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizzaman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKetchup;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.TextBox tbExtraCheese;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.TextBox tbHotPeppers;
        private System.Windows.Forms.CheckBox cbHotPeppers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTotalBeer;
        private System.Windows.Forms.TextBox tbBeerPrice;
        private System.Windows.Forms.TextBox tbQtyBeer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalJuice;
        private System.Windows.Forms.TextBox tbJuicePrice;
        private System.Windows.Forms.TextBox tbQtyJuice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalCoke;
        private System.Windows.Forms.TextBox tbCokePrice;
        private System.Windows.Forms.TextBox tbQtyCoke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbLargeSize;
        private System.Windows.Forms.TextBox tbMediumSize;
        private System.Windows.Forms.TextBox tbSmallSize;
        private System.Windows.Forms.RadioButton rbLargeSize;
        private System.Windows.Forms.RadioButton rbMediumSize;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbDessert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalToPay;
        private System.Windows.Forms.TextBox tbTotalToReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotalPaid;
        private System.Windows.Forms.Button btnCancelDessert;
        private System.Windows.Forms.Button btnOrderDessert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDessertPrice;
    }
}

