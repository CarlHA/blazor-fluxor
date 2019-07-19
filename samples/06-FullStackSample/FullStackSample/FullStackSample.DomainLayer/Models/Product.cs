﻿namespace FullStackSample.DomainLayer.Models
{
	public class Product
	{
		public int Id { get; private set; }
		public ProductType Type { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
	}
}