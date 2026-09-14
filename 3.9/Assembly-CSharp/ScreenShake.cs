using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061D RID: 1565
[Token(Token = "0x200061D")]
public class ScreenShake : MonoBehaviour
{
	// Token: 0x06001D7C RID: 7548 RVA: 0x0009CEF0 File Offset: 0x0009B0F0
	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0x576B50", Offset = "0x575150", VA = "0x180576B50")]
	private void Start()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x0009CF14 File Offset: 0x0009B114
	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0x576CF0", Offset = "0x5752F0", VA = "0x180576CF0")]
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

	// Token: 0x06001D7E RID: 7550 RVA: 0x0009CF7C File Offset: 0x0009B17C
	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0x576A40", Offset = "0x575040", VA = "0x180576A40")]
	private static bool CheckShake()
	{
		if (!GameAPP.config.disableScreenShake)
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

	// Token: 0x06001D7F RID: 7551 RVA: 0x0009CFB4 File Offset: 0x0009B1B4
	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0x576BE0", Offset = "0x5751E0", VA = "0x180576BE0")]
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

	// Token: 0x06001D80 RID: 7552 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ScreenShake()
	{
	}

	// Token: 0x04000FFC RID: 4092
	[Token(Token = "0x4000FFC")]
	private static Vector3 originalPosition;

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000FFD")]
	private static float shakeDuration;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000FFE")]
	private static readonly float shakeMagnitude;

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000FFF")]
	private static bool isShaking;
}
