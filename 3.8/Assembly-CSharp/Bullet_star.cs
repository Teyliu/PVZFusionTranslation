using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
public class Bullet_star : Bullet
{
	// Token: 0x06000783 RID: 1923 RVA: 0x00026AD0 File Offset: 0x00024CD0
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x7E5720", Offset = "0x7E3D20", VA = "0x1807E5720", Slot = "8")]
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

	// Token: 0x06000784 RID: 1924 RVA: 0x00026B34 File Offset: 0x00024D34
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x7E5900", Offset = "0x7E3F00", VA = "0x1807E5900", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.star;
		float trackSpeed = this.trackSpeed;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00026B64 File Offset: 0x00024D64
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x7E5640", Offset = "0x7E3C40", VA = "0x1807E5640", Slot = "25")]
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

	// Token: 0x06000786 RID: 1926 RVA: 0x00026BB0 File Offset: 0x00024DB0
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x7E5510", Offset = "0x7E3B10", VA = "0x1807E5510", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00026BE4 File Offset: 0x00024DE4
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x7E5430", Offset = "0x7E3A30", VA = "0x1807E5430", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00026C10 File Offset: 0x00024E10
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x7E50C0", Offset = "0x7E36C0", VA = "0x1807E50C0", Slot = "14")]
	protected override Zombie GetNearestZombie()
	{
		return base.GetNearestZombie();
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00026CA4 File Offset: 0x00024EA4
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x7E5840", Offset = "0x7E3E40", VA = "0x1807E5840", Slot = "17")]
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

	// Token: 0x0600078A RID: 1930 RVA: 0x00026CDC File Offset: 0x00024EDC
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x7DB980", Offset = "0x7D9F80", VA = "0x1807DB980")]
	public Bullet_star()
	{
	}

	// Token: 0x0400039E RID: 926
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400039E")]
	public float accelerateTime;

	// Token: 0x0400039F RID: 927
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x400039F")]
	public float angularSpeed;

	// Token: 0x040003A0 RID: 928
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40003A0")]
	public float angle;

	// Token: 0x040003A1 RID: 929
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40003A1")]
	public bool movingToCircle = true;

	// Token: 0x040003A2 RID: 930
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40003A2")]
	public Vector2 targetPosition;

	// Token: 0x040003A3 RID: 931
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40003A3")]
	public bool track;

	// Token: 0x040003A4 RID: 932
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003A4")]
	private Transform star;
}
