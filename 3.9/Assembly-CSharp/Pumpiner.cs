using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200042A RID: 1066
[Token(Token = "0x200042A")]
public class Pumpiner : Plant
{
	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0006E2D0 File Offset: 0x0006C4D0
	// (set) Token: 0x060013AA RID: 5034 RVA: 0x0006E2E4 File Offset: 0x0006C4E4
	[Token(Token = "0x1700013B")]
	public virtual Dictionary<PlantType, int> PumpinerPlants
	{
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x4BA260", Offset = "0x4B8860", VA = "0x1804BA260", Slot = "68")]
		get;
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x4BA270", Offset = "0x4B8870", VA = "0x1804BA270", Slot = "69")]
		set;
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0006E2F8 File Offset: 0x0006C4F8
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x4BA0C0", Offset = "0x4B86C0", VA = "0x1804BA0C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0006E30C File Offset: 0x0006C50C
	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x4B9CB0", Offset = "0x4B82B0", VA = "0x1804B9CB0", Slot = "70")]
	protected virtual void Check()
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> func = delegate(Plant a)
		{
			if (a.plantTag == (ulong)0L && !a.isLily)
			{
				return a != this;
			}
			throw new NullReferenceException();
		};
		if (Enumerable.Any<Plant>(list, func))
		{
			base.Die((Plant.DieReason)((uint)8));
			Transform axis = this.axis;
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0006E364 File Offset: 0x0006C564
	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x4B9FD0", Offset = "0x4B85D0", VA = "0x1804B9FD0")]
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

	// Token: 0x060013AE RID: 5038 RVA: 0x0006E390 File Offset: 0x0006C590
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x4B9A30", Offset = "0x4B8030", VA = "0x1804B9A30", Slot = "71")]
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

	// Token: 0x060013AF RID: 5039 RVA: 0x0006E40C File Offset: 0x0006C60C
	[Token(Token = "0x60013AF")]
	[Address(RVA = "0x4B9E00", Offset = "0x4B8400", VA = "0x1804B9E00", Slot = "61")]
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
		return true;
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0006E460 File Offset: 0x0006C660
	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x4BA180", Offset = "0x4B8780", VA = "0x1804BA180")]
	public Pumpiner()
	{
		List<PlantType> list = new List();
		this.contains = list;
		Dictionary<PlantType, int> dictionary = new Dictionary();
		this.PumpinerPlants = dictionary;
		base..ctor();
	}

	// Token: 0x04000CD7 RID: 3287
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CD7")]
	private int MaxGridCount = (int)((ulong)27L);

	// Token: 0x04000CD8 RID: 3288
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CD8")]
	public List<PlantType> contains;

	// Token: 0x04000CDA RID: 3290
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CDA")]
	public UnityEvent<PumpinerChestMenu> onOpenChest;

	// Token: 0x04000CDB RID: 3291
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CDB")]
	public bool gambling;
}
