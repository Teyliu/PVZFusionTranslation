using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002AF RID: 687
[Token(Token = "0x20002AF")]
public class Apple : Plant
{
	// Token: 0x06000C11 RID: 3089 RVA: 0x000447D0 File Offset: 0x000429D0
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x418E00", Offset = "0x417400", VA = "0x180418E00", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
		SpriteRenderer spriteRenderer = this.shield;
		bool flag = spriteRenderers.Remove(spriteRenderer);
		this.shield.gameObject.SetActive(true);
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00044810 File Offset: 0x00042A10
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x4189E0", Offset = "0x416FE0", VA = "0x1804189E0", Slot = "11")]
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

	// Token: 0x06000C13 RID: 3091 RVA: 0x00044890 File Offset: 0x00042A90
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x418900", Offset = "0x416F00", VA = "0x180418900", Slot = "17")]
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

	// Token: 0x06000C14 RID: 3092 RVA: 0x000448D8 File Offset: 0x00042AD8
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x418CB0", Offset = "0x4172B0", VA = "0x180418CB0", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		base.AttributeCountdown = 1f;
		this.attributeCount = (int)((ulong)0L);
		base.AttributeCountdown = 5f;
		base.UpdateText();
		return false;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00044910 File Offset: 0x00042B10
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x418D30", Offset = "0x417330", VA = "0x180418D30", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00044930 File Offset: 0x00042B30
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Apple()
	{
	}

	// Token: 0x040007FD RID: 2045
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40007FD")]
	public SpriteRenderer shield;
}
