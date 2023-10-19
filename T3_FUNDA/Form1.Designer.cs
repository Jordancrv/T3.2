namespace T3_FUNDA
{
    partial class Form1
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
            txt_numero = new TextBox();
            btn_registrar = new Button();
            btn_eliminar = new Button();
            btn_ascendente = new Button();
            btn_descendente = new Button();
            dgv_numero = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            btn_mostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_numero).BeginInit();
            SuspendLayout();
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(130, 98);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(125, 27);
            txt_numero.TabIndex = 0;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(145, 141);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(94, 29);
            btn_registrar.TabIndex = 1;
            btn_registrar.Text = "REGISTRAR";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += button1_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(145, 178);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_ascendente
            // 
            btn_ascendente.Location = new Point(145, 213);
            btn_ascendente.Name = "btn_ascendente";
            btn_ascendente.Size = new Size(94, 29);
            btn_ascendente.TabIndex = 3;
            btn_ascendente.Text = "ASCENDENTE";
            btn_ascendente.UseVisualStyleBackColor = true;
            btn_ascendente.Click += btn_ascendente_Click;
            // 
            // btn_descendente
            // 
            btn_descendente.Location = new Point(145, 248);
            btn_descendente.Name = "btn_descendente";
            btn_descendente.Size = new Size(94, 29);
            btn_descendente.TabIndex = 4;
            btn_descendente.Text = "DESCENDENTE";
            btn_descendente.UseVisualStyleBackColor = true;
            btn_descendente.Click += btn_descendente_Click;
            // 
            // dgv_numero
            // 
            dgv_numero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_numero.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgv_numero.Location = new Point(368, 66);
            dgv_numero.Name = "dgv_numero";
            dgv_numero.RowHeadersWidth = 51;
            dgv_numero.RowTemplate.Height = 29;
            dgv_numero.Size = new Size(178, 188);
            dgv_numero.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Numeros";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(145, 283);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(94, 29);
            btn_mostrar.TabIndex = 6;
            btn_mostrar.Text = "MOSTRAR";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_mostrar);
            Controls.Add(dgv_numero);
            Controls.Add(btn_descendente);
            Controls.Add(btn_ascendente);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_registrar);
            Controls.Add(txt_numero);
            Name = "Form1";
            Text = "re";
            ((System.ComponentModel.ISupportInitialize)dgv_numero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_numero;
        private Button btn_registrar;
        private Button btn_eliminar;
        private Button btn_ascendente;
        private Button btn_descendente;
        private DataGridView dgv_numero;
        private DataGridViewTextBoxColumn Column1;
        private Button btn_mostrar;
    }
}