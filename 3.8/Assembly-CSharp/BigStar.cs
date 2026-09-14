using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20002A7")]
public class BigStar : MonoBehaviour
{
	// Token: 0x06000BF7 RID: 3063 RVA: 0x000448C4 File Offset: 0x00042AC4
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x3CD840", Offset = "0x3CBE40", VA = "0x1803CD840")]
	public static void SetStar(BigStar.BigStarType bigStarType)
	{
		int num = 0;
		if (bigStarType == BigStar.BigStarType.DoomStar)
		{
			GameObject gameObject = Resources.Load<GameObject>("Items/DoomStar");
		}
		int num2 = 0;
		if (num != num2)
		{
			Transform transform = Board.Instance.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(num, transform).GetComponent<BigStar>().type = bigStarType;
		}
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00044918 File Offset: 0x00042B18
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x3CD970", Offset = "0x3CBF70", VA = "0x1803CD970")]
	private void Start()
	{
		if (this.zombie)
		{
			float num = this.speedX * -1f;
			this.speedX = num;
			Transform transform = base.transform;
		}
		uint num2;
		GameAPP.PlaySound((int)num2, 1f, 1f);
		Board instance = Board.Instance;
		int rowNum;
		if (instance.rowNum != 1)
		{
			rowNum = instance.rowNum;
			float boxYFromRow = Mouse.Instance.GetBoxYFromRow(rowNum);
		}
		Mouse instance2 = Mouse.Instance;
		int num3 = rowNum - 1;
		float boxYFromRow2 = instance2.GetBoxYFromRow(num3);
		Board instance3 = Board.Instance;
		Mouse instance4 = Mouse.Instance;
		int rowNum2 = instance3.rowNum;
		float num4 = instance4.GetBoxYFromRow(rowNum2) * 0.5f;
		this.minY = num4;
		Solar instance5 = Solar.Instance;
		int num5 = 0;
		if (instance5 != num5 && !this.zombie)
		{
			Transform transform2 = base.transform.Find("Particle System");
			int num6 = 0;
			if (transform2 != num6)
			{
				GameObject gameObject = transform2.gameObject;
				bool flag = !GameAPP.config.disableSolarStarEffect;
				gameObject.SetActive(flag);
			}
			this.sun = true;
		}
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00044A3C File Offset: 0x00042C3C
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x3CDC80", Offset = "0x3CC280", VA = "0x1803CDC80")]
	private void Update()
	{
		if (!this.isLand)
		{
			float deltaTime = Time.deltaTime;
			this.speedY = deltaTime;
			Transform transform = base.transform;
			float deltaTime2 = Time.deltaTime;
			Transform transform2 = base.transform;
			float num = this.speedX;
			float deltaTime3 = Time.deltaTime;
			int num2 = 0;
			int num3 = 0;
			float num4;
			transform2.Rotate((float)num3, (float)num2, num4);
			Transform transform3 = base.transform;
			Vector3 vector;
			if (this.minY > vector.y)
			{
				this.isLand = true;
				int num5 = 0;
				if ((this.zombie ? 1 : 0) != num5)
				{
					this.ZombieCrash();
					throw new NullReferenceException();
				}
				this.Crash();
			}
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00044AE4 File Offset: 0x00042CE4
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x3CDE40", Offset = "0x3CC440", VA = "0x1803CDE40")]
	private void ZombieCrash()
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num2;
		GameAPP.PlaySound((int)num2, 1f, 1f);
		ScreenShake.TriggerShake(0.15f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		int mask = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				LayerMask layerMask;
				int mask2 = layerMask.m_Mask;
				if (layerMask != 0)
				{
				}
			}
			num++;
		}
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform5 = bullet.transform;
		uint num3;
		bullet.Damage = (int)num3;
		num += 10;
		num++;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00044BC0 File Offset: 0x00042DC0
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x3CC970", Offset = "0x3CAF70", VA = "0x1803CC970")]
	private void Crash()
	{
		int num = 0;
		global::UnityEngine.Object.Destroy(base.gameObject);
		BigStar.BigStarType bigStarType = this.type;
		if (bigStarType == BigStar.BigStarType.SuperStar)
		{
		}
		if (bigStarType == BigStar.BigStarType.UltimateStar)
		{
		}
		int num2;
		int num3;
		num2 += num3;
		bool flag;
		if (flag)
		{
		}
		Collider2D[] array;
		if (this.type != BigStar.BigStarType.SolarStar)
		{
			if ((this.sun ? 1 : 0) != num)
			{
				CreateItem instance = CreateItem.Instance;
				Transform transform = base.transform;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				Vector3 vector;
				GameObject gameObject = instance.SetCoin(num6, num5, num4, num, vector, num != 0);
				num++;
			}
			Transform transform2 = base.transform;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			if (num >= array.Length)
			{
				goto IL_013D;
			}
			bool flag2;
			if (flag2)
			{
				PlantType plantType = this.fromType;
			}
			num++;
		}
		if ("{il2cpp array field local50->}" != num)
		{
			Player player = PlayerShootingManager.Instance.player;
		}
		if (array[9] > 0)
		{
			Collider2D collider2D = array[9];
			int num7 = 0;
			Zombie zombie;
			if (zombie != num7 && (zombie.isMindControlled ? 1 : 0) == num && zombie.theStatus != ZombieStatus.Dying)
			{
				PlantType plantType2 = this.fromType;
			}
		}
		CreateItem instance2 = CreateItem.Instance;
		Transform transform3 = base.transform;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		Vector3 vector2;
		GameObject gameObject2 = instance2.SetCoin(num10, num9, num8, num, vector2, num != 0);
		num++;
		IL_013D:
		uint num11;
		GameAPP.PlaySound((int)num11, 1f, 1f);
		if (this.type == BigStar.BigStarType.SuperStar)
		{
			Transform transform4 = base.transform;
			GameObject gameObject3;
			Transform transform5 = gameObject3.transform;
			if ((GameAPP.config.distablexplodeFlash ? 1 : 0) == num)
			{
				Transform transform6 = base.transform;
			}
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform7 = base.transform;
		}
		ParticleManager instance4 = ParticleManager.Instance;
		Transform transform8 = base.transform;
		ParticleManager instance5 = ParticleManager.Instance;
		Transform transform9 = base.transform;
		Transform transform10 = base.transform;
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00044D90 File Offset: 0x00042F90
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x3CD390", Offset = "0x3CB990", VA = "0x1803CD390")]
	private void CreateStars(BulletType bulletType)
	{
		if (this.type <= BigStar.BigStarType.SolarStar)
		{
		}
		if (this.bulletDamage != (ulong)0L)
		{
		}
		int num = 0;
		int num2;
		if (this.type != BigStar.BigStarType.SuperStar)
		{
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			Transform transform3 = bullet.transform;
			bullet.Damage = num2;
			PlantType plantType = this.fromType;
			num += 10;
			bullet.fromType = plantType;
			num++;
			return;
		}
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet2;
		Transform transform6 = bullet2.transform;
		bullet2.Damage = num2;
		bullet2.theStatus = (BulletStatus)((ulong)4L);
		PlantType plantType2 = this.fromType;
		bullet2.fromType = plantType2;
		throw new NullReferenceException();
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00044E4C File Offset: 0x0004304C
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x3CE380", Offset = "0x3CC980", VA = "0x1803CE380")]
	public BigStar()
	{
	}

	// Token: 0x040007E9 RID: 2025
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E9")]
	private readonly float g = -9.8f;

	// Token: 0x040007EA RID: 2026
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007EA")]
	private float speedX = 7f;

	// Token: 0x040007EB RID: 2027
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007EB")]
	private float speedY;

	// Token: 0x040007EC RID: 2028
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007EC")]
	private bool isLand;

	// Token: 0x040007ED RID: 2029
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007ED")]
	private float minY;

	// Token: 0x040007EE RID: 2030
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007EE")]
	public BigStar.BigStarType type;

	// Token: 0x040007EF RID: 2031
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007EF")]
	public bool zombie;

	// Token: 0x040007F0 RID: 2032
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40007F0")]
	public int baseDamage = (int)((ulong)1800L);

	// Token: 0x040007F1 RID: 2033
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007F1")]
	public int? bulletDamage;

	// Token: 0x040007F2 RID: 2034
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007F2")]
	public int skinType;

	// Token: 0x040007F3 RID: 2035
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40007F3")]
	private bool sun;

	// Token: 0x040007F4 RID: 2036
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007F4")]
	public PlantType fromType;

	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	public enum BigStarType
	{
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		Default,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		SuperStar,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		UltimateStar,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		IronStar,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		PickaxeStar,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		SolarStar,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		DoomStar
	}
}
