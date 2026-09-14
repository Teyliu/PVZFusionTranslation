using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007C8 RID: 1992
[Token(Token = "0x20007C8")]
public class Almanac : BaseMenu
{
	// Token: 0x06002847 RID: 10311 RVA: 0x000DAEF4 File Offset: 0x000D90F4
	[Token(Token = "0x6002847")]
	[Address(RVA = "0x62AE20", Offset = "0x629420", VA = "0x18062AE20", Slot = "6")]
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

	// Token: 0x06002848 RID: 10312 RVA: 0x000DAF44 File Offset: 0x000D9144
	[Token(Token = "0x6002848")]
	[Address(RVA = "0x62AD50", Offset = "0x629350", VA = "0x18062AD50")]
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

	// Token: 0x06002849 RID: 10313 RVA: 0x000DAF94 File Offset: 0x000D9194
	[Token(Token = "0x6002849")]
	[Address(RVA = "0x62AF30", Offset = "0x629530", VA = "0x18062AF30")]
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

	// Token: 0x0600284A RID: 10314 RVA: 0x000DB05C File Offset: 0x000D925C
	[Token(Token = "0x600284A")]
	[Address(RVA = "0x62B1A0", Offset = "0x6297A0", VA = "0x18062B1A0", Slot = "10")]
	public override void OnHide()
	{
		GameObject gameObject = this.plant;
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.zombie;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x000DB090 File Offset: 0x000D9290
	[Token(Token = "0x600284B")]
	[Address(RVA = "0x62B160", Offset = "0x629760", VA = "0x18062B160", Slot = "9")]
	public override void OnBackEnter()
	{
		this.plant.SetActive(true);
		this.zombie.SetActive(true);
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x000DB0BC File Offset: 0x000D92BC
	[Token(Token = "0x600284C")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public Almanac()
	{
	}

	// Token: 0x040016A5 RID: 5797
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40016A5")]
	public Transform plantAxis;

	// Token: 0x040016A6 RID: 5798
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016A6")]
	public Transform zombieAxis;

	// Token: 0x040016A7 RID: 5799
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016A7")]
	public GameObject plant;

	// Token: 0x040016A8 RID: 5800
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40016A8")]
	public GameObject zombie;

	// Token: 0x040016A9 RID: 5801
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016A9")]
	public TextMeshProUGUI animButton;
}
