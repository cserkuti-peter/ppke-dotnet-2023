﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBook.API.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string? Ingredients { get; set; }
        public string Method { get; set; }
        [Range(1, 1200)]
        public int CookTime { get; set; }
        [Range(1, 12)]
        public int Serves { get; set; }
        public double RatingsAvg { get; set; }
        //[ForeignKey("RecipeBook")]
        public int RecipeBookId { get; set; }
        public RecipeBook RecipeBook { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
