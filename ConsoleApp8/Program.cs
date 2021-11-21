using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Який формат бажаєте обрати?: ");
                    string format = Console.ReadLine();
                    if (format == "PNG")
                    {
                        PNG formatPNG = new PNG(format);
                        formatPNG.BoxMeth();
                    }
                    else if (format == "DOC")
                    {
                        new DOC(format).BoxMeth();
                    }
                    else if (format == "JPEG")
                    {
                        new JPEG(format).BoxMeth();
                    }
                    else
                    {
                        Console.WriteLine("Помилка");
                        
                    }
                    Console.ReadLine();
                }

            }
        }
        abstract class AbstractHandler
        {
            public abstract void Create();
            public abstract void Open();
            public abstract void Change();
            public abstract void Save();
        }
        class AllMet : AbstractHandler
        {
            public string NameFormat { get; set; }
            public AllMet(string name)
            {
                this.NameFormat = name;
            }
            public override void Create()
            {
                Console.WriteLine($"Creating {NameFormat} file");
            }
            public override void Open()
            {
                Console.WriteLine($"Opening {NameFormat} file");
            }
            public override void Change()
            {
                Console.WriteLine($"Changing {NameFormat} file");
            }
            public override void Save()
            {
                Console.WriteLine($"Saving {NameFormat} file");
            }

            public virtual void BoxMeth()
            {
                Create();
                Open();
                Change();
                Save();
            }

        }
        class PNG : AllMet
        {
            public PNG(string name)
                : base(name)
            { }
            public override void BoxMeth()
            {
                base.BoxMeth();
            }

        }
        class JPEG : AllMet
        {
            public JPEG(string name)
                : base(name)
            { }
            public override void BoxMeth()
            {
                base.BoxMeth();
            }

        }
        class DOC : AllMet
        {
            public DOC(string name)
                : base(name)
            { }
            public override void BoxMeth()
            {
                base.BoxMeth();
            }

        }

    }
