using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQ
{
    /// <summary>
    /// 用于存放消息的实体
    /// </summary>
   [Serializable]
  public class Msg
    {
      /// <summary>
      /// 发送人
      /// </summary>
        public string sendUser { get; set; }


      /// <summary>
      /// 接收人
      /// </summary>
        public string  revidUser { get; set; }


      /// <summary>
      /// 消息内容
      /// </summary>
        public string Content { get; set; }
    }
}
