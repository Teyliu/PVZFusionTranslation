using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C3 RID: 963
[Token(Token = "0x20003C3")]
public class JalaPumpkin : Pumpkin
{
	// Token: 0x06001194 RID: 4500 RVA: 0x00063880 File Offset: 0x00061A80
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x445B50", Offset = "0x444150", VA = "0x180445B50", Slot = "29")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
		GameObject gameObject = this.fire3;
		CrackStatus crackStatus;
		this.CrackStatus = crackStatus;
		bool flag = crackStatus != CrackStatus.Bad;
		gameObject.SetActive(flag);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x000638B8 File Offset: 0x00061AB8
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x4459E0", Offset = "0x443FE0", VA = "0x1804459E0", Slot = "64")]
	public override bool OnEat(Zombie zombie)
	{
		CrackStatus crackStatus = this.CrackStatus;
		if (crackStatus == CrackStatus.Normal)
		{
		}
		if (crackStatus == CrackStatus.Bad)
		{
		}
		PlantType thePlantType = this.thePlantType;
		zombie.SetJalaed();
		throw new NullReferenceException();
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x000638EC File Offset: 0x00061AEC
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x445BD0", Offset = "0x4441D0", VA = "0x180445BD0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x0006390C File Offset: 0x00061B0C
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x445780", Offset = "0x443D80", VA = "0x180445780", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)2), action);
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00063924 File Offset: 0x00061B24
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x445AA0", Offset = "0x4440A0", VA = "0x180445AA0")]
	private void OnZombieDeath(object obj)
	{
		bool flag;
		if (obj != 0 && flag)
		{
			int thePlantRow = this.thePlantRow;
			base.UpdateText();
		}
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00063948 File Offset: 0x00061B48
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x445950", Offset = "0x443F50", VA = "0x180445950", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		this.attributeCount = (int)((ulong)0L);
		base.UpdateText();
		return true;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00063980 File Offset: 0x00061B80
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x445820", Offset = "0x443E20", VA = "0x180445820", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00063990 File Offset: 0x00061B90
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x445840", Offset = "0x443E40", VA = "0x180445840")]
	public void EatEnergy(int value)
	{
		this.attributeCount = value;
		if (value > 1000000)
		{
			this.attributeCount = (int)((ulong)1000000L);
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x000639BC File Offset: 0x00061BBC
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x445880", Offset = "0x443E80", VA = "0x180445880", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000639DC File Offset: 0x00061BDC
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public JalaPumpkin()
	{
	}

	// Token: 0x04000BC5 RID: 3013
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BC5")]
	public GameObject fire3;

	// Token: 0x04000BC6 RID: 3014
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BC6")]
	public GameObject back;

	// Token: 0x04000BC7 RID: 3015
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BC7")]
	private CrackStatus CrackStatus;
}
