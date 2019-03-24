/*
 * Program:     Assignment 4
 * Author:      Patrick Klesyk, Ben Lane, Matt Rycraft
 * Z-ID:        Z1782152        Z1806979  Z1818053 
 * Description: This application is a graphing calculator that supports four different
 *              equation types.
 * Due Date:    3/28/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
