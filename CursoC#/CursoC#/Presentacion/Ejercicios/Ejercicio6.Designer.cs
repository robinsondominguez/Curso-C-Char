namespace CursoC_.Ejercicios
{
    partial class Ejercicio6
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
            this.lblEjercicio6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.PanelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPorcen = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEjercicio6
            // 
            this.lblEjercicio6.BackColor = System.Drawing.Color.Black;
            this.lblEjercicio6.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEjercicio6.ForeColor = System.Drawing.Color.White;
            this.lblEjercicio6.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio6.Name = "lblEjercicio6";
            this.lblEjercicio6.Size = new System.Drawing.Size(137, 623);
            this.lblEjercicio6.TabIndex = 0;
            this.lblEjercicio6.Text = "Ejercicio 6";
            this.lblEjercicio6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CursoC_.Properties.Resources.celular1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblNum1);
            this.panel1.Controls.Add(this.lblOperacion);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.txtPantalla);
            this.panel1.Controls.Add(this.PanelNumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(143, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 630);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNum1
            // 
            this.lblNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNum1.Location = new System.Drawing.Point(501, 161);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(69, 22);
            this.lblNum1.TabIndex = 6;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNum1.Visible = false;
            // 
            // lblOperacion
            // 
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOperacion.Location = new System.Drawing.Point(501, 193);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(69, 22);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOperacion.Visible = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = global::CursoC_.Properties.Resources.Icono_Copiar;
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.Location = new System.Drawing.Point(311, 225);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(52, 46);
            this.btnCopiar.TabIndex = 4;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.txtPantalla.ForeColor = System.Drawing.Color.White;
            this.txtPantalla.Location = new System.Drawing.Point(369, 224);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(201, 46);
            this.txtPantalla.TabIndex = 3;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PanelNumerico
            // 
            this.PanelNumerico.Location = new System.Drawing.Point(308, 337);
            this.PanelNumerico.Name = "PanelNumerico";
            this.PanelNumerico.Size = new System.Drawing.Size(201, 223);
            this.PanelNumerico.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDiv);
            this.flowLayoutPanel2.Controls.Add(this.btnMult);
            this.flowLayoutPanel2.Controls.Add(this.btnResta);
            this.flowLayoutPanel2.Controls.Add(this.btnSuma);
            this.flowLayoutPanel2.Controls.Add(this.btnIgual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(515, 277);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(55, 283);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnDiv
            // 
            this.btnDiv.BackgroundImage = global::CursoC_.Properties.Resources.botonNaranja;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Location = new System.Drawing.Point(3, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(45, 50);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackgroundImage = global::CursoC_.Properties.Resources.botonNaranja;
            this.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Location = new System.Drawing.Point(3, 59);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 50);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackgroundImage = global::CursoC_.Properties.Resources.botonNaranja;
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.FlatAppearance.BorderSize = 0;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Location = new System.Drawing.Point(3, 115);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(45, 50);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackgroundImage = global::CursoC_.Properties.Resources.botonNaranja;
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Location = new System.Drawing.Point(3, 171);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(45, 50);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackgroundImage = global::CursoC_.Properties.Resources.botonNaranja;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Location = new System.Drawing.Point(3, 227);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(45, 50);
            this.btnIgual.TabIndex = 7;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnPorcen);
            this.flowLayoutPanel1.Controls.Add(this.btnOff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(308, 277);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::CursoC_.Properties.Resources.botonGris;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(3, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(52, 50);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "AC";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPorcen
            // 
            this.btnPorcen.BackgroundImage = global::CursoC_.Properties.Resources.botonGris;
            this.btnPorcen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorcen.FlatAppearance.BorderSize = 0;
            this.btnPorcen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcen.Location = new System.Drawing.Point(61, 3);
            this.btnPorcen.Name = "btnPorcen";
            this.btnPorcen.Size = new System.Drawing.Size(52, 50);
            this.btnPorcen.TabIndex = 1;
            this.btnPorcen.Text = "%";
            this.btnPorcen.UseVisualStyleBackColor = true;
            this.btnPorcen.Click += new System.EventHandler(this.btnPorcen_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackgroundImage = global::CursoC_.Properties.Resources.botonGris;
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(119, 3);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(52, 50);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEjercicio6);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio6";
            this.Size = new System.Drawing.Size(1324, 623);
            this.Load += new System.EventHandler(this.Ejercicio6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PanelNumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPorcen;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperacion;
    }
}
