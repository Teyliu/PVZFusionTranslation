using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B3 RID: 947
[Token(Token = "0x20003B3")]
public class IcePlantern : Plantern
{
	// Token: 0x0600115E RID: 4446 RVA: 0x00062C08 File Offset: 0x00060E08
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00062C28 File Offset: 0x00060E28
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x440F90", Offset = "0x43F590", VA = "0x180440F90", Slot = "40")]
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

	// Token: 0x06001160 RID: 4448 RVA: 0x00062CC4 File Offset: 0x00060EC4
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x441380", Offset = "0x43F980", VA = "0x180441380", Slot = "69")]
	protected override GameObject GetLight()
	{
		GameObject gameObject = this.lightPrefab;
		float z = this.lightPos.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00062D00 File Offset: 0x00060F00
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x431100", Offset = "0x42F700", VA = "0x180431100")]
	public IcePlantern()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.processedZombie = hashSet;
		base..ctor();
	}

	// Token: 0x04000BB7 RID: 2999
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BB7")]
	public GameObject lightPrefab;

	// Token: 0x04000BB8 RID: 3000
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BB8")]
	private readonly HashSet<Zombie> processedZombie;
}
