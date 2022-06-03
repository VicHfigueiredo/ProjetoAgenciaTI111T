
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaCadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarFuncionario));
            this.lblCadastriFuncionario = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.lblSenhaFuncionario = new System.Windows.Forms.Label();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.tbxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.tbxEmailFuncionario = new System.Windows.Forms.TextBox();
            this.tbxSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCadastriFuncionario
            // 
            this.lblCadastriFuncionario.AutoSize = true;
            this.lblCadastriFuncionario.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastriFuncionario.Location = new System.Drawing.Point(283, 28);
            this.lblCadastriFuncionario.Name = "lblCadastriFuncionario";
            this.lblCadastriFuncionario.Size = new System.Drawing.Size(264, 30);
            this.lblCadastriFuncionario.TabIndex = 0;
            this.lblCadastriFuncionario.Text = "Cadastro de Funcionário";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFuncionario.Location = new System.Drawing.Point(134, 123);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(61, 23);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "Nome:";
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.AutoSize = true;
            this.lblEmailFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailFuncionario.Location = new System.Drawing.Point(135, 183);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.Size = new System.Drawing.Size(55, 23);
            this.lblEmailFuncionario.TabIndex = 2;
            this.lblEmailFuncionario.Text = "Email:";
            // 
            // lblSenhaFuncionario
            // 
            this.lblSenhaFuncionario.AutoSize = true;
            this.lblSenhaFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenhaFuncionario.Location = new System.Drawing.Point(135, 238);
            this.lblSenhaFuncionario.Name = "lblSenhaFuncionario";
            this.lblSenhaFuncionario.Size = new System.Drawing.Size(61, 23);
            this.lblSenhaFuncionario.TabIndex = 3;
            this.lblSenhaFuncionario.Text = "Senha:";
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(520, 289);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(94, 28);
            this.btnSalvarFuncionario.TabIndex = 4;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // tbxNomeFuncionario
            // 
            this.tbxNomeFuncionario.Location = new System.Drawing.Point(206, 126);
            this.tbxNomeFuncionario.Name = "tbxNomeFuncionario";
            this.tbxNomeFuncionario.Size = new System.Drawing.Size(368, 23);
            this.tbxNomeFuncionario.TabIndex = 6;
            // 
            // tbxEmailFuncionario
            // 
            this.tbxEmailFuncionario.Location = new System.Drawing.Point(206, 186);
            this.tbxEmailFuncionario.Name = "tbxEmailFuncionario";
            this.tbxEmailFuncionario.Size = new System.Drawing.Size(368, 23);
            this.tbxEmailFuncionario.TabIndex = 7;
            // 
            // tbxSenhaFuncionario
            // 
            this.tbxSenhaFuncionario.Location = new System.Drawing.Point(206, 241);
            this.tbxSenhaFuncionario.Name = "tbxSenhaFuncionario";
            this.tbxSenhaFuncionario.Size = new System.Drawing.Size(155, 23);
            this.tbxSenhaFuncionario.TabIndex = 8;
            // 
            // TelaCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSenhaFuncionario);
            this.Controls.Add(this.tbxEmailFuncionario);
            this.Controls.Add(this.tbxNomeFuncionario);
            this.Controls.Add(this.btnSalvarFuncionario);
            this.Controls.Add(this.lblSenhaFuncionario);
            this.Controls.Add(this.lblEmailFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblCadastriFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agência de Viagens -Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.TelaCadastrarFuncionario_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarFuncionario_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastriFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.Label lblSenhaFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.TextBox tbxNomeFuncionario;
        private System.Windows.Forms.TextBox tbxEmailFuncionario;
        private System.Windows.Forms.TextBox tbxSenhaFuncionario;
    }
}