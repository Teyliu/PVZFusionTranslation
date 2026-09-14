using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x02000841 RID: 2113
[Token(Token = "0x2000841")]
public class BaseWindow : UIButton
{
	// Token: 0x06002B18 RID: 11032 RVA: 0x000EA2D8 File Offset: 0x000E84D8
	[Token(Token = "0x6002B18")]
	[Address(RVA = "0x6988F0", Offset = "0x696EF0", VA = "0x1806988F0", Slot = "10")]
	protected virtual void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x000EA2F4 File Offset: 0x000E84F4
	[Token(Token = "0x6002B19")]
	[Address(RVA = "0x698940", Offset = "0x696F40", VA = "0x180698940", Slot = "11")]
	public virtual void OnAnimOver()
	{
		if (this.onAnimOver != 0)
		{
		}
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x000EA30C File Offset: 0x000E850C
	[Token(Token = "0x6002B1A")]
	[Address(RVA = "0x698A00", Offset = "0x697000", VA = "0x180698A00")]
	public void SetDescription(string text)
	{
		TextMeshProUGUI textMeshProUGUI = this.introduce;
		throw new NullReferenceException();
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x000EA328 File Offset: 0x000E8528
	[Token(Token = "0x6002B1B")]
	[Address(RVA = "0x698960", Offset = "0x696F60", VA = "0x180698960")]
	public GameObject ResetPlant(PlantType thePlantType)
	{
		GameObject gameObject = this.show;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x000EA358 File Offset: 0x000E8558
	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x698AF0", Offset = "0x6970F0", VA = "0x180698AF0")]
	public GameObject SetPlant(PlantType thePlantType)
	{
		GameObject gameObject;
		bool flag;
		do
		{
			Transform transform = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = 0;
			if (gameObject == num)
			{
				Transform transform2 = this.axis;
				Vector3 vector2;
				float z2 = vector2.z;
			}
			Transform transform3 = gameObject.transform;
			Transform transform4 = base.transform;
			transform3.parentInternal = transform4;
			this.show = gameObject;
		}
		while (flag);
		gameObject.AddComponent<SortingGroup>().sortingLayerName = "UI";
		bool flag2;
		if (flag2)
		{
			Transform transform5 = gameObject.transform;
			Vector3 vector3;
			float z3 = vector3.z;
		}
		return gameObject;
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x000EA3F0 File Offset: 0x000E85F0
	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x698D90", Offset = "0x697390", VA = "0x180698D90")]
	public void SetZombie(ZombieType theZombieType, float scale = 1f)
	{
		GameObject gameObject2;
		bool flag;
		do
		{
			GameObject gameObject = this.show;
			int num = 0;
			if (gameObject != num)
			{
				global::UnityEngine.Object.Destroy(this.show);
			}
			Transform transform = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = gameObject2.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
			Transform transform4 = gameObject2.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
		while (flag);
		gameObject2.AddComponent<SortingGroup>().sortingLayerName = "UI";
		this.show = gameObject2;
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x000EA47C File Offset: 0x000E867C
	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x698A30", Offset = "0x697030", VA = "0x180698A30")]
	public void SetImage(Quality frameType)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x000EA4A0 File Offset: 0x000E86A0
	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x6990A0", Offset = "0x6976A0", VA = "0x1806990A0")]
	private void ShaderUpdate(Material mt, CancellationTokenSource cancellationTokenSource)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x000EA4C4 File Offset: 0x000E86C4
	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x698FD0", Offset = "0x6975D0", VA = "0x180698FD0")]
	private void ShaderUpdate2(Material mt, CancellationTokenSource cancellationTokenSource)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x000EA4E8 File Offset: 0x000E86E8
	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public BaseWindow()
	{
	}

	// Token: 0x04001910 RID: 6416
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001910")]
	public Transform axis;

	// Token: 0x04001911 RID: 6417
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001911")]
	public TextMeshProUGUI title;

	// Token: 0x04001912 RID: 6418
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001912")]
	public TextMeshProUGUI introduce;

	// Token: 0x04001913 RID: 6419
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001913")]
	public GameObject show;

	// Token: 0x04001914 RID: 6420
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001914")]
	public Action onAnimOver;

	// Token: 0x04001915 RID: 6421
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001915")]
	protected Animator anim;

	// Token: 0x04001916 RID: 6422
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001916")]
	public Image frameImage;

	// Token: 0x04001917 RID: 6423
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001917")]
	private CancellationTokenSource CancellationTokenSource;
}
