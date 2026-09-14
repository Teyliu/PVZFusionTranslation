using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020009EF RID: 2543
[Token(Token = "0x20009EF")]
public class ModularizationUI : MonoBehaviour
{
	// Token: 0x06003410 RID: 13328 RVA: 0x001136C0 File Offset: 0x001118C0
	[Token(Token = "0x6003410")]
	[Address(RVA = "0x76B5F0", Offset = "0x769BF0", VA = "0x18076B5F0")]
	[ProButton]
	public void CreateUI(string name)
	{
		BaseMenu baseMenu = this.buildingMenu;
		int num = 0;
		if (!(baseMenu != num))
		{
			GameObject gameObject = new GameObject(name);
			BaseMenu baseMenu2 = gameObject.AddComponent<BaseMenu>();
			this.buildingMenu = baseMenu2;
			Transform transform = gameObject.transform;
			Transform transform2 = GameObject.Find("CanvasUp").transform;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject.transform;
			Transform transform4 = gameObject.transform;
			GameObject gameObject2 = Resources.Load<GameObject>("UI/Modularization/MenuBackground");
			Transform transform5 = gameObject.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform5).name = "Background";
			ModularizationUI modularizationUI = this.buildingMenu.AddComponent<ModularizationUI>();
			BaseMenu baseMenu3 = this.buildingMenu;
			modularizationUI.buildingMenu = baseMenu3;
			global::UnityEngine.Object.DestroyImmediate(this);
		}
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x0011377C File Offset: 0x0011197C
	[Token(Token = "0x6003411")]
	[Address(RVA = "0x76B3F0", Offset = "0x7699F0", VA = "0x18076B3F0")]
	[ProButton]
	public void CreateButton()
	{
		BaseMenu baseMenu = this.buildingMenu;
		int num = 0;
		if (!(baseMenu == num))
		{
			GameObject gameObject = Resources.Load<GameObject>("UI/Modularization/MenuUIButton");
			Transform transform = this.buildingMenu.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).name = "Button";
		}
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x001137CC File Offset: 0x001119CC
	[Token(Token = "0x6003412")]
	[Address(RVA = "0x76B4F0", Offset = "0x769AF0", VA = "0x18076B4F0")]
	[ProButton]
	public void CreateEnter()
	{
		BaseMenu baseMenu = this.buildingMenu;
		int num = 0;
		if (!(baseMenu == num))
		{
			GameObject gameObject = Resources.Load<GameObject>("UI/Modularization/MenuEnterGame");
			Transform transform = this.buildingMenu.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).name = "Window";
		}
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x0011381C File Offset: 0x00111A1C
	[Token(Token = "0x6003413")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ModularizationUI()
	{
	}

	// Token: 0x04002599 RID: 9625
	[Token(Token = "0x4002599")]
	private const string Path = "UI/Modularization/";

	// Token: 0x0400259A RID: 9626
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400259A")]
	public BaseMenu buildingMenu;
}
