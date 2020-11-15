namespace ProjetoBase.NET.Layers.Views
{
    partial class frmResumoCliente
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
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.grdResumoCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRegiao = new System.Windows.Forms.ComboBox();
            this.chkMelhores = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.Location = new System.Drawing.Point(12, 30);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(179, 29);
            this.txtValorMinimo.TabIndex = 1;
            this.txtValorMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMinimo_KeyPress);
            // 
            // grdResumoCliente
            // 
            this.grdResumoCliente.AllowUserToAddRows = false;
            this.grdResumoCliente.AllowUserToDeleteRows = false;
            this.grdResumoCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdResumoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResumoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grdResumoCliente.Location = new System.Drawing.Point(0, 193);
            this.grdResumoCliente.Name = "grdResumoCliente";
            this.grdResumoCliente.ReadOnly = true;
            this.grdResumoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResumoCliente.Size = new System.Drawing.Size(640, 596);
            this.grdResumoCliente.TabIndex = 2;
            this.grdResumoCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdResumoCliente_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorMinimo);
            this.groupBox2.Location = new System.Drawing.Point(433, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor mínimo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.grdResumoCliente);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 813);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumo Clientes";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExcluir);
            this.groupBox5.Location = new System.Drawing.Point(477, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 70);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Excluir";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::ProjetoBase.NET.Properties.Resources.Delete;
            this.btnExcluir.Location = new System.Drawing.Point(6, 28);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(151, 36);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkMelhores);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Location = new System.Drawing.Point(6, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoBase.NET.Properties.Resources.Search;
            this.btnPesquisar.Location = new System.Drawing.Point(6, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 36);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRegiao);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Região";
            // 
            // cmbRegiao
            // 
            this.cmbRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegiao.FormattingEnabled = true;
            this.cmbRegiao.Location = new System.Drawing.Point(6, 29);
            this.cmbRegiao.Name = "cmbRegiao";
            this.cmbRegiao.Size = new System.Drawing.Size(409, 30);
            this.cmbRegiao.TabIndex = 5;
            // 
            // chkMelhores
            // 
            this.chkMelhores.AutoSize = true;
            this.chkMelhores.Checked = true;
            this.chkMelhores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMelhores.Location = new System.Drawing.Point(165, 34);
            this.chkMelhores.Name = "chkMelhores";
            this.chkMelhores.Size = new System.Drawing.Size(295, 26);
            this.chkMelhores.TabIndex = 9;
            this.chkMelhores.Text = "Pesquisar Melhores Clientes";
            this.chkMelhores.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Cliente";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Total";
            this.Column2.HeaderText = "Valor Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmResumoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(673, 854);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmResumoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResumoCliente";
            this.Load += new System.EventHandler(this.frmResumoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.DataGridView grdResumoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRegiao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chkMelhores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}