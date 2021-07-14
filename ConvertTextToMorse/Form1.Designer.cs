namespace ConvertTextToMorse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rchtxtxbx_input = new System.Windows.Forms.RichTextBox();
            this.rchtxtxbx_output = new System.Windows.Forms.RichTextBox();
            this.btn_translate_to_morse = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_translate_to_string = new System.Windows.Forms.Button();
            this.rchtxtxbx_translated = new System.Windows.Forms.RichTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear_text = new System.Windows.Forms.Button();
            this.btn_clear_morse = new System.Windows.Forms.Button();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.btn_clear_translated_text = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxtxbx_input
            // 
            this.rchtxtxbx_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtxbx_input.Location = new System.Drawing.Point(0, 0);
            this.rchtxtxbx_input.Name = "rchtxtxbx_input";
            this.rchtxtxbx_input.Size = new System.Drawing.Size(393, 399);
            this.rchtxtxbx_input.TabIndex = 0;
            this.rchtxtxbx_input.Text = "";
            // 
            // rchtxtxbx_output
            // 
            this.rchtxtxbx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtxbx_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtxbx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxtxbx_output.Name = "rchtxtxbx_output";
            this.rchtxtxbx_output.Size = new System.Drawing.Size(405, 399);
            this.rchtxtxbx_output.TabIndex = 1;
            this.rchtxtxbx_output.Text = "";
            // 
            // btn_translate_to_morse
            // 
            this.btn_translate_to_morse.Location = new System.Drawing.Point(16, 5);
            this.btn_translate_to_morse.Name = "btn_translate_to_morse";
            this.btn_translate_to_morse.Size = new System.Drawing.Size(223, 39);
            this.btn_translate_to_morse.TabIndex = 2;
            this.btn_translate_to_morse.Text = "Translate to Morse";
            this.btn_translate_to_morse.UseVisualStyleBackColor = true;
            this.btn_translate_to_morse.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(18, 5);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(92, 39);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play Morse";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_translate_to_string
            // 
            this.btn_translate_to_string.Location = new System.Drawing.Point(4, 5);
            this.btn_translate_to_string.Name = "btn_translate_to_string";
            this.btn_translate_to_string.Size = new System.Drawing.Size(139, 39);
            this.btn_translate_to_string.TabIndex = 5;
            this.btn_translate_to_string.Text = "Translate to Text";
            this.btn_translate_to_string.UseVisualStyleBackColor = true;
            this.btn_translate_to_string.Click += new System.EventHandler(this.btn_translate_to_string_Click);
            // 
            // rchtxtxbx_translated
            // 
            this.rchtxtxbx_translated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtxbx_translated.Enabled = false;
            this.rchtxtxbx_translated.Location = new System.Drawing.Point(0, 0);
            this.rchtxtxbx_translated.Name = "rchtxtxbx_translated";
            this.rchtxtxbx_translated.Size = new System.Drawing.Size(395, 399);
            this.rchtxtxbx_translated.TabIndex = 6;
            this.rchtxtxbx_translated.Text = "";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(5, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 38);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear_text
            // 
            this.btn_clear_text.Location = new System.Drawing.Point(17, 5);
            this.btn_clear_text.Name = "btn_clear_text";
            this.btn_clear_text.Size = new System.Drawing.Size(93, 38);
            this.btn_clear_text.TabIndex = 8;
            this.btn_clear_text.Text = "Clear Text";
            this.btn_clear_text.UseVisualStyleBackColor = true;
            this.btn_clear_text.Click += new System.EventHandler(this.btn_clear_text_Click);
            // 
            // btn_clear_morse
            // 
            this.btn_clear_morse.Location = new System.Drawing.Point(8, 5);
            this.btn_clear_morse.Name = "btn_clear_morse";
            this.btn_clear_morse.Size = new System.Drawing.Size(95, 38);
            this.btn_clear_morse.TabIndex = 9;
            this.btn_clear_morse.Text = "Clear Morse";
            this.btn_clear_morse.UseVisualStyleBackColor = true;
            this.btn_clear_morse.Click += new System.EventHandler(this.btn_clear_morse_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.Location = new System.Drawing.Point(14, 5);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(95, 38);
            this.btn_clear_all.TabIndex = 10;
            this.btn_clear_all.Text = "Clear All";
            this.btn_clear_all.UseVisualStyleBackColor = true;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // btn_clear_translated_text
            // 
            this.btn_clear_translated_text.Location = new System.Drawing.Point(5, 5);
            this.btn_clear_translated_text.Name = "btn_clear_translated_text";
            this.btn_clear_translated_text.Size = new System.Drawing.Size(141, 38);
            this.btn_clear_translated_text.TabIndex = 11;
            this.btn_clear_translated_text.Text = "Clear Translated";
            this.btn_clear_translated_text.UseVisualStyleBackColor = true;
            this.btn_clear_translated_text.Click += new System.EventHandler(this.btn_clear_translated_text_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Text to Translate";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Morse";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Morse to Text";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 505);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(402, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 34);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rchtxtxbx_input);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 399);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rchtxtxbx_output);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(402, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 399);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(813, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 34);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rchtxtxbx_translated);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(813, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 399);
            this.panel6.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 448);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(393, 54);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_clear_text);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(126, 48);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_translate_to_morse);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(135, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 48);
            this.panel8.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel11, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(402, 448);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 54);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_clear_morse);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(111, 48);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_play);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(120, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(129, 48);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_translate_to_string);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(255, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(147, 48);
            this.panel11.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.08772F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.91228F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel13, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(813, 448);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(395, 54);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_clear_translated_text);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(151, 48);
            this.panel12.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_clear_all);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(160, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(122, 48);
            this.panel13.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_exit);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(288, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(104, 48);
            this.panel14.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Convert Text to Morse Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtxbx_input;
        private System.Windows.Forms.RichTextBox rchtxtxbx_output;
        private System.Windows.Forms.Button btn_translate_to_morse;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_translate_to_string;
        private System.Windows.Forms.RichTextBox rchtxtxbx_translated;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear_text;
        private System.Windows.Forms.Button btn_clear_morse;
        private System.Windows.Forms.Button btn_clear_all;
        private System.Windows.Forms.Button btn_clear_translated_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
    }
}

