using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public class Bullet_star : Bullet
{
	// Token: 0x06000790 RID: 1936 RVA: 0x000263F8 File Offset: 0x000245F8
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x812AA0", Offset = "0x8110A0", VA = "0x180812AA0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		Transform transform = base.transform;
		int num = 0;
		Transform transform2 = transform.GetChild(num).transform;
		this.star = transform2;
		Transform transform3 = base.transform;
		int num2 = 0;
		this.movingToCircle = true;
		this.accelerateTime = (float)num2;
		this.angle = (float)num2;
		this.angularSpeed = -3f;
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0002645C File Offset: 0x0002465C
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x812C80", Offset = "0x811280", VA = "0x180812C80", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.star;
		float trackSpeed = this.trackSpeed;
		float num = Mathf.Min(trackSpeed, 12f);
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0002649C File Offset: 0x0002469C
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x8129C0", Offset = "0x810FC0", VA = "0x1808129C0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x000264E8 File Offset: 0x000246E8
	[Token(Token = "0x6000793")]
	[Address(RVA = "0x812890", Offset = "0x810E90", VA = "0x180812890", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0002651C File Offset: 0x0002471C
	[Token(Token = "0x6000794")]
	[Address(RVA = "0x8127B0", Offset = "0x810DB0", VA = "0x1808127B0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00026548 File Offset: 0x00024748
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x812BC0", Offset = "0x8111C0", VA = "0x180812BC0", Slot = "16")]
	protected override void MoveDieUpdate(Vector2 currentPosition)
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			float minX = this.minX;
			base.Die();
			return;
		}
		base.MoveDieUpdate(currentPosition);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00026580 File Offset: 0x00024780
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_star()
	{
	}

	// Token: 0x040003A7 RID: 935
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003A7")]
	public float accelerateTime;

	// Token: 0x040003A8 RID: 936
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40003A8")]
	public float angularSpeed;

	// Token: 0x040003A9 RID: 937
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003A9")]
	public float angle;

	// Token: 0x040003AA RID: 938
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40003AA")]
	public bool movingToCircle = true;

	// Token: 0x040003AB RID: 939
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40003AB")]
	public Vector2 targetPosition;

	// Token: 0x040003AC RID: 940
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40003AC")]
	public bool track;

	// Token: 0x040003AD RID: 941
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40003AD")]
	private Transform star;
}
