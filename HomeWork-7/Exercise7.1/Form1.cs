using System;
using System.Windows.Forms;
namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            lblNumber.Text = "0";
            btnReset.Text = "�����";
            this.Text = "���������";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            lblStepsCount.Text = "0";
        }

        public void Update()
        {
            lblNumber.Text = doubler.Value.ToString();
            lblStepsCount.Text = doubler.Steps.ToString();
            this.Refresh();
            if (lblGoal.Visible)
                if (doubler.CheckGoal())
                {
                    MessageBox.Show($"�����������, �� �������� ��������� ����� �� {doubler.Steps} �����");
                    lblGoal.Visible = false;
                    lblGoalText.Visible = false;
                    doubler.Reset();
                }

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            Update();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Double();
            Update();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Update();
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            MessageBox.Show($"�������� ��������: {doubler.Goal}");
            lblGoal.Visible = true;
            lblGoalText.Visible = true;
            lblGoal.Text = doubler.Goal.ToString();
            doubler.Reset();
            Update();
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            doubler.CheckStack();
            Update();
        }
    }
}