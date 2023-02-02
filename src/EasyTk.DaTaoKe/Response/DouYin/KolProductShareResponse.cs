using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class KolProductShareResponse
    {
        #region

        /// <summary>
        /// dyDeeplink string snssdk1128://ec_goods_detail/?promotion_id=3455239341532652291\u0026kol_id=99514375927\u0026source_page=outer_product_share\u0026request_additions=%7B%22enter_from%22%3A%22outer_product_share%22%2C%22sec_author_id%22%3A%22MS4wLjABAAAA2I9NdgAKZrz9e0tLm1csyDMNqLESPDm34TdYYqXe8-I%22%2C%22cps_track%22%3A%22Ck4I972T3PICEOgIGihkeV8xMDcwNTYxNDMyMDQ3MzA4MTQ3NTJfMzczN18xODQ3Mzk1OTYyIg4xMzkwNDc1XzBfMDIwMCgAMAA6AEIASAASDAit0YnwxfW1-S8QAg%22%2C%22product_id%22%3A3455060999458154669%7D /
        /// </summary>
        [JsonProperty("dyDeeplink")]
        public string DyDeeplink { get; set; }

        /// <summary>
        /// dyPassword string 7 抖音口令
        /// </summary>
        [JsonProperty("dyPassword")]
        public string DyPassword { get; set; }

        /// <summary>
        /// qrCode object / 二维码
        /// </summary>
        [JsonProperty("qrCode")]
        public QrCodeInfo QrCode { get; set; }

        #endregion
    }
}
