namespace UCloudSDK.Models
{
    /// <summary>
    /// 购买流量
    ///     <para>
    ///     http://docs.ucloud.cn/api/ucdn/buy_ucdn_traffic.html
    ///     </para>
    /// </summary>
    public partial class BuyUcdnTrafficRequest
    {
        /// <summary>
        /// API名称
        ///     <para>
        ///     BuyUcdnTraffic
        ///     </para>
        /// </summary>
        public string Action
        {
            get
            {
                return "BuyUcdnTraffic";
            }
        }  
               
        /// <summary>
        /// 所购买的流量 
        ///     <para>
        ///      单位GB
        ///     </para>                 
        /// </summary>
        public int Traffic { get; set; }

        /// <summary>
        /// 购买流量的区域 
        ///     <para>
        ///      枚举值为:cn: 国内; abroad: 海外
        ///     </para>                 
        /// </summary>
        public string Areacode { get; set; }

        /// <summary>
        /// 实例化 <see cref="BuyUcdnTrafficRequest"/> 类.
        /// </summary>
        /// <param name="traffic">所购买的流量</param>                    
        public BuyUcdnTrafficRequest(int traffic)
        {               
            Traffic = traffic;
        }                
    }
}
