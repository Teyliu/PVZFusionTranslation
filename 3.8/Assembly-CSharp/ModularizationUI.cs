using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020009B3 RID: 2483
[Token(Token = "0x20009B3")]
public class ModularizationUI : MonoBehaviour
{
	// Token: 0x060032DC RID: 13020 RVA: 0x0010E6B0 File Offset: 0x0010C8B0
	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x7060D0", Offset = "0x7046D0", VA = "0x1807060D0")]
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

	// Token: 0x060032DD RID: 13021 RVA: 0x0010E76C File Offset: 0x0010C96C
	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x705ED0", Offset = "0x7044D0", VA = "0x180705ED0")]
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

	// Token: 0x060032DE RID: 13022 RVA: 0x0010E7BC File Offset: 0x0010C9BC
	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x705FD0", Offset = "0x7045D0", VA = "0x180705FD0")]
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

	// Token: 0x060032DF RID: 13023 RVA: 0x0010E80C File Offset: 0x0010CA0C
	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ModularizationUI()
	{
	}

	// Token: 0x04002487 RID: 9351
	[Token(Token = "0x4002487")]
	private const string Path = "UI/Modularization/";

	// Token: 0x04002488 RID: 9352
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002488")]
	public BaseMenu buildingMenu;
}
