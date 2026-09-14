using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000131 RID: 305
[Token(Token = "0x2000131")]
public class Bullet_doom : Bullet
{
	// Token: 0x060005C2 RID: 1474 RVA: 0x0001EF78 File Offset: 0x0001D178
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x6C0430", Offset = "0x6BEA30", VA = "0x1806C0430", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform3 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		GameAPP.PlaySound(41, 0.5f, 1f);
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)2000)))
		{
			Mouse instance = Mouse.Instance;
			Transform axis = zombie.axis;
			BoardAction boardAction = this.board.boardAction;
			int num = Mathf.Max(this._damage, 1800);
			PlantType fromType2 = this.fromType;
			base.Die();
			return;
		}
		PlantType fromType3 = this.fromType;
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)31));
		while (!flag)
		{
		}
		while (flag >= true)
		{
		}
		BoardAction boardAction2 = this.board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0001F05C File Offset: 0x0001D25C
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x6C0020", Offset = "0x6BE620", VA = "0x1806C0020", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0001F088 File Offset: 0x0001D288
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x6C0100", Offset = "0x6BE700", VA = "0x1806C0100", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		ulong num;
		do
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			GameAPP.PlaySound(70, 0.5f, 1f);
			GameObject gameObject;
			Transform transform2 = gameObject.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			int thePlantRow = plant.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(plant.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		plant.FlashOnce();
		base.Die();
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0001F108 File Offset: 0x0001D308
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0001F138 File Offset: 0x0001D338
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x6C0820", Offset = "0x6BEE20", VA = "0x1806C0820", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.sprite;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0001F168 File Offset: 0x0001D368
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_doom()
	{
	}

	// Token: 0x04000369 RID: 873
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000369")]
	private Transform sprite;
}
