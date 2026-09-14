using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E4 RID: 1252
[Token(Token = "0x20004E4")]
public class BigGatling : Shooter
{
	// Token: 0x060017A5 RID: 6053 RVA: 0x00081678 File Offset: 0x0007F878
	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x509A40", Offset = "0x508040", VA = "0x180509A40", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		this.anim.SetBool("shooting", true);
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x0008170C File Offset: 0x0007F90C
	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x509EB0", Offset = "0x5084B0", VA = "0x180509EB0", Slot = "16")]
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

	// Token: 0x060017A7 RID: 6055 RVA: 0x0008173C File Offset: 0x0007F93C
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x509A00", Offset = "0x508000", VA = "0x180509A00", Slot = "72")]
	protected virtual void ModifyAttackSpeed()
	{
		this.attackSpeed = 0.75f;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x0008176C File Offset: 0x0007F96C
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x509B90", Offset = "0x508190", VA = "0x180509B90")]
	private void Raised()
	{
		this.theStatus = (PlantStatus)((ulong)8L);
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00081784 File Offset: 0x0007F984
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x509BA0", Offset = "0x5081A0", VA = "0x180509BA0", Slot = "68")]
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

	// Token: 0x060017AA RID: 6058 RVA: 0x0008181C File Offset: 0x0007FA1C
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x509F30", Offset = "0x508530", VA = "0x180509F30")]
	public BigGatling()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}

	// Token: 0x04000E4B RID: 3659
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E4B")]
	protected float attackSpeed = 1f;

	// Token: 0x04000E4C RID: 3660
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000E4C")]
	public float multiplier = 1f;

	// Token: 0x04000E4D RID: 3661
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E4D")]
	private int shootCount;
}
