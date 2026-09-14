using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000584 RID: 1412
[Token(Token = "0x2000584")]
public class SuperThreeGatling : ThreePeater
{
	// Token: 0x06001A16 RID: 6678 RVA: 0x0008C4E4 File Offset: 0x0008A6E4
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x4EB8A0", Offset = "0x4E9EA0", VA = "0x1804EB8A0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = global::UnityEngine.Random.Range(0, 100);
		return base.Shoot1();
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x0008C538 File Offset: 0x0008A738
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x4EBAC0", Offset = "0x4EA0C0", VA = "0x1804EBAC0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			Animator anim = this.anim;
			this.timer = 0f;
			int num3 = 0;
			anim.SetBool("shooting", num3 != 0);
		}
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x0008C594 File Offset: 0x0008A794
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x4EB7D0", Offset = "0x4E9DD0", VA = "0x1804EB7D0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (base.Shootable())
		{
			this.anim.SetTrigger("shoot");
		}
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x0008C5E0 File Offset: 0x0008A7E0
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x4EBA90", Offset = "0x4EA090", VA = "0x1804EBA90", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.timer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			return;
		}
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x0008C5FC File Offset: 0x0008A7FC
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x4EB7B0", Offset = "0x4E9DB0", VA = "0x1804EB7B0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		float num = this.timer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			base.Crashed(level, soundID, zombie);
			return;
		}
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x0008C620 File Offset: 0x0008A820
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x4EB300", Offset = "0x4E9900", VA = "0x1804EB300", Slot = "40")]
	protected override void AttributeEvent()
	{
		Transform shoot = this.shoot;
		float num = global::UnityEngine.Random.Range(-15f, 15f);
		float num2 = global::UnityEngine.Random.Range(12f, 14f);
		float num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num4 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		float num5 = global::UnityEngine.Random.Range(-15f, 15f);
		float num6 = global::UnityEngine.Random.Range(12f, 14f);
		float num7 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num8 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		int thePlantRow = this.thePlantRow;
		num6 = global::UnityEngine.Random.Range(-15f, 15f);
		num5 = global::UnityEngine.Random.Range(12f, 14f);
		float num9 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num10 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		int thePlantRow2 = this.thePlantRow;
		int rowNum = this.board.rowNum;
		num9 = global::UnityEngine.Random.Range(-15f, 15f);
		num5 = global::UnityEngine.Random.Range(12f, 14f);
		float num11 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num12 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		int num13 = this.thePlantRow;
		num13++;
		num9 = global::UnityEngine.Random.Range(num12, 0.2f);
		num5 = global::UnityEngine.Random.Range(12f, 14f);
		float num14 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num15 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		int thePlantRow3 = this.thePlantRow;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		int num16 = 0;
		base.AttributeCountdown = (float)num16;
		Animator anim = this.anim;
		int num17 = 0;
		anim.SetBool("shooting", num17 != 0);
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x0008C810 File Offset: 0x0008AA10
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x4EB970", Offset = "0x4E9F70", VA = "0x1804EB970")]
	private void SuperShoot(float angle, float speed, float x, float y, BulletMoveWay bulletMoveWay, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		int num = 0;
		Bullet bullet;
		Transform transform = bullet.transform;
		int num2 = 0;
		int num3 = 0;
		transform.Rotate((float)num3, (float)num2, x);
		bullet.normalSpeed = speed;
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x0008C86C File Offset: 0x0008AA6C
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x4EBB60", Offset = "0x4EA160", VA = "0x1804EBB60")]
	public SuperThreeGatling()
	{
	}

	// Token: 0x04000E4C RID: 3660
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E4C")]
	private float timer;

	// Token: 0x04000E4D RID: 3661
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000E4D")]
	public int _p = (int)((ulong)2L);
}
