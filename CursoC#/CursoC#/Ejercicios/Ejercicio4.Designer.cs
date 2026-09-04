namespace CursoC_.Ejercicios
{
    partial class Ejercicio4
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTallaL = new System.Windows.Forms.RadioButton();
            this.rbTallaM = new System.Windows.Forms.RadioButton();
            this.rbTallaS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbColorBlanco = new System.Windows.Forms.RadioButton();
            this.rbColorRojo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1336, 35);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Ejercicio 4";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoC_.Properties.Resources.Ejercicio4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1336, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1336, 35);
            this.label2.TabIndex = 22;
            this.label2.Text = "Solucion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Casacas";
            // 
            // rbTallaL
            // 
            this.rbTallaL.AutoSize = true;
            this.rbTallaL.Location = new System.Drawing.Point(6, 30);
            this.rbTallaL.Name = "rbTallaL";
            this.rbTallaL.Size = new System.Drawing.Size(130, 27);
            this.rbTallaL.TabIndex = 0;
            this.rbTallaL.TabStop = true;
            this.rbTallaL.Text = "L ($ 100)";
            this.rbTallaL.UseVisualStyleBackColor = true;
            this.rbTallaL.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbTallaM
            // 
            this.rbTallaM.AutoSize = true;
            this.rbTallaM.Location = new System.Drawing.Point(6, 63);
            this.rbTallaM.Name = "rbTallaM";
            this.rbTallaM.Size = new System.Drawing.Size(130, 27);
            this.rbTallaM.TabIndex = 1;
            this.rbTallaM.TabStop = true;
            this.rbTallaM.Text = "M ($ 200)";
            this.rbTallaM.UseVisualStyleBackColor = true;
            // 
            // rbTallaS
            // 
            this.rbTallaS.AutoSize = true;
            this.rbTallaS.Location = new System.Drawing.Point(6, 96);
            this.rbTallaS.Name = "rbTallaS";
            this.rbTallaS.Size = new System.Drawing.Size(130, 27);
            this.rbTallaS.TabIndex = 2;
            this.rbTallaS.TabStop = true;
            this.rbTallaS.Text = "S ($ 300)";
            this.rbTallaS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTallaS);
            this.groupBox1.Controls.Add(this.rbTallaM);
            this.groupBox1.Controls.Add(this.rbTallaL);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 134);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // rbColorBlanco
            // 
            this.rbColorBlanco.AutoSize = true;
            this.rbColorBlanco.Location = new System.Drawing.Point(6, 30);
            this.rbColorBlanco.Name = "rbColorBlanco";
            this.rbColorBlanco.Size = new System.Drawing.Size(97, 27);
            this.rbColorBlanco.TabIndex = 0;
            this.rbColorBlanco.TabStop = true;
            this.rbColorBlanco.Text = "Blanco";
            this.rbColorBlanco.UseVisualStyleBackColor = true;
            // 
            // rbColorRojo
            // 
            this.rbColorRojo.AutoSize = true;
            this.rbColorRojo.Location = new System.Drawing.Point(6, 63);
            this.rbColorRojo.Name = "rbColorRojo";
            this.rbColorRojo.Size = new System.Drawing.Size(75, 27);
            this.rbColorRojo.TabIndex = 1;
            this.rbColorRojo.TabStop = true;
            this.rbColorRojo.Text = "Rojo";
            this.rbColorRojo.UseVisualStyleBackColor = true;
            this.rbColorRojo.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbColorRojo);
            this.groupBox2.Controls.Add(this.rbColorBlanco);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(931, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 134);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(619, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 59);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.Lime;
            this.txtDetalle.Location = new System.Drawing.Point(384, 432);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(606, 131);
            this.txtDetalle.TabIndex = 21;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ejercicio4";
            this.Size = new System.Drawing.Size(1336, 571);
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTallaL;
        private System.Windows.Forms.RadioButton rbTallaM;
        private System.Windows.Forms.RadioButton rbTallaS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbColorBlanco;
        private System.Windows.Forms.RadioButton rbColorRojo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}
