namespace LoveWindowsAgain
{
    partial class FeedbackPageView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFeedback = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.richInfo = new System.Windows.Forms.RichTextBox();
            this._lblVotes = new System.Windows.Forms.Label();
            this._lblHeader = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFeedback
            // 
            this.listFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFeedback.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFeedback.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listFeedback.HideSelection = false;
            this.listFeedback.Location = new System.Drawing.Point(76, 136);
            this.listFeedback.Name = "listFeedback";
            this.listFeedback.Size = new System.Drawing.Size(523, 656);
            this.listFeedback.TabIndex = 0;
            this.listFeedback.UseCompatibleStateImageBehavior = false;
            this.listFeedback.View = System.Windows.Forms.View.Details;
            this.listFeedback.SelectedIndexChanged += new System.EventHandler(this.listFeedback_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 177;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richInfo
            // 
            this.richInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richInfo.Location = new System.Drawing.Point(628, 182);
            this.richInfo.Name = "richInfo";
            this.richInfo.Size = new System.Drawing.Size(403, 610);
            this.richInfo.TabIndex = 178;
            this.richInfo.Text = "";
            this.richInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richInfo_LinkClicked);
            // 
            // _lblVotes
            // 
            this._lblVotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblVotes.AutoSize = true;
            this._lblVotes.Font = new System.Drawing.Font("Segoe UI Variable Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblVotes.ForeColor = System.Drawing.Color.DeepPink;
            this._lblVotes.Location = new System.Drawing.Point(622, 136);
            this._lblVotes.Name = "_lblVotes";
            this._lblVotes.Size = new System.Drawing.Size(36, 36);
            this._lblVotes.TabIndex = 179;
            this._lblVotes.Text = "...";
            // 
            // _lblHeader
            // 
            this._lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblHeader.AutoEllipsis = true;
            this._lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._lblHeader.Location = new System.Drawing.Point(95, 30);
            this._lblHeader.Name = "_lblHeader";
            this._lblHeader.Size = new System.Drawing.Size(936, 36);
            this._lblHeader.TabIndex = 180;
            this._lblHeader.Text = "Top Feature Requests of Windows 11 users";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.DeepPink;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.Black;
            this.btnAnalyze.Location = new System.Drawing.Point(100, 69);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(153, 25);
            this.btnAnalyze.TabIndex = 181;
            this.btnAnalyze.Text = "Add feedback";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // FeedbackPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this._lblHeader);
            this.Controls.Add(this._lblVotes);
            this.Controls.Add(this.richInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listFeedback);
            this.Name = "FeedbackPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listFeedback;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox richInfo;
        private System.Windows.Forms.Label _lblVotes;
        private System.Windows.Forms.Label _lblHeader;
        private System.Windows.Forms.Button btnAnalyze;
    }
}
