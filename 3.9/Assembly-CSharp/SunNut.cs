using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000349 RID: 841
[Token(Token = "0x2000349")]
public class SunNut : Producer
{
	// Token: 0x06000F5F RID: 3935 RVA: 0x00058D78 File Offset: 0x00056F78
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00058D88 File Offset: 0x00056F88
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x46ABC0", Offset = "0x4691C0", VA = "0x18046ABC0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		base.ProduceSunWithNoSound();
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00058D9C File Offset: 0x00056F9C
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x46AD20", Offset = "0x469320", VA = "0x18046AD20", Slot = "28")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		uint num4;
		ulong num5;
		base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
		if (!this.produceSun1)
		{
			base.ProduceSun();
			this.produceSun1 = true;
		}
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00058EFC File Offset: 0x000570FC
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x46AC30", Offset = "0x469230", VA = "0x18046AC30")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Zombie"))
		{
			Zombie component = collision.GetComponent<Zombie>();
			int thePlantRow = this.thePlantRow;
			if (component.theZombieRow == thePlantRow && component.theAttackTarget == this && collision.gameObject.GetComponent<Zombie>().theStatus != ZombieStatus.Dying)
			{
				this.thePlantSpeed = 0f;
			}
		}
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00058F60 File Offset: 0x00057160
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x46AC00", Offset = "0x469200", VA = "0x18046AC00", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00058F84 File Offset: 0x00057184
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SunNut()
	{
	}

	// Token: 0x04000B7D RID: 2941
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B7D")]
	private bool produceSun1;

	// Token: 0x04000B7E RID: 2942
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000B7E")]
	private bool produceSun2;
}
