using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000801 RID: 2049
[Token(Token = "0x2000801")]
public class Almanac : BaseMenu
{
	// Token: 0x06002976 RID: 10614 RVA: 0x000DFEB0 File Offset: 0x000DE0B0
	[Token(Token = "0x6002976")]
	[Address(RVA = "0x68E720", Offset = "0x68CD20", VA = "0x18068E720", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.Init();
		TextMeshProUGUI textMeshProUGUI = this.animButton;
		GameConfig config = GameAPP.config;
		if (config.disableMenuAnim)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x000DFF00 File Offset: 0x000DE100
	[Token(Token = "0x6002977")]
	[Address(RVA = "0x68E650", Offset = "0x68CC50", VA = "0x18068E650")]
	public void AnimSwitch()
	{
		GameConfig config = GameAPP.config;
		bool flag = !config.disableMenuAnim;
		config.disableMenuAnim = flag;
		GameConfig config2 = GameAPP.config;
		if (config2.disableMenuAnim)
		{
		}
		TextMeshProUGUI textMeshProUGUI = this.animButton;
		throw new NullReferenceException();
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000DFF50 File Offset: 0x000DE150
	[Token(Token = "0x6002978")]
	[Address(RVA = "0x68E830", Offset = "0x68CE30", VA = "0x18068E830")]
	private void Init()
	{
		Transform transform = this.plantAxis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		this.plant = gameObject;
		SortingGroup sortingGroup = this.plant.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		sortingGroup.sortingOrder = 20001;
		Transform transform2 = this.plant.transform;
		Transform transform3 = base.transform;
		transform2.parentInternal = transform3;
		Transform transform4 = this.zombieAxis;
		Vector3 vector2;
		float z2 = vector2.z;
		GameObject gameObject2;
		this.zombie = gameObject2;
		SortingGroup sortingGroup2 = this.zombie.AddComponent<SortingGroup>();
		sortingGroup2.sortingLayerName = "up1";
		sortingGroup2.sortingOrder = 20001;
		Transform transform5 = this.zombie.transform;
		Transform transform6 = base.transform;
		transform5.parentInternal = transform6;
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x000E0018 File Offset: 0x000DE218
	[Token(Token = "0x6002979")]
	[Address(RVA = "0x68EAA0", Offset = "0x68D0A0", VA = "0x18068EAA0", Slot = "10")]
	public override void OnHide()
	{
		GameObject gameObject = this.plant;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.zombie;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x000E004C File Offset: 0x000DE24C
	[Token(Token = "0x600297A")]
	[Address(RVA = "0x68EA60", Offset = "0x68D060", VA = "0x18068EA60", Slot = "9")]
	public override void OnBackEnter()
	{
		this.plant.SetActive(true);
		this.zombie.SetActive(true);
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x000E0078 File Offset: 0x000DE278
	[Token(Token = "0x600297B")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public Almanac()
	{
	}

	// Token: 0x04001781 RID: 6017
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001781")]
	public Transform plantAxis;

	// Token: 0x04001782 RID: 6018
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001782")]
	public Transform zombieAxis;

	// Token: 0x04001783 RID: 6019
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001783")]
	public GameObject plant;

	// Token: 0x04001784 RID: 6020
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001784")]
	public GameObject zombie;

	// Token: 0x04001785 RID: 6021
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001785")]
	public TextMeshProUGUI animButton;
}
