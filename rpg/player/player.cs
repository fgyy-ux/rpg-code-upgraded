using Godot;

public partial class Player: Node2D // adds new class
{
    public int playerMaxHp = 100;
    public int playerHp = 100;

    public int playerXp = 0;
    public int playerLevel = 1;
    public int XpToLevel = playerLevel * 10;
    public int abilityPoints = 0; // main player caracterization and stats
    public override void _Ready()
    {
        GD.Print("Player is ready."); // getting player ready for executing tasks
    }
}