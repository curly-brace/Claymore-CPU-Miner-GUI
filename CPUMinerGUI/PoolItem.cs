using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUMinerGUI {
    class PoolItem {
        private static int curId = 0;
        public int id;
        public string address;
        public string user;
        public string password;
        public string description;

        public static void resetId() {
            curId = 0;
        }

        public PoolItem(string a, string u, string p, string d) {
            id = curId++;
            address = a;
            user = u;
            password = p;
            description = d;
        }

        public override string ToString() {
            return address + "|" + user + "|" + password + "|" + description;
        }

    }
}
