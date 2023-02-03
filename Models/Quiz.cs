﻿using QuizAPI.Interfaces;

namespace QuizAPI.Models;

public class Quiz : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public List<Question> Questions { get; set; } = new();
}
