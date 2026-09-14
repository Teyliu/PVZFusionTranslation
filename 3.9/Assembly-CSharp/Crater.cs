using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class Crater : GridItem
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060009DA RID: 2522 RVA: 0x00034F7C File Offset: 0x0003317C
	// (set) Token: 0x060009DB RID: 2523 RVA: 0x00034F90 File Offset: 0x00033190
	[Token(Token = "0x170000BF")]
	public bool Embered
	{
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x903CF0", Offset = "0x9022F0", VA = "0x180903CF0")]
		get
		{
			return this._embered;
		}
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x903D00", Offset = "0x902300", VA = "0x180903D00")]
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

	// Token: 0x060009DC RID: 2524 RVA: 0x00034FE4 File Offset: 0x000331E4
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x903580", Offset = "0x901B80", VA = "0x180903580")]
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

	// Token: 0x060009DD RID: 2525 RVA: 0x00035064 File Offset: 0x00033264
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x903C60", Offset = "0x902260", VA = "0x180903C60")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		this.existTime = deltaTime;
		this.CraterUpdate();
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00035088 File Offset: 0x00033288
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x903AC0", Offset = "0x9020C0", VA = "0x180903AC0")]
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

	// Token: 0x060009DF RID: 2527 RVA: 0x000350E4 File Offset: 0x000332E4
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x9036B0", Offset = "0x901CB0", VA = "0x1809036B0")]
	private void CraterUpdate()
	{
		SpriteRenderer spriteRenderer;
		for (;;)
		{
			Board board = this.board;
			base.Die();
			int theItemRow = this.theItemRow;
			List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, theItemRow);
			Func<Plant, bool> func;
			if (Crater.<>c.<>9__14_0 == 0)
			{
				func = (Plant a) => a.thePlantType == PlantType.DoomPot;
				Crater.<>c.<>9__14_0 = func;
			}
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(plantsByRow, func);
			Func<Plant, int> func2;
			if (Crater.<>c.<>9__14_1 == 0)
			{
				Crater.<>c.<>9__14_1 = func2;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, int>(enumerable, func2));
			int num = 0;
			if (plant != num)
			{
				float deltaTime = Time.deltaTime;
				float num2 = this.recoverTimer;
				this.existTime = deltaTime;
				float deltaTime2 = Time.deltaTime;
				int num3 = 0;
				this.recoverTimer = num2;
				if (num3 > (int)num2)
				{
					this.recoverTimer = 1f;
					int num4 = plant.thePlantMaxHealth.Multiply(0.02f);
					int num5 = 0;
					ulong num6;
					ulong num7;
					plant.Recover(0.02f, (DamageType)num5, num6 != 0UL, num7 != 0UL);
				}
			}
			spriteRenderer = this.r;
			float num8 = this.maxTimer * 0.5f;
			if (this.existTime <= num8)
			{
				break;
			}
			Sprite sprite = this.crater_fading;
			if (this.existTime > this.maxTimer)
			{
				goto Block_5;
			}
		}
		Sprite sprite2 = this.crater;
		spriteRenderer.sprite = sprite2;
		return;
		Block_5:
		throw new NullReferenceException();
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00035224 File Offset: 0x00033424
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x903A70", Offset = "0x902070", VA = "0x180903A70", Slot = "5")]
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

	// Token: 0x060009E1 RID: 2529 RVA: 0x00035268 File Offset: 0x00033468
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Crater()
	{
	}

	// Token: 0x0400051B RID: 1307
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400051B")]
	public float maxTimer;

	// Token: 0x0400051C RID: 1308
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400051C")]
	public Sprite crater_fading;

	// Token: 0x0400051D RID: 1309
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400051D")]
	private bool _embered;

	// Token: 0x0400051E RID: 1310
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400051E")]
	public float existTime;

	// Token: 0x0400051F RID: 1311
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400051F")]
	private Sprite crater;

	// Token: 0x04000520 RID: 1312
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000520")]
	private SpriteRenderer r;

	// Token: 0x04000521 RID: 1313
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000521")]
	private LayerMask zombieLayer;

	// Token: 0x04000522 RID: 1314
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000522")]
	private float recoverTimer;
}
