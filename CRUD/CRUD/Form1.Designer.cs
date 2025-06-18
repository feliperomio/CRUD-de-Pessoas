namespace CRUD
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
        private void InitializeComponent() {
            label1 = new Label();
            btnCadastrar = new Button();
            btnRemover = new Button();
            btnAtualizar = new Button();
            btnMostraID = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            ComboBoxSexo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(543, 27);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(241, 35);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(543, 77);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(241, 35);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(543, 124);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(241, 35);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnMostraID
            // 
            btnMostraID.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostraID.Location = new Point(543, 169);
            btnMostraID.Name = "btnMostraID";
            btnMostraID.Size = new Size(241, 35);
            btnMostraID.TabIndex = 5;
            btnMostraID.Text = "Mostrar no ID";
            btnMostraID.UseVisualStyleBackColor = true;
            btnMostraID.Click += btnMostraID_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(274, 23);
            txtNome.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(94, 35);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 162);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 8;
            label3.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(18, 200);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(274, 23);
            txtTelefone.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 46);
            label4.Name = "label4";
            label4.Size = new Size(87, 35);
            label4.TabIndex = 11;
            label4.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 138);
            label5.Name = "label5";
            label5.Size = new Size(49, 35);
            label5.TabIndex = 12;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(356, 176);
            txtID.Name = "txtID";
            txtID.Size = new Size(123, 23);
            txtID.TabIndex = 13;
            // 
            // ComboBoxSexo
            // 
            ComboBoxSexo.FormattingEnabled = true;
            ComboBoxSexo.Items.AddRange(new object[] { "M", "F" });
            ComboBoxSexo.Location = new Point(356, 84);
            ComboBoxSexo.Name = "ComboBoxSexo";
            ComboBoxSexo.Size = new Size(121, 23);
            ComboBoxSexo.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 241);
            Controls.Add(ComboBoxSexo);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(btnMostraID);
            Controls.Add(btnAtualizar);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastrar;
        private Button btnRemover;
        private Button btnAtualizar;
        private Button btnMostraID;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private ComboBox ComboBoxSexo;
    }
}
