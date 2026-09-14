using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class DamageHUD : MonoBehaviour
{
	// Token: 0x06000C45 RID: 3141 RVA: 0x00046B60 File Offset: 0x00044D60
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x3D3140", Offset = "0x3D1740", VA = "0x1803D3140")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.text = component;
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00046B7C File Offset: 0x00044D7C
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x3D32F0", Offset = "0x3D18F0", VA = "0x1803D32F0")]
	private void Update()
	{
		int num = 0;
		Bullet bullet = this.follow;
		int num2 = 0;
		if (!(bullet == num2))
		{
			Bullet bullet2 = this.follow;
			TextMeshProUGUI textMeshProUGUI = this.text;
			if ((bullet2.board.showBulletDamage ? 1 : 0) == num)
			{
			}
			bool activeSelf = bullet2.gameObject.activeSelf;
			textMeshProUGUI.enabled = activeSelf;
			if (this.text.enabled)
			{
				Transform transform = base.transform;
				Transform transform2 = this.follow.transform;
				Vector3 vector;
				float z = vector.z;
				Transform transform3 = base.transform;
				Transform transform4 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				Vector3 vector3;
				float z3 = vector3.z;
				Bullet bullet3 = this.follow;
				TextMeshProUGUI textMeshProUGUI2 = this.text;
				int damage = bullet3._damage;
				string text;
				textMeshProUGUI2.text = text;
			}
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00046C58 File Offset: 0x00044E58
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x3D3190", Offset = "0x3D1790", VA = "0x1803D3190")]
	private void PositionUpdate()
	{
		Transform transform = base.transform;
		Transform transform2 = this.follow.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00046CAC File Offset: 0x00044EAC
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public DamageHUD()
	{
	}

	// Token: 0x0400086A RID: 2154
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400086A")]
	public Bullet follow;

	// Token: 0x0400086B RID: 2155
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400086B")]
	public TextMeshProUGUI text;
}
