# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
 - Max int: 2147483647
 - Max float: 3.402823E+38
 - Max double: 1.79769313486232E+308
## 2. Nhờ AI Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
Tuần 1: Làm quen với Unity và C#
Ngày 1-2: Cài đặt và khám phá giao diện Unity
Cài đặt Unity và Visual Studio 2022:
Tải và cài đặt Unity Hub, sau đó cài phiên bản Unity LTS.
Đảm bảo bạn đã cài đặt tích hợp Unity trong Visual Studio 2022.
Khám phá giao diện Unity:
Mở Unity và tạo một dự án mới.
Tìm hiểu các phần:
Hierarchy (cây đối tượng trong cảnh),
Scene (cảnh 3D hoặc 2D),
Inspector (thuộc tính của đối tượng),
Game View (chế độ xem trò chơi khi chạy thử).
Hiểu cách thêm đối tượng vào Scene (vd: 3D Plane, Cube, 2D Sprites).
Ngày 3-4: Cơ bản về C# trong Unity
Tạo và thêm script C#:
Tạo một script đơn giản bằng cách thêm C# Script vào một đối tượng.
Học cách sử dụng vòng đời Unity (Start(), Update()).
Cơ bản về di chuyển và tương tác:
Viết một script đơn giản để di chuyển đối tượng trong không gian 3D bằng cách thay đổi các thuộc tính của transform.
Thực hành tương tác với đối tượng khác bằng cách tạo va chạm (collision) và vật lý (physics).
Ngày 5-7: Bắt đầu dự án Tower Defense
Tạo một scene cơ bản:
Tạo một Plane làm mặt đất và các Cube làm tháp (tower).
Xây dựng một hệ thống đơn giản để chọn vị trí đặt tháp (vd: nhấn chuột để chọn nơi đặt tháp).
Thêm camera:
Thiết lập camera để người chơi có thể nhìn toàn bộ chiến trường.
Tuần 2: Xây dựng các cơ chế cơ bản của Tower Defense
Ngày 8-9: Hệ thống xây dựng tháp
Hệ thống chọn vị trí đặt tháp:
Tạo một đối tượng "tháp" với các thuộc tính cơ bản.
Viết script cho phép người chơi chọn các vị trí cố định để đặt tháp (sử dụng Raycast từ camera để lấy vị trí chuột).
Xử lý việc đặt tháp:
Viết script để kiểm tra xem vị trí đã có tháp hay chưa và cho phép/thực hiện việc đặt tháp.
Ngày 10-11: Tạo kẻ địch
Tạo đối tượng kẻ địch:
Tạo một đối tượng Enemy (có thể dùng 3D Cube ban đầu) và thêm RigidBody để có vật lý cơ bản.
Thiết lập hệ thống đường đi:
Tạo các điểm đường đi (waypoints) và viết script để kẻ địch di chuyển từ điểm này đến điểm khác.
Kẻ địch sẽ di chuyển từ vị trí sinh ra (spawn point) đến điểm kết thúc (end point).
Ngày 12-14: Học vật lý và hệ thống va chạm
Tạo đạn (projectile):
Tạo một đối tượng đạn đơn giản (vd: sphere nhỏ) và viết script để tháp bắn đạn về phía kẻ địch.
Xử lý va chạm:
Sử dụng Collider và RigidBody để xác định va chạm giữa đạn và kẻ địch.
Khi đạn trúng kẻ địch, kẻ địch sẽ bị giảm máu hoặc phá hủy.
Tuần 3: Nâng cấp lối chơi và tính năng
Ngày 15-17: Cải tiến cơ chế bắn
Tự động bắn kẻ địch:

Viết script để tháp tự động phát hiện kẻ địch trong tầm bắn.
Khi kẻ địch trong tầm bắn, tháp sẽ bắn đạn và theo dõi mục tiêu.
Tạo thuộc tính tháp:

Thêm các thuộc tính như tầm bắn, sát thương, và tốc độ bắn vào tháp.
Viết script để điều chỉnh tầm bắn (vd: sử dụng Sphere Collider để phát hiện kẻ địch trong vùng tầm bắn).
Ngày 18-20: Hệ thống nâng cấp tháp
Tạo giao diện nâng cấp:
Thêm UI (như Button) để người chơi có thể chọn nâng cấp tháp.
Logic nâng cấp:
Viết script để khi người chơi nhấn nút, các thuộc tính tháp (sát thương, tốc độ bắn) được tăng lên.
Ngày 21-22: Hệ thống tài nguyên và điểm số
Tạo tài nguyên và hệ thống vàng:

Mỗi lần tiêu diệt kẻ địch, người chơi nhận được một số lượng vàng nhất định.
Sử dụng vàng để xây và nâng cấp tháp.
Hiển thị điểm số và vàng:

Thêm giao diện hiển thị số vàng và điểm số người chơi tích lũy được.
Ngày 23-24: Tạo hệ thống đợt tấn công (Waves)
Hệ thống cấp độ (waves):

