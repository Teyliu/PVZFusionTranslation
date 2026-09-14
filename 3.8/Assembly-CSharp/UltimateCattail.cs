using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059F RID: 1439
[Token(Token = "0x200059F")]
public class UltimateCattail : CattailPlant, IChargeByFire
{
	// Token: 0x06001AB8 RID: 6840 RVA: 0x0008F6C4 File Offset: 0x0008D8C4
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x4FA5C0", Offset = "0x4F8BC0", VA = "0x1804FA5C0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		bool flag;
		if (!flag)
		{
		}
		base.AttributeCountdown = 0.075f;
		Transform transform = this.laserFrom;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.laserFrom.transform;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D;
			bool flag2 = collider2D.TryGetComponent<Zombie>(num);
			if (flag2 && (collider2D <= (ulong)21L || flag2 > true) && flag2 > true && collider2D != (ulong)21L)
			{
				BoardAction boardAction = this.board.boardAction;
				PlantType thePlantType = this.thePlantType;
				Collider2D collider2D2;
				collider2D2 += collider2D2;
				num++;
			}
			num++;
		}
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0008F770 File Offset: 0x0008D970
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x4FA9C0", Offset = "0x4F8FC0", VA = "0x1804FA9C0", Slot = "73")]
	public void ChargeByFire(int value = 1)
	{
		if (value > 1)
		{
		}
		int num = this.attributeCount;
		num += value;
		this.attributeCount = num;
		if (num > 240)
		{
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			this.theStatus = (PlantStatus)((ulong)38L);
		}
		base.UpdateText();
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x4FA540", Offset = "0x4F8B40", VA = "0x1804FA540")]
	private void AnimLaserUp()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
		float deltaTime = Time.deltaTime;
		base.AttributeCountdown = deltaTime;
		GameAPP.PlaySound(144, 0.5f, 1f);
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x0008F80C File Offset: 0x0008DA0C
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x439AA0", Offset = "0x4380A0", VA = "0x180439AA0")]
	private void AnimLaserOver()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x0008F824 File Offset: 0x0008DA24
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x4FAB60", Offset = "0x4F9160", VA = "0x1804FAB60", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num > 240)
		{
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			this.theStatus = (PlantStatus)((ulong)38L);
		}
		base.UpdateText();
		int attackDamage = this.attackDamage;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)43)))
		{
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = attackDamage;
		Transform shoot2 = this.shoot2;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet2;
		bullet2.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		return bullet2;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0008F8E8 File Offset: 0x0008DAE8
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x4FAA90", Offset = "0x4F9090", VA = "0x1804FAA90", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x0008F908 File Offset: 0x0008DB08
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateCattail()
	{
	}

	// Token: 0x04000E8E RID: 3726
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E8E")]
	public Transform laserFrom;
}
