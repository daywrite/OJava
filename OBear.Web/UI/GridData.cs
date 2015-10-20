using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBear.Web.UI
{
    /// <summary>
    /// 列表数据，封装列表的行数据与总记录数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GridData<T>
    {
        public GridData()
            : this(new List<T>(), 0)
        { }

        public GridData(IEnumerable<T> _rows, int _total)
        {
            rows = _rows;
            total = _total;
        }

        /// <summary>
        /// 获取或设置 行数据
        /// </summary>
        public IEnumerable<T> rows { get; set; }

        /// <summary>
        /// 获取或设置 数据行数
        /// </summary>
        public int total { get; set; }
    }
}