Viết script để tạo ra các đợt tấn công (waves) với số lượng và loại kẻ địch khác nhau.
Sau mỗi wave, số lượng và độ khó của kẻ địch sẽ tăng lên.
Thêm yếu tố khó khăn:

Tăng dần độ khó bằng cách thay đổi tốc độ, lượng máu, và số lượng kẻ địch.
Tuần 4: Hoàn thiện trò chơi và tối ưu hóa
Ngày 25-27: Hoàn thiện UI
Tạo menu chính:
Thêm một menu đơn giản với các nút Start, Options, Exit.
Giao diện trong game:
Thêm HUD (hiển thị thông tin như số vàng, điểm số, số lượng kẻ địch còn lại).
Thêm màn hình chiến thắng/thất bại (Victory/Defeat screen) khi hoàn thành hoặc thua cuộc.
Ngày 28-29: Cải thiện trải nghiệm người chơi
Thêm âm thanh:
Tải và thêm các hiệu ứng âm thanh như âm thanh bắn, nổ, và nhạc nền.
Hiệu ứng hình ảnh:
Thêm các hiệu ứng như nổ tung khi kẻ địch bị tiêu diệt hoặc khi đạn va chạm.
Ngày 30: Kiểm tra, sửa lỗi và xuất bản
Kiểm tra và sửa lỗi:
Chơi thử trò chơi, kiểm tra lỗi (bugs) và cân bằng trò chơi.
Đảm bảo các hệ thống hoạt động mượt mà và không có lỗi lớn.
Xuất bản game:
Học cách build game thành file .exe (hoặc build lên WebGL nếu muốn chơi trực tiếp trên trình duyệt).
Chia sẻ dự án lên các nền tảng như Itch.io hoặc lưu trữ trên GitHub.
Các tài nguyên bổ sung
Tài liệu Unity chính thức: https://docs.unity3d.com/
Kho asset miễn phí: Unity Asset Store (Free section)
Hướng dẫn từ Brackeys: Brackeys Tower Defense Tutorial
Kế hoạch này chi tiết hóa từng nhiệm vụ hàng ngày để bạn có thể theo dõi và hoàn thành mục tiêu tạo ra một trò chơi Tower Defense trong 1 tháng.
## 3. Khai Báo Thêm 5 Methods Cho Class Enemy
file Enemy.cs
## 4. Khai Báo Thêm 5 Biến Cho Class Enemy
file Enemy.cs


## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`

- Câu lệnh int[] scores = new int[10]; trong C# thực hiện việc khai báo và khởi tạo một mảng số nguyên. Dưới đây là giải thích chi tiết về câu lệnh này:

- int[]: Đây là cú pháp để khai báo một mảng chứa các phần tử có kiểu dữ liệu int (số nguyên). Dấu ngoặc vuông [] thể hiện rằng biến scores sẽ là một mảng, chứ không phải một biến đơn lẻ.

- scores: Đây là tên của mảng. Bạn có thể đặt tên này tùy ý theo quy tắc đặt tên biến trong C#.

- new int[10]: Cụm từ này tạo ra một mảng mới có 10 phần tử. Từ khóa new được sử dụng để khởi tạo mảng mới trong bộ nhớ. Trong đó:

   - int chỉ ra rằng mảng sẽ chứa các giá trị kiểu int.
   - [10] xác định rằng mảng sẽ có 10 phần tử. Các chỉ số (index) trong mảng sẽ bắt đầu từ 0 và kết thúc tại 9 (tức là 10 phần tử với chỉ số từ 0 đến 9).
- Mặc định giá trị của các phần tử: Khi bạn khởi tạo mảng với new int[10], các phần tử trong mảng sẽ mặc định có giá trị là 0 (giá trị mặc định của kiểu int).

Ví dụ về cách sử dụng mảng này:
```
int[] scores = new int[10];  // Khởi tạo mảng với 10 phần tử

// Gán giá trị cho từng phần tử trong mảng
scores[0] = 100;
scores[1] = 200;

// Truy xuất giá trị từ mảng
Debug.Log(scores[0]);  // In ra 100
Debug.Log(scores[1]);  // In ra 200
```

## 6. Nhờ AI Giải Thích Về Rigidbody

- Trong Unity, Rigidbody là một thành phần (component) dùng để mô phỏng vật lý thực tế cho các đối tượng 3D. Khi bạn thêm Rigidbody vào một đối tượng, Unity sẽ áp dụng các quy tắc vật lý như trọng lực, va chạm và ma sát lên đối tượng đó, làm cho nó có thể tương tác với môi trường xung quanh theo cách tự nhiên.

### Các khái niệm chính về Rigidbody:
- Trọng lực (Gravity):

