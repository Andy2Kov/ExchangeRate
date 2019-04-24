namespace ExchangeRate
{
    partial class frmCurrency
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
            this.gridCurrency = new DevExpress.XtraGrid.GridControl();
            this.gridViewCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dtCource = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrency)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCource.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCource.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCurrency
            // 
            this.gridCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCurrency.Location = new System.Drawing.Point(0, 40);
            this.gridCurrency.MainView = this.gridViewCurrency;
            this.gridCurrency.Name = "gridCurrency";
            this.gridCurrency.Size = new System.Drawing.Size(776, 404);
            this.gridCurrency.TabIndex = 3;
            this.gridCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrency});
            // 
            // gridViewCurrency
            // 
            this.gridViewCurrency.GridControl = this.gridCurrency;
            this.gridViewCurrency.Name = "gridViewCurrency";
            this.gridViewCurrency.OptionsBehavior.ReadOnly = true;
            this.gridViewCurrency.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridViewCurrency.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewCurrency.OptionsSelection.MultiSelect = true;
            this.gridViewCurrency.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewCurrency.OptionsView.ColumnAutoWidth = false;
            this.gridViewCurrency.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCurrency.OptionsView.ShowGroupPanel = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.dtCource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 40);
            this.panel2.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Дата курса валют";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(251, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtCource
            // 
            this.dtCource.EditValue = null;
            this.dtCource.Location = new System.Drawing.Point(116, 10);
            this.dtCource.Name = "dtCource";
            this.dtCource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCource.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCource.Size = new System.Drawing.Size(119, 20);
            this.dtCource.TabIndex = 0;
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 444);
            this.Controls.Add(this.gridCurrency);
            this.Controls.Add(this.panel2);
            this.Name = "frmCurrency";
            this.Text = "Курсы валют";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrency)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCource.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCource.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrency;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.DateEdit dtCource;
    }
}

