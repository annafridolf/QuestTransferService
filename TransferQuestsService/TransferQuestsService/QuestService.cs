using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferQuestsService
{
    public class QuestService: IQuestService
    {
        string IQuestService.TestConnection()
        {
            return "success";
        }

        string IQuestService.PerformQuestTransfer(int questId)
        {
            return "this should return stuff";
        }
    }
}
