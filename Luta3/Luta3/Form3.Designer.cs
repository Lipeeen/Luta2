namespace Luta3
{
    partial class Form3
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
            this.picture_premioconsolacao = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_personagemvencedor = new System.Windows.Forms.Label();
            this.picture_vencedor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_premioconsolacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vencedor)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_premioconsolacao
            // 
            this.picture_premioconsolacao.Location = new System.Drawing.Point(357, 446);
            this.picture_premioconsolacao.Name = "picture_premioconsolacao";
            this.picture_premioconsolacao.Size = new System.Drawing.Size(236, 204);
            this.picture_premioconsolacao.TabIndex = 9;
            this.picture_premioconsolacao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prêmio de consolação para o perdedor, tente da próxima vez!";
            // 
            // lbl_personagemvencedor
            // 
            this.lbl_personagemvencedor.AutoSize = true;
            this.lbl_personagemvencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personagemvencedor.Location = new System.Drawing.Point(400, 120);
            this.lbl_personagemvencedor.Name = "lbl_personagemvencedor";
            this.lbl_personagemvencedor.Size = new System.Drawing.Size(151, 29);
            this.lbl_personagemvencedor.TabIndex = 7;
            this.lbl_personagemvencedor.Text = "Personagem";
            // 
            // picture_vencedor
            // 
            this.picture_vencedor.Location = new System.Drawing.Point(357, 152);
            this.picture_vencedor.Name = "picture_vencedor";
            this.picture_vencedor.Size = new System.Drawing.Size(236, 204);
            this.picture_vencedor.TabIndex = 6;
            this.picture_vencedor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vencedor da batalha: Player";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luta3.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(903, 678);
            this.Controls.Add(this.picture_premioconsolacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_personagemvencedor);
            this.Controls.Add(this.picture_vencedor);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.picture_premioconsolacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vencedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_premioconsolacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_personagemvencedor;
        private System.Windows.Forms.PictureBox picture_vencedor;
        private System.Windows.Forms.Label label1;
    }
}