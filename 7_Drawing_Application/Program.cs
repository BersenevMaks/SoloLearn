using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Drawing_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

            Console.ReadKey();
        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }

    }

    //inherit this class from the class Draw
    class Spray : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }

    }
}
