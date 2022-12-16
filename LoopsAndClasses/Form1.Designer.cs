namespace LoopsAndClasses
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMeddelande = new System.Windows.Forms.Label();
            this.lblAntal = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtAntal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelLblOutput = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLblOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblMeddelande, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAntal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMessage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAntal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelLblOutput, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblMeddelande
            // 
            this.lblMeddelande.AutoSize = true;
            this.lblMeddelande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeddelande.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeddelande.Location = new System.Drawing.Point(3, 0);
            this.lblMeddelande.Name = "lblMeddelande";
            this.lblMeddelande.Size = new System.Drawing.Size(349, 126);
            this.lblMeddelande.TabIndex = 0;
            this.lblMeddelande.Text = "Meddelande:";
            this.lblMeddelande.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntal.Location = new System.Drawing.Point(3, 126);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(349, 126);
            this.lblAntal.TabIndex = 1;
            this.lblAntal.Text = "Antal:";
            this.lblAntal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(358, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(350, 34);
            this.txtMessage.TabIndex = 3;
            // 
            // txtAntal
            // 
            this.txtAntal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntal.Location = new System.Drawing.Point(358, 129);
            this.txtAntal.Name = "txtAntal";
            this.txtAntal.Size = new System.Drawing.Size(350, 34);
            this.txtAntal.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(358, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(350, 121);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Beräkna Output";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // panelLblOutput
            // 
            this.panelLblOutput.AutoScroll = true;
            this.panelLblOutput.Controls.Add(this.lblOutput);
            this.panelLblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLblOutput.Location = new System.Drawing.Point(3, 255);
            this.panelLblOutput.Name = "panelLblOutput";
            this.panelLblOutput.Size = new System.Drawing.Size(349, 121);
            this.panelLblOutput.TabIndex = 6;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 29);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelLblOutput.ResumeLayout(false);
            this.panelLblOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMeddelande;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtAntal;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panelLblOutput;
    }
}

