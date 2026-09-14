using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043E RID: 1086
[Token(Token = "0x200043E")]
public class SmallUmbrella : Plant
{
	// Token: 0x060013FD RID: 5117 RVA: 0x0006F5D4 File Offset: 0x0006D7D4
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x482420", Offset = "0x480A20", VA = "0x180482420", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x4BDA90", Offset = "0x4BC090", VA = "0x1804BDA90", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		CreatePlant instance = CreatePlant.Instance;
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x0006F624 File Offset: 0x0006D824
	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x4BDB50", Offset = "0x4BC150", VA = "0x1804BDB50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				this.anim.SetTrigger("block");
				this.theStatus = (PlantStatus)((ulong)25L);
			}
		}
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0006F664 File Offset: 0x0006D864
	[Token(Token = "0x6001400")]
	[Address(RVA = "0x4BD750", Offset = "0x4BBD50", VA = "0x1804BD750")]
	private void AnimBlock()
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform axis = this.axis;
		int num3 = this.zombieLayer;
		int num4 = 0;
		int num5 = 0;
		Collider2D[] array;
		if (num4 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (flag2 || !flag3 || base.PotType != PlantType.UmbrellaPot)
				{
				}
			}
			num5++;
		}
		if (num == 0)
		{
		}
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x0006F6EC File Offset: 0x0006D8EC
	[Token(Token = "0x6001401")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SmallUmbrella()
	{
	}
}
