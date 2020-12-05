namespace Agenda_3cx
{
    partial class Frm_Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pesquisa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(16, 104);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(148, 104);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(16, 55);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(207, 26);
            this.txtPesquisa.TabIndex = 3;
            // 
            // Frm_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 141);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Frm_Pesquisa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label1;
    }
}