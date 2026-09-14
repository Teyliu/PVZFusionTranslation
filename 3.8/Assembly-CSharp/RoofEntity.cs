using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000782 RID: 1922
[Token(Token = "0x2000782")]
public class RoofEntity : MonoBehaviour
{
	// Token: 0x060026CF RID: 9935 RVA: 0x000CF3D4 File Offset: 0x000CD5D4
	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x608210", Offset = "0x606810", VA = "0x180608210")]
	private void Awake()
	{
		int num = 0;
		if (base.TryGetComponent<Plant>(num))
		{
			this.plant = num;
			GameObject gameObject = base.transform.Find("Shadow").gameObject;
			this.land = gameObject;
			this.entityRow = num;
			return;
		}
		if (base.TryGetComponent<Zombie>(num))
		{
			this.zombie = num;
			GameObject gameObject2 = base.transform.Find("Shadow").gameObject;
			this.land = gameObject2;
			this.entityRow = num;
			this.entityType = (EntityType)((ulong)1L);
			return;
		}
		if (!base.TryGetComponent<Mower>(num))
		{
			if (base.TryGetComponent<GridItem>(num))
			{
				this.gridItem = num;
				GameObject gameObject3 = base.gameObject;
				this.land = gameObject3;
				this.entityRow = num;
				this.entityType = (EntityType)((ulong)4L);
			}
			return;
		}
		this.mower = num;
		GameObject gameObject4 = base.transform.Find("Shadow").gameObject;
		this.land = gameObject4;
		this.entityRow = num;
		Transform transform = base.transform;
		int num2 = 0;
		int num3 = 0;
		transform.Translate((float)num3, -1.45f, (float)num2);
		this.entityType = (EntityType)((ulong)3L);
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000CF4F4 File Offset: 0x000CD6F4
	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x6084E0", Offset = "0x606AE0", VA = "0x1806084E0")]
	private void Update()
	{
		EntityType entityType = this.entityType;
		if (entityType != EntityType.Plant)
		{
			if (entityType != EntityType.Plant)
			{
				return;
			}
		}
		else
		{
			Plant plant = this.plant;
			Mouse instance = Mouse.Instance;
			Transform axis = plant.axis;
			Plant plant2 = this.plant;
			float num;
			plant.AdjustY(num);
		}
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000CF53C File Offset: 0x000CD73C
	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RoofEntity()
	{
	}

	// Token: 0x040014A7 RID: 5287
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014A7")]
	public int entityRow;

	// Token: 0x040014A8 RID: 5288
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40014A8")]
	public EntityType entityType;

	// Token: 0x040014A9 RID: 5289
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A9")]
	private Plant plant;

	// Token: 0x040014AA RID: 5290
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014AA")]
	private Zombie zombie;

	// Token: 0x040014AB RID: 5291
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014AB")]
	private Mower mower;

	// Token: 0x040014AC RID: 5292
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014AC")]
	private GridItem gridItem;

	// Token: 0x040014AD RID: 5293
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014AD")]
	private GameObject land;
}
