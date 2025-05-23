namespace ExamenT3
{
    partial class FormAltas
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
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labPrecio = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.txtBCategoria = new System.Windows.Forms.TextBox();
            this.rTBDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBNombre
            // 
            this.txtBNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtBNombre.Location = new System.Drawing.Point(317, 139);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(241, 31);
            this.txtBNombre.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre del Artículo:";
            // 
            // txtBCantidad
            // 
            this.txtBCantidad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCantidad.Location = new System.Drawing.Point(17, 212);
            this.txtBCantidad.Name = "txtBCantidad";
            this.txtBCantidad.Size = new System.Drawing.Size(241, 31);
            this.txtBCantidad.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Precio Unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categoria ";
            // 
            // labPrecio
            // 
            this.labPrecio.AutoSize = true;
            this.labPrecio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrecio.Location = new System.Drawing.Point(12, 173);
            this.labPrecio.Name = "labPrecio";
            this.labPrecio.Size = new System.Drawing.Size(178, 25);
            this.labPrecio.TabIndex = 15;
            this.labPrecio.Text = "Cantidad Disponible:";
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(17, 138);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(241, 31);
            this.txtBID.TabIndex = 14;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.labID.Location = new System.Drawing.Point(12, 91);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(168, 25);
            this.labID.TabIndex = 13;
            this.labID.Text = "Código del Artículo:";
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(662, 343);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(152, 38);
            this.btnAlta.TabIndex = 25;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(662, 413);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 39);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBPrecio.Location = new System.Drawing.Point(17, 293);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(241, 31);
            this.txtBPrecio.TabIndex = 27;
            // 
            // txtBCategoria
            // 
            this.txtBCategoria.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCategoria.Location = new System.Drawing.Point(314, 212);
            this.txtBCategoria.Name = "txtBCategoria";
            this.txtBCategoria.Size = new System.Drawing.Size(244, 31);
            this.txtBCategoria.TabIndex = 28;
            // 
            // rTBDescripcion
            // 
            this.rTBDescripcion.Location = new System.Drawing.Point(17, 356);
            this.rTBDescripcion.Name = "rTBDescripcion";
            this.rTBDescripcion.Size = new System.Drawing.Size(564, 96);
            this.rTBDescripcion.TabIndex = 19;
            this.rTBDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descripcion Del Artículo: ";
            // 
            // FormAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenT3.Properties.Resources.Imagen_de_WhatsApp_2025_05_23_a_las_16_06_49_b6a8d999;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 468);
            this.Controls.Add(this.txtBCategoria);
            this.Controls.Add(this.txtBPrecio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBCantidad);
            this.Controls.Add(this.rTBDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labPrecio);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.labID);
            this.Name = "FormAltas";
            this.Text = "Alta De Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPrecio;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.TextBox txtBCategoria;
        private System.Windows.Forms.RichTextBox rTBDescripcion;
        private System.Windows.Forms.Label label3;
    }
}