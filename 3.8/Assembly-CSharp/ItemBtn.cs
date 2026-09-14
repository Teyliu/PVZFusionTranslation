using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000769 RID: 1897
[Token(Token = "0x2000769")]
public class ItemBtn : MonoBehaviour
{
	// Token: 0x0600267A RID: 9850 RVA: 0x000CD390 File Offset: 0x000CB590
	[Token(Token = "0x600267A")]
	[Address(RVA = "0x5E3350", Offset = "0x5E1950", VA = "0x1805E3350")]
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

	// Token: 0x0600267B RID: 9851 RVA: 0x000CD3F8 File Offset: 0x000CB5F8
	[Token(Token = "0x600267B")]
	[Address(RVA = "0x5E34E0", Offset = "0x5E1AE0", VA = "0x1805E34E0")]
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

	// Token: 0x0600267C RID: 9852 RVA: 0x000CD49C File Offset: 0x000CB69C
	[Token(Token = "0x600267C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ItemBtn()
	{
	}

	// Token: 0x04001412 RID: 5138
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001412")]
	public ItemBtn.Type type;

	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public enum Type
	{
		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		Bean
	}
}
