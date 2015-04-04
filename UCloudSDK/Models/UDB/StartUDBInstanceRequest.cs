namespace UCloudSDK.Models
{
    /// <summary>
    /// 启动udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/start_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class StartUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "StartUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     StartUDBInstance
        ///     </para>
        /// </summary>
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
               
        /// <summary>
        /// 数据中心 
        ///     <para>
        ///     请参见数据中心RegionList
        ///     </para>                 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 实例的Id                
        /// </summary>
        public string DBId { get; set; }

        /// <summary>
        /// 实例化 <see cref="StartUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        public StartUDBInstanceRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
