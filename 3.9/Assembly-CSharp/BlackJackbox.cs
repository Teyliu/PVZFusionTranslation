using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000663 RID: 1635
[Token(Token = "0x2000663")]
public class BlackJackbox : JackboxZombie
{
	// Token: 0x06001EF1 RID: 7921 RVA: 0x000A4B04 File Offset: 0x000A2D04
	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x5896C0", Offset = "0x587CC0", VA = "0x1805896C0", Slot = "76")]
	protected override void PopUpdate()
	{
		float popCountDown = this.popCountDown;
		int num = 0;
		if (popCountDown > (float)num)
		{
			float popCountDown2 = this.popCountDown;
			float deltaTime = Time.deltaTime;
			this.popCountDown = popCountDown2;
			this.popCountDown = 0f;
			if (global::UnityEngine.Random.Range(0, 3) != 0)
			{
				this.anim.SetTrigger("throw");
				this.audioSource.Pause();
				this.audioSourcePlaying = false;
				if (!Lawnf.TravelDebuff((TravelDebuff)((uint)38)))
				{
					goto IL_0080;
				}
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
			base.Pop();
		}
		IL_0080:
		AudioSource audioSource = this.audioSource;
		float gameSoundVolume = GameAPP.config.gameSoundVolume;
		audioSource.volume = gameSoundVolume;
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x589610", Offset = "0x587C10", VA = "0x180589610")]
	private void GetNewOne()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x000A4BE8 File Offset: 0x000A2DE8
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x5895E0", Offset = "0x587BE0", VA = "0x1805895E0")]
	private void CursePlant(Plant plant)
	{
		bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 10f);
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x000A4C0C File Offset: 0x000A2E0C
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x588EB0", Offset = "0x5874B0", VA = "0x180588EB0", Slot = "77")]
	protected override void AnimExplode()
	{
		base.Die(2);
		Transform axis = this.axis;
		long num = (long)(this.level * (int)((uint)1800));
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x000A4C40 File Offset: 0x000A2E40
	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x589030", Offset = "0x587630", VA = "0x180589030")]
	private void AnimThrow()
	{
		int num;
		do
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot = this.shoot;
			Transform shoot2 = this.shoot;
			num = 0;
			Bullet bullet;
			bool flag;
			bullet.Damage = (flag ? 1 : 0);
			bullet.from_zombie = this;
			bullet.shootByZombie = true;
			int num2 = 0;
			bullet.ThrowToNull(num2, num);
			int theZombieRow = this.theZombieRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, theZombieRow);
			Func<Plant, bool> <>9__4_ = BlackJackbox.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				BlackJackbox.<>c.<>9__4_0 = delegate(Plant p)
				{
					if (p.plantTag != (ulong)0L)
					{
					}
					bool flag3;
					return flag3;
				};
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(plantsByRow, <>9__4_));
			int num3 = 0;
			if (!(plant != num3))
			{
				Transform shoot3 = this.shoot;
				Vector3 vector;
				float z = vector.z;
				GridSystem gridSystem = this.board.gridSystem;
				int theZombieRow2 = this.theZombieRow;
				int num4 = 0;
				Vector2 position = gridSystem.GetGrid(num4, theZombieRow2).Position;
			}
			int num5 = 0;
			bullet.ThrowTo(plant, num5, num);
			List<Transform> changeSprites = this.changeSprites;
			bool flag2;
			if (flag2)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num != 0);
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000A4D58 File Offset: 0x000A2F58
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x000A4D68 File Offset: 0x000A2F68
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x589540", Offset = "0x587B40", VA = "0x180589540", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x000A4DE4 File Offset: 0x000A2FE4
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x589930", Offset = "0x587F30", VA = "0x180589930")]
	public BlackJackbox()
	{
	}
}
