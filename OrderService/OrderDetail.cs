using System;
using System.Collections.Generic;

namespace OrderApp
{
    /**
     **/
    public class OrderDetail
    {
        public string Id { get; set; } //主键

        public int Index { get; set; } //序号

        public string ProductId { get; set; } //外键

        public Product Product { get; set; } //导航属性，用于做关联查询

        public string ProductName => Product?.Name ?? "";

        public double UnitPrice => Product?.Price ?? 0.0;

        public string OrderId { get; set; } //外键，不需要用Order做关联查询，所以不加导航属性

        public int Quantity { get; set; }

        public OrderDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetail(int index, Product goods, int quantity)
        {
            Index = index;
            Product = goods;
            Quantity = quantity;
        }

        public double TotalPrice => Product?.Price * Quantity ?? 0.0;

        public override string ToString()
        {
            return $"[No.:{Index},goods:{ProductName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                   ProductName == item.ProductName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}