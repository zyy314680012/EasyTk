using EasyTk.DaTaoKe.Response;
using System.Collections.Generic;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 超级分类
    /// 可查询大淘客所有的一级分类和二级分类，且提供一级分类图标及二级分类图标素材，协助您完善商品分类筛选功能的搭建
    /// </summary>
    public class GetSuperCategoryRequest:BaseRequest<WrapperResponse<List<GetSuperCategoryResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/category/get-super-category";

        public override string Version => "v1.1.0";
    }
}
