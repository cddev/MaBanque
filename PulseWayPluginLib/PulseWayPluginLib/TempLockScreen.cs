using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MM.Monitor.Client;

namespace PulseWayPluginLib
{
    public class TempLockScreen:ClientPlugin 
    {
        public override string GetPluginName()
        {
            return "System Temperature On LockScreen";
        }
        public override string GetPluginDescription()
        {
            return "This plugin shows the current date and time.";
        }
    }
}
