using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A2 RID: 1954
[Token(Token = "0x20007A2")]
public class ItemBtn : MonoBehaviour
{
	// Token: 0x060027A9 RID: 10153 RVA: 0x000D2408 File Offset: 0x000D0608
	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x646680", Offset = "0x644C80", VA = "0x180646680")]
	public GameObject Clicked()
	{
		Money instance = Money.Instance;
		int num = 0;
		if (!(instance != num))
		{
		}
		GameObject gameObject = GameAPP.itemPrefab[37];
		Transform transform = Board.Instance.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
		gameObject2.name = "bean";
		Mouse.Instance.mouseItemType = (MouseItemType)((ulong)8L);
		return gameObject2;
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x000D2470 File Offset: 0x000D0670
	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x646810", Offset = "0x644E10", VA = "0x180646810")]
	private void Update()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.UseGoldBean))
		{
			GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
			int num = 0;
			if (theItemOnMouse == num)
			{
				Board instance = Board.Instance;
				Mouse instance2 = Mouse.Instance;
				Money instance3 = Money.Instance;
				int num2 = 0;
				if (!(instance3 != num2))
				{
				}
				GameObject gameObject = GameAPP.itemPrefab[37];
				Transform transform = Board.Instance.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
				gameObject2.name = "bean";
				Mouse.Instance.mouseItemType = (MouseItemType)((ulong)8L);
				instance2.theItemOnMouse = gameObject2;
			}
		}
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000D2514 File Offset: 0x000D0714
	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ItemBtn()
	{
	}

	// Token: 0x040014EE RID: 5358
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014EE")]
	public ItemBtn.Type type;

	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	public enum Type
	{
		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40014F0")]
		Bean
	}
}
