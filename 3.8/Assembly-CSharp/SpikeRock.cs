using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x02000426 RID: 1062
[Token(Token = "0x2000426")]
public class SpikeRock : Caltrop
{
	// Token: 0x06001391 RID: 5009 RVA: 0x0006DA70 File Offset: 0x0006BC70
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x467E70", Offset = "0x466470", VA = "0x180467E70", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.SpriteUpdate();
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0006DA8C File Offset: 0x0006BC8C
	[Token(Token = "0x6001392")]
	[Address(RVA = "0x468140", Offset = "0x466740", VA = "0x180468140", Slot = "73")]
	protected override void OnAttack(Zombie zombie)
	{
		base.OnAttack(zombie);
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12014)))
		{
		}
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
	[Token(Token = "0x6001393")]
	[Address(RVA = "0x467C50", Offset = "0x466250", VA = "0x180467C50")]
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

	// Token: 0x06001394 RID: 5012 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
	[Token(Token = "0x6001394")]
	[Address(RVA = "0x4681A0", Offset = "0x4667A0", VA = "0x1804681A0")]
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

	// Token: 0x06001395 RID: 5013 RVA: 0x0006DBF0 File Offset: 0x0006BDF0
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x467E90", Offset = "0x466490", VA = "0x180467E90", Slot = "71")]
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

	// Token: 0x06001396 RID: 5014 RVA: 0x0006DC58 File Offset: 0x0006BE58
	[Token(Token = "0x6001396")]
	[Address(RVA = "0x467E40", Offset = "0x466440", VA = "0x180467E40", Slot = "35")]
	public override void Crashed(int type = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.Crashed(type, soundID, zombie);
		this.isCrashed = false;
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0006DC78 File Offset: 0x0006BE78
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public SpikeRock()
	{
	}
}
