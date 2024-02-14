﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class GetByIDProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Coverimage { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
