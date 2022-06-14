namespace ColorCheckDemo
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sdaColor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dsColor1 = new ColorCheckDemo.dsColor();
            this.flpColor = new System.Windows.Forms.FlowLayoutPanel();
            this.dbgProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT DISTINCT ISNULL(Color, \'[No Color]\') AS \'Color\'\r\nFROM         Production.P" +
                "roduct";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sdaColor
            // 
            this.sdaColor.SelectCommand = this.sqlSelectCommand1;
            this.sdaColor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Color", "Color")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=AdventureWorks;Persist Security Info=True;User ID=s" +
                "a;Password=sql";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsColor1
            // 
            this.dsColor1.DataSetName = "dsColor";
            this.dsColor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flpColor
            // 
            this.flpColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpColor.Location = new System.Drawing.Point(0, 0);
            this.flpColor.Name = "flpColor";
            this.flpColor.Size = new System.Drawing.Size(445, 104);
            this.flpColor.TabIndex = 0;
            // 
            // dbgProduct
            // 
            this.dbgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgProduct.Location = new System.Drawing.Point(0, 104);
            this.dbgProduct.Name = "dbgProduct";
            this.dbgProduct.Size = new System.Drawing.Size(445, 316);
            this.dbgProduct.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 420);
            this.Controls.Add(this.dbgProduct);
            this.Controls.Add(this.flpColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sdaColor;
        private dsColor dsColor1;
        private System.Windows.Forms.FlowLayoutPanel flpColor;
        private System.Windows.Forms.DataGridView dbgProduct;
    }
}

