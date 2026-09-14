using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DB RID: 1243
[Token(Token = "0x20004DB")]
public class Cornpult : Thrower
{
	// Token: 0x06001763 RID: 5987 RVA: 0x00080414 File Offset: 0x0007E614
	[Token(Token = "0x6001763")]
	[Address(RVA = "0x4A0650", Offset = "0x49EC50", VA = "0x1804A0650", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x0008042C File Offset: 0x0007E62C
	[Token(Token = "0x6001764")]
	[Address(RVA = "0x4A0680", Offset = "0x49EC80", VA = "0x1804A0680", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x0008043C File Offset: 0x0007E63C
	[Token(Token = "0x6001765")]
	[Address(RVA = "0x4A0640", Offset = "0x49EC40", VA = "0x1804A0640", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal;
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x0008044C File Offset: 0x0007E64C
	[Token(Token = "0x6001766")]
	[Address(RVA = "0x4A0630", Offset = "0x49EC30", VA = "0x1804A0630", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter;
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x0008045C File Offset: 0x0007E65C
	[Token(Token = "0x6001767")]
	[Address(RVA = "0x4A06B0", Offset = "0x49ECB0", VA = "0x1804A06B0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (!base.DetactiveEnermy())
		{
			return;
		}
		int butterP = this.butterP;
		int num2 = global::UnityEngine.Random.Range(0, butterP);
		Animator anim = this.anim;
		if (num2 != 0)
		{
			anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x000804C4 File Offset: 0x0007E6C4
	[Token(Token = "0x6001768")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public Cornpult()
	{
	}
}
