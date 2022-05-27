
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaCadastrarPacote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarPacote));
            this.cadastrarPacote = new System.Windows.Forms.Label();
            this.lblValorPacote = new System.Windows.Forms.Label();
            this.lblOrigemPacote = new System.Windows.Forms.Label();
            this.lblDestinoPacote = new System.Windows.Forms.Label();
            this.lblDataIdaPacote = new System.Windows.Forms.Label();
            this.lblDataVoltaPacote = new System.Windows.Forms.Label();
            this.lblDescricaoPacote = new System.Windows.Forms.Label();
            this.dataIdaPacote = new System.Windows.Forms.DateTimePicker();
            this.dataVoltaPacote = new System.Windows.Forms.DateTimePicker();
            this.tbxDescricaoPacote = new System.Windows.Forms.RichTextBox();
            this.tbxValorPacote = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvarPacote = new System.Windows.Forms.Button();
            this.btnBuscarImagemPacote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrarPacote
            // 
            this.cadastrarPacote.AutoSize = true;
            this.cadastrarPacote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastrarPacote.Location = new System.Drawing.Point(262, 21);
            this.cadastrarPacote.Name = "cadastrarPacote";
            this.cadastrarPacote.Size = new System.Drawing.Size(313, 30);
            this.cadastrarPacote.TabIndex = 0;
            this.cadastrarPacote.Text = "Cadastro de Pacote de Viagens";
            // 
            // lblValorPacote
            // 
            this.lblValorPacote.AutoSize = true;
            this.lblValorPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorPacote.Location = new System.Drawing.Point(46, 362);
            this.lblValorPacote.Name = "lblValorPacote";
            this.lblValorPacote.Size = new System.Drawing.Size(52, 21);
            this.lblValorPacote.TabIndex = 1;
            this.lblValorPacote.Text = "Valor:";
            // 
            // lblOrigemPacote
            // 
            this.lblOrigemPacote.AutoSize = true;
            this.lblOrigemPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigemPacote.Location = new System.Drawing.Point(46, 87);
            this.lblOrigemPacote.Name = "lblOrigemPacote";
            this.lblOrigemPacote.Size = new System.Drawing.Size(69, 21);
            this.lblOrigemPacote.TabIndex = 2;
            this.lblOrigemPacote.Text = "Origem:";
            // 
            // lblDestinoPacote
            // 
            this.lblDestinoPacote.AutoSize = true;
            this.lblDestinoPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestinoPacote.Location = new System.Drawing.Point(46, 144);
            this.lblDestinoPacote.Name = "lblDestinoPacote";
            this.lblDestinoPacote.Size = new System.Drawing.Size(70, 21);
            this.lblDestinoPacote.TabIndex = 3;
            this.lblDestinoPacote.Text = "Destino:";
            // 
            // lblDataIdaPacote
            // 
            this.lblDataIdaPacote.AutoSize = true;
            this.lblDataIdaPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataIdaPacote.Location = new System.Drawing.Point(45, 304);
            this.lblDataIdaPacote.Name = "lblDataIdaPacote";
            this.lblDataIdaPacote.Size = new System.Drawing.Size(99, 21);
            this.lblDataIdaPacote.TabIndex = 4;
            this.lblDataIdaPacote.Text = "Data da ida: ";
            // 
            // lblDataVoltaPacote
            // 
            this.lblDataVoltaPacote.AutoSize = true;
            this.lblDataVoltaPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataVoltaPacote.Location = new System.Drawing.Point(300, 307);
            this.lblDataVoltaPacote.Name = "lblDataVoltaPacote";
            this.lblDataVoltaPacote.Size = new System.Drawing.Size(113, 21);
            this.lblDataVoltaPacote.TabIndex = 5;
            this.lblDataVoltaPacote.Text = "Data da volta: ";
            // 
            // lblDescricaoPacote
            // 
            this.lblDescricaoPacote.AutoSize = true;
            this.lblDescricaoPacote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoPacote.Location = new System.Drawing.Point(45, 191);
            this.lblDescricaoPacote.Name = "lblDescricaoPacote";
            this.lblDescricaoPacote.Size = new System.Drawing.Size(85, 21);
            this.lblDescricaoPacote.TabIndex = 6;
            this.lblDescricaoPacote.Text = "Descrição:";
            // 
            // dataIdaPacote
            // 
            this.dataIdaPacote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataIdaPacote.Location = new System.Drawing.Point(150, 304);
            this.dataIdaPacote.Name = "dataIdaPacote";
            this.dataIdaPacote.Size = new System.Drawing.Size(123, 23);
            this.dataIdaPacote.TabIndex = 10;
            // 
            // dataVoltaPacote
            // 
            this.dataVoltaPacote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVoltaPacote.Location = new System.Drawing.Point(420, 307);
            this.dataVoltaPacote.Name = "dataVoltaPacote";
            this.dataVoltaPacote.Size = new System.Drawing.Size(133, 23);
            this.dataVoltaPacote.TabIndex = 11;
            // 
            // tbxDescricaoPacote
            // 
            this.tbxDescricaoPacote.Location = new System.Drawing.Point(136, 193);
            this.tbxDescricaoPacote.Name = "tbxDescricaoPacote";
            this.tbxDescricaoPacote.Size = new System.Drawing.Size(222, 47);
            this.tbxDescricaoPacote.TabIndex = 12;
            this.tbxDescricaoPacote.Text = "";
            // 
            // tbxValorPacote
            // 
            this.tbxValorPacote.Location = new System.Drawing.Point(122, 364);
            this.tbxValorPacote.Name = "tbxValorPacote";
            this.tbxValorPacote.Size = new System.Drawing.Size(114, 23);
            this.tbxValorPacote.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(490, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 123);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvarPacote
            // 
            this.btnSalvarPacote.Location = new System.Drawing.Point(351, 398);
            this.btnSalvarPacote.Name = "btnSalvarPacote";
            this.btnSalvarPacote.Size = new System.Drawing.Size(86, 29);
            this.btnSalvarPacote.TabIndex = 16;
            this.btnSalvarPacote.Text = "Salvar";
            this.btnSalvarPacote.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImagemPacote
            // 
            this.btnBuscarImagemPacote.Location = new System.Drawing.Point(575, 231);
            this.btnBuscarImagemPacote.Name = "btnBuscarImagemPacote";
            this.btnBuscarImagemPacote.Size = new System.Drawing.Size(105, 25);
            this.btnBuscarImagemPacote.TabIndex = 17;
            this.btnBuscarImagemPacote.Text = "Buscar Imagem";
            this.btnBuscarImagemPacote.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarImagemPacote);
            this.Controls.Add(this.btnSalvarPacote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxDescricaoPacote);
            this.Controls.Add(this.dataVoltaPacote);
            this.Controls.Add(this.dataIdaPacote);
            this.Controls.Add(this.tbxValorPacote);
            this.Controls.Add(this.lblDescricaoPacote);
            this.Controls.Add(this.lblDataVoltaPacote);
            this.Controls.Add(this.lblDataIdaPacote);
            this.Controls.Add(this.lblDestinoPacote);
            this.Controls.Add(this.lblOrigemPacote);
            this.Controls.Add(this.lblValorPacote);
            this.Controls.Add(this.cadastrarPacote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agência de Viagens - Cadastrar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastrarPacote;
        private System.Windows.Forms.Label lblValorPacote;
        private System.Windows.Forms.Label lblOrigemPacote;
        private System.Windows.Forms.Label lblDestinoPacote;
        private System.Windows.Forms.Label lblDataIdaPacote;
        private System.Windows.Forms.Label lblDataVoltaPacote;
        private System.Windows.Forms.Label lblDescricaoPacote;
        private System.Windows.Forms.DateTimePicker dataIdaPacote;
        private System.Windows.Forms.DateTimePicker dataVoltaPacote;
        private System.Windows.Forms.RichTextBox tbxDescricaoPacote;
        private System.Windows.Forms.TextBox tbxValorPacote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvarPacote;
        private System.Windows.Forms.Button btnBuscarImagemPacote;
    }
}