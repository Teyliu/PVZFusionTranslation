using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200076B RID: 1899
[Token(Token = "0x200076B")]
public class JigsawPrize : GardenPrize
{
	// Token: 0x0600267D RID: 9853 RVA: 0x000CD4B0 File Offset: 0x000CB6B0
	[Token(Token = "0x600267D")]
	[Address(RVA = "0x5E3AE0", Offset = "0x5E20E0", VA = "0x1805E3AE0", Slot = "6")]
	public override void Active()
	{
		ulong num5;
		do
		{
			int num = 0;
			Transform transform = base.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			base.transform.GetChild(1).gameObject.SetActive(true);
			GameAPP.PlaySound(66, 0.5f, 1f);
			global::UnityEngine.Object.Destroy(base.GetComponent<Collider2D>());
			int num4 = 0;
			if (!(JigsawManager.Instance == num4))
			{
				JigsawManager.Instance.enabled = true;
			}
			JigsawManager jigsawManager = Board.Instance.gameObject.AddComponent<JigsawManager>();
			Time.timeScale = (float)0;
			JigsawManager.Instance.showJig = false;
			JigsawManager.Instance.SwitchJigs();
			JigsawManager.Instance.GetRandomShape();
			List<BaseMenu> list = GameAPP.UIManager.Peak();
			bool flag;
			if (flag)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num5 != (ulong)0L);
		InGameText instance = InGameText.Instance;
		int num6 = 0;
		instance.ShowText("你获得了一块拼图！左键放下拼图\n紫色：增伤 绿色：减伤 淡蓝色：增加射速\n红色：治疗加成 黄色：3x3替伤 灰色：防压", 7f, num6 != 0);
		GameObject gameObject2;
		global::UnityEngine.Object.Destroy(gameObject2, 3f);
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x000CD5C8 File Offset: 0x000CB7C8
	[Token(Token = "0x600267E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public JigsawPrize()
	{
	}
}
