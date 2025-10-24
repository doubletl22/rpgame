Assets/ ├── 📁 Animations/ # File Animation Controller, Animation Clip │ ├── 📁 Characters/ │ ├── 📁 Props/ │ └── 📁 UI/ ├── 📁 Art/ # Tài nguyên hình ảnh, model 3D │ ├── 📁 Characters/ # Sprites, Models nhân vật │ ├── 📁 Effects/ # Visual Effects (VFX) │ ├── 📁 Environment/ # Tilesets, Backgrounds, Props môi trường │ ├── 📁 Fonts/ # File font chữ │ └── 📁 UI/ # Sprites, Icons cho giao diện người dùng ├── 📁 Audio/ # Âm thanh │ ├── 📁 Music/ # Nhạc nền │ └── 📁 SFX/ # Hiệu ứng âm thanh (Sound Effects) ├── 📁 Editor/ # Scripts dành riêng cho Unity Editor ├── 📁 Materials/ # Files Material ├── 📁 Prefabs/ # File Prefab │ ├── 📁 Characters/ │ ├── 📁 Environment/ │ ├── 📁 Items/ │ └── 📁 UI/ ├── 📁 Presets/ # File Preset cho component hoặc setting ├── 📁 Resources/ # Tài nguyên load động (chỉ dùng khi cần) ├── 📁 Scenes/ # Các file Scene (.unity) │ ├── 📁 Levels/ │ └── 📁 Tests/ # Scene dùng để test ├── 📁 ScriptableObjects/ # File ScriptableObject Instances │ ├── 📁 Data/ │ └── 📁 Settings/ ├── 📁 Scripts/ # Mã C# │ ├── 📁 Core/ # Logic cốt lõi, hệ thống chung │ ├── 📁 Data/ # Định nghĩa dữ liệu, ScriptableObjects │ ├── 📁 Editor/ # (Có thể để ở thư mục Editor/ gốc) │ ├── 📁 Features/ # Sắp xếp theo tính năng (Player, Enemy, Inventory,...) │ │ ├── 📁 Player/ │ │ ├── 📁 Enemy/ │ │ └── 📁 Inventory/ │ ├── 📁 System/ # Các hệ thống quản lý (GameManager, AudioManager,...) │ └── 📁 UI/ # Scripts điều khiển UI ├── 📁 Settings/ # File cấu hình (Input Actions, Render Pipeline Assets,...) ├── 📁 Shaders/ # File Shader ├── 📁 ThirdParty/ # Tài nguyên từ Asset Store hoặc nguồn bên ngoài │ ├── 📁 [Tên Asset Pack 1]/ │ └── 📁 [Tên Asset Pack 2]/ └── 📁 Tests/ # Scripts cho Unit Test, Play Mode Test


## Giải Thích Các Thư Mục Chính

* **`Animations`**: Chứa các Animation Controller và Animation Clip, phân loại theo đối tượng (Nhân vật, Đồ vật, UI).
* **`Art`**: Chứa tất cả tài nguyên nghệ thuật trực quan như sprites, models 3D, textures, fonts, hiệu ứng hình ảnh (VFX). Được phân loại chi tiết hơn bên trong.
* **`Audio`**: Chứa tài nguyên âm thanh, chia thành nhạc nền (`Music`) và hiệu ứng âm thanh (`SFX`).
* **`Editor`**: Chứa các script C# chỉ chạy trong môi trường Unity Editor (ví dụ: custom inspectors, editor windows).
* **`Materials`**: Chứa các file Material dùng để áp dụng lên renderer của GameObject.
* **`Prefabs`**: Chứa các GameObject đã được cấu hình sẵn (Prefabs), phân loại theo chức năng hoặc loại đối tượng.
* **`Presets`**: Chứa các file Preset để lưu trữ cấu hình mặc định cho các component hoặc setting.
* **`Resources`**: Chứa các tài nguyên cần được load động bằng `Resources.Load()`. **Lưu ý**: Chỉ sử dụng khi thực sự cần thiết vì tất cả tài nguyên trong thư mục này sẽ được đóng gói vào bản build cuối cùng.
* **`Scenes`**: Chứa các file Scene (`.unity`) của game, có thể chia thành các màn chơi chính (`Levels`), menu, hoặc scene thử nghiệm (`Tests`).
* **`ScriptableObjects`**: Chứa các instance của ScriptableObject, thường dùng để lưu trữ dữ liệu hoặc cấu hình tách biệt khỏi scene.
* **`Scripts`**: Chứa toàn bộ mã nguồn C# của dự án. Nên phân cấp theo tính năng (`Features`) hoặc vai trò (`Core`, `System`, `UI`) để dễ quản lý.
* **`Settings`**: Chứa các file cấu hình của dự án như Input Actions, Render Pipeline Assets, Post-processing Profiles,...
* **`Shaders`**: Chứa các file shader tùy chỉnh.
* **`ThirdParty` / `Plugins`**: Chứa các asset pack hoặc thư viện từ Asset Store hoặc các nguồn bên ngoài khác. Mỗi asset nên nằm trong thư mục con riêng. **Quan trọng**: Tránh sửa đổi trực tiếp nội dung trong này.
* **`Tests`**: Chứa các script dùng cho Unity Test Framework (Play Mode và Edit Mode tests).

## Quy Tắc Chung

* **Đặt tên nhất quán**: Sử dụng quy tắc đặt tên rõ ràng và nhất quán (ví dụ: PascalCase cho thư mục và file C#).
* **Tránh tài nguyên rời rạc**: Không nên để các file asset nằm trực tiếp dưới thư mục `Assets/` gốc mà không thuộc thư mục con nào.
* **Quản lý phiên bản**: Sử dụng hệ thống quản lý phiên bản (như Git) và đảm bảo commit cả file `.meta` tương ứng với mỗi asset.

Bằng cách tuân thủ cấu trúc này, dự án sẽ dễ dàng quản lý, mở rộng và bảo trì hơn.
