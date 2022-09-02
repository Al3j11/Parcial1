namespace DATAGRID_PARCIAL
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textColmMA = new System.Windows.Forms.TextBox();
            this.textFilasMA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textColmMB = new System.Windows.Forms.TextBox();
            this.textFilasMB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.matrizB = new System.Windows.Forms.DataGridView();
            this.matrizRAB = new System.Windows.Forms.DataGridView();
            this.matrizRBA = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizRAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizRBA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(1019, 734);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(102, 29);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textColmMA);
            this.groupBox1.Controls.Add(this.textFilasMA);
            this.groupBox1.Location = new System.Drawing.Point(175, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MATRIZ A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columnas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filas";
            // 
            // textColmMA
            // 
            this.textColmMA.Location = new System.Drawing.Point(160, 41);
            this.textColmMA.Name = "textColmMA";
            this.textColmMA.Size = new System.Drawing.Size(100, 23);
            this.textColmMA.TabIndex = 1;
            // 
            // textFilasMA
            // 
            this.textFilasMA.Location = new System.Drawing.Point(10, 41);
            this.textFilasMA.Name = "textFilasMA";
            this.textFilasMA.Size = new System.Drawing.Size(100, 23);
            this.textFilasMA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textColmMB);
            this.groupBox2.Controls.Add(this.textFilasMB);
            this.groupBox2.Location = new System.Drawing.Point(703, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MATRIZ B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Filas";
            // 
            // textColmMB
            // 
            this.textColmMB.Location = new System.Drawing.Point(160, 41);
            this.textColmMB.Name = "textColmMB";
            this.textColmMB.Size = new System.Drawing.Size(100, 23);
            this.textColmMB.TabIndex = 4;
            // 
            // textFilasMB
            // 
            this.textFilasMB.Location = new System.Drawing.Point(10, 41);
            this.textFilasMB.Name = "textFilasMB";
            this.textFilasMB.Size = new System.Drawing.Size(100, 23);
            this.textFilasMB.TabIndex = 3;
            this.textFilasMB.TextChanged += new System.EventHandler(this.textFilasMB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(907, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "AxB";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "BxA";
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Location = new System.Drawing.Point(1081, 90);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(102, 29);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "MULTIPLICAR";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(1081, 39);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(102, 29);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // matrizA
            // 
            this.matrizA.AllowUserToAddRows = false;
            this.matrizA.AllowUserToDeleteRows = false;
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.Location = new System.Drawing.Point(175, 162);
            this.matrizA.Name = "matrizA";
            this.matrizA.RowTemplate.Height = 25;
            this.matrizA.Size = new System.Drawing.Size(418, 255);
            this.matrizA.TabIndex = 13;
            this.matrizA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matrizB
            // 
            this.matrizB.AllowUserToAddRows = false;
            this.matrizB.AllowUserToDeleteRows = false;
            this.matrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizB.Location = new System.Drawing.Point(703, 454);
            this.matrizB.Name = "matrizB";
            this.matrizB.RowTemplate.Height = 25;
            this.matrizB.Size = new System.Drawing.Size(418, 255);
            this.matrizB.TabIndex = 14;
            // 
            // matrizRAB
            // 
            this.matrizRAB.AllowUserToAddRows = false;
            this.matrizRAB.AllowUserToDeleteRows = false;
            this.matrizRAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizRAB.Location = new System.Drawing.Point(703, 162);
            this.matrizRAB.Name = "matrizRAB";
            this.matrizRAB.RowTemplate.Height = 25;
            this.matrizRAB.Size = new System.Drawing.Size(418, 255);
            this.matrizRAB.TabIndex = 15;
            // 
            // matrizRBA
            // 
            this.matrizRBA.AllowUserToAddRows = false;
            this.matrizRBA.AllowUserToDeleteRows = false;
            this.matrizRBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizRBA.Location = new System.Drawing.Point(175, 454);
            this.matrizRBA.Name = "matrizRBA";
            this.matrizRBA.RowTemplate.Height = 25;
            this.matrizRBA.Size = new System.Drawing.Size(418, 255);
            this.matrizRBA.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "REINICIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 784);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrizRBA);
            this.Controls.Add(this.matrizRAB);
            this.Controls.Add(this.matrizB);
            this.Controls.Add(this.matrizA);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MATRIZ X MATRIZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizRAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizRBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalir;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textColmMA;
        private TextBox textFilasMA;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private TextBox textColmMB;
        private TextBox textFilasMB;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonMultiplicar;
        private Button buttonAgregar;
        private DataGridView matrizA;
        private DataGridView matrizB;
        private DataGridView matrizRAB;
        private DataGridView matrizRBA;
        private Button button1;
    }
}