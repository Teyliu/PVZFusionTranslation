using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000784 RID: 1924
[Token(Token = "0x2000784")]
public class BaseTool : MonoBehaviour
{
	// Token: 0x06002715 RID: 10005 RVA: 0x000CE2CC File Offset: 0x000CC4CC
	[Token(Token = "0x6002715")]
	[Address(RVA = "0x61E730", Offset = "0x61CD30", VA = "0x18061E730")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Transform transform = base.transform.parent;
		this.parent = transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x000CE300 File Offset: 0x000CC500
	[Token(Token = "0x6002716")]
	[Address(RVA = "0x61E920", Offset = "0x61CF20", VA = "0x18061E920", Slot = "4")]
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

	// Token: 0x06002717 RID: 10007 RVA: 0x000CE3F8 File Offset: 0x000CC5F8
	[Token(Token = "0x6002717")]
	[Address(RVA = "0x61F180", Offset = "0x61D780", VA = "0x18061F180")]
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

	// Token: 0x06002718 RID: 10008 RVA: 0x000CE458 File Offset: 0x000CC658
	[Token(Token = "0x6002718")]
	[Address(RVA = "0x61EB00", Offset = "0x61D100", VA = "0x18061EB00")]
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

	// Token: 0x06002719 RID: 10009 RVA: 0x000CE61C File Offset: 0x000CC81C
	[Token(Token = "0x6002719")]
	[Address(RVA = "0x61E890", Offset = "0x61CE90", VA = "0x18061E890")]
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

	// Token: 0x0600271A RID: 10010 RVA: 0x000CE664 File Offset: 0x000CC864
	[Token(Token = "0x600271A")]
	[Address(RVA = "0x61E7B0", Offset = "0x61CDB0", VA = "0x18061E7B0")]
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

	// Token: 0x0600271B RID: 10011 RVA: 0x000CE6AC File Offset: 0x000CC8AC
	[Token(Token = "0x600271B")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BaseTool()
	{
	}

	// Token: 0x04001461 RID: 5217
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001461")]
	public ToolType toolType;

	// Token: 0x04001462 RID: 5218
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001462")]
	public bool take;

	// Token: 0x04001463 RID: 5219
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001463")]
	private Collider2D col;

	// Token: 0x04001464 RID: 5220
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001464")]
	private Transform parent;
}
