# 🚗 IVehicle interfeysi va Car klassi - C# loyihasi

Bu kichik C# dasturida **IVehicle** interfeysi yaratilgan bo‘lib, u ikkita metodni o‘z ichiga oladi:  
- `Drive()` – mashinani harakatga keltiradi  
- `Refuel(int amount)` – mashinaga benzin quyadi

## 🛠 Loyihaning tarkibi

- **IVehicle interfeysi** – `Drive` va `Refuel` metodlarini belgilaydi.
- **Car klassi** – IVehicle interfeysini implement qiladi va benzin miqdorini boshqaradi.
- **Main metodi** – foydalanuvchidan benzin miqdorini so‘rab, avtomobilni haydaydi.

## 🧪 Ishlash tartibi

1. Dasturni ishga tushiring.
2. Konsolda "Necha litr benzin quymoqchisiz?" degan savol chiqadi.
3. Benzin miqdorini kiriting (masalan: `5`).
4. Agar benzin > 0 bo‘lsa, konsolga `"Driving"` yozuvi chiqadi.
5. Aks holda `"Yoqilg‘i yo‘q, hayday olmaysiz."` degan xabar chiqadi.

## 💻 Ishga tushirish

1. Visual Studio yoki boshqa C# muharrirda `.cs` faylni oching.
2. `Ctrl + F5` bosib dasturni ishga tushiring.

## 📂 Namuna

```text
Necha litr benzin quymoqchisiz? 5
Driving
```
