using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040C RID: 1036
[Token(Token = "0x200040C")]
public class PuffSeaShroom : SmallPuff
{
	// Token: 0x06001326 RID: 4902 RVA: 0x0006BE8C File Offset: 0x0006A08C
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0006BEAC File Offset: 0x0006A0AC
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x462080", Offset = "0x460680", VA = "0x180462080", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		if (!this.head[2].activeSelf)
		{
			this.head[2].SetActive(true);
		}
		Mouse instance = Mouse.Instance;
		int num = this.thePlantColumn;
		int thePlantRow = this.thePlantRow;
		num++;
		Plant plant = instance.TryEatSeashroom(num, thePlantRow);
		int num2 = 0;
		if (plant == num2)
		{
			Transform axis = this.axis;
		}
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x0006BF30 File Offset: 0x0006A130
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x462200", Offset = "0x460800", VA = "0x180462200", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = 0;
		if (this.head[num].activeSelf)
		{
			Transform transform = this.shoots[num];
			CreateBullet instance = CreateBullet.Instance;
			PlantType thePlantType = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
		}
		num++;
		GameAPP.PlaySound(57, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x0006BFA8 File Offset: 0x0006A1A8
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x4623A0", Offset = "0x4609A0", VA = "0x1804623A0")]
	public PuffSeaShroom()
	{
		List<Transform> list = new List();
		this.shoots = list;
		List<GameObject> list2 = new List();
		this.head = list2;
		base..ctor();
	}

	// Token: 0x04000C4D RID: 3149
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C4D")]
	public List<Transform> shoots;

	// Token: 0x04000C4E RID: 3150
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C4E")]
	public List<GameObject> head;
}
