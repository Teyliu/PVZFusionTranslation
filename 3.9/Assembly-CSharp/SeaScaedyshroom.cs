using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000586 RID: 1414
[Token(Token = "0x2000586")]
public class SeaScaedyshroom : ScaredyShroom
{
	// Token: 0x06001A43 RID: 6723 RVA: 0x0008D138 File Offset: 0x0008B338
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x53E550", Offset = "0x53CB50", VA = "0x18053E550", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x0008D154 File Offset: 0x0008B354
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x53E5E0", Offset = "0x53CBE0", VA = "0x18053E5E0", Slot = "72")]
	protected override void GetNearZombies()
	{
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("NearZombie", num != 0);
		this.isShort = false;
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x0008D19C File Offset: 0x0008B39C
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x53E570", Offset = "0x53CB70", VA = "0x18053E570")]
	public void EatSeashroom()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
		base.AttributeCountdown = 10f;
		this.anim.SetTrigger("sea");
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x0008D1D4 File Offset: 0x0008B3D4
	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x53E660", Offset = "0x53CC60", VA = "0x18053E660")]
	private void SeashroomEnterWater()
	{
		Transform transform = this.seashroom;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(24, 0.5f, 1f);
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x0008D208 File Offset: 0x0008B408
	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SeaScaedyshroom()
	{
	}

	// Token: 0x04000EFD RID: 3837
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EFD")]
	public Transform seashroom;
}
