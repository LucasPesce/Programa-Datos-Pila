namespace Pilas
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
            cmdQuitarPila2 = new Button();
            cmdQuitarPila1 = new Button();
            lstPila1 = new ListBox();
            lstPila2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            cmdAgregar = new Button();
            SuspendLayout();
            // 
            // cmdQuitarPila2
            // 
            cmdQuitarPila2.BackColor = Color.FromArgb(128, 128, 255);
            cmdQuitarPila2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            cmdQuitarPila2.ForeColor = Color.FromArgb(255, 192, 255);
            cmdQuitarPila2.Location = new Point(182, 25);
            cmdQuitarPila2.Name = "cmdQuitarPila2";
            cmdQuitarPila2.Size = new Size(73, 52);
            cmdQuitarPila2.TabIndex = 0;
            cmdQuitarPila2.Text = "<<";
            cmdQuitarPila2.UseVisualStyleBackColor = false;
            cmdQuitarPila2.Click += cmdQuitarPila2_Click;
            // 
            // cmdQuitarPila1
            // 
            cmdQuitarPila1.BackColor = Color.FromArgb(128, 128, 255);
            cmdQuitarPila1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            cmdQuitarPila1.ForeColor = Color.FromArgb(255, 192, 255);
            cmdQuitarPila1.Location = new Point(264, 25);
            cmdQuitarPila1.Name = "cmdQuitarPila1";
            cmdQuitarPila1.Size = new Size(72, 52);
            cmdQuitarPila1.TabIndex = 1;
            cmdQuitarPila1.Text = " >>";
            cmdQuitarPila1.UseVisualStyleBackColor = false;
            cmdQuitarPila1.Click += cmdQuitarPila1_Click;
            // 
            // lstPila1
            // 
            lstPila1.FormattingEnabled = true;
            lstPila1.ItemHeight = 37;
            lstPila1.Location = new Point(12, 91);
            lstPila1.Name = "lstPila1";
            lstPila1.Size = new Size(243, 263);
            lstPila1.TabIndex = 2;
            // 
            // lstPila2
            // 
            lstPila2.FormattingEnabled = true;
            lstPila2.ItemHeight = 37;
            lstPila2.Location = new Point(264, 91);
            lstPila2.Name = "lstPila2";
            lstPila2.Size = new Size(243, 263);
            lstPila2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 373);
            label1.Name = "label1";
            label1.Size = new Size(115, 37);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 430);
            label2.Name = "label2";
            label2.Size = new Size(63, 37);
            label2.TabIndex = 5;
            label2.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 370);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 43);
            txtNombre.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(164, 427);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(198, 43);
            txtDNI.TabIndex = 7;
            // 
            // cmdAgregar
            // 
            cmdAgregar.BackColor = Color.FromArgb(128, 128, 255);
            cmdAgregar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            cmdAgregar.ForeColor = Color.FromArgb(255, 192, 255);
            cmdAgregar.Location = new Point(377, 370);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(130, 100);
            cmdAgregar.TabIndex = 8;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = false;
            cmdAgregar.Click += cmdAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(525, 482);
            Controls.Add(cmdAgregar);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPila2);
            Controls.Add(lstPila1);
            Controls.Add(cmdQuitarPila1);
            Controls.Add(cmdQuitarPila2);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Manejo de Pilas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdQuitarPila2;
        private Button cmdQuitarPila1;
        private ListBox lstPila1;
        private ListBox lstPila2;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Button cmdAgregar;
    }
}