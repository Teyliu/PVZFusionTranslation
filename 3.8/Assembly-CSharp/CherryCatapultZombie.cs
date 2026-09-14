using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200063C RID: 1596
[Token(Token = "0x200063C")]
public class CherryCatapultZombie : CatapultZombie
{
	// Token: 0x06001E57 RID: 7767 RVA: 0x000A23EC File Offset: 0x000A05EC
	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x538660", Offset = "0x536C60", VA = "0x180538660", Slot = "74")]
	protected override void AnimShoot()
	{
		Plant target = this._target;
		int num = 0;
		if (!(target == num))
		{
			Transform transform = base.transform.Find("shoot");
			Vector3 vector;
			float z = vector.z;
			CreateBullet instance = CreateBullet.Instance;
			int num2 = 0;
			Bullet bullet;
			uint num3;
			bullet.Damage = (int)num3;
			this._target = num2;
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			int basketballNum = this.basketballNum;
			if (basketballNum != 0)
			{
				if (basketballNum != 0)
				{
					if (basketballNum != 0)
					{
						if (basketballNum != 0)
						{
							if (basketballNum != 1)
							{
								if (basketballNum != 0)
								{
									if (basketballNum != 0)
									{
										if (basketballNum != 0)
										{
											if (basketballNum != 0)
											{
												if (basketballNum != 1)
												{
													return;
												}
												uint num5;
												SpriteRenderer component = base.transform.GetChild((int)num5).GetComponent<SpriteRenderer>();
												int num6 = 0;
												component.enabled = num6 != 0;
												uint num7;
												Transform child = base.transform.GetChild((int)num7);
												int num8 = 0;
												ulong num9;
												child.GetChild(num8).GetComponent<SpriteRenderer>().enabled = num9 != 0UL;
											}
											uint num10;
											SpriteRenderer component2 = base.transform.GetChild((int)num10).GetComponent<SpriteRenderer>();
											int num11 = 0;
											component2.enabled = num11 != 0;
											uint num12;
											Transform child2 = base.transform.GetChild((int)num12);
											int num13 = 0;
											ulong num14;
											child2.GetChild(num13).GetComponent<SpriteRenderer>().enabled = num14 != 0UL;
										}
										uint num15;
										SpriteRenderer component3 = base.transform.GetChild((int)num15).GetComponent<SpriteRenderer>();
										int num16 = 0;
										component3.enabled = num16 != 0;
										uint num17;
										Transform child3 = base.transform.GetChild((int)num17);
										int num18 = 0;
										ulong num19;
										child3.GetChild(num18).GetComponent<SpriteRenderer>().enabled = num19 != 0UL;
									}
									uint num20;
									SpriteRenderer component4 = base.transform.GetChild((int)num20).GetComponent<SpriteRenderer>();
									int num21 = 0;
									component4.enabled = num21 != 0;
									uint num22;
									Transform child4 = base.transform.GetChild((int)num22);
									int num23 = 0;
									ulong num24;
									child4.GetChild(num23).GetComponent<SpriteRenderer>().enabled = num24 != 0UL;
								}
								ulong num25;
								this.anim.SetBool("shoot2", num25 != 0UL);
								uint num26;
								SpriteRenderer component5 = base.transform.GetChild((int)num26).GetComponent<SpriteRenderer>();
								int num27 = 0;
								component5.enabled = num27 != 0;
								uint num28;
								Transform child5 = base.transform.GetChild((int)num28);
								int num29 = 0;
								ulong num30;
								child5.GetChild(num29).GetComponent<SpriteRenderer>().enabled = num30 != 0UL;
								uint num31;
								SpriteRenderer component6 = base.transform.GetChild((int)num31).GetComponent<SpriteRenderer>();
								int num32 = 0;
								component6.enabled = num32 != 0;
								uint num33;
								Transform child6 = base.transform.GetChild((int)num33);
								int num34 = 0;
								ulong num35;
								child6.GetChild(num34).GetComponent<SpriteRenderer>().enabled = num35 != 0UL;
							}
							uint num36;
							GameObject gameObject = base.transform.GetChild((int)num36).gameObject;
							int num37 = 0;
							gameObject.SetActive(num37 != 0);
							return;
						}
						Transform transform2 = base.transform;
					}
					Transform transform3 = base.transform;
				}
				Transform transform4 = base.transform;
			}
			this.anim.SetTrigger("walk2");
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000A26B8 File Offset: 0x000A08B8
	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x5385A0", Offset = "0x536BA0", VA = "0x1805385A0")]
	public CherryCatapultZombie()
	{
		this.basketballNum = (int)((ulong)25L);
		base..ctor();
	}
}
