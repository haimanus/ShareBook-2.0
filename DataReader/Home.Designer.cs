
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ShareBook.App.UI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.dtgStockData = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsStockData = new System.Windows.Forms.BindingSource(this.components);
            this.shareBookDBDataSet = new ShareBook.App.UI.ShareBookDBDataSet();
            this.stockTableAdapter = new ShareBook.App.UI.ShareBookDBDataSetTableAdapters.StockInfoTableAdapter();
            this.btnGetdata = new System.Windows.Forms.Button();
            this.High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdFetchStatus = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prgStocks = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareBookDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFetchStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStockData
            // 
            this.dtgStockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.High,
            this.Low,
            this.Open,
            this.Close});
            this.dtgStockData.Location = new System.Drawing.Point(336, 56);
            this.dtgStockData.Name = "dtgStockData";
            this.dtgStockData.Size = new System.Drawing.Size(413, 256);
            this.dtgStockData.TabIndex = 0;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "StockInfoDB";
            this.stockBindingSource.DataSource = this.dtsStockData;
            // 
            // dtsStockData
            // 
            this.dtsStockData.DataSource = this.shareBookDBDataSet;
            this.dtsStockData.Position = 0;
            // 
            // shareBookDBDataSet
            // 
            this.shareBookDBDataSet.DataSetName = "ShareBookDBDataSet";
            this.shareBookDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // btnGetdata
            // 
            this.btnGetdata.Location = new System.Drawing.Point(674, 27);
            this.btnGetdata.Name = "btnGetdata";
            this.btnGetdata.Size = new System.Drawing.Size(75, 23);
            this.btnGetdata.TabIndex = 2;
            this.btnGetdata.Text = "GET DATA";
            this.btnGetdata.UseVisualStyleBackColor = true;
            this.btnGetdata.Click += new System.EventHandler(this.btnGetdata_Click);
            // 
            // High
            // 
            this.High.HeaderText = "High";
            this.High.Name = "High";
            // 
            // Low
            // 
            this.Low.HeaderText = "Low";
            this.Low.Name = "Low";
            // 
            // Open
            // 
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            // 
            // Close
            // 
            this.Close.HeaderText = "Close";
            this.Close.Name = "Close";
            // 
            // grdFetchStatus
            // 
            this.grdFetchStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFetchStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Status});
            this.grdFetchStatus.Location = new System.Drawing.Point(12, 56);
            this.grdFetchStatus.Name = "grdFetchStatus";
            this.grdFetchStatus.Size = new System.Drawing.Size(277, 256);
            this.grdFetchStatus.TabIndex = 3;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // prgStocks
            // 
            this.prgStocks.Location = new System.Drawing.Point(12, 27);
            this.prgStocks.Name = "prgStocks";
            this.prgStocks.Size = new System.Drawing.Size(276, 23);
            this.prgStocks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 330);
            this.Controls.Add(this.prgStocks);
            this.Controls.Add(this.grdFetchStatus);
            this.Controls.Add(this.btnGetdata);
            this.Controls.Add(this.dtgStockData);
            this.Name = "Form1";
            this.Text = "Data Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shareBookDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFetchStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStockData;
        private System.Windows.Forms.BindingSource dtsStockData;
        private ShareBookDBDataSet shareBookDBDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private ShareBookDBDataSetTableAdapters.StockInfoTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button btnGetdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn High;
        private System.Windows.Forms.DataGridViewTextBoxColumn Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn Close;
        private System.Windows.Forms.DataGridView grdFetchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ProgressBar prgStocks;
    }
}

