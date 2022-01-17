/*                              Самойлов Р.А.                                 
4. 
    *Используя полученные знания и класс TrueFalse в качестве шаблона, 
    разработать собственную утилиту хранения данных 
    (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutEnglishWords
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