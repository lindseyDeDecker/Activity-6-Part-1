namespace CST_150_ListTogv
{
    partial class FrmInventory
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
            gvInv = new DataGridView();
            ntmIncQty = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(167, 104);
            gvInv.Name = "gvInv";
            gvInv.RowTemplate.Height = 25;
            gvInv.Size = new Size(539, 334);
            gvInv.TabIndex = 0;
            gvInv.Click += GridView_ClickEventHandler;
            // 
            // ntmIncQty
            // 
            ntmIncQty.Location = new Point(167, 53);
            ntmIncQty.Name = "ntmIncQty";
            ntmIncQty.Size = new Size(75, 23);
            ntmIncQty.TabIndex = 1;
            ntmIncQty.Text = "IncQty";
            ntmIncQty.UseVisualStyleBackColor = true;
            ntmIncQty.Click += BtnIncQty_clickEventHandler;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ntmIncQty);
            Controls.Add(gvInv);
            Name = "FrmInventory";
            Text = "Inventory";
            Load += PopulateGrid_LoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvInv;
        private Button ntmIncQty;
    }
}
