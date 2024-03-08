namespace BezierCurveGenerator
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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.ActionTypeBtn = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CurveChooseBtn = new System.Windows.Forms.ComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MaxPointsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DrawSkelCheck = new System.Windows.Forms.CheckBox();
            this.MainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 5;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.MainPictureBox, 1, 1);
            this.MainTableLayout.Controls.Add(this.ActionTypeBtn, 3, 2);
            this.MainTableLayout.Controls.Add(this.ResetBtn, 3, 3);
            this.MainTableLayout.Controls.Add(this.CurveChooseBtn, 3, 1);
            this.MainTableLayout.Controls.Add(this.StatusStrip, 1, 6);
            this.MainTableLayout.Controls.Add(this.DrawSkelCheck, 3, 5);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 7;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(20, 20);
            this.MainPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainTableLayout.SetRowSpan(this.MainPictureBox, 5);
            this.MainPictureBox.Size = new System.Drawing.Size(612, 410);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            // 
            // ActionTypeBtn
            // 
            this.ActionTypeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionTypeBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ActionTypeBtn.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ActionTypeBtn.FormattingEnabled = true;
            this.ActionTypeBtn.Items.AddRange(new object[] {
            "Add Curve",
            "Add Control Point",
            "Remove Point"});
            this.ActionTypeBtn.Location = new System.Drawing.Point(655, 97);
            this.ActionTypeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActionTypeBtn.MaxDropDownItems = 2;
            this.ActionTypeBtn.Name = "ActionTypeBtn";
            this.ActionTypeBtn.Size = new System.Drawing.Size(121, 24);
            this.ActionTypeBtn.TabIndex = 2;
            this.ActionTypeBtn.SelectedIndexChanged += new System.EventHandler(this.ActionTypeBtn_SelectedIndexChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetBtn.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ResetBtn.Location = new System.Drawing.Point(682, 155);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ResetBtn.Size = new System.Drawing.Size(67, 30);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CurveChooseBtn
            // 
            this.CurveChooseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurveChooseBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurveChooseBtn.Enabled = false;
            this.CurveChooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurveChooseBtn.FormattingEnabled = true;
            this.CurveChooseBtn.ItemHeight = 13;
            this.CurveChooseBtn.Location = new System.Drawing.Point(655, 39);
            this.CurveChooseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CurveChooseBtn.Name = "CurveChooseBtn";
            this.CurveChooseBtn.Size = new System.Drawing.Size(121, 21);
            this.CurveChooseBtn.TabIndex = 4;
            this.CurveChooseBtn.SelectedIndexChanged += new System.EventHandler(this.CurveChooseBtn_SelectedIndexChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaxPointsLabel});
            this.StatusStrip.Location = new System.Drawing.Point(20, 430);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(612, 20);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 5;
            // 
            // MaxPointsLabel
            // 
            this.MaxPointsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxPointsLabel.Name = "MaxPointsLabel";
            this.MaxPointsLabel.Size = new System.Drawing.Size(114, 20);
            this.MaxPointsLabel.Text = "Max points amount:";
            // 
            // DrawSkelCheck
            // 
            this.DrawSkelCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrawSkelCheck.Checked = true;
            this.DrawSkelCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawSkelCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DrawSkelCheck.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.DrawSkelCheck.Location = new System.Drawing.Point(663, 389);
            this.DrawSkelCheck.Margin = new System.Windows.Forms.Padding(0);
            this.DrawSkelCheck.Name = "DrawSkelCheck";
            this.DrawSkelCheck.Size = new System.Drawing.Size(106, 22);
            this.DrawSkelCheck.TabIndex = 6;
            this.DrawSkelCheck.Text = "Draw skeleton";
            this.DrawSkelCheck.UseVisualStyleBackColor = true;
            this.DrawSkelCheck.CheckedChanged += new System.EventHandler(this.DrawSkelCheck_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Main";
            this.Text = "Bézier Curve Generator";
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.ComboBox ActionTypeBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.ComboBox CurveChooseBtn;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MaxPointsLabel;
        private System.Windows.Forms.CheckBox DrawSkelCheck;
    }
}

