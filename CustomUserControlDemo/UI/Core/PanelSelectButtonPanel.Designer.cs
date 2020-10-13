namespace CustomUserControlDemo.UI.Core
{
    partial class PanelSelectButtonPanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonBPanel = new System.Windows.Forms.Button();
            this.ButtonAPanel = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Controls.Add(this.ButtonBPanel, 1, 0);
            this.MainPanel.Controls.Add(this.ButtonAPanel, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 1;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Size = new System.Drawing.Size(712, 150);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonBPanel
            // 
            this.ButtonBPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBPanel.Location = new System.Drawing.Point(406, 50);
            this.ButtonBPanel.Margin = new System.Windows.Forms.Padding(50);
            this.ButtonBPanel.Name = "ButtonBPanel";
            this.ButtonBPanel.Size = new System.Drawing.Size(256, 50);
            this.ButtonBPanel.TabIndex = 1;
            this.ButtonBPanel.Text = "BControl";
            this.ButtonBPanel.UseVisualStyleBackColor = true;
            // 
            // ButtonAPanel
            // 
            this.ButtonAPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAPanel.Location = new System.Drawing.Point(50, 50);
            this.ButtonAPanel.Margin = new System.Windows.Forms.Padding(50);
            this.ButtonAPanel.Name = "ButtonAPanel";
            this.ButtonAPanel.Size = new System.Drawing.Size(256, 50);
            this.ButtonAPanel.TabIndex = 0;
            this.ButtonAPanel.Text = "AControl";
            this.ButtonAPanel.UseVisualStyleBackColor = true;
            // 
            // PanelSelectButtonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "PanelSelectButtonPanel";
            this.Size = new System.Drawing.Size(712, 150);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Button ButtonAPanel;
        private System.Windows.Forms.Button ButtonBPanel;
    }
}
