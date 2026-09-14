using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F0 RID: 1520
[Token(Token = "0x20005F0")]
public class UltimateSpring : MelonFume
{
	// Token: 0x06001C4F RID: 7247 RVA: 0x00097098 File Offset: 0x00095298
	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x56A0A0", Offset = "0x5686A0", VA = "0x18056A0A0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_springMelon;
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000970A8 File Offset: 0x000952A8
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x56A520", Offset = "0x568B20", VA = "0x18056A520", Slot = "77")]
	protected override void UniqueEffect(Bullet bullet)
	{
		base.UniqueEffect(bullet);
		bool flag = "{il2cpp field on {'Bullet_springMelon' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Bullet_springMelon).TypeHandle;
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x000970E0 File Offset: 0x000952E0
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x56A440", Offset = "0x568A40", VA = "0x18056A440", Slot = "79")]
	protected override void TimerUpdate()
	{
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)26)))
		{
			base.TimerUpdate();
		}
		float attackSpeedAdder = this.attackSpeedAdder;
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
		Board board = this.board;
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x00097124 File Offset: 0x00095324
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x56A2C0", Offset = "0x5688C0", VA = "0x18056A2C0", Slot = "62")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		Vector2 mousePosition = mouse.MousePosition;
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot2");
		int num2 = 0;
		this.cannonTarget.z = (float)num2;
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x00097178 File Offset: 0x00095378
	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x56A390", Offset = "0x568990", VA = "0x18056A390")]
	public void ShootByMouse(Vector2 pos)
	{
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot2");
		int num2 = 0;
		this.cannonTarget.z = (float)num2;
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x000971C4 File Offset: 0x000953C4
	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x56A0B0", Offset = "0x5686B0", VA = "0x18056A0B0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[48];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		return true;
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x00097228 File Offset: 0x00095428
	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x569E60", Offset = "0x568460", VA = "0x180569E60")]
	private void AnimShootByMouse()
	{
		Mouse instance = Mouse.Instance;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		BulletType bulletType = this.GetBulletType();
		Transform shoot3 = this.shoot;
		float flightTime = this.flightTime;
		bool melonSputter = this.melonSputter;
		Bullet bullet;
		bullet.melonSputter = melonSputter;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		this.UniqueEffect(bullet);
		int num = bullet._damage;
		num += num;
		bullet._damage = num;
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x000972B4 File Offset: 0x000954B4
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public UltimateSpring()
	{
	}
}
