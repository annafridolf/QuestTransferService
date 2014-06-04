using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class QuestService : IQuestService
    {
       
        string IQuestService.TestConnection()
        {
            return "success connecting";
        }

        string IQuestService.PerformQuestTransfer(int questId)
        {
            return "this should return success when procecced quest";
        }
    }
}
