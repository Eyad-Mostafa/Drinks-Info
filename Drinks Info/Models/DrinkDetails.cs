﻿using Newtonsoft.Json;

namespace Drinks_Info.Models;

internal class DrinkDetailResponse
{
    [JsonProperty("drinks")]
    public List<DrinkDetails>? DrinkDetailList { get; set; }
}

internal class DrinkDetails
{
    public string? strDrink { get; set; }
    public object? Details { get; set; }
    public object? strTags { get; set; }
    public string? strCategory { get; set; }
    public object? strIBA { get; set; }
    public string? strAlcoholic { get; set; }
    public string? strGlass { get; set; }
    public string? strInstructions { get; set; }
    public string? strIngredient1 { get; set; }
    public string? strIngredient2 { get; set; }
    public string? strIngredient3 { get; set; }
    public string? strIngredient4 { get; set; }
    public object? strIngredient5 { get; set; }
    public object? strIngredient6 { get; set; }
    public object? strIngredient7 { get; set; }
    public object? strIngredient8 { get; set; }
    public object? strIngredient9 { get; set; }
    public object? strIngredient10 { get; set; }
    public object? strIngredient11 { get; set; }
    public object? strIngredient12 { get; set; }
    public object? strIngredient13 { get; set; }
    public object? strIngredient14 { get; set; }
    public object? strIngredient15 { get; set; }
    public string? strMeasure1 { get; set; }
    public string? strMeasure2 { get; set; }
    public string? strMeasure3 { get; set; }
    public string? strMeasure4 { get; set; }
    public object? strMeasure5 { get; set; }
    public object? strMeasure6 { get; set; }
    public object? strMeasure7 { get; set; }
    public object? strMeasure8 { get; set; }
    public object? strMeasure9 { get; set; }
    public object? strMeasure10 { get; set; }
    public object? strMeasure11 { get; set; }
    public object? strMeasure12 { get; set; }
    public object? strMeasure13 { get; set; }
    public object? strMeasure14 { get; set; }
    public object? strMeasure15 { get; set; }
}

internal class DrinkDetailDto
{
    public string? Name { get; set; }

    public object? Details { get; set; }
}