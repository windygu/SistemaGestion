﻿namespace GestionAdministrativa.Win.Forms.Util
{
    partial class UcFiltroSucursal
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
            this.Combo = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.Combo)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo
            // 
            this.Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Combo.DropDownAnimationEnabled = true;
            this.Combo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo.Location = new System.Drawing.Point(0, 0);
            this.Combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Combo.MaxDropDownItems = 0;
            this.Combo.Name = "Combo";
            this.Combo.ShowImageInEditorArea = true;
            this.Combo.Size = new System.Drawing.Size(369, 32);
            this.Combo.TabIndex = 2;
            this.Combo.ThemeName = "TelerikMetroBlue";
            this.Combo.SelectedValueChanged += new System.EventHandler(this.Combo_SelectedValueChanged);
            // 
            // UcFiltroSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Combo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcFiltroSucursal";
            this.Size = new System.Drawing.Size(369, 33);
            this.Load += new System.EventHandler(this.ucFiltrSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Combo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList Combo;

    }
}