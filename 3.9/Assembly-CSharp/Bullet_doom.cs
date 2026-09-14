using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
public class Bullet_doom : Bullet
{
	// Token: 0x060005C9 RID: 1481 RVA: 0x0001E748 File Offset: 0x0001C948
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x6EB200", Offset = "0x6E9800", VA = "0x1806EB200", Slot = "22")]
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

	// Token: 0x060005CA RID: 1482 RVA: 0x0001E82C File Offset: 0x0001CA2C
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x6EADF0", Offset = "0x6E93F0", VA = "0x1806EADF0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0001E858 File Offset: 0x0001CA58
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x6EAED0", Offset = "0x6E94D0", VA = "0x1806EAED0", Slot = "21")]
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

	// Token: 0x060005CC RID: 1484 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001E908 File Offset: 0x0001CB08
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x6EB5F0", Offset = "0x6E9BF0", VA = "0x1806EB5F0", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.sprite;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0001E938 File Offset: 0x0001CB38
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_doom()
	{
	}

	// Token: 0x04000370 RID: 880
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000370")]
	private Transform sprite;
}
