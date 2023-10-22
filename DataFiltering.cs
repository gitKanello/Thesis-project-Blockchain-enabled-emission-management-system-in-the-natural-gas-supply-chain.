using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlockchain
{
    public class DataFiltering
    {
        public double CalculateTotalUSEmissions(BlockChain BlockChain)
        {
            double totalCO2eEmissions = 0.0;
            foreach (var block in BlockChain.Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    totalCO2eEmissions += transaction.CO2e;
                }
            }
            return totalCO2eEmissions;
        }

        public double CalculateEmissionsPerBasin(BlockChain BlockChain, Batches BatchNo)
        {
            double totalCO2eEmissions = 0.0;

            foreach (var block in BlockChain.Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    if(transaction.BatchNo == (int)BatchNo)
                    {
                        totalCO2eEmissions += transaction.CO2e;
                    }
                }
            }
            return totalCO2eEmissions;
        }

        public double CalculateEmissionsPerProcess(BlockChain BlockChain, Process Process)
        {
            double totalCO2eEmissions = 0.0;

            foreach (var block in BlockChain.Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    if (transaction.Process == Process)
                    {
                        totalCO2eEmissions += transaction.CO2e;
                    }
                }
            }
            return totalCO2eEmissions;
        }

        public double CalculateEmissionsPerProcessGroup(BlockChain BlockChain, ProcessGroup Group)
        {
            double totalCO2eEmissions = 0.0;

            foreach (var block in BlockChain.Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    if (transaction.Group == Group)
                    {
                        totalCO2eEmissions += transaction.CO2e;
                    }
                }
            }
            return totalCO2eEmissions;
        }

        public double Custom(BlockChain BlockChain, ProcessGroup Group, Batches BatchNo)
        {
            double totalCO2eEmissions = 0.0;

            foreach (var block in BlockChain.Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    if (transaction.Group == Group && transaction.BatchNo == (int)BatchNo)
                    {
                        totalCO2eEmissions += transaction.CO2e;
                    }
                }
            }
            return totalCO2eEmissions;
        }
    }
}
