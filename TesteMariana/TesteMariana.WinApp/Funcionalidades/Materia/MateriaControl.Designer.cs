﻿namespace TesteMariana.WinApp.Funcionalidades.Materias
{
    partial class MateriaControl
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
            this.listMaterias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listMaterias
            // 
            this.listMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMaterias.FormattingEnabled = true;
            this.listMaterias.Location = new System.Drawing.Point(0, 0);
            this.listMaterias.Margin = new System.Windows.Forms.Padding(2);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(213, 199);
            this.listMaterias.TabIndex = 1;
            // 
            // MateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMaterias);
            this.Name = "MateriaControl";
            this.Size = new System.Drawing.Size(213, 199);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterias;
    }
}
