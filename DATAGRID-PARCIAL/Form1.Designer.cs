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
            this.dataGridMA = new System.Windows.Forms.DataGridView();
            this.dataGridMAMB = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridMBMA = new System.Windows.Forms.DataGridView();
            this.dataGridB = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMAMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMBMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(833, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(153, 39);
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
            this.groupBox2.Location = new System.Drawing.Point(504, 39);
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
            // 
            // dataGridMA
            // 
            this.dataGridMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMA.Location = new System.Drawing.Point(37, 197);
            this.dataGridMA.Name = "dataGridMA";
            this.dataGridMA.RowTemplate.Height = 25;
            this.dataGridMA.Size = new System.Drawing.Size(376, 179);
            this.dataGridMA.TabIndex = 5;
            // 
            // dataGridMAMB
            // 
            this.dataGridMAMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMAMB.Location = new System.Drawing.Point(452, 197);
            this.dataGridMAMB.Name = "dataGridMAMB";
            this.dataGridMAMB.RowTemplate.Height = 25;
            this.dataGridMAMB.Size = new System.Drawing.Size(364, 179);
            this.dataGridMAMB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "AxB";
            // 
            // dataGridMBMA
            // 
            this.dataGridMBMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMBMA.Location = new System.Drawing.Point(37, 405);
            this.dataGridMBMA.Name = "dataGridMBMA";
            this.dataGridMBMA.RowTemplate.Height = 25;
            this.dataGridMBMA.Size = new System.Drawing.Size(376, 179);
            this.dataGridMBMA.TabIndex = 9;
            // 
            // dataGridB
            // 
            this.dataGridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridB.Location = new System.Drawing.Point(452, 405);
            this.dataGridB.Name = "dataGridB";
            this.dataGridB.RowTemplate.Height = 25;
            this.dataGridB.Size = new System.Drawing.Size(364, 179);
            this.dataGridB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "BxA";
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Location = new System.Drawing.Point(23, 90);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(102, 29);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "MULTIPLICAR";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(23, 39);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(102, 29);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 752);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridB);
            this.Controls.Add(this.dataGridMBMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridMAMB);
            this.Controls.Add(this.dataGridMA);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMAMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMBMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridB)).EndInit();
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
        private DataGridView dataGridMA;
        private DataGridView dataGridMAMB;
        private Label label5;
        private Label label6;
        private DataGridView dataGridMBMA;
        private DataGridView dataGridB;
        private Label label7;
        private Label label8;
        private Button buttonMultiplicar;
        private Button buttonAgregar;
    }
}