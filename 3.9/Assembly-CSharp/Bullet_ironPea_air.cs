using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class Bullet_ironPea_air : Bullet
{
	// Token: 0x0600064E RID: 1614 RVA: 0x00020F78 File Offset: 0x0001F178
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x6F31A0", Offset = "0x6F17A0", VA = "0x1806F31A0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int theZombieRow = zombie.theZombieRow;
		this.Bomb(theZombieRow);
		base.Die();
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00020FA0 File Offset: 0x0001F1A0
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x6F3170", Offset = "0x6F1770", VA = "0x1806F3170", Slot = "17")]
	public override void HitLand()
	{
		int theBulletRow = this.theBulletRow;
		this.Bomb(theBulletRow);
		base.Die();
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00020FC4 File Offset: 0x0001F1C4
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x6F2E60", Offset = "0x6F1460", VA = "0x1806F2E60")]
	private void Bomb(int row)
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.2f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				num -= row;
				bool flag2;
				if (!flag2)
				{
					PlantType fromType = this.fromType;
				}
				PlantType fromType2 = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00021038 File Offset: 0x0001F238
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ironPea_air()
	{
	}
}
