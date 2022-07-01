
namespace ProjetoAgenciaTI111T.View
{
    partial class TelaRegistrarVenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.tbxCodFun = new System.Windows.Forms.TextBox();
            this.tbxCodPac = new System.Windows.Forms.TextBox();
            this.tbxCodCli = new System.Windows.Forms.TextBox();
            this.buscarCodCli = new System.Windows.Forms.Button();
            this.buscarCodFun = new System.Windows.Forms.Button();
            this.buscarCodPac = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.tbxOrigem = new System.Windows.Forms.TextBox();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxValorVenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do pacote:";
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Location = new System.Drawing.Point(368, 415);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVenda.TabIndex = 3;
            this.btnRegistrarVenda.Text = "Registrar";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // tbxCodFun
            // 
            this.tbxCodFun.Location = new System.Drawing.Point(184, 202);
            this.tbxCodFun.Name = "tbxCodFun";
            this.tbxCodFun.Size = new System.Drawing.Size(100, 23);
            this.tbxCodFun.TabIndex = 5;
            // 
            // tbxCodPac
            // 
            this.tbxCodPac.Location = new System.Drawing.Point(159, 294);
            this.tbxCodPac.Name = "tbxCodPac";
            this.tbxCodPac.Size = new System.Drawing.Size(100, 23);
            this.tbxCodPac.TabIndex = 6;
            // 
            // tbxCodCli
            // 
            this.tbxCodCli.Location = new System.Drawing.Point(163, 93);
            this.tbxCodCli.Name = "tbxCodCli";
            this.tbxCodCli.Size = new System.Drawing.Size(128, 23);
            this.tbxCodCli.TabIndex = 7;
            // 
            // buscarCodCli
            // 
            this.buscarCodCli.Location = new System.Drawing.Point(306, 93);
            this.buscarCodCli.Name = "buscarCodCli";
            this.buscarCodCli.Size = new System.Drawing.Size(75, 23);
            this.buscarCodCli.TabIndex = 8;
            this.buscarCodCli.Text = "Buscar";
            this.buscarCodCli.UseVisualStyleBackColor = true;
            this.buscarCodCli.Click += new System.EventHandler(this.buscarCodCli_Click);
            // 
            // buscarCodFun
            // 
            this.buscarCodFun.Location = new System.Drawing.Point(306, 201);
            this.buscarCodFun.Name = "buscarCodFun";
            this.buscarCodFun.Size = new System.Drawing.Size(75, 23);
            this.buscarCodFun.TabIndex = 9;
            this.buscarCodFun.Text = "Buscar";
            this.buscarCodFun.UseVisualStyleBackColor = true;
            this.buscarCodFun.Click += new System.EventHandler(this.buscarCodFun_Click);
            // 
            // buscarCodPac
            // 
            this.buscarCodPac.Location = new System.Drawing.Point(282, 294);
            this.buscarCodPac.Name = "buscarCodPac";
            this.buscarCodPac.Size = new System.Drawing.Size(75, 23);
            this.buscarCodPac.TabIndex = 10;
            this.buscarCodPac.Text = "Buscar";
            this.buscarCodPac.UseVisualStyleBackColor = true;
            this.buscarCodPac.Click += new System.EventHandler(this.buscarCodPac_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registrar Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome do funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Origem do pacote:";
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(163, 139);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(254, 23);
            this.tbxNomeCli.TabIndex = 15;
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(178, 234);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(247, 23);
            this.tbxNomeFun.TabIndex = 16;
            // 
            // tbxOrigem
            // 
            this.tbxOrigem.Location = new System.Drawing.Point(184, 342);
            this.tbxOrigem.Name = "tbxOrigem";
            this.tbxOrigem.Size = new System.Drawing.Size(217, 23);
            this.tbxOrigem.TabIndex = 17;
            // 
            // tbxDestino
            // 
            this.tbxDestino.Location = new System.Drawing.Point(184, 376);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(217, 23);
            this.tbxDestino.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Destino do pacote:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Valor:";
            // 
            // tbxValorVenda
            // 
            this.tbxValorVenda.Location = new System.Drawing.Point(123, 41);
            this.tbxValorVenda.Name = "tbxValorVenda";
            this.tbxValorVenda.Size = new System.Drawing.Size(100, 23);
            this.tbxValorVenda.TabIndex = 21;
            // 
            // TelaRegistrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxValorVenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxDestino);
            this.Controls.Add(this.tbxOrigem);
            this.Controls.Add(this.tbxNomeFun);
            this.Controls.Add(this.tbxNomeCli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarCodPac);
            this.Controls.Add(this.buscarCodFun);
            this.Controls.Add(this.buscarCodCli);
            this.Controls.Add(this.tbxCodCli);
            this.Controls.Add(this.tbxCodPac);
            this.Controls.Add(this.tbxCodFun);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaRegistrarVenda";
            this.Text = "TelaRegistrarVenda";
            this.Load += new System.EventHandler(this.TelaRegistrarVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarVenda;
        private System.Windows.Forms.TextBox tbxCodFun;
        private System.Windows.Forms.TextBox tbxCodPac;
        private System.Windows.Forms.TextBox tbxCodCli;
        private System.Windows.Forms.Button buscarCodCli;
        private System.Windows.Forms.Button buscarCodFun;
        private System.Windows.Forms.Button buscarCodPac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.TextBox tbxOrigem;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxValorVenda;
    }
}