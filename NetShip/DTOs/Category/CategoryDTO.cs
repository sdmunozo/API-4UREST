﻿namespace NetShip.DTOs.Category
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Icon { get; set; }
        public Guid ParentId { get; set; }
        public string Status { get; set; } = "Activo";
    }
}
