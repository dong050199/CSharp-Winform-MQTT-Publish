
namespace MQTTTest
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
            this.tb_data1 = new System.Windows.Forms.TextBox();
            this.tb_data2 = new System.Windows.Forms.TextBox();
            this.tb_data3 = new System.Windows.Forms.TextBox();
            this.tb_data4 = new System.Windows.Forms.TextBox();
            this.bt_Pub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_data1
            // 
            this.tb_data1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data1.Location = new System.Drawing.Point(134, 48);
            this.tb_data1.Name = "tb_data1";
            this.tb_data1.Size = new System.Drawing.Size(98, 31);
            this.tb_data1.TabIndex = 0;
            // 
            // tb_data2
            // 
            this.tb_data2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data2.Location = new System.Drawing.Point(134, 102);
            this.tb_data2.Name = "tb_data2";
            this.tb_data2.Size = new System.Drawing.Size(98, 31);
            this.tb_data2.TabIndex = 1;
            // 
            // tb_data3
            // 
            this.tb_data3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data3.Location = new System.Drawing.Point(134, 157);
            this.tb_data3.Name = "tb_data3";
            this.tb_data3.Size = new System.Drawing.Size(98, 31);
            this.tb_data3.TabIndex = 2;
            // 
            // tb_data4
            // 
            this.tb_data4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data4.Location = new System.Drawing.Point(134, 217);
            this.tb_data4.Name = "tb_data4";
            this.tb_data4.Size = new System.Drawing.Size(98, 31);
            this.tb_data4.TabIndex = 3;
            // 
            // bt_Pub
            // 
            this.bt_Pub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Pub.Location = new System.Drawing.Point(35, 266);
            this.bt_Pub.Name = "bt_Pub";
            this.bt_Pub.Size = new System.Drawing.Size(197, 56);
            this.bt_Pub.TabIndex = 4;
            this.bt_Pub.Text = "Publish";
            this.bt_Pub.UseVisualStyleBackColor = true;
            this.bt_Pub.Click += new System.EventHandler(this.bt_Pub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "data1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "data2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "data3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "data4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Pub);
            this.Controls.Add(this.tb_data4);
            this.Controls.Add(this.tb_data3);
            this.Controls.Add(this.tb_data2);
            this.Controls.Add(this.tb_data1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_data1;
        private System.Windows.Forms.TextBox tb_data2;
        private System.Windows.Forms.TextBox tb_data3;
        private System.Windows.Forms.TextBox tb_data4;
        private System.Windows.Forms.Button bt_Pub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

