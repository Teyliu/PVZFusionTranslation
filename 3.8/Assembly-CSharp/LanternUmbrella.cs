using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CE RID: 974
[Token(Token = "0x20003CE")]
public class LanternUmbrella : CornUmbrella
{
	// Token: 0x060011C6 RID: 4550 RVA: 0x00064278 File Offset: 0x00062478
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x447670", Offset = "0x445C70", VA = "0x180447670", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = this.maxEnergy;
		this.attributeCount = num;
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x0006429C File Offset: 0x0006249C
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x4476A0", Offset = "0x445CA0", VA = "0x1804476A0", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x000642D8 File Offset: 0x000624D8
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x447BB0", Offset = "0x4461B0", VA = "0x180447BB0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		GameObject gameObject = GameAPP.particlePrefab[40];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		this.lanternLight = gameObject2;
		ParticleSystem component = this.lanternLight.GetComponent<ParticleSystem>();
		this.par = component;
		Transform transform2 = this.lanternLight.transform;
		int num = 0;
		this.UseEnergy(num);
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00064360 File Offset: 0x00062560
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x448060", Offset = "0x446660", VA = "0x180448060")]
	public void UseEnergy(int cost)
	{
		GameObject gameObject = this.lanternLight;
		int num = 0;
		if (!(gameObject == num))
		{
			int num2 = this.attributeCount;
			GameObject gameObject2 = this.lanternLight;
			num2 -= cost;
			this.attributeCount = num2;
			if (num2 > 0)
			{
				ulong num3;
				gameObject2.SetActive(num3 != 0UL);
			}
			this.attributeCount = (int)((ulong)0L);
			int num4 = 0;
			gameObject2.SetActive(num4 != 0);
			this.recoverEnergyTimer = 5f;
			int num5 = this.maxEnergy;
			this.attributeCount = num5;
			if (0 * (int)0.1f <= (int)1f)
			{
			}
			ParticleSystem.MainModule main = this.par.main;
			ParticleSystem.MinMaxGradient minMaxGradient;
			Gradient gradientMax = minMaxGradient.m_GradientMax;
			float b = minMaxGradient.m_ColorMin.b;
			if (cost > 0)
			{
				base.FlashOnce();
			}
			base.UpdateText();
		}
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00064428 File Offset: 0x00062628
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x447850", Offset = "0x445E50", VA = "0x180447850", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int num = base.GetDamage(damage);
		num -= damage;
		this.UseEnergy(damage);
		return num;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x0006444C File Offset: 0x0006264C
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x447F10", Offset = "0x446510", VA = "0x180447F10", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		float num = this.recoverEnergyTimer;
		float deltaTime = Time.deltaTime;
		this.recoverEnergyTimer = num;
		this.recoverEnergyTimer = 1f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)22)))
		{
		}
		int num2 = this.shootingLevel;
		int num3 = this.theLevel;
		num2++;
		num3++;
		long num5;
		int num4 = (int)((long)(num2 * num3) * num5);
		this.UseEnergy(num4);
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x000644E4 File Offset: 0x000626E4
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x447B00", Offset = "0x446100", VA = "0x180447B00")]
	protected void RecoverEnergyUpdate()
	{
		float num = this.recoverEnergyTimer;
		float deltaTime = Time.deltaTime;
		this.recoverEnergyTimer = num;
		this.recoverEnergyTimer = 1f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)22)))
		{
		}
		int num2 = this.shootingLevel;
		int num3 = this.theLevel;
		num2++;
		num3++;
		long num5;
		int num4 = (int)((long)(num2 * num3) * num5);
		this.UseEnergy(num4);
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00064550 File Offset: 0x00062750
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x447790", Offset = "0x445D90", VA = "0x180447790", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00064590 File Offset: 0x00062790
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x447A30", Offset = "0x446030", VA = "0x180447A30", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x000645C0 File Offset: 0x000627C0
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x447980", Offset = "0x445F80", VA = "0x180447980", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x000645EC File Offset: 0x000627EC
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x4478B0", Offset = "0x445EB0", VA = "0x1804478B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x0006460C File Offset: 0x0006280C
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x448260", Offset = "0x446860", VA = "0x180448260")]
	public LanternUmbrella()
	{
	}

	// Token: 0x04000BCE RID: 3022
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BCE")]
	private float recoverEnergyTimer = 1f;

	// Token: 0x04000BCF RID: 3023
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000BCF")]
	public int maxEnergy = (int)((ulong)2000L);

	// Token: 0x04000BD0 RID: 3024
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BD0")]
	protected GameObject lanternLight;

	// Token: 0x04000BD1 RID: 3025
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BD1")]
	private Vector3 lightPos;

	// Token: 0x04000BD2 RID: 3026
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000BD2")]
	private ParticleSystem par;
}
