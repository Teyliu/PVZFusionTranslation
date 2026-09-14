using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050E RID: 1294
[Token(Token = "0x200050E")]
public class DoomStar : Plant
{
	// Token: 0x0600184A RID: 6218 RVA: 0x00084178 File Offset: 0x00082378
	[Token(Token = "0x600184A")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x00084198 File Offset: 0x00082398
	[Token(Token = "0x600184B")]
	[Address(RVA = "0x522540", Offset = "0x520B40", VA = "0x180522540", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("shake");
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x000841C4 File Offset: 0x000823C4
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x522460", Offset = "0x520A60", VA = "0x180522460", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BigStar.SetStar((BigStar.BigStarType)((uint)6));
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int num3 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num2, thePlantRow, num4 != 0UL, (float)num3);
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00084214 File Offset: 0x00082414
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomStar()
	{
	}
}
