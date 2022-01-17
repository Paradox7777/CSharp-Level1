using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessNumber
{
    public partial class Form1 : Form
    {
        randNumber rnum;
        int max;
        Form2 f2;
        public Form1()
        {
            max = 100;
            rnum = new randNumber(max);
            InitializeComponent();
            btnCheck.Text = "���������";
            this.Text = "������ �����";
            lblStepCount.Text = "0";
            lblEnterTheNumber.Text = $"������� ����� �� 0 �� {max}:";
            lblStepText.Text = "���� �����:";
            MessageBox.Show("������� � ���� ����� ���� �� ��������. ��������� ������ \"���������\" " +
                "����� ������ ��������� �������. ", "�������");
            tboxUserAnswer.Visible = false;
            f2 = new Form2();
            f2.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool check;

            MessageBox.Show(rnum.CheckValue(out check, f2.userAnswer));
            if (check)
            {
                rnum.Reset(max);
                MessageBox.Show($"���� �������� ������.\n������� ����� �� 0 �� {max}:");
            }
            Update();
        }

        void Update()
        {
            lblStepCount.Text = rnum.Steps.ToString();
            this.Refresh();
        }
    }
}