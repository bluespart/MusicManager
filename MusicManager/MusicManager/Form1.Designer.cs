namespace MusicManager
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tlpPaths = new System.Windows.Forms.TableLayoutPanel();
            this.btnAction = new System.Windows.Forms.Button();
            this.tlpPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(455, 3);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(260, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.Click += new System.EventHandler(this.txtSource_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(455, 53);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(260, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.Click += new System.EventHandler(this.txtDestination_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(3, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(3, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination";
            // 
            // tlpPaths
            // 
            this.tlpPaths.ColumnCount = 2;
            this.tlpPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaths.Controls.Add(this.lblSource, 0, 0);
            this.tlpPaths.Controls.Add(this.txtSource, 1, 0);
            this.tlpPaths.Controls.Add(this.lblDestination, 0, 1);
            this.tlpPaths.Controls.Add(this.txtDestination, 1, 1);
            this.tlpPaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPaths.Location = new System.Drawing.Point(0, 0);
            this.tlpPaths.Name = "tlpPaths";
            this.tlpPaths.RowCount = 2;
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPaths.Size = new System.Drawing.Size(905, 100);
            this.tlpPaths.TabIndex = 4;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 141);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Execute";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 406);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.tlpPaths);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpPaths.ResumeLayout(false);
            this.tlpPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TableLayoutPanel tlpPaths;
        private System.Windows.Forms.Button btnAction;
    }
}

