
namespace Clase
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
            this.ionCashLabel = new System.Windows.Forms.Label();
            this.alexCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ionGivesToAlex = new System.Windows.Forms.Button();
            this.alexGivesToIon = new System.Windows.Forms.Button();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ionCashLabel
            // 
            this.ionCashLabel.AutoSize = true;
            this.ionCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionCashLabel.Location = new System.Drawing.Point(82, 8);
            this.ionCashLabel.Name = "ionCashLabel";
            this.ionCashLabel.Size = new System.Drawing.Size(59, 31);
            this.ionCashLabel.TabIndex = 0;
            this.ionCashLabel.Text = "test";
            // 
            // alexCashLabel
            // 
            this.alexCashLabel.AutoSize = true;
            this.alexCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alexCashLabel.Location = new System.Drawing.Point(82, 46);
            this.alexCashLabel.Name = "alexCashLabel";
            this.alexCashLabel.Size = new System.Drawing.Size(86, 31);
            this.alexCashLabel.TabIndex = 0;
            this.alexCashLabel.Text = "label1";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashLabel.Location = new System.Drawing.Point(82, 87);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(86, 31);
            this.bankCashLabel.TabIndex = 0;
            this.bankCashLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ofera 10 $ lui ION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Primeste 5 $ de la Alex";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ionGivesToAlex
            // 
            this.ionGivesToAlex.Location = new System.Drawing.Point(41, 230);
            this.ionGivesToAlex.Name = "ionGivesToAlex";
            this.ionGivesToAlex.Size = new System.Drawing.Size(124, 64);
            this.ionGivesToAlex.TabIndex = 1;
            this.ionGivesToAlex.Text = "Ion  > Alex - 10$";
            this.ionGivesToAlex.UseVisualStyleBackColor = true;
            this.ionGivesToAlex.Click += new System.EventHandler(this.ionGivesToAlex_Click);
            // 
            // alexGivesToIon
            // 
            this.alexGivesToIon.Location = new System.Drawing.Point(236, 230);
            this.alexGivesToIon.Name = "alexGivesToIon";
            this.alexGivesToIon.Size = new System.Drawing.Size(124, 64);
            this.alexGivesToIon.TabIndex = 1;
            this.alexGivesToIon.Text = "Alex > Ion - 5$";
            this.alexGivesToIon.UseVisualStyleBackColor = true;
            this.alexGivesToIon.Click += new System.EventHandler(this.alexGivesToIon_Click);
            // 
            // treeView3
            // 
            this.treeView3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.treeView3.Location = new System.Drawing.Point(-2, 300);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(440, 10);
            this.treeView3.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(-2, 300);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(440, 55);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "label1";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 385);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alexGivesToIon);
            this.Controls.Add(this.ionGivesToAlex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.alexCashLabel);
            this.Controls.Add(this.ionCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ionCashLabel;
        private System.Windows.Forms.Label alexCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ionGivesToAlex;
        private System.Windows.Forms.Button alexGivesToIon;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.Label lbStatus;
    }
}

