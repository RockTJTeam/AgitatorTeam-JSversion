using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 新建设置单位到指定站点记录类
    /// </summary>
    public class SyncStationAdd : Entity
    {
        /// <summary>
        /// 单位主键ID
        /// </summary>
        public int unitId { get; set; }

        /// <summary>
        /// 站点主键ID
        /// </summary>
        public int siteId { get; set; }
        
        /// <summary>
        /// 是否启用同步；1：开启；2：关闭
        /// </summary>
        public string syncState { get; set; }
    }
}
