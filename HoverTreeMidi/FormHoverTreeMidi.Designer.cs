namespace HoverTreeMidi
{
    partial class FormHoverTreeMidi
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoverTreeMidi));
            this.button_shortPlay = new System.Windows.Forms.Button();
            this.label_volumn = new System.Windows.Forms.Label();
            this.numericUpDown_volumn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_key = new System.Windows.Forms.NumericUpDown();
            this.label_key = new System.Windows.Forms.Label();
            this.label_chanel = new System.Windows.Forms.Label();
            this.numericUpDown_chenel = new System.Windows.Forms.NumericUpDown();
            this.label_hoverTree = new System.Windows.Forms.Label();
            this.linkLabel_hoverTree = new System.Windows.Forms.LinkLabel();
            this.label_www = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chenel)).BeginInit();
            this.SuspendLayout();
            // 
            // button_shortPlay
            // 
            this.button_shortPlay.Location = new System.Drawing.Point(106, 175);
            this.button_shortPlay.Name = "button_shortPlay";
            this.button_shortPlay.Size = new System.Drawing.Size(98, 23);
            this.button_shortPlay.TabIndex = 10;
            this.button_shortPlay.Text = "播放声音";
            this.button_shortPlay.UseVisualStyleBackColor = true;
            this.button_shortPlay.Click += new System.EventHandler(this.button_shortPlay_Click);
            // 
            // label_volumn
            // 
            this.label_volumn.AutoSize = true;
            this.label_volumn.Location = new System.Drawing.Point(47, 136);
            this.label_volumn.Name = "label_volumn";
            this.label_volumn.Size = new System.Drawing.Size(41, 12);
            this.label_volumn.TabIndex = 16;
            this.label_volumn.Text = "音量：";
            // 
            // numericUpDown_volumn
            // 
            this.numericUpDown_volumn.Location = new System.Drawing.Point(106, 134);
            this.numericUpDown_volumn.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown_volumn.Name = "numericUpDown_volumn";
            this.numericUpDown_volumn.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_volumn.TabIndex = 40;
            this.numericUpDown_volumn.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDown_key
            // 
            this.numericUpDown_key.Location = new System.Drawing.Point(106, 57);
            this.numericUpDown_key.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_key.Name = "numericUpDown_key";
            this.numericUpDown_key.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_key.TabIndex = 20;
            this.numericUpDown_key.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(47, 59);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(41, 12);
            this.label_key.TabIndex = 13;
            this.label_key.Text = "音高：";
            // 
            // label_chanel
            // 
            this.label_chanel.AutoSize = true;
            this.label_chanel.Location = new System.Drawing.Point(47, 99);
            this.label_chanel.Name = "label_chanel";
            this.label_chanel.Size = new System.Drawing.Size(41, 12);
            this.label_chanel.TabIndex = 12;
            this.label_chanel.Text = "频道：";
            // 
            // numericUpDown_chenel
            // 
            this.numericUpDown_chenel.Location = new System.Drawing.Point(106, 93);
            this.numericUpDown_chenel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_chenel.Name = "numericUpDown_chenel";
            this.numericUpDown_chenel.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_chenel.TabIndex = 30;
            // 
            // label_hoverTree
            // 
            this.label_hoverTree.AutoSize = true;
            this.label_hoverTree.Font = new System.Drawing.Font("宋体", 20F);
            this.label_hoverTree.Location = new System.Drawing.Point(67, 9);
            this.label_hoverTree.Name = "label_hoverTree";
            this.label_hoverTree.Size = new System.Drawing.Size(149, 27);
            this.label_hoverTree.TabIndex = 18;
            this.label_hoverTree.Text = "何问起MIDI";
            // 
            // linkLabel_hoverTree
            // 
            this.linkLabel_hoverTree.AutoSize = true;
            this.linkLabel_hoverTree.Location = new System.Drawing.Point(12, 241);
            this.linkLabel_hoverTree.Name = "linkLabel_hoverTree";
            this.linkLabel_hoverTree.Size = new System.Drawing.Size(41, 12);
            this.linkLabel_hoverTree.TabIndex = 50;
            this.linkLabel_hoverTree.TabStop = true;
            this.linkLabel_hoverTree.Text = "何问起";
            this.linkLabel_hoverTree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_hoverTree_LinkClicked);
            // 
            // label_www
            // 
            this.label_www.AutoSize = true;
            this.label_www.Font = new System.Drawing.Font("宋体", 16F);
            this.label_www.Location = new System.Drawing.Point(119, 233);
            this.label_www.Name = "label_www";
            this.label_www.Size = new System.Drawing.Size(153, 22);
            this.label_www.TabIndex = 51;
            this.label_www.Text = "hovertree.com";
            // 
            // FormHoverTreeMidi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_www);
            this.Controls.Add(this.linkLabel_hoverTree);
            this.Controls.Add(this.label_hoverTree);
            this.Controls.Add(this.button_shortPlay);
            this.Controls.Add(this.label_volumn);
            this.Controls.Add(this.numericUpDown_volumn);
            this.Controls.Add(this.numericUpDown_key);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label_chanel);
            this.Controls.Add(this.numericUpDown_chenel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHoverTreeMidi";
            this.Text = "何问起Midi v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chenel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_shortPlay;
        private System.Windows.Forms.Label label_volumn;
        private System.Windows.Forms.NumericUpDown numericUpDown_volumn;
        private System.Windows.Forms.NumericUpDown numericUpDown_key;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_chanel;
        private System.Windows.Forms.NumericUpDown numericUpDown_chenel;
        private System.Windows.Forms.Label label_hoverTree;
        private System.Windows.Forms.LinkLabel linkLabel_hoverTree;
        private System.Windows.Forms.Label label_www;
    }
}

