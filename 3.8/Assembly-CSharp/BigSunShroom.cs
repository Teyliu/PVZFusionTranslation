using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A8 RID: 1192
[Token(Token = "0x20004A8")]
public class BigSunShroom : Producer
{
	// Token: 0x06001680 RID: 5760 RVA: 0x0007C68C File Offset: 0x0007A88C
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x49B0C0", Offset = "0x4996C0", VA = "0x18049B0C0")]
	public void ChargeBySun(CoinSun sun)
	{
		Transform shoot = this.shoot;
		sun.target = shoot;
		Action<int> action;
		sun.action = action;
		throw new NullReferenceException();
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0007C6B4 File Offset: 0x0007A8B4
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x49B3C0", Offset = "0x4999C0", VA = "0x18049B3C0")]
	private void SunAction(int value)
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		if (gameObject != num)
		{
			base.UpdateText();
		}
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0007C6DC File Offset: 0x0007A8DC
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x49B230", Offset = "0x499830", VA = "0x18049B230", Slot = "70")]
	protected override void ProduceSun()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		base.UpdateText();
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0007C724 File Offset: 0x0007A924
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x49B160", Offset = "0x499760", VA = "0x18049B160", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x0007C744 File Offset: 0x0007A944
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public BigSunShroom()
	{
	}
}
