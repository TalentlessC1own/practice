using practice.Model;
using practice.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 mainForm = new Form1();
            PointCalc calculator = new PointCalc();
            MessageService messageService = new MessageService();
            Validator validator = new Validator();
            FileManager fileManager = new FileManager();
            MainFormPresenter presenter = new MainFormPresenter(mainForm, calculator, messageService, validator, fileManager);
            Application.Run(mainForm);
        }
    }
}
