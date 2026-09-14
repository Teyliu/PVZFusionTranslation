using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000888 RID: 2184
[Token(Token = "0x2000888")]
public class InGameTool : MonoBehaviour, IClickable
{
	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000F26F0 File Offset: 0x000F08F0
	[Token(Token = "0x170001FF")]
	public int Priority
	{
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "4")]
		get
		{
			return 3;
		}
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x000F2700 File Offset: 0x000F0900
	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0x6CB9F0", Offset = "0x6C9FF0", VA = "0x1806CB9F0", Slot = "6")]
	protected virtual void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
		Mouse instance2 = Mouse.Instance;
		this.mouse = instance2;
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		float num = this.fullCD;
		this.CD = num;
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x000F2744 File Offset: 0x000F0944
	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0x6CB880", Offset = "0x6C9E80", VA = "0x1806CB880")]
	private void OnMouseEnter()
	{
		GameObject theItemOnMouse = this.mouse.theItemOnMouse;
		int num = 0;
		if (theItemOnMouse == num)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x000F2778 File Offset: 0x000F0978
	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x000F278C File Offset: 0x000F098C
	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0x6CBAA0", Offset = "0x6CA0A0", VA = "0x1806CBAA0")]
	private void Update()
	{
		this.CDUpdate();
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x000F27A0 File Offset: 0x000F09A0
	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "7")]
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x000F27B0 File Offset: 0x000F09B0
	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x6CB780", Offset = "0x6C9D80", VA = "0x1806CB780", Slot = "8")]
	public virtual bool OnClick(Mouse mouse)
	{
		if (!this.isPickUp && this.avaliable)
		{
			GameObject theItemOnMouse = mouse.theItemOnMouse;
			int num = 0;
			if (theItemOnMouse == num)
			{
				GameObject gameObject = base.gameObject;
				mouse.theItemOnMouse = gameObject;
				GameAPP.PlaySound(19, 0.5f, 1f);
				this.PickUp();
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x000F2814 File Offset: 0x000F0A14
	[Token(Token = "0x6002C81")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "9")]
	public virtual void Use(Mouse mouse)
	{
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x000F2824 File Offset: 0x000F0A24
	[Token(Token = "0x6002C82")]
	[Address(RVA = "0x6CB8F0", Offset = "0x6C9EF0", VA = "0x1806CB8F0")]
	public void PickUp()
	{
		this.isPickUp = true;
		Collider2D collider2D = this.col;
		int num = 0;
		collider2D.enabled = num != 0;
		Transform transform = base.transform;
		Transform uiparent = this.board.UIParent;
		transform.parentInternal = uiparent;
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x000F2868 File Offset: 0x000F0A68
	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x6CB950", Offset = "0x6C9F50", VA = "0x1806CB950")]
	public void PutDown()
	{
		this.isPickUp = false;
		this.col.enabled = true;
		Transform transform = base.transform;
		Transform transform2 = this.defaultParent.transform;
		transform.parentInternal = transform2;
		Transform transform3 = base.transform;
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x000F28B4 File Offset: 0x000F0AB4
	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x6CB620", Offset = "0x6C9C20", VA = "0x1806CB620", Slot = "10")]
	protected virtual void CDUpdate()
	{
		if (!this.board.freeCD)
		{
		}
		float num = this.fullCD;
		this.CD = num;
		Image image = this.cdMask;
		int num2 = 0;
		bool flag = image != num2;
		if (flag)
		{
			Image image2 = this.cdMask;
			if (!flag)
			{
			}
			int num3 = 0;
			image2.fillAmount = (float)num3;
		}
		if (this.fullCD <= this.CD)
		{
			this.avaliable = true;
			return;
		}
		float deltaTime = Time.deltaTime;
		this.CD = deltaTime;
		this.UpdateCDTimer();
		float cd = this.CD;
		this.avaliable = false;
		float num4 = this.fullCD;
		this.CD = num4;
		this.avaliable = true;
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x000F2968 File Offset: 0x000F0B68
	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "11")]
	protected virtual void UpdateCDTimer()
	{
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x000F2978 File Offset: 0x000F0B78
	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x6CA550", Offset = "0x6C8B50", VA = "0x1806CA550")]
	public InGameTool()
	{
	}

	// Token: 0x04001A5E RID: 6750
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A5E")]
	public float fullCD = 10f;

	// Token: 0x04001A5F RID: 6751
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001A5F")]
	public float CD;

	// Token: 0x04001A60 RID: 6752
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A60")]
	public bool isPickUp;

	// Token: 0x04001A61 RID: 6753
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4001A61")]
	public bool avaliable = true;

	// Token: 0x04001A62 RID: 6754
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A62")]
	public Image cdMask;

	// Token: 0x04001A63 RID: 6755
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A63")]
	public GameObject defaultParent;

	// Token: 0x04001A64 RID: 6756
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A64")]
	protected Mouse mouse;

	// Token: 0x04001A65 RID: 6757
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A65")]
	protected Collider2D col;

	// Token: 0x04001A66 RID: 6758
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A66")]
	protected Board board;

	// Token: 0x04001A67 RID: 6759
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A67")]
	protected float coolSpeed = 1f;
}
