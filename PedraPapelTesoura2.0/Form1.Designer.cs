namespace PedraPapelTesoura2._0
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
            btn_pedra = new Button();
            btn_papel = new Button();
            btn_tesoura = new Button();
            label1 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_resultado = new TextBox();
            placar = new Label();
            label5 = new Label();
            label6 = new Label();
            placarUsuario = new TextBox();
            placarMaquina = new TextBox();
            lb_usuario = new Label();
            txt_maquina = new TextBox();
            SuspendLayout();
            // 
            // btn_pedra
            // 
            btn_pedra.Location = new Point(239, 153);
            btn_pedra.Name = "btn_pedra";
            btn_pedra.Size = new Size(112, 34);
            btn_pedra.TabIndex = 0;
            btn_pedra.Text = "Pedra";
            btn_pedra.UseVisualStyleBackColor = true;
            btn_pedra.Click += btn_pedra_Click;
            // 
            // btn_papel
            // 
            btn_papel.Location = new Point(357, 153);
            btn_papel.Name = "btn_papel";
            btn_papel.Size = new Size(112, 34);
            btn_papel.TabIndex = 1;
            btn_papel.Text = "Papel";
            btn_papel.UseVisualStyleBackColor = true;
            btn_papel.Click += btn_papel_Click;
            // 
            // btn_tesoura
            // 
            btn_tesoura.Location = new Point(475, 153);
            btn_tesoura.Name = "btn_tesoura";
            btn_tesoura.Size = new Size(112, 34);
            btn_tesoura.TabIndex = 2;
            btn_tesoura.Text = "Tesoura";
            btn_tesoura.UseVisualStyleBackColor = true;
            btn_tesoura.Click += btn_tesoura_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 113);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 3;
            label1.Text = "Escolha uma das opções:";
            // 
            // txt_usuario
            // 
            txt_usuario.Enabled = false;
            txt_usuario.Location = new Point(419, 215);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(150, 31);
            txt_usuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 261);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 7;
            label2.Text = "Escolha da máquina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 353);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 8;
            label3.Text = "Resultado:";
            // 
            // txt_resultado
            // 
            txt_resultado.Enabled = false;
            txt_resultado.Location = new Point(380, 347);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(189, 31);
            txt_resultado.TabIndex = 9;
            // 
            // placar
            // 
            placar.AutoSize = true;
            placar.Location = new Point(380, 9);
            placar.Name = "placar";
            placar.Size = new Size(58, 25);
            placar.TabIndex = 10;
            placar.Text = "Placar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 35);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 11;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 35);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 12;
            label6.Text = "Computador";
            // 
            // placarUsuario
            // 
            placarUsuario.Enabled = false;
            placarUsuario.Location = new Point(251, 63);
            placarUsuario.Name = "placarUsuario";
            placarUsuario.Size = new Size(73, 31);
            placarUsuario.TabIndex = 13;
            placarUsuario.Text = "0";
            // 
            // placarMaquina
            // 
            placarMaquina.Enabled = false;
            placarMaquina.Location = new Point(496, 63);
            placarMaquina.Name = "placarMaquina";
            placarMaquina.Size = new Size(73, 31);
            placarMaquina.TabIndex = 14;
            placarMaquina.Text = "0";
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.Location = new Point(239, 221);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(165, 25);
            lb_usuario.TabIndex = 15;
            lb_usuario.Text = "Escolha do usuário:";
            // 
            // txt_maquina
            // 
            txt_maquina.Enabled = false;
            txt_maquina.Location = new Point(419, 258);
            txt_maquina.Name = "txt_maquina";
            txt_maquina.Size = new Size(150, 31);
            txt_maquina.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_maquina);
            Controls.Add(lb_usuario);
            Controls.Add(placarMaquina);
            Controls.Add(placarUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(placar);
            Controls.Add(txt_resultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(btn_tesoura);
            Controls.Add(btn_papel);
            Controls.Add(btn_pedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pedra;
        private Button btn_papel;
        private Button btn_tesoura;
        private Label label1;
        private TextBox txt_usuario;
        private Label label2;
        private Label label3;
        private TextBox txt_resultado;
        private Label placar;
        private Label label5;
        private Label label6;
        private TextBox placarUsuario;
        private TextBox placarMaquina;
        private Label lb_usuario;
        private TextBox txt_maquina;
    }
}