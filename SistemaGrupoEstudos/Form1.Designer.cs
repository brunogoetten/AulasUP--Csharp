namespace SistemaGrupoEstudos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.label_aluno = new System.Windows.Forms.Label();
            this.ButtonInserir = new System.Windows.Forms.Button();
            this.listaAlunos = new System.Windows.Forms.ListView();
            this.TelefoneAluno = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeAluno
            // 
            this.NomeAluno.Location = new System.Drawing.Point(15, 32);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(100, 20);
            this.NomeAluno.TabIndex = 0;
            // 
            // label_aluno
            // 
            this.label_aluno.AutoSize = true;
            this.label_aluno.Location = new System.Drawing.Point(12, 16);
            this.label_aluno.Name = "label_aluno";
            this.label_aluno.Size = new System.Drawing.Size(79, 13);
            this.label_aluno.TabIndex = 1;
            this.label_aluno.Text = "Nome do aluno";
            // 
            // ButtonInserir
            // 
            this.ButtonInserir.Location = new System.Drawing.Point(15, 58);
            this.ButtonInserir.Name = "ButtonInserir";
            this.ButtonInserir.Size = new System.Drawing.Size(75, 23);
            this.ButtonInserir.TabIndex = 2;
            this.ButtonInserir.Text = "Salvar";
            this.ButtonInserir.UseVisualStyleBackColor = true;
            this.ButtonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);
            // 
            // listaAlunos
            // 
            this.listaAlunos.Location = new System.Drawing.Point(15, 106);
            this.listaAlunos.Name = "listaAlunos";
            this.listaAlunos.Size = new System.Drawing.Size(773, 220);
            this.listaAlunos.TabIndex = 3;
            this.listaAlunos.UseCompatibleStateImageBehavior = false;
            this.listaAlunos.SelectedIndexChanged += new System.EventHandler(this.listaAlunos_SelectedIndexChanged);
            this.listaAlunos.Leave += new System.EventHandler(this.listaAlunos_Leave);
            // 
            // TelefoneAluno
            // 
            this.TelefoneAluno.Location = new System.Drawing.Point(142, 32);
            this.TelefoneAluno.Name = "TelefoneAluno";
            this.TelefoneAluno.Size = new System.Drawing.Size(100, 20);
            this.TelefoneAluno.TabIndex = 1;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(139, 16);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(93, 13);
            this.label_telefone.TabIndex = 5;
            this.label_telefone.Text = "Telefone do aluno";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(713, 332);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 6;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Visible = false;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Location = new System.Drawing.Point(632, 332);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEditar.TabIndex = 7;
            this.BotaoEditar.Text = "Editar";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            this.BotaoEditar.Visible = false;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(96, 58);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 8;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Visible = false;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.TelefoneAluno);
            this.Controls.Add(this.listaAlunos);
            this.Controls.Add(this.ButtonInserir);
            this.Controls.Add(this.label_aluno);
            this.Controls.Add(this.NomeAluno);
            this.Name = "Form1";
            this.Text = "Cadastro de Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Label label_aluno;
        private System.Windows.Forms.Button ButtonInserir;
        private System.Windows.Forms.ListView listaAlunos;
        private System.Windows.Forms.TextBox TelefoneAluno;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}

