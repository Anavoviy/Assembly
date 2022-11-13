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
        public string KeyProduct { get; set; } = "#0000000";

        public string Marking { get; set; }  = "Product marking";
        public CPUCompany Company { get; set; }

        public string Model { get; set; }
        public CPUFamily Family { get; set; }
        public byte Generation { get; set; }
        public CPUSocket Socket { get; set; }

        public bool BOX_OEM { get; set; } = false;
        public bool ThermalPaste { get; set; } = false;

        public short Cores { get; set; }
        public short Threads { get; set; }
        public short P_Cores { get; set; }
        public short E_Cores { get; set; }
        public byte L2 { get; set; }
        public byte L3 { get; set; }
        public byte TechnicalProcess { get; set; }
        public string? Core { get; set; }

        public int BaseFrequency { get; set; }
        public int MaxFrequency { get; set; }
        public int BaseFrecuencyE { get; set; }
        public int MaxFrequencyE { get; set; }
        public bool FreeMultiplier { get; set; } = false;

        public RAMType RAMType { get; set; }
        public short MaxRAMCapacity { get; set; }
        public byte RAMChannels { get; set; }
        public int MaxRAMFrequency { get; set; }
        public bool ECC_RAM { get; set; } = false;

        public short TDP { get; set; }
        public byte MaxTemperature { get; set; }

        public string BuiltInGraphics { get; set; }

        public bool BuiltInControllerPCIE { get; set; } = true;
        public byte PCIELines { get; set; }

        public ulong Cost { get; set; }


    }

    
}
