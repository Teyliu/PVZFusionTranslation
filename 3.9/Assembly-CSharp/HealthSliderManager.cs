using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
public class HealthSliderManager : MonoBehaviour
{
	// Token: 0x06000B3A RID: 2874 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x931860", Offset = "0x92FE60", VA = "0x180931860")]
	private void Awake()
	{
		HealthSliderManager.Instance = this;
		if (!GameAPP.config.enableBossHealthSlider)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0003FEE8 File Offset: 0x0003E0E8
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x931940", Offset = "0x92FF40", VA = "0x180931940")]
	private void Update()
	{
		int num;
		do
		{
			num = 0;
			List<BoardHealthSlider> list = this.sliders;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				float deltaTime = Time.deltaTime;
				if (num2 > (int)deltaTime || deltaTime > 1f)
				{
				}
				GameObject gameObject;
				if (!gameObject.activeSelf)
				{
					continue;
				}
				num++;
			}
		}
		while (num != 0);
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0003FF58 File Offset: 0x0003E158
	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x931C30", Offset = "0x930230", VA = "0x180931C30")]
	public HealthSliderManager()
	{
		List<BoardHealthSlider> list = new List();
		this.sliders = list;
		base..ctor();
	}

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	public static HealthSliderManager Instance;

	// Token: 0x04000743 RID: 1859
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000743")]
	public List<BoardHealthSlider> sliders;

	// Token: 0x04000744 RID: 1860
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000744")]
	public RectTransform content;
}
