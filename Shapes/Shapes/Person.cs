using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes {
    internal class Person {
        private int wut = 100;

        public bool Wuetend { get { return wut >= 50; } private set { } }

        public void Entspannen() {
            wut -= 10;
        }

        public void Nerven() {
            wut += 10;
        }

        public void Entschuldigen() {
            wut = 0;
        }

        public void Blosstellen() {
            wut = 100;
        }
    }
}
