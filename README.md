# Asteroids Game

Bu proje, klasik Asteroids oyununun modern bir uyarlamasıdır.

## Adımlar

### 1. Oyun Sınırları ve Player Mekanikleri
- Kontroller telefon ve klavye olarak bölündü.
- Gelşitirici player input ile hem touch hem de keyboard olarak farklı inputlar girebilir.

### 2. Kurşun Mekanikleri

- Kurşun için bir prefab oluşturuldu ve mekanikleri yazıldı.
- Bir nesne havuzundan çekilerek verimlilik sağlandı
- Kurşun fırlatma fonksiyonu oyuncu sınıfında tanımlandı.

### 3. Asteroid Mekanikleri

- Asteroidler için prefablar oluşturuldu.
- Asteroidler rastgele ve prosedürsel bir şekilde spawn edildi.
- Builder sınıf ile builder pattern kullanarak asteroidler oluşturuldu.
- Asteroidler yok olduğunda ikiye bölünerek ve yeniden builder kullanılarak oluşturuldu.

### 4. Oyuncu Ölümü ve Diğer İşlemler

- Oyuncu öldüğünde işlemler oyun yöneticisi tarafından yönetildi.
- Event bazlı programlama ve Unity events kullanılarak oyuncu ölümüne tepki verildi.
- Particle effect ile patlama efekti eklendi ve bu efekt tekil yapı olarak yönetildi.
- Ses efektleri benzer mantıkla yönetildi.
- Arka plan yönetimi için bir yıldız alanı efekti yazıldı.

### 5. UI, GUI, Temel mekanikler

- Oyuncu hayat ve skor kavramları HUD ile verildi.
- Kullanıcı arayüzü panelleri açık ve kapalı duruma getiren fonksiyonlar tanımlandı.
- Oyunun temel mekanikleri eklendi.
