using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B6 RID: 950
[Token(Token = "0x20003B6")]
public class IcePumpkin : Pumpkin
{
	// Token: 0x06001167 RID: 4455 RVA: 0x00062EC8 File Offset: 0x000610C8
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x443A00", Offset = "0x442000", VA = "0x180443A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 5f;
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x00062EE8 File Offset: 0x000610E8
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x4439C0", Offset = "0x441FC0", VA = "0x1804439C0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		int num = 0;
		this.attributeCountdown = 5f;
		bool flag = this.OnClicked(num);
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x00062F10 File Offset: 0x00061110
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x443CD0", Offset = "0x4422D0", VA = "0x180443CD0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00062F24 File Offset: 0x00061124
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x443C60", Offset = "0x442260", VA = "0x180443C60", Slot = "64")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		zombie.SetCold(4f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(5, num3);
		return base.OnEat(zombie);
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00062F5C File Offset: 0x0006115C
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x443D10", Offset = "0x442310", VA = "0x180443D10")]
	public bool StoragedCool(Vector2 pos)
	{
		int num = 0;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector3;
		float z3 = vector3.z;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)85), num, thePlantRow, num3 != 0UL, (float)num2);
		base.UpdateText();
		return true;
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00062FC8 File Offset: 0x000611C8
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x443A20", Offset = "0x442020", VA = "0x180443A20", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00062FE8 File Offset: 0x000611E8
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x443AF0", Offset = "0x4420F0", VA = "0x180443AF0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		Vector3 vector;
		float z = vector.z;
		base.UpdateText();
		return true;
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00063028 File Offset: 0x00061228
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public IcePumpkin()
	{
	}

	// Token: 0x04000BBC RID: 3004
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BBC")]
	public GameObject back;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	private static bool blocked;
}
