using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUMinerGUI {
    class Miner {
        public int pid;
        public string threads;
        public bool lowCpu;
        public PoolItem pool;
        public string hashrate;
        public string logFile;
        public Process proc;

        public Miner(int p, string t, bool l, PoolItem pi, Process pr, string log) {
            pid = p;
            threads = t;
            lowCpu = l;
            pool = pi;
            proc = pr;
            logFile = log;
            hashrate = "0 h/s";
        }
    }
}
