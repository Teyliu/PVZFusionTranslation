using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E8 RID: 1512
[Token(Token = "0x20005E8")]
public class ScreenShake : MonoBehaviour
{
	// Token: 0x06001C7D RID: 7293 RVA: 0x00098388 File Offset: 0x00096588
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x509AD0", Offset = "0x5080D0", VA = "0x180509AD0")]
	private void Start()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x000983AC File Offset: 0x000965AC
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x509C70", Offset = "0x508270", VA = "0x180509C70")]
	private void Update()
	{
		if (!ScreenShake.CheckShake())
		{
			Transform transform = base.transform;
			return;
		}
		int num = 0;
		if (ScreenShake.shakeDuration <= (float)num)
		{
		}
		Transform transform2 = base.transform;
		Vector3 insideUnitSphere = global::UnityEngine.Random.insideUnitSphere;
		float num2 = ScreenShake.shakeMagnitude * insideUnitSphere.z;
		float num3 = ScreenShake.shakeDuration;
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		ScreenShake.shakeDuration = num3;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00098414 File Offset: 0x00096614
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x5099C0", Offset = "0x507FC0", VA = "0x1805099C0")]
	private static bool CheckShake()
	{
		if (!GameAPP.config.distablexplodeFlash)
		{
			Board instance = Board.Instance;
			int num = 0;
			if (instance != num)
			{
			}
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x0009844C File Offset: 0x0009664C
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x509B60", Offset = "0x508160", VA = "0x180509B60")]
	public static void TriggerShake(float duration = 0.15f)
	{
		if (ScreenShake.CheckShake())
		{
			ScreenShake.shakeDuration = duration;
			Transform transform = Camera.main.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x00098488 File Offset: 0x00096688
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ScreenShake()
	{
	}

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000F34")]
	private static Vector3 originalPosition;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000F35")]
	private static float shakeDuration;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000F36")]
	private static readonly float shakeMagnitude;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000F37")]
	private static bool isShaking;
}
