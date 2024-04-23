namespace SqlClientExample.DTOs;

public record GetAnimalDetailsResponse(int id, string Name, string Description, string Category, string Area);