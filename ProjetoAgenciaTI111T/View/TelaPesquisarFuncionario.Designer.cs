
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaPesquisarFuncionario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSenhaFun = new System.Windows.Forms.TabPage();
            this.tbxSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmailFuncionario = new System.Windows.Forms.TextBox();
            this.tbxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.tbxDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbxSenhaFun.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbxSenhaFun);
            this.tabControl1.Location = new System.Drawing.Point(69, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(653, 145);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 71;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(328, 23);
            this.textBox5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pesquisar funcionário:";
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Controls.Add(this.tbxSenhaFuncionario);
            this.tbxSenhaFun.Controls.Add(this.label5);
            this.tbxSenhaFun.Controls.Add(this.tbxEmailFuncionario);
            this.tbxSenhaFun.Controls.Add(this.tbxNomeFuncionario);
            this.tbxSenhaFun.Controls.Add(this.tbxDeletarFuncionario);
            this.tbxSenhaFun.Controls.Add(this.btnAlterarFuncionario);
            this.tbxSenhaFun.Controls.Add(this.btnBuscarFuncionario);
            this.tbxSenhaFun.Controls.Add(this.label4);
            this.tbxSenhaFun.Controls.Add(this.label3);
            this.tbxSenhaFun.Controls.Add(this.tbxCodigoFuncionario);
            this.tbxSenhaFun.Controls.Add(this.label2);
            this.tbxSenhaFun.Location = new System.Drawing.Point(4, 24);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.Padding = new System.Windows.Forms.Padding(3);
            this.tbxSenhaFun.Size = new System.Drawing.Size(675, 257);
            this.tbxSenhaFun.TabIndex = 1;
            this.tbxSenhaFun.Text = "Pesquisar por código";
            this.tbxSenhaFun.UseVisualStyleBackColor = true;
            this.tbxSenhaFun.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbxSenhaFuncionario
            // 
            this.tbxSenhaFuncionario.Location = new System.Drawing.Point(93, 173);
            this.tbxSenhaFuncionario.Name = "tbxSenhaFuncionario";
            this.tbxSenhaFuncionario.Size = new System.Drawing.Size(157, 23);
            this.tbxSenhaFuncionario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha:";
            // 
            // tbxEmailFuncionario
            // 
            this.tbxEmailFuncionario.Location = new System.Drawing.Point(93, 122);
            this.tbxEmailFuncionario.Name = "tbxEmailFuncionario";
            this.tbxEmailFuncionario.Size = new System.Drawing.Size(371, 23);
            this.tbxEmailFuncionario.TabIndex = 8;
            // 
            // tbxNomeFuncionario
            // 
            this.tbxNomeFuncionario.Location = new System.Drawing.Point(93, 78);
            this.tbxNomeFuncionario.Name = "tbxNomeFuncionario";
            this.tbxNomeFuncionario.Size = new System.Drawing.Size(371, 23);
            this.tbxNomeFuncionario.TabIndex = 7;
            // 
            // tbxDeletarFuncionario
            // 
            this.tbxDeletarFuncionario.Location = new System.Drawing.Point(472, 198);
            this.tbxDeletarFuncionario.Name = "tbxDeletarFuncionario";
            this.tbxDeletarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.tbxDeletarFuncionario.TabIndex = 6;
            this.tbxDeletarFuncionario.Text = "Deletar";
            this.tbxDeletarFuncionario.UseVisualStyleBackColor = true;
            this.tbxDeletarFuncionario.Click += new System.EventHandler(this.tbxDeletarFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(334, 198);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFuncionario.TabIndex = 5;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(530, 19);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFuncionario.TabIndex = 4;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // tbxCodigoFuncionario
            // 
            this.tbxCodigoFuncionario.Location = new System.Drawing.Point(224, 22);
            this.tbxCodigoFuncionario.Name = "tbxCodigoFuncionario";
            this.tbxCodigoFuncionario.Size = new System.Drawing.Size(291, 23);
            this.tbxCodigoFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o nome do funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar Funcionários";
            // 
            // TelaPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPesquisarFuncionario";
            this.Text = "TelaPesquisarFuncionario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbxSenhaFun.ResumeLayout(false);
            this.tbxSenhaFun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbxSenhaFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCodigoFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Button tbxDeletarFuncionario;
        private System.Windows.Forms.TextBox tbxEmailFuncionario;
        private System.Windows.Forms.TextBox tbxNomeFuncionario;
        private System.Windows.Forms.TextBox tbxSenhaFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}