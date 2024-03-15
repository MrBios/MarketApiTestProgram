using System.Windows.Forms;

namespace MarketApiTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.binanceTextBox = new System.Windows.Forms.TextBox();
            this.bybitTextBox = new System.Windows.Forms.TextBox();
            this.kucoinTextBox = new System.Windows.Forms.TextBox();
            this.bitgetTextBox = new System.Windows.Forms.TextBox();
            this.pairBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // binanceTextBox
            // 
            this.binanceTextBox.Location = new System.Drawing.Point(33, 87);
            this.binanceTextBox.Name = "binanceTextBox";
            this.binanceTextBox.ReadOnly = true;
            this.binanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.binanceTextBox.TabIndex = 1;
            // 
            // bybitTextBox
            // 
            this.bybitTextBox.Location = new System.Drawing.Point(181, 87);
            this.bybitTextBox.Name = "bybitTextBox";
            this.bybitTextBox.ReadOnly = true;
            this.bybitTextBox.Size = new System.Drawing.Size(100, 22);
            this.bybitTextBox.TabIndex = 2;
            // 
            // kucoinTextBox
            // 
            this.kucoinTextBox.Location = new System.Drawing.Point(33, 139);
            this.kucoinTextBox.Name = "kucoinTextBox";
            this.kucoinTextBox.ReadOnly = true;
            this.kucoinTextBox.Size = new System.Drawing.Size(100, 22);
            this.kucoinTextBox.TabIndex = 3;
            // 
            // bitgetTextBox
            // 
            this.bitgetTextBox.Location = new System.Drawing.Point(181, 139);
            this.bitgetTextBox.Name = "bitgetTextBox";
            this.bitgetTextBox.ReadOnly = true;
            this.bitgetTextBox.Size = new System.Drawing.Size(100, 22);
            this.bitgetTextBox.TabIndex = 4;
            // 
            // pairBox
            // 
            this.pairBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pairBox.FormattingEnabled = true;
            this.pairBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pairBox.Location = new System.Drawing.Point(98, 33);
            this.pairBox.Name = "pairBox";
            this.pairBox.Size = new System.Drawing.Size(121, 24);
            this.pairBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "выбор пары";
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(12, 179);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(291, 33);
            this.infoText.TabIndex = 7;
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Binance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kucoin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bybit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bitget";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 217);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pairBox);
            this.Controls.Add(this.bitgetTextBox);
            this.Controls.Add(this.kucoinTextBox);
            this.Controls.Add(this.bybitTextBox);
            this.Controls.Add(this.binanceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Цена криптовалюты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox binanceTextBox;
        private System.Windows.Forms.TextBox bybitTextBox;
        private System.Windows.Forms.TextBox kucoinTextBox;
        private System.Windows.Forms.TextBox bitgetTextBox;
        private System.Windows.Forms.ComboBox pairBox;
        private System.Windows.Forms.Label label1;
        private Label infoText;
        private Timer timer;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

