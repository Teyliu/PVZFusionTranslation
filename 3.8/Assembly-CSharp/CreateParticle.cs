using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200020B RID: 523
[Token(Token = "0x200020B")]
public class CreateParticle : MonoBehaviour
{
	// Token: 0x060008DA RID: 2266 RVA: 0x0002E290 File Offset: 0x0002C490
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x859FF0", Offset = "0x8585F0", VA = "0x180859FF0")]
	public static GameObject SetParticle(int theParticleType, Vector3 position, int row, bool setLayer = true)
	{
		GameObject gameObject = GameAPP.particlePrefab[theParticleType];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		float z = position.z;
		GameObject gameObject2;
		if (setLayer)
		{
			CreateParticle.SetLayer(gameObject2, row);
		}
		return gameObject2;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x859C90", Offset = "0x858290", VA = "0x180859C90")]
	private static void SetLayer(GameObject obj, int row)
	{
		for (;;)
		{
			int num = 0;
			bool flag = obj.TryGetComponent<SpriteRenderer>(num);
			if (flag)
			{
				goto IL_0026;
			}
			bool flag2 = obj.TryGetComponent<ParticleSystemRenderer>(num);
			if (flag2)
			{
				string text = string.Format("particle{0}", flag2);
				goto IL_0026;
			}
			IL_0033:
			if (obj.transform.childCount <= 0)
			{
				break;
			}
			GameObject gameObject;
			if (obj.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				CreateParticle.SetLayer(gameObject, row);
			}
			if (gameObject != 0)
			{
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_0026:
			string text2 = string.Format("particle{0}", flag);
			goto IL_0033;
		}
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0002E374 File Offset: 0x0002C574
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CreateParticle()
	{
	}
}
