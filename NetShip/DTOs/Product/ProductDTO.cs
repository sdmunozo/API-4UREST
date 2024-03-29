﻿namespace NetShip.DTOs.Product
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string? Icon { get; set; }
        public Guid CategoryId { get; set; }
        public string Status { get; set; } = "Activo";
    }
}
