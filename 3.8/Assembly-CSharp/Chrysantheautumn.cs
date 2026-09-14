using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200036E RID: 878
[Token(Token = "0x200036E")]
public class Chrysantheautumn : Plant
{
	// Token: 0x0600101C RID: 4124 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0005CDE8 File Offset: 0x0005AFE8
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x427470", Offset = "0x425A70", VA = "0x180427470", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("lightout");
		GameAPP.PlaySound(85, 0.5f, 1f);
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0005CE1C File Offset: 0x0005B01C
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x4271F0", Offset = "0x4257F0", VA = "0x1804271F0")]
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

	// Token: 0x0600101F RID: 4127 RVA: 0x0005CE8C File Offset: 0x0005B08C
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Chrysantheautumn()
	{
	}
}
