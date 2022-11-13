using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assemblies
{
    class IsRunning : Assembly {
        Assembly assembly;

        public IsRunning() { }

        public IsRunning(Assembly ass) { this.assembly = ass; }
        
        public bool CPU_MotherBoard() {
            CPU cpu = this.CPU;
            MotherBoard motherBoard = this.MotherBoard;

            int countYes = 0;
            if (cpu.Socket == motherBoard.Socket) 
                countYes++;
            if (cpu.Socket == motherBoard.Socket)
                countYes++;

        }
        
    }
}
