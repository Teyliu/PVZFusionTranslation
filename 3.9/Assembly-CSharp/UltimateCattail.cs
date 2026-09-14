using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D0 RID: 1488
[Token(Token = "0x20005D0")]
public class UltimateCattail : CattailPlant, IChargeByFire
{
	// Token: 0x06001B9E RID: 7070 RVA: 0x00093AC4 File Offset: 0x00091CC4
	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x557BF0", Offset = "0x5561F0", VA = "0x180557BF0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		bool flag;
		if (!flag)
		{
		}
		base.AttributeCountdown = 0.075f;
		Transform transform = this.laserFrom;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.laserFrom.transform;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D;
			bool flag2 = collider2D.TryGetComponent<Zombie>(num);
			if (flag2 && (collider2D <= (ulong)21L || flag2 > true) && flag2 > true && collider2D != (ulong)21L)
			{
				BoardAction boardAction = this.board.boardAction;
				PlantType thePlantType = this.thePlantType;
				Collider2D collider2D2;
				collider2D2 += collider2D2;
				num++;
			}
			num++;
		}
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00093B70 File Offset: 0x00091D70
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x557FF0", Offset = "0x5565F0", VA = "0x180557FF0", Slot = "72")]
	public void ChargeByFire(int value = 1)
	{
		if (value > 1)
		{
		}
		int num = this.attributeCount;
		num += value;
		this.attributeCount = num;
		if (num > 240)
		{
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			this.theStatus = (PlantStatus)((ulong)38L);
		}
		base.UpdateText();
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00093BD0 File Offset: 0x00091DD0
	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x557B70", Offset = "0x556170", VA = "0x180557B70")]
	private void AnimLaserUp()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
		float deltaTime = Time.deltaTime;
		base.AttributeCountdown = deltaTime;
		GameAPP.PlaySound(144, 0.5f, 1f);
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00093C0C File Offset: 0x00091E0C
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x48D320", Offset = "0x48B920", VA = "0x18048D320")]
	private void AnimLaserOver()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00093C24 File Offset: 0x00091E24
	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x558190", Offset = "0x556790", VA = "0x180558190", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num > 240)
		{
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			this.theStatus = (PlantStatus)((ulong)38L);
		}
		base.UpdateText();
		int attackDamage = this.attackDamage;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)43)))
		{
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = attackDamage;
		Transform shoot2 = this.shoot2;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet2;
		bullet2.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		return bullet2;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x00093CE8 File Offset: 0x00091EE8
	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x5580C0", Offset = "0x5566C0", VA = "0x1805580C0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x00093D08 File Offset: 0x00091F08
	[Token(Token = "0x6001BA4")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateCattail()
	{
	}

	// Token: 0x04000F4D RID: 3917
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F4D")]
	public Transform laserFrom;
}
