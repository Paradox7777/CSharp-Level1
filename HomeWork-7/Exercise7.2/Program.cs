/*
 *                                    �������� �.�.
 * ��������� Windows Forms, ����������� ���� ������� �����. ��������� ���������� ����� �� 1 �� 100, 
 * � ������� �������� ��� ������� �� ����������� ����� �������. 
 * ��������� �������, ������ ��� ������ ���������� ����� ����������.  
a) ��� ����� ������ �� �������� ������������ ������� TextBox;
�) **����������� ��������� ����� c TextBox ��� ����� �����.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessNumber
{
    static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}