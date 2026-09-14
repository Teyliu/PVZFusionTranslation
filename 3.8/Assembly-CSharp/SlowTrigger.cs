using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008A2 RID: 2210
[Token(Token = "0x20008A2")]
public class SlowTrigger : UIButton
{
	// Token: 0x06002D04 RID: 11524 RVA: 0x000F8180 File Offset: 0x000F6380
	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x684C00", Offset = "0x683200", VA = "0x180684C00")]
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

	// Token: 0x06002D05 RID: 11525 RVA: 0x000F81D4 File Offset: 0x000F63D4
	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x684DF0", Offset = "0x6833F0", VA = "0x180684DF0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002D06 RID: 11526 RVA: 0x000F8210 File Offset: 0x000F6410
	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x684DD0", Offset = "0x6833D0", VA = "0x180684DD0", Slot = "8")]
	protected override void OnMouseDown()
	{
		base.OnMouseDown();
		this.clicked = true;
	}

	// Token: 0x06002D07 RID: 11527 RVA: 0x000F822C File Offset: 0x000F642C
	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x684EF0", Offset = "0x6834F0", VA = "0x180684EF0", Slot = "7")]
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

	// Token: 0x06002D08 RID: 11528 RVA: 0x000F8270 File Offset: 0x000F6470
	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x684F50", Offset = "0x683550", VA = "0x180684F50")]
	private void TriggerSlow()
	{
		float timeScale = Time.timeScale;
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002D09 RID: 11529 RVA: 0x000F82A8 File Offset: 0x000F64A8
	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x684870", Offset = "0x682E70", VA = "0x180684870")]
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

	// Token: 0x06002D0A RID: 11530 RVA: 0x000F8348 File Offset: 0x000F6548
	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x684FE0", Offset = "0x6835E0", VA = "0x180684FE0")]
	private void Update()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.SlowTrigger))
		{
			float timeScale = Time.timeScale;
			Time.timeScale = GameAPP.config.gameSpeed;
			return;
		}
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x000F838C File Offset: 0x000F658C
	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x684D00", Offset = "0x683300", VA = "0x180684D00")]
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

	// Token: 0x06002D0C RID: 11532 RVA: 0x000F8404 File Offset: 0x000F6604
	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x685110", Offset = "0x683710", VA = "0x180685110")]
	public SlowTrigger()
	{
	}

	// Token: 0x04001B22 RID: 6946
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001B22")]
	public bool clicked;

	// Token: 0x04001B23 RID: 6947
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4001B23")]
	public bool follow;

	// Token: 0x04001B24 RID: 6948
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4001B24")]
	public float clickedTimer;

	// Token: 0x04001B25 RID: 6949
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001B25")]
	public float coolTimer;

	// Token: 0x04001B26 RID: 6950
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001B26")]
	public RectTransform maskValue;

	// Token: 0x04001B27 RID: 6951
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001B27")]
	private readonly float maxCoolTime = 2.5f;

	// Token: 0x04001B28 RID: 6952
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001B28")]
	private Collider2D col;

	// Token: 0x04001B29 RID: 6953
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001B29")]
	private Animator anim;
}
