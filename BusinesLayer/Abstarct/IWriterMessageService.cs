using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstarct
{
    public interface IWriterMessageService: IGenericServices<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessage(string p);
        List<WriterMessage> GetListReciverMessage(string p);

    }
}
