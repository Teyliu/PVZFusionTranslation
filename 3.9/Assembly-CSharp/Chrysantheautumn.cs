using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200037E RID: 894
[Token(Token = "0x200037E")]
public class Chrysantheautumn : Plant
{
	// Token: 0x06001067 RID: 4199 RVA: 0x0005DD4C File Offset: 0x0005BF4C
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x0005DD6C File Offset: 0x0005BF6C
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x47E0D0", Offset = "0x47C6D0", VA = "0x18047E0D0", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("lightout");
		GameAPP.PlaySound(85, 0.5f, 1f);
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x0005DDA0 File Offset: 0x0005BFA0
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x47DE50", Offset = "0x47C450", VA = "0x18047DE50")]
	private void AnimLight()
	{
		ulong num2;
		do
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				float[] array;
				float num = array[1];
			}
		}
		while (num2 != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0005DE10 File Offset: 0x0005C010
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Chrysantheautumn()
	{
	}
}
