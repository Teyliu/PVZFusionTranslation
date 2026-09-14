using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000886 RID: 2182
[Token(Token = "0x2000886")]
public class Glove : InGameTool
{
	// Token: 0x06002C65 RID: 11365 RVA: 0x000F2104 File Offset: 0x000F0304
	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x6CA0D0", Offset = "0x6C86D0", VA = "0x1806CA0D0")]
	private void Awake()
	{
		Glove.Instance = this;
		Image component = base.GetComponent<Image>();
		this.image = component;
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x000F2128 File Offset: 0x000F0328
	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x6CA400", Offset = "0x6C8A00", VA = "0x1806CA400")]
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

	// Token: 0x06002C67 RID: 11367 RVA: 0x000F2188 File Offset: 0x000F0388
	[Token(Token = "0x6002C67")]
	[Address(RVA = "0x6CA210", Offset = "0x6C8810", VA = "0x1806CA210", Slot = "6")]
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

	// Token: 0x06002C68 RID: 11368 RVA: 0x000F21E8 File Offset: 0x000F03E8
	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x6CA150", Offset = "0x6C8750", VA = "0x1806CA150", Slot = "7")]
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

	// Token: 0x06002C69 RID: 11369 RVA: 0x000F2228 File Offset: 0x000F0428
	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x6CA4F0", Offset = "0x6C8AF0", VA = "0x1806CA4F0", Slot = "11")]
	protected override void UpdateCDTimer()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1003)))
		{
			float deltaTime = Time.deltaTime;
			this.CD = deltaTime;
		}
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x000F2254 File Offset: 0x000F0454
	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x6CA530", Offset = "0x6C8B30", VA = "0x1806CA530", Slot = "9")]
	public override void Use(Mouse mouse)
	{
		mouse.TryToPickPlant();
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x000F2270 File Offset: 0x000F0470
	[Token(Token = "0x6002C6B")]
	[Address(RVA = "0x6CA550", Offset = "0x6C8B50", VA = "0x1806CA550")]
	public Glove()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04001A56 RID: 6742
	[Token(Token = "0x4001A56")]
	public static Glove Instance;

	// Token: 0x04001A57 RID: 6743
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A57")]
	public Sprite zombieGlove;

	// Token: 0x04001A58 RID: 6744
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A58")]
	public Sprite plantGlove;

	// Token: 0x04001A59 RID: 6745
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A59")]
	public bool isZombie;

	// Token: 0x04001A5A RID: 6746
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A5A")]
	private Image image;
}
