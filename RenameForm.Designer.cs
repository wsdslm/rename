namespace rename
{
    partial class RenameForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFileAdd = new System.Windows.Forms.TabPage();
            this.listViewPath = new System.Windows.Forms.ListView();
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRuleManage = new System.Windows.Forms.TabPage();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRuleDelete = new System.Windows.Forms.Button();
            this.buttonRuleClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewRule = new System.Windows.Forms.ListView();
            this.columnHeaderSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReplace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.buttonRuleAdd = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageResultPreview = new System.Windows.Forms.TabPage();
            this.buttonPreviewClear = new System.Windows.Forms.Button();
            this.buttonPreviewStart = new System.Windows.Forms.Button();
            this.listViewPreview = new System.Windows.Forms.ListView();
            this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.radioButtonRename = new System.Windows.Forms.RadioButton();
            this.radioButtonPreview = new System.Windows.Forms.RadioButton();
            this.buttonResuleClear = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonBakClear = new System.Windows.Forms.Button();
            this.buttonBakReturn = new System.Windows.Forms.Button();
            this.buttonBakImport = new System.Windows.Forms.Button();
            this.listViewBak = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialogLog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBak = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageFileAdd.SuspendLayout();
            this.tabPageRuleManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageResultPreview.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFileAdd);
            this.tabControl1.Controls.Add(this.tabPageRuleManage);
            this.tabControl1.Controls.Add(this.tabPageResultPreview);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Controls.Add(this.tabPageBackup);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFileAdd
            // 
            this.tabPageFileAdd.Controls.Add(this.listViewPath);
            this.tabPageFileAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageFileAdd.Name = "tabPageFileAdd";
            this.tabPageFileAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileAdd.Size = new System.Drawing.Size(643, 482);
            this.tabPageFileAdd.TabIndex = 0;
            this.tabPageFileAdd.Text = "添加文件";
            this.tabPageFileAdd.UseVisualStyleBackColor = true;
            // 
            // listViewPath
            // 
            this.listViewPath.AllowDrop = true;
            this.listViewPath.CheckBoxes = true;
            this.listViewPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Path});
            this.listViewPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPath.Location = new System.Drawing.Point(3, 3);
            this.listViewPath.Name = "listViewPath";
            this.listViewPath.Size = new System.Drawing.Size(637, 476);
            this.listViewPath.TabIndex = 0;
            this.listViewPath.UseCompatibleStateImageBehavior = false;
            this.listViewPath.View = System.Windows.Forms.View.Details;
            this.listViewPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPath_DragDrop);
            this.listViewPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPath_DragEnter);
            // 
            // Path
            // 
            this.Path.Text = "路径";
            this.Path.Width = 641;
            // 
            // tabPageRuleManage
            // 
            this.tabPageRuleManage.Controls.Add(this.buttonImport);
            this.tabPageRuleManage.Controls.Add(this.buttonExport);
            this.tabPageRuleManage.Controls.Add(this.buttonRuleDelete);
            this.tabPageRuleManage.Controls.Add(this.buttonRuleClear);
            this.tabPageRuleManage.Controls.Add(this.groupBox2);
            this.tabPageRuleManage.Controls.Add(this.groupBox1);
            this.tabPageRuleManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageRuleManage.Name = "tabPageRuleManage";
            this.tabPageRuleManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRuleManage.Size = new System.Drawing.Size(643, 482);
            this.tabPageRuleManage.TabIndex = 1;
            this.tabPageRuleManage.Text = "设计规则";
            this.tabPageRuleManage.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(70, 444);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "导入规则";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(477, 444);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "导出规则";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonRuleDelete
            // 
            this.buttonRuleDelete.Location = new System.Drawing.Point(331, 444);
            this.buttonRuleDelete.Name = "buttonRuleDelete";
            this.buttonRuleDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonRuleDelete.TabIndex = 2;
            this.buttonRuleDelete.Text = "删除规则";
            this.buttonRuleDelete.UseVisualStyleBackColor = true;
            this.buttonRuleDelete.Click += new System.EventHandler(this.buttonRuleDelete_Click);
            // 
            // buttonRuleClear
            // 
            this.buttonRuleClear.Location = new System.Drawing.Point(210, 444);
            this.buttonRuleClear.Name = "buttonRuleClear";
            this.buttonRuleClear.Size = new System.Drawing.Size(75, 23);
            this.buttonRuleClear.TabIndex = 2;
            this.buttonRuleClear.Text = "清空规则";
            this.buttonRuleClear.UseVisualStyleBackColor = true;
            this.buttonRuleClear.Click += new System.EventHandler(this.buttonRuleClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewRule);
            this.groupBox2.Location = new System.Drawing.Point(7, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "规则列表";
            // 
            // listViewRule
            // 
            this.listViewRule.CheckBoxes = true;
            this.listViewRule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSearch,
            this.columnHeaderReplace,
            this.columnHeaderRegex});
            this.listViewRule.FullRowSelect = true;
            this.listViewRule.Location = new System.Drawing.Point(6, 20);
            this.listViewRule.Name = "listViewRule";
            this.listViewRule.Size = new System.Drawing.Size(618, 263);
            this.listViewRule.TabIndex = 0;
            this.listViewRule.UseCompatibleStateImageBehavior = false;
            this.listViewRule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSearch
            // 
            this.columnHeaderSearch.Text = "查找";
            this.columnHeaderSearch.Width = 260;
            // 
            // columnHeaderReplace
            // 
            this.columnHeaderReplace.Text = "替换为";
            this.columnHeaderReplace.Width = 295;
            // 
            // columnHeaderRegex
            // 
            this.columnHeaderRegex.Text = "正则匹配";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRegex);
            this.groupBox1.Controls.Add(this.buttonRuleAdd);
            this.groupBox1.Controls.Add(this.textBoxReplace);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "替换字符";
            // 
            // checkBoxRegex
            // 
            this.checkBoxRegex.AutoSize = true;
            this.checkBoxRegex.Location = new System.Drawing.Point(343, 43);
            this.checkBoxRegex.Name = "checkBoxRegex";
            this.checkBoxRegex.Size = new System.Drawing.Size(72, 16);
            this.checkBoxRegex.TabIndex = 3;
            this.checkBoxRegex.Text = "正则匹配";
            this.checkBoxRegex.UseVisualStyleBackColor = true;
            // 
            // buttonRuleAdd
            // 
            this.buttonRuleAdd.Location = new System.Drawing.Point(343, 76);
            this.buttonRuleAdd.Name = "buttonRuleAdd";
            this.buttonRuleAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRuleAdd.TabIndex = 2;
            this.buttonRuleAdd.Text = "添加规则";
            this.buttonRuleAdd.UseVisualStyleBackColor = true;
            this.buttonRuleAdd.Click += new System.EventHandler(this.buttonRuleAdd_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(113, 78);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(198, 21);
            this.textBoxReplace.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(113, 39);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(198, 21);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "替换为";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找";
            // 
            // tabPageResultPreview
            // 
            this.tabPageResultPreview.Controls.Add(this.buttonPreviewClear);
            this.tabPageResultPreview.Controls.Add(this.buttonPreviewStart);
            this.tabPageResultPreview.Controls.Add(this.listViewPreview);
            this.tabPageResultPreview.Location = new System.Drawing.Point(4, 22);
            this.tabPageResultPreview.Name = "tabPageResultPreview";
            this.tabPageResultPreview.Size = new System.Drawing.Size(643, 482);
            this.tabPageResultPreview.TabIndex = 2;
            this.tabPageResultPreview.Text = "预览结果";
            this.tabPageResultPreview.UseVisualStyleBackColor = true;
            // 
            // buttonPreviewClear
            // 
            this.buttonPreviewClear.Location = new System.Drawing.Point(326, 447);
            this.buttonPreviewClear.Name = "buttonPreviewClear";
            this.buttonPreviewClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviewClear.TabIndex = 1;
            this.buttonPreviewClear.Text = "清空列表";
            this.buttonPreviewClear.UseVisualStyleBackColor = true;
            this.buttonPreviewClear.Click += new System.EventHandler(this.buttonPreviewClear_Click);
            // 
            // buttonPreviewStart
            // 
            this.buttonPreviewStart.Location = new System.Drawing.Point(218, 447);
            this.buttonPreviewStart.Name = "buttonPreviewStart";
            this.buttonPreviewStart.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviewStart.TabIndex = 1;
            this.buttonPreviewStart.Text = "开始预览";
            this.buttonPreviewStart.UseVisualStyleBackColor = true;
            this.buttonPreviewStart.Click += new System.EventHandler(this.buttonPreviewStart_Click);
            // 
            // listViewPreview
            // 
            this.listViewPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrigin,
            this.columnHeaderNew});
            this.listViewPreview.Location = new System.Drawing.Point(3, 4);
            this.listViewPreview.Name = "listViewPreview";
            this.listViewPreview.Size = new System.Drawing.Size(636, 437);
            this.listViewPreview.TabIndex = 0;
            this.listViewPreview.UseCompatibleStateImageBehavior = false;
            this.listViewPreview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrigin
            // 
            this.columnHeaderOrigin.Text = "原名";
            this.columnHeaderOrigin.Width = 318;
            // 
            // columnHeaderNew
            // 
            this.columnHeaderNew.Text = "重命名为";
            this.columnHeaderNew.Width = 317;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.checkBoxLog);
            this.tabPageResult.Controls.Add(this.radioButtonRename);
            this.tabPageResult.Controls.Add(this.radioButtonPreview);
            this.tabPageResult.Controls.Add(this.buttonResuleClear);
            this.tabPageResult.Controls.Add(this.buttonRename);
            this.tabPageResult.Controls.Add(this.listViewResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(643, 482);
            this.tabPageResult.TabIndex = 3;
            this.tabPageResult.Text = "执行重命名";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Location = new System.Drawing.Point(18, 410);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(72, 16);
            this.checkBoxLog.TabIndex = 3;
            this.checkBoxLog.Text = "记录日志";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // radioButtonRename
            // 
            this.radioButtonRename.AutoSize = true;
            this.radioButtonRename.Location = new System.Drawing.Point(146, 443);
            this.radioButtonRename.Name = "radioButtonRename";
            this.radioButtonRename.Size = new System.Drawing.Size(71, 16);
            this.radioButtonRename.TabIndex = 2;
            this.radioButtonRename.Text = "重新执行";
            this.radioButtonRename.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreview
            // 
            this.radioButtonPreview.AutoSize = true;
            this.radioButtonPreview.Checked = true;
            this.radioButtonPreview.Location = new System.Drawing.Point(146, 410);
            this.radioButtonPreview.Name = "radioButtonPreview";
            this.radioButtonPreview.Size = new System.Drawing.Size(119, 16);
            this.radioButtonPreview.TabIndex = 2;
            this.radioButtonPreview.TabStop = true;
            this.radioButtonPreview.Text = "按预览结果重命名";
            this.radioButtonPreview.UseVisualStyleBackColor = true;
            // 
            // buttonResuleClear
            // 
            this.buttonResuleClear.Location = new System.Drawing.Point(518, 425);
            this.buttonResuleClear.Name = "buttonResuleClear";
            this.buttonResuleClear.Size = new System.Drawing.Size(75, 23);
            this.buttonResuleClear.TabIndex = 1;
            this.buttonResuleClear.Text = "清空列表";
            this.buttonResuleClear.UseVisualStyleBackColor = true;
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(362, 425);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 1;
            this.buttonRename.Text = "执行重命名";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewResult.Location = new System.Drawing.Point(3, 3);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(634, 382);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "原名";
            this.columnHeader1.Width = 322;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "重命名为";
            this.columnHeader2.Width = 317;
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.buttonBakClear);
            this.tabPageBackup.Controls.Add(this.buttonBakReturn);
            this.tabPageBackup.Controls.Add(this.buttonBakImport);
            this.tabPageBackup.Controls.Add(this.listViewBak);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(643, 482);
            this.tabPageBackup.TabIndex = 4;
            this.tabPageBackup.Text = "文件名还原";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonBakClear
            // 
            this.buttonBakClear.Location = new System.Drawing.Point(377, 442);
            this.buttonBakClear.Name = "buttonBakClear";
            this.buttonBakClear.Size = new System.Drawing.Size(75, 23);
            this.buttonBakClear.TabIndex = 2;
            this.buttonBakClear.Text = "清空列表";
            this.buttonBakClear.UseVisualStyleBackColor = true;
            this.buttonBakClear.Click += new System.EventHandler(this.buttonBakClear_Click);
            // 
            // buttonBakReturn
            // 
            this.buttonBakReturn.Location = new System.Drawing.Point(238, 442);
            this.buttonBakReturn.Name = "buttonBakReturn";
            this.buttonBakReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonBakReturn.TabIndex = 1;
            this.buttonBakReturn.Text = "文件名还原";
            this.buttonBakReturn.UseVisualStyleBackColor = true;
            this.buttonBakReturn.Click += new System.EventHandler(this.buttonBakReturn_Click);
            // 
            // buttonBakImport
            // 
            this.buttonBakImport.Location = new System.Drawing.Point(88, 442);
            this.buttonBakImport.Name = "buttonBakImport";
            this.buttonBakImport.Size = new System.Drawing.Size(93, 23);
            this.buttonBakImport.TabIndex = 1;
            this.buttonBakImport.Text = "导入日志记录";
            this.buttonBakImport.UseVisualStyleBackColor = true;
            this.buttonBakImport.Click += new System.EventHandler(this.buttonBakImport_Click);
            // 
            // listViewBak
            // 
            this.listViewBak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBak.Location = new System.Drawing.Point(6, 3);
            this.listViewBak.Name = "listViewBak";
            this.listViewBak.Size = new System.Drawing.Size(631, 424);
            this.listViewBak.TabIndex = 0;
            this.listViewBak.UseCompatibleStateImageBehavior = false;
            this.listViewBak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "现在文件名";
            this.columnHeader3.Width = 292;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "旧文件名";
            this.columnHeader4.Width = 340;
            // 
            // openFileDialogLog
            // 
            this.openFileDialogLog.Filter = "|*.rule";
            // 
            // saveFileDialogLog
            // 
            this.saveFileDialogLog.Filter = "|*.rule";
            // 
            // openFileDialogBak
            // 
            this.openFileDialogBak.Filter = "|*.bak";
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 541);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RenameForm";
            this.Text = "文件重命名";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFileAdd.ResumeLayout(false);
            this.tabPageRuleManage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageResultPreview.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tabPageBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFileAdd;
        private System.Windows.Forms.TabPage tabPageRuleManage;
        private System.Windows.Forms.TabPage tabPageResultPreview;
        private System.Windows.Forms.ListView listViewPath;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewRule;
        private System.Windows.Forms.ColumnHeader columnHeaderSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRuleAdd;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPreviewClear;
        private System.Windows.Forms.Button buttonPreviewStart;
        private System.Windows.Forms.ListView listViewPreview;
        private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
        private System.Windows.Forms.ColumnHeader columnHeaderNew;
        private System.Windows.Forms.Button buttonRuleClear;
        private System.Windows.Forms.Button buttonRuleDelete;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonResuleClear;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.RadioButton radioButtonRename;
        private System.Windows.Forms.RadioButton radioButtonPreview;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.OpenFileDialog openFileDialogLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLog;
        private System.Windows.Forms.Button buttonBakReturn;
        private System.Windows.Forms.Button buttonBakImport;
        private System.Windows.Forms.ListView listViewBak;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.OpenFileDialog openFileDialogBak;
        private System.Windows.Forms.Button buttonBakClear;
        private System.Windows.Forms.ColumnHeader columnHeaderRegex;
        private System.Windows.Forms.CheckBox checkBoxRegex;
    }
}

