using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000331 RID: 817
[Token(Token = "0x2000331")]
public class PotatoChomper : Chomper
{
	// Token: 0x06000EE9 RID: 3817 RVA: 0x000572F4 File Offset: 0x000554F4
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x428A00", Offset = "0x427000", VA = "0x180428A00", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00057364 File Offset: 0x00055564
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x428B90", Offset = "0x427190", VA = "0x180428B90")]
	private void Explode()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00057390 File Offset: 0x00055590
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x428CE0", Offset = "0x4272E0", VA = "0x180428CE0", Slot = "70")]
	protected override void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
		base.Invoke("CreateMine", 0.5f);
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x000573D8 File Offset: 0x000555D8
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x4288D0", Offset = "0x426ED0", VA = "0x1804288D0")]
	private void CreateMine()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = this.thePlantColumn;
		num++;
		int num2 = 0;
		Plant plant;
		if (plant != num2 && plant != 0)
		{
			int num3 = 0;
			plant.AttributeCountdown = (float)num3;
			return;
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00057420 File Offset: 0x00055620
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x428C10", Offset = "0x427210", VA = "0x180428C10", Slot = "69")]
	protected override void SetAttackRange()
	{
		this.centerOffset = (ulong)1056964608L;
		this.centerOffset.y = 0.5f;
		this.range = (ulong)1056964608L;
		this.range.y = 1f;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)6), (MissionResult)((uint)2)))
		{
			Vector2 centerOffset = this.centerOffset;
			Vector2 range = this.range;
			this.centerOffset = centerOffset;
			this.range = range;
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x0005749C File Offset: 0x0005569C
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public PotatoChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}
}
