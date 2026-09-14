using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F5 RID: 245
[Token(Token = "0x20000F5")]
public class UpgradeArrow : MonoBehaviour, IClickable
{
	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600049C RID: 1180 RVA: 0x00017DCC File Offset: 0x00015FCC
	[Token(Token = "0x17000095")]
	public int Priority
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
		get
		{
			return 1;
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00017DDC File Offset: 0x00015FDC
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x5EC7B0", Offset = "0x5EADB0", VA = "0x1805EC7B0")]
	private void Update()
	{
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		this.timer = unscaledDeltaTime;
		if (unscaledDeltaTime > 3f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00017E0C File Offset: 0x0001600C
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x5EC370", Offset = "0x5EA970", VA = "0x1805EC370", Slot = "5")]
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

	// Token: 0x0600049F RID: 1183 RVA: 0x00017E70 File Offset: 0x00016070
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x5EC530", Offset = "0x5EAB30", VA = "0x1805EC530")]
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

	// Token: 0x060004A0 RID: 1184 RVA: 0x00017EE4 File Offset: 0x000160E4
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x5906B0", Offset = "0x58ECB0", VA = "0x1805906B0")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00017EF8 File Offset: 0x000160F8
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00017F0C File Offset: 0x0001610C
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UpgradeArrow()
	{
	}

	// Token: 0x040002B5 RID: 693
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B5")]
	public TowerPlant plant;

	// Token: 0x040002B6 RID: 694
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B6")]
	public SpriteRenderer back;

	// Token: 0x040002B7 RID: 695
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B7")]
	private float timer;
}
