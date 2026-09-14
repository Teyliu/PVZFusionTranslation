using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000480 RID: 1152
[Token(Token = "0x2000480")]
public class UltimateMachineNut : WallNut
{
	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06001573 RID: 5491 RVA: 0x00076DB0 File Offset: 0x00074FB0
	[Token(Token = "0x1700010D")]
	public override int LimDamage
	{
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00076DC4 File Offset: 0x00074FC4
	[Token(Token = "0x6001574")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00076DD4 File Offset: 0x00074FD4
	[Token(Token = "0x6001575")]
	[Address(RVA = "0x48DF70", Offset = "0x48C570", VA = "0x18048DF70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)16), action, num != 0);
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x00076DF4 File Offset: 0x00074FF4
	[Token(Token = "0x6001576")]
	[Address(RVA = "0x48DD70", Offset = "0x48C370", VA = "0x18048DD70", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		base.OnCreate((int)reason, num);
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)16), action);
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00076E18 File Offset: 0x00075018
	[Token(Token = "0x6001577")]
	[Address(RVA = "0x48DE90", Offset = "0x48C490", VA = "0x18048DE90")]
	private void OnPlantRecover(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00076E3C File Offset: 0x0007503C
	[Token(Token = "0x6001578")]
	[Address(RVA = "0x48DE20", Offset = "0x48C420", VA = "0x18048DE20", Slot = "28")]
	protected override void LimHealth()
	{
		int num = Mathf.Min(this.thePlantHealth, 1000000000);
		this.thePlantHealth = num;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00076E64 File Offset: 0x00075064
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateMachineNut()
	{
	}
}
