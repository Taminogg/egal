namespace ContainerToolDBDb;

public class ChecklistDto
{
    [Required] public int Id { get; set; }
    [Required] public string CustomerName { get; set; } = null!;
}