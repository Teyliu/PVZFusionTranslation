using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000503 RID: 1283
[Token(Token = "0x2000503")]
public class Cornpult : Thrower
{
	// Token: 0x0600181A RID: 6170 RVA: 0x00083694 File Offset: 0x00081894
	[Token(Token = "0x600181A")]
	[Address(RVA = "0x520300", Offset = "0x51E900", VA = "0x180520300", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x000836AC File Offset: 0x000818AC
	[Token(Token = "0x600181B")]
	[Address(RVA = "0x520330", Offset = "0x51E930", VA = "0x180520330", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x000836BC File Offset: 0x000818BC
	[Token(Token = "0x600181C")]
	[Address(RVA = "0x5202F0", Offset = "0x51E8F0", VA = "0x1805202F0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal;
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x000836CC File Offset: 0x000818CC
	[Token(Token = "0x600181D")]
	[Address(RVA = "0x5202E0", Offset = "0x51E8E0", VA = "0x1805202E0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter;
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x000836DC File Offset: 0x000818DC
	[Token(Token = "0x600181E")]
	[Address(RVA = "0x520360", Offset = "0x51E960", VA = "0x180520360", Slot = "44")]
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

	// Token: 0x0600181F RID: 6175 RVA: 0x00083744 File Offset: 0x00081944
	[Token(Token = "0x600181F")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public Cornpult()
	{
	}
}
