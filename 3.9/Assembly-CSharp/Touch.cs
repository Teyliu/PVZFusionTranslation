using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A23 RID: 2595
[Token(Token = "0x2000A23")]
public class Touch : MonoBehaviour
{
	// Token: 0x06003540 RID: 13632 RVA: 0x0011AA7C File Offset: 0x00118C7C
	[Token(Token = "0x6003540")]
	[Address(RVA = "0x7842E0", Offset = "0x7828E0", VA = "0x1807842E0")]
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

	// Token: 0x06003541 RID: 13633 RVA: 0x0011AB18 File Offset: 0x00118D18
	[Token(Token = "0x6003541")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Touch()
	{
	}
}
