namespace MouseAndKey
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mName = new System.Windows.Forms.Label();
            this.kName = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyboard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mButton = new System.Windows.Forms.Button();
            this.kButton = new System.Windows.Forms.Button();
            this.mPosition = new System.Windows.Forms.Label();
            this.xP = new System.Windows.Forms.Label();
            this.xPtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yPtxt = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_E = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.매크로단축키설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.exp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyRepeat = new System.Windows.Forms.TextBox();
            this.txtMdelay = new System.Windows.Forms.TextBox();
            this.txtKdelay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Location = new System.Drawing.Point(35, 44);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(81, 12);
            this.mName.TabIndex = 0;
            this.mName.Text = "마우스 매크로";
            // 
            // kName
            // 
            this.kName.AutoSize = true;
            this.kName.Location = new System.Drawing.Point(278, 44);
            this.kName.Name = "kName";
            this.kName.Size = new System.Drawing.Size(81, 12);
            this.kName.TabIndex = 5;
            this.kName.Text = "키보드 매크로";
          
            // 
            // cnt
            // 
            this.cnt.Location = new System.Drawing.Point(111, 103);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(57, 21);
            this.cnt.TabIndex = 8;
            this.cnt.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "반복횟수 :";
            // 
            // txtKeyboard
            // 
            this.txtKeyboard.Location = new System.Drawing.Point(354, 130);
            this.txtKeyboard.Name = "txtKeyboard";
            this.txtKeyboard.Size = new System.Drawing.Size(104, 21);
            this.txtKeyboard.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "문장 : ";
            // 
            // mButton
            // 
            this.mButton.Location = new System.Drawing.Point(102, 239);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(57, 23);
            this.mButton.TabIndex = 11;
            this.mButton.Text = "실행";
            this.mButton.UseVisualStyleBackColor = true;
            this.mButton.Click += new System.EventHandler(this.mButton_Click);
            // 
            // kButton
            // 
            this.kButton.Location = new System.Drawing.Point(303, 239);
            this.kButton.Name = "kButton";
            this.kButton.Size = new System.Drawing.Size(56, 23);
            this.kButton.TabIndex = 15;
            this.kButton.Text = "실행";
            this.kButton.UseVisualStyleBackColor = true;
            this.kButton.Click += new System.EventHandler(this.kButton_Click);
            // 
            // mPosition
            // 
            this.mPosition.AutoSize = true;
            this.mPosition.Location = new System.Drawing.Point(35, 77);
            this.mPosition.Name = "mPosition";
            this.mPosition.Size = new System.Drawing.Size(41, 12);
            this.mPosition.TabIndex = 1;
            this.mPosition.Text = "좌표 : ";
            // 
            // xP
            // 
            this.xP.AutoSize = true;
            this.xP.Location = new System.Drawing.Point(35, 133);
            this.xP.Name = "xP";
            this.xP.Size = new System.Drawing.Size(44, 12);
            this.xP.TabIndex = 3;
            this.xP.Text = "x좌표 :";
            // 
            // xPtxt
            // 
            this.xPtxt.Location = new System.Drawing.Point(111, 130);
            this.xPtxt.Name = "xPtxt";
            this.xPtxt.Size = new System.Drawing.Size(57, 21);
            this.xPtxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "y좌표 :";
            // 
            // yPtxt
            // 
            this.yPtxt.Location = new System.Drawing.Point(111, 161);
            this.yPtxt.Name = "yPtxt";
            this.yPtxt.Size = new System.Drawing.Size(57, 21);
            this.yPtxt.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_E
            // 
            this.btn_E.Location = new System.Drawing.Point(365, 239);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(57, 23);
            this.btn_E.TabIndex = 16;
            this.btn_E.Text = "종료";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.information});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매크로단축키설정ToolStripMenuItem,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(43, 20);
            this.file.Text = "파일";
            // 
            // 매크로단축키설정ToolStripMenuItem
            // 
            this.매크로단축키설정ToolStripMenuItem.Name = "매크로단축키설정ToolStripMenuItem";
            this.매크로단축키설정ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.매크로단축키설정ToolStripMenuItem.Text = "매크로 단축키 설정";
            this.매크로단축키설정ToolStripMenuItem.Click += new System.EventHandler(this.매크로단축키설정ToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 22);
            this.exit.Text = "종료";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // information
            // 
            this.information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exp});
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(43, 20);
            this.information.Text = "정보";
            // 
            // exp
            // 
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(98, 22);
            this.exp.Text = "설명";
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "반복횟수 :";
            // 
            // txtKeyRepeat
            // 
            this.txtKeyRepeat.Location = new System.Drawing.Point(354, 103);
            this.txtKeyRepeat.Name = "txtKeyRepeat";
            this.txtKeyRepeat.Size = new System.Drawing.Size(57, 21);
            this.txtKeyRepeat.TabIndex = 13;
            this.txtKeyRepeat.Text = "5";
            // 
            // txtMdelay
            // 
            this.txtMdelay.Location = new System.Drawing.Point(111, 189);
            this.txtMdelay.Name = "txtMdelay";
            this.txtMdelay.Size = new System.Drawing.Size(57, 21);
            this.txtMdelay.TabIndex = 11;
            this.txtMdelay.Text = "100";
            // 
            // txtKdelay
            // 
            this.txtKdelay.Location = new System.Drawing.Point(354, 158);
            this.txtKdelay.Name = "txtKdelay";
            this.txtKdelay.Size = new System.Drawing.Size(57, 21);
            this.txtKdelay.TabIndex = 15;
            this.txtKdelay.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "시간 지연 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "시간 지연 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKdelay);
            this.Controls.Add(this.txtMdelay);
            this.Controls.Add(this.txtKeyRepeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yPtxt);
            this.Controls.Add(this.xP);
            this.Controls.Add(this.xPtxt);
            this.Controls.Add(this.mPosition);
            this.Controls.Add(this.kButton);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeyboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.kName);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "마우스 키보드 매크로";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mName;
        private System.Windows.Forms.Label kName;
        private System.Windows.Forms.TextBox cnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mButton;
        private System.Windows.Forms.Button kButton;
        private System.Windows.Forms.Label mPosition;
        private System.Windows.Forms.Label xP;
        private System.Windows.Forms.TextBox xPtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yPtxt;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.ToolStripMenuItem exp;
        private System.Windows.Forms.ToolStripMenuItem 매크로단축키설정ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyRepeat;
        private System.Windows.Forms.TextBox txtMdelay;
        private System.Windows.Forms.TextBox txtKdelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

