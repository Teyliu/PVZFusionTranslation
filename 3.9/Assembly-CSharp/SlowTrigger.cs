using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008DE RID: 2270
[Token(Token = "0x20008DE")]
public class SlowTrigger : UIButton
{
	// Token: 0x06002E37 RID: 11831 RVA: 0x000FCD18 File Offset: 0x000FAF18
	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x6FE1C0", Offset = "0x6FC7C0", VA = "0x1806FE1C0")]
	private void Awake()
	{
		this.maskValue.transform.parent.gameObject.SetActive(true);
		RectTransform rectTransform = this.maskValue;
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Animator component2 = base.GetComponent<Animator>();
		this.anim = component2;
		throw new NullReferenceException();
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x000FCD6C File Offset: 0x000FAF6C
	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x6FE3B0", Offset = "0x6FC9B0", VA = "0x1806FE3B0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002E39 RID: 11833 RVA: 0x000FCDA8 File Offset: 0x000FAFA8
	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x6FE390", Offset = "0x6FC990", VA = "0x1806FE390", Slot = "8")]
	protected override void OnMouseDown()
	{
		base.OnMouseDown();
		this.clicked = true;
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x000FCDC4 File Offset: 0x000FAFC4
	[Token(Token = "0x6002E3A")]
	[Address(RVA = "0x6FE4B0", Offset = "0x6FCAB0", VA = "0x1806FE4B0", Slot = "7")]
	protected override void OnMouseUp()
	{
		int num = 0;
		base.OnMouseUp();
		this.clicked = false;
		this.clickedTimer = 0f;
		if (!this.follow)
		{
			this.maskValue.anchoredPosition = num;
			return;
		}
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x000FCE08 File Offset: 0x000FB008
	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x6FE510", Offset = "0x6FCB10", VA = "0x1806FE510")]
	private void TriggerSlow()
	{
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x000FCE40 File Offset: 0x000FB040
	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x6FDE30", Offset = "0x6FC430", VA = "0x1806FDE30")]
	private void AnimHit()
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Vector3 vector2;
				float z2 = vector2.z;
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
				float num3 = this.maxCoolTime;
				this.coolTimer = num3;
			}
			num++;
		}
		this.maskValue.anchoredPosition = num;
		Transform transform2 = base.transform;
		ulong num4;
		this.col.enabled = num4 != 0UL;
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x000FCEE0 File Offset: 0x000FB0E0
	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x6FE5A0", Offset = "0x6FCBA0", VA = "0x1806FE5A0")]
	private void Update()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.SlowTrigger))
		{
			float timeScale = Time.timeScale;
			Time.timeScale = GameAPP.config.gameSpeed;
			return;
		}
	}

	// Token: 0x06002E3E RID: 11838 RVA: 0x000FCF24 File Offset: 0x000FB124
	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x6FE2C0", Offset = "0x6FC8C0", VA = "0x1806FE2C0")]
	private void Clicking()
	{
		float deltaTime = Time.deltaTime;
		RectTransform rectTransform = this.maskValue;
		int num = 0;
		this.clickedTimer = deltaTime;
		float num2 = deltaTime * 5f;
		if (num > (int)num2 || num2 > 1f)
		{
		}
		if (this.clickedTimer > 0.2f)
		{
			Collider2D collider2D = this.col;
			this.follow = true;
			int num3 = 0;
			collider2D.enabled = num3 != 0;
			CursorChange.SetDefaultCursor();
		}
	}

	// Token: 0x06002E3F RID: 11839 RVA: 0x000FCF9C File Offset: 0x000FB19C
	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x6FE6D0", Offset = "0x6FCCD0", VA = "0x1806FE6D0")]
	public SlowTrigger()
	{
	}

	// Token: 0x04001C12 RID: 7186
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001C12")]
	public bool clicked;

	// Token: 0x04001C13 RID: 7187
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4001C13")]
	public bool follow;

	// Token: 0x04001C14 RID: 7188
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4001C14")]
	public float clickedTimer;

	// Token: 0x04001C15 RID: 7189
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001C15")]
	public float coolTimer;

	// Token: 0x04001C16 RID: 7190
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001C16")]
	public RectTransform maskValue;

	// Token: 0x04001C17 RID: 7191
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001C17")]
	private readonly float maxCoolTime = 2.5f;

	// Token: 0x04001C18 RID: 7192
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001C18")]
	private Collider2D col;

	// Token: 0x04001C19 RID: 7193
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001C19")]
	private Animator anim;
}
