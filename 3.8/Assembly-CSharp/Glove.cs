using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200084A RID: 2122
[Token(Token = "0x200084A")]
public class Glove : InGameTool
{
	// Token: 0x06002B33 RID: 11059 RVA: 0x000ED3F8 File Offset: 0x000EB5F8
	[Token(Token = "0x6002B33")]
	[Address(RVA = "0x665560", Offset = "0x663B60", VA = "0x180665560")]
	private void Awake()
	{
		Glove.Instance = this;
		Image component = base.GetComponent<Image>();
		this.image = component;
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x000ED41C File Offset: 0x000EB61C
	[Token(Token = "0x6002B34")]
	[Address(RVA = "0x665890", Offset = "0x663E90", VA = "0x180665890")]
	public void SwitchStatus()
	{
		Sprite sprite = this.zombieGlove;
		int num = 0;
		if (!(sprite == num))
		{
			Sprite sprite2 = this.plantGlove;
			int num2 = 0;
			if (!(sprite2 == num2))
			{
				Board board = this.board;
				bool flag = !this.isZombie;
				this.isZombie = flag;
				Image image = this.image;
			}
		}
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x000ED47C File Offset: 0x000EB67C
	[Token(Token = "0x6002B35")]
	[Address(RVA = "0x6656A0", Offset = "0x663CA0", VA = "0x1806656A0", Slot = "6")]
	protected override void Start()
	{
		ulong num2;
		do
		{
			int num = 0;
			base.Start();
			List<TalentType> talents = AdvantureConfig.data.talents;
			bool flag;
			if (flag)
			{
				if (num != 12 && num != 27)
				{
					while (num != 28)
					{
					}
					float coolSpeed = this.coolSpeed;
					this.coolSpeed = coolSpeed;
				}
				float coolSpeed2 = this.coolSpeed;
				this.coolSpeed = coolSpeed2;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x000ED4DC File Offset: 0x000EB6DC
	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x6655E0", Offset = "0x663BE0", VA = "0x1806655E0", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Glove))
		{
			Mouse mouse = this.mouse;
			bool flag = base.OnClick(mouse);
		}
		if (Input.GetKeyDownInt(KeyCodeManager.ZombieGlove))
		{
			this.SwitchStatus();
			return;
		}
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x000ED51C File Offset: 0x000EB71C
	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x665980", Offset = "0x663F80", VA = "0x180665980", Slot = "11")]
	protected override void UpdateCDTimer()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1003)))
		{
			float deltaTime = Time.deltaTime;
			this.CD = deltaTime;
		}
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x000ED548 File Offset: 0x000EB748
	[Token(Token = "0x6002B38")]
	[Address(RVA = "0x6659C0", Offset = "0x663FC0", VA = "0x1806659C0", Slot = "9")]
	public override void Use(Mouse mouse)
	{
		mouse.TryToPickPlant();
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x000ED564 File Offset: 0x000EB764
	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x6659E0", Offset = "0x663FE0", VA = "0x1806659E0")]
	public Glove()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04001968 RID: 6504
	[Token(Token = "0x4001968")]
	public static Glove Instance;

	// Token: 0x04001969 RID: 6505
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001969")]
	public Sprite zombieGlove;

	// Token: 0x0400196A RID: 6506
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400196A")]
	public Sprite plantGlove;

	// Token: 0x0400196B RID: 6507
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400196B")]
	public bool isZombie;

	// Token: 0x0400196C RID: 6508
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400196C")]
	private Image image;
}
