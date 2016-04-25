using _421FinalProject.Orders;
using System.Threading;
namespace _421FinalProject.Machine {
    class DonutMachine : MachineIF
    {

        DonutFactory df;
        bool isBusy;

        /// <summary>
        ///     we essentially are using this machine as a resource so that we don't
        ///     use the factory class itself to send the 
        /// </summary>
        /// <param name="s">
        ///     string representation of donut the employee requested to make.
        /// </param>
        /// <returns>
        ///    donut that the employee requested the machine to make
        /// </returns>
        public DonutIF makeDonut(string s)
        {
            if (!isBusy)
            {
                lock(this)
                {
                    isBusy = true;
                    //  wait for 5 seconds or something like that because whatever.
                    Thread.Sleep(5000);
                    return df.getDonut(s);
                }
            }
            else {
                return null;
            }
        }

    }
}
