﻿namespace Entities.Models.Requests;

public class CategoryRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
}
