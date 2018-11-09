using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace StudyExamples.Threading.TPL
{
    class ImageProcess
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            var alterpath = path + @"\alterpath";
            if (!Directory.Exists(alterpath)) Directory.CreateDirectory(alterpath);
            string[] files = Directory.GetFiles(path + @"\images", "*.*",SearchOption.TopDirectoryOnly);
            files.ToList().ForEach(x => Console.WriteLine(x.ToString()));
            WithoutTPL(files,alterpath);
            WithTPL(files,alterpath);
            Console.ReadKey();
        }
        //Without TPL takes approx. 7 seconds to complete operation
        private static void WithoutTPL(string[] files,string alterpath)
        { 
            Stopwatch sp = new Stopwatch();
            sp.Start();
            foreach (var file in files)
            {
               
                TransformImageFiles(file,alterpath);
            }
            sp.Stop();
            Console.WriteLine("Elapse time for sequancial trasformation is :" + sp.ElapsedMilliseconds.ToString());
        }

        //With TPL takes approx. 3.5 seconds to complete operation
        private static void WithTPL(string[] files,string alterpath)
        {            
            files.ToList().ForEach(x => Console.WriteLine(x.ToString()));
            Stopwatch sp = new Stopwatch();
            sp.Start();
            Parallel.ForEach(files, x=> TransformImageFiles(x,alterpath));
            sp.Stop();
            Console.WriteLine("Elapse time for TPL trasformation is :" + sp.ElapsedMilliseconds.ToString());
        }

        private static void TransformImageFiles(string file,string alterpath)
        {
          //  Image imgnew = null;
            try
            {              
               string filename =  Path.GetFileName(file);
              //image object needs to be dispose after using to implement using
               using (Image img = Image.FromFile(file))
               {
                   using (Image imgnew = new Bitmap(img))
                   {
                       imgnew.RotateFlip(RotateFlipType.Rotate90FlipX);
                       imgnew.Save(Path.Combine(alterpath,filename), System.Drawing.Imaging.ImageFormat.Jpeg);
                       Console.WriteLine("Thread {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
                   }
               }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
             
            }
        }
    }
}
