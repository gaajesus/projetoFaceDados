namespace Dadinho_CTI
{
    partial class dado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dado));
            this.lblJog1 = new System.Windows.Forms.Label();
            this.numCred = new System.Windows.Forms.NumericUpDown();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblcred = new System.Windows.Forms.Label();
            this.lbljog2 = new System.Windows.Forms.Label();
            this.lblcred2 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.numCred2 = new System.Windows.Forms.NumericUpDown();
            this.picJog = new System.Windows.Forms.PictureBox();
            this.picJog2 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picDado = new System.Windows.Forms.PictureBox();
            this.picDajog = new System.Windows.Forms.PictureBox();
            this.picDajog2 = new System.Windows.Forms.PictureBox();
            this.lblJog = new System.Windows.Forms.Label();
            this.btnFoto1 = new System.Windows.Forms.Button();
            this.btnFoto2 = new System.Windows.Forms.Button();
            this.lblDad2 = new System.Windows.Forms.Label();
            this.lblDad = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAp = new System.Windows.Forms.Button();
            this.btnAp2 = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCred2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDajog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDajog2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJog1
            // 
            this.lblJog1.AutoSize = true;
            this.lblJog1.BackColor = System.Drawing.Color.PeachPuff;
            this.lblJog1.Font = new System.Drawing.Font("Impact", 15F);
            this.lblJog1.ForeColor = System.Drawing.Color.Tomato;
            this.lblJog1.Location = new System.Drawing.Point(88, 9);
            this.lblJog1.Name = "lblJog1";
            this.lblJog1.Size = new System.Drawing.Size(92, 25);
            this.lblJog1.TabIndex = 0;
            this.lblJog1.Text = "Jogador 1:";
            // 
            // numCred
            // 
            this.numCred.DecimalPlaces = 2;
            this.numCred.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCred.Location = new System.Drawing.Point(91, 64);
            this.numCred.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numCred.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCred.Name = "numCred";
            this.numCred.Size = new System.Drawing.Size(120, 20);
            this.numCred.TabIndex = 1;
            this.numCred.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(91, 38);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(100, 20);
            this.txtNome1.TabIndex = 2;
            // 
            // lblcred
            // 
            this.lblcred.AutoSize = true;
            this.lblcred.Location = new System.Drawing.Point(21, 66);
            this.lblcred.Name = "lblcred";
            this.lblcred.Size = new System.Drawing.Size(48, 13);
            this.lblcred.TabIndex = 3;
            this.lblcred.Text = "Créditos:";
            // 
            // lbljog2
            // 
            this.lbljog2.AutoSize = true;
            this.lbljog2.Location = new System.Drawing.Point(441, 41);
            this.lbljog2.Name = "lbljog2";
            this.lbljog2.Size = new System.Drawing.Size(57, 13);
            this.lbljog2.TabIndex = 4;
            this.lbljog2.Text = "Jogador 2:";
            // 
            // lblcred2
            // 
            this.lblcred2.AutoSize = true;
            this.lblcred2.Location = new System.Drawing.Point(441, 66);
            this.lblcred2.Name = "lblcred2";
            this.lblcred2.Size = new System.Drawing.Size(48, 13);
            this.lblcred2.TabIndex = 5;
            this.lblcred2.Text = "Créditos:";
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(504, 38);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(100, 20);
            this.txtNome2.TabIndex = 6;
            // 
            // numCred2
            // 
            this.numCred2.DecimalPlaces = 2;
            this.numCred2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCred2.Location = new System.Drawing.Point(504, 64);
            this.numCred2.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numCred2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCred2.Name = "numCred2";
            this.numCred2.Size = new System.Drawing.Size(120, 20);
            this.numCred2.TabIndex = 7;
            this.numCred2.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // picJog
            // 
            this.picJog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJog.Location = new System.Drawing.Point(245, 29);
            this.picJog.Name = "picJog";
            this.picJog.Size = new System.Drawing.Size(100, 100);
            this.picJog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog.TabIndex = 8;
            this.picJog.TabStop = false;
            // 
            // picJog2
            // 
            this.picJog2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picJog2.Location = new System.Drawing.Point(671, 29);
            this.picJog2.Name = "picJog2";
            this.picJog2.Size = new System.Drawing.Size(100, 100);
            this.picJog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJog2.TabIndex = 9;
            this.picJog2.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(49, 309);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(142, 36);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(324, 309);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(142, 36);
            this.btnJogar.TabIndex = 11;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(620, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 36);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // picDado
            // 
            this.picDado.Image = ((System.Drawing.Image)(resources.GetObject("picDado.Image")));
            this.picDado.Location = new System.Drawing.Point(337, 168);
            this.picDado.Name = "picDado";
            this.picDado.Size = new System.Drawing.Size(100, 100);
            this.picDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado.TabIndex = 13;
            this.picDado.TabStop = false;
            // 
            // picDajog
            // 
            this.picDajog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDajog.Location = new System.Drawing.Point(64, 168);
            this.picDajog.Name = "picDajog";
            this.picDajog.Size = new System.Drawing.Size(100, 100);
            this.picDajog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDajog.TabIndex = 14;
            this.picDajog.TabStop = false;
            // 
            // picDajog2
            // 
            this.picDajog2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDajog2.Location = new System.Drawing.Point(637, 168);
            this.picDajog2.Name = "picDajog2";
            this.picDajog2.Size = new System.Drawing.Size(100, 100);
            this.picDajog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDajog2.TabIndex = 15;
            this.picDajog2.TabStop = false;
            // 
            // lblJog
            // 
            this.lblJog.AutoSize = true;
            this.lblJog.Location = new System.Drawing.Point(21, 41);
            this.lblJog.Name = "lblJog";
            this.lblJog.Size = new System.Drawing.Size(57, 13);
            this.lblJog.TabIndex = 17;
            this.lblJog.Text = "Jogador 1:";
            // 
            // btnFoto1
            // 
            this.btnFoto1.Location = new System.Drawing.Point(245, 135);
            this.btnFoto1.Name = "btnFoto1";
            this.btnFoto1.Size = new System.Drawing.Size(75, 23);
            this.btnFoto1.TabIndex = 18;
            this.btnFoto1.Text = "&FOTO";
            this.btnFoto1.UseVisualStyleBackColor = true;
            this.btnFoto1.Click += new System.EventHandler(this.btnFoto1_Click);
            // 
            // btnFoto2
            // 
            this.btnFoto2.Location = new System.Drawing.Point(671, 135);
            this.btnFoto2.Name = "btnFoto2";
            this.btnFoto2.Size = new System.Drawing.Size(75, 23);
            this.btnFoto2.TabIndex = 19;
            this.btnFoto2.Text = "&FOTO";
            this.btnFoto2.UseVisualStyleBackColor = true;
            this.btnFoto2.Click += new System.EventHandler(this.btnFoto2_Click);
            // 
            // lblDad2
            // 
            this.lblDad2.AutoSize = true;
            this.lblDad2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDad2.ForeColor = System.Drawing.Color.Tomato;
            this.lblDad2.Location = new System.Drawing.Point(653, 271);
            this.lblDad2.Name = "lblDad2";
            this.lblDad2.Size = new System.Drawing.Size(53, 20);
            this.lblDad2.TabIndex = 20;
            this.lblDad2.Text = "Dado 2";
            // 
            // lblDad
            // 
            this.lblDad.AutoSize = true;
            this.lblDad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDad.ForeColor = System.Drawing.Color.Tomato;
            this.lblDad.Location = new System.Drawing.Point(80, 271);
            this.lblDad.Name = "lblDad";
            this.lblDad.Size = new System.Drawing.Size(51, 20);
            this.lblDad.TabIndex = 21;
            this.lblDad.Text = "Dado 1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAp
            // 
            this.btnAp.ForeColor = System.Drawing.Color.Red;
            this.btnAp.Location = new System.Drawing.Point(323, 135);
            this.btnAp.Name = "btnAp";
            this.btnAp.Size = new System.Drawing.Size(22, 23);
            this.btnAp.TabIndex = 22;
            this.btnAp.Text = "X";
            this.btnAp.UseVisualStyleBackColor = true;
            this.btnAp.Click += new System.EventHandler(this.btnAp_Click);
            // 
            // btnAp2
            // 
            this.btnAp2.ForeColor = System.Drawing.Color.Red;
            this.btnAp2.Location = new System.Drawing.Point(749, 135);
            this.btnAp2.Name = "btnAp2";
            this.btnAp2.Size = new System.Drawing.Size(22, 23);
            this.btnAp2.TabIndex = 23;
            this.btnAp2.Text = "X";
            this.btnAp2.UseVisualStyleBackColor = true;
            this.btnAp2.Click += new System.EventHandler(this.btnAp2_Click);
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(768, 322);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(22, 23);
            this.btnColor.TabIndex = 24;
            this.btnColor.Text = "C";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTitulo2.Font = new System.Drawing.Font("Impact", 15F);
            this.lblTitulo2.ForeColor = System.Drawing.Color.Tomato;
            this.lblTitulo2.Location = new System.Drawing.Point(509, 9);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(94, 25);
            this.lblTitulo2.TabIndex = 25;
            this.lblTitulo2.Text = "Jogador 2:";
            // 
            // dado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnAp2);
            this.Controls.Add(this.btnAp);
            this.Controls.Add(this.lblDad);
            this.Controls.Add(this.lblDad2);
            this.Controls.Add(this.btnFoto2);
            this.Controls.Add(this.btnFoto1);
            this.Controls.Add(this.lblJog);
            this.Controls.Add(this.picDajog2);
            this.Controls.Add(this.picDajog);
            this.Controls.Add(this.picDado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.picJog2);
            this.Controls.Add(this.picJog);
            this.Controls.Add(this.numCred2);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.lblcred2);
            this.Controls.Add(this.lbljog2);
            this.Controls.Add(this.lblcred);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.numCred);
            this.Controls.Add(this.lblJog1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dado";
            this.Text = "CTI Dadinho";
            ((System.ComponentModel.ISupportInitialize)(this.numCred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCred2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDajog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDajog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJog1;
        private System.Windows.Forms.NumericUpDown numCred;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblcred;
        private System.Windows.Forms.Label lbljog2;
        private System.Windows.Forms.Label lblcred2;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.NumericUpDown numCred2;
        private System.Windows.Forms.PictureBox picJog;
        private System.Windows.Forms.PictureBox picJog2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picDado;
        private System.Windows.Forms.PictureBox picDajog;
        private System.Windows.Forms.PictureBox picDajog2;
        private System.Windows.Forms.Label lblJog;
        private System.Windows.Forms.Button btnFoto1;
        private System.Windows.Forms.Button btnFoto2;
        private System.Windows.Forms.Label lblDad2;
        private System.Windows.Forms.Label lblDad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAp;
        private System.Windows.Forms.Button btnAp2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTitulo2;
    }
}

