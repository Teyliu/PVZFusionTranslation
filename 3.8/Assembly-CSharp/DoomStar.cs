using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E6 RID: 1254
[Token(Token = "0x20004E6")]
public class DoomStar : Plant
{
	// Token: 0x06001793 RID: 6035 RVA: 0x00080F30 File Offset: 0x0007F130
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00080F50 File Offset: 0x0007F150
	[Token(Token = "0x6001794")]
	[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("shake");
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x00080F7C File Offset: 0x0007F17C
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x4C7120", Offset = "0x4C5720", VA = "0x1804C7120", Slot = "40")]
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

	// Token: 0x06001796 RID: 6038 RVA: 0x00080FCC File Offset: 0x0007F1CC
	[Token(Token = "0x6001796")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomStar()
	{
	}
}
