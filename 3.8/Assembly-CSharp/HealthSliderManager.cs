using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200026A RID: 618
[Token(Token = "0x200026A")]
public class HealthSliderManager : MonoBehaviour
{
	// Token: 0x06000B1E RID: 2846 RVA: 0x0003FFF4 File Offset: 0x0003E1F4
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x8A18C0", Offset = "0x89FEC0", VA = "0x1808A18C0")]
	private void Awake()
	{
		HealthSliderManager.Instance = this;
		if (!GameAPP.config.enableBossHealthSlider)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00040028 File Offset: 0x0003E228
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x8A19A0", Offset = "0x89FFA0", VA = "0x1808A19A0")]
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

	// Token: 0x06000B20 RID: 2848 RVA: 0x00040098 File Offset: 0x0003E298
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x8A1C90", Offset = "0x8A0290", VA = "0x1808A1C90")]
	public HealthSliderManager()
	{
		List<BoardHealthSlider> list = new List();
		this.sliders = list;
		base..ctor();
	}

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x4000736")]
	public static HealthSliderManager Instance;

	// Token: 0x04000737 RID: 1847
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000737")]
	public List<BoardHealthSlider> sliders;

	// Token: 0x04000738 RID: 1848
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000738")]
	public RectTransform content;
}
