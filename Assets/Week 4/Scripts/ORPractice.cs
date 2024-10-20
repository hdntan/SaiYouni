using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ORPractice : MainBehaviourScript
{


    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;
    public Toggle checkedToggle1;
    public Toggle checkedToggle2;
    public Toggle checkedToggle3;


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
        this.checkedToggle3 = canvas.transform.Find("Toggle3").GetComponent<Toggle>();


        this.myButton = canvas.transform.Find("Button2").GetComponent<Button>();






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

   

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        string ticket = input1.text; 
        bool isVipMember = checkedToggle1.isOn; 
        bool isInvited = checkedToggle2.isOn; 

        // Kiểm tra nếu thông tin vé đã được nhập
        if (string.IsNullOrEmpty(ticket))
        {
            Debug.Log("Vui lòng nhập thông tin vé.");
            return; 
        }

       
        if (!string.IsNullOrEmpty(ticket) || isVipMember || isInvited)
        {
            Debug.Log("Bạn có thể vào sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện vào sự kiện.");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        int ticketNumber;

        
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập số vé.");
            return; // Dừng phương thức nếu không có dữ liệu
        }

       
        if (int.TryParse(input1.text, out ticketNumber))
        {
            
            if (ticketNumber == 1 || ticketNumber == 2 || ticketNumber == 3) 
            {
                Debug.Log("Bạn đã trúng thưởng!");
            }
            else
            {
                Debug.Log("Bạn không trúng thưởng.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập số vé hợp lệ.");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh

        float income;

        
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập thu nhập.");
            return; 
        }

       
        if (float.TryParse(input1.text, out income))
        {
            bool hasCollateral = checkedToggle1.isOn; 
            bool hasGuarantor = checkedToggle2.isOn;

           
            if (income > 0 || hasCollateral || hasGuarantor) 
            {
                Debug.Log("Bạn đủ điều kiện vay tiền.");
            }
            else
            {
                Debug.Log("Bạn không đủ điều kiện vay tiền.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập giá trị thu nhập hợp lệ.");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        bool hasExcellentAcademic = checkedToggle1.isOn; 
        bool hasGoodExtracurricular = checkedToggle2.isOn; 
        bool isUnderprivileged = checkedToggle3.isOn;

        
        if (hasExcellentAcademic || hasGoodExtracurricular || isUnderprivileged) 
        {
            Debug.Log("Bạn đủ điều kiện nhận học bổng.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện nhận học bổng.");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        string email = input1.text;
        bool isPhoneVerified = checkedToggle1.isOn; // Kiểm tra nếu số điện thoại đã xác thực
        bool isWebsiteRegistered = checkedToggle2.isOn; // Kiểm tra nếu đã đăng ký qua trang web

        // Kiểm tra nếu email không rỗng và hợp lệ
        if (string.IsNullOrEmpty(email))
        {
            Debug.Log("Vui lòng nhập email.");
            return;
        }

        // Kiểm tra điều kiện đăng ký sự kiện
        if (IsValidEmail(email) || isPhoneVerified || isWebsiteRegistered)
        {
            Debug.Log("Bạn có thể đăng ký sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện đăng ký sự kiện.");
        }
    }

    bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return false;


        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }


    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe

        bool hasLicense = checkedToggle1.isOn; 
        bool hasCarRegistration = checkedToggle2.isOn;
        bool hasInsurance = checkedToggle3.isOn;

      
        if (hasLicense || hasCarRegistration || hasInsurance)
        {
            Debug.Log("Bạn có thể lái xe.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện lái xe.");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        bool isAdmin = checkedToggle1.isOn; 
        bool hasManagerPermission = checkedToggle2.isOn; 
        string accessCode = input1.text; 
        
        if (string.IsNullOrEmpty(accessCode) && !isAdmin && !hasManagerPermission)
        {
            Debug.Log("Vui lòng nhập mã xác thực hoặc đảm bảo bạn có quyền truy cập từ quản trị viên hoặc quản lý.");
            return;
        }

       
        if (isAdmin || hasManagerPermission || !string.IsNullOrEmpty(accessCode)) // Điều kiện OR
        {
            Debug.Log("Bạn có quyền truy cập tài liệu.");
        }
        else
        {
            Debug.Log("Bạn không có quyền truy cập tài liệu.");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        bool hasRecommendationLetter = checkedToggle1.isOn; // Kiểm tra nếu có thư giới thiệu từ giáo viên
        bool completedEntranceExam = checkedToggle2.isOn; // Kiểm tra nếu đã hoàn thành bài kiểm tra đầu vào
        bool hasRelevantExperience = checkedToggle3.isOn; // Kiểm tra nếu có kinh nghiệm liên quan

        // Kiểm tra điều kiện tham gia khóa học
        if (hasRecommendationLetter || completedEntranceExam || hasRelevantExperience)
        {
            Debug.Log("Học sinh có thể tham gia khóa học đặc biệt.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện tham gia khóa học đặc biệt.");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        bool hasPromoCode = checkedToggle1.isOn; 
        bool isVIPMember = checkedToggle2.isOn; 
        bool isFreePeriod = checkedToggle3.isOn; 

       
        if (hasPromoCode || isVIPMember || isFreePeriod)
        {
            Debug.Log("Bạn có thể tải ứng dụng miễn phí.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện để tải ứng dụng miễn phí.");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        bool isLoyalCustomer = checkedToggle1.isOn; 
        bool hasPromo = checkedToggle2.isOn; 
        string spendingText = input1.text; 
        float spending;
         float spendingThreshold = 1000f;

       
        if (string.IsNullOrEmpty(spendingText) || !float.TryParse(spendingText, out spending))
        {
            Debug.Log("Vui lòng nhập số tiền chi tiêu hợp lệ.");
            return;
        }

       
        if (spending > spendingThreshold || isLoyalCustomer || hasPromo)
        {
            Debug.Log("Bạn đủ điều kiện sử dụng dịch vụ đặc biệt.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện sử dụng dịch vụ đặc biệt.");
        }
    }
}
