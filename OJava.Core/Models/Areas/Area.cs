using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace OJava.Models
{
    [Table("StsArea")]
    public class Area : Entity
    {
        public virtual string 区划名称 { get; set; }
        public virtual string 区划代码 { get; set; }

        [Column(TypeName = "text")]
        public virtual string 边界 { get; set; }

        public virtual double 经度 { get; set; }
        public virtual double 纬度 { get; set; }
        public virtual int 展示级别 { get; set; }
        public virtual string 简称 { get; set; }
        public virtual int 标识 { get; set; }
    }
}