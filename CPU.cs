using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerEnums.CPU;
using ComputerEnums.RAM;

namespace Assemblies
{
    class CPU
    {
        string KeyProduct = "#0000000";

        string Marking = "Product marking";
        CPUCompany Company;
        string Model;
        CPUFamily Family;
        byte Generation;
        CPUSocket Socket;

        bool BOX_OEM = false;
        bool ThermalPaste = false;

        short Cores;
        short Threads;
        short P_Cores;
        short E_Cores;
        byte L2;
        byte L3;
        byte TechnicalProcess;
        string? Core;

        int BaseFrequency;
        int MaxFrequency;
        int BaseFrecuencyE;
        int MaxFrequencyE;
        bool FreeMultiplier = false;

        RAMType RAMType;
        short MaxRAMCapacity;
        byte RAMChannels;
        int MaxRAMFrequency;
        bool ECC_RAM = false;

        short TDP;
        byte MaxTemperature;

        string BuiltInGraphics;

        bool BuiltInControllerPCIE = true;
        byte PCIELines;

        ulong Cost;


    }
}
