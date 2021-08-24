
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcularOB = new System.Windows.Forms.Button();
            this.txtResultadoOB = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultadoCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEscala = new System.Windows.Forms.ComboBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnCalcularCT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxListado = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERACIONES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 43);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcularOB);
            this.groupBox1.Controls.Add(this.txtResultadoOB);
            this.groupBox1.Controls.Add(this.cmbOperacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones basicas";
            // 
            // btnCalcularOB
            // 
            this.btnCalcularOB.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalcularOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularOB.ForeColor = System.Drawing.Color.White;
            this.btnCalcularOB.Location = new System.Drawing.Point(20, 149);
            this.btnCalcularOB.Name = "btnCalcularOB";
            this.btnCalcularOB.Size = new System.Drawing.Size(182, 27);
            this.btnCalcularOB.TabIndex = 8;
            this.btnCalcularOB.Text = "Calcular";
            this.btnCalcularOB.UseVisualStyleBackColor = false;
            this.btnCalcularOB.Click += new System.EventHandler(this.btnCalcularOB_Click);
            // 
            // txtResultadoOB
            // 
            this.txtResultadoOB.Enabled = false;
            this.txtResultadoOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoOB.Location = new System.Drawing.Point(101, 182);
            this.txtResultadoOB.Name = "txtResultadoOB";
            this.txtResultadoOB.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoOB.TabIndex = 7;
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"});
            this.cmbOperacion.Location = new System.Drawing.Point(101, 103);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(100, 24);
            this.cmbOperacion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operación:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(102, 65);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 23);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(102, 26);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 23);
            this.txtNum1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultadoCT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbEscala);
            this.groupBox2.Controls.Add(this.txtTemperatura);
            this.groupBox2.Controls.Add(this.btnCalcularCT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(17, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertir Temperatura";
            // 
            // txtResultadoCT
            // 
            this.txtResultadoCT.Enabled = false;
            this.txtResultadoCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoCT.Location = new System.Drawing.Point(103, 129);
            this.txtResultadoCT.Name = "txtResultadoCT";
            this.txtResultadoCT.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoCT.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Resultado:";
            // 
            // cmbEscala
            // 
            this.cmbEscala.FormattingEnabled = true;
            this.cmbEscala.Items.AddRange(new object[] {
            "C",
            "F"});
            this.cmbEscala.Location = new System.Drawing.Point(143, 55);
            this.cmbEscala.Name = "cmbEscala";
            this.cmbEscala.Size = new System.Drawing.Size(60, 24);
            this.cmbEscala.TabIndex = 11;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(9, 57);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(105, 23);
            this.txtTemperatura.TabIndex = 10;
            // 
            // btnCalcularCT
            // 
            this.btnCalcularCT.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalcularCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularCT.ForeColor = System.Drawing.Color.White;
            this.btnCalcularCT.Location = new System.Drawing.Point(9, 96);
            this.btnCalcularCT.Name = "btnCalcularCT";
            this.btnCalcularCT.Size = new System.Drawing.Size(194, 27);
            this.btnCalcularCT.TabIndex = 9;
            this.btnCalcularCT.Text = "Calcular";
            this.btnCalcularCT.UseVisualStyleBackColor = false;
            this.btnCalcularCT.Click += new System.EventHandler(this.btnCalcularCT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Escala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Temperatura:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxListado);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnPrimos);
            this.groupBox3.Controls.Add(this.btnRaiz);
            this.groupBox3.Location = new System.Drawing.Point(263, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 423);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar Numeros";
            // 
            // lbxListado
            // 
            this.lbxListado.FormattingEnabled = true;
            this.lbxListado.HorizontalScrollbar = true;
            this.lbxListado.ItemHeight = 16;
            this.lbxListado.Location = new System.Drawing.Point(16, 158);
            this.lbxListado.Name = "lbxListado";
            this.lbxListado.ScrollAlwaysVisible = true;
            this.lbxListado.Size = new System.Drawing.Size(186, 244);
            this.lbxListado.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Resultado:";
            // 
            // btnPrimos
            // 
            this.btnPrimos.BackColor = System.Drawing.Color.Gold;
            this.btnPrimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimos.Location = new System.Drawing.Point(16, 66);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(163, 31);
            this.btnPrimos.TabIndex = 1;
            this.btnPrimos.Text = "Primeros 10 primos";
            this.btnPrimos.UseVisualStyleBackColor = false;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.Gold;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Location = new System.Drawing.Point(16, 26);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(163, 31);
            this.btnRaiz.TabIndex = 0;
            this.btnRaiz.Text = "Raiz del 1 al 10";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(511, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularOB;
        private System.Windows.Forms.TextBox txtResultadoOB;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultadoCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEscala;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnCalcularCT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.ListBox lbxListado;
        private System.Windows.Forms.Label label9;
    }
}

