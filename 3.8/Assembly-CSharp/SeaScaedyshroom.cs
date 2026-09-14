using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000557 RID: 1367
[Token(Token = "0x2000557")]
public class SeaScaedyshroom : ScaredyShroom
{
	// Token: 0x06001967 RID: 6503 RVA: 0x000891C8 File Offset: 0x000873C8
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x4E0440", Offset = "0x4DEA40", VA = "0x1804E0440", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x000891E4 File Offset: 0x000873E4
	[Token(Token = "0x6001968")]
	[Address(RVA = "0x4E04D0", Offset = "0x4DEAD0", VA = "0x1804E04D0", Slot = "73")]
	protected override void GetNearZombies()
	{
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("NearZombie", num != 0);
		this.isShort = false;
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x0008922C File Offset: 0x0008742C
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x4E0460", Offset = "0x4DEA60", VA = "0x1804E0460")]
	public void EatSeashroom()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
		base.AttributeCountdown = 10f;
		this.anim.SetTrigger("sea");
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00089264 File Offset: 0x00087464
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x4E0550", Offset = "0x4DEB50", VA = "0x1804E0550")]
	private void SeashroomEnterWater()
	{
		Transform transform = this.seashroom;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(24, 0.5f, 1f);
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x00089298 File Offset: 0x00087498
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SeaScaedyshroom()
	{
	}

	// Token: 0x04000E3F RID: 3647
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E3F")]
	public Transform seashroom;
}
