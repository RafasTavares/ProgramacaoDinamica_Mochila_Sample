namespace ProgramacaoDinamica_Mochila_0_1
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
            this.tbAlgoritmo = new System.Windows.Forms.TextBox();
            this.lAlgoritmo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAlgoritmo
            // 
            this.tbAlgoritmo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlgoritmo.Location = new System.Drawing.Point(13, 36);
            this.tbAlgoritmo.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlgoritmo.Multiline = true;
            this.tbAlgoritmo.Name = "tbAlgoritmo";
            this.tbAlgoritmo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAlgoritmo.Size = new System.Drawing.Size(758, 413);
            this.tbAlgoritmo.TabIndex = 0;
            // 
            // lAlgoritmo
            // 
            this.lAlgoritmo.AutoSize = true;
            this.lAlgoritmo.Location = new System.Drawing.Point(13, 9);
            this.lAlgoritmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAlgoritmo.Name = "lAlgoritmo";
            this.lAlgoritmo.Size = new System.Drawing.Size(65, 16);
            this.lAlgoritmo.TabIndex = 1;
            this.lAlgoritmo.Text = "Algoritmo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linguagem: C#";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lAlgoritmo);
            this.Controls.Add(this.tbAlgoritmo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Programação Dinâmica - Problema: Mochila 0-1 ou 0-1 Knapsack Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAlgoritmo;
        private System.Windows.Forms.Label lAlgoritmo;
        private System.Windows.Forms.Label label1;
    }
}