
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaPesquisarCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNomeCli = new System.Windows.Forms.Button();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarImagemCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.pictureBoxFotoCliente = new System.Windows.Forms.PictureBox();
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.tbxSenhaCliente = new System.Windows.Forms.TextBox();
            this.tbxEmailCliente = new System.Windows.Forms.TextBox();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomePesquisarCliente = new System.Windows.Forms.Label();
            this.btnBuscaCodCli = new System.Windows.Forms.Button();
            this.tbxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogPesquisar = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Clientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(52, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 338);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCliente);
            this.tabPage1.Controls.Add(this.btnBuscarNomeCli);
            this.tabPage1.Controls.Add(this.tbxNomeCli);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.email,
            this.foto});
            this.dataGridViewCliente.Location = new System.Drawing.Point(19, 87);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(635, 181);
            this.dataGridViewCliente.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 71;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // foto
            // 
            this.foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.Width = 56;
            // 
            // btnBuscarNomeCli
            // 
            this.btnBuscarNomeCli.Location = new System.Drawing.Point(513, 24);
            this.btnBuscarNomeCli.Name = "btnBuscarNomeCli";
            this.btnBuscarNomeCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomeCli.TabIndex = 2;
            this.btnBuscarNomeCli.Text = "Buscar";
            this.btnBuscarNomeCli.UseVisualStyleBackColor = true;
            this.btnBuscarNomeCli.Click += new System.EventHandler(this.btnBuscarNomeCli_Click);
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(207, 25);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(280, 23);
            this.tbxNomeCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o nome do cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarImagemCli);
            this.tabPage2.Controls.Add(this.btnDeletarCli);
            this.tabPage2.Controls.Add(this.pictureBoxFotoCliente);
            this.tabPage2.Controls.Add(this.btnAlterarCli);
            this.tabPage2.Controls.Add(this.tbxSenhaCliente);
            this.tabPage2.Controls.Add(this.tbxEmailCliente);
            this.tabPage2.Controls.Add(this.tbxNomeCliente);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblNomePesquisarCliente);
            this.tabPage2.Controls.Add(this.btnBuscaCodCli);
            this.tabPage2.Controls.Add(this.tbxCodigoCliente);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImagemCli
            // 
            this.btnBuscarImagemCli.Location = new System.Drawing.Point(480, 195);
            this.btnBuscarImagemCli.Name = "btnBuscarImagemCli";
            this.btnBuscarImagemCli.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarImagemCli.TabIndex = 12;
            this.btnBuscarImagemCli.Text = "Buscar imagem";
            this.btnBuscarImagemCli.UseVisualStyleBackColor = true;
            this.btnBuscarImagemCli.Click += new System.EventHandler(this.btnBuscarImagemCli_Click);
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Location = new System.Drawing.Point(359, 235);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCli.TabIndex = 11;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // pictureBoxFotoCliente
            // 
            this.pictureBoxFotoCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxFotoCliente.Location = new System.Drawing.Point(480, 84);
            this.pictureBoxFotoCliente.Name = "pictureBoxFotoCliente";
            this.pictureBoxFotoCliente.Size = new System.Drawing.Size(111, 105);
            this.pictureBoxFotoCliente.TabIndex = 10;
            this.pictureBoxFotoCliente.TabStop = false;
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.Location = new System.Drawing.Point(262, 235);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCli.TabIndex = 9;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = true;
            this.btnAlterarCli.Click += new System.EventHandler(this.btnAlterarCli_Click);
            // 
            // tbxSenhaCliente
            // 
            this.tbxSenhaCliente.Location = new System.Drawing.Point(94, 166);
            this.tbxSenhaCliente.Name = "tbxSenhaCliente";
            this.tbxSenhaCliente.Size = new System.Drawing.Size(122, 23);
            this.tbxSenhaCliente.TabIndex = 8;
            // 
            // tbxEmailCliente
            // 
            this.tbxEmailCliente.Location = new System.Drawing.Point(94, 127);
            this.tbxEmailCliente.Name = "tbxEmailCliente";
            this.tbxEmailCliente.Size = new System.Drawing.Size(349, 23);
            this.tbxEmailCliente.TabIndex = 7;
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Location = new System.Drawing.Point(94, 85);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(349, 23);
            this.tbxNomeCliente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // lblNomePesquisarCliente
            // 
            this.lblNomePesquisarCliente.AutoSize = true;
            this.lblNomePesquisarCliente.Location = new System.Drawing.Point(38, 85);
            this.lblNomePesquisarCliente.Name = "lblNomePesquisarCliente";
            this.lblNomePesquisarCliente.Size = new System.Drawing.Size(40, 15);
            this.lblNomePesquisarCliente.TabIndex = 3;
            this.lblNomePesquisarCliente.Text = "Nome";
            // 
            // btnBuscaCodCli
            // 
            this.btnBuscaCodCli.Location = new System.Drawing.Point(544, 43);
            this.btnBuscaCodCli.Name = "btnBuscaCodCli";
            this.btnBuscaCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaCodCli.TabIndex = 2;
            this.btnBuscaCodCli.Text = "Buscar";
            this.btnBuscaCodCli.UseVisualStyleBackColor = true;
            this.btnBuscaCodCli.Click += new System.EventHandler(this.btnBuscaCodCli_Click);
            // 
            // tbxCodigoCliente
            // 
            this.tbxCodigoCliente.Location = new System.Drawing.Point(223, 43);
            this.tbxCodigoCliente.Name = "tbxCodigoCliente";
            this.tbxCodigoCliente.Size = new System.Drawing.Size(287, 23);
            this.tbxCodigoCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite o código do cliente:";
            // 
            // openFileDialogPesquisar
            // 
            this.openFileDialogPesquisar.FileName = "openFileDialogPesquisarCliente";
            // 
            // TelaPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarCliente";
            this.Text = "Sistema Gerenciador de Viagens";
            this.Load += new System.EventHandler(this.TelaPesquisarCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNomeCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaCodCli;
        private System.Windows.Forms.TextBox tbxCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNomePesquisarCliente;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.PictureBox pictureBoxFotoCliente;
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.TextBox tbxSenhaCliente;
        private System.Windows.Forms.TextBox tbxEmailCliente;
        private System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.Button btnBuscarImagemCli;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPesquisar;
    }
}