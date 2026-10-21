#if false
namespace PvZ_Fusion_Translator.AssetStore;

public static class WarningStore
{
    private static readonly Dictionary<string, (string, string)> s_warningMessages = new()
    {
        {
            "English",
            ("""
             <size=10>The only valid source of this translation is from this community:
             <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. If you got this <i>anywhere</i> else like 
             <color=#8B0000>Plants Hybrid</color> and <color=#8B0000>superhybrid.online</color>, they stole it.
             Stray away from other sources as they may contain viruses.
             Please visit our community for future updates.</size>
             """, "Okay! Got it.")
        },
        {
            "French",
            ("""
             <size=9.5>La seule source valide pour cette traduction provient de cette
             communauté :<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si vous l'avez obtenue 
             <i>ailleurs</i>, comme <color=#8B0000>Plants Hybrid</color> ou <color=#8B0000>superhybrid.online</color>, ils l'ont volée.
             Évitez les autres sources, car elles peuvent contenir des virus.
             Veuillez visiter notre communauté pour les mises à jour futures.
             """, "D'accord !")
        },
        {
            "Italian",
            ("""
             <size=10>L'unica fonte valida di questa traduzione è questa community:
             <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se l'hai ottenuta <i>altrove</i>, come 
             <color=#8B0000>Plants Hybrid</color> e <color=#8B0000>superhybrid.online</color>, l'hanno rubata.
             Evita altre fonti, potrebbero contenere virus.
             Visita la nostra community per aggiornamenti futuri.</size>
             """, "Va bene! Ho capito.")
        },
        {
            "German",
            ("""
             <size=10>Die einzige gültige Quelle für diese Übersetzung stammt aus
             dieser Community: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Wenn Sie diese 
             <i>irgendwo</i> anders gefunden haben, z. B. bei <color=#8B0000>Plants Hybrid</color> oder 
             <color=#8B0000>superhybrid.online</color>, dann haben sie sie gestohlen.
             Meiden Sie andere Quellen, da diese Viren enthalten könnten.
             Bitte besuchen Sie unsere Community für zukünftige Updates.
             """, "Okay, verstanden!")
        },
        {
            "Spanish",
            ("""
             <size=10>La única fuente válida de esta traducción proviene de esta
             comunidad: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si la obtuvo <i>en cualquier</i>
             otro lugar como <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, la robaron.
             Manténgase alejado de otras fuentes, ya que podrían contener virus.
             Por favor, visite nuestra comunidad para futuras actualizaciones.
             """, "¡Entendido!")
        },
        {
            "Portuguese",
            ("""
             <size=10>O lugar original e seguro dessa tradução vem daqui:
             <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se você baixou ela de <i>qualquer 
             lugar</i> como <color=#8B0000>Plants Hybrid</color> ou <color=#8B0000>superhybrid.online</color>, eles
             roubaram. Evite baixar deles, pode conter vírus.
             Por favor, visite nossa comunidade para atualizações futuras.</size>
             """, "Okay, entendido.")
        },
        {
            "Filipino",
            ("""
             <size=9>Ang tanging opisyal na source ng pagsasaling ito ay mula
             lamang dito: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Kung nakuha nmo ito <i>kahit 
             saan pa</i> tulad ng <color=#8B0000>Plants Hybrid</color> at <color=#8B0000>superhybrid.online</color>, ito ay ninakaw. 
             Lumayo sa ibang source dahil posibleng may kasamang virus.
             Paki-bisita ang aming komunidad para sa mga darating na update.</size>
             """, "Naiintindihan!")
        },
        {
            "Vietnamese",
            ("""
             <size=8>Nguồn duy nhất hợp lệ của bản dịch này là từ cộng
             đồng này: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Nếu bạn nhận 
             được nó <i>ở bất cứ nơi nào</i> khác như <color=#8B0000>Plants Hybrid</color> 
             hoặc <color=#8B0000>superhybrid.online</color>, họ đã ăn cắp nó.
             Tránh xa các nguồn khác vì chúng có thể chứa 
             virus. Hãy ghé thăm cộng đồng của chúng tôi để 
             cập nhật trong tương lai.</size>
             """, "Đồng ý!")
        },
        {
            "Indonesian",
            ("""
             <size=10>Satu-satunya sumber resmi dari terjemahan ini adalah 
             komunitas kami: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Jika Anda 
             mendapatkannya dari <i>sumber lain</i> seperti <color=#8B0000>Plants Hybrid</color> 
             dan <color=#8B0000>superhybrid.online</color>, mereka mencurinya. 
             Jauhi sumber lain karena mungkin ada virus.
             Silakan kunjungi komunitas kami untuk pembaruan berikutnya.</size>
             """, "Oke! Mengerti.")
        },
        {
            "Russian", ("""
                        <size=9>Единственный проверенный источник этого перевода —
                        сообщество <color=#E6E6FA>discord.gg/DPAC5ZVJ8T</color>.
                        Или же его замена <color=#E6E6FA>https://t.me/nekoshkindom</color>
                        Если вы скачали этот мод <i>где-либо ещё</i>, возможно он содержит вирусы.
                        Программист перевода: LancerX0.
                        Переводчик: Nekosha.
                        """, "Хорошо!")
        },
        {
            "Japanese", ("""
                         <size=6>この翻訳の唯一の有効なソースは、このコミュニティからです：
                         <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>.<color=#8B0000>Plants Hybrid</color>や<color=#8B0000>superhybrid.online</color>、
                         <color=#8B0000>YoutubeのBlue Fly</color>が作っているもの、他のどこかでこれを入手した場合、
                         彼らはそれを盗んだことになります。ウイルスが含まれている可能性があるので、
                         他のソースからは離れてください。今後のアップデートについては、
                         私たちのコミュニティをご覧ください。</size>
                         """,
                "了解しました！")
        },
        {
            "Korean", ("""
                       <size=8>이 번역은 Bloom(<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>)에서만
                       제공됩니다. Bloom 디스코드 이외의 다른</i>서드 파티 사이트, 
                       예를 들어 <color=#8B0000>Plants Hybrid</color> 및 <color=#8B0000>superhybrid.online</color>, 또는
                       <color=#8B0000>유튜브 Blue Fly</color>등에서 제공하는 파일은 무단으로 재배포된 것이며,
                       이런 사이트들에는 바이러스가 포함되어 있을 가능성이 높습니다. 
                       향후 업데이트를 위해 저희 디스코드를 방문해 주세요.
                       """,
                "확인")
        },
        {
            "Javanese", ("""
                         <size=10>Sumber mung sing sah kanggo terjemahan iki saka komunitas iki:
                         <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Yen sampeyan nemokake iki <i>ing papan
                         liya</i> kaya <color=#8B0000>Plants Hybrid</color> lan <color=#8B0000>superhybrid.online</color>, iku dicolong.
                         Aja nyedhaki sumber liya amarga bisa ngandhut virus. Mangga
                         ngunjungi komunitas kita kanggo nganyari ing mangsa ngarep.</size>
                         """,
                "Oke! Ngertos.")
        },
        {
            "Polish", ("""
                       <size=8>Jedynym wiarygodnym źródłem tego tłumaczenia jest ta społeczność:
                       <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Jeśli znalazłeś to <i>gdziekolwiek</i> indziej, np. 
                       <color=#8B0000>Plants Hybrid</color> i <color=#8B0000>superhybrid.online</color>, ukradli to.
                       Omijaj inne źródła, ponieważ mogą zawierać wirusy.
                       Odwiedź naszą społeczność, aby uzyskać przyszłe aktualizacje.</size>
                       """,
                "Okay! Rozumiem.")
        },
        {
            "Hungarian", (
                """
                <size=8>Ennek a fordításnak az egyetlen érvényes forrása ebből a közösségből származik:
                <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Ha ezt <i>valahol</i> máshol szerezted, például 
                <color=#8B0000>Plants Hybrid</color> és <color=#8B0000>superhybrid.online</color> oldalakon, akkor ők lopták.
                Kerüld a többi forrást, mert vírusokat tartalmazhatnak.
                Kérjük, látogass el közösségünkbe a jövőbeli frissítésekért.</size>
                """,
                "Oké! Értem.")
        },
        {
            "Arabic", ("""
                       <size=10>The only valid source of this translation is from this community:
                       <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. If you got this <i>anywhere</i> else like 
                       <color=#8B0000>Plants Hybrid</color> and <color=#8B0000>superhybrid.online</color>, they stole it.
                       Stray away from other sources as they may contain viruses.
                       Please visit our community for future updates.</size>
                       """,
                "Okay! Got it.")
        },
        // { "OTHER" , ("<size=10>A única fonte válida dessa tradução é desta\ncomunidade: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se você obteve \nisso <i>em qualquer lugar</i> como <color=#8B0000>Plants Hybrid</color>\ne <color=#8B0000>superhybrid.online</color>,ou Blue Fly do Youtube,\nelses roubaram. Fique longe de sites falsos. Por favor,\nvisite nossa comunidade para futuras atualizações.</size>", "¡Okei! Entendido.") },
        // { "OTHER" , ("<size=9.5>Ang translation na ito ay galing dito lamang:\n<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Pag nakuha niyo ito <i>sa iba pa</i>\nkagaya ng <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, anumang\nginawagawa ng <color=#8B0000>Blue Fly mula sa Youtube</color>, o anumang\n<color=#8B0000>Sub2Unlock links</color>, scam sila. MAG INGAT dahil\nkasi baka may virus 'jan. Join kayo sa discord namin!\nFilipino Translation by ColinPogi</size>", "Tayo magsi-laro!") },
    };

