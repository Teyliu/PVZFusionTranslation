using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000212 RID: 530
[Token(Token = "0x2000212")]
public class CreateParticle : MonoBehaviour
{
	// Token: 0x060008F4 RID: 2292 RVA: 0x0002E2A0 File Offset: 0x0002C4A0
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x8E8CD0", Offset = "0x8E72D0", VA = "0x1808E8CD0")]
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

	// Token: 0x060008F5 RID: 2293 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x8E8970", Offset = "0x8E6F70", VA = "0x1808E8970")]
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

	// Token: 0x060008F6 RID: 2294 RVA: 0x0002E384 File Offset: 0x0002C584
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CreateParticle()
	{
	}
}
