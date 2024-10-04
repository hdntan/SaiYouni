using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng foreach để in tất cả các phần tử trong mảng

        foreach (int number in numbers)
        {
            Debug.Log("Phần tử trong mảng: " + number);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
       
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Khởi tạo biến tổng
        int sum = 0;

        // Sử dụng vòng lặp foreach để tính tổng tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            sum += number;
        }

        // In tổng ra console
        Debug.Log("Tổng của các phần tử trong mảng: " + sum);
    
}

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 3, 9, 2, 8, 7, 1, 10, 4, 6 };

        // Giả định phần tử lớn nhất là phần tử đầu tiên
        int max = numbers[0];

        // Sử dụng vòng lặp foreach để tìm phần tử lớn nhất trong mảng
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // In phần tử lớn nhất ra console
        Debug.Log("Phần tử lớn nhất trong mảng: " + max);
    

    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 3, 9, 2, 8, 7, 1, 10, 4, 6 };

        // Khởi tạo biến để đếm số lượng số chẵn
        int evenCount = 0;

        // Sử dụng vòng lặp foreach để đếm số lượng phần tử chẵn trong mảng
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // In số lượng phần tử chẵn ra console
        Debug.Log("Số lượng phần tử chẵn trong mảng: " + evenCount);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>()
        {
            "Xin chào",
            "Unity",
            "C#",
            "Lập trình",
            "Học vui"
        };

        // Sử dụng vòng lặp foreach để in tất cả các chuỗi trong danh sách
        foreach (string str in stringList)
        {
            Debug.Log("Chuỗi trong danh sách: " + str);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>()
        {
            "Xin chào",
            "Unity",
            "Lập trình C#",
            "Tìm chuỗi dài nhất",
            "Học vui"
        };

        // Khởi tạo biến để giữ chuỗi dài nhất, bắt đầu bằng chuỗi đầu tiên
        string longestString = stringList[0];

        // Sử dụng vòng lặp foreach để tìm chuỗi dài nhất trong danh sách
        foreach (string str in stringList)
        {
            if (str.Length > longestString.Length)
            {
                longestString = str;
            }
        }

        // In chuỗi dài nhất ra console
        Debug.Log("Chuỗi dài nhất trong danh sách: " + longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 3, 9, 2, 8, 7, 1, 10, 4, 6 };

        // Khởi tạo biến tổng cho các số lẻ
        int sumOdd = 0;

        // Sử dụng vòng lặp foreach để tính tổng tất cả các số lẻ trong mảng
        foreach (int number in numbers)
        {
            if (number % 2 != 0) // Kiểm tra nếu số đó là số lẻ
            {
                sumOdd += number;
            }
        }

        // In tổng các số lẻ ra console
        Debug.Log("Tổng của các số lẻ trong mảng: " + sumOdd);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 3, 9, 2, 8, 7, 1, 10, 4, 6 };

        // Sử dụng vòng lặp foreach để in tất cả các số chẵn trong mảng
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Kiểm tra nếu số đó là số chẵn
            {
                Debug.Log("Số chẵn trong mảng: " + number);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 3, 9, 2, 8, 7, 1, 10, 4, 6 };

        // Phần tử cần kiểm tra
        int elementToCheck = 7;

        // Biến cờ để lưu kết quả kiểm tra
        bool exists = false;

        // Sử dụng vòng lặp foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int number in numbers)
        {
            if (number == elementToCheck)
            {
                exists = true;
                break; // Thoát khỏi vòng lặp nếu tìm thấy phần tử
            }
        }

        // In kết quả ra console
        if (exists)
        {
            Debug.Log("Phần tử " + elementToCheck + " tồn tại trong mảng.");
        }
        else
        {
            Debug.Log("Phần tử " + elementToCheck + " không tồn tại trong mảng.");
        }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -5, 3, -9, 2, -8, 7, -1, 10, -4, 6 };

        // Biến để đếm số lượng phần tử âm
        int negativeCount = 0;

        // Sử dụng vòng lặp foreach để đếm số lượng các phần tử âm trong mảng
        foreach (int number in numbers)
        {
            if (number < 0) // Kiểm tra nếu phần tử là số âm
            {
                negativeCount++;
            }
        }

        // In kết quả ra console
        Debug.Log("Số lượng phần tử âm trong mảng: " + negativeCount);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 15, 9, 12, 8, 22, 7, 10, 14, 3, 20 };

        // Sử dụng vòng lặp foreach để in các số lớn hơn 10 trong mảng
        Debug.Log("Các số lớn hơn 10 trong mảng:");
        foreach (int number in numbers)
        {
            if (number > 10) // Kiểm tra nếu phần tử lớn hơn 10
            {
                Debug.Log(number);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string> { "apple", "banana", "kiwi", "grapefruit", "fig", "pear" };

        // Biến để lưu chuỗi ngắn nhất, khởi tạo với chuỗi đầu tiên trong danh sách
        string shortestString = stringList[0];

        // Sử dụng vòng lặp foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        foreach (string str in stringList)
        {
            if (str.Length < shortestString.Length) // Kiểm tra xem độ dài của chuỗi hiện tại có nhỏ hơn chuỗi ngắn nhất không
            {
                shortestString = str; // Cập nhật chuỗi ngắn nhất
            }
        }

        // In chuỗi ngắn nhất ra console
        Debug.Log("Chuỗi có độ dài ngắn nhất trong danh sách: " + shortestString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        Debug.Log("Các phần tử sau khi nhân đôi:");
        foreach (int number in numbers)
        {
            int doubledNumber = number * 2; // Nhân đôi phần tử
            Debug.Log(doubledNumber); // In ra phần tử đã nhân đôi
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 2, 8, 1, 9, 3, 7 };

        // Biến để lưu số lớn nhất và số lớn thứ hai
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach (int number in numbers)
        {
            if (number > largest) // Nếu số hiện tại lớn hơn số lớn nhất
            {
                secondLargest = largest; // Cập nhật số lớn thứ hai
                largest = number; // Cập nhật số lớn nhất
            }
            else if (number > secondLargest && number != largest) // Nếu số hiện tại lớn hơn số lớn thứ hai và không bằng số lớn nhất
            {
                secondLargest = number; // Cập nhật số lớn thứ hai
            }
        }

        // Kiểm tra và in ra kết quả
        if (secondLargest != int.MinValue) // Nếu có số lớn thứ hai
        {
            Debug.Log("Số lớn thứ hai trong mảng là: " + secondLargest);
        }
        else
        {
            Debug.Log("Không tìm thấy số lớn thứ hai trong mảng.");
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string> { "Apple", "Banana", "Avocado", "Cherry", "Apricot", "Grape" };

        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        Debug.Log("Các chuỗi bắt đầu bằng chữ cái 'A':");
        foreach (string str in stringList)
        {
            if (str.StartsWith("A")) // Kiểm tra xem chuỗi có bắt đầu bằng 'A' không
            {
                Debug.Log(str); // In chuỗi ra console
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string> { "Hi", "Hello", "World", "Unity", "CSharp" };

        // Biến để kiểm tra sự tồn tại của chuỗi "Hello"
        bool containsHello = false;

        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string str in stringList)
        {
            if (str == "Hello") // Kiểm tra xem chuỗi hiện tại có bằng "Hello" không
            {
                containsHello = true; // Nếu có, cập nhật biến containsHello thành true
                break; // Thoát khỏi vòng lặp vì đã tìm thấy chuỗi
            }
        }

        // In kết quả ra console
        if (containsHello)
        {
            Debug.Log("Danh sách chứa chuỗi 'Hello'.");
        }
        else
        {
            Debug.Log("Danh sách không chứa chuỗi 'Hello'.");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -5, 2, -8, 1, -3, 7, -1 };

        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        Debug.Log("Các phần tử âm trong mảng:");
        foreach (int number in numbers)
        {
            if (number < 0) // Kiểm tra xem phần tử có âm không
            {
                Debug.Log(number); // In phần tử âm ra console
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 2, 5, 2, 6 };

        // Phần tử cần đếm số lần xuất hiện
        int targetElement = 2;

        // Biến đếm số lần xuất hiện của phần tử
        int count = 0;

        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        foreach (int number in numbers)
        {
            if (number == targetElement) // Kiểm tra xem phần tử hiện tại có bằng phần tử mục tiêu không
            {
                count++; // Tăng biến đếm lên 1
            }
        }

        // In kết quả ra console
        Debug.Log("Số lần xuất hiện của phần tử " + targetElement + " là: " + count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 12, 8, 15, 3, 22, 9, 10, 11 };

        // Tạo danh sách để lưu các phần tử lớn hơn 10
        List<int> greaterThanTenList = new List<int>();

        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int number in numbers)
        {
            if (number > 10) // Kiểm tra xem phần tử có lớn hơn 10 không
            {
                greaterThanTenList.Add(number); // Thêm phần tử vào danh sách
            }
        }

        // In các phần tử trong danh sách ra console
        Debug.Log("Các phần tử lớn hơn 10:");
        foreach (int num in greaterThanTenList)
        {
            Debug.Log(num); // In từng phần tử ra console
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = new List<string>
        {
            "Hello",
            "Unity",
            "Programming",
            "C#",
            "Game Development",
            "Longer String Example",
            "Test"
        };

        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        Debug.Log("Các chuỗi có độ dài lớn hơn 5 ký tự:");
        foreach (string str in strings)
        {
            if (str.Length > 5) // Kiểm tra độ dài của chuỗi
            {
                Debug.Log(str); // In chuỗi ra console
            }
        }
    }

}
