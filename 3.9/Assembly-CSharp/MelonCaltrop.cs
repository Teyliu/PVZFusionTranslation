using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020003F8 RID: 1016
[Token(Token = "0x20003F8")]
public class MelonCaltrop : Caltrop
{
	// Token: 0x060012BF RID: 4799 RVA: 0x000690B0 File Offset: 0x000672B0
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x4A7500", Offset = "0x4A5B00", VA = "0x1804A7500", Slot = "72")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (!flag && zombie.Alive)
		{
			Vector2 velocity = zombie.rb.velocity;
			if (0 != 0)
			{
				int theZombieType2 = (int)zombie.theZombieType;
				bool flag2;
				if (!flag2)
				{
					zombie.ChangeStatus((ZombieStatus)((uint)16));
					Blow blow = zombie.AddComponent<Blow>();
					zombie.theOriginSpeed = 0f;
					Vector2 vector;
					zombie.rb.velocity = vector;
					return;
				}
			}
		}
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00069160 File Offset: 0x00067360
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public MelonCaltrop()
	{
	}
}
