namespace Agenda_3cx
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDiscar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.DGVInicio = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInicio)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtRamal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnDiscar);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.DGVInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 400);
            this.panel1.TabIndex = 0;
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(183, 3);
            this.txtRamal.Margin = new System.Windows.Forms.Padding(4);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(80, 27);
            this.txtRamal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o Seu Ramal";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(358, 338);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 33);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDiscar
            // 
            this.btnDiscar.Location = new System.Drawing.Point(358, 291);
            this.btnDiscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscar.Name = "btnDiscar";
            this.btnDiscar.Size = new System.Drawing.Size(103, 33);
            this.btnDiscar.TabIndex = 5;
            this.btnDiscar.Text = "Discar";
            this.btnDiscar.UseVisualStyleBackColor = true;
            this.btnDiscar.Click += new System.EventHandler(this.btnDiscar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(183, 338);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(103, 33);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(183, 291);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 33);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 338);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(103, 33);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 291);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 33);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // DGVInicio
            // 
            this.DGVInicio.AllowUserToAddRows = false;
            this.DGVInicio.AllowUserToDeleteRows = false;
            this.DGVInicio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNome,
            this.ColTelefone});
            this.DGVInicio.Location = new System.Drawing.Point(12, 42);
            this.DGVInicio.Margin = new System.Windows.Forms.Padding(4);
            this.DGVInicio.Name = "DGVInicio";
            this.DGVInicio.ReadOnly = true;
            this.DGVInicio.Size = new System.Drawing.Size(449, 244);
            this.DGVInicio.TabIndex = 0;
            this.DGVInicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInicio_CellClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.DataPropertyName = "id_cadastro";
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "nome";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 150;
            // 
            // ColTelefone
            // 
            this.ColTelefone.DataPropertyName = "telefone";
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            this.ColTelefone.Width = 150;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(473, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "V 1.1";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda 3cx";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInicio)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDiscar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView DGVInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

