namespace MyApplication
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
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(142, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(218, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(218, 165);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 27);
            txtTelefono.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 172);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(218, 216);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(213, 27);
            txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 223);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(218, 269);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(213, 27);
            txtEdad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 276);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Edad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(218, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 27);
            txtApellido.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 130);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Apellido";
            // 
            // txtId
            // 
            txtId.Location = new Point(560, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(189, 27);
            txtId.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(559, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(190, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 456);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtId;
        private Button btnBuscar;
    }
}