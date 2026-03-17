using System;

public abstract class Equipment
{
    private static int _nextId = 1;

    public int Id { get; }

    public string Name { get; set; }

    public streing Description { get; set; }

    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;

    public DateTime AddedDate { get; set; }

    public Equipment(string name, string description = "")
    {
        Id = _nextId++;
        Name = name; 
        Description = description;
        Status = EquipmentStatuses.Available;
        AddedDate = DateTime.Now;
    }
}