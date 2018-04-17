namespace TesteMariana.WinApp.Funcionalidades.Disciplinas
{
    partial class DisciplinaControl
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
            this.listDisciplinas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listDisciplinas
            // 
            this.listDisciplinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDisciplinas.FormattingEnabled = true;
            this.listDisciplinas.Location = new System.Drawing.Point(0, 0);
            this.listDisciplinas.Margin = new System.Windows.Forms.Padding(2);
            this.listDisciplinas.Name = "listDisciplinas";
            this.listDisciplinas.Size = new System.Drawing.Size(213, 199);
            this.listDisciplinas.TabIndex = 1;
            // 
            // DisciplinaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDisciplinas);
            this.Name = "DisciplinaControl";
            this.Size = new System.Drawing.Size(213, 199);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDisciplinas;
    }
}
