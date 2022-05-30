namespace ProyectoPeliculas
{
    partial class UpdatePelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePelicula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdPelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeliculasDisponibles = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lad = new System.Windows.Forms.Label();
            this.DTPAnoLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.labelAgregacion = new System.Windows.Forms.Label();
            this.CbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtIdPelicula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdPelicula
            // 
            this.txtIdPelicula.Location = new System.Drawing.Point(28, 66);
            this.txtIdPelicula.Name = "txtIdPelicula";
            this.txtIdPelicula.Size = new System.Drawing.Size(125, 27);
            this.txtIdPelicula.TabIndex = 2;
            this.txtIdPelicula.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Película";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 592);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 762);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1006, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 582);
            this.panel5.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label13.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(70, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "Director:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label11.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(446, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "Género:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(71, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 29);
            this.label9.TabIndex = 48;
            this.label9.Text = "Precio de Renta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(345, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cantidad de Películas Diponibles:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(446, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "Clasificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(506, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Duración:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(176, 264);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(223, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "_____________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Año de Lanzamiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPeliculasDisponibles
            // 
            this.txtPeliculasDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtPeliculasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeliculasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeliculasDisponibles.Location = new System.Drawing.Point(701, 500);
            this.txtPeliculasDisponibles.Name = "txtPeliculasDisponibles";
            this.txtPeliculasDisponibles.Size = new System.Drawing.Size(237, 23);
            this.txtPeliculasDisponibles.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(697, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 23);
            this.label10.TabIndex = 61;
            this.label10.Text = "_____________________";
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirector.Location = new System.Drawing.Point(180, 335);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(237, 23);
            this.txtDirector.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(176, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 23);
            this.label12.TabIndex = 65;
            this.label12.Text = "_____________________";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuracion.Location = new System.Drawing.Point(659, 411);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(237, 23);
            this.txtDuracion.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(655, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(241, 23);
            this.label16.TabIndex = 71;
            this.label16.Text = "_____________________";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(224, 281);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // lad
            // 
            this.lad.AutoSize = true;
            this.lad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lad.Location = new System.Drawing.Point(211, 285);
            this.lad.Name = "lad";
            this.lad.Size = new System.Drawing.Size(98, 23);
            this.lad.TabIndex = 73;
            this.lad.Text = "________";
            this.lad.Click += new System.EventHandler(this.lad_Click);
            // 
            // DTPAnoLanzamiento
            // 
            this.DTPAnoLanzamiento.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DTPAnoLanzamiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.DTPAnoLanzamiento.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.DTPAnoLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPAnoLanzamiento.Location = new System.Drawing.Point(289, 415);
            this.DTPAnoLanzamiento.Name = "DTPAnoLanzamiento";
            this.DTPAnoLanzamiento.Size = new System.Drawing.Size(250, 27);
            this.DTPAnoLanzamiento.TabIndex = 4;
            this.DTPAnoLanzamiento.ValueChanged += new System.EventHandler(this.DTPAñoLanzamiento_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.CbClasificacion);
            this.panel4.Controls.Add(this.cbGenero);
            this.panel4.Controls.Add(this.chkIsActive);
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Controls.Add(this.lad);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(28, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(959, 393);
            this.panel4.TabIndex = 75;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsActive.Location = new System.Drawing.Point(810, 25);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(98, 33);
            this.chkIsActive.TabIndex = 74;
            this.chkIsActive.Text = "Activo";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // BotonModificar
            // 
            this.BotonModificar.AutoSize = true;
            this.BotonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.BotonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificar.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonModificar.Image = ((System.Drawing.Image)(resources.GetObject("BotonModificar.Image")));
            this.BotonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonModificar.Location = new System.Drawing.Point(655, 641);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(156, 58);
            this.BotonModificar.TabIndex = 8;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelAgregacion
            // 
            this.labelAgregacion.AutoSize = true;
            this.labelAgregacion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAgregacion.Location = new System.Drawing.Point(141, 653);
            this.labelAgregacion.Name = "labelAgregacion";
            this.labelAgregacion.Size = new System.Drawing.Size(0, 31);
            this.labelAgregacion.TabIndex = 77;
            this.labelAgregacion.Click += new System.EventHandler(this.labelAgregacion_Click);
            // 
            // CbClasificacion
            // 
            this.CbClasificacion.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbClasificacion.FormattingEnabled = true;
            this.CbClasificacion.Items.AddRange(new object[] {
            "AA",
            "A",
            "B",
            "C",
            "D"});
            this.CbClasificacion.Location = new System.Drawing.Point(572, 117);
            this.CbClasificacion.Name = "CbClasificacion";
            this.CbClasificacion.Size = new System.Drawing.Size(77, 37);
            this.CbClasificacion.TabIndex = 76;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Accion",
            "Comedia",
            "Drama",
            "Romance",
            "Aventura",
            "Concierto",
            "Misterio",
            "Sustpenso",
            "Ciencia Ficcion",
            "Fantasia",
            "Documental",
            "Musicales",
            "Terror"});
            this.cbGenero.Location = new System.Drawing.Point(515, 51);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(211, 37);
            this.cbGenero.TabIndex = 75;
            // 
            // UpdatePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1016, 772);
            this.Controls.Add(this.labelAgregacion);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.DTPAnoLanzamiento);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPeliculasDisponibles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UpdatePelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtPeliculasDisponibles;
        private Label label10;
        private TextBox txtDirector;
        private Label label12;
        private TextBox txtDuracion;
        private Label label16;
        private TextBox txtPrecio;
        private Label lad;
        private DateTimePicker DTPAnoLanzamiento;
        private Panel panel4;
        private Button BotonModificar;
        private Label labelAgregacion;
        private CheckBox chkIsActive;
        private TextBox txtIdPelicula;
        private ComboBox CbClasificacion;
        private ComboBox cbGenero;
    }
}