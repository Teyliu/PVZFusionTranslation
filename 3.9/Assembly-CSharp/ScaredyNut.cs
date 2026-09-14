using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000580 RID: 1408
[Token(Token = "0x2000580")]
public class ScaredyNut : Plant
{
	// Token: 0x06001A1E RID: 6686 RVA: 0x0008C680 File Offset: 0x0008A880
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x53C5D0", Offset = "0x53ABD0", VA = "0x18053C5D0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Plant pumpkin = base.Pumpkin;
		int num = 0;
		if (pumpkin != num && base.Pumpkin.thePlantType == PlantType.ScaredyPumpkin)
		{
			Animator anim = this.anim;
			int num2 = 0;
			anim.SetBool("NearZombie", num2 != 0);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0008C6D4 File Offset: 0x0008A8D4
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x53C9B0", Offset = "0x53AFB0", VA = "0x18053C9B0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool @bool = this.anim.GetBool("NearZombie");
		throw new NullReferenceException();
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0008C6F8 File Offset: 0x0008A8F8
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x53C980", Offset = "0x53AF80", VA = "0x18053C980", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0008C708 File Offset: 0x0008A908
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x53C6B0", Offset = "0x53ACB0", VA = "0x18053C6B0", Slot = "68")]
	protected virtual void GetNearZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || flag > true)
			{
			}
			num++;
			ulong num3;
			this.anim.SetBool("NearZombie", num3 != 0UL);
			this.ScaredEvent();
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = fixedDeltaTime;
			if (fixedDeltaTime > 10f)
			{
				this.timer = (float)num;
				this.timer2 = 5f;
				base.Invoke("Action", 0.5f);
			}
			return;
		}
		Animator anim = this.anim;
		int num4 = 0;
		anim.SetBool("NearZombie", num4 != 0);
		float num5 = this.timer2;
		this.timer = (float)num;
		float fixedDeltaTime2 = Time.fixedDeltaTime;
		this.timer2 = num5;
		throw new NullReferenceException();
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x0008C7E4 File Offset: 0x0008A9E4
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x53C2A0", Offset = "0x53A8A0", VA = "0x18053C2A0")]
	private void Action()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				PlantType thePlantType = this.thePlantType;
				Vector3 vector;
				float z = vector.z;
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
			}
			num++;
		}
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x0008C854 File Offset: 0x0008AA54
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "69")]
	protected virtual void ScaredEvent()
	{
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x0008C864 File Offset: 0x0008AA64
	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public ScaredyNut()
	{
	}

	// Token: 0x04000EF9 RID: 3833
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EF9")]
	public GameObject head;

	// Token: 0x04000EFA RID: 3834
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000EFA")]
	[SerializeField]
	private float timer;

	// Token: 0x04000EFB RID: 3835
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000EFB")]
	[SerializeField]
	private float timer2;
}
