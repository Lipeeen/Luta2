namespace Luta3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.picture_vencedorround = new System.Windows.Forms.PictureBox();
            this.lbl_personagemvencedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picture_premio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vencedorround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_premio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vencedor Round 1:  Player ";
            // 
            // picture_vencedorround
            // 
            this.picture_vencedorround.Location = new System.Drawing.Point(353, 156);
            this.picture_vencedorround.Name = "picture_vencedorround";
            this.picture_vencedorround.Size = new System.Drawing.Size(236, 204);
            this.picture_vencedorround.TabIndex = 1;
            this.picture_vencedorround.TabStop = false;
            // 
            // lbl_personagemvencedor
            // 
            this.lbl_personagemvencedor.AutoSize = true;
            this.lbl_personagemvencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personagemvencedor.Location = new System.Drawing.Point(397, 124);
            this.lbl_personagemvencedor.Name = "lbl_personagemvencedor";
            this.lbl_personagemvencedor.Size = new System.Drawing.Size(151, 29);
            this.lbl_personagemvencedor.TabIndex = 2;
            this.lbl_personagemvencedor.Text = "Personagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prêmio";
            // 
            // picture_premio
            // 
            this.picture_premio.Location = new System.Drawing.Point(294, 453);
            this.picture_premio.Name = "picture_premio";
            this.picture_premio.Size = new System.Drawing.Size(364, 204);
            this.picture_premio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_premio.TabIndex = 4;
            this.picture_premio.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luta3.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(903, 678);
            this.Controls.Add(this.picture_premio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_personagemvencedor);
            this.Controls.Add(this.picture_vencedorround);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picture_vencedorround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_premio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_vencedorround;
        private System.Windows.Forms.Label lbl_personagemvencedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture_premio;
    }
}