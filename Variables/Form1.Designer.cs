namespace Variables
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificarLocal = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.lblVariableGlobal = new System.Windows.Forms.Label();
            this.btnVerificarGlobal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(170, 19);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(396, 30);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(170, 80);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(194, 30);
            this.tbCodigo.TabIndex = 3;
            // 
            // btnVerificarLocal
            // 
            this.btnVerificarLocal.Location = new System.Drawing.Point(29, 154);
            this.btnVerificarLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificarLocal.Name = "btnVerificarLocal";
            this.btnVerificarLocal.Size = new System.Drawing.Size(252, 91);
            this.btnVerificarLocal.TabIndex = 4;
            this.btnVerificarLocal.Text = "Verificar";
            this.btnVerificarLocal.UseVisualStyleBackColor = true;
            this.btnVerificarLocal.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(170, 295);
            this.lblVariableLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(136, 25);
            this.lblVariableLocal.TabIndex = 6;
            this.lblVariableLocal.Text = "Variable Local";
            this.lblVariableLocal.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblVariableGlobal
            // 
            this.lblVariableGlobal.AutoSize = true;
            this.lblVariableGlobal.Location = new System.Drawing.Point(170, 369);
            this.lblVariableGlobal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariableGlobal.Name = "lblVariableGlobal";
            this.lblVariableGlobal.Size = new System.Drawing.Size(145, 25);
            this.lblVariableGlobal.TabIndex = 7;
            this.lblVariableGlobal.Text = "Variable Global";
            this.lblVariableGlobal.Click += new System.EventHandler(this.lblVariableGlobal_Click);
            // 
            // btnVerificarGlobal
            // 
            this.btnVerificarGlobal.Location = new System.Drawing.Point(314, 154);
            this.btnVerificarGlobal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificarGlobal.Name = "btnVerificarGlobal";
            this.btnVerificarGlobal.Size = new System.Drawing.Size(252, 91);
            this.btnVerificarGlobal.TabIndex = 8;
            this.btnVerificarGlobal.Text = "Verificar Global";
            this.btnVerificarGlobal.UseVisualStyleBackColor = true;
            this.btnVerificarGlobal.Click += new System.EventHandler(this.btnVerificarGlobal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 430);
            this.Controls.Add(this.btnVerificarGlobal);
            this.Controls.Add(this.lblVariableGlobal);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.btnVerificarLocal);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnVerificarLocal;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label lblVariableGlobal;
        private System.Windows.Forms.Button btnVerificarGlobal;
    }
}