Nếu Rigidbody được gắn vào đối tượng và bật tùy chọn "Use Gravity", đối tượng sẽ bị ảnh hưởng bởi lực hấp dẫn (gravity), làm nó rơi xuống đất hoặc bị kéo về phía trọng lực (thường là hướng xuống).
Bạn có thể bật/tắt trọng lực bằng cách sử dụng thuộc tính useGravity.
Động lực học (Kinematics):

Khi một đối tượng có Rigidbody, nó có thể chuyển động và tương tác với các đối tượng khác thông qua các lực tác động như đẩy, kéo, hoặc va chạm.
Nếu bạn đặt thuộc tính isKinematic thành true, đối tượng sẽ không bị ảnh hưởng bởi lực hay va chạm, nhưng bạn vẫn có thể di chuyển nó thông qua mã lập trình.
Lực và Mômen lực (Force and Torque):

Bạn có thể áp dụng lực (force) để đẩy hoặc kéo một đối tượng trong Unity bằng cách sử dụng phương thức AddForce(). Điều này có thể được sử dụng để tạo ra các chuyển động vật lý như nhảy, đẩy đối tượng hoặc va chạm.
Tương tự, AddTorque() được sử dụng để làm đối tượng xoay.
Va chạm (Collision):

Đối tượng có Rigidbody sẽ tương tác với các đối tượng khác có collider. Khi có va chạm giữa các đối tượng, Unity sẽ xử lý phản hồi dựa trên luật vật lý như phản lực và ma sát.
Tùy chỉnh các thuộc tính vật lý:

Mass: Khối lượng của đối tượng, ảnh hưởng đến mức độ dễ dàng mà lực có thể đẩy hoặc kéo nó.
Drag: Mức độ cản trở đối với chuyển động của đối tượng (ma sát với không khí).
Angular Drag: Mức độ cản trở chuyển động xoay của đối tượng.
### Một số phương thức và thuộc tính chính của Rigidbody:
 - AddForce(Vector3 force): Thêm một lực vào đối tượng để nó di chuyển theo hướng và cường độ được chỉ định.
 - AddTorque(Vector3 torque): Thêm một mômen lực làm cho đối tượng xoay.
 - velocity: Tốc độ hiện tại của đối tượng.
 - angularVelocity: Tốc độ xoay của đối tượng.
 - mass: Khối lượng của đối tượng.
 - drag và angularDrag: Điều chỉnh mức độ ma sát của đối tượng khi di chuyển và xoay.

 ### Ví dụ sử dụng Rigidbody:
 ```
 public class MoveObject : MonoBehaviour
{
    public float forceAmount = 500f;
    private Rigidbody rb;

    void Start()
    {
        // Lấy thành phần Rigidbody từ đối tượng hiện tại
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nếu nhấn phím cách (space), áp dụng một lực đẩy đối tượng lên trên
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceAmount);
        }
    }
}
 ```
Trong ví dụ này, khi nhấn phím cách (space), một lực được áp dụng lên đối tượng, làm cho nó bay lên trên.

Kết luận:
Rigidbody là thành phần giúp mô phỏng vật lý cho các đối tượng 3D trong Unity.
Nó cho phép các đối tượng phản ứng với trọng lực, lực tác động, va chạm, và ma sát.
Bạn có thể điều chỉnh các thuộc tính vật lý như khối lượng, lực kéo, và mômen để thay đổi hành vi của đối tượng trong thế giới 3D.

## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
Để chia lấy dư một số trong C#, bạn có thể sử dụng toán tử modulus (%). Toán tử này trả về phần dư của phép chia giữa hai số.
Cú pháp:
```
int remainder = a % b;
```
a: Số bị chia.
b: Số chia.
remainder: Phần dư của phép chia a / b.
Ví dụ:
```
int number = 17;
int divisor = 5;
int remainder = number % divisor;

Debug.Log("Phần dư của 17 chia cho 5 là: " + remainder);
```
Kết quả:

```
Phần dư của 17 chia cho 5 là: 2
```
Một số điểm lưu ý:
Nếu a nhỏ hơn b, phần dư sẽ là chính số a.
Nếu b bằng 0, phép chia sẽ gây ra lỗi DivideByZeroException, vì không thể chia cho 0.
## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
double: Số thực dấu phẩy động chính xác cao hơn (64-bit).
byte: Số nguyên 8-bit, giá trị từ 0 đến 255.
long: Số nguyên 64-bit.
List: Danh sách động cho phép thêm/xóa phần tử linh hoạt 
Array: Mảng dữ liệu của một kiểu nhất định (vd: int[], float[])


## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác

- ?:: Phép toán điều kiện
int x = (5 > 3) ? 10 : 20; // Kết quả: 10
- ??: Trả về giá trị bên phải nếu giá trị bên trái là null
string name = null;
string result = name ?? "Unknown"; // Kết quả: "Unknown"
- !: Phép phủ định logic
bool result = !(5 > 3); // Kết quả: false