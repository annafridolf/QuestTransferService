using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TransferQuestsService
{
    [ServiceContract]
    public interface IQuestService
    {


        [OperationContract]
        string TestConnection();
        [OperationContract]
        string PerformQuestTransfer(int questId);



    }
}
