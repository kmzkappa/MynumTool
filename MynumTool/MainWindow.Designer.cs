namespace MynumTool
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.grpCalc = new System.Windows.Forms.GroupBox();
            this.txtCalcResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTitleCalc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleCheck = new System.Windows.Forms.Label();
            this.grpCheck = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.ntxtCheck2 = new MynumTool.NumericTextBox();
            this.ntxtCheck3 = new MynumTool.NumericTextBox();
            this.ntxtCheck1 = new MynumTool.NumericTextBox();
            this.ntxtCalc3 = new MynumTool.NumericTextBox();
            this.ntxtCalc2 = new MynumTool.NumericTextBox();
            this.ntxtCalc1 = new MynumTool.NumericTextBox();
            this.grpCalc.SuspendLayout();
            this.grpCheck.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCalc
            // 
            this.grpCalc.Controls.Add(this.ntxtCalc3);
            this.grpCalc.Controls.Add(this.ntxtCalc2);
            this.grpCalc.Controls.Add(this.ntxtCalc1);
            this.grpCalc.Controls.Add(this.txtCalcResult);
            this.grpCalc.Location = new System.Drawing.Point(12, 36);
            this.grpCalc.Name = "grpCalc";
            this.grpCalc.Size = new System.Drawing.Size(164, 49);
            this.grpCalc.TabIndex = 1;
            this.grpCalc.TabStop = false;
            this.grpCalc.Text = "個人番号（上11桁）";
            // 
            // txtCalcResult
            // 
            this.txtCalcResult.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCalcResult.Location = new System.Drawing.Point(134, 18);
            this.txtCalcResult.MaxLength = 4;
            this.txtCalcResult.Name = "txtCalcResult";
            this.txtCalcResult.ReadOnly = true;
            this.txtCalcResult.Size = new System.Drawing.Size(20, 19);
            this.txtCalcResult.TabIndex = 3;
            this.txtCalcResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(182, 52);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            this.btnCalc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalc_KeyPress);
            // 
            // lblTitleCalc
            // 
            this.lblTitleCalc.AutoSize = true;
            this.lblTitleCalc.Location = new System.Drawing.Point(10, 11);
            this.lblTitleCalc.Name = "lblTitleCalc";
            this.lblTitleCalc.Size = new System.Drawing.Size(147, 12);
            this.lblTitleCalc.TabIndex = 3;
            this.lblTitleCalc.Text = "個人番号 チェックデジット算出";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 2);
            this.label1.TabIndex = 4;
            // 
            // lblTitleCheck
            // 
            this.lblTitleCheck.AutoSize = true;
            this.lblTitleCheck.Location = new System.Drawing.Point(10, 113);
            this.lblTitleCheck.Name = "lblTitleCheck";
            this.lblTitleCheck.Size = new System.Drawing.Size(105, 12);
            this.lblTitleCheck.TabIndex = 5;
            this.lblTitleCheck.Text = "個人番号 有効確認";
            // 
            // grpCheck
            // 
            this.grpCheck.Controls.Add(this.ntxtCheck2);
            this.grpCheck.Controls.Add(this.ntxtCheck3);
            this.grpCheck.Controls.Add(this.ntxtCheck1);
            this.grpCheck.Location = new System.Drawing.Point(12, 137);
            this.grpCheck.Name = "grpCheck";
            this.grpCheck.Size = new System.Drawing.Size(148, 49);
            this.grpCheck.TabIndex = 6;
            this.grpCheck.TabStop = false;
            this.grpCheck.Text = "個人番号（12桁）";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(182, 151);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(76, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "確認";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCheck_KeyPress);
            // 
            // statusStrip
            // 
            this.statusStrip.AllowMerge = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar});
            this.statusStrip.Location = new System.Drawing.Point(0, 197);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(268, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            // 
            // statusbar
            // 
            this.statusbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(0, 17);
            // 
            // ntxtCheck2
            // 
            this.ntxtCheck2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCheck2.Location = new System.Drawing.Point(52, 18);
            this.ntxtCheck2.MaxLength = 4;
            this.ntxtCheck2.Name = "ntxtCheck2";
            this.ntxtCheck2.Size = new System.Drawing.Size(40, 19);
            this.ntxtCheck2.TabIndex = 6;
            this.ntxtCheck2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCheck2_KeyPress);
            // 
            // ntxtCheck3
            // 
            this.ntxtCheck3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCheck3.Location = new System.Drawing.Point(98, 18);
            this.ntxtCheck3.MaxLength = 4;
            this.ntxtCheck3.Name = "ntxtCheck3";
            this.ntxtCheck3.Size = new System.Drawing.Size(40, 19);
            this.ntxtCheck3.TabIndex = 7;
            this.ntxtCheck3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCheck3_KeyPress);
            // 
            // ntxtCheck1
            // 
            this.ntxtCheck1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCheck1.Location = new System.Drawing.Point(6, 18);
            this.ntxtCheck1.MaxLength = 4;
            this.ntxtCheck1.Name = "ntxtCheck1";
            this.ntxtCheck1.Size = new System.Drawing.Size(40, 19);
            this.ntxtCheck1.TabIndex = 5;
            this.ntxtCheck1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCheck1_KeyPress);
            // 
            // ntxtCalc3
            // 
            this.ntxtCalc3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCalc3.Location = new System.Drawing.Point(98, 18);
            this.ntxtCalc3.MaxLength = 3;
            this.ntxtCalc3.Name = "ntxtCalc3";
            this.ntxtCalc3.Size = new System.Drawing.Size(30, 19);
            this.ntxtCalc3.TabIndex = 2;
            this.ntxtCalc3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCalc3_KeyPress);
            // 
            // ntxtCalc2
            // 
            this.ntxtCalc2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCalc2.Location = new System.Drawing.Point(52, 18);
            this.ntxtCalc2.MaxLength = 4;
            this.ntxtCalc2.Name = "ntxtCalc2";
            this.ntxtCalc2.Size = new System.Drawing.Size(40, 19);
            this.ntxtCalc2.TabIndex = 1;
            this.ntxtCalc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCalc2_KeyPress);
            // 
            // ntxtCalc1
            // 
            this.ntxtCalc1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ntxtCalc1.Location = new System.Drawing.Point(6, 18);
            this.ntxtCalc1.MaxLength = 4;
            this.ntxtCalc1.Name = "ntxtCalc1";
            this.ntxtCalc1.Size = new System.Drawing.Size(40, 19);
            this.ntxtCalc1.TabIndex = 0;
            this.ntxtCalc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxtCalc1_KeyPress);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 219);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grpCheck);
            this.Controls.Add(this.lblTitleCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleCalc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "個人番号計算機";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.grpCalc.ResumeLayout(false);
            this.grpCalc.PerformLayout();
            this.grpCheck.ResumeLayout(false);
            this.grpCheck.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCalc;
        private System.Windows.Forms.TextBox txtCalcResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTitleCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleCheck;
        private System.Windows.Forms.GroupBox grpCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusbar;
        private NumericTextBox ntxtCalc3;
        private NumericTextBox ntxtCalc2;
        private NumericTextBox ntxtCalc1;
        private NumericTextBox ntxtCheck2;
        private NumericTextBox ntxtCheck3;
        private NumericTextBox ntxtCheck1;
    }
}

