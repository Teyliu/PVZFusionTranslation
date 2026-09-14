using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200040F RID: 1039
[Token(Token = "0x200040F")]
public class Pumpiner : Plant
{
	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06001333 RID: 4915 RVA: 0x0006C438 File Offset: 0x0006A638
	// (set) Token: 0x06001334 RID: 4916 RVA: 0x0006C44C File Offset: 0x0006A64C
	[Token(Token = "0x170000F7")]
	public virtual Dictionary<PlantType, int> PumpinerPlants
	{
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x463B60", Offset = "0x462160", VA = "0x180463B60", Slot = "69")]
		get;
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x463B70", Offset = "0x462170", VA = "0x180463B70", Slot = "70")]
		set;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0006C460 File Offset: 0x0006A660
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x4639C0", Offset = "0x461FC0", VA = "0x1804639C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0006C474 File Offset: 0x0006A674
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x4635C0", Offset = "0x461BC0", VA = "0x1804635C0", Slot = "71")]
	protected virtual void Check()
	{
		int thePlantRow = this.thePlantRow;
		Func<Plant, bool> func;
		if (Enumerable.Any<Plant>(global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow), func))
		{
			base.Die((Plant.DieReason)((uint)8));
			Transform axis = this.axis;
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("这个格子有植物了", 3f, num != 0);
		}
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x4638D0", Offset = "0x461ED0", VA = "0x1804638D0")]
	public bool SaveCard(CardUI card)
	{
		bool flag;
		if (card != 0 && flag)
		{
			GameAPP.PlaySound((SoundType)((uint)22), 0.5f, 1f);
			return true;
		}
		return false;
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x0006C500 File Offset: 0x0006A700
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x463340", Offset = "0x461940", VA = "0x180463340", Slot = "72")]
	public virtual bool Add(PlantType thePlantType, bool ignoreStack = false, bool fromPumpiner = false)
	{
		if (!this.gambling)
		{
			Board board = this.board;
			this.MaxGridCount = (int)((ulong)54L);
			if (this.PumpinerPlants.Count < this.MaxGridCount)
			{
				Dictionary<PlantType, int> pumpinerPlants = this.PumpinerPlants;
				bool flag;
				if (!flag)
				{
					Dictionary<PlantType, int> pumpinerPlants2 = this.PumpinerPlants;
				}
				CardLevel cardLevel;
				if (cardLevel <= CardLevel.Red)
				{
				}
				Board board2 = this.board;
				if (ignoreStack)
				{
					Dictionary<PlantType, int> pumpinerPlants3 = this.PumpinerPlants;
					List<PlantType> list = this.contains;
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x0006C57C File Offset: 0x0006A77C
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x463710", Offset = "0x461D10", VA = "0x180463710", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		if (this.PumpinerPlants.Count != 0)
		{
			Time.timeScale = (float)0;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			int num = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)83), num != 0);
			if (this.onOpenChest != 0)
			{
			}
			return true;
		}
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("箱子里没有任何卡牌", 3f, num2 != 0);
		return true;
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0006C5E4 File Offset: 0x0006A7E4
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x463A80", Offset = "0x462080", VA = "0x180463A80")]
	public Pumpiner()
	{
		List<PlantType> list = new List();
		this.contains = list;
		Dictionary<PlantType, int> dictionary = new Dictionary();
		this.PumpinerPlants = dictionary;
		base..ctor();
	}

	// Token: 0x04000C5C RID: 3164
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C5C")]
	private int MaxGridCount = (int)((ulong)27L);

	// Token: 0x04000C5D RID: 3165
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C5D")]
	public List<PlantType> contains;

	// Token: 0x04000C5F RID: 3167
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C5F")]
	public UnityEvent<PumpinerChestMenu> onOpenChest;

	// Token: 0x04000C60 RID: 3168
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C60")]
	public bool gambling;
}
