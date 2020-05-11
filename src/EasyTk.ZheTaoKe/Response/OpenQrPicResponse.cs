using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class OpenQrPicResponse : BaseResponse
    {
        #region ===========================

        ///<summary> 
        ///model "￥kStwYaf2xiD￥",     /*淘口令*/
        ///</summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        ///<summary> 
        ///item_id "570499167319",     /*商品ID*/
        ///</summary>
        [JsonProperty("item_id")]
        public long? ItemId { get; set; }

        ///<summary> 
        ///pic_url "https://api.zhetaoke.com:10001/uploads_qrcode/20190413/201904132231017909.jpg",     /*二维码发单图url*/
        ///</summary>
        [JsonProperty("pic_url")]
        public string PicUrl { get; set; }

        ///<summary> 
        ///copy_tkl_url "https://t.cn/EXLVNdG"     /*中间页url，新浪短链*/
        ///</summary>
        [JsonProperty("copy_tkl_url")]
        public string CopyTklUrl { get; set; }

        ///<summary> 
        ///copy_tkl_url2 "http://rd.wechat.com/qrcode/confirm?"     /*中间页url，原始url*/
        ///</summary>
        [JsonProperty("copy_tkl_url2")]
        public string CopyTklUrl2 { get; set; }

        ///<summary> 
        ///wenan "这里是朋友圈文案。"     /*朋友圈文案*/
        ///</summary>
        [JsonProperty("wenan")]
        public string WenAn { get; set; }

        #endregion
    }
}
