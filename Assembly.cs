using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Assemblies
{
    class Assembly {

        protected string Name = "Assembly name";
        protected ulong? Cost;

        protected CPU? CPU;
        protected MotherBoard? MotherBoard;
        protected RAM? RAM;
        protected GPU? GPU;
        protected CPUCooling? CPUCooling;
        protected List<DataStorageDevice>? DataStorageDevices;
        protected PowerSupply? PowerSupply;
        protected ComputerCase? ComputerCase;

        public Assembly() { }
        public Assembly(string name)
        {
            Name = name;
        }

        public Assembly(string name,
                        ulong cost,
                        CPU cPU,
                        MotherBoard? motherBoard,
                        RAM rAM,
                        GPU gPU,
                        CPUCooling? cPUCooling,
                        List<DataStorageDevice>? dataStorageDevices,
                        PowerSupply? powerSupply,
                        ComputerCase? computerCase)
        {
            Name = name;
            this.Cost = cost;
            CPU = cPU;
            MotherBoard = motherBoard;
            RAM = rAM;
            GPU = gPU;
            CPUCooling = cPUCooling;
            DataStorageDevices = dataStorageDevices;
            PowerSupply = powerSupply;
            ComputerCase = computerCase;
        }

        


    }
}
