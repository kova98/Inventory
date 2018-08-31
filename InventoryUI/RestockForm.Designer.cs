namespace InventoryUI
{
    partial class RestockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockForm));
            this.restockItemLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.restockButton = new System.Windows.Forms.Button();
            this.itemDropDown = new System.Windows.Forms.ComboBox();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // restockItemLabel
            // 
            this.restockItemLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.restockItemLabel.Location = new System.Drawing.Point(12, 9);
            this.restockItemLabel.Name = "restockItemLabel";
            this.restockItemLabel.Size = new System.Drawing.Size(268, 47);
            this.restockItemLabel.TabIndex = 2;
            this.restockItemLabel.Text = "Restock Item";
            this.restockItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.itemLabel.Location = new System.Drawing.Point(7, 78);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(49, 25);
            this.itemLabel.TabIndex = 12;
            this.itemLabel.Text = "Item";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountUpDown.Location = new System.Drawing.Point(224, 107);
            this.amountUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.amountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(56, 38);
            this.amountUpDown.TabIndex = 14;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // restockButton
            // 
            this.restockButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.restockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.restockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.restockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.restockButton.Location = new System.Drawing.Point(12, 151);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(268, 62);
            this.restockButton.TabIndex = 18;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // itemDropDown
            // 
            this.itemDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemDropDown.FormattingEnabled = true;
            this.itemDropDown.Location = new System.Drawing.Point(12, 107);
            this.itemDropDown.Name = "itemDropDown";
            this.itemDropDown.Size = new System.Drawing.Size(154, 38);
            this.itemDropDown.TabIndex = 19;
            this.itemDropDown.SelectedIndexChanged += new System.EventHandler(this.itemDropDown_SelectedIndexChanged);
            // 
            // itemAmountLabel
            // 
            this.itemAmountLabel.AutoSize = true;
            this.itemAmountLabel.Location = new System.Drawing.Point(172, 110);
            this.itemAmountLabel.Name = "itemAmountLabel";
            this.itemAmountLabel.Size = new System.Drawing.Size(46, 30);
            this.itemAmountLabel.TabIndex = 26;
            this.itemAmountLabel.Text = "999";
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 226);
            this.Controls.Add(this.itemAmountLabel);
            this.Controls.Add(this.itemDropDown);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.restockItemLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RestockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restock";
            this.Load += new System.EventHandler(this.RestockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restockItemLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.ComboBox itemDropDown;
        private System.Windows.Forms.Label itemAmountLabel;
    }
}