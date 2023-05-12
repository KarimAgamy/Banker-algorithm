namespace Banker
{
    partial class Form1
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
            gvTotalResources = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            gvAvailableResources = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            gvCurrentAllocation = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            gvMaxNeed = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            btnRunBankersAlgorithm = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProcessIndex = new TextBox();
            txtRequestAmount = new TextBox();
            txtResourceIndex = new TextBox();
            btnRequestResource = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvTotalResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvAvailableResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrentAllocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvMaxNeed).BeginInit();
            SuspendLayout();
            // 
            // gvTotalResources
            // 
            gvTotalResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTotalResources.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            gvTotalResources.Location = new Point(44, 71);
            gvTotalResources.Name = "gvTotalResources";
            gvTotalResources.RowHeadersWidth = 51;
            gvTotalResources.RowTemplate.Height = 29;
            gvTotalResources.Size = new Size(353, 92);
            gvTotalResources.TabIndex = 0;
            gvTotalResources.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "A";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "B";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 75;
            // 
            // Column3
            // 
            Column3.HeaderText = "C";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "D";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 75;
            // 
            // gvAvailableResources
            // 
            gvAvailableResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvAvailableResources.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            gvAvailableResources.Location = new Point(609, 71);
            gvAvailableResources.Name = "gvAvailableResources";
            gvAvailableResources.RowHeadersWidth = 51;
            gvAvailableResources.RowTemplate.Height = 29;
            gvAvailableResources.Size = new Size(353, 92);
            gvAvailableResources.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "A";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "B";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "C";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "D";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 75;
            // 
            // gvCurrentAllocation
            // 
            gvCurrentAllocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCurrentAllocation.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            gvCurrentAllocation.Location = new Point(44, 257);
            gvCurrentAllocation.Name = "gvCurrentAllocation";
            gvCurrentAllocation.RowHeadersWidth = 51;
            gvCurrentAllocation.RowTemplate.Height = 29;
            gvCurrentAllocation.Size = new Size(353, 92);
            gvCurrentAllocation.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "A";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "B";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "C";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "D";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 75;
            // 
            // gvMaxNeed
            // 
            gvMaxNeed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvMaxNeed.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            gvMaxNeed.Location = new Point(609, 257);
            gvMaxNeed.Name = "gvMaxNeed";
            gvMaxNeed.RowHeadersWidth = 51;
            gvMaxNeed.RowTemplate.Height = 29;
            gvMaxNeed.Size = new Size(353, 92);
            gvMaxNeed.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "A";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "B";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 75;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "C";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "D";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 75;
            // 
            // btnRunBankersAlgorithm
            // 
            btnRunBankersAlgorithm.Location = new Point(449, 408);
            btnRunBankersAlgorithm.Name = "btnRunBankersAlgorithm";
            btnRunBankersAlgorithm.Size = new Size(94, 29);
            btnRunBankersAlgorithm.TabIndex = 4;
            btnRunBankersAlgorithm.Text = "calculate";
            btnRunBankersAlgorithm.UseVisualStyleBackColor = true;
            btnRunBankersAlgorithm.Click += btnRunBankersAlgorithm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "Total Resources";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(725, 30);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 6;
            label2.Text = "Available Resources";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(166, 210);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 7;
            label3.Text = "Current Allocation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(725, 210);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 8;
            label4.Text = "Maximum Need";
            // 
            // txtProcessIndex
            // 
            txtProcessIndex.Location = new Point(44, 390);
            txtProcessIndex.Name = "txtProcessIndex";
            txtProcessIndex.Size = new Size(125, 27);
            txtProcessIndex.TabIndex = 9;
            // 
            // txtRequestAmount
            // 
            txtRequestAmount.Location = new Point(230, 390);
            txtRequestAmount.Name = "txtRequestAmount";
            txtRequestAmount.Size = new Size(125, 27);
            txtRequestAmount.TabIndex = 10;
            // 
            // txtResourceIndex
            // 
            txtResourceIndex.Location = new Point(44, 454);
            txtResourceIndex.Name = "txtResourceIndex";
            txtResourceIndex.Size = new Size(125, 27);
            txtResourceIndex.TabIndex = 11;
            // 
            // btnRequestResource
            // 
            btnRequestResource.Location = new Point(230, 452);
            btnRequestResource.Name = "btnRequestResource";
            btnRequestResource.Size = new Size(94, 29);
            btnRequestResource.TabIndex = 12;
            btnRequestResource.Text = "Request";
            btnRequestResource.UseVisualStyleBackColor = true;
            btnRequestResource.Click += btnRequestResource_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(60, 367);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "process index";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(230, 367);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 14;
            label6.Text = "Request amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(49, 431);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 15;
            label7.Text = "Resource index";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 495);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnRequestResource);
            Controls.Add(txtResourceIndex);
            Controls.Add(txtRequestAmount);
            Controls.Add(txtProcessIndex);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRunBankersAlgorithm);
            Controls.Add(gvMaxNeed);
            Controls.Add(gvCurrentAllocation);
            Controls.Add(gvAvailableResources);
            Controls.Add(gvTotalResources);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvTotalResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvAvailableResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrentAllocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvMaxNeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvTotalResources;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView gvAvailableResources;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView gvCurrentAllocation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView gvMaxNeed;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Button btnRunBankersAlgorithm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProcessIndex;
        private TextBox txtRequestAmount;
        private TextBox txtResourceIndex;
        private Button btnRequestResource;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}