using System;
using Assemblies;

class Program
{
    public static void Main()
    {
        CPU cpu = new();
        MotherBoard MB = new();
        RAM ram = new();
        GPU gpu = new();
        CPUCooling cpuCooling = new();

        DataStorageDevice SSD = new();
        DataStorageDevice HDD = new();
        List <DataStorageDevice> dataStorageDevices = new List<DataStorageDevice>();
        dataStorageDevices.Add(SSD);
        dataStorageDevices.Add(HDD);
        
        PowerSupply PS = new();
        ComputerCase computerCase = new();

        Assembly assembly = new("Гор", (ulong)75000, cpu, MB, ram, gpu, cpuCooling, dataStorageDevices, PS, computerCase);



        IsRunning isRunning = (IsRunning)assembly;

    }

}