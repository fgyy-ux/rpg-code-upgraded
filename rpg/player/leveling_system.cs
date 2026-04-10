using Godot;
public partial class LvlSys: Node2D
{
	public int playerLevel = 1;
	public int playerXp = 0;
	public int XpToLevel = playerLevel * 10;
	public int abilityPoints = 1;

	public void getXp(int amount)
	{
		playerXp += amount;
		while (playerXp >= XpToLevel)
		{
			XpToLevel -= playerXp;
			LevelUp();
		}
	}
	private void LevelUp()
	{
		playerLevel++;
		XpToLevel = playerLevel * 10;
	}
}