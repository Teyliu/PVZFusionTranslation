using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000551 RID: 1361
[Token(Token = "0x2000551")]
public class ScaredyNut : Plant
{
	// Token: 0x06001942 RID: 6466 RVA: 0x00088714 File Offset: 0x00086914
	[Token(Token = "0x6001942")]
	[Address(RVA = "0x4DE4D0", Offset = "0x4DCAD0", VA = "0x1804DE4D0", Slot = "17")]
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

	// Token: 0x06001943 RID: 6467 RVA: 0x00088768 File Offset: 0x00086968
	[Token(Token = "0x6001943")]
	[Address(RVA = "0x4DE8B0", Offset = "0x4DCEB0", VA = "0x1804DE8B0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		bool @bool = this.anim.GetBool("NearZombie");
		throw new NullReferenceException();
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x0008878C File Offset: 0x0008698C
	[Token(Token = "0x6001944")]
	[Address(RVA = "0x4DE880", Offset = "0x4DCE80", VA = "0x1804DE880", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x0008879C File Offset: 0x0008699C
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x4DE5B0", Offset = "0x4DCBB0", VA = "0x1804DE5B0", Slot = "69")]
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

	// Token: 0x06001946 RID: 6470 RVA: 0x00088878 File Offset: 0x00086A78
	[Token(Token = "0x6001946")]
	[Address(RVA = "0x4DE1A0", Offset = "0x4DC7A0", VA = "0x1804DE1A0")]
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

	// Token: 0x06001947 RID: 6471 RVA: 0x000888E8 File Offset: 0x00086AE8
	[Token(Token = "0x6001947")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "70")]
	protected virtual void ScaredEvent()
	{
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x000888F8 File Offset: 0x00086AF8
	[Token(Token = "0x6001948")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public ScaredyNut()
	{
	}

	// Token: 0x04000E3B RID: 3643
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E3B")]
	public GameObject head;

	// Token: 0x04000E3C RID: 3644
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E3C")]
	[SerializeField]
	private float timer;

	// Token: 0x04000E3D RID: 3645
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000E3D")]
	[SerializeField]
	private float timer2;
}
