# Language Options
- [EN](#asteroids-game)
- [TR](#asteroids-oyunu)

# Asteroids Game

This project is a modern adaptation of the classic Asteroids game.

## Steps

### 1. Game Boundaries and Player Mechanics
- Controls are split into phone and keyboard.
- Developers can input both touch and keyboard controls for the player.

### 2. Bullet Mechanics

- A prefab for the bullet was created, and its mechanics were scripted.
- Bullets are drawn from an object pool for efficiency.
- The bullet firing function is defined in the player class.

### 3. Asteroid Mechanics

- Prefabs for asteroids were created.
- Asteroids are spawned randomly and procedurally.
- Asteroids are generated using a builder class with the builder pattern.
- When asteroids are destroyed, they split into two and are regenerated using the builder.

### 4. Player Death and Other Processes

- When the player dies, processes are managed by the game manager.
- Player death is handled using event-based programming and Unity events.
- A particle effect for explosions was added and managed as a single entity.
- Sound effects were managed using a similar logic.
- A star field effect was scripted for background management.

### 5. UI, GUI, Basic Mechanics

- Concepts of player life and score are presented with a HUD.
- Functions for toggling user interface panels on and off were defined.
- Basic mechanics of the game were added.

-----------------

# Asteroids Oyunu

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
