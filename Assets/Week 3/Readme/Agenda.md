# Agenda Phát Triển Game Week 3

## 1. Tìm Thêm 5 Characters Cho Game

- Nghiên cứu và chọn 5 nhân vật mới để thêm vào game.
- Tìm kiếm các nhân vật có phong cách và khả năng phù hợp với lối chơi của game.
- Đảm bảo rằng các nhân vật này được tối ưu hóa cho hiệu suất.

## 2. Gắn Animation Chạy (Run) Vào Cho 5 Characters Mới

- Gắn animation chạy mặc định vào từng nhân vật mới.
- Kiểm tra xem các animation có tương thích và hoạt động mượt mà trên các nhân vật.

## 3. Lần Lượt Gắn 3 Animation Chạy Khác Nhau Vào Animator

- Gắn ba animation chạy khác nhau vào hệ thống Animator của Unity.
- Thiết lập các transition (chuyển cảnh) giữa các animation để tạo sự linh hoạt cho các hành động của nhân vật.
- Kiểm tra tính đồng nhất giữa các animation trong quá trình chuyển tiếp.

## 4. Tìm Kiếm 2 Website Khác Ngoài Unity Store Cung Cấp Asset

- Tìm và đánh giá thêm 2 trang web cung cấp asset để làm phong phú nguồn tài nguyên cho dự án.
- Một số trang web có thể tham khảo bao gồm:
  - **CGTrader**: Chuyên cung cấp asset 3D.
  - **TurboSquid**: Một trang web uy tín với nhiều asset cho các dự án game và phim.
- Xem xét độ tương thích của các asset với Unity và dự án hiện tại.

 - **Unity Asset Store**: Unity Asset Store là nền tảng chính thức của Unity, cung cấp một kho tàng phong phú các asset phục vụ phát triển game và ứng dụng. Các asset bao gồm 3D models, animations, textures, sound effects, tools, scripts và nhiều thứ khác.
  - **Sketchfab**: Sketchfab là một nền tảng lớn cho phép người dùng tạo, tải lên, và bán các mô hình 3D. Điểm mạnh của Sketchfab là khả năng xem trước mô hình 3D trực tiếp trên trang web, giúp bạn dễ dàng đánh giá trước khi tải về hoặc mua.

## 5. Hỏi AI Cách Sử Dụng Nav Mesh Obstacle

- Tìm hiểu cách sử dụng **NavMesh Obstacle** để chặn đường hoặc tạo vật cản cho các nhân vật điều hướng (navigation) trong game.
- Xem xét cách thiết lập các thuộc tính như "carving" để nhân vật tránh hoặc phản ứng linh hoạt với vật cản.
- Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới.
1. Sử dụng NavMesh Obstacle để chặn đường và tạo vật cản
NavMesh Obstacle là một thành phần (component) dùng để tạo ra các vật cản cho các đối tượng sử dụng NavMesh Agent khi điều hướng. Điều này giúp bạn tạo ra môi trường có các vật cản tĩnh hoặc động mà nhân vật không thể đi xuyên qua.

Các bước sử dụng NavMesh Obstacle:
Tạo một vật cản:

Tạo một đối tượng trong Unity như Cube, Sphere hoặc bất kỳ mô hình 3D nào mà bạn muốn sử dụng làm vật cản.
Ví dụ: Tạo một Cube làm vật cản trong game.
Thêm NavMesh Obstacle:

Chọn đối tượng vật cản vừa tạo và thêm thành phần NavMesh Obstacle bằng cách:
Component > Navigation > NavMesh Obstacle.
Sau khi thêm, đối tượng này sẽ được xem như một vật cản mà các đối tượng sử dụng NavMesh Agent không thể vượt qua.
Điều chỉnh kích thước và vị trí:

