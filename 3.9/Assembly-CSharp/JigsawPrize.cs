using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x020007A4 RID: 1956
[Token(Token = "0x20007A4")]
public class JigsawPrize : GardenPrize
{
	// Token: 0x060027AC RID: 10156 RVA: 0x000D2528 File Offset: 0x000D0728
	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x646E10", Offset = "0x645410", VA = "0x180646E10", Slot = "6")]
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
		GameObject gameObject2;
		global::UnityEngine.Object.Destroy(gameObject2, 3f);
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x000D2628 File Offset: 0x000D0828
	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public JigsawPrize()
	{
	}
}
