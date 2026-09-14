using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D3 RID: 979
[Token(Token = "0x20003D3")]
public class LilyPad : Plant
{
	// Token: 0x060011F0 RID: 4592 RVA: 0x00065420 File Offset: 0x00063620
	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x44C230", Offset = "0x44A830", VA = "0x18044C230", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		BoxCollider2D[] components = base.GetComponents<BoxCollider2D>();
		this.col = components;
		Transform transform = base.transform;
		int num = 0;
		SpriteRenderer component = transform.GetChild(num).gameObject.GetComponent<SpriteRenderer>();
		this.r = component;
		PlantType theLilyType = this.theLilyType;
		this.ChangeSprite(theLilyType);
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)25), (MissionResult)((uint)1)))
		{
			float num2 = this.growSpeed;
			this.growSpeed = num2;
		}
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x0006549C File Offset: 0x0006369C
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x44C6A0", Offset = "0x44ACA0", VA = "0x18044C6A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Board board = this.board;
		this.SummonUpdate();
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x000654C4 File Offset: 0x000636C4
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x44C380", Offset = "0x44A980", VA = "0x18044C380")]
	private void SummonUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.growTime = deltaTime;
		if (deltaTime > 90f)
		{
			int num = 0;
			this.growTime = (float)num;
			CreatePlant instance = CreatePlant.Instance;
			int num2 = 0;
			Plant plant;
			if (plant != num2)
			{
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
				GameObject gameObject = GameAPP.particlePrefab[11];
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform2 = this.board.transform;
			}
		}
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00065548 File Offset: 0x00063748
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x44BE10", Offset = "0x44A410", VA = "0x18044BE10", Slot = "69")]
	protected virtual void MixUpdate()
	{
		int num4;
		do
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !(num != this))
				{
					continue;
				}
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				if (flag3)
				{
					this.theLilyType = (flag2 ? PlantType.SunFlower : PlantType.Peashooter);
				}
			}
			if (num2 != 0)
			{
				goto IL_00C7;
			}
			num4 = 0;
			BoardGrid boardGrid;
			List<Plant> plants2 = boardGrid.plants;
			bool flag4;
			if (flag4)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
		}
		while (num4 != 0);
		int num6 = 0;
		BoxCollider2D[] array = this.col;
		if (num6 < array.Length)
		{
			num6++;
			if (num6 < array.Length)
			{
				num6++;
			}
		}
		return;
		IL_00C7:
		throw new NullReferenceException();
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00065624 File Offset: 0x00063824
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x44BDE0", Offset = "0x44A3E0", VA = "0x18044BDE0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00065638 File Offset: 0x00063838
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x44C620", Offset = "0x44AC20", VA = "0x18044C620", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (this.col[0].enabled)
		{
		}
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00065660 File Offset: 0x00063860
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x44BC80", Offset = "0x44A280", VA = "0x18044BC80")]
	private void ChangeSprite(PlantType type)
	{
		if (type == PlantType.SunFlower)
		{
		}
		if (type == PlantType.WallNut)
		{
		}
		Sprite sprite;
		if ("Plants/LilyPad/Lily_Sun" <= (ulong)5L)
		{
			sprite = Resources.Load<Sprite>("Plants/LilyPad/Lily_TorchWood");
		}
		int num = 0;
		if (sprite != num)
		{
			this.r.sprite = sprite;
		}
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x000656AC File Offset: 0x000638AC
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x44BC30", Offset = "0x44A230", VA = "0x18044BC30")]
	private bool AllowChange(PlantType theSeedType)
	{
		return false;
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x000656BC File Offset: 0x000638BC
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x44C740", Offset = "0x44AD40", VA = "0x18044C740")]
	public LilyPad()
	{
	}

	// Token: 0x04000BEA RID: 3050
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BEA")]
	protected BoxCollider2D[] col;

	// Token: 0x04000BEB RID: 3051
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BEB")]
	private SpriteRenderer r;

	// Token: 0x04000BEC RID: 3052
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BEC")]
	private float growTime;

	// Token: 0x04000BED RID: 3053
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000BED")]
	private float growSpeed = 1f;
}
