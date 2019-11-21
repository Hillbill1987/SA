using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BackgroundChecks
    {
        public BackgroundChecks()
        {

        }

        public void Check()
        {
            Task.Run(() =>
            {




                //System.Threading.SynchronizationContext.Current.OperationCompleted();
                
            });
        }
    }
}
