﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputers.Data;
namespace DollarComputers
{
    public static class Program
    {
        public static Product product;
        public static Dictionary<string, Form> forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            forms = new Dictionary<string, Form>();
            forms.Add("SplashScreen", new SplashScreen());
            forms.Add("StartForm", new StartForm());
            forms.Add("SelectForm", new SelectForm());
            forms.Add("ProductInfo", new ProductInfo());
            forms.Add("OrderForm", new OrderForm());
            forms.Add("AboutForm", new AboutForm());

            product = new Product();
            Application.Run(forms["SplashScreen"]);
        }
    }
}
