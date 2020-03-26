namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(105, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // izq
            // 
            this.izq.BackColor = System.Drawing.Color.Transparent;
            this.izq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.izq.ForeColor = System.Drawing.Color.Transparent;
            this.izq.Location = new System.Drawing.Point(385, 627);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(75, 79);
            this.izq.TabIndex = 1;
            this.izq.UseVisualStyleBackColor = false;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.BackColor = System.Drawing.Color.Transparent;
            this.der.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.der.ForeColor = System.Drawing.Color.Transparent;
            this.der.Location = new System.Drawing.Point(478, 627);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(75, 79);
            this.der.TabIndex = 2;
            this.der.UseVisualStyleBackColor = false;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nombrePokemon.Location = new System.Drawing.Point(735, 207);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(214, 65);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokedexC_sharp.Properties.Resources.pokedex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 828);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombrePokemon;
    }
}

