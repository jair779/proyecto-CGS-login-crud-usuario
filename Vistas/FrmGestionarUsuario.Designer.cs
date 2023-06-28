namespace Proyecto_CGS.Vistas
{
    partial class FrmGestionarUsuario
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
            System.Windows.Forms.Label estadoUsuarioLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label passwordUsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarUsuario));
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.estadoUsuarioCheckBox = new System.Windows.Forms.CheckBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            estadoUsuarioLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            passwordUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBox_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // estadoUsuarioLabel
            // 
            estadoUsuarioLabel.AutoSize = true;
            estadoUsuarioLabel.Location = new System.Drawing.Point(28, 280);
            estadoUsuarioLabel.Name = "estadoUsuarioLabel";
            estadoUsuarioLabel.Size = new System.Drawing.Size(82, 13);
            estadoUsuarioLabel.TabIndex = 0;
            estadoUsuarioLabel.Text = "Estado Usuario:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(38, 31);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 2;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(24, 144);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(94, 13);
            nombreCompletoLabel.TabIndex = 4;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(24, 71);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombreUsuarioLabel.TabIndex = 6;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // passwordUsuarioLabel
            // 
            passwordUsuarioLabel.AutoSize = true;
            passwordUsuarioLabel.Location = new System.Drawing.Point(15, 109);
            passwordUsuarioLabel.Name = "passwordUsuarioLabel";
            passwordUsuarioLabel.Size = new System.Drawing.Size(95, 13);
            passwordUsuarioLabel.TabIndex = 8;
            passwordUsuarioLabel.Text = "Password Usuario:";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Proyecto_CGS.Models.Usuario);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(303, 128);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(541, 292);
            this.usuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordUsuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn4.HeaderText = "NombreCompleto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EstadoUsuario";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EstadoUsuario";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // groupBox_Usuario
            // 
            this.groupBox_Usuario.Controls.Add(this.btn_cancelar);
            this.groupBox_Usuario.Controls.Add(this.btn_guardar);
            this.groupBox_Usuario.Controls.Add(estadoUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.estadoUsuarioCheckBox);
            this.groupBox_Usuario.Controls.Add(idUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.idUsuarioTextBox);
            this.groupBox_Usuario.Controls.Add(nombreCompletoLabel);
            this.groupBox_Usuario.Controls.Add(this.nombreCompletoTextBox);
            this.groupBox_Usuario.Controls.Add(nombreUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.nombreUsuarioTextBox);
            this.groupBox_Usuario.Controls.Add(passwordUsuarioLabel);
            this.groupBox_Usuario.Controls.Add(this.passwordUsuarioTextBox);
            this.groupBox_Usuario.Enabled = false;
            this.groupBox_Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_Usuario.Location = new System.Drawing.Point(12, 48);
            this.groupBox_Usuario.Name = "groupBox_Usuario";
            this.groupBox_Usuario.Size = new System.Drawing.Size(252, 372);
            this.groupBox_Usuario.TabIndex = 2;
            this.groupBox_Usuario.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(142, 329);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(27, 329);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // estadoUsuarioCheckBox
            // 
            this.estadoUsuarioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "EstadoUsuario", true));
            this.estadoUsuarioCheckBox.Location = new System.Drawing.Point(142, 275);
            this.estadoUsuarioCheckBox.Name = "estadoUsuarioCheckBox";
            this.estadoUsuarioCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoUsuarioCheckBox.TabIndex = 1;
            this.estadoUsuarioCheckBox.Text = "Activo";
            this.estadoUsuarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(120, 28);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(104, 20);
            this.idUsuarioTextBox.TabIndex = 3;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(41, 169);
            this.nombreCompletoTextBox.Multiline = true;
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(188, 86);
            this.nombreCompletoTextBox.TabIndex = 5;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreUsuario", true));
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(120, 68);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreUsuarioTextBox.TabIndex = 7;
            // 
            // passwordUsuarioTextBox
            // 
            this.passwordUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "PasswordUsuario", true));
            this.passwordUsuarioTextBox.Location = new System.Drawing.Point(120, 109);
            this.passwordUsuarioTextBox.Name = "passwordUsuarioTextBox";
            this.passwordUsuarioTextBox.Size = new System.Drawing.Size(104, 20);
            this.passwordUsuarioTextBox.TabIndex = 9;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Location = new System.Drawing.Point(659, 50);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Lime;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Location = new System.Drawing.Point(746, 26);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(115, 23);
            this.btn_nuevo.TabIndex = 4;
            this.btn_nuevo.Text = "Nuevo Usuario";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Cyan;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Location = new System.Drawing.Point(769, 61);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(769, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(382, 53);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(245, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(93, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "USUARIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(337, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Buscar por : Nombre Usuario | Nombre Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(569, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "\"VENTA DE COMPUTADORAS\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(629, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "\"INFINITIX\"";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(141, 444);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 9;
            // 
            // txt_rol
            // 
            this.txt_rol.Location = new System.Drawing.Point(731, 443);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(100, 20);
            this.txt_rol.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(78, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(690, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rol  : ";
            // 
            // FrmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(873, 476);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rol);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox_Usuario);
            this.Controls.Add(this.usuarioDataGridView);
            this.DoubleBuffered = true;
            this.Name = "FrmGestionarUsuario";
            this.Text = "FrmGestionarUsuario";
            this.Load += new System.EventHandler(this.FrmGestionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBox_Usuario.ResumeLayout(false);
            this.groupBox_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox_Usuario;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.CheckBox estadoUsuarioCheckBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox passwordUsuarioTextBox;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}