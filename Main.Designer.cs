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
            this.MainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 5;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.MainPictureBox, 1, 1);
            this.MainTableLayout.Controls.Add(this.ActionTypeBtn, 3, 1);
            this.MainTableLayout.Controls.Add(this.ResetBtn, 3, 2);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 5;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.MainTableLayout.SetRowSpan(this.MainPictureBox, 3);
            this.MainPictureBox.Size = new System.Drawing.Size(592, 410);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // ActionTypeBtn
            // 
            this.ActionTypeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionTypeBtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ActionTypeBtn.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ActionTypeBtn.FormattingEnabled = true;
            this.ActionTypeBtn.Items.AddRange(new object[] {
            "Add",
            "Remove",
            "Move"});
            this.ActionTypeBtn.Location = new System.Drawing.Point(645, 38);
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
            this.ResetBtn.Location = new System.Drawing.Point(672, 95);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ResetBtn.Size = new System.Drawing.Size(67, 30);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.ComboBox ActionTypeBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

