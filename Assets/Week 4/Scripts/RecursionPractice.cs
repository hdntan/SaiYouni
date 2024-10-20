using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class RecursionPractice : MainBehaviourScript
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


    protected virtual void AddOnClickButtonEvents()
    {
        this.myButton.onClick.AddListener(OnButtonClicked);
    }


    void OnButtonClicked()
    {
         this.BaiTap1();
        //this.BaiTap2();
        // this.BaiTap3();
        //this.BaiTap4();
        //this.BaiTap5();
       



    }

    protected void LoadComponentsCanvas()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();

        this.input1 = canvas.transform.Find("InputField1").GetComponent<TMP_InputField>();
        this.input2 = canvas.transform.Find("InputField2").GetComponent<TMP_InputField>();
        this.input3 = canvas.transform.Find("InputField3").GetComponent<TMP_InputField>();
        this.checkedToggle1 = canvas.transform.Find("Toggle1").GetComponent<Toggle>();
        this.checkedToggle2 = canvas.transform.Find("Toggle2").GetComponent<Toggle>();

        this.myButton = canvas.transform.Find("Button3").GetComponent<Button>();






    }


    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính giai thừa của n
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập một số nguyên dương.");
            return;
        }

        
        int n;
        if (int.TryParse(input1.text, out n) && n >= 0)
        {
            
            int result = GiaiThua(n);
            Debug.Log($"Giai thừa của {n} là: {result}");
        }
        else
        {
            Debug.Log("Vui lòng nhập một số nguyên dương hợp lệ.");
        }
    }

    int GiaiThua(int n)
    {
        
        if (n <= 1)
            return 1;

   
        return n * GiaiThua(n - 1);
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập một số nguyên dương.");
            return;
        }

       
        int n;
        if (int.TryParse(input1.text, out n) && n >= 1)
        {
            
            int result = Sum(n);
            Debug.Log($"Tổng các số từ 1 đến {n} là: {result}");
        }
        else
        {
            Debug.Log("Vui lòng nhập một số nguyên dương hợp lệ.");
        }
    }

    int Sum(int n)
    {
        // Điều kiện dừng: nếu n == 1, trả về 1
        if (n == 1)
            return 1;

        // Công thức đệ quy: Tổng từ 1 đến n = n + Tổng từ 1 đến (n - 1)
        return n + Sum(n - 1);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập một số nguyên.");
            return;
        }

        
        int n;
        if (int.TryParse(input1.text, out n) && n >= 0)
        {
            
            int result = Fibonacci(n);
            Debug.Log($"Số Fibonacci thứ {n} là: {result}");
        }
        else
        {
            Debug.Log("Vui lòng nhập một số nguyên không âm hợp lệ.");
        }
    }

    int Fibonacci(int n)
    {
       
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
        
        if (string.IsNullOrEmpty(input1.text))
        {
            Debug.Log("Vui lòng nhập một số nguyên dương.");
            return;
        }

        int n;
        if (int.TryParse(input1.text, out n) && n > 0)
        {
           
            Debug.Log($"Đếm ngược từ {n}:");
            Countdown(n);
        }
        else
        {
            Debug.Log("Vui lòng nhập một số nguyên dương hợp lệ.");
        }
    }

    void Countdown(int n)
    {
        
        if (n <= 0)
        {
            return;
        }

      
        Debug.Log(n);

       
        Countdown(n - 1);
    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        
        if (string.IsNullOrEmpty(input1.text) || string.IsNullOrEmpty(input2.text))
        {
            Debug.Log("Vui lòng nhập cả hai số nguyên.");
            return;
        }

       
        int a, b;
        if (int.TryParse(input1.text, out a) && int.TryParse(input2.text, out b))
        {
            
            int result = UCLN(a, b);
            Debug.Log($"UCLN của {a} và {b} là: {result}");
        }
        else
        {
            Debug.Log("Vui lòng nhập hai số nguyên hợp lệ.");
        }
    }
    int UCLN(int a, int b)
    {
       
        if (b == 0)
            return a;

        
        return UCLN(b, a % b);
    }
}
