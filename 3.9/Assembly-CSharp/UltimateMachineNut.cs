using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A2 RID: 1186
[Token(Token = "0x20004A2")]
public class UltimateMachineNut : WallNut
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06001613 RID: 5651 RVA: 0x0007972C File Offset: 0x0007792C
	[Token(Token = "0x17000153")]
	public override int LimDamage
	{
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00079740 File Offset: 0x00077940
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00079750 File Offset: 0x00077950
	[Token(Token = "0x6001615")]
	[Address(RVA = "0x4E74F0", Offset = "0x4E5AF0", VA = "0x1804E74F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)16), action, num != 0);
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00079770 File Offset: 0x00077970
	[Token(Token = "0x6001616")]
	[Address(RVA = "0x4E72F0", Offset = "0x4E58F0", VA = "0x1804E72F0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		base.OnCreate((int)reason, num);
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)16), action);
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00079794 File Offset: 0x00077994
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x4E7410", Offset = "0x4E5A10", VA = "0x1804E7410")]
	private void OnPlantRecover(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x000797B8 File Offset: 0x000779B8
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x4E73A0", Offset = "0x4E59A0", VA = "0x1804E73A0", Slot = "27")]
	protected override void LimHealth()
	{
		int num = Mathf.Min(this.thePlantHealth, 1000000000);
		this.thePlantHealth = num;
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x000797E0 File Offset: 0x000779E0
	[Token(Token = "0x6001619")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateMachineNut()
	{
	}
}
