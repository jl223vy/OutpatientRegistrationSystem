﻿namespace OutpatientRegistrationSystem
{
    partial class Frm_appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_appointment));
            this.cmb_docname = new System.Windows.Forms.ComboBox();
            this.cmb_regname = new System.Windows.Forms.ComboBox();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.dtp_regDate = new System.Windows.Forms.DateTimePicker();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.dtp_regTime = new System.Windows.Forms.DateTimePicker();
            this.btn_addnewpatient = new System.Windows.Forms.Button();
            this.tb_cardno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_addappointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_regfee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_regid = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_patientNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.btn_printAppo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_operater = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_docname
            // 
            this.cmb_docname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_docname.FormattingEnabled = true;
            this.cmb_docname.Location = new System.Drawing.Point(284, 20);
            this.cmb_docname.Name = "cmb_docname";
            this.cmb_docname.Size = new System.Drawing.Size(93, 20);
            this.cmb_docname.TabIndex = 13;
            this.cmb_docname.SelectedIndexChanged += new System.EventHandler(this.cmb_docname_SelectedIndexChanged);
            // 
            // cmb_regname
            // 
            this.cmb_regname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regname.FormattingEnabled = true;
            this.cmb_regname.Location = new System.Drawing.Point(79, 49);
            this.cmb_regname.Name = "cmb_regname";
            this.cmb_regname.Size = new System.Drawing.Size(120, 20);
            this.cmb_regname.TabIndex = 11;
            this.cmb_regname.SelectedIndexChanged += new System.EventHandler(this.cmb_regname_SelectedIndexChanged);
            // 
            // cmb_dept
            // 
            this.cmb_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.ItemHeight = 12;
            this.cmb_dept.Location = new System.Drawing.Point(79, 21);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(120, 20);
            this.cmb_dept.TabIndex = 10;
            // 
            // dtp_regDate
            // 
            this.dtp_regDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_regDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_regDate.Location = new System.Drawing.Point(476, 18);
            this.dtp_regDate.Name = "dtp_regDate";
            this.dtp_regDate.Size = new System.Drawing.Size(129, 21);
            this.dtp_regDate.TabIndex = 9;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(285, 54);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(128, 21);
            this.tb_tel.TabIndex = 19;
            // 
            // dtp_regTime
            // 
            this.dtp_regTime.CustomFormat = "hh:mm";
            this.dtp_regTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_regTime.Location = new System.Drawing.Point(476, 48);
            this.dtp_regTime.Name = "dtp_regTime";
            this.dtp_regTime.Size = new System.Drawing.Size(129, 21);
            this.dtp_regTime.TabIndex = 7;
            // 
            // btn_addnewpatient
            // 
            this.btn_addnewpatient.Location = new System.Drawing.Point(749, 53);
            this.btn_addnewpatient.Name = "btn_addnewpatient";
            this.btn_addnewpatient.Size = new System.Drawing.Size(75, 23);
            this.btn_addnewpatient.TabIndex = 20;
            this.btn_addnewpatient.Text = "添加新病人资料";
            this.btn_addnewpatient.UseVisualStyleBackColor = true;
            this.btn_addnewpatient.Click += new System.EventHandler(this.btn_addnewpatient_Click);
            // 
            // tb_cardno
            // 
            this.tb_cardno.Location = new System.Drawing.Point(529, 19);
            this.tb_cardno.Name = "tb_cardno";
            this.tb_cardno.Size = new System.Drawing.Size(170, 21);
            this.tb_cardno.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "挂号费用：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "预约医生：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(458, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "就诊卡号：";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(529, 54);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(170, 21);
            this.tb_id.TabIndex = 10;
            // 
            // btn_addappointment
            // 
            this.btn_addappointment.Location = new System.Drawing.Point(748, 52);
            this.btn_addappointment.Name = "btn_addappointment";
            this.btn_addappointment.Size = new System.Drawing.Size(75, 23);
            this.btn_addappointment.TabIndex = 22;
            this.btn_addappointment.Text = "添加预约";
            this.btn_addappointment.UseVisualStyleBackColor = true;
            this.btn_addappointment.Click += new System.EventHandler(this.btn_addappointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "预约科室：";
            // 
            // cmb_regfee
            // 
            this.cmb_regfee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regfee.FormattingEnabled = true;
            this.cmb_regfee.Location = new System.Drawing.Point(284, 49);
            this.cmb_regfee.Name = "cmb_regfee";
            this.cmb_regfee.Size = new System.Drawing.Size(93, 20);
            this.cmb_regfee.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "挂号类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "预约日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "预约时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "联系电话：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_regid);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.cmb_regfee);
            this.groupBox2.Controls.Add(this.btn_addappointment);
            this.groupBox2.Controls.Add(this.cmb_docname);
            this.groupBox2.Controls.Add(this.cmb_regname);
            this.groupBox2.Controls.Add(this.cmb_dept);
            this.groupBox2.Controls.Add(this.dtp_regDate);
            this.groupBox2.Controls.Add(this.dtp_regTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(216, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 83);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预约信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "预约号：";
            // 
            // tb_regid
            // 
            this.tb_regid.Enabled = false;
            this.tb_regid.Location = new System.Drawing.Point(679, 19);
            this.tb_regid.Name = "tb_regid";
            this.tb_regid.Size = new System.Drawing.Size(48, 21);
            this.tb_regid.TabIndex = 37;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(748, 18);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 33;
            this.btn_cancel.Text = "作废";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "卡类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "病人姓名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(842, 346);
            this.dataGridView1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(446, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "身份证号码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_patientNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_cardtype);
            this.groupBox1.Controls.Add(this.btn_addnewpatient);
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.tb_cardno);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 89);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人资料";
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(80, 53);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(124, 21);
            this.tb_patientNo.TabIndex = 97;
            this.tb_patientNo.TextChanged += new System.EventHandler(this.tb_patientNo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 96;
            this.label12.Text = "患者编号：";
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Location = new System.Drawing.Point(285, 21);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(128, 20);
            this.cmb_cardtype.TabIndex = 92;
            // 
            // btn_printAppo
            // 
            this.btn_printAppo.Location = new System.Drawing.Point(964, 548);
            this.btn_printAppo.Name = "btn_printAppo";
            this.btn_printAppo.Size = new System.Drawing.Size(75, 23);
            this.btn_printAppo.TabIndex = 23;
            this.btn_printAppo.Text = "打印预约单";
            this.btn_printAppo.UseVisualStyleBackColor = true;
            this.btn_printAppo.Click += new System.EventHandler(this.btn_printAppo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "【操作员】";
            // 
            // lb_operater
            // 
            this.lb_operater.AutoSize = true;
            this.lb_operater.Location = new System.Drawing.Point(273, 553);
            this.lb_operater.Name = "lb_operater";
            this.lb_operater.Size = new System.Drawing.Size(0, 12);
            this.lb_operater.TabIndex = 26;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(868, 548);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 27;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(80, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(124, 21);
            this.tb_name.TabIndex = 99;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(203, 547);
            this.dataGridView2.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "病人列表：";
            // 
            // Frm_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1062, 574);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_operater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_printAppo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_appointment";
            this.Text = "患者预约 ";
            this.Load += new System.EventHandler(this.Frm_appointment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_docname;
        private System.Windows.Forms.ComboBox cmb_regname;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.DateTimePicker dtp_regDate;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.DateTimePicker dtp_regTime;
        private System.Windows.Forms.Button btn_addnewpatient;
        private System.Windows.Forms.TextBox tb_cardno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_addappointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_regfee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_cardtype;
        private System.Windows.Forms.TextBox tb_patientNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_printAppo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_operater;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_regid;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;

    }
}