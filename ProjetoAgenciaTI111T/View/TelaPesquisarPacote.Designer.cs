
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarImagemPacote = new System.Windows.Forms.Button();
            this.tbxCodigoPacote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxDescricaoPacote = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerVolta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIda = new System.Windows.Forms.DateTimePicker();
            this.tbxDestinoPacote = new System.Windows.Forms.TextBox();
            this.tbxOrigemPacote = new System.Windows.Forms.TextBox();
            this.tbxValorPacote = new System.Windows.Forms.TextBox();
            this.pictureBoxPesquisar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarPacote = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisar)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(43, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 359);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(630, 221);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(374, 23);
            this.textBox3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nome do pacote:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarPacote);
            this.tabPage2.Controls.Add(this.btnBuscarImagemPacote);
            this.tabPage2.Controls.Add(this.tbxCodigoPacote);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.rtxDescricaoPacote);
            this.tabPage2.Controls.Add(this.dateTimePickerVolta);
            this.tabPage2.Controls.Add(this.dateTimePickerIda);
            this.tabPage2.Controls.Add(this.tbxDestinoPacote);
            this.tabPage2.Controls.Add(this.tbxOrigemPacote);
            this.tabPage2.Controls.Add(this.tbxValorPacote);
            this.tabPage2.Controls.Add(this.pictureBoxPesquisar);
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
            // btnBuscarImagemPacote
            // 
            this.btnBuscarImagemPacote.Location = new System.Drawing.Point(528, 176);
            this.btnBuscarImagemPacote.Name = "btnBuscarImagemPacote";
            this.btnBuscarImagemPacote.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarImagemPacote.TabIndex = 19;
            this.btnBuscarImagemPacote.Text = "Buscar Imagem";
            this.btnBuscarImagemPacote.UseVisualStyleBackColor = true;
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
            this.rtxDescricaoPacote.Size = new System.Drawing.Size(426, 77);
            this.rtxDescricaoPacote.TabIndex = 16;
            this.rtxDescricaoPacote.Text = "";
            // 
            // dateTimePickerVolta
            // 
            this.dateTimePickerVolta.Location = new System.Drawing.Point(116, 194);
            this.dateTimePickerVolta.Name = "dateTimePickerVolta";
            this.dateTimePickerVolta.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerVolta.TabIndex = 15;
            // 
            // dateTimePickerIda
            // 
            this.dateTimePickerIda.Location = new System.Drawing.Point(116, 160);
            this.dateTimePickerIda.Name = "dateTimePickerIda";
            this.dateTimePickerIda.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerIda.TabIndex = 14;
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
            // pictureBoxPesquisar
            // 
            this.pictureBoxPesquisar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPesquisar.Location = new System.Drawing.Point(515, 47);
            this.pictureBoxPesquisar.Name = "pictureBoxPesquisar";
            this.pictureBoxPesquisar.Size = new System.Drawing.Size(151, 114);
            this.pictureBoxPesquisar.TabIndex = 7;
            this.pictureBoxPesquisar.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisar)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxPesquisar;
        private System.Windows.Forms.RichTextBox rtxDescricaoPacote;
        private System.Windows.Forms.DateTimePicker dateTimePickerVolta;
        private System.Windows.Forms.DateTimePicker dateTimePickerIda;
        private System.Windows.Forms.TextBox tbxDestinoPacote;
        private System.Windows.Forms.TextBox tbxOrigemPacote;
        private System.Windows.Forms.TextBox tbxValorPacote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnBuscarImagemPacote;
        private System.Windows.Forms.TextBox tbxCodigoPacote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarPacote;
    }
}