using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000607 RID: 1543
[Token(Token = "0x2000607")]
public class Tower_BigSunShroom : TowerProducer
{
	// Token: 0x06001CE4 RID: 7396 RVA: 0x00099C40 File Offset: 0x00097E40
	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x55E830", Offset = "0x55CE30", VA = "0x18055E830", Slot = "74")]
	public override string GetUniqueText()
	{
		float num = this.amplifier * 100f;
		return string.Format("阳光增幅：{0:F2}%", "阳光增幅：{0:F2}%");
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x00099C6C File Offset: 0x00097E6C
	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0x55EC20", Offset = "0x55D220", VA = "0x18055EC20", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.amplifier;
		this.amplifier = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x00099CA8 File Offset: 0x00097EA8
	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x55E790", Offset = "0x55CD90", VA = "0x18055E790")]
	public void ChargeBySun(CoinSun sun)
	{
		Transform shoot = this.shoot;
		sun.target = shoot;
		Action<int> action;
		sun.action = action;
		throw new NullReferenceException();
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x00099CD0 File Offset: 0x00097ED0
	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x55EB00", Offset = "0x55D100", VA = "0x18055EB00")]
	private void SunAction(int value)
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		if (gameObject != num)
		{
			base.UpdateText();
		}
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x00099CF8 File Offset: 0x00097EF8
	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x55E970", Offset = "0x55CF70", VA = "0x18055E970", Slot = "75")]
	protected override void ProduceSun()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		base.UpdateText();
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x00099D40 File Offset: 0x00097F40
	[Token(Token = "0x6001CE9")]
	[Address(RVA = "0x55E8A0", Offset = "0x55CEA0", VA = "0x18055E8A0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x00099D60 File Offset: 0x00097F60
	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x55EC90", Offset = "0x55D290", VA = "0x18055EC90")]
	public Tower_BigSunShroom()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000FC5 RID: 4037
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FC5")]
	private float amplifier = 0.3f;
}
