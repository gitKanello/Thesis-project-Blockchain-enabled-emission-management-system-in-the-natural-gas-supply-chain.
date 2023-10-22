using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
/*
public class Emissions
{
    public int LotNumber { get; set; }
    public double CO2e { get; set; }
    public Emissions(int lotNumber, double co2e)
	{
        LotNumber = lotNumber;
        CO2e = co2e;
	}
}
*/
public class Emissions
{
    public int BatchNo { get; set; }
    public ProcessGroup Group { get; set; }
    public Process Process { get; set; }
    public double CH4Emissions { get; set; }
    public double CO2Emissions { get; set; }
    public double CO2e { get; set; }

    public Emissions(int batchNo, ProcessGroup group, Process process, 
        double ch4Emissions, double co2Emissions, double co2e)
    {
        BatchNo = batchNo;
        Group = group;
        Process = process;
        CH4Emissions = ch4Emissions;
        CO2Emissions = co2Emissions;
        CO2e = CO2Emissions + 29.8 * CH4Emissions;
    }
}