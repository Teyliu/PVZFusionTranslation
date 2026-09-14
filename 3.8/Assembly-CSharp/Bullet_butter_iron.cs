using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
public class Bullet_butter_iron : Bullet_butter
{
	// Token: 0x06000555 RID: 1365 RVA: 0x0001D024 File Offset: 0x0001B224
	[Token(Token = "0x6000555")]
	[Address(RVA = "0x6B8080", Offset = "0x6B6680", VA = "0x1806B8080", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		if (zombie.theFirstArmorHealth == 0)
		{
		}
		ulong num;
		zombie.Buttered(4f, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0001D07C File Offset: 0x0001B27C
	[Token(Token = "0x6000556")]
	[Address(RVA = "0x6B7FB0", Offset = "0x6B65B0", VA = "0x1806B7FB0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(100, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_iron()
	{
	}
}