Điều chỉnh kích thước và vị trí của đối tượng để phù hợp với cảnh của bạn.
2. Thiết lập thuộc tính "Carving" để tạo phản ứng linh hoạt với vật cản
Thuộc tính Carving trong NavMesh Obstacle rất quan trọng khi bạn muốn tạo ra các vật cản động. Khi kích hoạt Carving, NavMesh sẽ tự động cập nhật và điều chỉnh đường đi xung quanh vật cản động, giúp các nhân vật điều hướng một cách linh hoạt hơn.

Cấu hình thuộc tính Carving:
Carving: Khi thuộc tính này được bật, NavMesh sẽ tạo một khoảng trống xung quanh vật cản trên NavMesh, giúp các đối tượng điều hướng tránh khu vực này. Điều này hữu ích nếu bạn có các vật cản động.
Carving Move Threshold: Thiết lập khoảng cách mà vật cản phải di chuyển trước khi NavMesh được tái tính toán. Điều này giúp tránh việc tính toán lại NavMesh quá thường xuyên, gây giảm hiệu suất.
Carving Time To Stationary: Thiết lập khoảng thời gian trước khi NavMesh Obstacle tạm thời tắt quá trình carving, khi đối tượng không còn di chuyển.
Ví dụ cách sử dụng Carving:
Đối với các vật cản động như cánh cửa hoặc vật rơi xuống, bạn cần bật thuộc tính Carving để NavMesh cập nhật đường đi cho nhân vật một cách liên tục khi vật cản thay đổi vị trí.
Thao tác thực hiện:

Chọn đối tượng đã có NavMesh Obstacle.
Trong bảng thuộc tính NavMesh Obstacle, bật Carving.
Lưu ý: Nếu đối tượng là tĩnh và không di chuyển, bạn không cần bật Carving. Chỉ bật Carving khi đối tượng có thể di chuyển và cần điều chỉnh NavMesh xung quanh nó.

3. Kiểm tra và điều chỉnh hệ thống NavMesh cho phù hợp với các vật cản mới
Sau khi thêm các vật cản bằng NavMesh Obstacle, bạn cần kiểm tra và có thể điều chỉnh lại NavMesh để đảm bảo hệ thống điều hướng hoạt động tốt với các vật cản mới.

Các bước kiểm tra và điều chỉnh:
Bake lại NavMesh:

Sau khi thêm các vật cản tĩnh, bạn nên "bake" lại NavMesh để Unity có thể cập nhật bản đồ điều hướng với các vật cản mới.
Vào Window > AI > Navigation, rồi nhấn Bake để tạo lại NavMesh dựa trên các vật cản mới.
Kiểm tra trong Play Mode:

Chạy game ở Play Mode để kiểm tra xem các đối tượng điều hướng có tránh các vật cản một cách chính xác hay không.
Với các vật cản động, kiểm tra xem NavMesh có được tái tính toán một cách chính xác khi vật cản di chuyển.
Điều chỉnh các thông số NavMesh Agent:

Nếu cần thiết, điều chỉnh các thông số của NavMesh Agent (nhân vật điều hướng) như Speed, Acceleration, và Stopping Distance để đảm bảo nhân vật phản ứng nhanh nhạy và phù hợp với các vật cản mới.
Ví dụ về điều chỉnh NavMesh Agent:
Radius: Điều chỉnh kích thước bán kính của NavMesh Agent để nhân vật điều hướng tránh các vật cản gần hơn hoặc xa hơn.
Avoidance Priority: Điều chỉnh độ ưu tiên tránh va chạm giữa các NavMesh Agent hoặc giữa NavMesh Agent và vật cản.

### Tóm tắt:
NavMesh Obstacle giúp tạo ra các vật cản tĩnh hoặc động trong game.
Sử dụng thuộc tính Carving để NavMesh tự động tái tính toán khi có vật cản động.
Kiểm tra và điều chỉnh lại hệ thống NavMesh sau khi thêm các vật cản mới bằng cách Bake lại và điều chỉnh thông số của NavMesh Agent để đảm bảo nhân vật điều hướng tốt trong môi trường mới.