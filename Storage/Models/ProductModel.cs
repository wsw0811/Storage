using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class ProductModel
    {
        public Guid id { get; set; }//编号
        public string Name { get; set; }//名称
        public string Size { get; set; }//规格
        public int Type { get; set; }//型号
        public string Unit { get; set; }//单位
        public int Startstock { get; set; }//期初库存
        public int Include { get; set; }//本期收入
        public double Purchaseprice { get; set; }//采购金额
        public double Purchaseaverageprice { get; set; }//采购均价
        public int Send { get; set; }//本期发出
        public int Consumedcosts { get; set; }//成本消耗
        public int Remain { get; set; }//本月结存
        public double Stockprice { get; set; }//库存资金
        public bool IsDeleted { get; set; }
    }
}
