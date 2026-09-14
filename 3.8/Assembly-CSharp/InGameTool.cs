using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200084C RID: 2124
[Token(Token = "0x200084C")]
public class InGameTool : MonoBehaviour, IClickable
{
	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000EDA90 File Offset: 0x000EBC90
	[Token(Token = "0x170001B7")]
	public int Priority
	{
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "4")]
		get
		{
			return 3;
		}
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x000EDAA0 File Offset: 0x000EBCA0
	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x666EF0", Offset = "0x6654F0", VA = "0x180666EF0", Slot = "6")]
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

	// Token: 0x06002B4A RID: 11082 RVA: 0x000EDAE4 File Offset: 0x000EBCE4
	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x666D80", Offset = "0x665380", VA = "0x180666D80")]
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

	// Token: 0x06002B4B RID: 11083 RVA: 0x000EDB18 File Offset: 0x000EBD18
	[Token(Token = "0x6002B4B")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x000EDB2C File Offset: 0x000EBD2C
	[Token(Token = "0x6002B4C")]
	[Address(RVA = "0x666FA0", Offset = "0x6655A0", VA = "0x180666FA0")]
	private void Update()
	{
		this.CDUpdate();
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x000EDB40 File Offset: 0x000EBD40
	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "7")]
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x000EDB50 File Offset: 0x000EBD50
	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x666C80", Offset = "0x665280", VA = "0x180666C80", Slot = "8")]
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

	// Token: 0x06002B4F RID: 11087 RVA: 0x000EDBB4 File Offset: 0x000EBDB4
	[Token(Token = "0x6002B4F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "9")]
	public virtual void Use(Mouse mouse)
	{
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x000EDBC4 File Offset: 0x000EBDC4
	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x666DF0", Offset = "0x6653F0", VA = "0x180666DF0")]
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

	// Token: 0x06002B51 RID: 11089 RVA: 0x000EDC08 File Offset: 0x000EBE08
	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x666E50", Offset = "0x665450", VA = "0x180666E50")]
	public void PutDown()
	{
		this.isPickUp = false;
		this.col.enabled = true;
		Transform transform = base.transform;
		Transform transform2 = this.defaultParent.transform;
		transform.parentInternal = transform2;
		Transform transform3 = base.transform;
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x000EDC54 File Offset: 0x000EBE54
	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x666B20", Offset = "0x665120", VA = "0x180666B20", Slot = "10")]
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

	// Token: 0x06002B53 RID: 11091 RVA: 0x000EDD08 File Offset: 0x000EBF08
	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "11")]
	protected virtual void UpdateCDTimer()
	{
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x000EDD18 File Offset: 0x000EBF18
	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x6659E0", Offset = "0x663FE0", VA = "0x1806659E0")]
	public InGameTool()
	{
	}

	// Token: 0x04001970 RID: 6512
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001970")]
	public float fullCD = 10f;

	// Token: 0x04001971 RID: 6513
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001971")]
	public float CD;

	// Token: 0x04001972 RID: 6514
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001972")]
	public bool isPickUp;

	// Token: 0x04001973 RID: 6515
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4001973")]
	public bool avaliable = true;

	// Token: 0x04001974 RID: 6516
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001974")]
	public Image cdMask;

	// Token: 0x04001975 RID: 6517
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001975")]
	public GameObject defaultParent;

	// Token: 0x04001976 RID: 6518
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001976")]
	protected Mouse mouse;

	// Token: 0x04001977 RID: 6519
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001977")]
	protected Collider2D col;

	// Token: 0x04001978 RID: 6520
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001978")]
	protected Board board;

	// Token: 0x04001979 RID: 6521
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001979")]
	protected float coolSpeed = 1f;
}
