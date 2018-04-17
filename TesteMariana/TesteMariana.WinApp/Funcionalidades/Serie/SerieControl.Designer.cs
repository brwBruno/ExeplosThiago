namespace TesteMariana.WinApp.Funcionalidades.Series
{
    partial class SerieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSeries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listSeries
            // 
            this.listSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSeries.FormattingEnabled = true;
            this.listSeries.Location = new System.Drawing.Point(0, 0);
            this.listSeries.Margin = new System.Windows.Forms.Padding(2);
            this.listSeries.Name = "listSeries";
            this.listSeries.Size = new System.Drawing.Size(213, 199);
            this.listSeries.TabIndex = 1;
            // 
            // SerieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listSeries);
            this.Name = "SerieControl";
            this.Size = new System.Drawing.Size(213, 199);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSeries;
    }
}
