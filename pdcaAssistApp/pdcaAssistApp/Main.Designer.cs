namespace pdcaAssistApp {
    partial class pdcaMainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.stsWhole = new System.Windows.Forms.StatusStrip();
            this.tsslProgressIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProgressName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiProjectCase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewCase = new System.Windows.Forms.ToolStripMenuItem();
            this.tssUnderNew = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenCase = new System.Windows.Forms.ToolStripMenuItem();
            this.tssUnderOpen = new System.Windows.Forms.ToolStripSeparator();
            this.tssExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsWhole = new System.Windows.Forms.MenuStrip();
            this.tlpWhole = new System.Windows.Forms.TableLayoutPanel();
            this.tblProjectLabel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCase = new System.Windows.Forms.Panel();
            this.lblCaseName = new System.Windows.Forms.Label();
            this.lblCaseIndex = new System.Windows.Forms.Label();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectIndex = new System.Windows.Forms.Label();
            this.tlpPdcaData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTexts = new System.Windows.Forms.Panel();
            this.rtbPlan = new System.Windows.Forms.RichTextBox();
            this.rtbDo = new System.Windows.Forms.RichTextBox();
            this.rtbCheck = new System.Windows.Forms.RichTextBox();
            this.rtbAct = new System.Windows.Forms.RichTextBox();
            this.tlpBtns = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProgressRadioButtons = new System.Windows.Forms.Panel();
            this.rbtnAct = new System.Windows.Forms.RadioButton();
            this.rbtnCheck = new System.Windows.Forms.RadioButton();
            this.rbtnDo = new System.Windows.Forms.RadioButton();
            this.rbtnPlan = new System.Windows.Forms.RadioButton();
            this.btnInheritance = new System.Windows.Forms.Button();
            this.btnNextStage = new System.Windows.Forms.Button();
            this.stsWhole.SuspendLayout();
            this.mnsWhole.SuspendLayout();
            this.tlpWhole.SuspendLayout();
            this.tblProjectLabel.SuspendLayout();
            this.pnlCase.SuspendLayout();
            this.pnlProject.SuspendLayout();
            this.tlpPdcaData.SuspendLayout();
            this.pnlTexts.SuspendLayout();
            this.tlpBtns.SuspendLayout();
            this.pnlProgressRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsWhole
            // 
            this.stsWhole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProgressIndex,
            this.tsslProgressName});
            this.stsWhole.Location = new System.Drawing.Point(0, 339);
            this.stsWhole.Name = "stsWhole";
            this.stsWhole.Size = new System.Drawing.Size(584, 23);
            this.stsWhole.TabIndex = 0;
            this.stsWhole.Text = "statusStrip1";
            // 
            // tsslProgressIndex
            // 
            this.tsslProgressIndex.Name = "tsslProgressIndex";
            this.tsslProgressIndex.Size = new System.Drawing.Size(115, 18);
            this.tsslProgressIndex.Text = "Present progress :";
            // 
            // tsslProgressName
            // 
            this.tsslProgressName.AutoSize = false;
            this.tsslProgressName.Name = "tsslProgressName";
            this.tsslProgressName.Size = new System.Drawing.Size(120, 18);
            // 
            // tsmiProjectCase
            // 
            this.tsmiProjectCase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewProject,
            this.tsmiNewCase,
            this.tssUnderNew,
            this.tsmiOpenCase,
            this.tssUnderOpen,
            this.tssExit});
            this.tsmiProjectCase.Name = "tsmiProjectCase";
            this.tsmiProjectCase.Size = new System.Drawing.Size(112, 22);
            this.tsmiProjectCase.Text = "Project/Case(&P)";
            // 
            // tsmiNewProject
            // 
            this.tsmiNewProject.Name = "tsmiNewProject";
            this.tsmiNewProject.Size = new System.Drawing.Size(147, 22);
            this.tsmiNewProject.Text = "&New Project";
            // 
            // tsmiNewCase
            // 
            this.tsmiNewCase.Name = "tsmiNewCase";
            this.tsmiNewCase.Size = new System.Drawing.Size(147, 22);
            this.tsmiNewCase.Text = "New &Case";
            // 
            // tssUnderNew
            // 
            this.tssUnderNew.Name = "tssUnderNew";
            this.tssUnderNew.Size = new System.Drawing.Size(144, 6);
            // 
            // tsmiOpenCase
            // 
            this.tsmiOpenCase.Name = "tsmiOpenCase";
            this.tsmiOpenCase.Size = new System.Drawing.Size(147, 22);
            this.tsmiOpenCase.Text = "&Open Case";
            // 
            // tssUnderOpen
            // 
            this.tssUnderOpen.Name = "tssUnderOpen";
            this.tssUnderOpen.Size = new System.Drawing.Size(144, 6);
            // 
            // tssExit
            // 
            this.tssExit.Name = "tssExit";
            this.tssExit.Size = new System.Drawing.Size(147, 22);
            this.tssExit.Text = "E&xit";
            // 
            // mnsWhole
            // 
            this.mnsWhole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjectCase});
            this.mnsWhole.Location = new System.Drawing.Point(0, 0);
            this.mnsWhole.Name = "mnsWhole";
            this.mnsWhole.Size = new System.Drawing.Size(584, 26);
            this.mnsWhole.TabIndex = 1;
            this.mnsWhole.Text = "menuStrip1";
            // 
            // tlpWhole
            // 
            this.tlpWhole.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpWhole.ColumnCount = 1;
            this.tlpWhole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.Controls.Add(this.tblProjectLabel, 0, 0);
            this.tlpWhole.Controls.Add(this.tlpPdcaData, 0, 1);
            this.tlpWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWhole.Location = new System.Drawing.Point(0, 26);
            this.tlpWhole.Name = "tlpWhole";
            this.tlpWhole.RowCount = 2;
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpWhole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWhole.Size = new System.Drawing.Size(584, 313);
            this.tlpWhole.TabIndex = 2;
            // 
            // tblProjectLabel
            // 
            this.tblProjectLabel.ColumnCount = 1;
            this.tblProjectLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProjectLabel.Controls.Add(this.pnlCase, 0, 1);
            this.tblProjectLabel.Controls.Add(this.pnlProject, 0, 0);
            this.tblProjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProjectLabel.Location = new System.Drawing.Point(5, 5);
            this.tblProjectLabel.Name = "tblProjectLabel";
            this.tblProjectLabel.RowCount = 2;
            this.tblProjectLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProjectLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProjectLabel.Size = new System.Drawing.Size(574, 44);
            this.tblProjectLabel.TabIndex = 0;
            // 
            // pnlCase
            // 
            this.pnlCase.Controls.Add(this.lblCaseName);
            this.pnlCase.Controls.Add(this.lblCaseIndex);
            this.pnlCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCase.Location = new System.Drawing.Point(3, 25);
            this.pnlCase.Name = "pnlCase";
            this.pnlCase.Size = new System.Drawing.Size(568, 16);
            this.pnlCase.TabIndex = 1;
            // 
            // lblCaseName
            // 
            this.lblCaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaseName.Location = new System.Drawing.Point(60, 0);
            this.lblCaseName.Name = "lblCaseName";
            this.lblCaseName.Size = new System.Drawing.Size(508, 16);
            this.lblCaseName.TabIndex = 2;
            this.lblCaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCaseIndex
            // 
            this.lblCaseIndex.Location = new System.Drawing.Point(0, 0);
            this.lblCaseIndex.Name = "lblCaseIndex";
            this.lblCaseIndex.Size = new System.Drawing.Size(60, 16);
            this.lblCaseIndex.TabIndex = 0;
            this.lblCaseIndex.Text = "Case :";
            this.lblCaseIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlProject
            // 
            this.pnlProject.Controls.Add(this.lblProjectName);
            this.pnlProject.Controls.Add(this.lblProjectIndex);
            this.pnlProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProject.Location = new System.Drawing.Point(3, 3);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(568, 16);
            this.pnlProject.TabIndex = 0;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.Location = new System.Drawing.Point(60, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(508, 16);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProjectIndex
            // 
            this.lblProjectIndex.Location = new System.Drawing.Point(0, 0);
            this.lblProjectIndex.Name = "lblProjectIndex";
            this.lblProjectIndex.Size = new System.Drawing.Size(60, 16);
            this.lblProjectIndex.TabIndex = 0;
            this.lblProjectIndex.Text = "Project :";
            this.lblProjectIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPdcaData
            // 
            this.tlpPdcaData.ColumnCount = 2;
            this.tlpPdcaData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.83624F));
            this.tlpPdcaData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16376F));
            this.tlpPdcaData.Controls.Add(this.pnlTexts, 0, 0);
            this.tlpPdcaData.Controls.Add(this.tlpBtns, 1, 0);
            this.tlpPdcaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPdcaData.Location = new System.Drawing.Point(5, 57);
            this.tlpPdcaData.Name = "tlpPdcaData";
            this.tlpPdcaData.RowCount = 1;
            this.tlpPdcaData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPdcaData.Size = new System.Drawing.Size(574, 251);
            this.tlpPdcaData.TabIndex = 1;
            // 
            // pnlTexts
            // 
            this.pnlTexts.Controls.Add(this.rtbPlan);
            this.pnlTexts.Controls.Add(this.rtbDo);
            this.pnlTexts.Controls.Add(this.rtbCheck);
            this.pnlTexts.Controls.Add(this.rtbAct);
            this.pnlTexts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTexts.Location = new System.Drawing.Point(3, 3);
            this.pnlTexts.Name = "pnlTexts";
            this.pnlTexts.Size = new System.Drawing.Size(458, 245);
            this.pnlTexts.TabIndex = 0;
            // 
            // rtbPlan
            // 
            this.rtbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlan.Location = new System.Drawing.Point(0, 0);
            this.rtbPlan.Name = "rtbPlan";
            this.rtbPlan.Size = new System.Drawing.Size(458, 245);
            this.rtbPlan.TabIndex = 3;
            this.rtbPlan.Text = "";
            // 
            // rtbDo
            // 
            this.rtbDo.DetectUrls = false;
            this.rtbDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDo.Location = new System.Drawing.Point(0, 0);
            this.rtbDo.Name = "rtbDo";
            this.rtbDo.Size = new System.Drawing.Size(458, 245);
            this.rtbDo.TabIndex = 2;
            this.rtbDo.Text = "";
            this.rtbDo.Visible = false;
            // 
            // rtbCheck
            // 
            this.rtbCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCheck.Location = new System.Drawing.Point(0, 0);
            this.rtbCheck.Name = "rtbCheck";
            this.rtbCheck.Size = new System.Drawing.Size(458, 245);
            this.rtbCheck.TabIndex = 1;
            this.rtbCheck.Text = "";
            this.rtbCheck.Visible = false;
            // 
            // rtbAct
            // 
            this.rtbAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAct.Location = new System.Drawing.Point(0, 0);
            this.rtbAct.Name = "rtbAct";
            this.rtbAct.Size = new System.Drawing.Size(458, 245);
            this.rtbAct.TabIndex = 0;
            this.rtbAct.Text = "";
            this.rtbAct.Visible = false;
            // 
            // tlpBtns
            // 
            this.tlpBtns.ColumnCount = 1;
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtns.Controls.Add(this.pnlProgressRadioButtons, 0, 0);
            this.tlpBtns.Controls.Add(this.btnInheritance, 0, 1);
            this.tlpBtns.Controls.Add(this.btnNextStage, 0, 2);
            this.tlpBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtns.Location = new System.Drawing.Point(467, 3);
            this.tlpBtns.Name = "tlpBtns";
            this.tlpBtns.RowCount = 3;
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBtns.Size = new System.Drawing.Size(104, 245);
            this.tlpBtns.TabIndex = 1;
            // 
            // pnlProgressRadioButtons
            // 
            this.pnlProgressRadioButtons.Controls.Add(this.rbtnAct);
            this.pnlProgressRadioButtons.Controls.Add(this.rbtnCheck);
            this.pnlProgressRadioButtons.Controls.Add(this.rbtnDo);
            this.pnlProgressRadioButtons.Controls.Add(this.rbtnPlan);
            this.pnlProgressRadioButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProgressRadioButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlProgressRadioButtons.Name = "pnlProgressRadioButtons";
            this.pnlProgressRadioButtons.Size = new System.Drawing.Size(98, 169);
            this.pnlProgressRadioButtons.TabIndex = 0;
            // 
            // rbtnAct
            // 
            this.rbtnAct.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnAct.Location = new System.Drawing.Point(0, 87);
            this.rbtnAct.Name = "rbtnAct";
            this.rbtnAct.Size = new System.Drawing.Size(98, 29);
            this.rbtnAct.TabIndex = 3;
            this.rbtnAct.TabStop = true;
            this.rbtnAct.Text = "Act";
            this.rbtnAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnAct.UseVisualStyleBackColor = true;
            this.rbtnAct.CheckedChanged += new System.EventHandler(this.rbtnAct_CheckedChanged);
            // 
            // rbtnCheck
            // 
            this.rbtnCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnCheck.Location = new System.Drawing.Point(0, 58);
            this.rbtnCheck.Name = "rbtnCheck";
            this.rbtnCheck.Size = new System.Drawing.Size(98, 29);
            this.rbtnCheck.TabIndex = 2;
            this.rbtnCheck.TabStop = true;
            this.rbtnCheck.Text = "Check";
            this.rbtnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCheck.UseVisualStyleBackColor = true;
            this.rbtnCheck.CheckedChanged += new System.EventHandler(this.rbtnCheck_CheckedChanged);
            // 
            // rbtnDo
            // 
            this.rbtnDo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnDo.Location = new System.Drawing.Point(0, 29);
            this.rbtnDo.Name = "rbtnDo";
            this.rbtnDo.Size = new System.Drawing.Size(98, 29);
            this.rbtnDo.TabIndex = 1;
            this.rbtnDo.TabStop = true;
            this.rbtnDo.Text = "Do";
            this.rbtnDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnDo.UseVisualStyleBackColor = true;
            this.rbtnDo.CheckedChanged += new System.EventHandler(this.rbtnDo_CheckedChanged);
            // 
            // rbtnPlan
            // 
            this.rbtnPlan.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnPlan.Location = new System.Drawing.Point(0, 0);
            this.rbtnPlan.Name = "rbtnPlan";
            this.rbtnPlan.Size = new System.Drawing.Size(98, 29);
            this.rbtnPlan.TabIndex = 0;
            this.rbtnPlan.TabStop = true;
            this.rbtnPlan.Text = "Plan";
            this.rbtnPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnPlan.UseVisualStyleBackColor = true;
            this.rbtnPlan.CheckedChanged += new System.EventHandler(this.rbtnPlan_CheckedChanged);
            // 
            // btnInheritance
            // 
            this.btnInheritance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInheritance.Location = new System.Drawing.Point(3, 178);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(98, 29);
            this.btnInheritance.TabIndex = 1;
            this.btnInheritance.Text = "Inheritance";
            this.btnInheritance.UseVisualStyleBackColor = true;
            // 
            // btnNextStage
            // 
            this.btnNextStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextStage.Location = new System.Drawing.Point(3, 213);
            this.btnNextStage.Name = "btnNextStage";
            this.btnNextStage.Size = new System.Drawing.Size(98, 29);
            this.btnNextStage.TabIndex = 2;
            this.btnNextStage.Text = "NextStage";
            this.btnNextStage.UseVisualStyleBackColor = true;
            // 
            // pdcaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tlpWhole);
            this.Controls.Add(this.stsWhole);
            this.Controls.Add(this.mnsWhole);
            this.Name = "pdcaMainForm";
            this.Text = "PDCA Assis Tool";
            this.stsWhole.ResumeLayout(false);
            this.stsWhole.PerformLayout();
            this.mnsWhole.ResumeLayout(false);
            this.mnsWhole.PerformLayout();
            this.tlpWhole.ResumeLayout(false);
            this.tblProjectLabel.ResumeLayout(false);
            this.pnlCase.ResumeLayout(false);
            this.pnlProject.ResumeLayout(false);
            this.tlpPdcaData.ResumeLayout(false);
            this.pnlTexts.ResumeLayout(false);
            this.tlpBtns.ResumeLayout(false);
            this.pnlProgressRadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stsWhole;
        private System.Windows.Forms.ToolStripStatusLabel tsslProgressIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectCase;
        private System.Windows.Forms.MenuStrip mnsWhole;
        private System.Windows.Forms.TableLayoutPanel tlpWhole;
        private System.Windows.Forms.TableLayoutPanel tblProjectLabel;
        private System.Windows.Forms.Panel pnlCase;
        private System.Windows.Forms.Label lblCaseIndex;
        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.Label lblProjectIndex;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewCase;
        private System.Windows.Forms.ToolStripSeparator tssUnderNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenCase;
        private System.Windows.Forms.ToolStripSeparator tssUnderOpen;
        private System.Windows.Forms.ToolStripMenuItem tssExit;
        private System.Windows.Forms.TableLayoutPanel tlpPdcaData;
        private System.Windows.Forms.Panel pnlTexts;
        private System.Windows.Forms.RichTextBox rtbPlan;
        private System.Windows.Forms.RichTextBox rtbDo;
        private System.Windows.Forms.RichTextBox rtbCheck;
        private System.Windows.Forms.RichTextBox rtbAct;
        private System.Windows.Forms.TableLayoutPanel tlpBtns;
        private System.Windows.Forms.Panel pnlProgressRadioButtons;
        private System.Windows.Forms.RadioButton rbtnAct;
        private System.Windows.Forms.RadioButton rbtnCheck;
        private System.Windows.Forms.RadioButton rbtnDo;
        private System.Windows.Forms.RadioButton rbtnPlan;
        private System.Windows.Forms.Button btnInheritance;
        private System.Windows.Forms.Button btnNextStage;
        private System.Windows.Forms.Label lblCaseName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.ToolStripStatusLabel tsslProgressName;
    }
}