    public static bool IsWarningMessageLoaded { get; set; }

    public static string WarningMessage { get; set; } =
        "<size=10>La única fuente válida de esta traducción proviene de esta\ncomunidad: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si la obtuvo <i>en cualquier</i>\notro lugar como <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, la robaron.\nManténgase alejado de otras fuentes, ya que podrían contener virus.\nPor favor, visite nuestra comunidad para futuras actualizaciones.";

    public static string OkayButton { get; set; } = "¡Entendido!";

    // ReSharper disable once UnusedTupleComponentInReturnValue
    public static (string, string) GetWarningMessage(Utils.LanguageEnum language)
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));

        return s_warningMessages.TryGetValue(language.ToString(), out var message)
            ? message
            : s_warningMessages["English"]; // Default to English if language code is not found
    }

    public static void WarningLoad(NoticeMenu noticeMenu)
    {
        if (noticeMenu == null || noticeMenu.transform == null)
        {
            Log.LogWarning("[WarningStore] NoticeMenu or transform is null - ABORTING");
            return;
        }

        if (!ModFeatures.IsMultiLanguage)
            return;

        try
        {
            var (localizedWarningMessage, _) = GetWarningMessage(Utils.Language);
            var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform warningTransform = noticeMenu.transform.Find("窗口");

            if (warningTransform == null)
            {
                Log.LogWarning("[WarningStore] '窗口' transform not found - ABORTING");
                return;
            }

            var warningTextTransform = warningTransform.Find("文字");
            var warningTextShadowTransform = warningTransform.Find("文字2");

            if (warningTextTransform == null || warningTextShadowTransform == null)
            {
                Log.LogWarning("[WarningStore] Could not find text components (文字/文字2)");
                return;
            }

            var warningText = warningTextTransform.GetComponent<TextMeshProUGUI>();
            var shadowText = warningTextShadowTransform.GetComponent<TextMeshProUGUI>();

            if (warningText == null || shadowText == null)
            {
                Log.LogWarning("[WarningStore] TextMeshProUGUI components missing");
                return;
            }

            warningText.text = localizedWarningMessage;
            shadowText.text = localizedWarningMessage;

            if (fontAsset != null)
            {
                warningText.font = fontAsset;
                shadowText.font = fontAsset;
            }
            else
                Log.LogWarning("[WarningStore] Font asset is null");

            Log.LogInfo("Warning message loaded successfully!");
        }
        catch (Exception e)
        {
            Log.LogError($"Critical error in WarningLoad: {e}");
        }
    }

    public static void WarningReload(Utils.LanguageEnum language, NoticeMenu noticeMenu)
    {
        if (!ModFeatures.IsMultiLanguage)
        {
            if (IsWarningMessageLoaded)
                return;

            WarningStore.WarningLoad();
            IsWarningMessageLoaded = true;
            return;
        }

        if (noticeMenu == null)
        {
            Log.LogWarning("[WarningStore] NoticeMenu is null in WarningReload");
            return;
        }

        if (Utils.OldLanguage.ToString() == language.ToString() && Utils.OldLanguage.ToString() != "English")
            return;

        if (IsWarningMessageLoaded)
            return;

        WarningLoad(noticeMenu);
        IsWarningMessageLoaded = true;
    }
}
#endif
