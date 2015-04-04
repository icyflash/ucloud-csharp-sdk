namespace UCloudSDK.Models
{
    /// <summary>
    /// 重启udb实例
    ///     <para>
    ///     http://docs.ucloud.cn/api/udb/restart_udb_instance.html
    ///     </para>
    /// </summary>
    public partial class RestartUDBInstanceRequest
    {
        /// <summary>
        /// 默认Action名称
        /// </summary>
        private string _action = "RestartUDBInstance";

        /// <summary>
        /// API名称
        ///     <para>
        ///     RestartUDBInstance
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
        /// 实例化 <see cref="RestartUDBInstanceRequest"/> 类.
        /// </summary>
        /// <param name="region">数据中心</param>                    
        /// <param name="dbid">实例的Id</param>                    
        public RestartUDBInstanceRequest(string region, string dbid)
        {               
            Region = region;
            DBId = dbid;
        }                
    }
}
