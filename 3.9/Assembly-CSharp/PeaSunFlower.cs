using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200033F")]
public class PeaSunFlower : Shooter
{
	// Token: 0x06000F27 RID: 3879 RVA: 0x00057FC4 File Offset: 0x000561C4
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x467290", Offset = "0x465890", VA = "0x180467290", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
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
				PeaSunFlower.<SunBright>d__3 <SunBright>d__;
				<SunBright>d__.System.IDisposable.Dispose();
				<SunBright>d__.<>1__state = (int)((ulong)0L);
				<SunBright>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
				base.Invoke("ProduceSun", 0.5f);
			}
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00058054 File Offset: 0x00056254
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x4670C0", Offset = "0x4656C0", VA = "0x1804670C0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		Bullet bullet;
		if (num == 3)
		{
			this.attributeCount = (int)((ulong)0L);
			bullet.theStatus = (BulletStatus)num;
		}
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x000580D8 File Offset: 0x000562D8
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x466EB0", Offset = "0x4654B0", VA = "0x180466EB0")]
	private void PeaSunProduceUpdate()
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
			PeaSunFlower.<SunBright>d__3 <SunBright>d__;
			<SunBright>d__.System.IDisposable.Dispose();
			<SunBright>d__.<>1__state = (int)((ulong)0L);
			<SunBright>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<SunBright>d__);
			base.Invoke("ProduceSun", 0.5f);
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00058158 File Offset: 0x00056358
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x467220", Offset = "0x465820", VA = "0x180467220")]
	private IEnumerator SunBright()
	{
		PeaSunFlower.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0005817C File Offset: 0x0005637C
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x466FD0", Offset = "0x4655D0", VA = "0x180466FD0", Slot = "72")]
	protected virtual void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x000581B0 File Offset: 0x000563B0
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaSunFlower()
	{
	}
}
