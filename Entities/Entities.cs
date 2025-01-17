﻿namespace Entities;

public class Book
{
    public int? Id { get; set; }
    public int? Pages { get; set; }
    public string? Title { get; set; }
    public virtual Author? Author { get; set; }
    public int? AuthorId { get; set; }
}

public class Author
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Book>? Books { get; set; }
    
}

public class Student
{ 
    public int Id { get; set; }
    public string? StudentName { get; set; }
    
}