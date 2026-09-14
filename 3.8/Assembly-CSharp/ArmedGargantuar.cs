using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061E RID: 1566
[Token(Token = "0x200061E")]
public class ArmedGargantuar : Gargantuar
{
	// Token: 0x06001D9B RID: 7579 RVA: 0x0009F4E0 File Offset: 0x0009D6E0
	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0x51A0A0", Offset = "0x5186A0", VA = "0x18051A0A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.SetEyeType();
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x0009F4FC File Offset: 0x0009D6FC
	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0x51A860", Offset = "0x518E60", VA = "0x18051A860", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this.eyeType == ArmedGargantuar.EyeType.Blue || this.full1)
		{
			float theOriginSpeed = this.theOriginSpeed;
			this.theOriginSpeed = theOriginSpeed;
			if (this.full1)
			{
				goto IL_0038;
			}
		}
		if (this.eyeType != ArmedGargantuar.EyeType.Red)
		{
			return;
		}
		IL_0038:
		float theArmor = this.theArmor;
		this.theArmor = theArmor;
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x0009F550 File Offset: 0x0009D750
	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x0009F560 File Offset: 0x0009D760
	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x519F50", Offset = "0x518550", VA = "0x180519F50", Slot = "76")]
	protected override void AnimCrash()
	{
		base.AnimCrash();
		if (this.eyeType == ArmedGargantuar.EyeType.Green || this.full1)
		{
			int num = this.theHealth;
			num -= "jump";
			this.theHealth = num;
			int theMaxHealth = this.theMaxHealth;
			this.theHealth = theMaxHealth;
			GameObject theFirstArmor = this.theFirstArmor;
			int num2 = 0;
			bool flag = theFirstArmor != num2;
			if (flag)
			{
				int num3 = this.theFirstArmorHealth;
				num3 -= (flag ? 1 : 0);
				this.theFirstArmorHealth = num3;
				int theFirstArmorMaxHealth = this.theFirstArmorMaxHealth;
				this.theFirstArmorHealth = theFirstArmorMaxHealth;
			}
			base.UpdateHealthText();
		}
		if (this.eyeType == ArmedGargantuar.EyeType.Yellow || this.full1)
		{
			this.anim.SetTrigger("jump");
			return;
		}
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x0009F61C File Offset: 0x0009D81C
	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x519F40", Offset = "0x518540", VA = "0x180519F40")]
	private void AnimCrash2()
	{
		base.AnimCrash();
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x0009F630 File Offset: 0x0009D830
	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x51A250", Offset = "0x518850", VA = "0x18051A250", Slot = "77")]
	protected override void CrashPlant(Plant plant, bool crash)
	{
		Zombie zombie;
		ArmedGargantuar.EyeType eyeType;
		for (;;)
		{
			if (!crash)
			{
				plant.FlashOnce();
				if (this.eyeType == ArmedGargantuar.EyeType.Blue || this.full1 == crash)
				{
				}
				while (this.full1 != crash)
				{
				}
			}
			bool flag;
			if (!flag)
			{
				return;
			}
			Transform axis = plant.axis;
			CreateZombie instance = CreateZombie.Instance;
			int num = 0;
			if (!(zombie != num))
			{
				return;
			}
			this.board.SetHealthInTravel(zombie);
			eyeType = this.eyeType;
			if (eyeType == ArmedGargantuar.EyeType.Red || eyeType == ArmedGargantuar.EyeType.Red)
			{
				goto IL_00A4;
			}
			if (eyeType != ArmedGargantuar.EyeType.Red)
			{
				break;
			}
			CreateZombie instance2 = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie2;
			if (zombie2 != num2)
			{
				goto IL_00A4;
			}
		}
		if (eyeType == ArmedGargantuar.EyeType.Blue)
		{
			int num3 = zombie.theAttackDamage;
			num3 += num3;
			zombie.theAttackDamage = num3;
		}
		return;
		IL_00A4:
		throw new NullReferenceException();
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x0009F6E8 File Offset: 0x0009D8E8
	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x51A820", Offset = "0x518E20", VA = "0x18051A820", Slot = "49")]
	public override void SetJalaed()
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Red)
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x0009F708 File Offset: 0x0009D908
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x51A600", Offset = "0x518C00", VA = "0x18051A600", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x0009F728 File Offset: 0x0009D928
	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x51A800", Offset = "0x518E00", VA = "0x18051A800", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x0009F74C File Offset: 0x0009D94C
	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x51A230", Offset = "0x518830", VA = "0x18051A230", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Yellow)
		{
			base.Buttered(time, sprite);
			return;
		}
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x0009F76C File Offset: 0x0009D96C
	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x51A840", Offset = "0x518E40", VA = "0x18051A840", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Green)
		{
			base.SetPoison(time);
			return;
		}
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x0009F78C File Offset: 0x0009D98C
	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x519F20", Offset = "0x518520", VA = "0x180519F20", Slot = "53")]
	public override void AddPoisonLevel()
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Green)
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x0009F7AC File Offset: 0x0009D9AC
	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x51A5E0", Offset = "0x518BE0", VA = "0x18051A5E0", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		if (this.eyeType != ArmedGargantuar.EyeType.Blue)
		{
			base.KnockBack(x, reason);
			return;
		}
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x0009F7CC File Offset: 0x0009D9CC
	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x0009F7DC File Offset: 0x0009D9DC
	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x51A620", Offset = "0x518C20", VA = "0x18051A620")]
	private void SetEyeType()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)24));
		this.full1 = flag;
		Array values = Enum.GetValues(typeof(ArmedGargantuar.EyeType));
		if (values == 0 || values != 0)
		{
			List<ArmedGargantuar.EyeType> list = Enumerable.ToList<ArmedGargantuar.EyeType>(values);
			int num = list._size;
			num = global::UnityEngine.Random.Range(0, num);
			ArmedGargantuar.EyeType eyeType = list[num];
			List<Sprite> list2 = this.headSprites;
			int num2 = (int)eyeType;
			SpriteRenderer spriteRenderer = this.head;
			this.eyeType = eyeType;
			int num3 = (int)eyeType;
			Sprite sprite = list2[num3];
			spriteRenderer.sprite = sprite;
			List<Sprite> list3 = this.helmetSprites;
			SpriteRenderer spriteRenderer2 = this.helmet;
			Sprite sprite2 = list3[num2];
			spriteRenderer2.sprite = sprite2;
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x0009F890 File Offset: 0x0009DA90
	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x51A0C0", Offset = "0x5186C0", VA = "0x18051A0C0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x0009F8CC File Offset: 0x0009DACC
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x51A8D0", Offset = "0x518ED0", VA = "0x18051A8D0")]
	public ArmedGargantuar()
	{
		List<Sprite> list = new List();
		this.headSprites = list;
		List<Sprite> list2 = new List();
		this.helmetSprites = list2;
		base..ctor();
	}

	// Token: 0x04001028 RID: 4136
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001028")]
	private ArmedGargantuar.EyeType eyeType;

	// Token: 0x04001029 RID: 4137
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001029")]
	public SpriteRenderer head;

	// Token: 0x0400102A RID: 4138
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400102A")]
	public List<Sprite> headSprites;

	// Token: 0x0400102B RID: 4139
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400102B")]
	public SpriteRenderer helmet;

	// Token: 0x0400102C RID: 4140
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400102C")]
	public List<Sprite> helmetSprites;

	// Token: 0x0400102D RID: 4141
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400102D")]
	private bool full1;

	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	private enum EyeType
	{
		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		Red,
		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		Blue,
		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		Green,
		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		Yellow
	}
}
