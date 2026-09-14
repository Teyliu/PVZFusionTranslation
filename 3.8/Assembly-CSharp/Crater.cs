using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class Crater : GridItem
{
	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00035164 File Offset: 0x00033364
	// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00035178 File Offset: 0x00033378
	[Token(Token = "0x17000081")]
	public bool Embered
	{
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x873D50", Offset = "0x872350", VA = "0x180873D50")]
		get
		{
			return this._embered;
		}
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x873D60", Offset = "0x872360", VA = "0x180873D60")]
		set
		{
			SpriteRenderer spriteRenderer = this.r;
			if (!value)
			{
				Material material = GameMaterial.GetMaterial(MaterialType.Default);
				spriteRenderer.SetMaterial(material);
				SpriteRenderer spriteRenderer2 = this.r;
			}
			Material material2 = GameMaterial.GetMaterial((MaterialType)((uint)2));
			spriteRenderer.SetMaterial(material2);
			SpriteRenderer spriteRenderer3 = this.r;
			this._embered = value;
		}
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x000351CC File Offset: 0x000333CC
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x873860", Offset = "0x871E60", VA = "0x180873860")]
	private void Awake()
	{
		this.maxTimer = 180f;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
		SpriteRenderer spriteRenderer = this.r;
		int num = 0;
		if (spriteRenderer != num)
		{
			Sprite sprite = this.r.sprite;
		}
		int num2 = 0;
		this.crater = num2;
		throw new NullReferenceException();
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0003524C File Offset: 0x0003344C
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x873C30", Offset = "0x872230", VA = "0x180873C30")]
	private void Update()
	{
		SpriteRenderer spriteRenderer;
		for (;;)
		{
			float deltaTime = Time.deltaTime;
			this.existTime = deltaTime;
			Board board = this.board;
			base.Die();
			spriteRenderer = this.r;
			float num = this.maxTimer * 0.5f;
			if (this.existTime <= num)
			{
				break;
			}
			Sprite sprite = this.crater_fading;
			if (this.existTime > this.maxTimer)
			{
				goto Block_1;
			}
		}
		Sprite sprite2 = this.crater;
		spriteRenderer.sprite = sprite2;
		return;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x000352C4 File Offset: 0x000334C4
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x873A90", Offset = "0x872090", VA = "0x180873A90")]
	private void FixedUpdate()
	{
		int num = 0;
		if ((this._embered ? 1 : 0) != num)
		{
			Transform transform = base.transform;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int theItemRow = this.theItemRow;
					bool flag2;
					if (!global::Lawnf.InLandStatus((ZombieStatus)num) || !flag2)
					{
					}
				}
				num++;
			}
		}
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00035320 File Offset: 0x00033520
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x873990", Offset = "0x871F90", VA = "0x180873990")]
	private void CraterUpdate()
	{
		SpriteRenderer spriteRenderer;
		for (;;)
		{
			Board board = this.board;
			base.Die();
			spriteRenderer = this.r;
			float num = this.maxTimer * 0.5f;
			if (this.existTime <= num)
			{
				break;
			}
			Sprite sprite = this.crater_fading;
			if (this.existTime > this.maxTimer)
			{
				goto Block_1;
			}
		}
		Sprite sprite2 = this.crater;
		spriteRenderer.sprite = sprite2;
		return;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00035384 File Offset: 0x00033584
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x873A40", Offset = "0x872040", VA = "0x180873A40", Slot = "5")]
	protected override void DieEvent()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int theItemRow = this.theItemRow;
		int theItemColumn = this.theItemColumn;
		BoardGrid grid = gridSystem.GetGrid(theItemColumn, theItemRow);
		if (grid == 0 || grid.pitNum > 0)
		{
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x000353C8 File Offset: 0x000335C8
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Crater()
	{
	}

	// Token: 0x04000514 RID: 1300
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000514")]
	public float maxTimer;

	// Token: 0x04000515 RID: 1301
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000515")]
	public Sprite crater_fading;

	// Token: 0x04000516 RID: 1302
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000516")]
	private bool _embered;

	// Token: 0x04000517 RID: 1303
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000517")]
	public float existTime;

	// Token: 0x04000518 RID: 1304
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000518")]
	private Sprite crater;

	// Token: 0x04000519 RID: 1305
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000519")]
	private SpriteRenderer r;

	// Token: 0x0400051A RID: 1306
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400051A")]
	private LayerMask zombieLayer;
}
