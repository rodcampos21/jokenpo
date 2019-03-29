namespace Jokenpo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grupoPlacar = new System.Windows.Forms.GroupBox();
            this.placarCPU = new System.Windows.Forms.Label();
            this.placarJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.JogadaCPU = new System.Windows.Forms.GroupBox();
            this.IMGescolhaCPU = new System.Windows.Forms.PictureBox();
            this.MinhaJogada = new System.Windows.Forms.GroupBox();
            this.IMGescolhaJogador = new System.Windows.Forms.PictureBox();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoPedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grupoPlacar.SuspendLayout();
            this.JogadaCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGescolhaCPU)).BeginInit();
            this.MinhaJogada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGescolhaJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grupoPlacar);
            this.splitContainer1.Panel1.Controls.Add(this.JogadaCPU);
            this.splitContainer1.Panel1.Controls.Add(this.MinhaJogada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.botaoTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPapel);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPedra);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // grupoPlacar
            // 
            this.grupoPlacar.Controls.Add(this.placarCPU);
            this.grupoPlacar.Controls.Add(this.placarJogador);
            this.grupoPlacar.Controls.Add(this.label2);
            this.grupoPlacar.Controls.Add(this.label1);
            this.grupoPlacar.Location = new System.Drawing.Point(236, 36);
            this.grupoPlacar.Name = "grupoPlacar";
            this.grupoPlacar.Size = new System.Drawing.Size(176, 155);
            this.grupoPlacar.TabIndex = 6;
            this.grupoPlacar.TabStop = false;
            this.grupoPlacar.Text = "Placar";
            // 
            // placarCPU
            // 
            this.placarCPU.AutoSize = true;
            this.placarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarCPU.Location = new System.Drawing.Point(110, 81);
            this.placarCPU.Name = "placarCPU";
            this.placarCPU.Size = new System.Drawing.Size(49, 54);
            this.placarCPU.TabIndex = 3;
            this.placarCPU.Text = "0";
            // 
            // placarJogador
            // 
            this.placarJogador.AutoSize = true;
            this.placarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarJogador.Location = new System.Drawing.Point(22, 81);
            this.placarJogador.Name = "placarJogador";
            this.placarJogador.Size = new System.Drawing.Size(49, 54);
            this.placarJogador.TabIndex = 2;
            this.placarJogador.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            // 
            // JogadaCPU
            // 
            this.JogadaCPU.Controls.Add(this.IMGescolhaCPU);
            this.JogadaCPU.Location = new System.Drawing.Point(412, 47);
            this.JogadaCPU.Name = "JogadaCPU";
            this.JogadaCPU.Size = new System.Drawing.Size(200, 144);
            this.JogadaCPU.TabIndex = 4;
            this.JogadaCPU.TabStop = false;
            this.JogadaCPU.Text = "JogadaCPU";
            // 
            // IMGescolhaCPU
            // 
            this.IMGescolhaCPU.Location = new System.Drawing.Point(6, 12);
            this.IMGescolhaCPU.Name = "IMGescolhaCPU";
            this.IMGescolhaCPU.Size = new System.Drawing.Size(188, 126);
            this.IMGescolhaCPU.TabIndex = 5;
            this.IMGescolhaCPU.TabStop = false;
            // 
            // MinhaJogada
            // 
            this.MinhaJogada.Controls.Add(this.IMGescolhaJogador);
            this.MinhaJogada.Location = new System.Drawing.Point(30, 47);
            this.MinhaJogada.Name = "MinhaJogada";
            this.MinhaJogada.Size = new System.Drawing.Size(200, 144);
            this.MinhaJogada.TabIndex = 3;
            this.MinhaJogada.TabStop = false;
            this.MinhaJogada.Text = "MinhaJogada";
            // 
            // IMGescolhaJogador
            // 
            this.IMGescolhaJogador.Location = new System.Drawing.Point(6, 12);
            this.IMGescolhaJogador.Name = "IMGescolhaJogador";
            this.IMGescolhaJogador.Size = new System.Drawing.Size(188, 126);
            this.IMGescolhaJogador.TabIndex = 6;
            this.IMGescolhaJogador.TabStop = false;
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoTesoura.BackgroundImage")));
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoTesoura.Location = new System.Drawing.Point(426, 0);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(198, 223);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.botaoTesoura_Click);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPapel.BackgroundImage")));
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPapel.Location = new System.Drawing.Point(213, 0);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(213, 223);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.botaoPapel_Click);
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedra.BackgroundImage")));
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPedra.Location = new System.Drawing.Point(0, 0);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(213, 223);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.botaoPedra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JokenPô";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grupoPlacar.ResumeLayout(false);
            this.grupoPlacar.PerformLayout();
            this.JogadaCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMGescolhaCPU)).EndInit();
            this.MinhaJogada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMGescolhaJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.GroupBox JogadaCPU;
        private System.Windows.Forms.PictureBox IMGescolhaCPU;
        private System.Windows.Forms.GroupBox MinhaJogada;
        private System.Windows.Forms.PictureBox IMGescolhaJogador;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.GroupBox grupoPlacar;
        private System.Windows.Forms.Label placarCPU;
        private System.Windows.Forms.Label placarJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

