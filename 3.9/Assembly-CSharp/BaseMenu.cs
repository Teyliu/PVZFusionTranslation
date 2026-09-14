using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000810 RID: 2064
[Token(Token = "0x2000810")]
public class BaseMenu : MonoBehaviour
{
	// Token: 0x06002A04 RID: 10756 RVA: 0x000E2DA8 File Offset: 0x000E0FA8
	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x68EEE0", Offset = "0x68D4E0", VA = "0x18068EEE0")]
	private void OnTransformChildrenChanged()
	{
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000E2DB8 File Offset: 0x000E0FB8
	// (set) Token: 0x06002A06 RID: 10758 RVA: 0x000E2DCC File Offset: 0x000E0FCC
	[Token(Token = "0x170001EB")]
	public virtual bool Interactable
	{
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x68F520", Offset = "0x68DB20", VA = "0x18068F520", Slot = "4")]
		get
		{
			return this._interactable;
		}
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x68F530", Offset = "0x68DB30", VA = "0x18068F530", Slot = "5")]
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

	// Token: 0x06002A07 RID: 10759 RVA: 0x000E2E48 File Offset: 0x000E1048
	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x68EC40", Offset = "0x68D240", VA = "0x18068EC40", Slot = "6")]
	protected virtual void Awake()
	{
		this.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x000E2E6C File Offset: 0x000E106C
	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x68ECC0", Offset = "0x68D2C0", VA = "0x18068ECC0", Slot = "7")]
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

	// Token: 0x06002A09 RID: 10761 RVA: 0x000E2EDC File Offset: 0x000E10DC
	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "8")]
	public virtual void OnExit()
	{
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x000E2EEC File Offset: 0x000E10EC
	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "9")]
	public virtual void OnBackEnter()
	{
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x000E2EFC File Offset: 0x000E10FC
	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "10")]
	public virtual void OnHide()
	{
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x000E2F0C File Offset: 0x000E110C
	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x68F0E0", Offset = "0x68D6E0", VA = "0x18068F0E0", Slot = "11")]
	public virtual void PopMenu()
	{
		GameAPP.UIManager.Pop();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x000E2F30 File Offset: 0x000E1130
	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x68ECA0", Offset = "0x68D2A0", VA = "0x18068ECA0", Slot = "12")]
	public virtual void BackToMainMenu()
	{
		UIMgr.EnterMainMenu();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x000E2F4C File Offset: 0x000E114C
	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x68EF00", Offset = "0x68D500", VA = "0x18068EF00")]
	public void PopAllMenu()
	{
		GameAPP.UIManager.PopAll();
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x000E2F6C File Offset: 0x000E116C
	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x68F350", Offset = "0x68D950", VA = "0x18068F350", Slot = "13")]
	public virtual void PushMenuUp(string name)
	{
		ulong num;
		if (Enum.TryParse(typeof(UIType), name, num))
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
		}
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x000E2F9C File Offset: 0x000E119C
	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x68EF70", Offset = "0x68D570", VA = "0x18068EF70")]
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

	// Token: 0x06002A11 RID: 10769 RVA: 0x000E2FE4 File Offset: 0x000E11E4
	[Token(Token = "0x6002A11")]
	[Address(RVA = "0x68F150", Offset = "0x68D750", VA = "0x18068F150")]
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

	// Token: 0x06002A12 RID: 10770 RVA: 0x000E3040 File Offset: 0x000E1240
	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x68F4A0", Offset = "0x68DAA0", VA = "0x18068F4A0")]
	public BaseMenu()
	{
		List<Collider2D> list = new List();
		this.collider2Ds = list;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x040017FF RID: 6143
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017FF")]
	[SerializeField]
	protected List<Collider2D> collider2Ds;

	// Token: 0x04001800 RID: 6144
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001800")]
	protected Animator anim;

	// Token: 0x04001801 RID: 6145
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001801")]
	public CanvasGroup canvasGroup;

	// Token: 0x04001802 RID: 6146
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001802")]
	public UIType uIType;

	// Token: 0x04001803 RID: 6147
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001803")]
	protected bool poped;

	// Token: 0x04001804 RID: 6148
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4001804")]
	[SerializeField]
	private bool _interactable;
}
