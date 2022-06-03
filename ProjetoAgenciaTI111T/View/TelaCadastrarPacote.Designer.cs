
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
            this.rtxDescricaoPacote = new System.Windows.Forms.RichTextBox();
            this.tbxValorPacote = new System.Windows.Forms.TextBox();
            this.pictureBoxFotoPacote = new System.Windows.Forms.PictureBox();
            this.btnSalvarPacote = new System.Windows.Forms.Button();
            this.openFileDialogImagemPacote = new System.Windows.Forms.OpenFileDialog();
            this.tbxOrigemPac = new System.Windows.Forms.TextBox();
            this.tbxDestinoPac = new System.Windows.Forms.TextBox();
            this.btnBuscarImagemPacote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPacote)).BeginInit();
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
            // rtxDescricaoPacote
            // 
            this.rtxDescricaoPacote.Location = new System.Drawing.Point(136, 193);
            this.rtxDescricaoPacote.Name = "rtxDescricaoPacote";
            this.rtxDescricaoPacote.Size = new System.Drawing.Size(222, 47);
            this.rtxDescricaoPacote.TabIndex = 12;
            this.rtxDescricaoPacote.Text = "";
            // 
            // tbxValorPacote
            // 
            this.tbxValorPacote.Location = new System.Drawing.Point(122, 364);
            this.tbxValorPacote.Name = "tbxValorPacote";
            this.tbxValorPacote.Size = new System.Drawing.Size(114, 23);
            this.tbxValorPacote.TabIndex = 7;
            // 
            // pictureBoxFotoPacote
            // 
            this.pictureBoxFotoPacote.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxFotoPacote.Location = new System.Drawing.Point(490, 87);
            this.pictureBoxFotoPacote.Name = "pictureBoxFotoPacote";
            this.pictureBoxFotoPacote.Size = new System.Drawing.Size(258, 123);
            this.pictureBoxFotoPacote.TabIndex = 15;
            this.pictureBoxFotoPacote.TabStop = false;
            // 
            // btnSalvarPacote
            // 
            this.btnSalvarPacote.Location = new System.Drawing.Point(351, 398);
            this.btnSalvarPacote.Name = "btnSalvarPacote";
            this.btnSalvarPacote.Size = new System.Drawing.Size(86, 29);
            this.btnSalvarPacote.TabIndex = 16;
            this.btnSalvarPacote.Text = "Salvar";
            this.btnSalvarPacote.UseVisualStyleBackColor = true;
            this.btnSalvarPacote.Click += new System.EventHandler(this.btnSalvarPacote_Click);
            // 
            // openFileDialogImagemPacote
            // 
            this.openFileDialogImagemPacote.FileName = "openFileDialogImagemPacote";
            // 
            // tbxOrigemPac
            // 
            this.tbxOrigemPac.Location = new System.Drawing.Point(122, 89);
            this.tbxOrigemPac.Name = "tbxOrigemPac";
            this.tbxOrigemPac.Size = new System.Drawing.Size(179, 23);
            this.tbxOrigemPac.TabIndex = 17;
            // 
            // tbxDestinoPac
            // 
            this.tbxDestinoPac.Location = new System.Drawing.Point(122, 146);
            this.tbxDestinoPac.Name = "tbxDestinoPac";
            this.tbxDestinoPac.Size = new System.Drawing.Size(179, 23);
            this.tbxDestinoPac.TabIndex = 18;
            // 
            // btnBuscarImagemPacote
            // 
            this.btnBuscarImagemPacote.Location = new System.Drawing.Point(589, 245);
            this.btnBuscarImagemPacote.Name = "btnBuscarImagemPacote";
            this.btnBuscarImagemPacote.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarImagemPacote.TabIndex = 19;
            this.btnBuscarImagemPacote.Text = "button1";
            this.btnBuscarImagemPacote.UseVisualStyleBackColor = true;
            this.btnBuscarImagemPacote.Click += new System.EventHandler(this.btnBuscarImagemPacote_Click_1);
            // 
            // TelaCadastrarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarImagemPacote);
            this.Controls.Add(this.tbxDestinoPac);
            this.Controls.Add(this.tbxOrigemPac);
            this.Controls.Add(this.btnSalvarPacote);
            this.Controls.Add(this.pictureBoxFotoPacote);
            this.Controls.Add(this.rtxDescricaoPacote);
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agência de Viagens - Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.TelaCadastrarPacote_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarPacote_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPacote)).EndInit();
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
        private System.Windows.Forms.RichTextBox rtxDescricaoPacote;
        private System.Windows.Forms.TextBox tbxValorPacote;
        private System.Windows.Forms.PictureBox pictureBoxFotoPacote;
        private System.Windows.Forms.Button btnSalvarPacote;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagemPacote;
        private System.Windows.Forms.TextBox tbxOrigemPac;
        private System.Windows.Forms.TextBox tbxDestinoPac;
        private System.Windows.Forms.Button btnBuscarImagemPacote;
    }
}