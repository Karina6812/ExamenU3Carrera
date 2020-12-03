namespace ExamenTopicosU3
{
    partial class FrmCarrera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrera));
            this.pctTierra = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblVueltas = new MetroFramework.Controls.MetroLabel();
            this.lblCorredores = new MetroFramework.Controls.MetroLabel();
            this.lblNumCorr = new MetroFramework.Controls.MetroLabel();
            this.lblNumVueltas = new MetroFramework.Controls.MetroLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblReloj = new MetroFramework.Controls.MetroLabel();
            this.lblTimer1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgHora = new System.ComponentModel.BackgroundWorker();
            this.pctSanta3 = new System.Windows.Forms.PictureBox();
            this.pctSanta2 = new System.Windows.Forms.PictureBox();
            this.pctSanta1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTierra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctTierra
            // 
            this.pctTierra.Image = ((System.Drawing.Image)(resources.GetObject("pctTierra.Image")));
            this.pctTierra.Location = new System.Drawing.Point(201, 41);
            this.pctTierra.Name = "pctTierra";
            this.pctTierra.Size = new System.Drawing.Size(576, 434);
            this.pctTierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTierra.TabIndex = 0;
            this.pctTierra.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Green;
            this.btnIniciar.Location = new System.Drawing.Point(23, 172);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(76, 33);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblVueltas
            // 
            this.lblVueltas.AutoSize = true;
            this.lblVueltas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVueltas.Location = new System.Drawing.Point(23, 117);
            this.lblVueltas.Name = "lblVueltas";
            this.lblVueltas.Size = new System.Drawing.Size(70, 25);
            this.lblVueltas.TabIndex = 6;
            this.lblVueltas.Text = "Vueltas:";
            // 
            // lblCorredores
            // 
            this.lblCorredores.AutoSize = true;
            this.lblCorredores.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCorredores.Location = new System.Drawing.Point(23, 73);
            this.lblCorredores.Name = "lblCorredores";
            this.lblCorredores.Size = new System.Drawing.Size(100, 25);
            this.lblCorredores.TabIndex = 5;
            this.lblCorredores.Text = "Corredores:";
            // 
            // lblNumCorr
            // 
            this.lblNumCorr.AutoSize = true;
            this.lblNumCorr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumCorr.Location = new System.Drawing.Point(129, 73);
            this.lblNumCorr.Name = "lblNumCorr";
            this.lblNumCorr.Size = new System.Drawing.Size(21, 25);
            this.lblNumCorr.TabIndex = 7;
            this.lblNumCorr.Text = "0";
            // 
            // lblNumVueltas
            // 
            this.lblNumVueltas.AutoSize = true;
            this.lblNumVueltas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumVueltas.Location = new System.Drawing.Point(129, 117);
            this.lblNumVueltas.Name = "lblNumVueltas";
            this.lblNumVueltas.Size = new System.Drawing.Size(21, 25);
            this.lblNumVueltas.TabIndex = 8;
            this.lblNumVueltas.Text = "0";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Green;
            this.btnVolver.Location = new System.Drawing.Point(23, 229);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 33);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblReloj.Location = new System.Drawing.Point(23, 305);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(49, 25);
            this.lblReloj.TabIndex = 10;
            this.lblReloj.Text = "Reloj";
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.lblTimer1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer1.Location = new System.Drawing.Point(23, 355);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(55, 25);
            this.lblTimer1.TabIndex = 11;
            this.lblTimer1.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.FrmCarrera_SizeChanged);
            // 
            // bgHora
            // 
            this.bgHora.WorkerSupportsCancellation = true;
            this.bgHora.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHora_DoWork_1);
            // 
            // pctSanta3
            // 
            this.pctSanta3.Image = ((System.Drawing.Image)(resources.GetObject("pctSanta3.Image")));
            this.pctSanta3.Location = new System.Drawing.Point(219, 196);
            this.pctSanta3.Name = "pctSanta3";
            this.pctSanta3.Size = new System.Drawing.Size(49, 50);
            this.pctSanta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSanta3.TabIndex = 4;
            this.pctSanta3.TabStop = false;
            // 
            // pctSanta2
            // 
            this.pctSanta2.Image = ((System.Drawing.Image)(resources.GetObject("pctSanta2.Image")));
            this.pctSanta2.Location = new System.Drawing.Point(219, 129);
            this.pctSanta2.Name = "pctSanta2";
            this.pctSanta2.Size = new System.Drawing.Size(49, 50);
            this.pctSanta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSanta2.TabIndex = 3;
            this.pctSanta2.TabStop = false;
            // 
            // pctSanta1
            // 
            this.pctSanta1.Image = ((System.Drawing.Image)(resources.GetObject("pctSanta1.Image")));
            this.pctSanta1.Location = new System.Drawing.Point(219, 63);
            this.pctSanta1.Name = "pctSanta1";
            this.pctSanta1.Size = new System.Drawing.Size(49, 50);
            this.pctSanta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSanta1.TabIndex = 2;
            this.pctSanta1.TabStop = false;
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctSanta3);
            this.Controls.Add(this.pctSanta2);
            this.Controls.Add(this.pctSanta1);
            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNumVueltas);
            this.Controls.Add(this.lblNumCorr);
            this.Controls.Add(this.lblVueltas);
            this.Controls.Add(this.lblCorredores);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pctTierra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarrera";
            this.Text = "Carrera";
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTierra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTierra;
        private System.Windows.Forms.Button btnIniciar;
        private MetroFramework.Controls.MetroLabel lblVueltas;
        private MetroFramework.Controls.MetroLabel lblCorredores;
        private MetroFramework.Controls.MetroLabel lblNumCorr;
        private MetroFramework.Controls.MetroLabel lblNumVueltas;
        private System.Windows.Forms.Button btnVolver;
        private MetroFramework.Controls.MetroLabel lblReloj;
        private MetroFramework.Controls.MetroLabel lblTimer1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bgHora;
        private System.Windows.Forms.PictureBox pctSanta3;
        private System.Windows.Forms.PictureBox pctSanta2;
        private System.Windows.Forms.PictureBox pctSanta1;
    }
}