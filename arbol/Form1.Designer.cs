
namespace arbol
{
    partial class Form1
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Button_eliminar = new System.Windows.Forms.Button();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtDatoEliminar = new System.Windows.Forms.TextBox();
            this.txtDatoBuscar = new System.Windows.Forms.TextBox();
            this.Enorden = new System.Windows.Forms.Button();
            this.Preorden = new System.Windows.Forms.Button();
            this.PostOrden = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.m2 = new System.Windows.Forms.Button();
            this.M3 = new System.Windows.Forms.Button();
            this.M5 = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.Mayor = new System.Windows.Forms.Button();
            this.sumatxt = new System.Windows.Forms.TextBox();
            this.m2txt = new System.Windows.Forms.TextBox();
            this.m3txt = new System.Windows.Forms.TextBox();
            this.m5txt = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.Button();
            this.alturaxtx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(56, 26);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // Button_eliminar
            // 
            this.Button_eliminar.Location = new System.Drawing.Point(56, 79);
            this.Button_eliminar.Name = "Button_eliminar";
            this.Button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.Button_eliminar.TabIndex = 1;
            this.Button_eliminar.Text = "Eliminar";
            this.Button_eliminar.UseVisualStyleBackColor = true;
            this.Button_eliminar.Click += new System.EventHandler(this.Button_eliminar_Click);
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Location = new System.Drawing.Point(56, 138);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Button_Buscar.TabIndex = 2;
            this.Button_Buscar.Text = "Buscar";
            this.Button_Buscar.UseVisualStyleBackColor = true;
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(165, 26);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 3;
            // 
            // txtDatoEliminar
            // 
            this.txtDatoEliminar.Location = new System.Drawing.Point(165, 79);
            this.txtDatoEliminar.Name = "txtDatoEliminar";
            this.txtDatoEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtDatoEliminar.TabIndex = 4;
            // 
            // txtDatoBuscar
            // 
            this.txtDatoBuscar.Location = new System.Drawing.Point(165, 138);
            this.txtDatoBuscar.Name = "txtDatoBuscar";
            this.txtDatoBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtDatoBuscar.TabIndex = 5;
            // 
            // Enorden
            // 
            this.Enorden.Location = new System.Drawing.Point(26, 176);
            this.Enorden.Name = "Enorden";
            this.Enorden.Size = new System.Drawing.Size(75, 23);
            this.Enorden.TabIndex = 6;
            this.Enorden.Text = "En orden";
            this.Enorden.UseVisualStyleBackColor = true;
            this.Enorden.Click += new System.EventHandler(this.Enorden_Click);
            // 
            // Preorden
            // 
            this.Preorden.Location = new System.Drawing.Point(123, 176);
            this.Preorden.Name = "Preorden";
            this.Preorden.Size = new System.Drawing.Size(75, 23);
            this.Preorden.TabIndex = 7;
            this.Preorden.Text = "Pre orden";
            this.Preorden.UseVisualStyleBackColor = true;
            this.Preorden.Click += new System.EventHandler(this.Preorden_Click);
            // 
            // PostOrden
            // 
            this.PostOrden.Location = new System.Drawing.Point(218, 176);
            this.PostOrden.Name = "PostOrden";
            this.PostOrden.Size = new System.Drawing.Size(75, 23);
            this.PostOrden.TabIndex = 8;
            this.PostOrden.Text = "Post orden";
            this.PostOrden.UseVisualStyleBackColor = true;
            this.PostOrden.Click += new System.EventHandler(this.PostOrden_Click);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(54, 212);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 9;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(54, 255);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(75, 23);
            this.m2.TabIndex = 10;
            this.m2.Text = "Multiplos 2";
            this.m2.UseVisualStyleBackColor = true;
            this.m2.Click += new System.EventHandler(this.m2_Click);
            // 
            // M3
            // 
            this.M3.Location = new System.Drawing.Point(54, 296);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(75, 23);
            this.M3.TabIndex = 11;
            this.M3.Text = "Multiplos 3";
            this.M3.UseVisualStyleBackColor = true;
            this.M3.Click += new System.EventHandler(this.M3_Click);
            // 
            // M5
            // 
            this.M5.Location = new System.Drawing.Point(54, 336);
            this.M5.Name = "M5";
            this.M5.Size = new System.Drawing.Size(75, 23);
            this.M5.TabIndex = 12;
            this.M5.Text = "Multiplos 5";
            this.M5.UseVisualStyleBackColor = true;
            this.M5.Click += new System.EventHandler(this.M5_Click);
            // 
            // Menor
            // 
            this.Menor.Location = new System.Drawing.Point(73, 372);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(75, 23);
            this.Menor.TabIndex = 13;
            this.Menor.Text = "Menor";
            this.Menor.UseVisualStyleBackColor = true;
            this.Menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // Mayor
            // 
            this.Mayor.Location = new System.Drawing.Point(163, 372);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(75, 23);
            this.Mayor.TabIndex = 14;
            this.Mayor.Text = "Mayor";
            this.Mayor.UseVisualStyleBackColor = true;
            this.Mayor.Click += new System.EventHandler(this.Mayor_Click);
            // 
            // sumatxt
            // 
            this.sumatxt.Location = new System.Drawing.Point(163, 212);
            this.sumatxt.Name = "sumatxt";
            this.sumatxt.ReadOnly = true;
            this.sumatxt.Size = new System.Drawing.Size(100, 20);
            this.sumatxt.TabIndex = 15;
            // 
            // m2txt
            // 
            this.m2txt.Location = new System.Drawing.Point(163, 255);
            this.m2txt.Name = "m2txt";
            this.m2txt.ReadOnly = true;
            this.m2txt.Size = new System.Drawing.Size(100, 20);
            this.m2txt.TabIndex = 16;
            // 
            // m3txt
            // 
            this.m3txt.Location = new System.Drawing.Point(163, 296);
            this.m3txt.Name = "m3txt";
            this.m3txt.ReadOnly = true;
            this.m3txt.Size = new System.Drawing.Size(100, 20);
            this.m3txt.TabIndex = 17;
            // 
            // m5txt
            // 
            this.m5txt.Location = new System.Drawing.Point(163, 336);
            this.m5txt.Name = "m5txt";
            this.m5txt.ReadOnly = true;
            this.m5txt.Size = new System.Drawing.Size(100, 20);
            this.m5txt.TabIndex = 18;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(54, 415);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(75, 23);
            this.Altura.TabIndex = 19;
            this.Altura.Text = "Altura";
            this.Altura.UseVisualStyleBackColor = true;
            this.Altura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // alturaxtx
            // 
            this.alturaxtx.Location = new System.Drawing.Point(163, 417);
            this.alturaxtx.Name = "alturaxtx";
            this.alturaxtx.ReadOnly = true;
            this.alturaxtx.Size = new System.Drawing.Size(100, 20);
            this.alturaxtx.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alturaxtx);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.m5txt);
            this.Controls.Add(this.m3txt);
            this.Controls.Add(this.m2txt);
            this.Controls.Add(this.sumatxt);
            this.Controls.Add(this.Mayor);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.M5);
            this.Controls.Add(this.M3);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.PostOrden);
            this.Controls.Add(this.Preorden);
            this.Controls.Add(this.Enorden);
            this.Controls.Add(this.txtDatoBuscar);
            this.Controls.Add(this.txtDatoEliminar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.Button_Buscar);
            this.Controls.Add(this.Button_eliminar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button Button_eliminar;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtDatoEliminar;
        private System.Windows.Forms.TextBox txtDatoBuscar;
        private System.Windows.Forms.Button Enorden;
        private System.Windows.Forms.Button Preorden;
        private System.Windows.Forms.Button PostOrden;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button m2;
        private System.Windows.Forms.Button M3;
        private System.Windows.Forms.Button M5;
        private System.Windows.Forms.Button Menor;
        private System.Windows.Forms.Button Mayor;
        private System.Windows.Forms.TextBox sumatxt;
        private System.Windows.Forms.TextBox m2txt;
        private System.Windows.Forms.TextBox m3txt;
        private System.Windows.Forms.TextBox m5txt;
        private System.Windows.Forms.Button Altura;
        private System.Windows.Forms.TextBox alturaxtx;
    }
}

