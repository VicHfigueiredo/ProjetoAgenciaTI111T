
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaPesquisarPacote
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
            this.dataGridViewPacote = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBucarPacoteNome = new System.Windows.Forms.Button();
            this.tbxOrigemPac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletarPacote = new System.Windows.Forms.Button();
            this.btnAlterarPacote = new System.Windows.Forms.Button();
            this.btnBuscarPacote = new System.Windows.Forms.Button();
            this.btnBuscarImagemPacote = new System.Windows.Forms.Button();
            this.tbxCodigoPacote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxDescricaoPacote = new System.Windows.Forms.RichTextBox();
            this.dateVolta = new System.Windows.Forms.DateTimePicker();
            this.dateIda = new System.Windows.Forms.DateTimePicker();
            this.tbxDestinoPacote = new System.Windows.Forms.TextBox();
            this.tbxOrigemPacote = new System.Windows.Forms.TextBox();
            this.tbxValorPacote = new System.Windows.Forms.TextBox();
            this.pictureBoxFotoPacote = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewDestinoPacote = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.tbxDestinoPac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialogPesquisarPacote = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacote)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPacote)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinoPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Pacotes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(43, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 359);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPacote);
            this.tabPage1.Controls.Add(this.btnBucarPacoteNome);
            this.tabPage1.Controls.Add(this.tbxOrigemPac);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por origem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacote
            // 
            this.dataGridViewPacote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewPacote.Location = new System.Drawing.Point(47, 74);
            this.dataGridViewPacote.Name = "dataGridViewPacote";
            this.dataGridViewPacote.RowHeadersVisible = false;
            this.dataGridViewPacote.RowTemplate.Height = 25;
            this.dataGridViewPacote.Size = new System.Drawing.Size(627, 192);
            this.dataGridViewPacote.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Origem";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Destino";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data da ida";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data da volta";
            this.Column6.Name = "Column6";
            // 
            // btnBucarPacoteNome
            // 
            this.btnBucarPacoteNome.Location = new System.Drawing.Point(581, 29);
            this.btnBucarPacoteNome.Name = "btnBucarPacoteNome";
            this.btnBucarPacoteNome.Size = new System.Drawing.Size(75, 23);
            this.btnBucarPacoteNome.TabIndex = 2;
            this.btnBucarPacoteNome.Text = "Buscar";
            this.btnBucarPacoteNome.UseVisualStyleBackColor = true;
            this.btnBucarPacoteNome.Click += new System.EventHandler(this.btnBucarPacoteNome_Click);
            // 
            // tbxOrigemPac
            // 
            this.tbxOrigemPac.Location = new System.Drawing.Point(163, 29);
            this.tbxOrigemPac.Name = "tbxOrigemPac";
            this.tbxOrigemPac.Size = new System.Drawing.Size(374, 23);
            this.tbxOrigemPac.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Origem:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeletarPacote);
            this.tabPage2.Controls.Add(this.btnAlterarPacote);
            this.tabPage2.Controls.Add(this.btnBuscarPacote);
            this.tabPage2.Controls.Add(this.btnBuscarImagemPacote);
            this.tabPage2.Controls.Add(this.tbxCodigoPacote);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.rtxDescricaoPacote);
            this.tabPage2.Controls.Add(this.dateVolta);
            this.tabPage2.Controls.Add(this.dateIda);
            this.tabPage2.Controls.Add(this.tbxDestinoPacote);
            this.tabPage2.Controls.Add(this.tbxOrigemPacote);
            this.tabPage2.Controls.Add(this.tbxValorPacote);
            this.tabPage2.Controls.Add(this.pictureBoxFotoPacote);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por código";
            // 
            // btnDeletarPacote
            // 
            this.btnDeletarPacote.Location = new System.Drawing.Point(621, 278);
            this.btnDeletarPacote.Name = "btnDeletarPacote";
            this.btnDeletarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarPacote.TabIndex = 22;
            this.btnDeletarPacote.Text = "Deletar";
            this.btnDeletarPacote.UseVisualStyleBackColor = true;
            this.btnDeletarPacote.Click += new System.EventHandler(this.btnDeletarPacote_Click);
            // 
            // btnAlterarPacote
            // 
            this.btnAlterarPacote.Location = new System.Drawing.Point(528, 278);
            this.btnAlterarPacote.Name = "btnAlterarPacote";
            this.btnAlterarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPacote.TabIndex = 21;
            this.btnAlterarPacote.Text = "Alterar";
            this.btnAlterarPacote.UseVisualStyleBackColor = true;
            this.btnAlterarPacote.Click += new System.EventHandler(this.btnAlterarPacote_Click);
            // 
            // btnBuscarPacote
            // 
            this.btnBuscarPacote.Location = new System.Drawing.Point(420, 18);
            this.btnBuscarPacote.Name = "btnBuscarPacote";
            this.btnBuscarPacote.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPacote.TabIndex = 20;
            this.btnBuscarPacote.Text = "Buscar";
            this.btnBuscarPacote.UseVisualStyleBackColor = true;
            this.btnBuscarPacote.Click += new System.EventHandler(this.btnBuscarPacote_Click);
            // 
            // btnBuscarImagemPacote
            // 
            this.btnBuscarImagemPacote.Location = new System.Drawing.Point(528, 176);
            this.btnBuscarImagemPacote.Name = "btnBuscarImagemPacote";
            this.btnBuscarImagemPacote.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarImagemPacote.TabIndex = 19;
            this.btnBuscarImagemPacote.Text = "Buscar Imagem";
            this.btnBuscarImagemPacote.UseVisualStyleBackColor = true;
            this.btnBuscarImagemPacote.Click += new System.EventHandler(this.btnBuscarImagemPacote_Click);
            // 
            // tbxCodigoPacote
            // 
            this.tbxCodigoPacote.Location = new System.Drawing.Point(210, 19);
            this.tbxCodigoPacote.Name = "tbxCodigoPacote";
            this.tbxCodigoPacote.Size = new System.Drawing.Size(175, 23);
            this.tbxCodigoPacote.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Digite o código do pacote:";
            // 
            // rtxDescricaoPacote
            // 
            this.rtxDescricaoPacote.Location = new System.Drawing.Point(108, 237);
            this.rtxDescricaoPacote.Name = "rtxDescricaoPacote";
            this.rtxDescricaoPacote.Size = new System.Drawing.Size(387, 65);
            this.rtxDescricaoPacote.TabIndex = 16;
            this.rtxDescricaoPacote.Text = "";
            // 
            // dateVolta
            // 
            this.dateVolta.Location = new System.Drawing.Point(116, 194);
            this.dateVolta.Name = "dateVolta";
            this.dateVolta.Size = new System.Drawing.Size(200, 23);
            this.dateVolta.TabIndex = 15;
            // 
            // dateIda
            // 
            this.dateIda.Location = new System.Drawing.Point(116, 160);
            this.dateIda.Name = "dateIda";
            this.dateIda.Size = new System.Drawing.Size(200, 23);
            this.dateIda.TabIndex = 14;
            // 
            // tbxDestinoPacote
            // 
            this.tbxDestinoPacote.Location = new System.Drawing.Point(104, 124);
            this.tbxDestinoPacote.Name = "tbxDestinoPacote";
            this.tbxDestinoPacote.Size = new System.Drawing.Size(281, 23);
            this.tbxDestinoPacote.TabIndex = 13;
            // 
            // tbxOrigemPacote
            // 
            this.tbxOrigemPacote.Location = new System.Drawing.Point(104, 96);
            this.tbxOrigemPacote.Name = "tbxOrigemPacote";
            this.tbxOrigemPacote.Size = new System.Drawing.Size(281, 23);
            this.tbxOrigemPacote.TabIndex = 9;
            // 
            // tbxValorPacote
            // 
            this.tbxValorPacote.Location = new System.Drawing.Point(95, 64);
            this.tbxValorPacote.Name = "tbxValorPacote";
            this.tbxValorPacote.Size = new System.Drawing.Size(95, 23);
            this.tbxValorPacote.TabIndex = 8;
            // 
            // pictureBoxFotoPacote
            // 
            this.pictureBoxFotoPacote.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxFotoPacote.Location = new System.Drawing.Point(515, 47);
            this.pictureBoxFotoPacote.Name = "pictureBoxFotoPacote";
            this.pictureBoxFotoPacote.Size = new System.Drawing.Size(151, 114);
            this.pictureBoxFotoPacote.TabIndex = 7;
            this.pictureBoxFotoPacote.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data da volta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data da ida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewDestinoPacote);
            this.tabPage3.Controls.Add(this.btnBuscarDestino);
            this.tabPage3.Controls.Add(this.tbxDestinoPac);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(722, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pesquisar por destino";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDestinoPacote
            // 
            this.dataGridViewDestinoPacote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinoPacote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewDestinoPacote.Location = new System.Drawing.Point(36, 69);
            this.dataGridViewDestinoPacote.Name = "dataGridViewDestinoPacote";
            this.dataGridViewDestinoPacote.RowHeadersVisible = false;
            this.dataGridViewDestinoPacote.RowTemplate.Height = 25;
            this.dataGridViewDestinoPacote.Size = new System.Drawing.Size(643, 238);
            this.dataGridViewDestinoPacote.TabIndex = 3;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Código";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Valor";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Origem";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Destino";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Data da ida";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Data da volta";
            this.Column12.Name = "Column12";
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Location = new System.Drawing.Point(549, 23);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDestino.TabIndex = 2;
            this.btnBuscarDestino.Text = "Buscar";
            this.btnBuscarDestino.UseVisualStyleBackColor = true;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // tbxDestinoPac
            // 
            this.tbxDestinoPac.Location = new System.Drawing.Point(109, 24);
            this.tbxDestinoPac.Name = "tbxDestinoPac";
            this.tbxDestinoPac.Size = new System.Drawing.Size(381, 23);
            this.tbxDestinoPac.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Destino";
            // 
            // openFileDialogPesquisarPacote
            // 
            this.openFileDialogPesquisarPacote.FileName = "openFileDialog1";
            // 
            // TelaPesquisarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarPacote";
            this.Text = "TelaPesquisarPacote";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacote)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPacote)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinoPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxFotoPacote;
        private System.Windows.Forms.RichTextBox rtxDescricaoPacote;
        private System.Windows.Forms.DateTimePicker dateVolta;
        private System.Windows.Forms.DateTimePicker dateIda;
        private System.Windows.Forms.TextBox tbxDestinoPacote;
        private System.Windows.Forms.TextBox tbxOrigemPacote;
        private System.Windows.Forms.TextBox tbxValorPacote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewPacote;
        private System.Windows.Forms.Button btnBucarPacoteNome;
        private System.Windows.Forms.TextBox tbxOrigemPac;
        private System.Windows.Forms.Button btnBuscarImagemPacote;
        private System.Windows.Forms.TextBox tbxCodigoPacote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarPacote;
        private System.Windows.Forms.Button btnDeletarPacote;
        private System.Windows.Forms.Button btnAlterarPacote;
        private System.Windows.Forms.OpenFileDialog openFileDialogPesquisarPacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDestinoPacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.TextBox tbxDestinoPac;
        private System.Windows.Forms.Label label8;
    }
}