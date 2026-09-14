using System;
using Cpp2IlInjected;

// Token: 0x02000439 RID: 1081
[Token(Token = "0x2000439")]
public class ShulkBamboo : Bamboo
{
	// Token: 0x060013EA RID: 5098 RVA: 0x0006F178 File Offset: 0x0006D378
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0006F198 File Offset: 0x0006D398
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x4BC6E0", Offset = "0x4BACE0", VA = "0x1804BC6E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1.5f;
		bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)66), (MissionResult)((uint)2));
		base.GetShield(1.5f);
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.theShieldHealth = thePlantMaxHealth;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ShulkBamboo()
	{
	}
}
