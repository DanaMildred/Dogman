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
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 664);
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

        #endregion

        private DataGridView dGVPersonaje;
        private PictureBox pBPersonajes;
        private ComboBox cBpersonaje;
        private Label LSeleccionarPersonaje;
    }
}
