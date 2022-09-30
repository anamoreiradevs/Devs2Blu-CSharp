namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonTop = new FontAwesome.Sharp.IconButton();
            this.labelNomeDoJogo = new System.Windows.Forms.Label();
            this.iconBtnPrimeiroPlayer = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResultadoJogo = new System.Windows.Forms.Button();
            this.btnSalvarNumPrimeiroPlayer = new System.Windows.Forms.Button();
            this.btnSalvarNumSegundoPlayer = new System.Windows.Forms.Button();
            this.txtNumeroPrimeiroPlayer = new System.Windows.Forms.TextBox();
            this.txtNumeroSegundoPlayer = new System.Windows.Forms.TextBox();
            this.txtInformacoesJogo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantidadeVitorias2Player = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVitorias1Player = new System.Windows.Forms.TextBox();
            this.btnQuantidadeVitorias2Player = new FontAwesome.Sharp.IconButton();
            this.label2Vencedor = new System.Windows.Forms.Label();
            this.btnQuantidadeVitorias1Player = new FontAwesome.Sharp.IconButton();
            this.label2PontuacaoSegundoPlayer = new System.Windows.Forms.Label();
            this.labelPontuacaoPrimeiroPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnSegundoPlayer = new FontAwesome.Sharp.IconButton();
            this.iconBtnVencedor = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.iconButtonTop);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(744, 99);
            this.panelMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(449, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "JOGO DO 21";
            // 
            // iconButtonTop
            // 
            this.iconButtonTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTop.FlatAppearance.BorderSize = 0;
            this.iconButtonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTop.IconChar = FontAwesome.Sharp.IconChar.DiceD20;
            this.iconButtonTop.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTop.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTop.Name = "iconButtonTop";
            this.iconButtonTop.Size = new System.Drawing.Size(99, 99);
            this.iconButtonTop.TabIndex = 0;
            this.iconButtonTop.UseVisualStyleBackColor = true;
            this.iconButtonTop.Click += new System.EventHandler(this.iconButtonTop_Click);
            // 
            // labelNomeDoJogo
            // 
            this.labelNomeDoJogo.AutoSize = true;
            this.labelNomeDoJogo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeDoJogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNomeDoJogo.Location = new System.Drawing.Point(105, 24);
            this.labelNomeDoJogo.Name = "labelNomeDoJogo";
            this.labelNomeDoJogo.Size = new System.Drawing.Size(105, 21);
            this.labelNomeDoJogo.TabIndex = 1;
            this.labelNomeDoJogo.Text = "JOGO DO 21";
            this.labelNomeDoJogo.Click += new System.EventHandler(this.labelNomeDoJogo_Click);
            // 
            // iconBtnPrimeiroPlayer
            // 
            this.iconBtnPrimeiroPlayer.FlatAppearance.BorderSize = 0;
            this.iconBtnPrimeiroPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPrimeiroPlayer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconBtnPrimeiroPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnPrimeiroPlayer.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconBtnPrimeiroPlayer.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconBtnPrimeiroPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPrimeiroPlayer.IconSize = 35;
            this.iconBtnPrimeiroPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPrimeiroPlayer.Location = new System.Drawing.Point(3, 92);
            this.iconBtnPrimeiroPlayer.Name = "iconBtnPrimeiroPlayer";
            this.iconBtnPrimeiroPlayer.Size = new System.Drawing.Size(114, 34);
            this.iconBtnPrimeiroPlayer.TabIndex = 1;
            this.iconBtnPrimeiroPlayer.Text = "0";
            this.iconBtnPrimeiroPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPrimeiroPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPrimeiroPlayer.UseVisualStyleBackColor = true;
            this.iconBtnPrimeiroPlayer.Click += new System.EventHandler(this.iconButtonSecondPlayer_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.btnResultadoJogo);
            this.panel2.Controls.Add(this.labelNomeDoJogo);
            this.panel2.Controls.Add(this.btnSalvarNumPrimeiroPlayer);
            this.panel2.Controls.Add(this.btnSalvarNumSegundoPlayer);
            this.panel2.Controls.Add(this.txtNumeroPrimeiroPlayer);
            this.panel2.Controls.Add(this.txtNumeroSegundoPlayer);
            this.panel2.Location = new System.Drawing.Point(344, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 271);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnResultadoJogo
            // 
            this.btnResultadoJogo.AllowDrop = true;
            this.btnResultadoJogo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResultadoJogo.Location = new System.Drawing.Point(120, 228);
            this.btnResultadoJogo.Name = "btnResultadoJogo";
            this.btnResultadoJogo.Size = new System.Drawing.Size(90, 27);
            this.btnResultadoJogo.TabIndex = 10;
            this.btnResultadoJogo.Text = "Resultado";
            this.btnResultadoJogo.UseVisualStyleBackColor = true;
            this.btnResultadoJogo.Click += new System.EventHandler(this.btnResultadoJogo_Click);
            // 
            // btnSalvarNumPrimeiroPlayer
            // 
            this.btnSalvarNumPrimeiroPlayer.AllowDrop = true;
            this.btnSalvarNumPrimeiroPlayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarNumPrimeiroPlayer.Location = new System.Drawing.Point(129, 117);
            this.btnSalvarNumPrimeiroPlayer.Name = "btnSalvarNumPrimeiroPlayer";
            this.btnSalvarNumPrimeiroPlayer.Size = new System.Drawing.Size(70, 20);
            this.btnSalvarNumPrimeiroPlayer.TabIndex = 9;
            this.btnSalvarNumPrimeiroPlayer.Text = "Enviar";
            this.btnSalvarNumPrimeiroPlayer.UseVisualStyleBackColor = true;
            this.btnSalvarNumPrimeiroPlayer.Click += new System.EventHandler(this.btnSalvarNumPrimeiroPlayer_Click);
            // 
            // btnSalvarNumSegundoPlayer
            // 
            this.btnSalvarNumSegundoPlayer.AllowDrop = true;
            this.btnSalvarNumSegundoPlayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarNumSegundoPlayer.Location = new System.Drawing.Point(129, 185);
            this.btnSalvarNumSegundoPlayer.Name = "btnSalvarNumSegundoPlayer";
            this.btnSalvarNumSegundoPlayer.Size = new System.Drawing.Size(70, 20);
            this.btnSalvarNumSegundoPlayer.TabIndex = 8;
            this.btnSalvarNumSegundoPlayer.Text = "Enviar";
            this.btnSalvarNumSegundoPlayer.UseVisualStyleBackColor = true;
            this.btnSalvarNumSegundoPlayer.Click += new System.EventHandler(this.btnSalvarNumSegundoPlayer_Click);
            // 
            // txtNumeroPrimeiroPlayer
            // 
            this.txtNumeroPrimeiroPlayer.Location = new System.Drawing.Point(96, 88);
            this.txtNumeroPrimeiroPlayer.Name = "txtNumeroPrimeiroPlayer";
            this.txtNumeroPrimeiroPlayer.PlaceholderText = "Player 1:";
            this.txtNumeroPrimeiroPlayer.Size = new System.Drawing.Size(129, 23);
            this.txtNumeroPrimeiroPlayer.TabIndex = 4;
            this.txtNumeroPrimeiroPlayer.TextChanged += new System.EventHandler(this.txtNumeroUsuario_TextChanged);
            // 
            // txtNumeroSegundoPlayer
            // 
            this.txtNumeroSegundoPlayer.Location = new System.Drawing.Point(96, 156);
            this.txtNumeroSegundoPlayer.Name = "txtNumeroSegundoPlayer";
            this.txtNumeroSegundoPlayer.PlaceholderText = "Player 2:";
            this.txtNumeroSegundoPlayer.Size = new System.Drawing.Size(129, 23);
            this.txtNumeroSegundoPlayer.TabIndex = 4;
            this.txtNumeroSegundoPlayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInformacoesJogo
            // 
            this.txtInformacoesJogo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInformacoesJogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformacoesJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInformacoesJogo.ForeColor = System.Drawing.Color.Black;
            this.txtInformacoesJogo.Location = new System.Drawing.Point(344, 197);
            this.txtInformacoesJogo.Name = "txtInformacoesJogo";
            this.txtInformacoesJogo.Size = new System.Drawing.Size(331, 22);
            this.txtInformacoesJogo.TabIndex = 7;
            this.txtInformacoesJogo.Text = "Insira um número no intervalo de 1 até 20 ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.txtQuantidadeVitorias2Player);
            this.panel3.Controls.Add(this.txtQuantidadeVitorias1Player);
            this.panel3.Controls.Add(this.btnQuantidadeVitorias2Player);
            this.panel3.Controls.Add(this.label2Vencedor);
            this.panel3.Controls.Add(this.btnQuantidadeVitorias1Player);
            this.panel3.Controls.Add(this.label2PontuacaoSegundoPlayer);
            this.panel3.Controls.Add(this.labelPontuacaoPrimeiroPlayer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.iconBtnSegundoPlayer);
            this.panel3.Controls.Add(this.iconBtnVencedor);
            this.panel3.Controls.Add(this.iconBtnPrimeiroPlayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 486);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtQuantidadeVitorias2Player
            // 
            this.txtQuantidadeVitorias2Player.Location = new System.Drawing.Point(120, 340);
            this.txtQuantidadeVitorias2Player.Name = "txtQuantidadeVitorias2Player";
            this.txtQuantidadeVitorias2Player.Size = new System.Drawing.Size(70, 23);
            this.txtQuantidadeVitorias2Player.TabIndex = 4;
            // 
            // txtQuantidadeVitorias1Player
            // 
            this.txtQuantidadeVitorias1Player.Location = new System.Drawing.Point(123, 275);
            this.txtQuantidadeVitorias1Player.Name = "txtQuantidadeVitorias1Player";
            this.txtQuantidadeVitorias1Player.Size = new System.Drawing.Size(70, 23);
            this.txtQuantidadeVitorias1Player.TabIndex = 5;
            // 
            // btnQuantidadeVitorias2Player
            // 
            this.btnQuantidadeVitorias2Player.FlatAppearance.BorderSize = 0;
            this.btnQuantidadeVitorias2Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantidadeVitorias2Player.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuantidadeVitorias2Player.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuantidadeVitorias2Player.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnQuantidadeVitorias2Player.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnQuantidadeVitorias2Player.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuantidadeVitorias2Player.IconSize = 35;
            this.btnQuantidadeVitorias2Player.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidadeVitorias2Player.Location = new System.Drawing.Point(0, 332);
            this.btnQuantidadeVitorias2Player.Name = "btnQuantidadeVitorias2Player";
            this.btnQuantidadeVitorias2Player.Size = new System.Drawing.Size(114, 34);
            this.btnQuantidadeVitorias2Player.TabIndex = 7;
            this.btnQuantidadeVitorias2Player.Text = "Player 2";
            this.btnQuantidadeVitorias2Player.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidadeVitorias2Player.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuantidadeVitorias2Player.UseVisualStyleBackColor = true;
            // 
            // label2Vencedor
            // 
            this.label2Vencedor.AutoSize = true;
            this.label2Vencedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2Vencedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2Vencedor.Location = new System.Drawing.Point(2, 387);
            this.label2Vencedor.Name = "label2Vencedor";
            this.label2Vencedor.Size = new System.Drawing.Size(97, 25);
            this.label2Vencedor.TabIndex = 6;
            this.label2Vencedor.Text = "Vencedor";
            // 
            // btnQuantidadeVitorias1Player
            // 
            this.btnQuantidadeVitorias1Player.FlatAppearance.BorderSize = 0;
            this.btnQuantidadeVitorias1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantidadeVitorias1Player.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuantidadeVitorias1Player.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuantidadeVitorias1Player.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnQuantidadeVitorias1Player.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnQuantidadeVitorias1Player.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuantidadeVitorias1Player.IconSize = 35;
            this.btnQuantidadeVitorias1Player.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidadeVitorias1Player.Location = new System.Drawing.Point(0, 264);
            this.btnQuantidadeVitorias1Player.Name = "btnQuantidadeVitorias1Player";
            this.btnQuantidadeVitorias1Player.Size = new System.Drawing.Size(114, 34);
            this.btnQuantidadeVitorias1Player.TabIndex = 6;
            this.btnQuantidadeVitorias1Player.Text = "Player 1";
            this.btnQuantidadeVitorias1Player.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidadeVitorias1Player.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuantidadeVitorias1Player.UseVisualStyleBackColor = true;
            // 
            // label2PontuacaoSegundoPlayer
            // 
            this.label2PontuacaoSegundoPlayer.AutoSize = true;
            this.label2PontuacaoSegundoPlayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2PontuacaoSegundoPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2PontuacaoSegundoPlayer.Location = new System.Drawing.Point(3, 139);
            this.label2PontuacaoSegundoPlayer.Name = "label2PontuacaoSegundoPlayer";
            this.label2PontuacaoSegundoPlayer.Size = new System.Drawing.Size(174, 17);
            this.label2PontuacaoSegundoPlayer.TabIndex = 5;
            this.label2PontuacaoSegundoPlayer.Text = "Pontuaçao SegundoPlayer:";
            // 
            // labelPontuacaoPrimeiroPlayer
            // 
            this.labelPontuacaoPrimeiroPlayer.AutoSize = true;
            this.labelPontuacaoPrimeiroPlayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPontuacaoPrimeiroPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPontuacaoPrimeiroPlayer.Location = new System.Drawing.Point(0, 52);
            this.labelPontuacaoPrimeiroPlayer.Name = "labelPontuacaoPrimeiroPlayer";
            this.labelPontuacaoPrimeiroPlayer.Size = new System.Drawing.Size(177, 17);
            this.labelPontuacaoPrimeiroPlayer.TabIndex = 4;
            this.labelPontuacaoPrimeiroPlayer.Text = "Pontuaçao Primeiro Player:";
            this.labelPontuacaoPrimeiroPlayer.Click += new System.EventHandler(this.labelPontuaçaoPrimeiroPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Rodadas Ganhas:";
            // 
            // iconBtnSegundoPlayer
            // 
            this.iconBtnSegundoPlayer.FlatAppearance.BorderSize = 0;
            this.iconBtnSegundoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSegundoPlayer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconBtnSegundoPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSegundoPlayer.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconBtnSegundoPlayer.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconBtnSegundoPlayer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSegundoPlayer.IconSize = 35;
            this.iconBtnSegundoPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSegundoPlayer.Location = new System.Drawing.Point(3, 172);
            this.iconBtnSegundoPlayer.Name = "iconBtnSegundoPlayer";
            this.iconBtnSegundoPlayer.Size = new System.Drawing.Size(114, 34);
            this.iconBtnSegundoPlayer.TabIndex = 3;
            this.iconBtnSegundoPlayer.Text = "0";
            this.iconBtnSegundoPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSegundoPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSegundoPlayer.UseVisualStyleBackColor = true;
            this.iconBtnSegundoPlayer.Click += new System.EventHandler(this.iconButtonFirstPlayer_Click);
            // 
            // iconBtnVencedor
            // 
            this.iconBtnVencedor.FlatAppearance.BorderSize = 0;
            this.iconBtnVencedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnVencedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconBtnVencedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnVencedor.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.iconBtnVencedor.IconColor = System.Drawing.Color.NavajoWhite;
            this.iconBtnVencedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnVencedor.IconSize = 50;
            this.iconBtnVencedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnVencedor.Location = new System.Drawing.Point(3, 415);
            this.iconBtnVencedor.Name = "iconBtnVencedor";
            this.iconBtnVencedor.Size = new System.Drawing.Size(166, 59);
            this.iconBtnVencedor.TabIndex = 2;
            this.iconBtnVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnVencedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnVencedor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(271, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 32);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(744, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInformacoesJogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonTop;
        private Label labelNomeDoJogo;
        private FontAwesome.Sharp.IconButton iconBtnPrimeiroPlayer;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnVencedor;
        private FontAwesome.Sharp.IconButton iconBtnSegundoPlayer;
        private TextBox txtNumeroPrimeiroPlayer;
        private TextBox txtNumeroSegundoPlayer;
        private Label labelPontuacaoPrimeiroPlayer;
        private Label label2PontuacaoSegundoPlayer;
        private Label label2Vencedor;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSalvarNumSegundoPlayer;
        private TextBox txtInformacoesJogo;
        private Label label1;
        private TextBox txtQuantidadeVitorias1Player;
        private TextBox txtQuantidadeVitorias2Player;
        private FontAwesome.Sharp.IconButton btnQuantidadeVitorias2Player;
        private FontAwesome.Sharp.IconButton btnQuantidadeVitorias1Player;
        private Button btnSalvarNumPrimeiroPlayer;
        private Label label2;
        private Button btnResultadoJogo;
    }
}