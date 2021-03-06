﻿using AtlusLibSharp.FileSystems.BVP;
using System;
using System.IO;

namespace bvptool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No input specified.");
                Console.WriteLine("Usage:");
                Console.WriteLine(" Enter path to BVP file to extract it to a folder of the same name.");
                Console.WriteLine(" Enter path to directory to pack into a BVP.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }

            if (args[0].EndsWith(".BVP", StringComparison.InvariantCultureIgnoreCase))
            {
                BVPFile bvp = new BVPFile(args[0]);
                bvp.Extract(Path.GetFileNameWithoutExtension(args[0]));
            }
            else if (!Path.HasExtension(args[0]))
            {
                BVPFile bvp = BVPFile.Create(args[0]);
                bvp.Save(Path.GetFileName(args[0]) + ".BVP");
            }
        }
    }
}
