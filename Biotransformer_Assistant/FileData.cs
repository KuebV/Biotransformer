﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biotransformer_Assistant
{
    public class FileData
    {
        public static string OutputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Output");
        public static string BiotransformerInput = Path.Combine(OutputDirectory, "Biotransformer_Input.txt");
        public static string SMILES_SpreadsheetKey = Path.Combine(OutputDirectory, "SMILES_SpreadsheetKey.txt");

        public static string RawCompoundInput = "RawCompounds.txt";

        public static string CompoundSMILES = "Compounds_SMILES.txt";

        public static void SetupProgram()
        {
            if (!Directory.Exists(OutputDirectory))
                Directory.CreateDirectory(OutputDirectory);

            string BTI = Path.Combine(Directory.GetCurrentDirectory(), BiotransformerInput);
            if (!File.Exists(BTI))
                using (StreamWriter sw = new StreamWriter(BTI))
                    sw.Close();

            string PCI = Path.Combine(Directory.GetCurrentDirectory(), CompoundSMILES);
            if (!File.Exists(PCI))
                using (StreamWriter sw = new StreamWriter(PCI))
                    sw.Close();

            string SMILES = Path.Combine(Directory.GetCurrentDirectory(), SMILES_SpreadsheetKey);
            if (!File.Exists(SMILES))
                using (StreamWriter sw = new StreamWriter(SMILES))
                    sw.Close();

            string RawCompound = Path.Combine(Directory.GetCurrentDirectory(), RawCompoundInput);
            if (!File.Exists(RawCompound))
                using (StreamWriter sw = new StreamWriter(RawCompound))
                    sw.Close();
        }
    }
}
