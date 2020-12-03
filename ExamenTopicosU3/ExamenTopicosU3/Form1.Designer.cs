namespace ExamenTopicosU3
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblCorredores = new MetroFramework.Controls.MetroLabel();
            this.lblVueltas = new MetroFramework.Controls.MetroLabel();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.cmbCorredores = new MetroFramework.Controls.MetroComboBox();
            this.cmbVueltas = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorredores
            // 
            this.lblCorredores.AutoSize = true;
            this.lblCorredores.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCorredores.Location = new System.Drawing.Point(55, 79);
            this.lblCorredores.Name = "lblCorredores";
            this.lblCorredores.Size = new System.Drawing.Size(100, 25);
            this.lblCorredores.TabIndex = 0;
            this.lblCorredores.Text = "Corredores:";
            // 
            // lblVueltas
            // 
            this.lblVueltas.AutoSize = true;
            this.lblVueltas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVueltas.Location = new System.Drawing.Point(55, 123);
            this.lblVueltas.Name = "lblVueltas";
            this.lblVueltas.Size = new System.Drawing.Size(70, 25);
            this.lblVueltas.TabIndex = 1;
            this.lblVueltas.Text = "Vueltas:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngresar.Location = new System.Drawing.Point(157, 181);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 39);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbCorredores
            // 
            this.cmbCorredores.FormattingEnabled = true;
            this.cmbCorredores.ItemHeight = 23;
            this.cmbCorredores.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCorredores.Location = new System.Drawing.Point(194, 75);
            this.cmbCorredores.Name = "cmbCorredores";
            this.cmbCorredores.Size = new System.Drawing.Size(121, 29);
            this.cmbCorredores.TabIndex = 3;
            this.cmbCorredores.UseSelectable = true;
            // 
            // cmbVueltas
            // 
            this.cmbVueltas.FormattingEnabled = true;
            this.cmbVueltas.ItemHeight = 23;
            this.cmbVueltas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbVueltas.Location = new System.Drawing.Point(194, 119);
            this.cmbVueltas.Name = "cmbVueltas";
            this.cmbVueltas.Size = new System.Drawing.Size(121, 29);
            this.cmbVueltas.TabIndex = 4;
            this.cmbVueltas.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.cmbVueltas);
            this.Controls.Add(this.cmbCorredores);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblVueltas);
            this.Controls.Add(this.lblCorredores);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Carrera";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCorredores;
        private MetroFramework.Controls.MetroLabel lblVueltas;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroComboBox cmbCorredores;
        private MetroFramework.Controls.MetroComboBox cmbVueltas;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

