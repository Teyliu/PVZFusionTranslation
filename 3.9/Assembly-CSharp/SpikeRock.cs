using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x02000445 RID: 1093
[Token(Token = "0x2000445")]
public class SpikeRock : Caltrop
{
	// Token: 0x0600141B RID: 5147 RVA: 0x0006FD18 File Offset: 0x0006DF18
	[Token(Token = "0x600141B")]
	[Address(RVA = "0x4BEE60", Offset = "0x4BD460", VA = "0x1804BEE60", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.SpriteUpdate();
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x0006FD34 File Offset: 0x0006DF34
	[Token(Token = "0x600141C")]
	[Address(RVA = "0x4BF130", Offset = "0x4BD730", VA = "0x1804BF130", Slot = "72")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12014)))
		{
		}
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x0006FD58 File Offset: 0x0006DF58
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x4BEC40", Offset = "0x4BD240", VA = "0x1804BEC40")]
	private UniTask Blood(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		if (num2 == 0)
		{
		}
		if (num < typeof(UniTask).TypeHandle)
		{
			num += num;
			num++;
		}
		num += num;
		return default(UniTask);
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x0006FD90 File Offset: 0x0006DF90
	[Token(Token = "0x600141E")]
	[Address(RVA = "0x4BF190", Offset = "0x4BD790", VA = "0x1804BF190")]
	private void SpriteUpdate()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		int num3 = 0;
		GameObject gameObject = child.GetChild(num3).gameObject;
		int num4 = 0;
		gameObject.SetActive(num4 != 0);
		Transform transform2 = base.transform;
		int num5 = 0;
		uint num6;
		ulong num7;
		transform2.GetChild(num5).GetChild((int)num6).gameObject.SetActive(num7 != 0UL);
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0006FE98 File Offset: 0x0006E098
	[Token(Token = "0x600141F")]
	[Address(RVA = "0x4BEE80", Offset = "0x4BD480", VA = "0x1804BEE80", Slot = "70")]
	protected override void KillCar()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				int thePlantRow = this.thePlantRow;
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
			}
			num++;
		}
		int num4 = 0;
		base.Die((Plant.DieReason)num4);
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0006FF00 File Offset: 0x0006E100
	[Token(Token = "0x6001420")]
	[Address(RVA = "0x4BEE30", Offset = "0x4BD430", VA = "0x1804BEE30", Slot = "34")]
	public override void Crashed(int type = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.Crashed(type, soundID, zombie);
		this.isCrashed = false;
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0006FF20 File Offset: 0x0006E120
	[Token(Token = "0x6001421")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public SpikeRock()
	{
	}
}
