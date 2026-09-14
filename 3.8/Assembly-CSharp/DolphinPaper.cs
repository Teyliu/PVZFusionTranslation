using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000649 RID: 1609
[Token(Token = "0x2000649")]
public class DolphinPaper : PaperZombie
{
	// Token: 0x06001E89 RID: 7817 RVA: 0x000A3418 File Offset: 0x000A1618
	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x000A3428 File Offset: 0x000A1628
	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x53BBA0", Offset = "0x53A1A0", VA = "0x18053BBA0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x000A3468 File Offset: 0x000A1668
	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x53BB10", Offset = "0x53A110", VA = "0x18053BB10", Slot = "75")]
	protected override void Angry()
	{
		base.Angry();
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
		this.uniqueSpeed = 4f;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x000A34A0 File Offset: 0x000A16A0
	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x53BC40", Offset = "0x53A240", VA = "0x18053BC40", Slot = "19")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x000A3538 File Offset: 0x000A1738
	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public DolphinPaper()
	{
	}
}
