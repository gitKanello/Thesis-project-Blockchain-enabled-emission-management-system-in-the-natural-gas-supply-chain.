using System;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace BasicBlockchain
{
    class Program
    {

        //C:\Users\Kanello\source\repos\BasicBlockchain\BasicBlockchainσσ
        static void Main(string[] args)
        {   
            IO myIO = new IO();
            BlockChain USEmissions = myIO.Load();

            /*
            BlockChain USEmissions = new BlockChain(false);
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.WellPadEquipmentLeaks, Process.Separators, 0.10717 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.WellPadEquipmentLeaks, Process.Separators, 0.00706, 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.WellPadEquipmentLeaks, Process.Heaters, 0.01060 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.WellPadEquipmentLeaks, Process.Heaters, 0.01350 , 0.0, 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            
            
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.WellPadEquipmentLeaks, Process.Dehydrators, 0.10523 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.WellPadEquipmentLeaks, Process.Dehydrators, 0.00395 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.WellPadEquipmentLeaks, Process.MetersPiping, 1.09350, 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.WellPadEquipmentLeaks, Process.MetersPiping, 0.10351, 0.0, 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.WellPadEquipmentLeaks, Process.Compressors, 3.50396 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.WellPadEquipmentLeaks, Process.Compressors, 0.21441 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.PneumaticControllers, Process.HighBleed, 7.12170 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.PneumaticControllers, Process.HighBleed, 0.15439 , 0.0, 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.PneumaticControllers, Process.LowBleed, 0.03413 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.PneumaticControllers, Process.LowBleed, 0.10774 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.PneumaticControllers, Process.IntermittentBleed, 12.46528 , 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.PneumaticControllers, Process.IntermittentBleed, 2.75915, 0.0, 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.LargeTankswVRU, 0.0, 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.LargeTankswVRU, 0.00097, 0.00197 , 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.LargeTankswoControl, 0.06622 , 0.00834, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.LargeTankswoControl, 0.01132, 0.00295 , 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.SmallTankswoFlares, 4.20758 , 1.83384 , 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.SmallTankswoFlares, 0.04326 , 0.02138, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.MalfunctioningSeparatorDumpValves, 0.0, 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.MalfunctioningSeparatorDumpValves, 0.00050, 0.00002, 0));
            USEmissions.ProcessPendingTransactions("SNAME");
           

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.LargeTankswFlares, 0.0, 0.0, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.LargeTankswFlares, 0.00154, 2.32616, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.Tanks, Process.SmallTankswFlares, 0.0, 0.0 , 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.Tanks, Process.SmallTankswFlares, 0.00020, 0.03348 , 0));
            USEmissions.ProcessPendingTransactions("SNAME");
             

            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.LiquidsUnloading, Process.LiquidsUnloadingwPlungerLifts, 7.12752 , 0.46817 , 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.LiquidsUnloading, Process.LiquidsUnloadingwPlungerLifts, 0.27757 , 0.0 , 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Arkoma, ProcessGroup.LiquidsUnloading, Process.LiquidsUnloadingwoPlungerLifts, 2.73856 , 0.16057, 0));
            USEmissions.CreateTransaction(new Emissions((int)Batches.Illinois, ProcessGroup.LiquidsUnloading, Process.LiquidsUnloadingwoPlungerLifts, 0.47853 , 0.0 , 0));
            USEmissions.ProcessPendingTransactions("SNAME");
            */

            //Console.WriteLine(JsonConvert.SerializeObject(USEmissions, Formatting.Indented));

           // int tamperedBlock = USEmissions.IsValidInt();
            //if (tamperedBlock == 0)
           //     Console.WriteLine("The blockchain has been successfully validated");
           // else
            //    Console.WriteLine("The blockchain has been tampered at block: " + tamperedBlock.ToString());

            DataFiltering Filter = new DataFiltering();
            //double em = Filter.CalculateTotalUSEmissions(USEmissions);
            //Console.WriteLine(Filter.CalculateTotalUSEmissions(USEmissions).ToString());

            //double em = Filter.CalculateEmissionsPerBasin(USEmissions, Batches.Arkoma);
            //double emm = Filter.CalculateEmissionsPerBasin(USEmissions, Batches.Illinois);
            //double total = em + emm;

            double compressorEms = Filter.CalculateEmissionsPerProcess(USEmissions, Process.HighBleed);
            //double WellPadEquipment = Filter.CalculateEmissionsPerProcessGroup(USEmissions, ProcessGroup.WellPadEquipmentLeaks);

            //double custom = Filter.Custom(USEmissions, ProcessGroup.WellPadEquipmentLeaks, Batches.Arkoma);

            //string filePath = @"C:\Users\Kanello\Desktop\Blockchain.txt";
            /*
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(JsonConvert.SerializeObject(USEmissions, Formatting.Indented));
                }
                Console.WriteLine("Text has been written to the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            */
        }
    }
}


