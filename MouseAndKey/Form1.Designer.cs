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
            this.mName = new System.Windows.Forms.Label();
            this.kName = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Location = new System.Drawing.Point(63, 44);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(81, 12);
            this.mName.TabIndex = 0;
            this.mName.Text = "마우스 매크로";
            // 
            // kName
            // 
            this.kName.AutoSize = true;
            this.kName.Location = new System.Drawing.Point(302, 44);
            this.kName.Name = "kName";
            this.kName.Size = new System.Drawing.Size(81, 12);
            this.kName.TabIndex = 1;
            this.kName.Text = "키보드 매크로";
            // 
            // cnt
            // 
            this.cnt.Location = new System.Drawing.Point(110, 101);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(57, 21);
            this.cnt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "횟 수 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "문장 : ";
            // 
            // mButton
            // 
            this.mButton.Location = new System.Drawing.Point(110, 196);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(57, 23);
            this.mButton.TabIndex = 6;
            this.mButton.Text = "실행";
            this.mButton.UseVisualStyleBackColor = true;
            this.mButton.Click += new System.EventHandler(this.mButton_Click);
            // 
            // kButton
            // 
            this.kButton.Location = new System.Drawing.Point(395, 166);
            this.kButton.Name = "kButton";
            this.kButton.Size = new System.Drawing.Size(56, 23);
            this.kButton.TabIndex = 7;
            this.kButton.Text = "실행";
            this.kButton.UseVisualStyleBackColor = true;
            // 
            // mPosition
            // 
            this.mPosition.AutoSize = true;
            this.mPosition.Location = new System.Drawing.Point(63, 76);
            this.mPosition.Name = "mPosition";
            this.mPosition.Size = new System.Drawing.Size(41, 12);
            this.mPosition.TabIndex = 8;
            this.mPosition.Text = "좌표 : ";
            // 
            // xP
            // 
            this.xP.AutoSize = true;
            this.xP.Location = new System.Drawing.Point(61, 133);
            this.xP.Name = "xP";
            this.xP.Size = new System.Drawing.Size(44, 12);
            this.xP.TabIndex = 10;
            this.xP.Text = "x좌표 :";
            // 
            // xPtxt
            // 
            this.xPtxt.Location = new System.Drawing.Point(110, 128);
            this.xPtxt.Name = "xPtxt";
            this.xPtxt.Size = new System.Drawing.Size(57, 21);
            this.xPtxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "y좌표 :";
            // 
            // yPtxt
            // 
            this.yPtxt.Location = new System.Drawing.Point(110, 155);
            this.yPtxt.Name = "yPtxt";
            this.yPtxt.Size = new System.Drawing.Size(57, 21);
            this.yPtxt.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_E
            // 
            this.btn_E.Location = new System.Drawing.Point(173, 196);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(57, 23);
            this.btn_E.TabIndex = 13;
            this.btn_E.Text = "종료";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 348);
            this.Controls.Add(this.btn_E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yPtxt);
            this.Controls.Add(this.xP);
            this.Controls.Add(this.xPtxt);
            this.Controls.Add(this.mPosition);
            this.Controls.Add(this.kButton);
            this.Controls.Add(this.mButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.kName);
            this.Controls.Add(this.mName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "마우스 키보드";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mName;
        private System.Windows.Forms.Label kName;
        private System.Windows.Forms.TextBox cnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

