using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421FinalProject.Coffee
{
    class CondimentFactory : CoffeeCondimentAC
    {
        public CoffeeCondimentAC getCondiment(string s)
        {   
            CoffeeCondimentAC cac;
            switch (s)
            {
                case "vanilla":
                    {
                        return new Vanilla();
                    }

                case "chocolate":
                    {
                        return new Chocolate();
                    }

                case "cream":
                    {
                        return new Cream();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
