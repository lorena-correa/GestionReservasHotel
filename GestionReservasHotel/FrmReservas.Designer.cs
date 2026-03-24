namespace GestionReservasHotel
{
    partial class FrmReservas
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
            label1 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvReservas = new DataGridView();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            txtTarifa = new TextBox();
            lblTarifa = new Label();
            txtDuracion = new TextBox();
            lblDuracion = new Label();
            lblFechaReserva = new Label();
            dtpFechaReserva = new DateTimePicker();
            cmbTipoHabitacion = new ComboBox();
            lblTipoHabitacion = new Label();
            lblNumeroHabitacion = new Label();
            txtNumeroHabitacion = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(54, 294);
            label1.Name = "label1";
            label1.Size = new Size(0, 18);
            label1.TabIndex = 44;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Calibri", 11.25F);
            btnLimpiar.ImeMode = ImeMode.NoControl;
            btnLimpiar.Location = new Point(610, 254);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 35);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Calibri", 11.25F);
            btnEliminar.ImeMode = ImeMode.NoControl;
            btnEliminar.Location = new Point(432, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 35);
            btnEliminar.TabIndex = 42;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Calibri", 11.25F);
            btnEditar.ImeMode = ImeMode.NoControl;
            btnEditar.Location = new Point(248, 254);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 35);
            btnEditar.TabIndex = 41;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Calibri", 11.25F);
            btnAgregar.ImeMode = ImeMode.NoControl;
            btnAgregar.Location = new Point(70, 254);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 35);
            btnAgregar.TabIndex = 40;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(59, 315);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(675, 93);
            dgvReservas.TabIndex = 39;
            dgvReservas.CellClick += dgvReservas_CellClick;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Calibri", 11.25F);
            lblObservaciones.ImeMode = ImeMode.NoControl;
            lblObservaciones.Location = new Point(432, 196);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(106, 18);
            lblObservaciones.TabIndex = 38;
            lblObservaciones.Text = "Observaciones: ";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Calibri", 11.25F);
            txtObservaciones.Location = new Point(549, 193);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(191, 33);
            txtObservaciones.TabIndex = 37;
            // 
            // txtTarifa
            // 
            txtTarifa.Font = new Font("Calibri", 11.25F);
            txtTarifa.Location = new Point(549, 149);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 26);
            txtTarifa.TabIndex = 36;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Calibri", 11.25F);
            lblTarifa.ImeMode = ImeMode.NoControl;
            lblTarifa.Location = new Point(422, 154);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(116, 18);
            lblTarifa.TabIndex = 35;
            lblTarifa.Text = "Tarifa por Noche: ";
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Calibri", 11.25F);
            txtDuracion.Location = new Point(549, 106);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(100, 26);
            txtDuracion.TabIndex = 34;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Calibri", 11.25F);
            lblDuracion.ImeMode = ImeMode.NoControl;
            lblDuracion.Location = new Point(406, 109);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(137, 18);
            lblDuracion.TabIndex = 33;
            lblDuracion.Text = "Cantidad de Noches: ";
            // 
            // lblFechaReserva
            // 
            lblFechaReserva.AutoSize = true;
            lblFechaReserva.Font = new Font("Calibri", 11.25F);
            lblFechaReserva.ImeMode = ImeMode.NoControl;
            lblFechaReserva.Location = new Point(419, 69);
            lblFechaReserva.Name = "lblFechaReserva";
            lblFechaReserva.Size = new Size(122, 18);
            lblFechaReserva.TabIndex = 32;
            lblFechaReserva.Text = "Fecha de Reserva: ";
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.Font = new Font("Calibri", 11.25F);
            dtpFechaReserva.Location = new Point(549, 64);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(200, 26);
            dtpFechaReserva.TabIndex = 31;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.Font = new Font("Calibri", 11.25F);
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Estándar", "VIP" });
            cmbTipoHabitacion.Location = new Point(235, 200);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(100, 26);
            cmbTipoHabitacion.TabIndex = 30;
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Font = new Font("Calibri", 11.25F);
            lblTipoHabitacion.ImeMode = ImeMode.NoControl;
            lblTipoHabitacion.Location = new Point(99, 203);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(130, 18);
            lblTipoHabitacion.TabIndex = 29;
            lblTipoHabitacion.Text = "Tipo de Habitación: ";
            // 
            // lblNumeroHabitacion
            // 
            lblNumeroHabitacion.AutoSize = true;
            lblNumeroHabitacion.Font = new Font("Calibri", 11.25F);
            lblNumeroHabitacion.ImeMode = ImeMode.NoControl;
            lblNumeroHabitacion.Location = new Point(76, 162);
            lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            lblNumeroHabitacion.Size = new Size(154, 18);
            lblNumeroHabitacion.TabIndex = 28;
            lblNumeroHabitacion.Text = "Número de Habitación: ";
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Font = new Font("Calibri", 11.25F);
            txtNumeroHabitacion.Location = new Point(235, 154);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(100, 26);
            txtNumeroHabitacion.TabIndex = 27;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Calibri", 11.25F);
            txtDocumento.Location = new Point(235, 107);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 26);
            txtDocumento.TabIndex = 26;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Calibri", 11.25F);
            lblDocumento.ImeMode = ImeMode.NoControl;
            lblDocumento.Location = new Point(134, 115);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 18);
            lblDocumento.TabIndex = 25;
            lblDocumento.Text = "Documento: ";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Calibri", 11.25F);
            txtNombreCliente.Location = new Point(235, 61);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 26);
            txtNombreCliente.TabIndex = 24;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Calibri", 11.25F);
            lblNombreCliente.ImeMode = ImeMode.NoControl;
            lblNombreCliente.Location = new Point(94, 69);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(137, 18);
            lblNombreCliente.TabIndex = 23;
            lblNombreCliente.Text = "Nombre del Cliente: ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblTitulo.ImeMode = ImeMode.NoControl;
            lblTitulo.Location = new Point(271, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 23);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Gestión de Reservas en un Hotel";
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvReservas);
            Controls.Add(lblObservaciones);
            Controls.Add(txtObservaciones);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(txtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(lblFechaReserva);
            Controls.Add(dtpFechaReserva);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(lblNumeroHabitacion);
            Controls.Add(txtNumeroHabitacion);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Name = "FrmReservas";
            Text = "FrmReservas";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvReservas;
        private Label lblObservaciones;
        private TextBox txtObservaciones;
        private TextBox txtTarifa;
        private Label lblTarifa;
        private TextBox txtDuracion;
        private Label lblDuracion;
        private Label lblFechaReserva;
        private DateTimePicker dtpFechaReserva;
        private ComboBox cmbTipoHabitacion;
        private Label lblTipoHabitacion;
        private Label lblNumeroHabitacion;
        private TextBox txtNumeroHabitacion;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private Label lblTitulo;
    }
}