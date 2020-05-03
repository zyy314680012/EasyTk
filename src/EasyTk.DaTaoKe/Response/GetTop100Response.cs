using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetTop100Response
    {
        /// <summary>
        /// hotWords	热搜词	Array	“螺蛳粉”, “耳机”, “充电宝”, “水杯”, “防晒霜”, “口红”,”面膜”, “睡衣”,”洗面奶”, “蓝牙耳机”, “天猫超市”, “男鞋”,”女鞋”, “内裤”,”卸妆水”, “洗发水”, “零食”……
        /// </summary>
        [JsonProperty("hotWords")]
        public string[] HotWords { get; set; }

    }
}
