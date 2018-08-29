namespace InventoryUI
{
    partial class RemoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveForm));
            this.itemDropDown = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemLabel = new System.Windows.Forms.Label();
            this.restockItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDropDown
            // 
            this.itemDropDown.FormattingEnabled = true;
            this.itemDropDown.Location = new System.Drawing.Point(12, 107);
            this.itemDropDown.Name = "itemDropDown";
            this.itemDropDown.Size = new System.Drawing.Size(206, 38);
            this.itemDropDown.TabIndex = 24;
            // 
            // removeButton
            // 
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeButton.Location = new System.Drawing.Point(12, 151);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(268, 62);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
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
            this.amountUpDown.TabIndex = 22;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.itemLabel.Location = new System.Drawing.Point(7, 78);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(49, 25);
            this.itemLabel.TabIndex = 21;
            this.itemLabel.Text = "Item";
            // 
            // restockItemLabel
            // 
            this.restockItemLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.restockItemLabel.Location = new System.Drawing.Point(12, 9);
            this.restockItemLabel.Name = "restockItemLabel";
            this.restockItemLabel.Size = new System.Drawing.Size(268, 47);
            this.restockItemLabel.TabIndex = 20;
            this.restockItemLabel.Text = "Remove Item";
            this.restockItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 229);
            this.Controls.Add(this.itemDropDown);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.restockItemLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RemoveForm";
            this.Text = "Remove";
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemDropDown;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label restockItemLabel;
    }
}