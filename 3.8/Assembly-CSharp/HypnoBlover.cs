using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039E RID: 926
[Token(Token = "0x200039E")]
public class HypnoBlover : Blover
{
	// Token: 0x06001104 RID: 4356 RVA: 0x00060E5C File Offset: 0x0005F05C
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x43A410", Offset = "0x438A10", VA = "0x18043A410", Slot = "69")]
	protected override void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		base.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		base.Invoke("DelayDie", 5f);
		this.theStatus = (PlantStatus)((ulong)9L);
		this.DragZombieUpdate(true);
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00060ECC File Offset: 0x0005F0CC
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x43AAD0", Offset = "0x4390D0", VA = "0x18043AAD0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = 0;
		this.DragZombieUpdate(num != 0);
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00060EEC File Offset: 0x0005F0EC
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x43A540", Offset = "0x438B40", VA = "0x18043A540")]
	private void DragZombieUpdate(bool dmg)
	{
		Mouse instance = Mouse.Instance;
		int num = 0;
		float boxXFromColumn = instance.GetBoxXFromColumn(num);
		Board board = this.board;
		int num2 = 0;
		List<Zombie> zombieArray = board.zombieArray;
		Zombie zombie = this.board.zombieArray[num2];
		int num3 = 0;
		if (zombie != num3 && zombie.isMindControlled)
		{
			Transform axis = zombie.axis;
			if (!zombie.HasBuff((EffectType)((uint)11)))
			{
				if (dmg)
				{
					float totalFirstHealth = zombie.TotalFirstHealth;
				}
				int theZombieType = (int)zombie.theZombieType;
				bool flag;
				if (!flag)
				{
					int theZombieType2 = (int)zombie.theZombieType;
					bool flag2;
					if (!flag2)
					{
						int theZombieType3 = (int)zombie.theZombieType;
						bool flag3;
						if (!flag3)
						{
							Transform transform = zombie.transform;
							Vector3 vector;
							float z = vector.z;
							float deltaTime = Time.deltaTime;
						}
						Vector3 vector2;
						float z2 = vector2.z;
						float deltaTime2 = Time.deltaTime;
						Vector3 vector3;
						float z3 = vector3.z;
						float deltaTime3 = Time.deltaTime;
					}
					Vector3 vector4;
					float z4 = vector4.z;
					float deltaTime4 = Time.deltaTime;
				}
				float deltaTime5 = Time.deltaTime;
			}
		}
		Board board2 = this.board;
		num2++;
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00061014 File Offset: 0x0005F214
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x43AB10", Offset = "0x439110", VA = "0x18043AB10")]
	public HypnoBlover()
	{
	}

	// Token: 0x04000BA3 RID: 2979
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA3")]
	private readonly float dragSpeed = 2f;
}
