using Godot;

public partial class Player: Node2D
{
    public int playerMaxHp = 100;
    public int playerHp = 100;

    public int playerXp = 0;
    public int playerLevel = 1;
    public int XpToLevel = playerLevel * 10;
    public int abilityPoints = 0;
    public override void _Ready()
    {
        GD.Print("Player is ready.");
    }
}