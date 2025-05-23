namespace ExamenT3
{
    partial class FormRegistrosInventarios
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
            this.dgvRegistrosInventarios = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosInventarios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistrosInventarios
            // 
            this.dgvRegistrosInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosInventarios.Location = new System.Drawing.Point(12, 99);
            this.dgvRegistrosInventarios.Name = "dgvRegistrosInventarios";
            this.dgvRegistrosInventarios.RowHeadersWidth = 51;
            this.dgvRegistrosInventarios.RowTemplate.Height = 24;
            this.dgvRegistrosInventarios.Size = new System.Drawing.Size(954, 362);
            this.dgvRegistrosInventarios.TabIndex = 0;
            this.dgvRegistrosInventarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrosInventarios_CellContentClick);
            this.dgvRegistrosInventarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.d_CellMouseClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.btnCerrar.Location = new System.Drawing.Point(1041, 383);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(138, 60);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(1041, 294);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(138, 65);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Dar De Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiosToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 52);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1041, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Imprimir Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormRegistrosInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenT3.Properties.Resources.Imagen_de_WhatsApp_2025_05_23_a_las_15_55_30_9c7fb8b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvRegistrosInventarios);
            this.Name = "FormRegistrosInventarios";
            this.Text = "Registro De Inventarios";
            this.Activated += new System.EventHandler(this.FormRegistrosInventarios_Activated);
            this.Load += new System.EventHandler(this.FormRegistrosInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosInventarios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistrosInventarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}