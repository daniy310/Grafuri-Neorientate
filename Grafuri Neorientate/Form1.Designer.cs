
namespace Grafuri_Neorientate
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.buttonCitire = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonNrNoduri = new System.Windows.Forms.Button();
            this.buttonAdiacenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminareNod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAdiacenta = new System.Windows.Forms.TextBox();
            this.textBoxEliminare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(388, 44);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(299, 350);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // buttonCitire
            // 
            this.buttonCitire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCitire.Location = new System.Drawing.Point(25, 21);
            this.buttonCitire.Name = "buttonCitire";
            this.buttonCitire.Size = new System.Drawing.Size(105, 30);
            this.buttonCitire.TabIndex = 1;
            this.buttonCitire.Text = "Citire";
            this.buttonCitire.UseVisualStyleBackColor = true;
            this.buttonCitire.Click += new System.EventHandler(this.buttonCitire_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.Location = new System.Drawing.Point(25, 67);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(105, 30);
            this.buttonAfisare.TabIndex = 2;
            this.buttonAfisare.Text = "Afisare";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // buttonNrNoduri
            // 
            this.buttonNrNoduri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNrNoduri.Location = new System.Drawing.Point(25, 112);
            this.buttonNrNoduri.Name = "buttonNrNoduri";
            this.buttonNrNoduri.Size = new System.Drawing.Size(105, 30);
            this.buttonNrNoduri.TabIndex = 3;
            this.buttonNrNoduri.Text = "Nr noduri";
            this.buttonNrNoduri.UseVisualStyleBackColor = true;
            this.buttonNrNoduri.Click += new System.EventHandler(this.buttonNrNoduri_Click);
            // 
            // buttonAdiacenta
            // 
            this.buttonAdiacenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdiacenta.Location = new System.Drawing.Point(25, 162);
            this.buttonAdiacenta.Name = "buttonAdiacenta";
            this.buttonAdiacenta.Size = new System.Drawing.Size(153, 64);
            this.buttonAdiacenta.TabIndex = 4;
            this.buttonAdiacenta.Text = "Lista adiacenta nodul :";
            this.buttonAdiacenta.UseVisualStyleBackColor = true;
            this.buttonAdiacenta.Click += new System.EventHandler(this.buttonAdiacenta_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Matricea lanturilor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEliminareNod
            // 
            this.buttonEliminareNod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminareNod.Location = new System.Drawing.Point(25, 318);
            this.buttonEliminareNod.Name = "buttonEliminareNod";
            this.buttonEliminareNod.Size = new System.Drawing.Size(153, 35);
            this.buttonEliminareNod.TabIndex = 6;
            this.buttonEliminareNod.Text = "Eliminare nodul :";
            this.buttonEliminareNod.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "Graf complementar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxAdiacenta
            // 
            this.textBoxAdiacenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdiacenta.Location = new System.Drawing.Point(194, 169);
            this.textBoxAdiacenta.Name = "textBoxAdiacenta";
            this.textBoxAdiacenta.Size = new System.Drawing.Size(100, 44);
            this.textBoxAdiacenta.TabIndex = 8;
            // 
            // textBoxEliminare
            // 
            this.textBoxEliminare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEliminare.Location = new System.Drawing.Point(194, 322);
            this.textBoxEliminare.Name = "textBoxEliminare";
            this.textBoxEliminare.Size = new System.Drawing.Size(100, 31);
            this.textBoxEliminare.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.textBoxEliminare);
            this.Controls.Add(this.textBoxAdiacenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEliminareNod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdiacenta);
            this.Controls.Add(this.buttonNrNoduri);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.buttonCitire);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button buttonCitire;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonNrNoduri;
        private System.Windows.Forms.Button buttonAdiacenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEliminareNod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAdiacenta;
        private System.Windows.Forms.TextBox textBoxEliminare;
    }
}

