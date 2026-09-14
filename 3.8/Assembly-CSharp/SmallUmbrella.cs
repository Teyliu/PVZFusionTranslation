using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041F RID: 1055
[Token(Token = "0x200041F")]
public class SmallUmbrella : Plant
{
	// Token: 0x06001373 RID: 4979 RVA: 0x0006D32C File Offset: 0x0006B52C
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x431B90", Offset = "0x430190", VA = "0x180431B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0006D34C File Offset: 0x0006B54C
	[Token(Token = "0x6001374")]
	[Address(RVA = "0x466AA0", Offset = "0x4650A0", VA = "0x180466AA0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		CreatePlant instance = CreatePlant.Instance;
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0006D37C File Offset: 0x0006B57C
	[Token(Token = "0x6001375")]
	[Address(RVA = "0x466B60", Offset = "0x465160", VA = "0x180466B60")]
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

	// Token: 0x06001376 RID: 4982 RVA: 0x0006D3BC File Offset: 0x0006B5BC
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x466760", Offset = "0x464D60", VA = "0x180466760")]
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

	// Token: 0x06001377 RID: 4983 RVA: 0x0006D444 File Offset: 0x0006B644
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SmallUmbrella()
	{
	}
}
