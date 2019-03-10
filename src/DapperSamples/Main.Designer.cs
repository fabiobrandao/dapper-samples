namespace DapperSamples
{
    partial class Main
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
            this.txbResultQuery = new System.Windows.Forms.TextBox();
            this.btnDinamicSelect = new System.Windows.Forms.Button();
            this.btnTypedSelect = new System.Windows.Forms.Button();
            this.btnParametersSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.gbxOperations = new System.Windows.Forms.GroupBox();
            this.gbxSelects = new System.Windows.Forms.GroupBox();
            this.gbxOperations.SuspendLayout();
            this.gbxSelects.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbResultQuery
            // 
            this.txbResultQuery.Location = new System.Drawing.Point(107, 22);
            this.txbResultQuery.Multiline = true;
            this.txbResultQuery.Name = "txbResultQuery";
            this.txbResultQuery.Size = new System.Drawing.Size(375, 245);
            this.txbResultQuery.TabIndex = 0;
            // 
            // btnDinamicSelect
            // 
            this.btnDinamicSelect.Location = new System.Drawing.Point(7, 19);
            this.btnDinamicSelect.Name = "btnDinamicSelect";
            this.btnDinamicSelect.Size = new System.Drawing.Size(75, 23);
            this.btnDinamicSelect.TabIndex = 1;
            this.btnDinamicSelect.Text = "Dinamic Select";
            this.btnDinamicSelect.UseVisualStyleBackColor = true;
            this.btnDinamicSelect.Click += new System.EventHandler(this.btnBasicSelect_Click);
            // 
            // btnTypedSelect
            // 
            this.btnTypedSelect.Location = new System.Drawing.Point(8, 50);
            this.btnTypedSelect.Name = "btnTypedSelect";
            this.btnTypedSelect.Size = new System.Drawing.Size(75, 23);
            this.btnTypedSelect.TabIndex = 2;
            this.btnTypedSelect.Text = "Typed Select";
            this.btnTypedSelect.UseVisualStyleBackColor = true;
            this.btnTypedSelect.Click += new System.EventHandler(this.btnTypedSelect_Click);
            // 
            // btnParametersSelect
            // 
            this.btnParametersSelect.Location = new System.Drawing.Point(8, 79);
            this.btnParametersSelect.Name = "btnParametersSelect";
            this.btnParametersSelect.Size = new System.Drawing.Size(75, 23);
            this.btnParametersSelect.TabIndex = 3;
            this.btnParametersSelect.Text = "Parameters";
            this.btnParametersSelect.UseVisualStyleBackColor = true;
            this.btnParametersSelect.Click += new System.EventHandler(this.btnParametersSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(7, 49);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(75, 23);
            this.btnGetById.TabIndex = 7;
            this.btnGetById.Text = "Get By ID";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // gbxOperations
            // 
            this.gbxOperations.Controls.Add(this.btnInsert);
            this.gbxOperations.Controls.Add(this.btnUpdate);
            this.gbxOperations.Controls.Add(this.btnGetById);
            this.gbxOperations.Controls.Add(this.btnDelete);
            this.gbxOperations.Location = new System.Drawing.Point(12, 12);
            this.gbxOperations.Name = "gbxOperations";
            this.gbxOperations.Size = new System.Drawing.Size(89, 139);
            this.gbxOperations.TabIndex = 8;
            this.gbxOperations.TabStop = false;
            this.gbxOperations.Text = "Operations";
            // 
            // gbxSelects
            // 
            this.gbxSelects.Controls.Add(this.btnDinamicSelect);
            this.gbxSelects.Controls.Add(this.btnTypedSelect);
            this.gbxSelects.Controls.Add(this.btnParametersSelect);
            this.gbxSelects.Location = new System.Drawing.Point(12, 157);
            this.gbxSelects.Name = "gbxSelects";
            this.gbxSelects.Size = new System.Drawing.Size(89, 110);
            this.gbxSelects.TabIndex = 8;
            this.gbxSelects.TabStop = false;
            this.gbxSelects.Text = "Selects";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 279);
            this.Controls.Add(this.gbxSelects);
            this.Controls.Add(this.gbxOperations);
            this.Controls.Add(this.txbResultQuery);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dapper Samples";
            this.gbxOperations.ResumeLayout(false);
            this.gbxSelects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbResultQuery;
        private System.Windows.Forms.Button btnDinamicSelect;
        private System.Windows.Forms.Button btnTypedSelect;
        private System.Windows.Forms.Button btnParametersSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.GroupBox gbxOperations;
        private System.Windows.Forms.GroupBox gbxSelects;
    }
}

