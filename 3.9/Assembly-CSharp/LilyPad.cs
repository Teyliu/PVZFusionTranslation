using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E7 RID: 999
[Token(Token = "0x20003E7")]
public class LilyPad : Plant
{
	// Token: 0x0600124C RID: 4684 RVA: 0x00066A50 File Offset: 0x00064C50
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x4A0190", Offset = "0x49E790", VA = "0x1804A0190", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		BoxCollider2D[] components = base.GetComponents<BoxCollider2D>();
		this.col = components;
		Transform transform = base.transform;
		int num = 0;
		SpriteRenderer component = transform.GetChild(num).gameObject.GetComponent<SpriteRenderer>();
		this.r = component;
		throw new NullReferenceException();
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00066A98 File Offset: 0x00064C98
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x4A0910", Offset = "0x49EF10", VA = "0x1804A0910", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		PlantType theLilyType = this.theLilyType;
		this.ChangeSprite(theLilyType);
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)25), (MissionResult)((uint)1)))
		{
			float num = this.growSpeed;
			this.growSpeed = num;
		}
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00066AF4 File Offset: 0x00064CF4
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x4A03D0", Offset = "0x49E9D0", VA = "0x1804A03D0")]
	private void DoomUpdate()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00066B14 File Offset: 0x00064D14
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x4A0EE0", Offset = "0x49F4E0", VA = "0x1804A0EE0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Board board = this.board;
		this.SummonUpdate();
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00066B3C File Offset: 0x00064D3C
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x4A0A60", Offset = "0x49F060", VA = "0x1804A0A60")]
	private void SummonUpdate()
	{
		int num;
		do
		{
			num = 0;
			float num2 = this.growSpeed;
			float deltaTime = Time.deltaTime;
			this.growTime = num2;
			if (num2 <= 90f)
			{
				break;
			}
			this.growTime = (float)num;
			CreatePlant instance = CreatePlant.Instance;
			int num3 = 0;
			Plant plant;
			if (!(plant != num3))
			{
				break;
			}
			ParticleManager instance2 = ParticleManager.Instance;
			Transform axis = plant.axis;
			Vector3 vector;
			float z = vector.z;
			int num4 = 0;
			int thePlantRow = plant.thePlantRow;
			ulong num5;
			Particle particle = instance2.SetParticle((ParticleType)((uint)11), num, thePlantRow, num5 != 0UL, (float)num4);
			int num6 = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num6 != 0);
			bool flag;
			if (flag)
			{
				PlantType theLilyType = this.theLilyType;
			}
		}
		while (num != 0);
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00066C08 File Offset: 0x00064E08
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x4A04B0", Offset = "0x49EAB0", VA = "0x1804A04B0", Slot = "68")]
	protected virtual void MixUpdate()
	{
		int num;
		int num4;
		do
		{
			num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Enumerable.ToList<Plant>(Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow));
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
				goto IL_0099;
			}
			num4 = 0;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
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
		num6++;
		num += 8;
		num6++;
		num += 8;
		return;
		IL_0099:
		throw new NullReferenceException();
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00066CB4 File Offset: 0x00064EB4
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x4A0480", Offset = "0x49EA80", VA = "0x1804A0480", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00066CC8 File Offset: 0x00064EC8
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x4A0E60", Offset = "0x49F460", VA = "0x1804A0E60", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (this.col[0].enabled)
		{
		}
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00066CF0 File Offset: 0x00064EF0
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x4A0250", Offset = "0x49E850", VA = "0x1804A0250")]
	public void ChangeSprite(PlantType type)
	{
		if (type == PlantType.SunFlower)
		{
		}
		if (type == PlantType.WallNut)
		{
		}
		Sprite sprite;
		if ("Plants/LilyPad/Lily_Sun" <= (ulong)7L)
		{
			sprite = Resources.Load<Sprite>("Plants/LilyPad/Lily_TorchWood");
		}
		int num = 0;
		if (sprite != num)
		{
			this.r.sprite = sprite;
		}
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00066D3C File Offset: 0x00064F3C
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x4A0130", Offset = "0x49E730", VA = "0x1804A0130")]
	private bool AllowChange(PlantType theSeedType)
	{
		return false;
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00066D4C File Offset: 0x00064F4C
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x4A0F80", Offset = "0x49F580", VA = "0x1804A0F80")]
	public LilyPad()
	{
	}

	// Token: 0x04000C50 RID: 3152
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C50")]
	protected BoxCollider2D[] col;

	// Token: 0x04000C51 RID: 3153
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C51")]
	private SpriteRenderer r;

	// Token: 0x04000C52 RID: 3154
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C52")]
	private float growTime;

	// Token: 0x04000C53 RID: 3155
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C53")]
	private float growSpeed = 1f;
}
