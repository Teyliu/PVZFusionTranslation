using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000551 RID: 1361
[Token(Token = "0x2000551")]
public class KelpPuff : Plant
{
	// Token: 0x0600194A RID: 6474 RVA: 0x00088C48 File Offset: 0x00086E48
	[Token(Token = "0x600194A")]
	[Address(RVA = "0x52DE30", Offset = "0x52C430", VA = "0x18052DE30", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		int num = 0;
		List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)941), board, num != 0);
		Board board2 = this.board;
		int num2 = 0;
		List<Plant> plants2 = Lawnf.GetPlants((PlantType)((uint)5003), board2, num2 != 0);
		SpriteRenderer spriteRenderer = this.r;
		Sprite sprite = this.gold;
		spriteRenderer.sprite = sprite;
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00088CB8 File Offset: 0x00086EB8
	[Token(Token = "0x600194B")]
	[Address(RVA = "0x52DC70", Offset = "0x52C270", VA = "0x18052DC70", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		if (base.Active)
		{
			Transform axis = this.axis;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
					if (Lawnf.ThrowLandStatus((ZombieStatus)num))
					{
						goto IL_0048;
					}
				}
				num++;
				IL_0048:
				this.anim.SetTrigger("shoot");
			}
		}
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00088D24 File Offset: 0x00086F24
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x52D810", Offset = "0x52BE10", VA = "0x18052D810")]
	private void AnimExplode()
	{
		int num = 0;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		Transform shoot2 = this.shoot;
		float num3 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		float num4;
		bullet.velocity = num4;
		float num5 = global::UnityEngine.Random.Range(num4, 3f);
		bullet.velocity.y = num5;
		num++;
		bullet.acceleration.y = -10f;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		Transform shoot3 = this.shoot;
		CreateBullet instance2 = CreateBullet.Instance;
		float num6 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		Transform shoot4 = this.shoot;
		float num7 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		PlantType thePlantType2 = this.thePlantType;
		bullet2.fromType = thePlantType2;
		float num8;
		bullet2.velocity = num8;
		float num9 = global::UnityEngine.Random.Range(num8, 3f);
		num++;
		bullet2.velocity.y = num9;
		bullet2.acceleration.y = -10f;
		Transform shoot5 = this.shoot;
		ParticleManager instance3 = ParticleManager.Instance;
		int num10 = 0;
		int thePlantRow = this.thePlantRow;
		int num11 = 0;
		ulong num12;
		Particle particle = instance3.SetParticle((ParticleType)((uint)108), num10, thePlantRow, num12 != 0UL, (float)num11);
		GameAPP.PlaySound(75, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x00088EA4 File Offset: 0x000870A4
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x52DE10", Offset = "0x52C410", VA = "0x18052DE10", Slot = "35")]
	protected override bool OnCrash()
	{
		this.AnimExplode();
		return true;
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x00088EB8 File Offset: 0x000870B8
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public KelpPuff()
	{
	}

	// Token: 0x04000EC8 RID: 3784
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EC8")]
	public SpriteRenderer r;

	// Token: 0x04000EC9 RID: 3785
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000EC9")]
	public Sprite gold;
}
