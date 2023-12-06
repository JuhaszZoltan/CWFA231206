namespace KaktuszGUI
{
    partial class MainForm
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
            lblUI01 = new Label();
            tbxSzures = new TextBox();
            dgvAdatok = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmNev = new DataGridViewTextBoxColumn();
            clmTud = new DataGridViewTextBoxColumn();
            clmNehezseg = new DataGridViewTextBoxColumn();
            clmVizigeny = new DataGridViewTextBoxColumn();
            clmFenyigeny = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAdatok).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 15);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(112, 15);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Szűrés név alapján:";
            // 
            // tbxSzures
            // 
            tbxSzures.Location = new Point(130, 12);
            tbxSzures.Name = "tbxSzures";
            tbxSzures.Size = new Size(385, 23);
            tbxSzures.TabIndex = 1;
            // 
            // dgvAdatok
            // 
            dgvAdatok.AllowUserToAddRows = false;
            dgvAdatok.AllowUserToDeleteRows = false;
            dgvAdatok.AllowUserToResizeColumns = false;
            dgvAdatok.AllowUserToResizeRows = false;
            dgvAdatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdatok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdatok.Columns.AddRange(new DataGridViewColumn[] { clmID, clmNev, clmTud, clmNehezseg, clmVizigeny, clmFenyigeny });
            dgvAdatok.Location = new Point(12, 41);
            dgvAdatok.Name = "dgvAdatok";
            dgvAdatok.RowHeadersVisible = false;
            dgvAdatok.RowTemplate.Height = 25;
            dgvAdatok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdatok.Size = new Size(503, 285);
            dgvAdatok.TabIndex = 2;
            // 
            // clmID
            // 
            clmID.HeaderText = "ID";
            clmID.Name = "clmID";
            clmID.Visible = false;
            // 
            // clmNev
            // 
            clmNev.FillWeight = 200F;
            clmNev.HeaderText = "név";
            clmNev.Name = "clmNev";
            // 
            // clmTud
            // 
            clmTud.HeaderText = "latin név";
            clmTud.Name = "clmTud";
            clmTud.Visible = false;
            // 
            // clmNehezseg
            // 
            clmNehezseg.HeaderText = "nehézség";
            clmNehezseg.Name = "clmNehezseg";
            // 
            // clmVizigeny
            // 
            clmVizigeny.HeaderText = "vízigény";
            clmVizigeny.Name = "clmVizigeny";
            // 
            // clmFenyigeny
            // 
            clmFenyigeny.HeaderText = "fényigény";
            clmFenyigeny.Name = "clmFenyigeny";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(527, 340);
            Controls.Add(dgvAdatok);
            Controls.Add(tbxSzures);
            Controls.Add(lblUI01);
            Name = "Form1";
            Text = "KaktuszokGUI";
            ((System.ComponentModel.ISupportInitialize)dgvAdatok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxSzures;
        private DataGridView dgvAdatok;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmNev;
        private DataGridViewTextBoxColumn clmTud;
        private DataGridViewTextBoxColumn clmNehezseg;
        private DataGridViewTextBoxColumn clmVizigeny;
        private DataGridViewTextBoxColumn clmFenyigeny;
    }
}
