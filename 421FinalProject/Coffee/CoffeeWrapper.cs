﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee {

    class CoffeeWrapper : CoffeeIF {

        CoffeeIF cif;
        CoffeeCondimentAC cac;

        public CoffeeWrapper(CoffeeIF cif, CoffeeCondimentAC cac) {
            this.cif = cif;
            this.cac = cac;
        }

        public double getCondimentPrice() {
            if (cac == null) {
                return 0;
            }
            return cac.getPrice() + cif.getCondimentPrice();
        }

        public void addCondiment(CoffeeCondimentAC cac) {
            cif = new CoffeeWrapper(cif, cac);
        }

        public string getName() {
            return cif.getName();
        }

        public double getMenuPrice() {
            return cif.getMenuPrice();
        }
    }
}
