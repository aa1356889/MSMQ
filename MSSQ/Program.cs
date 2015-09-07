using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
namespace MSSQ
{
    class Program
    {
        static void Main(string[] args)
        {
             MsqHelp.Send(new Msg() { Content = "我爱你", sendUser = "李强", revidUser = "mengdie" });
             Msg msg = MsqHelp.GetObj();
            Console.WriteLine(msg.sendUser + "发送一条消息给" + msg.revidUser + "内容：" + msg.Content);
            Console.ReadKey();
        }
    }
}
