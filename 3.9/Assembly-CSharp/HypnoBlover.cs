using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B2 RID: 946
[Token(Token = "0x20003B2")]
public class HypnoBlover : Blover
{
	// Token: 0x06001160 RID: 4448 RVA: 0x000624B4 File Offset: 0x000606B4
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x48DC50", Offset = "0x48C250", VA = "0x18048DC50", Slot = "68")]
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

	// Token: 0x06001161 RID: 4449 RVA: 0x00062524 File Offset: 0x00060724
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x48E320", Offset = "0x48C920", VA = "0x18048E320", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		int num = 0;
		this.DragZombieUpdate(num != 0);
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00062544 File Offset: 0x00060744
	[Token(Token = "0x6001162")]
	[Address(RVA = "0x48DD80", Offset = "0x48C380", VA = "0x18048DD80")]
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
					long totalFirstHealth = zombie.TotalFirstHealth;
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

	// Token: 0x06001163 RID: 4451 RVA: 0x0006266C File Offset: 0x0006086C
	[Token(Token = "0x6001163")]
	[Address(RVA = "0x48E360", Offset = "0x48C960", VA = "0x18048E360")]
	public HypnoBlover()
	{
	}

	// Token: 0x04000C09 RID: 3081
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C09")]
	private readonly float dragSpeed = 2f;
}
