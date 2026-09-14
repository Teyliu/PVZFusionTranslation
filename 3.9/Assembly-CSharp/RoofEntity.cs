using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007BB RID: 1979
[Token(Token = "0x20007BB")]
public class RoofEntity : MonoBehaviour
{
	// Token: 0x060027FE RID: 10238 RVA: 0x000D4400 File Offset: 0x000D2600
	[Token(Token = "0x60027FE")]
	[Address(RVA = "0x66BA60", Offset = "0x66A060", VA = "0x18066BA60")]
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

	// Token: 0x060027FF RID: 10239 RVA: 0x000D4520 File Offset: 0x000D2720
	[Token(Token = "0x60027FF")]
	[Address(RVA = "0x66BD30", Offset = "0x66A330", VA = "0x18066BD30")]
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

	// Token: 0x06002800 RID: 10240 RVA: 0x000D4568 File Offset: 0x000D2768
	[Token(Token = "0x6002800")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RoofEntity()
	{
	}

	// Token: 0x04001583 RID: 5507
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001583")]
	public int entityRow;

	// Token: 0x04001584 RID: 5508
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001584")]
	public EntityType entityType;

	// Token: 0x04001585 RID: 5509
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001585")]
	private Plant plant;

	// Token: 0x04001586 RID: 5510
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001586")]
	private Zombie zombie;

	// Token: 0x04001587 RID: 5511
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001587")]
	private Mower mower;

	// Token: 0x04001588 RID: 5512
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001588")]
	private GridItem gridItem;

	// Token: 0x04001589 RID: 5513
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001589")]
	private GameObject land;
}
