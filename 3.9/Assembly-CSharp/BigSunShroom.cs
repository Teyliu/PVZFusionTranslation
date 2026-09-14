using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CB RID: 1227
[Token(Token = "0x20004CB")]
public class BigSunShroom : Producer
{
	// Token: 0x06001726 RID: 5926 RVA: 0x0007F284 File Offset: 0x0007D484
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x50AA10", Offset = "0x509010", VA = "0x18050AA10")]
	public void ChargeBySun(CoinSun sun)
	{
		Transform shoot = this.shoot;
		sun.target = shoot;
		Action<int> action;
		sun.action = action;
		throw new NullReferenceException();
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x0007F2AC File Offset: 0x0007D4AC
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x50AD10", Offset = "0x509310", VA = "0x18050AD10")]
	private void SunAction(int value)
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		if (gameObject != num)
		{
			base.UpdateText();
		}
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x0007F2D4 File Offset: 0x0007D4D4
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x50AB80", Offset = "0x509180", VA = "0x18050AB80", Slot = "69")]
	protected override void ProduceSun()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		base.UpdateText();
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x0007F31C File Offset: 0x0007D51C
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x50AAB0", Offset = "0x5090B0", VA = "0x18050AAB0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x0007F33C File Offset: 0x0007D53C
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BigSunShroom()
	{
	}
}
