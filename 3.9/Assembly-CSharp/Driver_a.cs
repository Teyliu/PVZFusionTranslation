using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000685 RID: 1669
[Token(Token = "0x2000685")]
public class Driver_a : Zombie
{
	// Token: 0x06001FB5 RID: 8117 RVA: 0x000A89BC File Offset: 0x000A6BBC
	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x5A17E0", Offset = "0x59FDE0", VA = "0x1805A17E0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(76, 1f, 1f);
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000A89E4 File Offset: 0x000A6BE4
	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x5A10C0", Offset = "0x59F6C0", VA = "0x1805A10C0", Slot = "30")]
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
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000A8A24 File Offset: 0x000A6C24
	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000A8A34 File Offset: 0x000A6C34
	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000A8A54 File Offset: 0x000A6C54
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x5A1530", Offset = "0x59FB30", VA = "0x1805A1530", Slot = "75")]
	public override void KillByCaltrop()
	{
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000A8ABC File Offset: 0x000A6CBC
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000A8AD0 File Offset: 0x000A6CD0
	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80")]
	protected void DieAndExplode()
	{
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000A8AE0 File Offset: 0x000A6CE0
	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x5A12A0", Offset = "0x59F8A0", VA = "0x1805A12A0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		this.DieParticle();
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000A8B08 File Offset: 0x000A6D08
	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x5A1370", Offset = "0x59F970", VA = "0x1805A1370")]
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

	// Token: 0x06001FBE RID: 8126 RVA: 0x000A8B60 File Offset: 0x000A6D60
	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000A8B70 File Offset: 0x000A6D70
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000A8B80 File Offset: 0x000A6D80
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000A8B90 File Offset: 0x000A6D90
	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x5A1870", Offset = "0x59FE70", VA = "0x1805A1870")]
	public Driver_a()
	{
	}

	// Token: 0x0400112D RID: 4397
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400112D")]
	public GameObject smoke;
}
