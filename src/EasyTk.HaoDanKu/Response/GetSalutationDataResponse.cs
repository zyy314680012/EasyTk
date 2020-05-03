using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class GetSalutationDataResponse
    {
        ///<summary> 
        ///string	http://img.haodanku.com/5c9c4f8e6053f50a1c61b1f746f1da22	问候语图片地址
        ///</summary>
        [JsonProperty("imgsrc")]
        public string ImgSrc { get; set; }

        ///<summary> 
        ///string	让我把这一整季的祝福包装起来，呈献给你，愿你欢度这个佳节，并愉悦地迈入充满希望的一年!	问候语内容
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///integer	88	点赞数
        ///</summary>
        [JsonProperty("likenum")]
        public string LikeNum { get; set; }

        ///<summary> 
        ///integer	1	分类ID
        ///</summary>
        [JsonProperty("categoryid")]
        public string CategoryId { get; set; }

    }
}
