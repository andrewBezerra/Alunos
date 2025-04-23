namespace Alunos.Windows
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
			components = new System.ComponentModel.Container();
			GridAlunos = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			enderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataNascimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataCriacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataModificacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			alunoBindingSource = new BindingSource(components);
			groupBox1 = new GroupBox();
			label6 = new Label();
			dtpDataNascimento = new DateTimePicker();
			txtTelefone = new TextBox();
			label5 = new Label();
			txtEndereco = new TextBox();
			txtEmail = new TextBox();
			txtNome = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			lblId = new Label();
			label1 = new Label();
			btnSalvar = new Button();
			btnCancelar = new Button();
			((System.ComponentModel.ISupportInitialize)GridAlunos).BeginInit();
			((System.ComponentModel.ISupportInitialize)alunoBindingSource).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// GridAlunos
			// 
			GridAlunos.AllowUserToAddRows = false;
			GridAlunos.AllowUserToDeleteRows = false;
			GridAlunos.AutoGenerateColumns = false;
			GridAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			GridAlunos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, enderecoDataGridViewTextBoxColumn, dataNascimentoDataGridViewTextBoxColumn, dataCriacaoDataGridViewTextBoxColumn, dataModificacaoDataGridViewTextBoxColumn });
			GridAlunos.DataSource = alunoBindingSource;
			GridAlunos.Location = new Point(26, 38);
			GridAlunos.Name = "GridAlunos";
			GridAlunos.ReadOnly = true;
			GridAlunos.RowHeadersWidth = 82;
			GridAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			GridAlunos.Size = new Size(1364, 420);
			GridAlunos.TabIndex = 0;
			GridAlunos.CellMouseDoubleClick += GridAlunos_CellMouseDoubleClick;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 10;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Width = 200;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			nomeDataGridViewTextBoxColumn.MinimumWidth = 10;
			nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			nomeDataGridViewTextBoxColumn.ReadOnly = true;
			nomeDataGridViewTextBoxColumn.Width = 200;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			emailDataGridViewTextBoxColumn.HeaderText = "Email";
			emailDataGridViewTextBoxColumn.MinimumWidth = 10;
			emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			emailDataGridViewTextBoxColumn.ReadOnly = true;
			emailDataGridViewTextBoxColumn.Width = 200;
			// 
			// telefoneDataGridViewTextBoxColumn
			// 
			telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
			telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
			telefoneDataGridViewTextBoxColumn.MinimumWidth = 10;
			telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
			telefoneDataGridViewTextBoxColumn.ReadOnly = true;
			telefoneDataGridViewTextBoxColumn.Width = 200;
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
			enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
			enderecoDataGridViewTextBoxColumn.MinimumWidth = 10;
			enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			enderecoDataGridViewTextBoxColumn.ReadOnly = true;
			enderecoDataGridViewTextBoxColumn.Width = 200;
			// 
			// dataNascimentoDataGridViewTextBoxColumn
			// 
			dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
			dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
			dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 10;
			dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
			dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
			dataNascimentoDataGridViewTextBoxColumn.Width = 200;
			// 
			// dataCriacaoDataGridViewTextBoxColumn
			// 
			dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
			dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
			dataCriacaoDataGridViewTextBoxColumn.MinimumWidth = 10;
			dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
			dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
			dataCriacaoDataGridViewTextBoxColumn.Width = 200;
			// 
			// dataModificacaoDataGridViewTextBoxColumn
			// 
			dataModificacaoDataGridViewTextBoxColumn.DataPropertyName = "DataModificacao";
			dataModificacaoDataGridViewTextBoxColumn.HeaderText = "DataModificacao";
			dataModificacaoDataGridViewTextBoxColumn.MinimumWidth = 10;
			dataModificacaoDataGridViewTextBoxColumn.Name = "dataModificacaoDataGridViewTextBoxColumn";
			dataModificacaoDataGridViewTextBoxColumn.ReadOnly = true;
			dataModificacaoDataGridViewTextBoxColumn.Width = 200;
			// 
			// alunoBindingSource
			// 
			alunoBindingSource.DataSource = typeof(Dominio.Entidade.Aluno);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(dtpDataNascimento);
			groupBox1.Controls.Add(txtTelefone);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtEndereco);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtNome);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(lblId);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(26, 496);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1364, 351);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Detalhes";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label6.Location = new Point(700, 103);
			label6.Name = "label6";
			label6.Size = new Size(245, 32);
			label6.TabIndex = 11;
			label6.Text = "Data de Nascimento";
			// 
			// dtpDataNascimento
			// 
			dtpDataNascimento.Location = new Point(700, 138);
			dtpDataNascimento.Name = "dtpDataNascimento";
			dtpDataNascimento.Size = new Size(630, 39);
			dtpDataNascimento.TabIndex = 10;
			// 
			// txtTelefone
			// 
			txtTelefone.Location = new Point(700, 293);
			txtTelefone.Name = "txtTelefone";
			txtTelefone.Size = new Size(630, 39);
			txtTelefone.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label5.Location = new Point(700, 263);
			label5.Name = "label5";
			label5.Size = new Size(111, 32);
			label5.TabIndex = 8;
			label5.Text = "Telefone";
			// 
			// txtEndereco
			// 
			txtEndereco.Location = new Point(41, 221);
			txtEndereco.Name = "txtEndereco";
			txtEndereco.Size = new Size(1289, 39);
			txtEndereco.TabIndex = 7;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(41, 293);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(630, 39);
			txtEmail.TabIndex = 6;
			// 
			// txtNome
			// 
			txtNome.Location = new Point(41, 138);
			txtNome.Name = "txtNome";
			txtNome.Size = new Size(630, 39);
			txtNome.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(41, 186);
			label4.Name = "label4";
			label4.Size = new Size(120, 32);
			label4.TabIndex = 4;
			label4.Text = "Endereço";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(41, 263);
			label3.Name = "label3";
			label3.Size = new Size(86, 32);
			label3.TabIndex = 3;
			label3.Text = "E-mail";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(42, 103);
			label2.Name = "label2";
			label2.Size = new Size(83, 32);
			label2.TabIndex = 2;
			label2.Text = "Nome";
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new Point(81, 51);
			lblId.Name = "lblId";
			lblId.Size = new Size(0, 32);
			lblId.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(41, 51);
			label1.Name = "label1";
			label1.Size = new Size(37, 32);
			label1.TabIndex = 0;
			label1.Text = "Id";
			// 
			// btnSalvar
			// 
			btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnSalvar.Location = new Point(1069, 876);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(150, 46);
			btnSalvar.TabIndex = 2;
			btnSalvar.Text = "&Salvar";
			btnSalvar.UseVisualStyleBackColor = true;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCancelar.Location = new Point(1240, 876);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(150, 46);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "&Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1422, 934);
			Controls.Add(btnCancelar);
			Controls.Add(btnSalvar);
			Controls.Add(groupBox1);
			Controls.Add(GridAlunos);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)GridAlunos).EndInit();
			((System.ComponentModel.ISupportInitialize)alunoBindingSource).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView GridAlunos;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataModificacaoDataGridViewTextBoxColumn;
		private BindingSource alunoBindingSource;
		private GroupBox groupBox1;
		private Label label1;
		private Label lblId;
		private TextBox txtTelefone;
		private Label label5;
		private TextBox txtEndereco;
		private TextBox txtEmail;
		private TextBox txtNome;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label6;
		private DateTimePicker dtpDataNascimento;
		private Button btnSalvar;
		private Button btnCancelar;
	}
}
