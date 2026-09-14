using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000427 RID: 1063
[Token(Token = "0x2000427")]
public class PuffSeaShroom : SmallPuff
{
	// Token: 0x0600139C RID: 5020 RVA: 0x0006DD24 File Offset: 0x0006BF24
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0006DD44 File Offset: 0x0006BF44
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x4B8770", Offset = "0x4B6D70", VA = "0x1804B8770", Slot = "39")]
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

	// Token: 0x0600139E RID: 5022 RVA: 0x0006DDC8 File Offset: 0x0006BFC8
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x4B88F0", Offset = "0x4B6EF0", VA = "0x1804B88F0", Slot = "68")]
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

	// Token: 0x0600139F RID: 5023 RVA: 0x0006DE40 File Offset: 0x0006C040
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x4B8A90", Offset = "0x4B7090", VA = "0x1804B8A90")]
	public PuffSeaShroom()
	{
		List<Transform> list = new List();
		this.shoots = list;
		List<GameObject> list2 = new List();
		this.head = list2;
		base..ctor();
	}

	// Token: 0x04000CC8 RID: 3272
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CC8")]
	public List<Transform> shoots;

	// Token: 0x04000CC9 RID: 3273
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CC9")]
	public List<GameObject> head;
}
