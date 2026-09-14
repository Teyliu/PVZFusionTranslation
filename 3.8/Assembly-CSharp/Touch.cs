using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009E7 RID: 2535
[Token(Token = "0x20009E7")]
public class Touch : MonoBehaviour
{
	// Token: 0x0600340C RID: 13324 RVA: 0x00115B24 File Offset: 0x00113D24
	[Token(Token = "0x600340C")]
	[Address(RVA = "0x71ED60", Offset = "0x71D360", VA = "0x18071ED60")]
	public static void CheckTouchUp()
	{
		global::UnityEngine.Touch touch;
		float y = touch.m_RawPosition.y;
		TouchPhase touchPhase;
		if (touchPhase == TouchPhase.Began)
		{
			Camera main = Camera.main;
			RaycastHit2D raycastHit2D;
			Vector2 normal = raycastHit2D.m_Normal;
			int collider = raycastHit2D.m_Collider;
			int num = 0;
			Collider2D collider2D;
			if (collider2D != num)
			{
				Collider2D collider2D2;
				MonoBehaviour component = collider2D2.GetComponent<MonoBehaviour>();
				int num2 = 0;
				bool flag = component != num2;
				MethodInfo method = component.GetType().GetMethod("OnMouseUp");
				int num3 = 0;
				if (method != num3)
				{
					Collider2D collider2D3;
					collider2D3.SendMessage("OnMouseUp");
				}
			}
		}
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00115BC0 File Offset: 0x00113DC0
	[Token(Token = "0x600340D")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Touch()
	{
	}
}
