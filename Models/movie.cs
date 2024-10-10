using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    //[Required]
    [Required(ErrorMessage = "片名是必要的")]
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [Required(ErrorMessage = "必須輸入發日期")]
    [DataType(DataType.Date)]

    public DateTime ReleaseDate { get; set; }

    [Range(1, 5000)]
    [Required(ErrorMessage = "必須輸入價格")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    //[Required]
    [Required(ErrorMessage = "請輸入影片分類")]
    [StringLength(30)]
    public string? Genre { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    //[Required]
    [Required(ErrorMessage = "首字母必須大寫。")]
    public string? Rating { get; set; }
}