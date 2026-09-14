using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B3 RID: 1459
[Token(Token = "0x20005B3")]
public class SuperSpruce : WaterSpruce
{
	// Token: 0x06001AF5 RID: 6901 RVA: 0x00090670 File Offset: 0x0008E870
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x54ABF0", Offset = "0x5491F0", VA = "0x18054ABF0", Slot = "68")]
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

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000906F4 File Offset: 0x0008E8F4
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x54ADD0", Offset = "0x5493D0", VA = "0x18054ADD0", Slot = "24")]
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

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00090770 File Offset: 0x0008E970
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x540AB0", Offset = "0x53F0B0", VA = "0x180540AB0")]
	public SuperSpruce()
	{
	}

	// Token: 0x04000F0A RID: 3850
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F0A")]
	public SpriteRenderer leaf;
}
