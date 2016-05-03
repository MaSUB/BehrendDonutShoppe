using System;

namespace _421FinalProject.Orders {
    class DonutFactory : DonutAC {

        DonutAC donut;

        public override string description() {
            return donut.description();
        }

        public DonutIF getDonut(string s) {
                donut = (DonutAC) Activator.CreateInstance(Type.GetType("421FinalProject.Orders" + "." + s));
                return donut;
        }
    }
}
