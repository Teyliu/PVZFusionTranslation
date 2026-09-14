using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200081D RID: 2077
[Token(Token = "0x200081D")]
public class DamMenu : BaseMenu, IDragHandler, IEventSystemHandler
{
	// Token: 0x06002A62 RID: 10850 RVA: 0x000E5410 File Offset: 0x000E3610
	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x692BF0", Offset = "0x6911F0", VA = "0x180692BF0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		DamMenu.Instance = this;
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x000E5438 File Offset: 0x000E3638
	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x692FE0", Offset = "0x6915E0", VA = "0x180692FE0")]
	private void Update()
	{
		base.transform.SetAsLastSibling();
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x000E5458 File Offset: 0x000E3658
	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x692CA0", Offset = "0x6912A0", VA = "0x180692CA0")]
	public void CreateDam(string name, string text)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x000E5478 File Offset: 0x000E3678
	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x692D90", Offset = "0x691390", VA = "0x180692D90", Slot = "14")]
	public void OnDrag(PointerEventData eventData)
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform = base.transform;
		Transform transform2 = this.axis;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x000E54C4 File Offset: 0x000E36C4
	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x693010", Offset = "0x691610", VA = "0x180693010")]
	public DamMenu()
	{
		Queue<GameObject> queue = new Queue();
		this.dams = queue;
		base..ctor();
	}

	// Token: 0x0400184E RID: 6222
	[Token(Token = "0x400184E")]
	public static DamMenu Instance;

	// Token: 0x0400184F RID: 6223
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400184F")]
	public GameObject DamClip;

	// Token: 0x04001850 RID: 6224
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001850")]
	public ScrollRect myScrollRect;

	// Token: 0x04001851 RID: 6225
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001851")]
	public RectTransform damLayout;

	// Token: 0x04001852 RID: 6226
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001852")]
	public Transform axis;

	// Token: 0x04001853 RID: 6227
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001853")]
	public bool autoUpdate;

	// Token: 0x04001854 RID: 6228
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001854")]
	public Queue<GameObject> dams;
}
