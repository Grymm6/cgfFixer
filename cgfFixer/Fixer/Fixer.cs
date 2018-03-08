﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryEngine;
using System.IO;
using cgfMerger;

namespace cgfFixer
{
    static class Fixer
    {


        public static void Fix(string path,string version="CE54")
        {
            if (version == "CE54")
            {
                string extension = Path.GetExtension(path);
                switch (extension)
                {
                    case ".cga":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_CE_5_4.fixElements(path);
                        Fixer_CE_5_4.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_CE_5_4.fixCga(path + "m");
                        Console.Write("DONE\n");
                        break;
                    case ".skin":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_CE_5_4.fixElements(path, true);
                        Fixer_CE_5_4.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_CE_5_4.fixSkin(path);
                        Console.Write("DONE\n");
                        break;
                    case ".cgf":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_CE_5_4.fixElements(path);
                        Fixer_CE_5_4.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_CE_5_4.fixCga(path + "m");
                        Console.Write("DONE\n");
                        break;
                    case ".chr":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_CE_5_4.fixElements(path);
                        Fixer_CE_5_4.fixElements(path + "m");
                        Console.Write("DONE\n");
                        break;
                    default:
                        break;
                }
            }
            else if(version == "LY")
            {
                string extension = Path.GetExtension(path);
                Merger merger;
                switch (extension)
                {
                    case ".cga":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_LY_1_12_0_1.fixElements(path);
                        Fixer_LY_1_12_0_1.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_LY_1_12_0_1.fixCga(path);
                        merger = new Merger(path, path + "m");
                        merger.RenderAndSaveMergedFile(path);
                        Console.Write("DONE\n");
                        break;
                    case ".skin":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_LY_1_12_0_1.fixElements(path, true);
                        Fixer_LY_1_12_0_1.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_LY_1_12_0_1.fixSkin(path);
                        merger = new Merger(path, path + "m");
                        merger.RenderAndSaveMergedFile(path);
                        Console.Write("DONE\n");
                        break;
                    case ".cgf":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_LY_1_12_0_1.fixElements(path);
                        Fixer_LY_1_12_0_1.fixElements(path + "m");
                        Console.Write("DONE\n");
                        Fixer_LY_1_12_0_1.fixCga(path);
                        merger = new Merger(path,path+"m");
                        merger.RenderAndSaveMergedFile(path);
                        Console.Write("DONE\n");
                        break;
                    case ".chr":
                        Console.WriteLine("FILE {0}", path);
                        Console.Write("Fixing elements sizes");
                        Fixer_LY_1_12_0_1.fixElements(path);
                        Fixer_LY_1_12_0_1.fixElements(path + "m");
                        merger = new Merger(path, path + "m");
                        merger.RenderAndSaveMergedFile(path);
                        Console.Write("DONE\n");
                        break;
                    default:
                        break;
                }
            }
            
        }
       
        
    }
}