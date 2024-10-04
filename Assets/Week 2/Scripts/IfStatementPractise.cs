using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class IfStatementPractise : MonoBehaviour
{
    public TextMeshProUGUI textOutput;
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;





    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    public void BaiTap1()
    {
        string input = input1.text; // Lấy dữ liệu từ InputField
        int number;

        // Chuyển đổi chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(input, out number);

        if (isValid)
        {
            if (number > 0)
            {
                textOutput.text = "Số bạn vừa nhập là số dương.";
            }
            else if (number < 0)
            {
                textOutput.text = "Số bạn vừa nhập là số âm.";
            }
            else
            {
                textOutput.text = "Số bạn vừa nhập là bằng 0.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một số nguyên hợp lệ.";
        }
    }



    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    public   void BaiTap2()
    {
        string input = input1.text; // Lấy dữ liệu từ InputField
        int number;

        // Chuyển đổi chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(input, out number);

        if (isValid)
        {
            if (number % 2 == 0)
            {
                textOutput.text = "Số bạn vừa nhập là số chẵn.";
            }
            else
            {
                textOutput.text = "Số bạn vừa nhập là số lẻ.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một số nguyên hợp lệ.";
        }
    }

    public void BaiTap3()
    {
        string input = input1.text; // Lấy dữ liệu từ InputField
        int number;

        // Chuyển đổi chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(input, out number);

        if (isValid)
        {
            // Kiểm tra nếu điểm trung bình >= 5.0
            if (number >= 5.0f)
            {
                textOutput.text = "Học sinh đã đỗ.";
            }
            else
            {
                textOutput.text = "Học sinh đã trượt.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một điểm hợp lệ.";
        }
    }


    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    public void BaiTap4()
    {
        string numberInput1 = input1.text; // Lấy số đầu tiên từ InputField1
        string numberInput2 = input2.text; // Lấy số thứ hai từ InputField2

        int number1, number2;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid1 = int.TryParse(numberInput1, out number1);
        bool isValid2 = int.TryParse(numberInput2, out number2);

        if (isValid1 && isValid2)
        {
            // So sánh hai số và tìm số lớn nhất
            if (number1 > number2)
            {
                textOutput.text = "Số lớn nhất là: " + number1;
            }
            else if (number2 > number1)
            {
                textOutput.text = "Số lớn nhất là: " + number2;
            }
            else
            {
                textOutput.text = "Hai số bằng nhau.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập hai số nguyên hợp lệ.";
        }
    }

    public void BaiTap5()
    {
        string moneyInput = input1.text;  // Lấy số tiền hiện có từ InputField
        string priceInput = input2.text;  // Lấy giá sản phẩm từ InputField

        float money, price;

        // Chuyển đổi chuỗi nhập vào thành số thực (float) và kiểm tra tính hợp lệ
        bool isValidMoney = float.TryParse(moneyInput, out money);
        bool isValidPrice = float.TryParse(priceInput, out price);

        if (isValidMoney && isValidPrice)
        {
            // Kiểm tra xem người dùng có đủ tiền để mua sản phẩm không
            if (money >= price)
            {
                textOutput.text = "Bạn có đủ tiền để mua hàng.";
            }
            else
            {
                textOutput.text = "Bạn không đủ tiền để mua hàng.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập số tiền và giá sản phẩm hợp lệ.";
        }
    }


    public void BaiTap6()
    {
        string yearInput = input1.text; // Lấy dữ liệu từ InputField
        int year;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(yearInput, out year);

        if (isValid)
        {
            // Kiểm tra xem năm có phải năm nhuận không
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                textOutput.text = "Năm " + year + " là năm nhuận.";
            }
            else
            {
                textOutput.text = "Năm " + year + " không phải là năm nhuận.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một năm hợp lệ.";
        }
    }

    public void BaiTap7()
    {
        string ageInput = input1.text; // Lấy dữ liệu từ InputField
        int age;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(ageInput, out age);

        if (isValid)
        {
            // Kiểm tra điều kiện tuổi để tính giá vé
            if (age < 18)
            {
                textOutput.text = "Giá vé của bạn là 50,000 đồng.";
            }
            else
            {
                textOutput.text = "Giá vé của bạn là 100,000 đồng.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một tuổi hợp lệ.";
        }
    }

    public void BaiTap8()
    {
        string scoreInput = input1.text;  // Lấy dữ liệu từ InputField
        float score;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(scoreInput, out score);

        if (isValid)
        {
            // Kiểm tra nếu điểm trung bình >= 9.0
            if (score >= 9.0f)
            {
                textOutput.text = "Học sinh đạt danh hiệu xuất sắc.";
            }
            else
            {
                textOutput.text = "Học sinh không đạt danh hiệu xuất sắc.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập một điểm trung bình hợp lệ.";
        }
    }


    public void BaiTap9()
    {
        string nuberInput1 = input1.text;  // Lấy dữ liệu từ InputField 1
        string nuberInput2 = input2.text;  // Lấy dữ liệu từ InputField 2
        string nuberInput3 = input3.text;  // Lấy dữ liệu từ InputField 3

        int number1, number2, number3;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid1 = int.TryParse(nuberInput1, out number1);
        bool isValid2 = int.TryParse(nuberInput2, out number2);
        bool isValid3 = int.TryParse(nuberInput3, out number3);

        if (isValid1 && isValid2 && isValid3)
        {
            // Kiểm tra và tìm số lớn nhất
            int max = number1;

            if (number2 > max)
            {
                max = number2;
            }

            if (number3 > max)
            {
                max = number3;
            }

            textOutput.text = "Số lớn nhất là: " + max;
        }
        else
        {
            textOutput.text = "Vui lòng nhập ba số nguyên hợp lệ.";
        }
    }


    public void BaiTap10()
    {
        string hoursInput = input1.text;  // Lấy số giờ làm việc từ InputField
        string wageInput = input2.text;    // Lấy mức lương cố định từ InputField

        float hoursWorked, hourlyWage;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValidHours = float.TryParse(hoursInput, out hoursWorked);
        bool isValidWage = float.TryParse(wageInput, out hourlyWage);

        if (isValidHours && isValidWage)
        {
            float salary;

            // Kiểm tra nếu làm việc trên 40 giờ, tính thêm giờ
            if (hoursWorked > 40)
            {
                float overtimeHours = hoursWorked - 40;
                salary = (40 * hourlyWage) + (overtimeHours * hourlyWage * 1.5f);  // Lương ngoài giờ = 1.5 lần lương bình thường
            }
            else
            {
                salary = hoursWorked * hourlyWage;  // Lương tính theo giờ bình thường
            }

            textOutput.text = "Tổng lương: " + salary.ToString("N0") + " đồng";
        }
        else
        {
            textOutput.text = "Vui lòng nhập số giờ làm việc và mức lương hợp lệ.";
        }
    }

    public void BaiTap11()
    {
        string ageInput = input1.text; // Lấy dữ liệu tuổi từ InputField
        int age;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(ageInput, out age);


        if (isValid)
        {
            // Kiểm tra điều kiện vào câu lạc bộ: trên 18 tuổi và có thẻ thành viên
            if (age > 18)
            {
                textOutput.text = "Bạn đủ điều kiện vào câu lạc bộ.";
            }
            else
            {
                textOutput.text = "Bạn không đủ điều kiện vào câu lạc bộ.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập tuổi hợp lệ.";
        }
    }

    public void BaiTap12()
    {
        string scoreInput = input1.text;  // Lấy dữ liệu từ InputField
        float score;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(scoreInput, out score);

        if (isValid)
        {
            string classification;

            // Phân loại học sinh theo điểm
            if (score >= 9.0f)
            {
                classification = "Xuất sắc";
            }
            else if (score >= 8.0f)
            {
                classification = "Giỏi";
            }
            else if (score >= 6.5f)
            {
                classification = "Khá";
            }
            else if (score >= 5.0f)
            {
                classification = "Trung bình";
            }
            else
            {
                classification = "Yếu";
            }

            textOutput.text = "Phân loại học sinh: " + classification;
        }
        else
        {
            textOutput.text = "Vui lòng nhập một điểm trung bình hợp lệ.";
        }
    }

    public void BaiTap13()
    {
        string electricityInput = input1.text;  // Lấy số điện tiêu thụ từ InputField
        float electricityUsed;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(electricityInput, out electricityUsed);

        if (isValid)
        {
            float bill;

            // Tính tiền điện theo công thức
            if (electricityUsed <= 100)
            {
                bill = electricityUsed * 1500;  // 1,500 đồng/kWh cho <= 100 kWh
            }
            else
            {
                bill = electricityUsed * 2000;  // 2,000 đồng/kWh cho > 100 kWh
            }

            textOutput.text = "Tổng tiền điện: " + bill.ToString("N0") + " đồng";
        }
        else
        {
            textOutput.text = "Vui lòng nhập số điện tiêu thụ hợp lệ.";
        }
    }

    public void BaiTap14()
    {
        string yearsInput = input1.text;          // Lấy số năm làm việc từ InputField
        string evaluationInput = input2.text; // Lấy đánh giá công việc từ InputField
        int yearsOfService;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValidYears = int.TryParse(yearsInput, out yearsOfService);

        // Kiểm tra điều kiện thăng chức
        if (isValidYears && !string.IsNullOrWhiteSpace(evaluationInput))
        {
            // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá công việc là "Tốt"
            if (yearsOfService > 5 && evaluationInput.Equals("Tốt", System.StringComparison.OrdinalIgnoreCase))
            {
                textOutput.text = "Bạn đủ điều kiện thăng chức.";
            }
            else
            {
                textOutput.text = "Bạn không đủ điều kiện thăng chức.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập số năm làm việc hợp lệ và đánh giá công việc.";
        }
    }


    public void BaiTap15()
    {
        string orderValueInput = input1.text; // Lấy giá trị đơn hàng từ InputField
        float orderValue;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(orderValueInput, out orderValue);

        if (isValid)
        {
            // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng
            if (orderValue >= 500000)
            {
                textOutput.text = "Bạn đủ điều kiện miễn phí vận chuyển.";
            }
            else
            {
                textOutput.text = "Bạn không đủ điều kiện miễn phí vận chuyển.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập giá trị đơn hàng hợp lệ.";
        }
    }


    public void BaiTap16()
    {
        string incomeInput = input1.text; // Lấy thu nhập từ InputField
        float income;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(incomeInput, out income);

        if (isValid)
        {
            float tax;

            // Tính thuế thu nhập cá nhân theo mức thu nhập
            if (income <= 5000000) // Nếu thu nhập <= 5 triệu đồng
            {
                tax = 0; // Miễn thuế
            }
            else if (income <= 10000000) // Nếu thu nhập <= 10 triệu đồng
            {
                tax = income * 0.05f; // 5% thuế
            }
            else if (income <= 18000000) // Nếu thu nhập <= 18 triệu đồng
            {
                tax = income * 0.1f; // 10% thuế
            }
            else // Nếu thu nhập > 18 triệu đồng
            {
                tax = income * 0.2f; // 20% thuế
            }

            textOutput.text = "Thuế thu nhập cá nhân: " + tax.ToString("N0") + " đồng";
        }
        else
        {
            textOutput.text = "Vui lòng nhập thu nhập hợp lệ.";
        }
    }

    public void BaiTap17()
    {
        string scoreInput1 = input1.text; // Lấy điểm bài kiểm tra 1 từ InputField
        string scoreInput2 = input2.text; // Lấy điểm bài kiểm tra 2 từ InputField
        string scoreInput3 = input3.text; // Lấy điểm bài kiểm tra 3 từ InputField

        float score1, score2, score3;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValidScore1 = float.TryParse(scoreInput1, out score1);
        bool isValidScore2 = float.TryParse(scoreInput2, out score2);
        bool isValidScore3 = float.TryParse(scoreInput3, out score3);

        // Kiểm tra tính hợp lệ của tất cả các điểm
        if (isValidScore1 && isValidScore2 && isValidScore3)
        {
            // Tính điểm trung bình
            float averageScore = (score1 + score2 + score3) / 3;

            // Kiểm tra xem học sinh có đạt yêu cầu không
            if (averageScore >= 5.0f)
            {
                textOutput.text = "Điểm trung bình: " + averageScore.ToString("N2") + " - Học sinh đạt yêu cầu.";
            }
            else
            {
                textOutput.text = "Điểm trung bình: " + averageScore.ToString("N2") + " - Học sinh không đạt yêu cầu.";
            }
        }
        else
        {
           textOutput.text = "Vui lòng nhập điểm hợp lệ cho tất cả các bài kiểm tra.";
        }
    }

    public void BaiTap18()
    {
        string currentStockInput = input1.text; // Lấy số lượng hàng hiện tại từ InputField
        int currentStock;

        // Chuyển chuỗi nhập vào thành số nguyên và kiểm tra tính hợp lệ
        bool isValid = int.TryParse(currentStockInput, out currentStock);

        if (isValid)
        {
            // Kiểm tra khả năng nhập thêm hàng
            if (currentStock < 100)
            {
                textOutput.text = "Bạn có thể nhập thêm hàng.";
            }
            else
            {
                textOutput.text = "Bạn không thể nhập thêm hàng (đã đủ 100 hàng).";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập số lượng hàng hợp lệ.";
        }
    }

    public void BaiTap19()
    {
        string numberInput = input1.text; // Lấy số nhập từ InputField
        float number;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValid = float.TryParse(numberInput, out number);

        if (isValid)
        {
            // Kiểm tra xem số đó có lớn hơn 10 hay không
            if (number > 10)
            {
                textOutput.text = "Số " + number.ToString("N2") + " lớn hơn 10.";
            }
            else
            {
                textOutput.text = "Số " + number.ToString("N2") + " không lớn hơn 10.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập số hợp lệ.";
        }
    }

    public void BaiTap20()
    {
        string finalScoreInput = input1.text; // Lấy điểm tổng kết từ InputField
        string attendanceInput =input2.text;   // Lấy tỷ lệ tham gia từ InputField

        float finalScore;
        float attendance;

        // Chuyển chuỗi nhập vào thành số thực và kiểm tra tính hợp lệ
        bool isValidScore = float.TryParse(finalScoreInput, out finalScore);
        bool isValidAttendance = float.TryParse(attendanceInput, out attendance);

        // Kiểm tra tính hợp lệ của điểm tổng kết và tỷ lệ tham gia
        if (isValidScore && isValidAttendance)
        {
            // Kiểm tra điều kiện đăng ký khóa học nâng cao
            if (finalScore >= 8.0f && attendance >= 75.0f)
            {
                textOutput.text = "Học sinh đủ điều kiện đăng ký khóa học nâng cao.";
            }
            else
            {
                textOutput.text = "Học sinh không đủ điều kiện đăng ký khóa học nâng cao.";
            }
        }
        else
        {
            textOutput.text = "Vui lòng nhập điểm tổng kết và tỷ lệ tham gia hợp lệ.";
        }
    }

}






