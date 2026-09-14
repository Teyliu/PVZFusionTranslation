using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000339 RID: 825
[Token(Token = "0x2000339")]
public class SunNut : Producer
{
	// Token: 0x06000F14 RID: 3860 RVA: 0x00057DD0 File Offset: 0x00055FD0
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00057DE0 File Offset: 0x00055FE0
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x42A020", Offset = "0x428620", VA = "0x18042A020", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		base.ProduceSunWithNoSound();
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00057DF4 File Offset: 0x00055FF4
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x42A180", Offset = "0x428780", VA = "0x18042A180", Slot = "29")]
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

	// Token: 0x06000F17 RID: 3863 RVA: 0x00057F54 File Offset: 0x00056154
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x42A090", Offset = "0x428690", VA = "0x18042A090")]
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

	// Token: 0x06000F18 RID: 3864 RVA: 0x00057FB8 File Offset: 0x000561B8
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x42A060", Offset = "0x428660", VA = "0x18042A060", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float theOriginSpeed = this.theOriginSpeed;
		this.thePlantSpeed = theOriginSpeed;
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00057FDC File Offset: 0x000561DC
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SunNut()
	{
	}

	// Token: 0x04000B2C RID: 2860
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B2C")]
	private bool produceSun1;

	// Token: 0x04000B2D RID: 2861
	[FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000B2D")]
	private bool produceSun2;
}
