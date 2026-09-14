using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CB RID: 1227
[Token(Token = "0x20004CB")]
public class CattailLour : CattailPlant
{
	// Token: 0x0600172C RID: 5932 RVA: 0x0007F65C File Offset: 0x0007D85C
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x49DD60", Offset = "0x49C360", VA = "0x18049DD60", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		Transform transform = this.flyPos;
		GameObject gameObject = this.flyPrefab;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		IntPtr cachedPtr = gameObject2.m_CachedPtr;
		num++;
		this.attributeCountdown = 3f;
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x0007F6AC File Offset: 0x0007D8AC
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x49E4C0", Offset = "0x49CAC0", VA = "0x18049E4C0")]
	public void Supply(bool onion = false)
	{
		Transform transform = this.flyPos;
		GameObject gameObject = this.flyPrefab;
		Transform transform2 = this.board.transform;
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x0007F6DC File Offset: 0x0007D8DC
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x49DFA0", Offset = "0x49C5A0", VA = "0x18049DFA0")]
	private void FlyUpdate(GameObject fly, bool onion)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x0007F6FC File Offset: 0x0007D8FC
	[Token(Token = "0x600172F")]
	[Address(RVA = "0x49E2F0", Offset = "0x49C8F0", VA = "0x18049E2F0")]
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

	// Token: 0x06001730 RID: 5936 RVA: 0x0007F758 File Offset: 0x0007D958
	[Token(Token = "0x6001730")]
	[Address(RVA = "0x49E090", Offset = "0x49C690", VA = "0x18049E090", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_lourCactus1;
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x0007F76C File Offset: 0x0007D96C
	[Token(Token = "0x6001731")]
	[Address(RVA = "0x49E0B0", Offset = "0x49C6B0", VA = "0x18049E0B0", Slot = "69")]
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

	// Token: 0x06001732 RID: 5938 RVA: 0x0007F7DC File Offset: 0x0007D9DC
	[Token(Token = "0x6001732")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x0007F7EC File Offset: 0x0007D9EC
	[Token(Token = "0x6001733")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CattailLour()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0007F80C File Offset: 0x0007DA0C
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x49E6F0", Offset = "0x49CCF0", VA = "0x18049E6F0")]
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

	// Token: 0x04000DAB RID: 3499
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DAB")]
	public GameObject flyPrefab;

	// Token: 0x04000DAC RID: 3500
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DAC")]
	public Transform flyPos;

	// Token: 0x04000DAD RID: 3501
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DAD")]
	public bool skin;

	// Token: 0x04000DAE RID: 3502
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000DAE")]
	[SerializeField]
	private int flyCount;

	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	private const int maxShootCount = 60;
}
