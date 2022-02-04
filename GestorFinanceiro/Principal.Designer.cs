namespace GestorFinanceiro
{
    partial class Principal
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
            System.Windows.Forms.Label lblUser;
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblBalancoMensal = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoDespesas = new System.Windows.Forms.Label();
            this.lblInfoReceitas = new System.Windows.Forms.Label();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.lblInfoBalancoMensal = new System.Windows.Forms.Label();
            this.lblInfoSaldoTotal = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUser.Location = new System.Drawing.Point(255, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(150, 29);
            lblUser.TabIndex = 2;
            lblUser.Text = "Olá, nomeUser";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoTotal.Location = new System.Drawing.Point(77, 43);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(102, 25);
            this.lblSaldoTotal.TabIndex = 0;
            this.lblSaldoTotal.Text = "Saldo total";
            // 
            // lblBalancoMensal
            // 
            this.lblBalancoMensal.AutoSize = true;
            this.lblBalancoMensal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalancoMensal.Location = new System.Drawing.Point(469, 43);
            this.lblBalancoMensal.Name = "lblBalancoMensal";
            this.lblBalancoMensal.Size = new System.Drawing.Size(144, 25);
            this.lblBalancoMensal.TabIndex = 1;
            this.lblBalancoMensal.Text = "Balanço mensal";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.lblInfoBalancoMensal);
            this.pnlPrincipal.Controls.Add(this.lblInfoSaldoTotal);
            this.pnlPrincipal.Controls.Add(lblUser);
            this.pnlPrincipal.Controls.Add(this.lblSaldoTotal);
            this.pnlPrincipal.Controls.Add(this.lblBalancoMensal);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(688, 507);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInfoDespesas);
            this.panel1.Controls.Add(this.lblInfoReceitas);
            this.panel1.Controls.Add(this.lblReceitas);
            this.panel1.Controls.Add(this.lblDespesas);
            this.panel1.Location = new System.Drawing.Point(77, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 85);
            this.panel1.TabIndex = 5;
            // 
            // lblInfoDespesas
            // 
            this.lblInfoDespesas.AutoSize = true;
            this.lblInfoDespesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoDespesas.ForeColor = System.Drawing.Color.Crimson;
            this.lblInfoDespesas.Location = new System.Drawing.Point(375, 41);
            this.lblInfoDespesas.Name = "lblInfoDespesas";
            this.lblInfoDespesas.Size = new System.Drawing.Size(73, 21);
            this.lblInfoDespesas.TabIndex = 8;
            this.lblInfoDespesas.Text = "- R$ 0,00";
            // 
            // lblInfoReceitas
            // 
            this.lblInfoReceitas.AutoSize = true;
            this.lblInfoReceitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoReceitas.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblInfoReceitas.Location = new System.Drawing.Point(91, 41);
            this.lblInfoReceitas.Name = "lblInfoReceitas";
            this.lblInfoReceitas.Size = new System.Drawing.Size(78, 21);
            this.lblInfoReceitas.TabIndex = 7;
            this.lblInfoReceitas.Text = "+ R$ 0,00";
            // 
            // lblReceitas
            // 
            this.lblReceitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceitas.Location = new System.Drawing.Point(89, 16);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(96, 25);
            this.lblReceitas.TabIndex = 5;
            this.lblReceitas.Text = "RECEITAS";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDespesas.Location = new System.Drawing.Point(361, 16);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(104, 25);
            this.lblDespesas.TabIndex = 6;
            this.lblDespesas.Text = "DESPESAS";
            // 
            // lblInfoBalancoMensal
            // 
            this.lblInfoBalancoMensal.AutoSize = true;
            this.lblInfoBalancoMensal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoBalancoMensal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.lblInfoBalancoMensal.Location = new System.Drawing.Point(509, 68);
            this.lblInfoBalancoMensal.Name = "lblInfoBalancoMensal";
            this.lblInfoBalancoMensal.Size = new System.Drawing.Size(72, 25);
            this.lblInfoBalancoMensal.TabIndex = 4;
            this.lblInfoBalancoMensal.Text = "R$ 0,00";
            // 
            // lblInfoSaldoTotal
            // 
            this.lblInfoSaldoTotal.AutoSize = true;
            this.lblInfoSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoSaldoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.lblInfoSaldoTotal.Location = new System.Drawing.Point(91, 68);
            this.lblInfoSaldoTotal.Name = "lblInfoSaldoTotal";
            this.lblInfoSaldoTotal.Size = new System.Drawing.Size(72, 25);
            this.lblInfoSaldoTotal.TabIndex = 3;
            this.lblInfoSaldoTotal.Text = "R$ 0,00";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(712, 523);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor financeiro";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSaldoTotal;
        private Label lblBalancoMensal;
        private Panel pnlPrincipal;
        private Panel panel1;
        private Label lblInfoBalancoMensal;
        private Label lblInfoSaldoTotal;
        private Label lblInfoDespesas;
        private Label lblInfoReceitas;
        private Label lblReceitas;
        private Label lblDespesas;
    }
}