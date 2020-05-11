using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class OpenQrPicRequest : BaseRequest<OpenQrPicResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10002/api/open_qrpic.ashx"
        };

        #region ===========================

        ///<summary> 
        ///content string	是	淘口令文案。请注意，该参数需要进行Urlencode编码后传入。<br />重要的事情说三遍：该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///type string	否	二维码发单图样式，目前有0和1两种样式，后期会扩充。
        ///</summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        ///<summary> 
        ///pict_url string	否	商品主图地址（字段：pict_url）或者其它商品图（字段：small_images中的某一张），默认800*800大小。<br />此参数如果输入值为空，返回的pic_url也将为空，输入值为：moren，后台默认按照此商品主图地址返回二维码图。<br />注意：输入图片地址或者固定值“moren”，才会返回二维码发单图！如果输入值为空，则不返回二维码发单图！
        ///</summary>
        [JsonProperty("pict_url")]
        public string PictUrl { get; set; }

        ///<summary> 
        ///copy_tkl_url2 string	否	中间页url，原始url。如：http://cms.zhetaoke.com:10000/m/item/detail.aspx?code=593335919876
        ///</summary>
        [JsonProperty("copy_tkl_url2")]
        public string CopyTklUrl2 { get; set; }

        ///<summary> 
        ///text string	否	二维码扫描文字内容。内容中如果带淘口令，将显示该内容，否则显示默认文字内容。<br />默认文字内容为： <br />点击右上角【复制链接】或长按复制这段文字，打开【手机淘宝APP】，【领取优惠券】并购买$Od92YdM1vlf$...皎洁电热蚊香液无味家用儿童驱蚊器
        ///</summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        ///<summary> 
        ///wenan string	否	朋友圈文案模板。 <br />默认文案模板内容为： <br />{标题}<br />【在售价】：{在售价}元<br />【券后价】：{券后价}元<br />{简介}【优惠券：{优惠券金额}元】<br />-------------------<br />复制这条信息，({淘口令})，打开【手机taobao】即可查看并下单<br />【详情链接】{短链接}<br /> <br /> <br />注意：注意：注意：以下是文案说明，不是文案内容。 <br />1、{标题}，表示推广商品标题 <br />2、{在售价}，表示推广商品的原始价格 <br />3、{券后价}，表示推广商品的券后价格 <br />4、{简介}，表示推广商品的简介 <br />5、{优惠券金额}，表示推广商品的优惠券金额 <br />6、{短链接}，表示推广商品的短连接，不需要此项，删掉文案所在行即可 <br />7、{淘口令}，表示推广商品的淘口令，格式默认是：￥{淘口令}￥，可设置成({淘口令}),手淘都能认出。
        ///</summary>
        [JsonProperty("wenan")]
        public string WenAn { get; set; }

        #endregion
    }
}
