namespace UCloudSDK.Models
{
    /// <summary>
    /// 启动处于关闭状态的UHost实例，需要指定数据中心及UHostID两个参数的值。
    ///     <para>
    ///     http://docs.ucloud.cn/api/uhost/start_uhost_instance.html
    ///     </para>
    /// </summary>
    public partial class StartUHostInstanceRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     StartUHostInstance
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "StartUHostInstance";
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
        /// 实例化 <see cref="StartUHostInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="uhostid">UHost实例ID</param>                    
        public StartUHostInstanceRequest(string region, string uhostid)
        {               
            Region = region;
            UHostId = uhostid;
        }                
    }
}
