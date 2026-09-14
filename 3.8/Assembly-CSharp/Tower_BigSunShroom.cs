using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D2 RID: 1490
[Token(Token = "0x20005D2")]
public class Tower_BigSunShroom : TowerProducer
{
	// Token: 0x06001BE5 RID: 7141 RVA: 0x00095028 File Offset: 0x00093228
	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x50D5E0", Offset = "0x50BBE0", VA = "0x18050D5E0", Slot = "75")]
	public override string GetUniqueText()
	{
		float num = this.amplifier * 100f;
		return string.Format("阳光增幅：{0:F2}%", "阳光增幅：{0:F2}%");
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00095054 File Offset: 0x00093254
	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x50D9D0", Offset = "0x50BFD0", VA = "0x18050D9D0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.amplifier;
		this.amplifier = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00095090 File Offset: 0x00093290
	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x50D540", Offset = "0x50BB40", VA = "0x18050D540")]
	public void ChargeBySun(CoinSun sun)
	{
		Transform shoot = this.shoot;
		sun.target = shoot;
		Action<int> action;
		sun.action = action;
		throw new NullReferenceException();
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x000950B8 File Offset: 0x000932B8
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x50D8B0", Offset = "0x50BEB0", VA = "0x18050D8B0")]
	private void SunAction(int value)
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		if (gameObject != num)
		{
			base.UpdateText();
		}
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x000950E0 File Offset: 0x000932E0
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x50D720", Offset = "0x50BD20", VA = "0x18050D720", Slot = "76")]
	protected override void ProduceSun()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		base.UpdateText();
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00095128 File Offset: 0x00093328
	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x50D650", Offset = "0x50BC50", VA = "0x18050D650", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x00095148 File Offset: 0x00093348
	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x50DA40", Offset = "0x50C040", VA = "0x18050DA40")]
	public Tower_BigSunShroom()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000EFD RID: 3837
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EFD")]
	private float amplifier = 0.3f;
}
