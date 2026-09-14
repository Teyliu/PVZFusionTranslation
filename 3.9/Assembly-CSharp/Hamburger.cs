using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200052B RID: 1323
[Token(Token = "0x200052B")]
public class Hamburger : Shooter
{
	// Token: 0x060018AC RID: 6316 RVA: 0x00085894 File Offset: 0x00083A94
	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x526C80", Offset = "0x525280", VA = "0x180526C80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this.thePlantStage == 1)
		{
			GameObject gameObject = this.r1;
			this.thePlantMaxHealth = (int)((ulong)4000L);
			this.thePlantAttackInterval = 2f;
			int num = 0;
			gameObject.SetActive(num != 0);
			GameObject gameObject2 = this.r2;
			GameObject gameObject3 = this.r1;
			this.thePlantMaxHealth = (int)((ulong)3000L);
			this.thePlantAttackInterval = 2.5f;
			int num2 = 0;
			gameObject3.SetActive(num2 != 0);
			GameObject gameObject4 = this.r2;
			int num3 = 0;
			gameObject4.SetActive(num3 != 0);
			GameObject gameObject5 = this.r3;
			GameObject gameObject6 = this.r1;
			this.thePlantMaxHealth = (int)((ulong)2000L);
			this.thePlantAttackInterval = 2.5f;
			int num4 = 0;
			gameObject6.SetActive(num4 != 0);
			ulong num5;
			this.r2.SetActive(num5 != 0UL);
			GameObject gameObject7 = this.r3;
			int num6 = 0;
			gameObject7.SetActive(num6 != 0);
		}
		Animator anim = this.anim;
		int thePlantStage = this.thePlantStage;
		anim.SetInteger("stage", thePlantStage);
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x0008599C File Offset: 0x00083B9C
	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x5260B0", Offset = "0x5246B0", VA = "0x1805260B0")]
	public int GetMaxHealth(PlantType thePlantType)
	{
		int thePlantStage = this.thePlantStage;
		PlantDataManager.PlantData plantData;
		int num = plantData.maxHealth;
		if (plantData != 0)
		{
			if (plantData == 0)
			{
				return num;
			}
			if (thePlantStage == 1)
			{
				return num;
			}
		}
		else
		{
			num += num;
		}
		return num;
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x000859D8 File Offset: 0x00083BD8
	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x525E10", Offset = "0x524410", VA = "0x180525E10")]
	public bool AddStage(PlantType thePlantType)
	{
		int thePlantStage = this.thePlantStage;
		if (thePlantStage == 0 || thePlantStage == 0 || thePlantStage != 1)
		{
		}
		uint num;
		while (thePlantType != (PlantType)num)
		{
		}
		int num2 = this.thePlantStage;
		Animator anim = this.anim;
		num2++;
		this.thePlantStage = num2;
		anim.SetInteger("stage", num2);
		PlantType thePlantType2 = this.thePlantType;
		int thePlantStage2 = this.thePlantStage;
		PlantDataManager.PlantData plantData;
		int num3 = plantData.maxHealth;
		if (plantData == 0 || plantData == 0 || thePlantStage2 == 1)
		{
			num3 += num3;
		}
		this.thePlantMaxHealth = num3;
		int thePlantStage3 = this.thePlantStage;
		GameObject gameObject5;
		if (thePlantStage2 != 1)
		{
			if (thePlantStage2 != 1)
			{
				if (thePlantStage3 != 1)
				{
					goto IL_010B;
				}
				GameObject gameObject = this.r1;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
				GameObject gameObject2 = this.r2;
			}
			GameObject gameObject3 = this.r1;
			int num5 = 0;
			gameObject3.SetActive(num5 != 0);
			GameObject gameObject4 = this.r2;
			int num6 = 0;
			gameObject4.SetActive(num6 != 0);
			gameObject5 = this.r3;
			ulong num7;
			gameObject5.SetActive(num7 != 0UL);
		}
		int num8 = 0;
		gameObject5.SetActive(num8 != 0);
		ulong num9;
		gameObject5.SetActive(num9 != 0UL);
		int num10 = 0;
		gameObject5.SetActive(num10 != 0);
		IL_010B:
		throw new NullReferenceException();
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00085AF8 File Offset: 0x00083CF8
	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x526360", Offset = "0x524960", VA = "0x180526360", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = this.attackDamage;
		List<BulletType> list = new List();
		int size = list._size;
		int num2 = 0;
		list._size = 1;
		list._syncRoot = num2;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		int size6 = list._size;
		list._size = 1;
		if (this.thePlantStage == 1)
		{
			int size7 = list._size;
			list._size = 1;
			int size8 = list._size;
			list._size = 1;
			int size9 = list._size;
			list._size = 1;
			int size10 = list._size;
			list._size = 1;
			int size11 = list._size;
			list._size = 1;
			int size12 = list._size;
			list._size = 1;
			int size13 = list._size;
			list._size = 1;
			int size14 = list._size;
			list._size = 1;
			int size15 = list._size;
			num += 20;
			list._size = 1;
			num += 20;
			int size16 = list._size;
			list._size = 1;
			int size17 = list._size;
			list._size = 1;
			int size18 = list._size;
			list._size = 1;
			num += 10;
		}
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		int num4 = list[num3];
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (num4 == 0)
		{
			if (bullet != 0)
			{
				if (bullet != 0)
				{
					if (bullet != (ulong)1L)
					{
						return bullet;
					}
					BoardAction boardAction = this.board.boardAction;
				}
				BoardAction boardAction2 = this.board.boardAction;
			}
			BoardAction boardAction3 = this.board.boardAction;
		}
		return bullet;
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x00085CEC File Offset: 0x00083EEC
	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x526C60", Offset = "0x525260", VA = "0x180526C60", Slot = "69")]
	protected override Bullet Shoot2()
	{
		return base.AnimShoot();
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00085D04 File Offset: 0x00083F04
	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x526070", Offset = "0x524670", VA = "0x180526070")]
	private void AnimShoot3()
	{
		Bullet bullet = base.AnimShoot();
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00085D1C File Offset: 0x00083F1C
	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x526090", Offset = "0x524690", VA = "0x180526090")]
	private void AnimShoot4()
	{
		Bullet bullet = base.AnimShoot();
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00085D34 File Offset: 0x00083F34
	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x526E60", Offset = "0x525460", VA = "0x180526E60", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00085D48 File Offset: 0x00083F48
	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x526240", Offset = "0x524840", VA = "0x180526240", Slot = "36")]
	public override void ProducerUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		if (num > (int)thePlantProduceCountDown)
		{
			float thePlantProduceInterval = this.thePlantProduceInterval;
			this.thePlantProduceCountDown = thePlantProduceInterval;
			int num2 = global::UnityEngine.Random.Range(-2, 3);
			this.thePlantProduceCountDown = (float)num;
			Hamburger.<SunBright>d__12 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00085DC8 File Offset: 0x00083FC8
	[Token(Token = "0x60018B5")]
	[Address(RVA = "0x526DF0", Offset = "0x5253F0", VA = "0x180526DF0")]
	protected IEnumerator SunBright()
	{
		Hamburger.<SunBright>d__12 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00085DEC File Offset: 0x00083FEC
	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x526150", Offset = "0x524750", VA = "0x180526150")]
	private void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00085E20 File Offset: 0x00084020
	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public Hamburger()
	{
	}

	// Token: 0x04000E80 RID: 3712
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E80")]
	public GameObject r1;

	// Token: 0x04000E81 RID: 3713
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E81")]
	public GameObject r2;

	// Token: 0x04000E82 RID: 3714
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E82")]
	public GameObject r3;
}
