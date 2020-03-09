namespace DDD.WinForm
{
    partial class DDDView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.runDistTextBox = new System.Windows.Forms.TextBox();
            this.engineTypeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inspectionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstRegistTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "車輛ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "車輛名";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Location = new System.Drawing.Point(75, 47);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.carNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "走行距離";
            // 
            // runDistTextBox
            // 
            this.runDistTextBox.Location = new System.Drawing.Point(75, 97);
            this.runDistTextBox.Name = "runDistTextBox";
            this.runDistTextBox.Size = new System.Drawing.Size(100, 19);
            this.runDistTextBox.TabIndex = 6;
            // 
            // engineTypeTextBox
            // 
            this.engineTypeTextBox.Location = new System.Drawing.Point(75, 122);
            this.engineTypeTextBox.Name = "engineTypeTextBox";
            this.engineTypeTextBox.Size = new System.Drawing.Size(100, 19);
            this.engineTypeTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "エンジン種別";
            // 
            // inspectionTextBox
            // 
            this.inspectionTextBox.Location = new System.Drawing.Point(75, 147);
            this.inspectionTextBox.Name = "inspectionTextBox";
            this.inspectionTextBox.Size = new System.Drawing.Size(100, 19);
            this.inspectionTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "車検";
            // 
            // repairTextBox
            // 
            this.repairTextBox.Location = new System.Drawing.Point(75, 172);
            this.repairTextBox.Name = "repairTextBox";
            this.repairTextBox.Size = new System.Drawing.Size(100, 19);
            this.repairTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "修復歴";
            // 
            // firstRegistTextBox
            // 
            this.firstRegistTextBox.Location = new System.Drawing.Point(75, 72);
            this.firstRegistTextBox.Name = "firstRegistTextBox";
            this.firstRegistTextBox.Size = new System.Drawing.Size(100, 19);
            this.firstRegistTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "初度登録";
            // 
            // DDDView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 214);
            this.Controls.Add(this.firstRegistTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.repairTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inspectionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.engineTypeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.runDistTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "DDDView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DDDView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox runDistTextBox;
        private System.Windows.Forms.TextBox engineTypeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inspectionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstRegistTextBox;
        private System.Windows.Forms.Label label7;
    }
}

