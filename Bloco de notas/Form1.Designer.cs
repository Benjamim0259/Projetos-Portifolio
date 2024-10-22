
namespace Bloco_de_notas
{
    partial class Form1
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
            
            label1 = new Label();
            label2 = new Label();
            TxtTitulo = new TextBox();
            TxtMensagem = new TextBox();
            dataGridView1 = new DataGridView();
            btnSalvar = new Button();
            btnLer = new Button();
            btnNovo = new Button();
            btnDeletar = new Button();
            Aviso = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(120, 88);
            label1.Name = "label1";
            label1.Size = new Size(86, 36);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(120, 152);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Mensagem:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.BackColor = SystemColors.InactiveCaption;
            TxtTitulo.Location = new Point(208, 96);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(288, 23);
            TxtTitulo.TabIndex = 2;
            // 
            // TxtMensagem
            // 
            TxtMensagem.BackColor = SystemColors.InactiveCaption;
            TxtMensagem.Location = new Point(120, 184);
            TxtMensagem.Multiline = true;
            TxtMensagem.Name = "TxtMensagem";
            TxtMensagem.Size = new Size(520, 304);
            TxtMensagem.TabIndex = 3;
            TxtMensagem.TextChanged += TxtMensagem_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(752, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(432, 384);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellEnter += DataGridView1_CellEnter;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(112, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(144, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(256, 0);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(144, 23);
            btnLer.TabIndex = 6;
            btnLer.Text = "Ler";
            btnLer.UseVisualStyleBackColor = true;
            btnLer.Click += BtnLer_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(400, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(144, 23);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(544, 0);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(144, 23);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += BtnDeletar_Click;
            // 
            // Aviso
            // 
            Aviso.AutoSize = true;
            Aviso.Font = new Font("Segoe UI", 20F);
            Aviso.ForeColor = Color.IndianRed;
            Aviso.Location = new Point(416, 544);
            Aviso.Name = "Aviso";
            Aviso.Size = new Size(498, 37);
            Aviso.TabIndex = 9;
            Aviso.Text = "Por favor insira um titulo antes de salvar!";
            Aviso.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1214, 660);
            Controls.Add(Aviso);
            Controls.Add(btnDeletar);
            Controls.Add(btnNovo);
            Controls.Add(btnLer);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(TxtMensagem);
            Controls.Add(TxtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bloco de notas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Carregar();
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            serializar();
        }



        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtTitulo;
        private TextBox TxtMensagem;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnLer;
        private Button btnNovo;
        private Button btnDeletar;
        public Label Aviso;
    }
}
