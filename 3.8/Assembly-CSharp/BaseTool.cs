using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200074B RID: 1867
[Token(Token = "0x200074B")]
public class BaseTool : MonoBehaviour
{
	// Token: 0x060025EE RID: 9710 RVA: 0x000C92A8 File Offset: 0x000C74A8
	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x5BC760", Offset = "0x5BAD60", VA = "0x1805BC760")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Transform transform = base.transform.parent;
		this.parent = transform;
		throw new NullReferenceException();
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x000C92DC File Offset: 0x000C74DC
	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x5BC950", Offset = "0x5BAF50", VA = "0x1805BC950", Slot = "4")]
	protected virtual void Update()
	{
		Garden instance = Garden.Instance;
		if (instance.free && instance.ui.Interactable)
		{
			if ((!Input.GetKeyDownInt((KeyCode)((uint)49)) || this.toolType != ToolType.WaterCan) && (!Input.GetKeyDownInt((KeyCode)((uint)50)) || this.toolType != ToolType.Fertilize) && (!Input.GetKeyDownInt((KeyCode)((uint)51)) || this.toolType != ToolType.BugSpray) && (!Input.GetKeyDownInt((KeyCode)((uint)52)) || this.toolType != ToolType.Phonograph) && (!Input.GetKeyDownInt((KeyCode)((uint)53)) || this.toolType != ToolType.Glove))
			{
				if (!Input.GetKeyDownInt((KeyCode)((uint)113)))
				{
					return;
				}
				int num = 0;
				BigGardenPlant bigGardenPlant;
				if (!(bigGardenPlant != num) || bigGardenPlant.satisfied)
				{
					return;
				}
				ToolType toolType = this.toolType;
				if (bigGardenPlant.needTool != toolType)
				{
					return;
				}
			}
			this.Take();
			instance.toolOnMouse = this;
			instance.free = false;
			GameAPP.PlaySound(19, 0.5f, 1f);
		}
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x000C93D4 File Offset: 0x000C75D4
	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x5BD1B0", Offset = "0x5BB7B0", VA = "0x1805BD1B0")]
	public void Use(GardenEquipment equipment)
	{
		if (this.toolType == ToolType.Glove)
		{
			Garden garden = equipment.garden;
			garden.equipmentOnMouse = equipment;
			garden.free = false;
			EquipmentData data = equipment.data;
			int level = data.level;
			EquipmentType theEquipmentType = data.theEquipmentType;
			garden.SetPreview(theEquipmentType, level);
			GameAPP.PlaySound(25, 0.5f, 1f);
		}
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x000C9434 File Offset: 0x000C7634
	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x5BCB30", Offset = "0x5BB130", VA = "0x1805BCB30")]
	public void Use(BigGardenPlant plant)
	{
		BigGardenPlant plant2 = plant;
		ToolType toolType = this.toolType;
		int num = 0;
		Garden garden;
		if (toolType != ToolType.WaterCan)
		{
			if (toolType != ToolType.WaterCan)
			{
				if (toolType != ToolType.WaterCan)
				{
					if (toolType != ToolType.WaterCan)
					{
						if (toolType != ToolType.Fertilize)
						{
							goto IL_0189;
						}
						BigGardenPlant plant3 = plant;
						garden.plantOnMouse = plant3;
						garden.free = num != 0;
						BigGardenPlant plant4 = plant;
						uint num2;
						GameAPP.PlaySound((int)num2, 0.5f, 1f);
					}
					Dictionary<GardenToolType, AnimTool> toolAnimPrefabs = GameAPP.resourcesManager.ToolAnimPrefabs;
					Transform transform = garden.transform;
					AnimTool animTool2;
					AnimTool animTool = global::UnityEngine.Object.Instantiate<AnimTool>(animTool2, transform);
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, 1f);
					Transform transform2 = animTool.transform;
					Transform transform3 = plant.transform;
					Vector3 vector;
					float z = vector.z;
				}
				Dictionary<GardenToolType, AnimTool> toolAnimPrefabs2 = GameAPP.resourcesManager.ToolAnimPrefabs;
				Transform transform4 = garden.transform;
				AnimTool animTool4;
				AnimTool animTool3 = global::UnityEngine.Object.Instantiate<AnimTool>(animTool4, transform4);
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
				Transform transform5 = animTool3.transform;
				Transform transform6 = plant.transform;
			}
			Dictionary<GardenToolType, AnimTool> toolAnimPrefabs3 = GameAPP.resourcesManager.ToolAnimPrefabs;
			Transform transform7 = garden.transform;
			AnimTool animTool6;
			AnimTool animTool5 = global::UnityEngine.Object.Instantiate<AnimTool>(animTool6, transform7);
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			Transform transform8 = animTool5.transform;
			Transform transform9 = plant.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
		Dictionary<GardenToolType, AnimTool> toolAnimPrefabs4 = GameAPP.resourcesManager.ToolAnimPrefabs;
		Transform transform10 = garden.transform;
		AnimTool animTool8;
		AnimTool animTool7 = global::UnityEngine.Object.Instantiate<AnimTool>(animTool8, transform10);
		Transform transform11 = animTool7.transform;
		IL_0189:
		int num6 = 0;
		if (animTool7 != num6)
		{
			Action action = delegate
			{
				BigGardenPlant plant5 = plant;
				int num7 = 0;
				if (plant5 != num7)
				{
					BaseTool <>4__this = this;
					BigGardenPlant plant6 = plant;
					ToolType toolType2 = <>4__this.toolType;
					plant6.Cultivated(toolType2);
				}
			};
			animTool7.action = action;
		}
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x000C95F8 File Offset: 0x000C77F8
	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x5BC8C0", Offset = "0x5BAEC0", VA = "0x1805BC8C0")]
	public void Take()
	{
		Collider2D collider2D = this.col;
		this.take = true;
		int num = 0;
		collider2D.enabled = num != 0;
		Transform transform = base.transform;
		Transform transform2 = Garden.Instance.ui.transform;
		transform.parentInternal = transform2;
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x000C9640 File Offset: 0x000C7840
	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x5BC7E0", Offset = "0x5BADE0", VA = "0x1805BC7E0")]
	public void PutDown()
	{
		Collider2D collider2D = this.col;
		this.take = false;
		collider2D.enabled = true;
		Transform transform = base.transform;
		Transform transform2 = this.parent;
		transform.parentInternal = transform2;
		Transform transform3 = base.transform;
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x000C9688 File Offset: 0x000C7888
	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BaseTool()
	{
	}

	// Token: 0x04001389 RID: 5001
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001389")]
	public ToolType toolType;

	// Token: 0x0400138A RID: 5002
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400138A")]
	public bool take;

	// Token: 0x0400138B RID: 5003
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400138B")]
	private Collider2D col;

	// Token: 0x0400138C RID: 5004
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400138C")]
	private Transform parent;
}
