using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000583 RID: 1411
[Token(Token = "0x2000583")]
public class ScaredySun : Producer
{
	// Token: 0x06001A31 RID: 6705 RVA: 0x0008CBF4 File Offset: 0x0008ADF4
	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x53D4E0", Offset = "0x53BAE0", VA = "0x18053D4E0", Slot = "17")]
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

	// Token: 0x06001A32 RID: 6706 RVA: 0x0008CC48 File Offset: 0x0008AE48
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x53D5C0", Offset = "0x53BBC0", VA = "0x18053D5C0", Slot = "71")]
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

	// Token: 0x06001A33 RID: 6707 RVA: 0x0008CCA8 File Offset: 0x0008AEA8
	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x53D7A0", Offset = "0x53BDA0", VA = "0x18053D7A0", Slot = "36")]
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

	// Token: 0x06001A34 RID: 6708 RVA: 0x0008CCDC File Offset: 0x0008AEDC
	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ScaredySun()
	{
	}
}
