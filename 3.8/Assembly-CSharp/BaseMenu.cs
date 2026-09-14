using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D7 RID: 2007
[Token(Token = "0x20007D7")]
public class BaseMenu : MonoBehaviour
{
	// Token: 0x060028D5 RID: 10453 RVA: 0x000DDDB8 File Offset: 0x000DBFB8
	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x62B5E0", Offset = "0x629BE0", VA = "0x18062B5E0")]
	private void OnTransformChildrenChanged()
	{
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000DDDC8 File Offset: 0x000DBFC8
	// (set) Token: 0x060028D7 RID: 10455 RVA: 0x000DDDDC File Offset: 0x000DBFDC
	[Token(Token = "0x170001A1")]
	public virtual bool Interactable
	{
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x62BC20", Offset = "0x62A220", VA = "0x18062BC20", Slot = "4")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x62BC30", Offset = "0x62A230", VA = "0x18062BC30", Slot = "5")]
		set
		{
			ulong num5;
			do
			{
				int num = 0;
				this._interactable = value;
				if (value)
				{
					List<Collider2D> list = this.collider2Ds;
					bool flag;
					if (flag)
					{
						int num2 = 0;
						if (!(num != num2))
						{
							continue;
						}
					}
					ulong num3;
					if (num3 != (ulong)0L)
					{
						goto IL_0067;
					}
				}
				List<Collider2D> list2 = this.collider2Ds;
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
				}
			}
			while (num5 != (ulong)0L);
			bool flag3;
			if (flag3)
			{
			}
			return;
			IL_0067:
			throw new NullReferenceException();
		}
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x000DDE58 File Offset: 0x000DC058
	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x62B340", Offset = "0x629940", VA = "0x18062B340", Slot = "6")]
	protected virtual void Awake()
	{
		this.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x000DDE7C File Offset: 0x000DC07C
	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x62B3C0", Offset = "0x6299C0", VA = "0x18062B3C0", Slot = "7")]
	protected virtual void GetCol()
	{
		int num;
		do
		{
			num = 0;
			List<Collider2D> list = this.collider2Ds;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<Collider2D> list2 = this.collider2Ds;
				bool interactable = this.Interactable;
			}
		}
		while (num != 0);
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x000DDEEC File Offset: 0x000DC0EC
	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "8")]
	public virtual void OnExit()
	{
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x000DDEFC File Offset: 0x000DC0FC
	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "9")]
	public virtual void OnBackEnter()
	{
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x000DDF0C File Offset: 0x000DC10C
	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "10")]
	public virtual void OnHide()
	{
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x000DDF1C File Offset: 0x000DC11C
	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x62B7E0", Offset = "0x629DE0", VA = "0x18062B7E0", Slot = "11")]
	public virtual void PopMenu()
	{
		GameAPP.UIManager.Pop();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x000DDF40 File Offset: 0x000DC140
	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x62B3A0", Offset = "0x6299A0", VA = "0x18062B3A0", Slot = "12")]
	public virtual void BackToMainMenu()
	{
		UIMgr.EnterMainMenu();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x000DDF5C File Offset: 0x000DC15C
	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x62B600", Offset = "0x629C00", VA = "0x18062B600")]
	public void PopAllMenu()
	{
		GameAPP.UIManager.PopAll();
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x000DDF7C File Offset: 0x000DC17C
	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x62BA50", Offset = "0x62A050", VA = "0x18062BA50", Slot = "13")]
	public virtual void PushMenuUp(string name)
	{
		ulong num;
		if (Enum.TryParse(typeof(UIType), name, num))
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
		}
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x000DDFAC File Offset: 0x000DC1AC
	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x62B670", Offset = "0x629C70", VA = "0x18062B670")]
	public void PopMenuWithAnim()
	{
		if (!GameAPP.config.disableMenuAnim)
		{
			GameAPP.UIManager.SetThisMenuDisable();
			Action action;
			BlackMask.Instance.Active(action);
			this.anim.Play("exit");
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x000DDFF4 File Offset: 0x000DC1F4
	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x62B850", Offset = "0x629E50", VA = "0x18062B850")]
	public void PushMenuUpWithAnim(string name)
	{
		if (!GameAPP.config.disableMenuAnim)
		{
			Type typeFromHandle = typeof(UIType);
			bool flag;
			if (flag)
			{
				GameAPP.UIManager.SetThisMenuDisable();
				BlackMask instance = BlackMask.Instance;
				object value;
				Action action = delegate
				{
					object value2 = value;
					UIResourcesLoader uimanager = GameAPP.UIManager;
				};
				instance.Active(action);
			}
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x000DE050 File Offset: 0x000DC250
	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x62BBA0", Offset = "0x62A1A0", VA = "0x18062BBA0")]
	public BaseMenu()
	{
		List<Collider2D> list = new List();
		this.collider2Ds = list;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001723 RID: 5923
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001723")]
	[SerializeField]
	protected List<Collider2D> collider2Ds;

	// Token: 0x04001724 RID: 5924
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001724")]
	protected Animator anim;

	// Token: 0x04001725 RID: 5925
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001725")]
	public CanvasGroup canvasGroup;

	// Token: 0x04001726 RID: 5926
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001726")]
	public UIType uIType;

	// Token: 0x04001727 RID: 5927
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001727")]
	protected bool poped;

	// Token: 0x04001728 RID: 5928
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4001728")]
	[SerializeField]
	private bool _interactable;
}
