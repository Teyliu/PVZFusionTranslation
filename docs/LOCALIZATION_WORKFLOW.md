# PvZ Fusion - Complete Offline Localization Workflow

> Tài liệu quy trình trích xuất toàn diện chuỗi văn bản trong game PvZ Fusion (IL2CPP + Unity Assets) và đối chiếu tự động với kho bản dịch hiện có.

---

## 1. Tổng quan & Vấn đề giải quyết

| Vấn đề của Runtime Screen Dump (`DumpUntranslatedStrings`) | Giải pháp Offline Extraction Pipeline |
|---|---|
| **Bỏ sót text**: Chỉ bắt được text khi người chơi kích hoạt trên màn hình (bỏ sót ải ẩn, mode bí mật, dialog hiếm). | **Độ phủ 100%**: Quét trực tiếp string literal trong `global-metadata.dat` và toàn bộ `TextAsset` trong `data.unity3d`. |
| **Spam rác regex**: Mỗi giây sinh ra hàng chục dòng với các con số khác nhau (Time, Points, Level, HP, CD...). | **Gom nhóm Regex thông minh**: Tự động nhận diện số động (`\\d+`) và tạo template placeholder `{0}`, `{1}` chuẩn StringStore. |
| **I/O Overhead**: Ghi file liên tục khi render text gây giật/lag game. | **Tốc độ cực nhanh**: Chạy độc lập ngoài game, quét và diff 5,000+ chuỗi chỉ trong **5 - 10 giây**. |
| **Format hỗn loạn**: Không tự tạo cấu trúc cho Plant/Zombie Almanac hay Buffs. | **Xuất cấu trúc chuẩn**: Tự sinh stub JSON đầy đủ (`seedType`, `introduce`, `info`, `cost`) cho plant/zombie mới. |

---

## 2. Kiến trúc & Nguồn dữ liệu

```
┌─────────────────────────────────────────────────────────────┐
│                       Game 3.9 Files                        │
│                                                             │
│  1. global-metadata.dat ──► 100% C# String Literals (IL2CPP)│
│  2. data.unity3d        ──► TextAssets, Almanac, Dialogues  │
└──────────────────────────────┬──────────────────────────────┘
                               │
                               ▼
┌─────────────────────────────────────────────────────────────┐
│           scripts/extract_strings.py (Offline Tool)         │
│                                                             │
│  • CJK Filter & Anti-Mojibake Sanitation                    │
│  • Auto-Regex Clustering (Numbers -> {0}, {1})              │
│  • Multi-Encoding Reference Loader (UTF-8, UTF-16, UTF-8-SIG│
│  • Diffing against Existing Localization                    │
└──────────────────────────────┬──────────────────────────────┘
                               │
                               ▼
┌─────────────────────────────────────────────────────────────┐
│              Localization_Delta/ (Output Files)             │
│                                                             │
│  • untranslated_strings.json   (Chuỗi tĩnh mới cần dịch)    │
│  • untranslated_regex.json     (Template regex mới sinh)    │
│  • missing_almanac_plants.json (Stub plant mới, e.g. ID 843)│
│  • missing_almanac_zombies.json(Stub zombie mới)            │
└─────────────────────────────────────────────────────────────┘
```

---

## 3. Hướng dẫn sử dụng

### 3.1. Chạy mặc định
Mở terminal tại thư mục gốc của repository:
```bash
python scripts/extract_strings.py
```

### 3.2. Chạy với tham số tùy chỉnh
```bash
python scripts/extract_strings.py \
  --game-path "D:\PvZ Fusion\BepInEx Game Files" \
  --loc-path "D:\VSCode\PVZF-Translation\PvZ_Fusion_Translator\Localization\Vietnamese" \
  --out-path "Localization_Delta"
```

---

## 4. Kết quả trích xuất thực tế (Game 3.9)

- **Tổng chuỗi tiếng Trung trong Game 3.9:** `3,521` chuỗi sạch.
- **Đã có bản dịch đối chiếu (Exact + Regex Match):** `~80%` (2,742 chuỗi).
- **Lượng chuỗi mới thực sự cần dịch (Delta ~20%):**
  - `untranslated_strings.json`: **779 chuỗi tĩnh mới**.
  - `untranslated_regex.json`: **649 template regex mới**.
  - `missing_almanac_plants.json`: **28 cây mới** (bao gồm `seedType=843`).

---

## 5. Quy trình Merge bản dịch sau khi dịch xong

1. Mở các file trong thư mục `Localization_Delta/`.
2. Điền bản dịch tiếng Việt vào:
   - Trong `untranslated_strings.json`: Điền value cho từng key tiếng Trung.
   - Trong `missing_almanac_plants.json`: Dịch `name`, `introduce`, `info`, `cost`.
3. Merge nội dung:
   - Copy key-value đã dịch vào `translation_strings.json` hoặc `translation_regexs.json`.
   - Copy mảng plant vào `LawnStringsTranslate.json`.
4. Khởi động lại game để nạp bản dịch mới mà không cần chơi thử để bắt string.
