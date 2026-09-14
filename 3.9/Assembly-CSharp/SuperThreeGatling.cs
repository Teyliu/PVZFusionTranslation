using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B5 RID: 1461
[Token(Token = "0x20005B5")]
public class SuperThreeGatling : ThreePeater
{
	// Token: 0x06001AFC RID: 6908 RVA: 0x0009086C File Offset: 0x0008EA6C
	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0x54B710", Offset = "0x549D10", VA = "0x18054B710", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = global::UnityEngine.Random.Range(0, 100);
		return base.Shoot1();
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000908C0 File Offset: 0x0008EAC0
	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x54B930", Offset = "0x549F30", VA = "0x18054B930", Slot = "16")]
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

	// Token: 0x06001AFE RID: 6910 RVA: 0x0009091C File Offset: 0x0008EB1C
	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x54B640", Offset = "0x549C40", VA = "0x18054B640", Slot = "44")]
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

	// Token: 0x06001AFF RID: 6911 RVA: 0x00090968 File Offset: 0x0008EB68
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x54B900", Offset = "0x549F00", VA = "0x18054B900", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		float num = this.timer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			return;
		}
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00090984 File Offset: 0x0008EB84
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x54B620", Offset = "0x549C20", VA = "0x18054B620", Slot = "34")]
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

	// Token: 0x06001B01 RID: 6913 RVA: 0x000909A8 File Offset: 0x0008EBA8
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x54B160", Offset = "0x549760", VA = "0x18054B160", Slot = "39")]
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

	// Token: 0x06001B02 RID: 6914 RVA: 0x00090B98 File Offset: 0x0008ED98
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x54B7E0", Offset = "0x549DE0", VA = "0x18054B7E0")]
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

	// Token: 0x06001B03 RID: 6915 RVA: 0x00090BF4 File Offset: 0x0008EDF4
	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x54B9D0", Offset = "0x549FD0", VA = "0x18054B9D0")]
	public SuperThreeGatling()
	{
	}

	// Token: 0x04000F0B RID: 3851
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F0B")]
	private float timer;

	// Token: 0x04000F0C RID: 3852
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000F0C")]
	public int _p = (int)((ulong)2L);
}
