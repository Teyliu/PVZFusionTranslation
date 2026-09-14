using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000582 RID: 1410
[Token(Token = "0x2000582")]
public class SuperSpruce : WaterSpruce
{
	// Token: 0x06001A0F RID: 6671 RVA: 0x0008C2E8 File Offset: 0x0008A4E8
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x4EAD90", Offset = "0x4E9390", VA = "0x1804EAD90", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		this.UpdateText();
		CreateBullet instance2 = CreateBullet.Instance;
		int num = this.attackDamage;
		num += num;
		Bullet bullet;
		bullet.Damage = num;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x0008C36C File Offset: 0x0008A56C
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x4EAF70", Offset = "0x4E9570", VA = "0x1804EAF70", Slot = "25")]
	public override void UpdateText()
	{
		base.UpdateText();
		SpriteRenderer spriteRenderer = this.leaf;
		spriteRenderer.enabled = true;
		Transform transform = this.leaf.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
	public SuperSpruce()
	{
	}

	// Token: 0x04000E4B RID: 3659
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E4B")]
	public SpriteRenderer leaf;
}
