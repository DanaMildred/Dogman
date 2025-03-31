
namespace Dogman
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dGVPersonaje = new DataGridView();
            pBPersonajes = new PictureBox();
            cBpersonaje = new ComboBox();
            LSeleccionarPersonaje = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TBIdPersonaje = new TextBox();
            TBNombre = new TextBox();
            TBTipo = new TextBox();
            TBHabilidad = new TextBox();
            BAgregar = new Button();
            BActualizar = new Button();
            BEliminar = new Button();
            BMostrar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            TBEliminar = new TextBox();
            TBURL = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGVPersonaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBPersonajes).BeginInit();
            SuspendLayout();
            // 
            // dGVPersonaje
            // 
            dGVPersonaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPersonaje.Location = new Point(102, 12);
            dGVPersonaje.Name = "dGVPersonaje";
            dGVPersonaje.RowHeadersWidth = 51;
            dGVPersonaje.Size = new Size(874, 240);
            dGVPersonaje.TabIndex = 0;
            // 
            // pBPersonajes
            // 
            pBPersonajes.Location = new Point(102, 269);
            pBPersonajes.Name = "pBPersonajes";
            pBPersonajes.Size = new Size(283, 306);
            pBPersonajes.SizeMode = PictureBoxSizeMode.StretchImage;
            pBPersonajes.TabIndex = 1;
            pBPersonajes.TabStop = false;
            // 
            // cBpersonaje
            // 
            cBpersonaje.FormattingEnabled = true;
            cBpersonaje.Location = new Point(409, 449);
            cBpersonaje.Name = "cBpersonaje";
            cBpersonaje.Size = new Size(151, 28);
            cBpersonaje.TabIndex = 2;
            cBpersonaje.SelectedIndexChanged += cBpersonaje_SelectedIndexChanged;
            // 
            // LSeleccionarPersonaje
            // 
            LSeleccionarPersonaje.AutoSize = true;
            LSeleccionarPersonaje.Location = new Point(405, 417);
            LSeleccionarPersonaje.Name = "LSeleccionarPersonaje";
            LSeleccionarPersonaje.Size = new Size(155, 20);
            LSeleccionarPersonaje.TabIndex = 3;
            LSeleccionarPersonaje.Text = "Seleccionar Personaje:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 271);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Id_Personaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 315);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(674, 361);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 406);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 7;
            label4.Text = "Habilidad_Especial";
            // 
            // TBIdPersonaje
            // 
            TBIdPersonaje.Location = new Point(851, 271);
            TBIdPersonaje.Name = "TBIdPersonaje";
            TBIdPersonaje.Size = new Size(125, 27);
            TBIdPersonaje.TabIndex = 8;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(851, 315);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(125, 27);
            TBNombre.TabIndex = 9;
            // 
            // TBTipo
            // 
            TBTipo.Location = new Point(851, 361);
            TBTipo.Name = "TBTipo";
            TBTipo.Size = new Size(125, 27);
            TBTipo.TabIndex = 10;
            // 
            // TBHabilidad
            // 
            TBHabilidad.Location = new Point(851, 403);
            TBHabilidad.Name = "TBHabilidad";
            TBHabilidad.Size = new Size(125, 27);
            TBHabilidad.TabIndex = 11;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(743, 510);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(94, 29);
            BAgregar.TabIndex = 12;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(859, 510);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(94, 29);
            BActualizar.TabIndex = 13;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click_1;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(756, 605);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(94, 29);
            BEliminar.TabIndex = 14;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BMostrar
            // 
            BMostrar.Location = new Point(487, 269);
            BMostrar.Name = "BMostrar";
            BMostrar.Size = new Size(94, 29);
            BMostrar.TabIndex = 15;
            BMostrar.Text = "Mostrar";
            BMostrar.UseVisualStyleBackColor = true;
            BMostrar.Click += BMostrar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 572);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 16;
            label5.Text = "Id_Personaje";
            // 
            // TBEliminar
            // 
            TBEliminar.Location = new Point(743, 572);
            TBEliminar.Name = "TBEliminar";
            TBEliminar.Size = new Size(125, 27);
            TBEliminar.TabIndex = 17;
            // 
            // TBURL
            // 
            TBURL.Location = new Point(851, 452);
            TBURL.Name = "TBURL";
            TBURL.Size = new Size(125, 27);
            TBURL.TabIndex = 19;
            TBURL.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 452);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 18;
            label6.Text = "Url_Imagen";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 664);
            Controls.Add(TBURL);
            Controls.Add(label6);
            Controls.Add(TBEliminar);
            Controls.Add(label5);
            Controls.Add(BMostrar);
            Controls.Add(BEliminar);
            Controls.Add(BActualizar);
            Controls.Add(BAgregar);
            Controls.Add(TBHabilidad);
            Controls.Add(TBTipo);
            Controls.Add(TBNombre);
            Controls.Add(TBIdPersonaje);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LSeleccionarPersonaje);
            Controls.Add(cBpersonaje);
            Controls.Add(pBPersonajes);
            Controls.Add(dGVPersonaje);
            Name = "frmInicio";
            Text = "Dogman";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dGVPersonaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBPersonajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void BActualizar_Click(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private DataGridView dGVPersonaje;
        private PictureBox pBPersonajes;
        private ComboBox cBpersonaje;
        private Label LSeleccionarPersonaje;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TBIdPersonaje;
        private TextBox TBNombre;
        private TextBox TBTipo;
        private TextBox TBHabilidad;
        private Button BAgregar;
        private Button BActualizar;
        private Button BEliminar;
        private Button BMostrar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private TextBox TBEliminar;
        private TextBox TBURL;
        private Label label6;
    }
}
