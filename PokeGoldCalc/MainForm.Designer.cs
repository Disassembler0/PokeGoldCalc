namespace PokeGoldCalc
{
    partial class MainForm
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
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownSlot = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(69, 12);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(150, 21);
            this.comboBoxItem.TabIndex = 0;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.CountItem);
            // 
            // numericUpDownSlot
            // 
            this.numericUpDownSlot.Location = new System.Drawing.Point(157, 39);
            this.numericUpDownSlot.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownSlot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSlot.Name = "numericUpDownSlot";
            this.numericUpDownSlot.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSlot.TabIndex = 1;
            this.numericUpDownSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSlot.ValueChanged += new System.EventHandler(this.CountItem);
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(157, 65);
            this.numericUpDownQty.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownQty.TabIndex = 2;
            this.numericUpDownQty.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.CountItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qty:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 182);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(207, 68);
            this.textBoxResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 262);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.numericUpDownSlot);
            this.Controls.Add(this.comboBoxItem);
            this.Name = "Form1";
            this.Text = "PokeGoldCalc";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.NumericUpDown numericUpDownSlot;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

