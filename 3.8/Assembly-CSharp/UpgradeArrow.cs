using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[Token(Token = "0x20000F0")]
public class UpgradeArrow : MonoBehaviour, IClickable
{
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000481 RID: 1153 RVA: 0x000179C0 File Offset: 0x00015BC0
	[Token(Token = "0x17000058")]
	public int Priority
	{
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
		get
		{
			return 1;
		}
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x000179D0 File Offset: 0x00015BD0
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x5B6D20", Offset = "0x5B5320", VA = "0x1805B6D20")]
	private void Update()
	{
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		this.timer = unscaledDeltaTime;
		if (unscaledDeltaTime > 3f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00017A00 File Offset: 0x00015C00
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x5B68E0", Offset = "0x5B4EE0", VA = "0x1805B68E0", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		TowerUpgradeMenu instance = TowerUpgradeMenu.Instance;
		int num = 0;
		if (!(instance != num))
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num2 = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)43), canvasUp, num2 != 0);
			TowerPlant towerPlant = this.plant;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		CursorChange.SetDefaultCursor();
		return true;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00017A64 File Offset: 0x00015C64
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x5B6AA0", Offset = "0x5B50A0", VA = "0x1805B6AA0")]
	public static void SetArrow(TowerPlant plant)
	{
		GameObject gameObject = Resources.Load<GameObject>("Items/UpgradeArrow");
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		UpgradeArrow component = gameObject2.GetComponent<UpgradeArrow>();
		Transform transform = component.transform;
		Transform transform2 = plant.transform;
		transform.parentInternal = transform2;
		component.plant = plant;
		Transform transform3 = component.transform;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00017AD8 File Offset: 0x00015CD8
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x525520", Offset = "0x523B20", VA = "0x180525520")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00017AEC File Offset: 0x00015CEC
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00017B00 File Offset: 0x00015D00
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UpgradeArrow()
	{
	}

	// Token: 0x040002A7 RID: 679
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A7")]
	public TowerPlant plant;

	// Token: 0x040002A8 RID: 680
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A8")]
	public SpriteRenderer back;

	// Token: 0x040002A9 RID: 681
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002A9")]
	private float timer;
}
