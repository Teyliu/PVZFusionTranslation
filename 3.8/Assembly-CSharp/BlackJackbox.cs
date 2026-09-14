using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200062E RID: 1582
[Token(Token = "0x200062E")]
public class BlackJackbox : JackboxZombie
{
	// Token: 0x06001DF2 RID: 7666 RVA: 0x000A0524 File Offset: 0x0009E724
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x532AB0", Offset = "0x5310B0", VA = "0x180532AB0", Slot = "74")]
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
			}
			base.Pop();
		}
		AudioSource audioSource = this.audioSource;
		float gameSoundVolume = GameAPP.config.gameSoundVolume;
		audioSource.volume = gameSoundVolume;
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x000A05C8 File Offset: 0x0009E7C8
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x532A80", Offset = "0x531080", VA = "0x180532A80")]
	private void CursePlant(Plant plant)
	{
		bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 10f);
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000A05EC File Offset: 0x0009E7EC
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x532350", Offset = "0x530950", VA = "0x180532350", Slot = "75")]
	protected override void AnimExplode()
	{
		base.Die(2);
		Transform axis = this.axis;
		long num = (long)(this.level * (int)((uint)1800));
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000A0620 File Offset: 0x0009E820
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x5324D0", Offset = "0x530AD0", VA = "0x1805324D0")]
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
			Func<Plant, bool> <>9__3_ = BlackJackbox.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<Plant, bool> func;
				BlackJackbox.<>c.<>9__3_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(plantsByRow, <>9__3_));
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

	// Token: 0x06001DF6 RID: 7670 RVA: 0x000A0728 File Offset: 0x0009E928
	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000A0738 File Offset: 0x0009E938
	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x5329E0", Offset = "0x530FE0", VA = "0x1805329E0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000A0778 File Offset: 0x0009E978
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000A07B4 File Offset: 0x0009E9B4
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x532C60", Offset = "0x531260", VA = "0x180532C60")]
	public BlackJackbox()
	{
	}
}
