namespace TesteMariana.WinApp.Funcionalidades.Questoes
{
    partial class CadastroQuestaoDialog
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverAlternativa = new System.Windows.Forms.Button();
            this.btnAdicionarAlteranativa = new System.Windows.Forms.Button();
            this.cbCorreta = new System.Windows.Forms.CheckBox();
            this.listAlternativas = new System.Windows.Forms.ListBox();
            this.cmbLetras = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(409, 304);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 21);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(308, 304);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 21);
            this.btnOk.TabIndex = 71;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cmbBimestre
            // 
            this.cmbBimestre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimestre.FormattingEnabled = true;
            this.cmbBimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbBimestre.Location = new System.Drawing.Point(425, 51);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(74, 21);
            this.cmbBimestre.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemoverAlternativa);
            this.groupBox1.Controls.Add(this.btnAdicionarAlteranativa);
            this.groupBox1.Controls.Add(this.cbCorreta);
            this.groupBox1.Controls.Add(this.listAlternativas);
            this.groupBox1.Controls.Add(this.cmbLetras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtResposta);
            this.groupBox1.Location = new System.Drawing.Point(30, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 172);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // btnRemoverAlternativa
            // 
            this.btnRemoverAlternativa.Image = global::TesteMariana.WinApp.Properties.Resources.Symbol_Delete;
            this.btnRemoverAlternativa.Location = new System.Drawing.Point(413, 17);
            this.btnRemoverAlternativa.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverAlternativa.Name = "btnRemoverAlternativa";
            this.btnRemoverAlternativa.Size = new System.Drawing.Size(39, 33);
            this.btnRemoverAlternativa.TabIndex = 74;
            this.btnRemoverAlternativa.UseVisualStyleBackColor = true;
            this.btnRemoverAlternativa.Click += new System.EventHandler(this.btnRemoverAlternativa_Click);
            // 
            // btnAdicionarAlteranativa
            // 
            this.btnAdicionarAlteranativa.Image = global::TesteMariana.WinApp.Properties.Resources.Symbol_Add;
            this.btnAdicionarAlteranativa.Location = new System.Drawing.Point(371, 17);
            this.btnAdicionarAlteranativa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarAlteranativa.Name = "btnAdicionarAlteranativa";
            this.btnAdicionarAlteranativa.Size = new System.Drawing.Size(39, 33);
            this.btnAdicionarAlteranativa.TabIndex = 73;
            this.btnAdicionarAlteranativa.UseVisualStyleBackColor = true;
            this.btnAdicionarAlteranativa.Click += new System.EventHandler(this.btnAdicionarAlteranativa_Click);
            // 
            // cbCorreta
            // 
            this.cbCorreta.AutoSize = true;
            this.cbCorreta.Location = new System.Drawing.Point(255, 27);
            this.cbCorreta.Name = "cbCorreta";
            this.cbCorreta.Size = new System.Drawing.Size(113, 17);
            this.cbCorreta.TabIndex = 52;
            this.cbCorreta.Text = "Alternativa Correta";
            this.cbCorreta.UseVisualStyleBackColor = true;
            // 
            // listAlternativas
            // 
            this.listAlternativas.FormattingEnabled = true;
            this.listAlternativas.Location = new System.Drawing.Point(6, 84);
            this.listAlternativas.Name = "listAlternativas";
            this.listAlternativas.Size = new System.Drawing.Size(447, 82);
            this.listAlternativas.TabIndex = 24;
            // 
            // cmbLetras
            // 
            this.cmbLetras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLetras.DisplayMember = "value";
            this.cmbLetras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetras.FormattingEnabled = true;
            this.cmbLetras.Location = new System.Drawing.Point(72, 26);
            this.cmbLetras.Name = "cmbLetras";
            this.cmbLetras.Size = new System.Drawing.Size(157, 21);
            this.cmbLetras.TabIndex = 19;
            this.cmbLetras.ValueMember = "DescricaoAlternativa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Letra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResposta.BackColor = System.Drawing.Color.LightYellow;
            this.txtResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResposta.Location = new System.Drawing.Point(72, 55);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(382, 20);
            this.txtResposta.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(97, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(119, 20);
            this.txtId.TabIndex = 63;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Bimestre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Enunciado:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(97, 49);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(255, 21);
            this.cmbMateria.TabIndex = 65;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnunciado.BackColor = System.Drawing.Color.LightYellow;
            this.txtEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnunciado.Location = new System.Drawing.Point(97, 77);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(402, 44);
            this.txtEnunciado.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Matéria:";
            // 
            // CadastroQuestaoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 337);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbBimestre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroQuestaoDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Questões";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCorreta;
        private System.Windows.Forms.ListBox listAlternativas;
        private System.Windows.Forms.ComboBox cmbLetras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionarAlteranativa;
        private System.Windows.Forms.Button btnRemoverAlternativa;
    }
}