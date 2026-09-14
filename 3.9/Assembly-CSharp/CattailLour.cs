using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F0 RID: 1264
[Token(Token = "0x20004F0")]
public class CattailLour : CattailPlant
{
	// Token: 0x060017DA RID: 6106 RVA: 0x00082608 File Offset: 0x00080808
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x50D760", Offset = "0x50BD60", VA = "0x18050D760", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		Transform transform = this.flyPos;
		GameObject gameObject = this.flyPrefab;
		Transform transform2 = this.board.transform;
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		num++;
		this.attributeCountdown = 3f;
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00082660 File Offset: 0x00080860
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x50DEC0", Offset = "0x50C4C0", VA = "0x18050DEC0")]
	public void Supply(bool onion = false)
	{
		Transform transform = this.flyPos;
		GameObject gameObject = this.flyPrefab;
		Transform transform2 = this.board.transform;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00082698 File Offset: 0x00080898
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x50D9A0", Offset = "0x50BFA0", VA = "0x18050D9A0")]
	private void FlyUpdate(GameObject fly, bool onion)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x000826B8 File Offset: 0x000808B8
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x50DCF0", Offset = "0x50C2F0", VA = "0x18050DCF0")]
	private void ShootUpdate(GameObject fly, float timer, int shootCount, bool onion)
	{
		float deltaTime = Time.deltaTime;
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Transform transform = fly.transform;
		int num2 = 0;
		Transform child = transform.GetChild(num2);
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		Bullet bullet2;
		Rigidbody2D rb2 = bullet2.rb;
		global::UnityEngine.Object.Destroy(fly);
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00082714 File Offset: 0x00080914
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x50DA90", Offset = "0x50C090", VA = "0x18050DA90", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_lourCactus1;
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00082728 File Offset: 0x00080928
	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x50DAB0", Offset = "0x50C0B0", VA = "0x18050DAB0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num = 0;
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)17)))
		{
		}
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00082798 File Offset: 0x00080998
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x000827A8 File Offset: 0x000809A8
	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CattailLour()
	{
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x000827BC File Offset: 0x000809BC
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x50E0F0", Offset = "0x50C6F0", VA = "0x18050E0F0")]
	[CompilerGenerated]
	private Bullet <ShootUpdate>g__SetBullet|8_0(BulletMoveWay bulletMoveWay, CattailLour.<>c__DisplayClass8_0 cpp2il__autoParamName__idx_1)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		bullet.fromType = (PlantType)((ulong)926L);
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)16));
		int attackDamage = this.attackDamage;
		if (flag)
		{
		}
		bullet.Damage = attackDamage;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		return bullet;
	}

	// Token: 0x04000E4E RID: 3662
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E4E")]
	public GameObject flyPrefab;

	// Token: 0x04000E4F RID: 3663
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E4F")]
	public Transform flyPos;

	// Token: 0x04000E50 RID: 3664
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E50")]
	public bool skin;

	// Token: 0x04000E51 RID: 3665
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000E51")]
	[SerializeField]
	private int flyCount;

	// Token: 0x04000E52 RID: 3666
	[Token(Token = "0x4000E52")]
	private const int maxShootCount = 60;
}
