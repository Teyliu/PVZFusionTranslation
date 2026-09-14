using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000402 RID: 1026
[Token(Token = "0x2000402")]
public class MoneyHypnoShroom : Plant
{
	// Token: 0x060012EB RID: 4843 RVA: 0x0006A09C File Offset: 0x0006829C
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x4AA830", Offset = "0x4A8E30", VA = "0x1804AA830", Slot = "42")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
			int theWave = this.board.theWave;
			List<ZombieSpawnData> list = zombieList[theWave];
			Func<ZombieSpawnData, bool> <>9__0_ = MoneyHypnoShroom.<>c.<>9__0_0;
			if (<>9__0_ == 0)
			{
				MoneyHypnoShroom.<>c.<>9__0_0 = delegate(ZombieSpawnData a)
				{
					int zombieType = (int)a.zombieType;
					bool flag;
					if (!flag)
					{
						int zombieType2 = (int)a.zombieType;
						bool flag2;
						if (!flag2)
						{
							int zombieType3 = (int)a.zombieType;
							bool flag3;
							return flag3;
						}
					}
					throw new NullReferenceException();
				};
			}
			ZombieSpawnData random = ListExtensions.GetRandom<ZombieSpawnData>(Enumerable.ToList<ZombieSpawnData>(Enumerable.Where<ZombieSpawnData>(list, <>9__0_)));
			CreateZombie instance2 = CreateZombie.Instance;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
		}
		throw new NullReferenceException();
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x0006A160 File Offset: 0x00068360
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x4AA740", Offset = "0x4A8D40", VA = "0x1804AA740", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		zombie.SetMindControl(num);
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
		CreateItem instance = CreateItem.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0006A194 File Offset: 0x00068394
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public MoneyHypnoShroom()
	{
	}
}
