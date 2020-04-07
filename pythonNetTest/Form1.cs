using Python.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pythonNetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         PythonEngine.PythonHome = @"C:\Python35";

         //PythonEngine.PythonHome = @"C:\Anaconda3\envs\mvpf";
         /*
         var pythonPath = @"C:\Anaconda3";
         var pathToVirtualEnv = @"C:\Anaconda3\envs\mvpf";

         Environment.SetEnvironmentVariable("PATH", pathToVirtualEnv, EnvironmentVariableTarget.Process);
         Environment.SetEnvironmentVariable("PYTHONHOME", pathToVirtualEnv, EnvironmentVariableTarget.Process);
         Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToVirtualEnv}\\Lib\\site-packages;{pythonPath}\\Lib", EnvironmentVariableTarget.Process);

         PythonEngine.PythonHome = pathToVirtualEnv;
         PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);
         */      
         PythonEngine.Initialize();
      }

        private void Button1_Click(object sender, EventArgs e)
        {
         MessageBox.Show
         using (Py.GIL())
            {

               dynamic sys = Py.Import("sys");
               dynamic sysAppend = sys.path.append("D:\\WORK");

               dynamic sysPath = sys.path;
               dynamic sysVersion = sys.version;
               Console.WriteLine(sysPath);
               Console.WriteLine(sysVersion);

               StringBuilder sb = new StringBuilder();
               foreach (dynamic Path in sysPath)
               {
                  sb.AppendLine(Convert.ToString(Path));
               }
               richTextBox1.Text = sb.ToString();

            
               dynamic test = Py.Import("example");
               dynamic f = test.Calculator(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
               dynamic sumRst = (f.add());
               textBox3.Text = Convert.ToString(sumRst);
          
            }
        }

      private void button1_Click_1(object sender, EventArgs e)
      {

         using (Py.GIL())
         {
            dynamic test = Py.Import("example2");
            dynamic plot = test.plot();
         }
      }

   }
}
