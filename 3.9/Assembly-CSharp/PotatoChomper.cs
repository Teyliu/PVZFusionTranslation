using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000341")]
public class PotatoChomper : Chomper
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00058308 File Offset: 0x00056508
	// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00058324 File Offset: 0x00056524
	[Token(Token = "0x17000110")]
	public override float ChompRange
	{
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x467FF0", Offset = "0x4665F0", VA = "0x180467FF0", Slot = "68")]
		get
		{
			return this.<ChompRange>k__BackingField * 0.5f;
		}
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x468010", Offset = "0x466610", VA = "0x180468010", Slot = "69")]
		set
		{
			this.<ChompRange>k__BackingField = value;
		}
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00058338 File Offset: 0x00056538
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x467D40", Offset = "0x466340", VA = "0x180467D40", Slot = "51")]
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

	// Token: 0x06000F36 RID: 3894 RVA: 0x000583A8 File Offset: 0x000565A8
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x467ED0", Offset = "0x4664D0", VA = "0x180467ED0")]
	private void Explode()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x000583D4 File Offset: 0x000565D4
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x467F50", Offset = "0x466550", VA = "0x180467F50", Slot = "70")]
	protected override void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
		base.Invoke("CreateMine", 0.5f);
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0005841C File Offset: 0x0005661C
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x467C10", Offset = "0x466210", VA = "0x180467C10")]
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

	// Token: 0x06000F39 RID: 3897 RVA: 0x00058464 File Offset: 0x00056664
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public PotatoChomper()
	{
	}
}
