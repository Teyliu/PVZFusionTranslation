using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020003E2 RID: 994
[Token(Token = "0x20003E2")]
public class MelonCaltrop : Caltrop
{
	// Token: 0x0600125B RID: 4699 RVA: 0x00067730 File Offset: 0x00065930
	[Token(Token = "0x600125B")]
	[Address(RVA = "0x4529C0", Offset = "0x450FC0", VA = "0x1804529C0", Slot = "73")]
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

	// Token: 0x0600125C RID: 4700 RVA: 0x000677E0 File Offset: 0x000659E0
	[Token(Token = "0x600125C")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public MelonCaltrop()
	{
	}
}
