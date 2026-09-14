using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BF RID: 1215
[Token(Token = "0x20004BF")]
public class BigGatling : Shooter
{
	// Token: 0x060016F7 RID: 5879 RVA: 0x0007E724 File Offset: 0x0007C924
	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x49A140", Offset = "0x498740", VA = "0x18049A140", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		this.anim.SetBool("shooting", true);
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x0007E7B8 File Offset: 0x0007C9B8
	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x49A5B0", Offset = "0x498BB0", VA = "0x18049A5B0", Slot = "16")]
	protected override void Update()
	{
		if (base.Active)
		{
			Board board = this.board;
			this.PlantShootUpdate();
		}
		base.Update();
		throw new NullReferenceException();
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0007E7E8 File Offset: 0x0007C9E8
	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x49A100", Offset = "0x498700", VA = "0x18049A100", Slot = "73")]
	protected virtual void ModifyAttackSpeed()
	{
		this.attackSpeed = 0.75f;
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0007E818 File Offset: 0x0007CA18
	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x49A290", Offset = "0x498890", VA = "0x18049A290")]
	private void Raised()
	{
		this.theStatus = (PlantStatus)((ulong)8L);
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0007E830 File Offset: 0x0007CA30
	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x49A2A0", Offset = "0x4988A0", VA = "0x18049A2A0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		if (this.shootCount > 100)
		{
		}
		Animator anim = this.anim;
		float num = this.multiplier * this.attackSpeed;
		anim.SetFloat("attackSpeed", num);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		CreateBullet instance2 = CreateBullet.Instance;
		PlantType thePlantType2 = this.thePlantType;
		Bullet bullet2;
		bullet2.fromType = thePlantType2;
		CreateBullet instance3 = CreateBullet.Instance;
		PlantType thePlantType3 = this.thePlantType;
		Bullet bullet3;
		bullet3.fromType = thePlantType3;
		return bullet;
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x49A630", Offset = "0x498C30", VA = "0x18049A630")]
	public BigGatling()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}

	// Token: 0x04000DA8 RID: 3496
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DA8")]
	protected float attackSpeed = 1f;

	// Token: 0x04000DA9 RID: 3497
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000DA9")]
	public float multiplier = 1f;

	// Token: 0x04000DAA RID: 3498
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DAA")]
	private int shootCount;
}
