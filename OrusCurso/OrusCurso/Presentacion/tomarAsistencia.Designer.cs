namespace OrusCurso.Presentacion
{
    partial class tomarAsistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tomarAsistencias = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtAviso = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelObservacion = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tomarAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelObservacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 69);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1239, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrusCadence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tomarAsistencias
            // 
            this.tomarAsistencias.Controls.Add(this.pictureBox1);
            this.tomarAsistencias.Controls.Add(this.txtNombre);
            this.tomarAsistencias.Controls.Add(this.txtAviso);
            this.tomarAsistencias.Controls.Add(this.lblHora2);
            this.tomarAsistencias.Controls.Add(this.lblFecha2);
            this.tomarAsistencias.Controls.Add(this.panel3);
            this.tomarAsistencias.Controls.Add(this.txtIdentificacion);
            this.tomarAsistencias.Controls.Add(this.lblHora);
            this.tomarAsistencias.Controls.Add(this.lblFecha);
            this.tomarAsistencias.Controls.Add(this.label3);
            this.tomarAsistencias.Controls.Add(this.label2);
            this.tomarAsistencias.Location = new System.Drawing.Point(149, 75);
            this.tomarAsistencias.Name = "tomarAsistencias";
            this.tomarAsistencias.Size = new System.Drawing.Size(513, 660);
            this.tomarAsistencias.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::OrusCurso.Properties.Resources.Cadence;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Red;
            this.txtNombre.Location = new System.Drawing.Point(7, 524);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(503, 25);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "***********";
            this.txtNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAviso
            // 
            this.txtAviso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAviso.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAviso.ForeColor = System.Drawing.Color.Red;
            this.txtAviso.Location = new System.Drawing.Point(7, 483);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(503, 25);
            this.txtAviso.TabIndex = 9;
            this.txtAviso.Text = "***********";
            this.txtAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora2
            // 
            this.lblHora2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHora2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHora2.Location = new System.Drawing.Point(189, 398);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(102, 25);
            this.lblHora2.TabIndex = 8;
            this.lblHora2.Text = "xx/xx/xx";
            this.lblHora2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha2
            // 
            this.lblFecha2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFecha2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha2.Location = new System.Drawing.Point(189, 346);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(102, 25);
            this.lblFecha2.TabIndex = 7;
            this.lblFecha2.Text = "xx/xx/xx";
            this.lblFecha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(180, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 6;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Location = new System.Drawing.Point(180, 294);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(150, 15);
            this.txtIdentificacion.TabIndex = 5;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(110, 398);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(104, 346);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 25);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "OrusCadence";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelObservacion
            // 
            this.panelObservacion.Controls.Add(this.btnConfirmar);
            this.panelObservacion.Controls.Add(this.txtObservacion);
            this.panelObservacion.Controls.Add(this.label15);
            this.panelObservacion.Location = new System.Drawing.Point(748, 219);
            this.panelObservacion.Name = "panelObservacion";
            this.panelObservacion.Size = new System.Drawing.Size(513, 337);
            this.panelObservacion.TabIndex = 2;
            this.panelObservacion.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(176, 250);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(172, 69);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Iniciar Sesion";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Location = new System.Drawing.Point(7, 57);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(503, 180);
            this.txtObservacion.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(507, 44);
            this.label15.TabIndex = 1;
            this.label15.Text = "OrusCadence";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // tomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1411, 775);
            this.Controls.Add(this.panelObservacion);
            this.Controls.Add(this.tomarAsistencias);
            this.Controls.Add(this.panel1);
            this.Name = "tomarAsistencia";
            this.Text = "tomarAsistencia";
            this.panel1.ResumeLayout(false);
            this.tomarAsistencias.ResumeLayout(false);
            this.tomarAsistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelObservacion.ResumeLayout(false);
            this.panelObservacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel tomarAsistencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtAviso;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelObservacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timerHora;
    }
}