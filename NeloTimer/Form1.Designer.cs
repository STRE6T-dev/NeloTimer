
namespace NeloTimer
{
    partial class frmNeloFoceser
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
            this.lblDeathmatch = new System.Windows.Forms.Label();
            this.lblAimLabs = new System.Windows.Forms.Label();
            this.lblStudy = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.btDeathMatch = new System.Windows.Forms.Button();
            this.btAimLabs = new System.Windows.Forms.Button();
            this.btStudy = new System.Windows.Forms.Button();
            this.btBreak = new System.Windows.Forms.Button();
            this.btnDeathMatch = new System.Windows.Forms.TextBox();
            this.btnAimLab = new System.Windows.Forms.TextBox();
            this.btnBreak = new System.Windows.Forms.TextBox();
            this.btnStudy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDeathmatch
            // 
            this.lblDeathmatch.AutoSize = true;
            this.lblDeathmatch.Location = new System.Drawing.Point(223, 9);
            this.lblDeathmatch.Name = "lblDeathmatch";
            this.lblDeathmatch.Size = new System.Drawing.Size(75, 15);
            this.lblDeathmatch.TabIndex = 0;
            this.lblDeathmatch.Text = "Death Match";
            // 
            // lblAimLabs
            // 
            this.lblAimLabs.AutoSize = true;
            this.lblAimLabs.Location = new System.Drawing.Point(424, 9);
            this.lblAimLabs.Name = "lblAimLabs";
            this.lblAimLabs.Size = new System.Drawing.Size(51, 15);
            this.lblAimLabs.TabIndex = 1;
            this.lblAimLabs.Text = "Aim Lab";
            // 
            // lblStudy
            // 
            this.lblStudy.AutoSize = true;
            this.lblStudy.Location = new System.Drawing.Point(234, 126);
            this.lblStudy.Name = "lblStudy";
            this.lblStudy.Size = new System.Drawing.Size(37, 15);
            this.lblStudy.TabIndex = 2;
            this.lblStudy.Text = "Study";
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Location = new System.Drawing.Point(400, 126);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(75, 15);
            this.lblBreak.TabIndex = 3;
            this.lblBreak.Text = "Break 10 min";
            // 
            // btDeathMatch
            // 
            this.btDeathMatch.Location = new System.Drawing.Point(187, 68);
            this.btDeathMatch.Name = "btDeathMatch";
            this.btDeathMatch.Size = new System.Drawing.Size(138, 23);
            this.btDeathMatch.TabIndex = 4;
            this.btDeathMatch.Text = "Start Death Match";
            this.btDeathMatch.UseVisualStyleBackColor = true;
            this.btDeathMatch.Click += new System.EventHandler(this.btDeathMatch_Click);
            // 
            // btAimLabs
            // 
            this.btAimLabs.Location = new System.Drawing.Point(367, 68);
            this.btAimLabs.Name = "btAimLabs";
            this.btAimLabs.Size = new System.Drawing.Size(157, 23);
            this.btAimLabs.TabIndex = 5;
            this.btAimLabs.Text = "Start Aim Labs";
            this.btAimLabs.UseVisualStyleBackColor = true;
            this.btAimLabs.Click += new System.EventHandler(this.btAimLabs_Click);
            // 
            // btStudy
            // 
            this.btStudy.Location = new System.Drawing.Point(187, 188);
            this.btStudy.Name = "btStudy";
            this.btStudy.Size = new System.Drawing.Size(138, 23);
            this.btStudy.TabIndex = 6;
            this.btStudy.Text = "Start Study";
            this.btStudy.UseVisualStyleBackColor = true;
            this.btStudy.Click += new System.EventHandler(this.btStudy_Click);
            // 
            // btBreak
            // 
            this.btBreak.Location = new System.Drawing.Point(367, 188);
            this.btBreak.Name = "btBreak";
            this.btBreak.Size = new System.Drawing.Size(157, 23);
            this.btBreak.TabIndex = 7;
            this.btBreak.Text = "Start Break";
            this.btBreak.UseVisualStyleBackColor = true;
            this.btBreak.Click += new System.EventHandler(this.btBreak_Click);
            // 
            // btnDeathMatch
            // 
            this.btnDeathMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeathMatch.Location = new System.Drawing.Point(187, 33);
            this.btnDeathMatch.Name = "btnDeathMatch";
            this.btnDeathMatch.ReadOnly = true;
            this.btnDeathMatch.Size = new System.Drawing.Size(138, 29);
            this.btnDeathMatch.TabIndex = 8;
            this.btnDeathMatch.Text = "00:00:00";
            this.btnDeathMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAimLab
            // 
            this.btnAimLab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAimLab.Location = new System.Drawing.Point(367, 33);
            this.btnAimLab.Name = "btnAimLab";
            this.btnAimLab.ReadOnly = true;
            this.btnAimLab.Size = new System.Drawing.Size(157, 29);
            this.btnAimLab.TabIndex = 9;
            this.btnAimLab.Text = "00:00:00";
            this.btnAimLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBreak
            // 
            this.btnBreak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBreak.Location = new System.Drawing.Point(367, 153);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.ReadOnly = true;
            this.btnBreak.Size = new System.Drawing.Size(157, 29);
            this.btnBreak.TabIndex = 10;
            this.btnBreak.Text = "00:00:00";
            this.btnBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudy
            // 
            this.btnStudy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudy.Location = new System.Drawing.Point(187, 153);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.ReadOnly = true;
            this.btnStudy.Size = new System.Drawing.Size(138, 29);
            this.btnStudy.TabIndex = 11;
            this.btnStudy.Text = "00:00:00";
            this.btnStudy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmNeloFoceser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnAimLab);
            this.Controls.Add(this.btnDeathMatch);
            this.Controls.Add(this.btBreak);
            this.Controls.Add(this.btStudy);
            this.Controls.Add(this.btAimLabs);
            this.Controls.Add(this.btDeathMatch);
            this.Controls.Add(this.lblBreak);
            this.Controls.Add(this.lblStudy);
            this.Controls.Add(this.lblAimLabs);
            this.Controls.Add(this.lblDeathmatch);
            this.Name = "frmNeloFoceser";
            this.Text = "Nelo Focus";
            this.Load += new System.EventHandler(this.frmNeloFoceser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeathmatch;
        private System.Windows.Forms.Label lblAimLabs;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Button btDeathMatch;
        private System.Windows.Forms.Button btAimLabs;
        private System.Windows.Forms.Button btStudy;
        private System.Windows.Forms.Button btBreak;
        private System.Windows.Forms.TextBox btnDeathMatch;
        private System.Windows.Forms.TextBox btnAimLab;
        private System.Windows.Forms.TextBox btnBreak;
        private System.Windows.Forms.TextBox btnStudy;
    }
}

