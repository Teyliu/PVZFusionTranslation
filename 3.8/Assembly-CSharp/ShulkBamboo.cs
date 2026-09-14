using System;
using Cpp2IlInjected;

// Token: 0x0200041A RID: 1050
[Token(Token = "0x200041A")]
public class ShulkBamboo : Bamboo
{
	// Token: 0x06001360 RID: 4960 RVA: 0x0006CED0 File Offset: 0x0006B0D0
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x4656F0", Offset = "0x463CF0", VA = "0x1804656F0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1.5f;
		bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)66), (MissionResult)((uint)2));
		base.GetShield(1.5f);
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.theShieldHealth = thePlantMaxHealth;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0006CF40 File Offset: 0x0006B140
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ShulkBamboo()
	{
	}
}
