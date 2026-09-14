using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002A4 RID: 676
[Token(Token = "0x20002A4")]
public class Apple : Plant
{
	// Token: 0x06000BE9 RID: 3049 RVA: 0x000444E4 File Offset: 0x000426E4
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x3CBF80", Offset = "0x3CA580", VA = "0x1803CBF80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
		SpriteRenderer spriteRenderer = this.shield;
		bool flag = spriteRenderers.Remove(spriteRenderer);
		this.shield.gameObject.SetActive(true);
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00044524 File Offset: 0x00042724
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x3CBB60", Offset = "0x3CA160", VA = "0x1803CBB60", Slot = "11")]
	protected override void GetSpriteRenderers()
	{
		int num;
		do
		{
			num = 0;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
			Material material = GameMaterial.GetMaterial(MaterialType.Default);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				string text;
				if (!(text != "Shadow"))
				{
					continue;
				}
				SpriteRenderer spriteRenderer = this.shield;
				if (!(num != spriteRenderer))
				{
					continue;
				}
				List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
				num.SetBrightness(1f);
			}
		}
		while (num != 0);
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x000445A4 File Offset: 0x000427A4
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x3CBA80", Offset = "0x3CA080", VA = "0x1803CBA80", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		bool active = base.Active;
		int num = 0;
		if (active && !active)
		{
			base.UpdateText();
		}
		SpriteRenderer spriteRenderer = this.shield;
		float num2;
		if (num > (int)num2 || num2 > 1f)
		{
		}
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x000445EC File Offset: 0x000427EC
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x3CBE30", Offset = "0x3CA430", VA = "0x1803CBE30", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		base.AttributeCountdown = 1f;
		this.attributeCount = (int)((ulong)0L);
		base.AttributeCountdown = 5f;
		base.UpdateText();
		return false;
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00044624 File Offset: 0x00042824
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x3CBEB0", Offset = "0x3CA4B0", VA = "0x1803CBEB0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00044644 File Offset: 0x00042844
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Apple()
	{
	}

	// Token: 0x040007DF RID: 2015
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40007DF")]
	public SpriteRenderer shield;
}
