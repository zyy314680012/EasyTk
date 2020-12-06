using EasyTk.PinDuoDuo.Response;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 批量绑定推广位的媒体id
    /// </summary>
    public class PddDdkPidMediaidBindRequest : BaseRequest<PddDdkPidMediaidBindResponse>
    {
        public override string Type => "pdd.ddk.pid.mediaid.bind";

        /// <summary>
        /// media_id 	LONG	 必填	媒体id
        /// </summary>
        public long MediaId { get; set; }

        /// <summary>
        /// pid_list	 STRING[]	必填	 pid列表
        /// </summary>
        public string[] PidList { get; set; }
    }
}
