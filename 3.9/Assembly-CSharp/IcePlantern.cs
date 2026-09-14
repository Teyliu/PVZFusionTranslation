using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C7 RID: 967
[Token(Token = "0x20003C7")]
public class IcePlantern : Plantern
{
	// Token: 0x060011BA RID: 4538 RVA: 0x00064228 File Offset: 0x00062428
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00064248 File Offset: 0x00062448
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x494DC0", Offset = "0x4933C0", VA = "0x180494DC0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.AttributeCountdown = 1f;
		HashSet<Zombie> hashSet = this.processedZombie;
		Predicate<Zombie> <>9__3_ = IcePlantern.<>c.<>9__3_0;
		if (<>9__3_ == 0)
		{
			Predicate<Zombie> predicate;
			IcePlantern.<>c.<>9__3_0 = predicate;
		}
		int num2 = hashSet.RemoveWhere(<>9__3_);
		Transform shoot = this.shoot;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				bool flag2;
				if (flag2 && !this.processedZombie.Contains(num))
				{
					bool flag3 = this.processedZombie.Add(num);
				}
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x000642E4 File Offset: 0x000624E4
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x4951B0", Offset = "0x4937B0", VA = "0x1804951B0", Slot = "68")]
	protected override GameObject GetLight()
	{
		GameObject gameObject = this.lightPrefab;
		float z = this.lightPos.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00064320 File Offset: 0x00062520
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x4952C0", Offset = "0x4938C0", VA = "0x1804952C0")]
	public IcePlantern()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.processedZombie = hashSet;
		base..ctor();
	}

	// Token: 0x04000C1D RID: 3101
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C1D")]
	public GameObject lightPrefab;

	// Token: 0x04000C1E RID: 3102
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C1E")]
	private readonly HashSet<Zombie> processedZombie;
}
