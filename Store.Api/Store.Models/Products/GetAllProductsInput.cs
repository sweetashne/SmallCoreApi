﻿namespace Store.Models.Products
{
    public class GetAllProductsInput
    {
        public string TypeCode { get; set; }
        public string UnitCode { get; set; }
        public string CategoryCode { get; set; }
        public int MaxResultCount { get; set; }
        public int SkipCount { get; set; }
    }
}