﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_registration : Form
    {
        sqlHelper mysql = new sqlHelper();
        public Frm_registration()
        {
            InitializeComponent();
        }

        private void btn_printReg_Click(object sender, EventArgs e)
        {
            userHelper.patientName = tb_patientNo.Text.Trim();
            Frm_printReg frm = new Frm_printReg();
            frm.Show();
        }

        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiParent.MdiChildren)
            {
                if (childFrm.Name == childfrmname)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btn_addnewpatient_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_patient") == true)
                return;
            Frm_patient frm = new Frm_patient();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void Frm_registration_Load(object sender, EventArgs e)
        {
            this.cmb_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmb_name.AutoCompleteSource = AutoCompleteSource.ListItems;

            //加载操作员
            lb_operater.Text = userHelper.operatorNo + "（" + userHelper.operatorName + "）";

            //使病人信息不可用
            cmb_cardtype.Enabled = false;
            tb_cardno.Enabled = false;
            tb_tel.Enabled = false;
            tb_patientNo.Enabled = false;
            tb_id.Enabled = false;

            //加载病人姓名
            this.getname();

            //加载医生
            DataSet getdocnameds = mysql.getds("select name from tb_doctor", "doctor");
            for (int i = 0; i < getdocnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_docname.Items.Add(getdocnameds.Tables[0].Rows[i][0]);
            }

            //加载科室
            DataSet getdeptds = mysql.getds("SELECT name FROM tb_dept", "dept");
            for (int i = 0; i < getdeptds.Tables[0].Rows.Count; i++)
            {
                this.cmb_dept.Items.Add(getdeptds.Tables[0].Rows[i][0]);
            }

            //添加挂号类型和挂号费用
            DataSet getRegds = mysql.getds("SELECT name,price FROM tb_regType", "regType");
            for (int i = 0; i < getRegds.Tables[0].Rows.Count; i++)
            {
                this.cmb_regname.Items.Add(getRegds.Tables[0].Rows[i][0]);
                this.cmb_regfee.Items.Add(getRegds.Tables[0].Rows[i][1]);
            }
            this.cmb_regname.SelectedIndex = 0;
            this.cmb_regfee.SelectedIndex = 0;

            //添加卡类型
            cmb_cardtype.Items.Add("就诊卡");
            cmb_cardtype.Items.Add("社保卡");
            cmb_cardtype.SelectedIndex = 0;
        }

        private void getname()
        {
            cmb_name.Items.Clear();
            DataSet getnameds = mysql.getds("SELECT name FROM tb_patient", "patient");
            for (int i = 0; i < getnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_name.Items.Add(getnameds.Tables[0].Rows[i][0]);
            }
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_name.Text;
            DataSet chanagenameds = mysql.getds("SELECT * FROM tb_patient WHERE name='" + tempstr + "'", "patient");
            tb_patientNo.Text = chanagenameds.Tables[0].Rows[0]["no"].ToString();
            tb_tel.Text = chanagenameds.Tables[0].Rows[0]["tel"].ToString();
            tb_id.Text = chanagenameds.Tables[0].Rows[0]["id"].ToString();
            tb_cardno.Text = chanagenameds.Tables[0].Rows[0]["visitNo"].ToString();
        }

        private void tb_cardno_TextChanged(object sender, EventArgs e)
        {
            if (tb_cardno.Text != "")
            {
                cmb_cardtype.SelectedIndex = 0;
            }
            else
            {
                cmb_cardtype.SelectedIndex = 1;
            }
        }

        private void cmb_regname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_regname.SelectedItem.ToString();
            DataSet regfreeds = mysql.getds("SELECT price FROM tb_regType WHERE name='" + tempstr + "'", "regType");
            for (int i = 0; i < regfreeds.Tables[0].Rows.Count; i++)
            {
                this.cmb_regfee.Text = regfreeds.Tables[0].Rows[i][0].ToString();
            }
        }

        private void btn_addreg_Click(object sender, EventArgs e)
        {
            if (cmb_name.Text == "")
            {
                MessageBox.Show("请选择挂号病人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cmb_docname.Text == "")
                    MessageBox.Show("请选择挂号医生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cmb_dept.Text == "")
                        MessageBox.Show("请选择挂号科室！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int rowAffected = 0;
                        try
                        {//bug：d1附近有语法错误。sql serve中可成功插入;
                            rowAffected = mysql.getcom(" INSERT tb_registration ( patientNo , deptNo , docNo , regDate , regTime , operater )"
                                + "SELECT '" + tb_patientNo.Text.Trim() + "',d2.NO, d1.No,'" + dtp_regDate.Value.ToShortDateString() + "','" + dtp_regTime.Value.ToShortTimeString() + "','" + userHelper.operatorNo + "'"
                                + "FROM tb_doctor d1, tb_dept d2"
                                + "WHERE d1.NAME='" + cmb_docname.SelectedItem.ToString() + "' AND d2.NAME='" + cmb_dept.SelectedItem.ToString() + "';");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            MessageBox.Show("添加挂号成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.gridviewinit();
                        }
                        else
                        {
                            MessageBox.Show("添加挂号失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void gridviewinit()//bug
        {
            DataSet view1ds = mysql.getds("SELECT r.NO 预约号,r.patientNo 患者编号,p.Name 患者姓名,d1.NAME 预约科室,d2.NAME 预约医生, r.regDate 预约日期,r.regTime 预约时间"
                + "FROM dbo.tb_registration r,dbo.tb_patient p, dbo.tb_dept d1, dbo.tb_doctor d2"
                + "WHERE r.docNo=d2.No AND r.deptNo=d1.NO AND r.patientNo=p.No AND r.regDate='" + dtp_regDate.Value.ToShortDateString() + "'"
                + "ORDER BY r.NO,r.regDate,r.regTime;", "registration");
            this.dataGridView1.DataSource = view1ds.Tables[0];
        }
    }
}