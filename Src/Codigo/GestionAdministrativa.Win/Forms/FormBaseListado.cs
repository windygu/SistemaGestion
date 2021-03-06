﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using GestionAdministrativa.Win.Forms;
using Telerik.WinControls.UI;

namespace GestionAdministrativa.Win.Forms
{
    public class FormBaseListado : FormBase
    {
        public bool CargarGrillaOnLoad { get; set; }
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public RadGridView MainGrid { get; set; }
        //public MetroPager MainPager { get; set; }
        public Dictionary<string, string> SortColumnMappings { get; set; }
        //public UcProgressSpinner Spinner { get; set; }

        public FormBaseListado()
        {
            CargarGrillaOnLoad = true;
        }

        public void FormBaseListado_Load(object sender, EventArgs e)
        {
            MainGrid.SortChanged += MainGridOnSortChanged;
            MainGrid.DataBindingComplete += MainGridOnDataBindingComplete;
        }

        private void MainGridOnDataBindingComplete(object sender, GridViewBindingCompleteEventArgs gridViewBindingCompleteEventArgs)
        {
            //Spinner.Hide();
        }

        private void MainGridOnSortChanged(object sender, GridViewCollectionChangedEventArgs gridViewCollectionChangedEventArgs)
        {
           // var sort = gridViewCollectionChangedEventArgs.GridViewTemplate.Sort;
           // var split = sort.Split(' ');
           // SortColumn = FinalSortColumn(split[0]);
           // SortDirection = split[1];
           //// MainPager.CurrentPage = 0;
           // RefrescarListado();
        }

        public virtual async Task<int> RefrescarListado()
        {
            return 0;
        }

        private string FinalSortColumn(string column)
        {
            if (SortColumnMappings == null || !SortColumnMappings.ContainsKey(column))
                return column;
            return SortColumnMappings[column];
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBaseListado
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBaseListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
