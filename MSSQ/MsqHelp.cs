using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSSQ
{
    /// <summary>
    /// msmq帮助类
    /// </summary>
   public class MsqHelp
    {
       /// <summary>
       /// 消息队列实例
       /// </summary>
       public  static  MessageQueue  msqQueue{ get; set; }
       static MsqHelp()
       {
           //判断是否存在此队列
           if (!MessageQueue.Exists(@".\private$\iwo3"))
           {
               msqQueue = MessageQueue.Create(@".\private$\iwo3");//创建一个队列
           }
           else
           {
               msqQueue = new MessageQueue(@".\private$\iwo3");
           }
       }

       /// <summary>
       /// 往队列发送一条消息
       /// </summary>
       /// <param name="msg"></param>
       /// <returns></returns>
       public static  bool Send(Msg msg)
       {
           try
           {
               msqQueue.Send(new Message(msg,new BinaryMessageFormatter()));
               return true;
           }
           catch(Exception e)
           {
               return false;
           }
       }

       /// <summary>
       /// 从队列获得一条数据
       /// </summary>
       /// <returns></returns>
       public static Msg GetObj()
       {
           msqQueue.Formatter = new BinaryMessageFormatter();
           Message msg = msqQueue.Receive();
         if (msg != null)
         {
           return  msg.Body as Msg;
         }
         return null;
       }
    }
}
