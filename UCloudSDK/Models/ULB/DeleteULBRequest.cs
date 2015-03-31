namespace UCloudSDK.Models
{
    /// <summary>
    /// 删除负载均衡实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/ulb/delete_ulb.html
    ///     </para>
    /// </summary>
    public partial class DeleteULBRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     DeleteULB
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "DeleteULB";
            }
        }  
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     参见 数据中心列表
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 负载均衡实例的ID                
        /// </summary>
        public string ULBId { get; set; }

        /// <summary>
        /// 实例化 <see cref="DeleteULBRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="ulbid">负载均衡实例的ID</param>                    
        public DeleteULBRequest(string region, string ulbid)
        {               
            Region = region;
            ULBId = ulbid;
        }                
    }
}
