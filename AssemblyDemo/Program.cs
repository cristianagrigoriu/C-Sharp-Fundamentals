using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAssembly(Assembly.GetEntryAssembly());
            ShowModuleNames(Assembly.GetEntryAssembly());
           // Assembly newAssembly = Assembly.Load(new AssemblyName(@"C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\WindowsBase.dll"));

            string fileToLoad = @"C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\WindowsBase.dll";
            AssemblyName assamblyName = AssemblyName.GetAssemblyName(fileToLoad);
            AppDomain myDomain = AppDomain.CreateDomain("MyDomain");
            Assembly myAssambly = myDomain.Load(assamblyName);
            ShowAssembly(myAssambly);
            ShowModuleNames(myAssambly);

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(executingAssembly);
            ShowModuleNames(executingAssembly);
        }

        static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine("---Assembly Info---");
            Console.WriteLine(assembly.FullName + "\n" + assembly.GlobalAssemblyCache + "\n" + assembly.Location + "\n" + assembly.ImageRuntimeVersion);
            Console.WriteLine();
        }

        static void ShowModuleNames(Assembly assembly)
        {
            Console.WriteLine("---Module Names---");
            foreach (var module in assembly.GetModules())
            {
                Console.WriteLine(module.Name);
            }
            Console.WriteLine();
        }
    }
}
