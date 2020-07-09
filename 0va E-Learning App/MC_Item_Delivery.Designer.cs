namespace _0va_E_Learning_App
{
    partial class MC_Item_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC_Item_Delivery));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.next_item = new System.Windows.Forms.Button();
            this.last_item = new System.Windows.Forms.Button();
            this.previous_item = new System.Windows.Forms.Button();
            this.first_item = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.time_remaining = new System.Windows.Forms.Label();
            this.question_number = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.item_number = new System.Windows.Forms.Label();
            this.STEM = new System.Windows.Forms.Label();
            this.option_A_text = new System.Windows.Forms.Label();
            this.option_B_text = new System.Windows.Forms.Label();
            this.option_C_text = new System.Windows.Forms.Label();
            this.option_D_text = new System.Windows.Forms.Label();
            this.optionA = new System.Windows.Forms.RadioButton();
            this.optionB = new System.Windows.Forms.RadioButton();
            this.optionC = new System.Windows.Forms.RadioButton();
            this.optionD = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.next_item);
            this.panel1.Controls.Add(this.last_item);
            this.panel1.Controls.Add(this.previous_item);
            this.panel1.Controls.Add(this.first_item);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.time_remaining);
            this.panel1.Controls.Add(this.question_number);
            this.panel1.Location = new System.Drawing.Point(317, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 143);
            this.panel1.TabIndex = 1;
            // 
            // next_item
            // 
            this.next_item.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next_item.Location = new System.Drawing.Point(282, 20);
            this.next_item.Name = "next_item";
            this.next_item.Size = new System.Drawing.Size(75, 30);
            this.next_item.TabIndex = 6;
            this.next_item.Text = ">";
            this.next_item.UseVisualStyleBackColor = false;
            this.next_item.Click += new System.EventHandler(this.next_item_Click);
            // 
            // last_item
            // 
            this.last_item.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.last_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.last_item.Location = new System.Drawing.Point(378, 20);
            this.last_item.Name = "last_item";
            this.last_item.Size = new System.Drawing.Size(75, 30);
            this.last_item.TabIndex = 5;
            this.last_item.Text = ">>";
            this.last_item.UseVisualStyleBackColor = false;
            this.last_item.Click += new System.EventHandler(this.last_item_Click);
            // 
            // previous_item
            // 
            this.previous_item.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.previous_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previous_item.Location = new System.Drawing.Point(106, 20);
            this.previous_item.Name = "previous_item";
            this.previous_item.Size = new System.Drawing.Size(75, 30);
            this.previous_item.TabIndex = 4;
            this.previous_item.Text = "<";
            this.previous_item.UseVisualStyleBackColor = false;
            this.previous_item.Click += new System.EventHandler(this.previous_item_Click);
            // 
            // first_item
            // 
            this.first_item.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.first_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_item.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.first_item.Location = new System.Drawing.Point(13, 20);
            this.first_item.Name = "first_item";
            this.first_item.Size = new System.Drawing.Size(75, 30);
            this.first_item.TabIndex = 3;
            this.first_item.Text = "<<";
            this.first_item.UseVisualStyleBackColor = false;
            this.first_item.Click += new System.EventHandler(this.first_item_Click);
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.Green;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit_button.Location = new System.Drawing.Point(157, 79);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(149, 41);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // time_remaining
            // 
            this.time_remaining.AutoSize = true;
            this.time_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_remaining.Location = new System.Drawing.Point(333, 78);
            this.time_remaining.Name = "time_remaining";
            this.time_remaining.Size = new System.Drawing.Size(95, 42);
            this.time_remaining.TabIndex = 1;
            this.time_remaining.Text = "1:30";
            // 
            // question_number
            // 
            this.question_number.AutoSize = true;
            this.question_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_number.Location = new System.Drawing.Point(3, 79);
            this.question_number.Name = "question_number";
            this.question_number.Size = new System.Drawing.Size(139, 42);
            this.question_number.TabIndex = 0;
            this.question_number.Text = "12 / 50";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.31443F));
            this.tableLayoutPanel1.Controls.Add(this.item_number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.STEM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.option_A_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.option_B_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.option_C_text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.option_D_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.optionA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.optionB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.optionC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.optionD, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 459);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // item_number
            // 
            this.item_number.AutoSize = true;
            this.item_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_number.ForeColor = System.Drawing.Color.MediumPurple;
            this.item_number.Location = new System.Drawing.Point(3, 0);
            this.item_number.Name = "item_number";
            this.item_number.Size = new System.Drawing.Size(139, 137);
            this.item_number.TabIndex = 0;
            this.item_number.Text = "1";
            this.item_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STEM
            // 
            this.STEM.AutoSize = true;
            this.STEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STEM.ForeColor = System.Drawing.Color.LightGray;
            this.STEM.Location = new System.Drawing.Point(148, 0);
            this.STEM.Name = "STEM";
            this.STEM.Size = new System.Drawing.Size(625, 137);
            this.STEM.TabIndex = 1;
            this.STEM.Text = "Overview";
            this.STEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_A_text
            // 
            this.option_A_text.AutoSize = true;
            this.option_A_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_A_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_A_text.ForeColor = System.Drawing.Color.LightGray;
            this.option_A_text.Location = new System.Drawing.Point(148, 137);
            this.option_A_text.Name = "option_A_text";
            this.option_A_text.Size = new System.Drawing.Size(625, 80);
            this.option_A_text.TabIndex = 2;
            this.option_A_text.Text = "Option1";
            this.option_A_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_B_text
            // 
            this.option_B_text.AutoSize = true;
            this.option_B_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_B_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_B_text.ForeColor = System.Drawing.Color.LightGray;
            this.option_B_text.Location = new System.Drawing.Point(148, 217);
            this.option_B_text.Name = "option_B_text";
            this.option_B_text.Size = new System.Drawing.Size(625, 80);
            this.option_B_text.TabIndex = 3;
            this.option_B_text.Text = "Option2";
            this.option_B_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_C_text
            // 
            this.option_C_text.AutoSize = true;
            this.option_C_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_C_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_C_text.ForeColor = System.Drawing.Color.LightGray;
            this.option_C_text.Location = new System.Drawing.Point(148, 297);
            this.option_C_text.Name = "option_C_text";
            this.option_C_text.Size = new System.Drawing.Size(625, 80);
            this.option_C_text.TabIndex = 4;
            this.option_C_text.Text = "Option3";
            this.option_C_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option_D_text
            // 
            this.option_D_text.AutoSize = true;
            this.option_D_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_D_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_D_text.ForeColor = System.Drawing.Color.LightGray;
            this.option_D_text.Location = new System.Drawing.Point(148, 377);
            this.option_D_text.Name = "option_D_text";
            this.option_D_text.Size = new System.Drawing.Size(625, 82);
            this.option_D_text.TabIndex = 5;
            this.option_D_text.Text = "Option4";
            this.option_D_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optionA
            // 
            this.optionA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionA.AutoSize = true;
            this.optionA.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionA.Location = new System.Drawing.Point(3, 140);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(139, 74);
            this.optionA.TabIndex = 6;
            this.optionA.TabStop = true;
            this.optionA.UseVisualStyleBackColor = true;
            // 
            // optionB
            // 
            this.optionB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionB.AutoSize = true;
            this.optionB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionB.Location = new System.Drawing.Point(3, 220);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(139, 74);
            this.optionB.TabIndex = 7;
            this.optionB.TabStop = true;
            this.optionB.UseVisualStyleBackColor = true;
            // 
            // optionC
            // 
            this.optionC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionC.AutoSize = true;
            this.optionC.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionC.Location = new System.Drawing.Point(3, 300);
            this.optionC.Name = "optionC";
            this.optionC.Size = new System.Drawing.Size(139, 74);
            this.optionC.TabIndex = 8;
            this.optionC.TabStop = true;
            this.optionC.UseVisualStyleBackColor = true;
            // 
            // optionD
            // 
            this.optionD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionD.AutoSize = true;
            this.optionD.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionD.Location = new System.Drawing.Point(3, 380);
            this.optionD.Name = "optionD";
            this.optionD.Size = new System.Drawing.Size(139, 76);
            this.optionD.TabIndex = 9;
            this.optionD.TabStop = true;
            this.optionD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionD.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MC_Item_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MC_Item_Delivery";
            this.Text = "MC_Item_Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button next_item;
        private System.Windows.Forms.Button last_item;
        private System.Windows.Forms.Button previous_item;
        private System.Windows.Forms.Button first_item;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label time_remaining;
        private System.Windows.Forms.Label question_number;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label item_number;
        private System.Windows.Forms.Label STEM;
        private System.Windows.Forms.Label option_A_text;
        private System.Windows.Forms.Label option_B_text;
        private System.Windows.Forms.Label option_C_text;
        private System.Windows.Forms.Label option_D_text;
        private System.Windows.Forms.RadioButton optionA;
        private System.Windows.Forms.RadioButton optionB;
        private System.Windows.Forms.RadioButton optionC;
        private System.Windows.Forms.RadioButton optionD;
        private System.Windows.Forms.Timer timer1;
    }
}