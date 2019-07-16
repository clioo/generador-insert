namespace Generador_insert
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_openFile = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_encabezado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_filafinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombrehoja = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tabla = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_openFile
            // 
            this.cmd_openFile.Location = new System.Drawing.Point(183, 67);
            this.cmd_openFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_openFile.Name = "cmd_openFile";
            this.cmd_openFile.Size = new System.Drawing.Size(112, 32);
            this.cmd_openFile.TabIndex = 0;
            this.cmd_openFile.Text = "Elegir archivo";
            this.cmd_openFile.UseVisualStyleBackColor = true;
            this.cmd_openFile.Click += new System.EventHandler(this.Cmd_openFile_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(8, 27);
            this.txt_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(430, 26);
            this.txt_path.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_openFile);
            this.groupBox1.Controls.Add(this.txt_path);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(458, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_tabla);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_nombrehoja);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_filafinal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_encabezado);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(458, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración de excel";
            // 
            // txt_encabezado
            // 
            this.txt_encabezado.Location = new System.Drawing.Point(8, 50);
            this.txt_encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_encabezado.Name = "txt_encabezado";
            this.txt_encabezado.Size = new System.Drawing.Size(430, 26);
            this.txt_encabezado.TabIndex = 1;
            this.txt_encabezado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_encabezado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fila de encabezado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila final";
            // 
            // txt_filafinal
            // 
            this.txt_filafinal.Location = new System.Drawing.Point(10, 106);
            this.txt_filafinal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filafinal.Name = "txt_filafinal";
            this.txt_filafinal.Size = new System.Drawing.Size(430, 26);
            this.txt_filafinal.TabIndex = 3;
            this.txt_filafinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_encabezado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de la hoja";
            // 
            // txt_nombrehoja
            // 
            this.txt_nombrehoja.Location = new System.Drawing.Point(8, 161);
            this.txt_nombrehoja.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombrehoja.Name = "txt_nombrehoja";
            this.txt_nombrehoja.Size = new System.Drawing.Size(430, 26);
            this.txt_nombrehoja.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(542, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 537);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre de la tabla";
            // 
            // txt_tabla
            // 
            this.txt_tabla.Location = new System.Drawing.Point(8, 220);
            this.txt_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tabla.Name = "txt_tabla";
            this.txt_tabla.Size = new System.Drawing.Size(430, 26);
            this.txt_tabla.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_openFile;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_encabezado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombrehoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_filafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tabla;
    }
}

