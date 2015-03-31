namespace UCloudSDK.Models
{
    /// <summary>
    /// 修改指定UHost实例备注信息。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/modify_uhost_instance_remark.html
    ///     </para>
    /// </summary>
    public partial class ModifyUHostInstanceRemarkRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     ModifyUHostInstanceRemark
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "ModifyUHostInstanceRemark";
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
        /// UHost实例ID                
        /// </summary>
        public string UHostId { get; set; }

        /// <summary>
        /// 备注                
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 实例化 <see cref="ModifyUHostInstanceRemarkRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public ModifyUHostInstanceRemarkRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
