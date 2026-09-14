using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000554 RID: 1364
[Token(Token = "0x2000554")]
public class ScaredySun : Producer
{
	// Token: 0x06001955 RID: 6485 RVA: 0x00088C88 File Offset: 0x00086E88
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x4DF3E0", Offset = "0x4DD9E0", VA = "0x1804DF3E0", Slot = "17")]
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

	// Token: 0x06001956 RID: 6486 RVA: 0x00088CDC File Offset: 0x00086EDC
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x4DF4C0", Offset = "0x4DDAC0", VA = "0x1804DF4C0", Slot = "72")]
	protected virtual void GetNearZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || flag > true)
			{
			}
			num++;
		}
		ulong num3;
		this.anim.SetBool("NearZombie", num3 != 0UL);
		if (num3 != (ulong)0L)
		{
		}
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00088D3C File Offset: 0x00086F3C
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x4DF6A0", Offset = "0x4DDCA0", VA = "0x1804DF6A0", Slot = "37")]
	public override void ProducerUpdate()
	{
		float thePlantProduceInterval = this.thePlantProduceInterval;
		if (thePlantProduceInterval > 10f)
		{
			float deltaTime = Time.deltaTime;
			this.thePlantProduceInterval = thePlantProduceInterval;
		}
		base.ProducerUpdate();
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00088D70 File Offset: 0x00086F70
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ScaredySun()
	{
	}
}
