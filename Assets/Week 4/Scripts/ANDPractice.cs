using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ANDPractice : MainBehaviourScript
{


    //public TextMeshProUGUI textOutput;
    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;
    public Toggle checkedToggle1;
    public Toggle checkedToggle2;

    public Button myButton;




    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadComponentsCanvas();
        this.AddOnClickButtonEvents();
    }


    protected void LoadComponentsCanvas()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();

        this.input1 = canvas.transform.Find("InputField1").GetComponent<TMP_InputField>();
        this.input2 = canvas.transform.Find("InputField2").GetComponent<TMP_InputField>();
        this.input3 = canvas.transform.Find("InputField3").GetComponent<TMP_InputField>();
        this.checkedToggle1 = canvas.transform.Find("Toggle1").GetComponent<Toggle>();
        this.checkedToggle2 = canvas.transform.Find("Toggle2").GetComponent<Toggle>();

        this.myButton = canvas.transform.Find("Button").GetComponent<Button>();






    }


    protected virtual void AddOnClickButtonEvents()
    {
        this.myButton.onClick.AddListener(OnButtonClicked);
    }


    void OnButtonClicked()
    {
       // this.BaiTap1();
        this.BaiTap2();
       // this.BaiTap3();
        //this.BaiTap4();
        //this.BaiTap5();
        //this.BaiTap6();
        //this.BaiTap7();
        //this.BaiTap8();
        //this.BaiTap9();
        //this.BaiTap10();



    }
    // Start is called before the first frame update


    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe từ InputField và Toggle
        int age;
        int drivingExperience;

        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập tuổi.");
            return; 
        }

        if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập kinh nghiệm lái xe.");
            return; 
        }


        if (int.TryParse(input1.text, out age) && int.TryParse(input2.text, out drivingExperience))
        {
            bool hasDrivingLicense = checkedToggle1.isOn; 

            if (age > 18 && hasDrivingLicense && drivingExperience > 1)
            {
                Debug.Log("Bạn đủ điều kiện lái xe.");
           
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện lái xe.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập tuổi và kinh nghiệm lái xe hợp lệ.");
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        bool hasTicket = input1.text.Length > 0; // Kiểm tra xem vé có được nhập hay không
        bool isPreRegistered = checkedToggle1.isOn; // Kiểm tra đã đăng ký trước hay không
        bool hasHeartCondition = checkedToggle2.isOn; // Kiểm tra tiền sử bệnh tim

     
        if (hasTicket && isPreRegistered && !hasHeartCondition)
        {
            Debug.Log("Bạn đủ điều kiện vào công viên giải trí.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện vào công viên giải trí.");
        }
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        float gpa;
        float extracurricularScore;

        // Kiểm tra nếu InputField không rỗng và giá trị nhập vào hợp lệ
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập điểm trung bình.");
            return;
        }

        if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập điểm hoạt động ngoại khóa.");
            return; 
        }

      
        if (float.TryParse(input1.text, out gpa) && float.TryParse(input2.text, out extracurricularScore))
        {
            bool hasDisciplinaryViolation = checkedToggle1.isOn; 

          
            if (gpa >= 9.0f && extracurricularScore >= 8.0f && !hasDisciplinaryViolation)
            {
                Debug.Log("Bạn đủ điều kiện nhận học bổng.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện nhận học bổng.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập điểm hợp lệ.");
        }
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        string email = input1.text;
        bool phoneConfirmed = checkedToggle1.isOn;
        bool paymentCompleted = checkedToggle2.isOn;

      
        if (IsValidEmail(email) && phoneConfirmed && paymentCompleted)
        {
            Debug.Log("Đăng ký hợp lệ.");
        }
        else
        {
            Debug.Log("Đăng ký không hợp lệ.");
        }


    }

    bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return false;

      
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        float finalGrade;
        int failedSubjects;
        float attendance;

       
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập điểm tổng kết.");
            return; 
        }

        if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập số môn thi trượt.");
            return; 
        }

        if (string.IsNullOrEmpty(input3.text))
        {
            Debug.Log("Vui lòng nhập điểm chuyên cần.");
            return; 
        }

       
        if (float.TryParse(input1.text, out finalGrade) &&
            int.TryParse(input2.text, out failedSubjects) &&
            float.TryParse(input3.text, out attendance))
        {
           
            if (finalGrade < 5.0f && failedSubjects <= 2 && attendance > 75.0f)
            {
                Debug.Log("Bạn đủ điều kiện thi lại.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện thi lại.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập giá trị hợp lệ cho điểm tổng kết, số môn thi trượt, và điểm chuyên cần.");
        }


    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        int experienceYears;

      
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập số năm kinh nghiệm.");
            return; 
        }

      
        if (int.TryParse(input1.text, out experienceYears))
        {
            bool hasDegree = checkedToggle1.isOn; 
            bool passedAptitudeTest = checkedToggle2.isOn; 

         
            if (hasDegree && experienceYears >= 2 && passedAptitudeTest)
            {
                Debug.Log("Ứng viên đủ điều kiện xét tuyển.");
            }
            else
            {
                Debug.Log("Ứng viên không đủ điều kiện xét tuyển.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập số năm kinh nghiệm hợp lệ.");
        }
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
         float itemPrice = 100.0f;
    float moneyAvailable;

       
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập số tiền hiện có.");
            return; 
        }

     
        if (float.TryParse(input1.text, out moneyAvailable))
        {
            bool inStock = checkedToggle1.isOn; 
            bool promotionEligible = checkedToggle2.isOn; 

           
            if (moneyAvailable >= itemPrice && inStock && promotionEligible)
            {
                Debug.Log("Bạn đủ điều kiện mua hàng.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện mua hàng.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập số tiền hợp lệ.");
        }
    }


    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        int tasksCompleted;
        float averageTaskScore;
        DateTime lastLoginDate;

        
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập số lượng nhiệm vụ đã hoàn thành.");
            return; 
        }

        if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập điểm trung bình nhiệm vụ.");
            return; 
        }

        if (string.IsNullOrEmpty(input3.text))
        {
            Debug.Log("Vui lòng nhập ngày đăng nhập cuối cùng (dạng YYYY-MM-DD).");
            return; 
        }

      
        if (int.TryParse(input1.text, out tasksCompleted) &&
            float.TryParse(input2.text, out averageTaskScore) &&
            DateTime.TryParse(input3.text, out lastLoginDate))
        {
            DateTime currentDate = DateTime.Now; 
            TimeSpan timeSinceLastLogin = currentDate - lastLoginDate; 

           
            if (tasksCompleted >= 10 && averageTaskScore >= 8.0f && timeSinceLastLogin.Days <= 7)
            {
                Debug.Log("Bạn đủ điều kiện nhận phần thưởng.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện nhận phần thưởng.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập giá trị hợp lệ cho số nhiệm vụ, điểm nhiệm vụ và ngày đăng nhập cuối.");
        }
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        int yearsOfWork;

        
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập số năm làm việc.");
            return; 
        }

       
        if (int.TryParse(input1.text, out yearsOfWork))
        {
            bool workTargetAchieved = checkedToggle1.isOn; 
            bool noDisciplinaryAction = checkedToggle2.isOn; 

           
            if (yearsOfWork > 5 && workTargetAchieved && noDisciplinaryAction)
            {
                Debug.Log("Bạn đủ điều kiện thăng chức.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện thăng chức.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập số năm làm việc hợp lệ.");
        }
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        int age;
        int ticketsPurchased;

      
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập tuổi.");
            return;
        }

       
        if (string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập số lần mua vé trong năm.");
            return;
        }

        
        if (int.TryParse(input1.text, out age) && int.TryParse(input2.text, out ticketsPurchased))
        {
            bool isVipMember = checkedToggle1.isOn; 

          
            if (age > 60 && isVipMember && ticketsPurchased >= 3)
            {
                Debug.Log("Bạn đủ điều kiện nhận vé miễn phí.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện nhận vé miễn phí.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập giá trị hợp lệ cho tuổi và số lần mua vé.");
        }
    }
}
