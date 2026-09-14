using System;
using Cpp2IlInjected;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000359")]
public class BloverMine : Plant
{
	// Token: 0x06000FBD RID: 4029 RVA: 0x0005AAD8 File Offset: 0x00058CD8
	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x472B10", Offset = "0x471110", VA = "0x180472B10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)20), action, num != 0);
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0005AAF8 File Offset: 0x00058CF8
	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x472920", Offset = "0x470F20", VA = "0x180472920", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)20), action);
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x0005AB10 File Offset: 0x00058D10
	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x4729C0", Offset = "0x470FC0", VA = "0x1804729C0")]
	private void OnPlantDeath(object obj)
	{
		if (obj != 0)
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			CreatePlant instance = CreatePlant.Instance;
			this.attributeCountdown = 15f;
		}
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0005AB4C File Offset: 0x00058D4C
	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BloverMine()
	{
	}
}
