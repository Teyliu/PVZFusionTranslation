using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064F RID: 1615
[Token(Token = "0x200064F")]
public class Driver_a : Zombie
{
	// Token: 0x06001EB3 RID: 7859 RVA: 0x000A4264 File Offset: 0x000A2464
	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0x53F190", Offset = "0x53D790", VA = "0x18053F190", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(76, 1f, 1f);
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x000A428C File Offset: 0x000A248C
	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0x53EAC0", Offset = "0x53D0C0", VA = "0x18053EAC0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x000A42CC File Offset: 0x000A24CC
	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x000A42DC File Offset: 0x000A24DC
	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000A42FC File Offset: 0x000A24FC
	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x53EF20", Offset = "0x53D520", VA = "0x18053EF20", Slot = "73")]
	public override void KillByCaltrop()
	{
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000A4364 File Offset: 0x000A2564
	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x000A4378 File Offset: 0x000A2578
	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300")]
	protected void DieAndExplode()
	{
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000A4388 File Offset: 0x000A2588
	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x53EC90", Offset = "0x53D290", VA = "0x18053EC90", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		this.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x000A43B0 File Offset: 0x000A25B0
	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x53ED60", Offset = "0x53D360", VA = "0x18053ED60")]
	protected void DieParticle()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[36];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x000A4408 File Offset: 0x000A2608
	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x000A4418 File Offset: 0x000A2618
	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000A4428 File Offset: 0x000A2628
	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x000A4438 File Offset: 0x000A2638
	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x53F220", Offset = "0x53D820", VA = "0x18053F220")]
	public Driver_a()
	{
	}

	// Token: 0x04001061 RID: 4193
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001061")]
	public GameObject smoke;
}
