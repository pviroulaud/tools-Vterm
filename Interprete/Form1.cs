using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using IronPython.Hosting;
//using Microsoft.Scripting;
//using Microsoft.Scripting.Hosting;

namespace Interprete
{
    public partial class Form1 : Form
    {
        //ScriptScope scope=null ;
        //ScriptEngine engine = Python.CreateEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean Chequear_Script(String codigo)
        {
            Boolean ret = true;
            try
            {
                //ScriptSource source =
                //    engine.CreateScriptSourceFromString(codigo,
                //        SourceCodeKind.AutoDetect);
                //source.Compile();

            }
            catch (Exception)
            {

                ret = false;
            }
            return ret;
        }
        private Boolean Chequear_Archivo_Script(String RutaYNombre)
        {
            Boolean ret = true;
            try
            {
                //ScriptSource source = engine.CreateScriptSourceFromFile(RutaYNombre);
                //source.Compile();
                //source = null;
            }
            catch (Exception)
            {

                ret = false;
            }

            return ret;
        }

        private void Crear_Archivo_Script(String Condicion_A_Evaluar,String RutaYNombre)
        {

            System.IO.StreamWriter script = new System.IO.StreamWriter(RutaYNombre);
            script.WriteLine("def Evaluar():");
            script.WriteLine("\tRet = False");
            script.WriteLine("\tif (" + Condicion_A_Evaluar + "):");
            script.WriteLine("\t\tRet = True");
            script.WriteLine("\telse:");
            script.WriteLine("\t\tRet = False");
            script.WriteLine("\treturn Ret");
            script.WriteLine();
            script.WriteLine("Resultado = Evaluar()");
            script.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string archivo = @"C:\Users\Pablo\Documents\scriptx.txt";

            //label4.Text = "";
            //label3.Text = "";

            //scope = engine.CreateScope();

            //Crear_Archivo_Script(textBox1.Text, archivo);
            //if (Chequear_Archivo_Script(archivo))
            //{
            //    label4.Text = "Script sin errores.";
            //    engine.ExecuteFile(@"C:\Users\Pablo\Documents\scriptx.txt", scope);
            //    label3.Text = Convert.ToString(scope.GetVariable("Resultado"));
            //}
            //else
            //{
            //    label4.Text = "ERROR en el Script!";
            //    label3.Text = "";
            //}
        }
    }
}
