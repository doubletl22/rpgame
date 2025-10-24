🧩 1. Animations/

Chứa các tệp liên quan đến hoạt hình.

Characters/ – Animation Controller, Animation Clip cho nhân vật

Props/ – Animation cho đạo cụ, vật phẩm

UI/ – Animation cho giao diện người dùng

🎨 2. Art/

Chứa tất cả tài nguyên hình ảnh, mô hình và visual assets.

Characters/ – Sprites, Models 3D nhân vật

Effects/ – Visual Effects (VFX)

Environment/ – Tilesets, Backgrounds, Props môi trường

Fonts/ – File font chữ

UI/ – Sprites, Icons cho giao diện người dùng

🔊 3. Audio/

Chứa các tệp âm thanh của game.

Music/ – Nhạc nền

SFX/ – Hiệu ứng âm thanh (Sound Effects)

⚙️ 4. Editor/

Scripts dành riêng cho Unity Editor (tùy chỉnh Inspector, Tools, v.v.)

🎭 5. Prefabs/

Chứa các tệp prefab (GameObject mẫu).

Characters/ – Prefab nhân vật

Environment/ – Prefab môi trường

Items/ – Prefab vật phẩm

UI/ – Prefab giao diện người dùng

⚗️ 6. Presets/

Chứa các tệp Preset cho component hoặc các thiết lập sẵn.

🌍 7. Resources/

Tài nguyên load động (dùng Resources.Load() khi cần).

🧱 8. Scenes/

Chứa các tệp Scene (.unity).

Levels/ – Các màn chơi chính

Tests/ – Scene dùng để test, demo

📜 9. ScriptableObjects/

Chứa các instance của ScriptableObject.

Data/ – Dữ liệu game (stat, config, v.v.)

Settings/ – Các thiết lập hệ thống

💻 10. Scripts/

Chứa toàn bộ mã nguồn C# của dự án.

Core/ – Logic cốt lõi, hệ thống chính

Data/ – Định nghĩa dữ liệu, ScriptableObjects

Editor/ – Scripts mở rộng cho Editor

Features/ – Chia module theo chức năng (Player, Enemy, Inventory, v.v.)

Player/

Enemy/

Inventory/

System/ – Hệ thống quản lý (GameManager, AudioManager, v.v.)

UI/ – Script điều khiển giao diện

Shading/ – Shader và tài nguyên liên quan đến shader

📦 11. Third Party/

Tài nguyên từ Asset Store hoặc nguồn bên ngoài.

[Tên Asset Pack 1]/

[Tên Asset Pack 2]/

🧪 12. Tests/

Chứa scripts phục vụ kiểm thử.

Unit Tests

Play Mode Tests

🧰 Ghi chú

Giữ tên thư mục và file nhất quán (camelCase hoặc PascalCase).

Các script hệ thống (GameManager, AudioManager,...) nên đặt trong Scripts/System/.

Không nên đặt script trực tiếp trong Assets/.

Mỗi thư mục con chỉ nên chứa một loại tài nguyên cụ thể.
