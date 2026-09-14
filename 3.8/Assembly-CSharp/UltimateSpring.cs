using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BE RID: 1470
[Token(Token = "0x20005BE")]
public class UltimateSpring : MelonFume
{
	// Token: 0x06001B5C RID: 7004 RVA: 0x00092964 File Offset: 0x00090B64
	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x5029C0", Offset = "0x500FC0", VA = "0x1805029C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_springMelon;
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x00092974 File Offset: 0x00090B74
	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x502DB0", Offset = "0x5013B0", VA = "0x180502DB0", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		base.UniqueEffect(bullet);
		bool flag = "{il2cpp field on {'Bullet_springMelon' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Bullet_springMelon).TypeHandle;
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000929AC File Offset: 0x00090BAC
	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x502CD0", Offset = "0x5012D0", VA = "0x180502CD0", Slot = "80")]
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

	// Token: 0x06001B5F RID: 7007 RVA: 0x000929F0 File Offset: 0x00090BF0
	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x502BE0", Offset = "0x5011E0", VA = "0x180502BE0", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		Vector2 mousePosition = mouse.MousePosition;
		this.ShootByMouse(mousePosition);
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x00092A14 File Offset: 0x00090C14
	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x502C20", Offset = "0x501220", VA = "0x180502C20")]
	public void ShootByMouse(Vector2 pos)
	{
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot2");
		int num2 = 0;
		this.cannonTarget.z = (float)num2;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x00092A60 File Offset: 0x00090C60
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x5029D0", Offset = "0x500FD0", VA = "0x1805029D0", Slot = "62")]
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

	// Token: 0x06001B62 RID: 7010 RVA: 0x00092AC4 File Offset: 0x00090CC4
	[Token(Token = "0x6001B62")]
	[Address(RVA = "0x502790", Offset = "0x500D90", VA = "0x180502790")]
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

	// Token: 0x06001B63 RID: 7011 RVA: 0x00092B50 File Offset: 0x00090D50
	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public UltimateSpring()
	{
	}
}
